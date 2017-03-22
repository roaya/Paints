Public Class CustomerReservation

    Dim TotalTemp As Double
    Dim B_EndLoad As Boolean = False
    Dim B_Edited As Boolean = False
    Dim DTemp As Double
    Dim CurID, SeqID As New SqlClient.SqlParameter
    Dim cmdPro As New SqlClient.SqlCommand
    Dim TName As String = "Customer_Reserve_Details"
    Dim RowID, ItmID As Integer

    Dim BDate, RDate As Date
    Dim RptPur As New RptSalesOrder
    'Dim RptChk As New RptSalBill
    Dim B_ID As Integer



    Sub CalculateTotalBill()
        If B_EndLoad = True Then
            Try
                If DataGridView1.Rows.Count > 0 Then
                    TotalTemp = MyDs.Tables("Customer_Reserve_Details").Compute("sum(total_item)", "bill_id=" & BillID.Text)
                    CountRecords.Text = MyDs.Tables("Customer_Reserve_Details").Compute("Count(bill_ID)", "bill_id=" & BillID.Text)
                Else
                    TotalTemp = 0
                    CountRecords.Text = 0
                End If
               
                TotalBill.Text = TotalTemp + Delivery.Value

            Catch ex As Exception
                cls.WriteError(ex.Message, TName)
            End Try
        End If
    End Sub

    Sub ResetOrder(ByVal IsNew As Boolean)
        Try
            'MyDs.Tables("Sales_Header").Rows.Clear()
            MyDs.Tables("Customer_Reserve_Details").Rows.Clear()
            ''''''''''''''''

            If IsNew = False Then
                BillID.Text = 0
                CashValue.Value = 0
                CreditValue.Value = 0
                BtnNew.Enabled = True
                BtnSave.Enabled = False
                BtnDelete.Enabled = False
                BtnExit.Enabled = True
                B_Edited = False
                BtnSavePrint.Enabled = False
                BillDate.Text = Now
                BillTime.Text = ""
                TotalBill.Text = 0
                Delivery.Value = 0
                'EmployeeID.Text = EmpNameVar
                'EmployeeID.Tag = EmpIDVar
                CashValue.Value = 0
                CreditValue.Value = 0
                Comments.TextBox1.Text = ""
                GroupHeader.Enabled = False
                GroupDetails.Enabled = False
                TotalTemp = 0
                B_EndLoad = False
            Else
                 CustomerID.Enabled = True
                 BtnNewCustomer.Enabled = True
                CashValue.Value = 0
                CreditValue.Value = 0
                BtnNew.Enabled = False
                BtnSave.Enabled = True
                BtnDelete.Enabled = True
                BtnExit.Enabled = True
                B_Edited = False
                BtnSavePrint.Enabled = True
                BillDate.Text = Now
                BillTime.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second
                TotalBill.Text = 0
                Delivery.Value = 0
                EmployeeID.Text = EmpNameVar
                EmployeeID.Tag = EmpIDVar
                CashValue.Value = 0
                CreditValue.Value = 0
                Comments.TextBox1.Text = ""
                GroupHeader.Enabled = True
                GroupDetails.Enabled = True
                TotalTemp = 0
              
                B_EndLoad = True

            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

     
    Sub Commit_Form()
        Try

            cmd.CommandText = "select count(*) from Customer_Reserve_Header where bill_id = " & BillID.Text
            If cmd.ExecuteScalar > 0 Then
                cls.MsgExclamation("رقم الفاتورة مستخدم مسبقا أعد ضبط اعدادات النظام", "order id of the current document has been used before please modify documents numbers from the system settings")
                Exit Sub
            End If

            
            If CashValue.Value + CreditValue.Value <> TotalBill.Text Then
                cls.MsgExclamation("يجب ان تتساوي قيمة المدفوع مع اجمالي الفاتورة", "cash value plus credit value must be equal to total document")
            ElseIf CustomerID.Text = "" Then
                cls.MsgExclamation("اختر اسم العميل", "please enter customer name")
             
            ElseIf DataGridView1.Rows.Count <= 0 Then
                cls.MsgExclamation("لا يوجد اصناف في الفاتورة", "there are no items in the current document")

            Else

                
                B_ID = BillID.Text
                CalculateTotalBill()

                BDate = BillDate.Text
                rdate = ReceiveDate.Text

                cmd.CommandText = "Exec Commit_Customer_Reservation_Header " & BillID.Text & ", '" & BDate.ToString("MM/dd/yyyy") & "' ,'" & BillTime.Text & "'," & CustomerID.SelectedValue & "," & _
    TotalBill.Text & "," & EmpIDVar & "," & CashValue.Value & "," & CreditValue.Value & ", N'" & _
            Comments.TextBox1.Text & "', " & Delivery.Value & " , '" & RDate.ToString("MM/dd/yyyy") & "'"
                cmd.ExecuteNonQuery()

                For i As Integer = 0 To DataGridView1.Rows.Count - 2

                    cmd.CommandText = "Exec Commit_Customer_Reservation_Details " & DataGridView1.Rows(i).Cells("Bill_ID").Value & ", N'" & DataGridView1.Rows(i).Cells("Item_Name").Value & "' ," & _
         DataGridView1.Rows(i).Cells("Quantity").Value & "," & DataGridView1.Rows(i).Cells("Price").Value & "," & DataGridView1.Rows(i).Cells("Total_Item").Value
                    cmd.ExecuteNonQuery()
                Next


                '''''''If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
                cls.MsgInfo("تم حفظ الفاتورة بنجاح", "document has been saved successfully")
                '''''''End If
                B_Edited = False
                Call ResetOrder(False)
                '-----------------------------------------
                '-----------------------------------------
            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    'Private Sub CustomerReservation_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    '    If B_Edited = True Then

    '        Commit_Form()
    '    End If
    'End Sub

    Private Sub CustomerReservation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If B_Edited = False Then
            e.Cancel = False
        Else
            e.Cancel = True
            cls.MsgExclamation("يجب حفظ الفاتورة او حذفها اولا", "document must be saved or deleted first")
        End If

    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Try
            'EmployeeID.Tag = EmpIDVar
            'EmployeeID.Text = EmpNameVar
            SeqID.Value = 10
            cmdPro.ExecuteNonQuery()
            BillID.Text = CurID.Value
            MyDs.Tables("Customer_Reserve_Details").Columns("Bill_ID").DefaultValue = BillID.Text
            ResetOrder(True)
            B_Edited = True
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Commit_Form()

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        '''''''AssistantSound.Speak("do you want to delete current document")
        If MsgBox("هل تريد حذف السجل الحالي", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, ProjectTitle) = MsgBoxResult.Yes Then
            '''MyDs.Tables("Sales_Header").Rows.Clear()
            MyDs.Tables("Sales_Details").Rows.Clear()
            '''''' If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
            cls.MsgInfo("تم حذف الفاتورة بنجاح", "document has been deleted successfully")
            '''''''End If
            B_Edited = False
            Call ResetOrder(False)
        End If
    End Sub

    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        RowID = DataGridView1.CurrentCell.RowIndex
    End Sub

    Private Sub SalesOrderNormal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cls.RefreshData("Customers")

            Dim B As New BindingSource
            B.DataSource = MyDs
            B.DataMember = "Table_Columns"
            B.Filter = "Table_ID ='" & TName & "'"
            OrderByCombo.ComboBox.DataSource = B
            OrderByCombo.ComboBox.DisplayMember = "Logical_Name"
            OrderByCombo.ComboBox.ValueMember = "Physical_Name"

            CustomerID.DataSource = MyDs
            CustomerID.DisplayMember = "Customers.Customer_Name"
            CustomerID.ValueMember = "Customers.Customer_ID"


            DataGridView1.DataSource = MyDs.Tables("Customer_Reserve_Details")
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).HeaderText = "اسم الصنف"
            DataGridView1.Columns(3).HeaderText = "العدد"
            DataGridView1.Columns(4).HeaderText = "سعر الوحدة"
            DataGridView1.Columns(5).HeaderText = "اجمالي الصنف"
            DataGridView1.Columns(5).ReadOnly = True

            MyDs.Tables("Customer_Reserve_Details").Rows.Clear()

            cmdPro.CommandType = CommandType.StoredProcedure
            cmdPro.Connection = cn


            CurID.DbType = DbType.Int32
            CurID.ParameterName = "CURR_ID"
            CurID.Direction = ParameterDirection.Output
            SeqID.DbType = DbType.Int32
            SeqID.ParameterName = "S_ID"
            SeqID.Direction = ParameterDirection.Input
            SeqID.Value = 11
            cmdPro.Parameters.Add(SeqID)
            cmdPro.Parameters.Add(CurID)
            cmdPro.CommandText = "UPDATE_SEQ"

            

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click, MenuExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculator.Click
        Shell("Calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCustomer.Click
        IsCustomerAdded = False
        Dim m As New Customers
        m.ShowDialog()
    End Sub

    Private Sub DataGridView1_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(RowID).Cells("Total_Item").Value = DataGridView1.Rows(RowID).Cells("Price").Value * DataGridView1.Rows(RowID).Cells("Quantity").Value
            CalculateTotalBill()
        End If
    End Sub
End Class