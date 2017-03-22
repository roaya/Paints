﻿Public Class CustomersRequests

    Dim B_EndLoad As Boolean = False
    Dim B_Edited As Boolean = False
    Dim CurID, SeqID As New SqlClient.SqlParameter
    Dim cmdPro As New SqlClient.SqlCommand
    Dim TName As String = "Requests_Details"
    Dim RowID, ItmID As Integer
    Dim ItmName, BarCde As String
    Dim BDate, BDateExpire As Date
    Dim d As Date
    Dim RptCustReq As New RptRequests
    Dim B_ID As Integer
    Dim BSourceUmDetails As New BindingSource

#Region "Order_Subs"

    Sub AddItem()
        If Quantity.Value = 0 Then
            cls.MsgExclamation("ادخل العدد", "please enter quantity")
        ElseIf CustomerID.Text = "" Then
            cls.MsgExclamation("اختر اسم العميل", "please select customer name")
        Else
            Try
                For xx As Integer = 0 To DataGridView1.Rows.Count - 1
                    If MyDs.Tables("Requests_Details").Compute("Count(Item_ID)", "Item_id=" & ItmID) > 0 Then
                        cls.MsgExclamation("هذا الصنف موجود مسبقا في الفاتورة الحالية", "this item already attached to the current document you can edit quantity or price from the data grid below or reenter the specified item")
                        Exit Sub
                    End If
                Next
                CustomerID.Enabled = False
                BtnNewCustomer.Enabled = False

                r = MyDs.Tables("Requests_Details").NewRow
                r("Request_ID") = BillID.Text
                r("Item_Name") = ComboUmDetailID.Text & " " & ItmName
                r("Item_ID") = ItmID
                r("Barcode") = BarCde
                r("um_detail_id") = ComboUmDetailID.SelectedValue
                r("Quantity") = Quantity.Value
                MyDs.Tables("Requests_Details").Rows.Add(r)

                ''''If MyDs.Tables("App_Preferences").Rows(0).Item("Ret_Ven_Def_Sch") = "الاسم" Then
                ''''RadioItemName.Checked = True
                ''''ItemName.Focus()
                ''''''''Else
                ''''RadioBarcode.Checked = True
                ''''BarCode.Focus()
                ''''End If

                Quantity.Value = 0

                ''''''Quantity.Value = MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Def_Qty")
            Catch ex As Exception
                cls.WriteError(ex.Message, TName)
            End Try
        End If
    End Sub

    Sub ResetOrder(ByVal IsNew As Boolean)
        Try
            'MyDs.Tables("Sales_Header").Rows.Clear()
            MyDs.Tables("Requests_Details").Rows.Clear()
            ''''''''''''''''

            ''''' PeriodID.Tag = MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Period_ID")
            '''''cmd.CommandText = "select period_name from periods where period_id = " & MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Period_ID")
            '''''PeriodID.Text = cmd.ExecuteScalar

            If IsNew = False Then
                BillID.Text = 0
                GeneralNumber.Value = 0
                BtnNew.Enabled = True
                BtnSave.Enabled = False
                BtnDelete.Enabled = False
                BtnExit.Enabled = True
                B_Edited = False
                BtnSavePrint.Enabled = False
                BillDate.Text = Now
                BillTime.Text = ""
                Comments.TextBox1.Text = ""
                GroupHeader.Enabled = False
                GroupDetails.Enabled = False
                GroupItems.Enabled = False
                B_EndLoad = False
            Else
                ItemName.Items.Clear()
                CustomerID.Enabled = True
                GeneralNumber.Value = 0
                BtnNewCustomer.Enabled = True
                BtnNew.Enabled = False
                BtnSave.Enabled = True
                BtnDelete.Enabled = True
                BtnExit.Enabled = True
                B_Edited = False
                BtnSavePrint.Enabled = True
                BillDate.Text = Now
                BillTime.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second
                EmployeeID.Text = EmpNameVar
                EmployeeID.Tag = EmpIDVar
                Comments.TextBox1.Text = ""
                GroupHeader.Enabled = True
                GroupDetails.Enabled = True
                GroupItems.Enabled = True

                'If MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Def_Sch") = "الاسم" Then
                '    RadioItemName.Checked = True
                '    ItemName.Focus()
                'Else
                '    RadioBarcode.Checked = True
                '    BarCode.Focus()
                'End If

                'If MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Edit_Emp_ID") = True Then
                '    EmployeeID.Enabled = True
                'Else
                '    EmployeeID.SelectedValue = EmpIDVar
                '    EmployeeID.Enabled = False
                'End If

                'If MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Edit_Date") = True Then
                '    BillDate.Enabled = True
                'Else
                '    BillDate.Text = Now
                '    BillDate.Enabled = False
                'End If

                B_EndLoad = True

                BSourceUmDetails.Filter = "item_id = 0"

            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Sub Commit_Form()
        Try

            cmd.CommandText = "select count(*) from requests_header where request_id = " & BillID.Text
            If cmd.ExecuteScalar > 0 Then
                cls.MsgExclamation("رقم الفاتورة مستخدم مسبقا أعد ضبط اعدادات النظام", "order id of the current document has been used before please modify documents numbers from the system settings")
                Exit Sub
            End If

            If GeneralNumber.Value = 0 Then
                GeneralNumber.BackColor = Color.Yellow
                GeneralNumber.Focus()
                cls.MsgExclamation("أدخل الرقم العام")
                Exit Sub
            Else
                cmd.CommandText = "select dbo.Is_Master_Num_Exists(" & GeneralNumber.Value & ",1)"
                If cmd.ExecuteScalar = 1 Then
                    GeneralNumber.BackColor = Color.Yellow
                    GeneralNumber.Focus()
                    cls.MsgExclamation("الرقم العام المدخل مستخدم مسبقا برجاء اعادة الادخال", "this master no already exists please enter a unique number")
                    Exit Sub
                End If
            End If

            If CustomerID.Text = "" Then
                cls.MsgExclamation("اختر اسم العميل", "please enter customer name")
            ElseIf DataGridView1.Rows.Count <= 0 Then
                cls.MsgExclamation("لا يوجد اصناف في الفاتورة", "there are no items in the current document")

            Else

                B_ID = BillID.Text

                '''''''''''''''''''''''''''''''''''''''''''''''''

                BDate = BillDate.Text
                BDateExpire = ExpiredDate.Text
                cmd.CommandText = "Exec Commit_Request_Header " & BillID.Text & ", '" & BDate.ToString("MM/dd/yyyy") & "' ,'" & BillTime.Text & "'," & CustomerID.SelectedValue & ", '" & _
                BDateExpire.ToString("MM/dd/yyyy") & "' ," & EmployeeID.Tag & ", N'" & Comments.TextBox1.Text & "' , " & GeneralNumber.Value
                cmd.ExecuteNonQuery()


                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    cmd.CommandText = "Exec Commit_Request_Details " & DataGridView1.Rows(i).Cells("Request_ID").Value & "," & DataGridView1.Rows(i).Cells("Item_ID").Value & "," & DataGridView1.Rows(i).Cells("Um_Detail_ID").Value & _
            "," & DataGridView1.Rows(i).Cells("Quantity").Value
                    cmd.ExecuteNonQuery()
                Next


                MyDs.Tables("Requests_Details").Rows.Clear()

                '''''''If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
                cls.MsgInfo("تم حفظ الفاتورة بنجاح", "document has been saved successfully")
                '''''''End If
                B_Edited = False
                Call ResetOrder(False)

            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub
