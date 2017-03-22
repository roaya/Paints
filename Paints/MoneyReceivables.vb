Public Class MoneyReceivables

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceMoneyReceivables As New BindingSource
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Money_Receivables"
    '-------------------------------
    Dim CurID, SeqID As New SqlClient.SqlParameter
    Dim cmdPro As New SqlClient.SqlCommand
    Private TblProMstr As New GeneralDataSet.Procedure_MasterDataTable
    Dim ChqID As Integer
    Private Rpt As New RptReceivePay
    Private m As New ShowAllReports


    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cmdPro.CommandType = CommandType.StoredProcedure
            cmdPro.Connection = cn


            CurID.DbType = DbType.Int32
            CurID.ParameterName = "CURR_ID"
            CurID.Direction = ParameterDirection.Output
            SeqID.DbType = DbType.Int32
            SeqID.ParameterName = "S_ID"
            SeqID.Direction = ParameterDirection.Input
            SeqID.Value = 12
            cmdPro.Parameters.Add(SeqID)
            cmdPro.Parameters.Add(CurID)
            cmdPro.CommandText = "UPDATE_SEQ"

            cls.RefreshData("Money_Receivables")
            cls.RefreshData("select * from procedure_master", TblProMstr)

            Dim B As New BindingSource
            B.DataSource = MyDs
            B.DataMember = "Table_Columns"
            B.Filter = "Table_ID ='" & TName & "'"
            OrderByCombo.DataSource = B
            OrderByCombo.DisplayMember = "Logical_Name"
            OrderByCombo.ValueMember = "Physical_Name"

            '-------------------------------
            'Must Specify Data Table Name
            '-------------------------------

            Gcls = New GeneralSp.NewMasterForms(TName, BSourceMoneyReceivables, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, BtnReload, BtnCancelSerach, BtnFirst, BtnPrevious, BtnNext, BtnLast, BtnFile, BtnData, BtnHelp, OrderByCombo, ContentPanel, MasterField1, CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "������ ����� �����"
            Me.Text = Gcls.SetWTitle

            MasterField1.TextBox1.DataBindings.Add("Text", BSourceMoneyReceivables, "Rec_ID")
            RecDate.DataBindings.Add("Text", BSourceMoneyReceivables, "Rec_Date")
            RecType.DataBindings.Add("Text", BSourceMoneyReceivables, "Rec_Type")
            RecValue.DataBindings.Add("Value", BSourceMoneyReceivables, "Rec_Value")
            RecDesc.DataBindings.Add("Text", BSourceMoneyReceivables, "Rec_Desc")
            TxtCheque.DataBindings.Add("Text", BSourceMoneyReceivables, "Cheque_Number")

            FromProcedureMasterID.DataSource = TblProMstr
            FromProcedureMasterID.DisplayMember = "Daily_Procedure_Name"
            FromProcedureMasterID.ValueMember = "Procedure_Master_ID"
            FromProcedureMasterID.DataBindings.Add("SelectedValue", BSourceMoneyReceivables, "From_Procedure_Master_ID")

            SSource = BSourceMoneyReceivables

            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Rec_ID"

            B_EndLoad = True

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, MenuNew.Click
        Try
            cmdPro.ExecuteNonQuery()
            MyDs.Tables("Money_Receivables").Columns("Rec_ID").DefaultValue = CurID.Value
            Gcls.NewRecord()

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try
            If FromProcedureMasterID.SelectedValue = Nothing Then
                cls.MsgComplete()
                FromProcedureMasterID.Focus()
                FromProcedureMasterID.BackColor = Color.Yellow
            ElseIf MasterField1.TextBox1.Text = "" Or RecValue.Value = 0 Or RecType.Text = "" Then
                cls.MsgComplete()
            Else

                If RecType.Text = "����" Then
                    If TxtCheque.Text = "" Then
                        cls.MsgExclamation("���� ��� �����", "")
                        Exit Sub
                    Else
                        cmd.CommandText = "select dbo.Is_Cheque_Valid('" & TxtCheque.Text & "')"
                        ChqID = cmd.ExecuteScalar
                        If ChqID = 0 Then
                            cls.MsgExclamation("����� ��� ���� ���������", "CURRENT CHEQUE NUMBER ISNOT VALID")
                            TxtCheque.Focus()
                            Exit Sub
                        Else
                            cmd.CommandText = "select cheque_value from cheques where cheque_number = " & TxtCheque.Text
                            RecValue.Value = cmd.ExecuteScalar
                        End If
                    End If
                End If

                If RecType.Text = "����" Then
                    cmd.CommandText = "Exec Commit_Procedure_Tran dbo.Get_Employee_Account_ID(" & EmpIDVar & ")," & FromProcedureMasterID.SelectedValue & " , " & RecValue.Value & ",N'" & RecDesc.Text & " - " & EmpNameVar & "'," & CurrentShiftID & "," & CurID.Value & ",N'��� ���'"
                    cmd.ExecuteNonQuery()
                ElseIf RecType.Text = "����" Then
                    REM cmd.CommandText = "select dbo.Get_Bank_Procedure_ID(" & TxtCheque.Text & ")"
                    REM FromAccID = cmd.ExecuteScalar
                    cmd.CommandText = "Exec Commit_Procedure_Tran 23," & FromProcedureMasterID.SelectedValue & "," & RecValue.Value & ",N'" & RecDesc.Text & " - " & EmpNameVar & "'," & CurrentShiftID & "," & CurID.Value & ",N'��� ���'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "UPDATE Cheques SET Cheque_Status=N'��� ����' WHERE Cheque_No = '" & TxtCheque.Text & "'"
                    cmd.ExecuteNonQuery()
                End If


                Gcls.SaveRecord()
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click, MenuDelete.Click
        Try
            Gcls.DeleteRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Try
            Gcls.LastRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Try
            Gcls.NextRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnPervious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        Try
            Gcls.PreviousRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Try
            Gcls.FirstRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click, MenuSearch.Click
        Try
            Rpt.ReportDefinition.ReportObjects.Item("TitleRecMoney").ObjectFormat.EnableSuppress = False
            Rpt.ReportDefinition.ReportObjects.Item("TitlePayMoney").ObjectFormat.EnableSuppress = True
            Rpt.ReportDefinition.ReportObjects.Item("TxtReceive").ObjectFormat.EnableSuppress = False
            Rpt.ReportDefinition.ReportObjects.Item("TxtPay").ObjectFormat.EnableSuppress = True

            MyDs.Tables("ReceivePay").Rows.Clear()
            r = MyDs.Tables("ReceivePay").NewRow
            r("Rec_ID") = MasterField1.TextBox1.Text
            r("Account_Name") = FromProcedureMasterID.Text
            r("Account_Date") = RecDate.Text
            r("Account_Value") = RecValue.Value
            r("Account_Desc") = RecDesc.Text
            If RecType.Text = "����" Then
                r("Account_Type") = "���"

            ElseIf RecType.Text = "����" Then
                r("Account_Type") = "����"
            End If
            MyDs.Tables("ReceivePay").Rows.Add(r)
            Rpt.SetDataSource(MyDs.Tables("ReceivePay"))
            m.CrystalReportViewer1.ReportSource = Rpt
            m.ShowDialog()

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub



    'Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Gcls.CutData(ContentPanel)
    '    Catch ex As Exception
    '        cls.WriteError(ex.Message, TName)
    '    End Try
    'End Sub

    'Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Gcls.CopyData(ContentPanel)
    '    Catch ex As Exception
    '        cls.WriteError(ex.Message, TName)
    '    End Try
    'End Sub

    'Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Gcls.PasteData(ContentPanel)
    '    Catch ex As Exception
    '        cls.WriteError(ex.Message, TName)
    '    End Try
    'End Sub

    Private Sub OrderByCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderByCombo.SelectedIndexChanged
        Try
            If B_EndLoad = True Then
                Gcls.SortData(BSourceMoneyReceivables, OrderByCombo.SelectedValue)
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub



    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click, MenuExit.Click
        Try
            Gcls.ExitForm()
            Me.Close()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReload.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Gcls.ReloadData()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    Private Sub BtnCancelSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelSerach.Click
        Try
            BSourceMoneyReceivables.RemoveFilter()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFile.Click
        Gcls.BtnFile()
    End Sub

    Private Sub BtnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnData.Click
        Gcls.BtnData()
    End Sub

    Private Sub BtnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHelp.Click
        Gcls.BtnHelp()
    End Sub

    Private Sub RecType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecType.SelectedIndexChanged
        If RecType.Text = "����" Then
            TxtCheque.Enabled = True
        Else
            TxtCheque.Enabled = False
        End If
    End Sub

    Private Sub FromProcedureMasterID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FromProcedureMasterID.GotFocus
        FromProcedureMasterID.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub FromProcedureMasterID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FromProcedureMasterID.Leave

        FromProcedureMasterID.BackColor = Color.Gainsboro
    End Sub

    Private Sub RecValue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecValue.GotFocus
        RecValue.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub RecValue_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecValue.Leave
        RecValue.BackColor = Color.Gainsboro
    End Sub

    Private Sub RecDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecDesc.GotFocus
        RecDesc.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub RecDesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecDesc.Leave
        RecDesc.BackColor = Color.Gainsboro
    End Sub

    Private Sub RecDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecDate.GotFocus
        RecDate.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub RecDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RecDate.Leave
        RecDate.BackColor = Color.Gainsboro
    End Sub

    Private Sub TxtCheque_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCheque.GotFocus
        TxtCheque.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub TxtCheque_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCheque.Leave
        TxtCheque.BackColor = Color.Gainsboro
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim m As New ProceduresTrans
        m.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim m As New Employees
        m.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim m As New Customers
        m.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m As New Vendors
        m.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim m As New MoneyPayments
        m.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim m As New MasterRecord
        m.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim m As New DailyProcedures
        m.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim m As New ReportDailyPro
        m.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim m As New ReportMoneyPayments
        m.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim m As New ReportAllCustVenTran
        m.ShowDialog()
    End Sub
End Class
