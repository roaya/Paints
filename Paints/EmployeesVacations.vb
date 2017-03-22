Public Class EmployeesVacations

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceEmployeesVacations As New BindingSource

    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Employees_Vacations"
    Private TblEmp As New GeneralDataSet.EmployeesDataTable


    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData(TName)
            cls.RefreshData(TblEmp, "Employees")


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

            Gcls = New GeneralSp.NewMasterForms(TName, BSourceEmployeesVacations, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, BtnReload, BtnCancelSerach, BtnFirst, BtnPrevious, BtnNext, BtnLast, BtnFile, BtnData, BtnHelp, OrderByCombo, ContentPanel, , CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "√Ã«“«  «·„ÊŸ›Ì‰"
            Me.Text = Gcls.SetWTitle

            EmployeeID.DataSource = TblEmp
            EmployeeID.DisplayMember = "Employee_Name"
            EmployeeID.ValueMember = "Employee_ID"
            EmployeeID.DataBindings.Add("SelectedValue", BSourceEmployeesVacations, "Employee_ID")

            FromDate.DataBindings.Add("Text", BSourceEmployeesVacations, "From_Date")
            ToDate.DataBindings.Add("Text", BSourceEmployeesVacations, "To_Date")

            SSource = BSourceEmployeesVacations

            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Gender_Name"

            B_EndLoad = True

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, MenuNew.Click
        Try
            Gcls.NewRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try
            If EmployeeID.Text = "" Then
                cls.MsgComplete()
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
                Gcls.SortData(BSourceEmployeesVacations, OrderByCombo.SelectedValue)
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
            BSourceEmployeesVacations.RemoveFilter()
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
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim m As New Employees
        m.ShowDialog()
        cls.RefreshData(TblEmp, "Employees")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim m As New Jobs
        m.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim m As New Departments
        m.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim m As New DiscountCategories
        m.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim m As New EmpAddedHours
        m.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim m As New RewardsCategories
        m.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim m As New EmployeesDiscounts
        m.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim m As New PaySalary
        m.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim m As New CheckHeader
        m.ShowDialog()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim m As New CheckDetails
        m.ShowDialog()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim m As New AppUsers
        m.ShowDialog()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim m As New Attendance
        m.ShowDialog()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim m As New QueryByEmployee
        m.ShowDialog()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim m As New QueryEmpByJobDep
        m.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim m As New EmployeesRewards
        m.ShowDialog()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim m As New QueryAttendance
        m.ShowDialog()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim m As New ReportUserLog
        m.ShowDialog()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim m As New EmployeesRewards
        m.ShowDialog()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim m As New EmployeesTasks
        m.ShowDialog()
    End Sub
End Class
