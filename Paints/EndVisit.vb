Public Class EndVisit

    Dim B_EndLoad As Boolean = False
    Dim B_Edited As Boolean = False
    Dim DTemp As Double
    Dim TName As String = "Adjustment_Details"
    Dim RowID, ItmID As Integer
    Dim ItmName, BarCde As String
    Dim ItmPrc As Double
    Dim BDate, BDateExpire As Date
    Dim FStkID, TStkID As Integer
    Dim RptAdj As New Report_Adjustments
    Dim B_ID As Integer
    Dim Total As Integer = 0
    Private BSourceItemStocks As New BindingSource
    Private cmdb As New SqlClient.SqlCommandBuilder

    Sub ResetOrder(ByVal IsNew As Boolean)
        Try
            MyDs.Tables("End_Visit").Rows.Clear()
            If IsNew = False Then

                BtnSave.Enabled = False

                BtnExit.Enabled = True
                B_Edited = False

                BtnSavePrint.Enabled = False

                EmployeeID.Text = EmpNameVar
                EmployeeID.Tag = EmpIDVar

                GroupHeader.Enabled = False
                GroupDetails.Enabled = False
                B_EndLoad = False
                'FStkID = 0
            Else

                BtnSave.Enabled = True
                BtnExit.Enabled = True
                B_Edited = False
                BtnSavePrint.Enabled = True

                EmployeeID.Text = EmpNameVar
                EmployeeID.Tag = EmpIDVar

                GroupHeader.Enabled = True
                GroupDetails.Enabled = True
                B_EndLoad = True
                'FStkID = 0
                BSourceUmDetails.Filter = "item_id = 0"
                BSourceItemStocks.Filter = "item_id = 0 and stock_id = 0"
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Sub Commit_Form()
        Try

            If DataGridView1.Rows.Count <= 0 Then
                cls.MsgExclamation("لا يوجد اصناف في الفاتورة", "there are no items attached to the current document")
            Else
                B_ID = 1

                'CalculateTotalBill()



                If RadioClosed.Checked = True Then

                    BSourceItemStocks.EndEdit()
                    cmd.CommandText = "select * from end_visit"
                    cmdb.DataAdapter = da
                    da.Update(MyDs.Tables("end_visit"))

                    For x As Integer = 0 To DataGridView1.Rows.Count - 1
                        If DataGridView1.Rows(x).Cells("Minus_Balance").Value > 0 Then
                            cls.MsgExclamation("لا يمكن اغلاق الجوله بدون الانتهاء من العجز", "")
                            Exit Sub
                        End If
                    Next

                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        BDateExpire = DataGridView1.Rows(i).Cells("Expired_Date").Value

                        cmd.CommandText = "Exec End_Visit_Transfer " & DataGridView1.Rows(i).Cells("Item_ID").Value & "," & DataGridView1.Rows(i).Cells("balance").Value & _
                        "," & FStkID & "," & TStkID & ", '" & BDateExpire.ToString("MM/dd/yyyy") & "' , '" & BDate.ToString("MM/dd/yyyy") & "'," & DataGridView1.Rows(i).Cells("Price").Value
                        cmd.ExecuteNonQuery()
                    Next


                    cmd.CommandText = "update visit_header set status = N'مغلقه' where visit_id = " & VisitName.Tag
                    cmd.ExecuteNonQuery()


                    B_Edited = False
                    Call ResetOrder(False)

                ElseIf RadioFinished.Checked = True Then

                    BSourceItemStocks.EndEdit()
                    cmd.CommandText = "select * from end_visit"
                    cmdb.DataAdapter = da
                    da.Update(MyDs.Tables("end_visit"))


                End If

                If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
                    cls.MsgInfo("تم حفظ الاذن بنجاح", "Document has been saved successfully")
                    MyDs.Tables("End_Visit").Rows.Clear()
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Commit_Form()

    End Sub

    

    Private Sub Adjustments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
           

            cls.FillSelectedTable("select e.* from employees e,Visit_Header h where h.sales_rep_id = e.employee_id and h.status = N'منتهيه'", "Employees")
            ComboSalesRepID.ComboBox.DataSource = MyDs
            ComboSalesRepID.ComboBox.DisplayMember = "Employees.Employee_Name"
            ComboSalesRepID.ComboBox.ValueMember = "Employees.Employee_ID"


            BSourceItemStocks.DataSource = MyDs
            BSourceItemStocks.DataMember = "End_Visit"
            DataGridView1.DataSource = BSourceItemStocks
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).HeaderText = "اسم الصنف"
            DataGridView1.Columns(3).HeaderText = "تاريخ الصلاحيه"
            DataGridView1.Columns(4).HeaderText = "الرصيد المفترض"
            DataGridView1.Columns(5).HeaderText = "الرصيد الفعلي"
            DataGridView1.Columns(6).HeaderText = "العجز"
            DataGridView1.Columns(7).HeaderText = "تكلفة الوحده"
            DataGridView1.Columns(8).Visible = False
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("Calc.exe", AppWinStyle.NormalFocus)
    End Sub





    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        cmd.CommandText = "select VISIT_ID,employee_id,employee_name,visit_name,stock_id,Stock_Name from visits_emp where status=N'منتهيه' and sales_rep_id =" & ComboSalesRepID.ComboBox.SelectedValue
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            EmployeeID.Tag = dr("employee_id")
            EmployeeID.Text = dr("employee_name")
            VisitName.Tag = dr("Visit_ID")
            VisitName.Text = dr("Visit_Name")
            StockID.Tag = dr("Stock_ID")
            StockID.Text = dr("Stock_Name")
        End If
        dr.Close()
        cmd.CommandText = "select stock_id,stock_Name from stocks where emp_reference_id = " & ComboSalesRepID.ComboBox.SelectedValue
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            EmpStockID.Text = dr("Stock_Name")
            EmpStockID.Tag = dr("Stock_ID")
        End If
        dr.Close()


        TStkID = StockID.Tag
        FStkID = EmpStockID.Tag

        'BSourceItemStocks.Filter = "stock_id = " & FStkID
        cls.FillSelectedTable("select * from Report_End_Visit where visit_id = " & VisitName.Tag, MyDs.Tables("End_Visit"))

    End Sub

    
End Class