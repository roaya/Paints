Public Class ProceduresTrans

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceProceduresDetails As New BindingSource
    Private FromProMstr As New GeneralDataSet.Procedure_MasterDataTable
    Private ToProMstr As New GeneralDataSet.Procedure_Master1DataTable

    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Procedure_Details"

    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData(TName)
            cls.RefreshData("select * from Procedure_Master order by daily_procedure_name", FromProMstr)
            cls.FillSelectedTable("select Procedure_Master_ID,Daily_Procedure_Name from procedure_master order by daily_procedure_name", ToProMstr)

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

            Gcls = New GeneralSp.NewMasterForms(TName, BSourceProceduresDetails, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, BtnReload, BtnCancelSerach, BtnFirst, BtnPrevious, BtnNext, BtnLast, BtnFile, BtnData, BtnHelp, OrderByCombo, ContentPanel, , CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "���� �������"
            Me.Text = Gcls.SetWTitle

            FromProcedure.DataSource = FromProMstr
            FromProcedure.DisplayMember = "Daily_Procedure_Name"
            FromProcedure.ValueMember = "Procedure_Master_ID"
            FromProcedure.DataBindings.Add("SelectedValue", BSourceProceduresDetails, "From_Procedure_Master_ID")

            ToProcedure.DataSource = ToProMstr
            ToProcedure.DisplayMember = "Daily_Procedure_Name"
            ToProcedure.ValueMember = "Procedure_Master_ID"
            ToProcedure.DataBindings.Add("SelectedValue", BSourceProceduresDetails, "to_Procedure_Master_ID")

            ProcedureValue.DataBindings.Add("Value", BSourceProceduresDetails, "Procedure_Value")
            ProcedureDate.DataBindings.Add("Text", BSourceProceduresDetails, "Procedure_Date")

            ProcedureDesc.DataBindings.Add("Text", BSourceProceduresDetails, "Procedure_Desc")

            SSource = BSourceProceduresDetails

            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Daily_Procedure_Name"

            B_EndLoad = True

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, MenuNew.Click
        Try
            MyDs.Tables("Procedure_Details").Columns("Shift_Detail_ID").DefaultValue = CurrentShiftID
            MyDs.Tables("Procedure_Details").Columns("Doc_ID").DefaultValue = 0
            MyDs.Tables("Procedure_Details").Columns("Doc_Type").DefaultValue = "���� �����"
            MyDs.Tables("Procedure_Details").Columns("Procedure_Date").DefaultValue = Today
            Gcls.NewRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try
            If FromProcedure.SelectedValue = Nothing Or ToProcedure.SelectedValue = Nothing Then
                cls.MsgComplete()
            ElseIf ProcedureValue.Value = 0 Then
                ProcedureValue.BackColor = Color.Gainsboro
                ProcedureValue.Focus()
                cls.MsgComplete()
            Else
                ProcedureValue.BackColor = Color.Gainsboro

                Gcls.SaveRecord()
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click, MenuDelete.Click
        Try
            ProcedureValue.BackColor = Color.Gainsboro

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
            Gcls.EditRecord()
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
                Gcls.SortData(BSourceProceduresDetails, OrderByCombo.SelectedValue)
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
            BSourceProceduresDetails.RemoveFilter()
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

    Private Sub ProcedureValue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProcedureValue.GotFocus
        ProcedureValue.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub ProcedureValue_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcedureValue.Leave
        If ProcedureValue.Value > 0 Then
            ProcedureValue.BackColor = Color.Gainsboro
        End If
    End Sub

    Private Sub ProcedureDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProcedureDesc.GotFocus
        ProcedureDesc.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub ProcedureDesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProcedureDesc.Leave
        ProcedureDesc.BackColor = Color.Gainsboro
    End Sub




    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim m As New MoneyPayments
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
        Dim m As New MoneyReceivables
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
