Public Class AttendanceShifts

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BsourceShifts As New BindingSource
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Attendance_Shifts"
    '-------------------------------
    Dim CurID, SeqID As New SqlClient.SqlParameter
    Dim cmdPro As New SqlClient.SqlCommand
    Dim ChqID As Integer
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
            SeqID.Value = 13
            cmdPro.Parameters.Add(SeqID)
            cmdPro.Parameters.Add(CurID)
            cmdPro.CommandText = "UPDATE_SEQ"


            cls.RefreshData(TName)

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

            Gcls = New GeneralSp.NewMasterForms(TName, BsourceShifts, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, BtnReload, BtnCancelSerach, BtnFirst, BtnPrevious, BtnNext, BtnLast, BtnFile, BtnData, BtnHelp, OrderByCombo, ContentPanel, MasterField1, CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "»Ì«‰«  Ê—œÌ«  «·Õ÷Ê—"
            Me.Text = Gcls.SetWTitle

            MasterField1.TextBox1.DataBindings.Add("Text", BsourceShifts, "Shift_Name")
            FromTime.DataBindings.Add("Text", BsourceShifts, "From_Time")
            ToTime.DataBindings.Add("Text", BsourceShifts, "To_Time")
            AttendFrom.DataBindings.Add("Text", BsourceShifts, "From_Attend")
            AttendTo.DataBindings.Add("Text", BsourceShifts, "To_Attend")
            DelayAllowed.DataBindings.Add("value", BsourceShifts, "Delay_Allowed")
            Saturday.DataBindings.Add("Checked", BsourceShifts, "Saturday", False)
            Sunday.DataBindings.Add("Checked", BsourceShifts, "Sunday", False)
            Monday.DataBindings.Add("Checked", BsourceShifts, "Monday", False)
            Tuseday.DataBindings.Add("Checked", BsourceShifts, "Tuesday", False)
            Wednesday.DataBindings.Add("Checked", BsourceShifts, "Wednesday", False)
            Thursday.DataBindings.Add("Checked", BsourceShifts, "Thursday", False)
            Friday.DataBindings.Add("Checked", BsourceShifts, "Friday", False)



            SSource = BsourceShifts

            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Pay_ID"

            B_EndLoad = True

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, MenuNew.Click
        Try
            MyDs.Tables("Attendance_Shifts").Columns("From_Time").DefaultValue = Now.TimeOfDay
            MyDs.Tables("Attendance_Shifts").Columns("To_Time").DefaultValue = Now.TimeOfDay
            MyDs.Tables("Attendance_Shifts").Columns("From_Attend").DefaultValue = Now.TimeOfDay
            MyDs.Tables("Attendance_Shifts").Columns("To_Attend").DefaultValue = Now.TimeOfDay
            Gcls.NewRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try
            Gcls.EditRecord()
        Catch
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try


            If MasterField1.TextBox1.Text = "" Then
                cls.MsgExclamation("»—Ã«¡ «œŒ· «”„ «·Ê—œÌ…")
                Exit Sub
            End If
            Gcls.SaveRecord()
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






    Private Sub OrderByCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderByCombo.SelectedIndexChanged
        Try
            If B_EndLoad = True Then
                Gcls.SortData(BsourceShifts, OrderByCombo.SelectedValue)
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
            BsourceShifts.RemoveFilter()
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


    Private Sub PayDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FromTime.GotFocus
        FromTime.BackColor = Color.FromArgb(135, 180, 209)

    End Sub

    Private Sub PayDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FromTime.Leave
        FromTime.BackColor = Color.Gainsboro
    End Sub



End Class
