Public Class CheckDetails

    Dim B_EndLoad As Boolean = False
    Dim B_Edited As Boolean = False
    Dim DTemp As Double
    Dim CurID, SeqID As New SqlClient.SqlParameter
    'Dim cmdPro As New SqlClient.SqlCommand
    Dim TName As String = "Check_Details"
    Dim RowID, ItmID As Integer
    Dim ItmName, BarCde As String
    Dim ItmPrc As Double
    Dim BDate, BExpDate As Date
    Dim StkID As Integer
    Dim cmdb As New SqlClient.SqlCommandBuilder
    Dim BSource As New BindingSource
    Dim TotalNormal, TotalEmployee, TotalIncrease As Double
    Private TblEmp As New GeneralDataSet.EmployeesDataTable
    Private TblProMstr As New GeneralDataSet.Procedure_MasterDataTable

#Region "Order_Subs"


    Sub AddItem()
        Try
            If Quantity.Value = 0 Then
                cls.MsgExclamation("ادخل العدد", "Please enter quantity")
                Exit Sub
            ElseIf StkID = "" Then
                cls.MsgExclamation("ادخل اسم المخزن", "please select warehouse name")
                Exit Sub
            End If


            r = MyDs.Tables("Check_Details").NewRow
            r("Check_ID") = CheckID.SelectedValue
            r("Item_Name") = ItmName
            r("Item_ID") = ItmID
            r("Barcode") = BarCde
            cmd.CommandText = "select balance from items_stocks where item_id = " & ItmID & " and stock_id = " & StkID
            r("System_Quantity") = cmd.ExecuteScalar
            r("User_Quantity") = Quantity.Value
            r("Expired_Date") = ExpiredDate.Text
            MyDs.Tables("Check_Details").Rows.Add(r)
            Quantity.Value = 0
            'CalculateTotalBill()

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    'Sub CalculateTotalBill()
    '    If B_EndLoad = True Then
    '        Try
    '            If DataGridView1.Rows.Count > 0 Then
    '                CountRecords.Text = MyDs.Tables("Check_Details").Compute("Count(Item_ID)", "Check_ID=" & CheckID.SelectedValue)
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
            'MyDs.Tables("Check_Header").Rows.Clear()
            MyDs.Tables("Check_Details").Rows.Clear()
            If IsNew = False Then
                BtnNew.Enabled = True
                BtnExit.Enabled = False
                BtnExit.Enabled = True
                B_Edited = False
                'GroupHeader.Enabled = False
                GroupDetails.Enabled = False
                GroupItems.Enabled = False
                B_EndLoad = False
                'FStkID = 0
            Else
                'FromStockID.Enabled = True
                'ToStockID.Enabled = True
                BtnNew.Enabled = False
                BtnExit.Enabled = True
                'BtnDelete.Enabled = True
                BtnExit.Enabled = True
                B_Edited = False
                'BtnSavePrint.Enabled = True
                'BillDate.Text = Now
                'BillTime.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second
                'EmployeeID.Text = EmpNameVar
                'EmployeeID.Tag = EmpIDVar
                'Comments.TextBox1.Text = ""
                'GroupHeader.Enabled = True
                GroupDetails.Enabled = True
                GroupItems.Enabled = True
                B_EndLoad = True
                'FStkID = 0
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Sub Commit_Form()
        Try
            If DataGridView1.Rows.Count <= 0 Then
                cls.MsgExclamation("لا يوجد اصناف في الفاتورة", "there are no items in the current document")
            Else

                ' CalculateTotalBill()

                BSource.EndEdit()
                cmd.CommandText = "select * from " & TName
                cmdb.DataAdapter = da
                da.Update(MyDs.Tables(TName))

                If RadioCheckClosed.Checked = True Then
                    For z As Integer = 0 To DataGridView1.Rows.Count - 1
                        If DataGridView1.Rows(z).Cells("Col_Check_Type").Value = "لا يوجد" And DataGridView1.Rows(z).Cells("Col_Diff_Quantity").Value <> 0 Then
                            cls.MsgExclamation("أدخل سبب الفرق")
                            Exit Sub
                        ElseIf DataGridView1.Rows(z).Cells("Col_Check_Type").Value = "جاري الشركاء" And DataGridView1.Rows(z).Cells("Col_Partner_ID").Value Is DBNull.Value Then
                            cls.MsgExclamation("أدخل حساب الشريك")
                            Exit Sub
                        ElseIf DataGridView1.Rows(z).Cells("Col_Check_Type").Value = "موظف" And DataGridView1.Rows(z).Cells("Col_Employee_ID").Value Is DBNull.Value Then
                            cls.MsgExclamation("أدخل اسم الموظف")
                            Exit Sub
                        End If
                    Next

                    cmd.CommandText = "update check_header set Check_Status=N'مغلق' where check_id = " & CheckID.SelectedValue
                    cmd.ExecuteNonQuery()
                    TotalEmployee = 0
                    TotalNormal = 0

                    For I As Integer = 0 To DataGridView1.Rows.Count - 1
                        Select Case DataGridView1.Rows(I).Cells("Col_Check_Type").Value
                            Case "طبيعي"
                                TotalNormal = TotalNormal + (DataGridView1.Rows(I).Cells("Col_Price").Value * DataGridView1.Rows(I).Cells("Col_Diff_Quantity").Value)
                            Case "جاري الشركاء"
                                cmd.CommandText = "Exec COMMIT_CHECK_TRAN 0,0," & (DataGridView1.Rows(I).Cells("Col_Price").Value * DataGridView1.Rows(I).Cells("Col_Diff_Quantity").Value) & " , " & DataGridView1.Rows(I).Cells("Col_Partner_ID").Value & ",0 , " & CurrentShiftID & "," & CheckID.SelectedValue
                                cmd.ExecuteNonQuery()
                            Case "موظف"
                                TotalEmployee = TotalEmployee + (DataGridView1.Rows(I).Cells("Col_Price").Value * DataGridView1.Rows(I).Cells("Col_Diff_Quantity").Value)
                            Case "زياده مخزنيه"
                                TotalIncrease = TotalIncrease + (DataGridView1.Rows(I).Cells("Col_Price").Value * DataGridView1.Rows(I).Cells("Col_Diff_Quantity").Value)
                        End Select
                        BExpDate = DataGridView1.Rows(I).Cells("Col_Expired_Date").Value
                        cmd.CommandText = "Exec COMMIT_CHECK " & StkID & "," & DataGridView1.Rows(I).Cells("Col_Item_ID").Value & "," & DataGridView1.Rows(I).Cells("Col_User_Quantity").Value & " , '" & BExpDate.ToString("MM/dd/yyyy") & "' , " & CurrentShiftID & "," & CheckID.SelectedValue
                        cmd.ExecuteNonQuery()

                    Next
                End If

                cmd.CommandText = "Exec COMMIT_CHECK_TRAN " & TotalNormal & ",0,0,0,0 , " & CurrentShiftID & "," & CheckID.SelectedValue
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Exec COMMIT_CHECK_TRAN 0," & TotalEmployee & ",0,0,0 , " & CurrentShiftID & "," & CheckID.SelectedValue
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Exec COMMIT_CHECK_TRAN 0,0,0,0," & TotalIncrease & " , " & CurrentShiftID & "," & CheckID.SelectedValue
                cmd.ExecuteNonQuery()

                ''''''''If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
                cls.MsgInfo("تم حفظ الاذن بنجاح", "document has been saved successfully")
                ''''''''End If
                B_Edited = False
                Call ResetOrder(False)

            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub
