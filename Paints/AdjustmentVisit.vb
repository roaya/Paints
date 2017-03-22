Public Class AdjustmentVisit

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
    Dim BSourceUmDetails, BSourceItemStocks As New BindingSource

    ''#Region "Order_Subs"


    Sub AddItem()
        Try
            If Quantity.Value = 0 Then
                cls.MsgExclamation("ادخل العدد", "Please enter delivered quantity")

                'ElseIf FromStockID.Text = "" Then
                '    cls.MsgExclamation("ادخل اسم المخزن المحول منه", "please select the first warehouse")

            
            ElseIf ComboUmDetailID.Text = "" Then
                cls.MsgExclamation("أدخل وحدة القياس", "Please enter unit of measure")




                '''
                '''
                '''
                '''
                '''



                '''''For xx As Integer = 0 To DataGridView1.Rows.Count - 1
                '''''    If MyDs.Tables("Adjustment_Details").Compute("Count(Item_ID)", "Item_id=" & ItmID) > 0 Then
                '''''        cls.MsgExclamation("هذا الصنف موجود مسبقا في الفاتورة الحالية", "This item already exists at the current document")
                '''''        Exit Sub
                '''''    End If
                '''''Next
            ElseIf DataGridView1.SelectedRows.Count <= 0 Then
                cls.MsgExclamation("أختر الكميه المراد الصرف منها", "please select a record")
            Else
                
                r = MyDs.Tables("Adjustment_Details").NewRow
                r("Adjustment_ID") = 1
                r("Item_ID") = ItmID
                r("Item_Name") = ComboUmDetailID.Text & " " & ItmName
                r("Barcode") = BarCde
                r("um_detail_id") = ComboUmDetailID.SelectedValue
                r("Quantity") = Quantity.Value
                r("expired_date") = DataGridView1.SelectedRows(0).Cells("expired_date").Value
                r("Price") = DataGridView1.SelectedRows(0).Cells("Price").Value

                MyDs.Tables("Adjustment_Details").Rows.Add(r)
                Quantity.Value = 0
                'CalculateTotalBill()
                




            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    'Sub CalculateTotalBill()
    '    If B_EndLoad = True Then
    '        Try
    '            If DataGridView1.Rows.Count > 0 Then
    '                CountRecords.Text = MyDs.Tables("Adjustment_Details").Compute("Count(Item_ID)", "Adjustment_ID=" & BillID.Text)
    '            Else
    '                CountRecords.Text = 0
    '            End If
    '        Catch ex As Exception
    '            cls.WriteError(ex.Message, TName)
    '        End Try
    '    End If
    'End Sub

    Sub ResetOrder(ByVal IsNew As Boolean)
        Try
            'MyDs.Tables("Adjustment_Header").Rows.Clear()
            MyDs.Tables("Adjustment_Details").Rows.Clear()
            If IsNew = False Then

                'BtnNew.Enabled = True
                BtnSave.Enabled = False

                BtnDelete.Enabled = False
                'BtnExit.Enabled = True
                B_Edited = False
                
                BtnSavePrint.Enabled = False
               
                EmployeeID.Text = EmpNameVar
                EmployeeID.Tag = EmpIDVar

                GroupHeader.Enabled = False
                GroupDetails.Enabled = False
                GroupAvailable.Enabled = False
                GroupItems.Enabled = False
                B_EndLoad = False
                'FStkID = 0
            Else
                
                ' BtnNew.Enabled = False
                BtnSave.Enabled = True
                BtnDelete.Enabled = True
                'BtnExit.Enabled = True
                B_Edited = False
                BtnSavePrint.Enabled = True
               
                EmployeeID.Text = EmpNameVar
                EmployeeID.Tag = EmpIDVar

                GroupHeader.Enabled = True
                GroupDetails.Enabled = True
                GroupAvailable.Enabled = True
                GroupItems.Enabled = True
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
                cls.MsgExclamation("لا يوجد اصناف في المستند", "there are no items attached to the current document")
            Else
                B_ID = 1

                'CalculateTotalBill()

                For i As Integer = 0 To DataGridView2.Rows.Count - 1
                    BDateExpire = DataGridView2.Rows(i).Cells("Expired_Date").Value
                    cmd.CommandText = "select dbo.Is_Balance_Fit(" & DataGridView2.Rows(i).Cells("Item_ID").Value & " , " & DataGridView2.Rows(i).Cells("um_detail_ID").Value & "," & DataGridView2.Rows(i).Cells("Quantity").Value & " , " & _
                        FStkID & " , '" & BDateExpire.ToString("MM/dd/yyyy") & "' )"
                    If cmd.ExecuteScalar = 1 Then
                        cls.MsgExclamation("الرصيد الحالي من " & DataGridView2.Rows(i).Cells("Item_NAME").Value & " لايكفي الكمية المنصرفة", "current balance from " & DataGridView2.Rows(i).Cells("Item_NAME").Value & " dosenot fit the delivered quantity")
                        Exit Sub
                    End If
                Next


                For i As Integer = 0 To DataGridView2.Rows.Count - 1
                    BDateExpire = DataGridView2.Rows(i).Cells("Expired_Date").Value

                    cmd.CommandText = "Exec commit_Visit_Transfer " & DataGridView2.Rows(i).Cells("Item_ID").Value & "," & DataGridView2.Rows(i).Cells("Quantity").Value & _
                    "," & FStkID & "," & TStkID & "," & DataGridView2.Rows(i).Cells("Um_Detail_ID").Value & ", '" & BDateExpire.ToString("MM/dd/yyyy") & "' , '" & BDate.ToString("MM/dd/yyyy") & "'," & DataGridView2.Rows(i).Cells("Price").Value & "," & VisitName.Tag
                    cmd.ExecuteNonQuery()
                Next

                ''''If RadioClosed.Checked = True Then
                ''''    cmd.CommandText = "update visit_header set status = N'منتهيه' where visit_id = " & VisitName.Tag
                ''''    cmd.ExecuteNonQuery()
                ''''    cmd.CommandText = "insert into end_visit(item_id,expired_date,balance,found_balance,price,visit_id) select item_id,expired_date,balance,0 as found_balance,price," & VisitName.Tag & " as visit_id from Items_stocks where stock_id = " & EmpStockID.Tag
                ''''    cmd.ExecuteNonQuery()

                ''''End If
                If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
                    cls.MsgInfo("تم حفظ الاذن بنجاح", "Document has been saved successfully")
                End If
                B_Edited = False
                Call ResetOrder(False)

            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try

    End Sub
    ''#End Region

    ''    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
    ''        Try
    ''            EmployeeID.Tag = EmpIDVar
    ''            EmployeeID.Text = EmpNameVar
    ''            cmdPro.ExecuteNonQuery()
    ''            BillID.Text = CurID.Value
    ''            MyDs.Tables("Adjustment_Details").Columns("Adjustment_ID").DefaultValue = BillID.Text
    ''            ResetOrder(True)
    ''            B_Edited = True

    ''            If MyDs.Tables("App_Preferences").Rows(0).Item("Adj_Def_Sch") = "الاسم" Then
    ''                RadioButton1.Checked = True
    ''                ItemName.Focus()
    ''            Else
    ''                RadioButton2.Checked = True
    ''                BarCode.Focus()
    ''            End If
    ''            Quantity.Value = MyDs.Tables("App_Preferences").Rows(0).Item("Adj_Def_Qty")
    ''        Catch ex As Exception
    ''            cls.WriteError(ex.Message, TName)
    ''        End Try
    ''    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Commit_Form()

    End Sub

    ''    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
    ''        If MsgBox("هل تريد حذف السجل الحالي", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, ProjectTitle) = MsgBoxResult.Yes Then
    ''            'MyDs.Tables("Adjustment_Header").Rows.Clear()
    ''            MyDs.Tables("Adjustment_Details").Rows.Clear()
    ''            If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
    ''                cls.MsgInfo("تم حذف الفاتورة بنجاح", "document has been deleted successfully")
    ''            End If



    ''            B_Edited = False
    ''            Call ResetOrder(False)
    ''        End If
    ''    End Sub

    Private Sub Quantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Quantity.KeyDown, DataGridView2.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItem()
        End If

    End Sub

    ''    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
    ''        RowID = DataGridView1.CurrentCell.RowIndex
    ''    End Sub

    ''    Private Sub DataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
    ''        If B_EndLoad = True Then

    ''            If DataGridView1.Rows.Count <= 0 Then
    ''                CountRecords.Text = 0
    ''            Else
    ''                CalculateTotalBill()
    ''                CountRecords.Text = MyDs.Tables("Adjustment_Details").Compute("Count(Item_ID)", "Adjustment_ID=" & BillID.Text)
    ''            End If
    ''        End If

    ''    End Sub



    ''    Private Sub Adjustments_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    ''        If B_Edited = False Then
    ''            e.Cancel = False
    ''        Else
    ''            e.Cancel = True
    ''            cls.MsgExclamation("يجب حفظ الاذن او حذفه اولا", "document must be saved or deleted first please press delete or save from the toolbar")
    ''        End If
    ''    End Sub

    Private Sub Adjustments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ' cls.SetGrant(MenuItemsStocks, "نافذة ربط الأصناف بالمحلات")

            ''Dim B As New BindingSource
            ''B.DataSource = MyDs
            ''B.DataMember = "Table_Columns"
            ''B.Filter = "Table_ID ='" & TName & "'"
            ''OrderByCombo.ComboBox.DataSource = B
            ''OrderByCombo.ComboBox.DisplayMember = "Logical_Name"
            ''OrderByCombo.ComboBox.ValueMember = "Physical_Name"

            cls.FillSelectedTable("select e.* from employees e,Visit_Header h where h.sales_rep_id = e.employee_id and h.status = N'مفتوحه'", "Employees")
            ComboSalesRepID.ComboBox.DataSource = MyDs
            ComboSalesRepID.ComboBox.DisplayMember = "Employees.Employee_Name"
            ComboSalesRepID.ComboBox.ValueMember = "Employees.Employee_ID"

            DataGridView2.DataSource = MyDs.Tables("Adjustment_Details")
            DataGridView2.Columns(0).Visible = False
            DataGridView2.Columns(1).Visible = False
            DataGridView2.Columns(2).Visible = False
            DataGridView2.Columns(3).HeaderText = "اسم الصنف"
            DataGridView2.Columns(3).ReadOnly = True
            DataGridView2.Columns(4).HeaderText = "الباركود"
            DataGridView2.Columns(4).ReadOnly = True
            DataGridView2.Columns(5).Visible = False
            DataGridView2.Columns(6).HeaderText = "العدد"
            DataGridView2.Columns(7).HeaderText = "تاريخ الصلاحيه"
            DataGridView2.Columns(8).HeaderText = "تكلفة الوحده"

            MyDs.Tables("Adjustment_Details").Rows.Clear()
            'MyDs.Tables("Adjustment_Header").Rows.Clear()


            cls.RefreshData("Stocks")

            cls.RefreshData("um_details")
            cls.RefreshData("Query_Items_Um")
            BSourceUmDetails.DataSource = MyDs
            BSourceUmDetails.DataMember = "Query_Items_Um"
            BSourceUmDetails.Filter = "item_id = 0"
            ComboUmDetailID.DataSource = BSourceUmDetails
            ComboUmDetailID.DisplayMember = "Equivalent_name"
            ComboUmDetailID.ValueMember = "Um_Detail_Id"

            cls.RefreshData("Items_Stocks")
            BSourceItemStocks.DataSource = MyDs
            BSourceItemStocks.DataMember = "Items_Stocks"
            BSourceItemStocks.Filter = "Item_ID = 0"
            DataGridView1.DataSource = BSourceItemStocks
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(7).HeaderText = "الرصيد"
            DataGridView1.Columns(6).HeaderText = "تاريخ الصلاحيه"
            DataGridView1.Columns(8).HeaderText = "تكلفة الوحده"
            DataGridView1.Columns(9).HeaderText = "الاجمالي"

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("Calc.exe", AppWinStyle.NormalFocus)
    End Sub


   

    ''    Private Sub ToStockID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToStockID.SelectedIndexChanged
    ''        Try
    ''            cmd.CommandText = "select stock_id from stocks where stock_name = N'" & ToStockID.Text & "'"
    ''            TStkID = cmd.ExecuteScalar
    ''        Catch ex As Exception
    ''            cls.WriteError(ex.Message, TName)
    ''        End Try
    ''    End Sub

    Private Sub BarCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarCode.Leave
        Try
            If BarCode.Text <> "" Then

                cmd.CommandText = "select dbo.Is_Item_EXISTS(0 , NULL , N'" & BarCode.Text & "')"
                If cmd.ExecuteScalar = 0 Then
                    cls.MsgExclamation("هذا الصنف غير موجود بهذا المخزن", "this item isnot attached to the current warehouse")
                    BarCode.Focus()
                    Exit Sub
                End If
                cmd.CommandText = "select Item_ID,item_Name from items where barcode = N'" & BarCode.Text & "'"
                dr = cmd.ExecuteReader
                Do While Not dr.Read = False
                    BarCde = BarCode.Text
                    ItmName = dr("Item_Name")
                    ItmID = dr("Item_ID")
                Loop
                dr.Close()
                BSourceUmDetails.Filter = "item_id = " & ItmID
                BSourceItemStocks.Filter = "item_id = " & ItmID & " and stock_id = " & FStkID
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub ItemName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemName.Leave
        Try
            If B_EndLoad = True Then
                cmd.CommandText = "select Item_ID,barcode from items where item_name = N'" & ItemName.Text & "'"
                dr = cmd.ExecuteReader

                Do While Not dr.Read = False
                    ItmName = ItemName.Text
                    BarCde = dr("Barcode")
                    ItmID = dr("Item_ID")
                Loop
                dr.Close()

                BSourceUmDetails.Filter = "item_id = " & ItmID
                BSourceItemStocks.Filter = "item_id = " & ItmID & " and stock_id = " & FStkID
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    
    ''    Private Sub BtnSavePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSavePrint.Click
    ''        Try
    ''            Me.Cursor = Cursors.WaitCursor
    ''            Commit_Form()
    ''            MyDs.Tables("Report_Adjustment").Rows.Clear()
    ''            cmd.CommandText = "select * from Report_Adjustment where Adjustment_id = " & B_ID
    ''            da.SelectCommand = cmd
    ''            da.Fill(MyDs.Tables("Report_Adjustment"))

    ''            RptAdj.SetDataSource(MyDs.Tables("Report_Adjustment"))
    ''            Dim m As New ShowAllReports
    ''            m.CrystalReportViewer1.ReportSource = RptAdj
    ''            m.ShowDialog()
    ''            Me.Cursor = Cursors.Default
    ''        Catch ex As Exception
    ''            cls.WriteError(ex.Message, TName)
    ''        End Try
    ''    End Sub

    ''    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''        Dim m As New Stocks
    ''        m.ShowDialog()
    ''    End Sub

    ''    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    ''        Dim m As New Stocks
    ''        m.ShowDialog()
    ''    End Sub

    ''    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    ''        Dim m As New Items
    ''        m.ShowDialog()
    ''        Try

    ''            If B_EndLoad = True Then
    ''                cmd.CommandText = "select stock_id from stocks where stock_name = N'" & FromStockID.Text & "'"
    ''                FStkID = cmd.ExecuteScalar

    ''                ItemName.Items.Clear()
    ''                cmd.CommandText = "select distinct item_name from report_items_stocks_balance where stock_id = " & FStkID
    ''                dr = cmd.ExecuteReader
    ''                Do While Not dr.Read = False
    ''                    ItemName.Items.Add(dr("Item_Name"))
    ''                Loop
    ''                dr.Close()
    ''            End If
    ''        Catch ex As Exception
    ''            cls.WriteError(ex.Message, TName)
    ''        End Try
    ''    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        cmd.CommandText = "select employee_id,employee_name,visit_name,stock_id,Stock_Name,visit_id from visits_emp where status=N'مفتوحه' and sales_rep_id =" & ComboSalesRepID.ComboBox.SelectedValue
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


        FStkID = StockID.Tag
        TStkID = EmpStockID.Tag

        ItemName.Items.Clear()
        cmd.CommandText = "select distinct item_name from report_items_stocks_balance where stock_id = " & FStkID
        dr = cmd.ExecuteReader
        Do While Not dr.Read = False
            ItemName.Items.Add(dr("Item_Name"))
        Loop
        dr.Close()


        ResetOrder(True)
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Me.Close()
    End Sub
End Class