Public Class Visa

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceVisa As New BindingSource

    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Visa"
    '-------------------------------
    Public SearchVisaID As Integer

    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData("Banks_Accounts")
            cls.RefreshData("Visa")

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

            Gcls = New GeneralSp.NewMasterForms(TName, BSourceVisa, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, BtnReload, BtnCancelSerach, BtnFirst, BtnPrevious, BtnNext, BtnLast, BtnFile, BtnData, BtnHelp, OrderByCombo, ContentPanel, MasterField1, CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "»Ì«‰«  ›Ì“«"
            Me.Text = Gcls.SetWTitle

            MasterField1.TextBox1.DataBindings.Add("Text", BSourceVisa, "Visa_Number")
            VisaStatus.DataBindings.Add("Checked", BSourceVisa, "Visa_Status", True)
            CreatedDate.DataBindings.Add("Text", BSourceVisa, "Created_Date")
            AccountID.DataSource = MyDs
            AccountID.DisplayMember = "Banks_Accounts.Account_Number"
            AccountID.ValueMember = "Banks_Accounts.Account_ID"
            AccountID.DataBindings.Add("SelectedValue", BSourceVisa, "Account_ID")

            SSource = BSourceVisa

            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Visa_Number"

            B_EndLoad = True

            If SearchVisaID <> 0 Then
                BSourceVisa.Filter = "Visa_ID = " & SearchVisaID
            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, MenuNew.Click
        Try
            MyDs.Tables(TName).Columns("Created_Date").DefaultValue = Today
            Gcls.NewRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try
            If MasterField1.TextBox1.Text = "" Then
                cls.MsgExclamation("»—Ã«¡ «œŒ· —ﬁ„ «·›Ì“«")
                MasterField1.TextBox1.Focus()
                MasterField1.TextBox1.BackColor = Color.Yellow
            ElseIf AccountID.Text = "" Then
                cls.MsgExclamation("»—Ã«¡ «œŒ· —ﬁ„ «·Õ”«»")
                AccountID.Focus()
            Else
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
                Gcls.SortData(BSourceVisa, OrderByCombo.SelectedValue)
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
            BSourceVisa.RemoveFilter()
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

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim m As New ReportBanksBalance
        m.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim m As New QueryCheques
        m.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim m As New ReportMoneyPayments
        m.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m As New Banks
        m.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim m As New BankAccounts
        m.ShowDialog()

        cls.RefreshData("Banks_Accounts")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim m As New ReportDailyPro
        m.ShowDialog()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim m As New DailyProcedures
        m.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim m As New ProceduresTrans
        m.ShowDialog()

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim m As New Cheques
        M.showdialog()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim m As New MasterRecord
        m.ShowDialog()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim m As New MoneyPayments
        m.ShowDialog()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim m As New MoneyReceivables
        m.ShowDialog()

    End Sub
End Class