#End Region

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Try
            MyDs.Tables("Check_Details").Rows.Clear()
            cmd.CommandText = "select stock_id from check_header where check_id = " & CheckID.SelectedValue
            StkID = cmd.ExecuteScalar
            cmd.CommandText = "select check_status from check_header where check_id = " & CheckID.SelectedValue
            If cmd.ExecuteScalar = "مغلق" Then
                RadioCheckClosed.Checked = True
                GroupDetails.Enabled = False
                GroupItems.Enabled = False
                RadioCheckOpened.Enabled = False
                RadioCheckClosed.Enabled = False
            Else
                ResetOrder(True)


                RadioCheckOpened.Checked = True
                GroupDetails.Enabled = True
                GroupItems.Enabled = True
                RadioCheckClosed.Enabled = True
                RadioCheckOpened.Enabled = True

                B_Edited = True
            End If
            cmd.CommandText = "select * from Query_Check_Items where check_id = " & CheckID.SelectedValue
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Check_Details"))

            MyDs.Tables("Check_Details").Columns("Check_ID").DefaultValue = CheckID.SelectedValue
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Commit_Form()

    End Sub

    'Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
    '    If MsgBox("هل تريد حذف السجل الحالي", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, ProjectTitle) = MsgBoxResult.Yes Then
    '        MyDs.Tables("Check_Header").Rows.Clear()
    '        MyDs.Tables("Check_Details").Rows.Clear()
    '        If ProjectSettings.ShowSaveMsg = True Then
    '            cls.MsgInfo("تم حذف الفاتورة بنجاح")
    '        End If
    '        B_Edited = False
    '        Call ResetOrder(False)
    '    End If
    'End Sub

    Private Sub Quantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItem()
        End If

    End Sub

    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        RowID = DataGridView1.CurrentCell.RowIndex
    End Sub

    'Private Sub DataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
    '    If B_EndLoad = True Then

    '        If DataGridView1.Rows.Count <= 0 Then
    '            CountRecords.Text = 0
    '        Else
    '            CalculateTotalBill()
    '            CountRecords.Text = MyDs.Tables("Check_Details").Compute("Count(Item_ID)", "Check_ID=" & CheckID.SelectedValue)
    '        End If
    '    End If
    'End Sub



    'Private Sub Adjustments_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    If B_Edited = False Then
    '        e.Cancel = False
    '    Else
    '        e.Cancel = True
    '        cls.MsgExclamation("يجب حفظ الاذن او حذفه اولا")
    '    End If
    'End Sub

    Private Sub Adjustments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try

            cls.RefreshData("select * from procedure_master where procedure_category=N'جاري الشريك'", TblProMstr)
            cls.RefreshData(TblEmp, "Employees")
            cls.RefreshData("Check_Header")

            BSource.DataSource = MyDs
            BSource.DataMember = TName
            'Dim B As New BindingSource
            'B.DataSource = MyDs
            'B.DataMember = "Table_Columns"
            'B.Filter = "Table_ID ='" & TName & "'"
            'OrderByCombo.ComboBox.DataSource = B
            'OrderByCombo.ComboBox.DisplayMember = "Logical_Name"
            'OrderByCombo.ComboBox.ValueMember = "Physical_Name"

            CheckID.DataSource = MyDs
            CheckID.DisplayMember = "Check_Header.Check_Name"
            CheckID.ValueMember = "Check_Header.Check_ID"

            Col_Check_ID.DataPropertyName = "Check_ID"
            Col_Serial_PK.DataPropertyName = "Serial_PK"
            Col_Item_ID.DataPropertyName = "Item_ID"
            Col_Barcode.DataPropertyName = "Barcode"
            Col_Item_Name.DataPropertyName = "Item_Name"
            Col_System_Quantity.DataPropertyName = "System_Quantity"
            Col_User_Quantity.DataPropertyName = "User_Quantity"
            Col_Expired_Date.DataPropertyName = "Expired_Date"
            Col_Diff_Quantity.DataPropertyName = "Diff_Quantity"
            Col_Price.DataPropertyName = "Price"
            Col_Check_Type.DataPropertyName = "Check_Type"

            Col_Partner_ID.DataSource = TblProMstr
            Col_Partner_ID.ValueMember = "Procedure_Master_ID"
            Col_Partner_ID.DisplayMember = "Daily_Procedure_Name"
            Col_Partner_ID.DataPropertyName = "Partner_ID"

          

            Col_Employee_ID.DataSource = TblEmp
            Col_Employee_ID.ValueMember = "Employee_ID"
            Col_Employee_ID.DisplayMember = "Employee_Name"
            Col_Employee_ID.DataPropertyName = "Employee_ID"

            DataGridView1.DataSource = MyDs.Tables("Check_Details")

            'DataGridView1.Columns(0).Visible = False
            'DataGridView1.Columns(1).Visible = False
            'DataGridView1.Columns(2).Visible = False
            'DataGridView1.Columns(3).HeaderText = "اسم الصنف"
            'DataGridView1.Columns(3).ReadOnly = True
            'DataGridView1.Columns(4).HeaderText = "الباركود"
            'DataGridView1.Columns(4).ReadOnly = True
            'DataGridView1.Columns(5).HeaderText = "العدد الموجود بالبرنامج"
            'DataGridView1.Columns(5).ReadOnly = True
            'DataGridView1.Columns(6).HeaderText = "العدد المدخل"
            'DataGridView1.Columns(7).HeaderText = "تاريخ الصلاحيه"
            'DataGridView1.Columns(7).ReadOnly = True
            'DataGridView1.Columns(8).HeaderText = "الفرق"
            'DataGridView1.Columns(9).HeaderText = "سعر التكلفه"
            'DataGridView1.Columns(10).HeaderText = "سبب العجز"
            'DataGridView1.Columns(11).HeaderText = "جاري الشريك"
            'DataGridView1.Columns(12).HeaderText = "الموظف المسئول"


            'MyDs.Tables("Check_Details").Rows.Clear()
            'MyDs.Tables("Check_Header").Rows.Clear()

            'cmdPro.CommandType = CommandType.StoredProcedure
            'cmdPro.Connection = cn


            'CurID.DbType = DbType.Int32
            'CurID.ParameterName = "CURR_ID"
            'CurID.Direction = ParameterDirection.Output
            'SeqID.DbType = DbType.Int32
            'SeqID.ParameterName = "S_ID"
            'SeqID.Direction = ParameterDirection.Input
            'SeqID.Value = 3
            'cmdPro.Parameters.Add(SeqID)
            'cmdPro.Parameters.Add(CurID)
            'cmdPro.CommandText = "UPDATE_SEQ"

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BarCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarCode.Leave
        Try
            If BarCode.Text = "" Then
                cls.MsgExclamation("أدخل الباركود", "please enter barcode")
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
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim m As New CheckHeader
        m.ShowDialog()
    End Sub

    Private Sub RadioItemName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioItemName.CheckedChanged
        If RadioItemName.Checked = True Then
            ItemName.Enabled = True
            BarCode.Enabled = False
        End If
    End Sub

    Private Sub RadioBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBarcode.CheckedChanged
        If RadioBarcode.Checked = True Then
            ItemName.Enabled = False
            BarCode.Enabled = True
        End If
    End Sub

    Private Sub BtnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class