#End Region

    'Private Sub CustomersRequests_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    If B_Edited = True Then

    '        Commit_Form()
    '    End If
    'End Sub

    Private Sub CustomersRequests_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If B_Edited = False Then
            e.Cancel = False
        Else
            e.Cancel = True
            cls.MsgExclamation("يجب حفظ الفاتورة او حذفها اولا", "document must be saved or deleted first")
        End If
    End Sub

    Private Sub BtnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Try
            'EmployeeID.Tag = EmpIDVar
            'EmployeeID.Text = EmpNameVar
            SeqID.Value = 8
            cmdPro.ExecuteNonQuery()
            BillID.Text = CurID.Value
            
            MyDs.Tables("Requests_Details").Columns("Request_ID").DefaultValue = BillID.Text
            ResetOrder(True)
            B_Edited = True
            ItemName.Items.Clear()
            If B_EndLoad = True Then
                cmd.CommandText = "select distinct item_name from Query_Items_stocks"
                dr = cmd.ExecuteReader
                Do While Not dr.Read = False
                    GeneralNumber.BackColor = Color.Gainsboro
                    ItemName.Items.Add(dr("Item_Name"))
                Loop
                dr.Close()
            End If

            ''''''If MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Def_Sch") = "الاسم" Then
            ''''''    RadioItemName.Checked = True
            ''''''    ItemName.Focus()
            ''''''Else
            ''''''    RadioBarcode.Checked = True
            ''''''    BarCode.Focus()
            ''''''End If
            ''''''OrderType.Text = MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Def_Ord_Type")

            ''''''Quantity.Value = MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Def_Qty")
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Commit_Form()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        ''AssistantSound.Speak("do you want to delete current document")
        If MsgBox("هل تريد حذف السجل الحالي", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, ProjectTitle) = MsgBoxResult.Yes Then
            '''MyDs.Tables("Sales_Header").Rows.Clear()
            MyDs.Tables("Requests_Details").Rows.Clear()
            '''''' If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
            cls.MsgInfo("تم حذف الفاتورة بنجاح", "document has been deleted successfully")
            '''''''End If
            B_Edited = False
            GeneralNumber.BackColor = Color.Gainsboro
            Call ResetOrder(False)
        End If
    End Sub

    Private Sub Quantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItem()
        End If
    End Sub

    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        RowID = DataGridView1.CurrentCell.RowIndex
    End Sub

    Private Sub DataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        If B_EndLoad = True Then

            If DataGridView1.Rows.Count <= 0 Then
                'TotalTemp.Text = 0
                CountRecords.Text = 0
            Else
               
                CountRecords.Text = MyDs.Tables("Requests_Details").Compute("Count(Item_ID)", "Request_id=" & BillID.Text)
            End If
        End If

    End Sub



    Private Sub ItemName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemName.Leave
        If ItemName.Text <> "" Then
            Try
                cmd.CommandText = "select dbo.Is_Item_EXISTS(1 ,N'" & ItemName.Text & "' , NULL )"
                If cmd.ExecuteScalar = 0 Then
                    cls.MsgExclamation("هذا الصنف غير موجود بهذا المخزن", "this item isnot attached to the current warehouse")
                    BarCode.Focus()
                Else
                    cmd.CommandText = "select Item_ID,Barcode from items where item_name = N'" & ItemName.Text & "'"
                    dr = cmd.ExecuteReader
                    Do While Not dr.Read = False
                        ItmName = ItemName.Text
                        BarCde = dr("Barcode")
                        ItmID = dr("Item_ID")
                    Loop
                    dr.Close()

                    BSourceUmDetails.Filter = "item_id = " & ItmID

                End If

            Catch ex As Exception
                cls.WriteError(ex.Message, TName)
            End Try
        End If
    End Sub

    Private Sub RadioItemName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioItemName.CheckedChanged
        If RadioItemName.Checked = True Then
            BarCode.Enabled = False
            ItemName.Enabled = True
            ItemName.Text = ""
            BarCode.Text = ""
        End If
    End Sub

    Private Sub RadioBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBarcode.CheckedChanged
        If RadioBarcode.Checked = True Then
            BarCode.Enabled = True
            ItemName.Enabled = False
            ItemName.Text = ""
            BarCode.Text = ""
        End If
    End Sub


    Private Sub CustomersRequests_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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


            DataGridView1.DataSource = MyDs.Tables("Requests_Details")
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).HeaderText = "اسم الصنف"
            DataGridView1.Columns(3).ReadOnly = True
            DataGridView1.Columns(4).HeaderText = "الباركود"
            DataGridView1.Columns(4).ReadOnly = True
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).HeaderText = "العدد"

            MyDs.Tables("Requests_Details").Rows.Clear()
            ''''''MyDs.Tables("Sales_Header").Rows.Clear()

            cmdPro.CommandType = CommandType.StoredProcedure
            cmdPro.Connection = cn


            CurID.DbType = DbType.Int32
            CurID.ParameterName = "CURR_ID"
            CurID.Direction = ParameterDirection.Output
            SeqID.DbType = DbType.Int32
            SeqID.ParameterName = "S_ID"
            SeqID.Direction = ParameterDirection.Input
            SeqID.Value = 8
            cmdPro.Parameters.Add(SeqID)
            cmdPro.Parameters.Add(CurID)
            cmdPro.CommandText = "UPDATE_SEQ"

            cls.RefreshData("um_details")
            cls.RefreshData("Query_Items_Um")
            BSourceUmDetails.DataSource = MyDs
            BSourceUmDetails.DataMember = "Query_Items_Um"
            BSourceUmDetails.Filter = "item_id = 0"
            ComboUmDetailID.DataSource = BSourceUmDetails
            ComboUmDetailID.DisplayMember = "Equivalent_name"
            ComboUmDetailID.ValueMember = "Um_Detail_Id"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCustomer.Click
        IsCustomerAdded = False
        Dim m As New Customers
        m.ShowDialog()
    End Sub

    Private Sub BtnSavePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSavePrint.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Commit_Form()
            MyDs.Tables("Report_Requests").Rows.Clear()
            cmd.CommandText = "select * from Report_Requests where bill_id = " & B_ID
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Report_Requests"))
            RptCustReq.SetDataSource(MyDs.Tables("Report_Requests"))
            Dim m As New ShowAllReports
            m.CrystalReportViewer1.ReportSource = RptCustReq
            m.ShowDialog()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BarCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarCode.Leave
        If BarCode.Text <> "" Then
            Try
                cmd.CommandText = "select dbo.Is_Item_EXISTS(0 , NULL , N'" & BarCode.Text & "')"
                If cmd.ExecuteScalar = 0 Then
                    cls.MsgExclamation("هذا الصنف غير موجود بهذا المخزن", "this item isnot attached to the current warehouse")
                    BarCode.Focus()
                Else
                    cmd.CommandText = "select Item_ID,item_name from items where BarCode = N'" & BarCode.Text & "'"
                    dr = cmd.ExecuteReader
                    Do While Not dr.Read = False
                        BarCde = BarCode.Text
                        ItmName = dr("item_name")
                        ItmID = dr("Item_ID")
                    Loop
                    dr.Close()

                    BSourceUmDetails.Filter = "item_id = " & ItmID

                End If

            Catch ex As Exception
                cls.WriteError(ex.Message, TName)
            End Try
        End If
    End Sub

    Private Sub GeneralNumber_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralNumber.Leave
        If GeneralNumber.Value <> 0 Then
            GeneralNumber.BackColor = Color.Gainsboro
        End If
    End Sub
End Class