Public Class EmpAddedHours

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceEmployees_Added_Hours As New BindingSource
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Employees_Added_Hours"
    '-------------------------------
    Dim d As Date
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

            Gcls = New GeneralSp.NewMasterForms(TName, BSourceEmployees_Added_Hours, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, BtnReload, BtnCancelSerach, BtnFirst, BtnPrevious, BtnNext, BtnLast, BtnFile, BtnData, BtnHelp, OrderByCombo, ContentPanel, , CountRecords, MenuNew, MenuSave, MenuDelete, MenuSearch, MenuExit)



            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "����� ����� ��������"
            Me.Text = Gcls.SetWTitle

            EmployeeID.DataSource = TblEmp
            EmployeeID.DisplayMember = "Employee_Name"
            EmployeeID.ValueMember = "Employee_ID"
            EmployeeID.DataBindings.Add("SelectedValue", BSourceEmployees_Added_Hours, "Employee_ID")

            HoursDate.DataBindings.Add("Text", BSourceEmployees_Added_Hours, "Hours_Date")
            FromTime.DataBindings.Add("Text", BSourceEmployees_Added_Hours, "From_Time")
            ToTime.DataBindings.Add("Text", BSourceEmployees_Added_Hours, "to_Time")
            RewardValue.DataBindings.Add("Value", BSourceEmployees_Added_Hours, "reward_Value")


            SSource = BSourceEmployees_Added_Hours

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
            MyDs.Tables("Employees_Added_Hours").Columns("hours_date").DefaultValue = Now.ToString("dd/MM/yyyy")
            FromTime.Text = Now.ToLongTimeString
            ToTime.Text = Now.ToLongTimeString
            Gcls.NewRecord()
            EmployeeID.Focus()

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try
            'MsgBox(FromTime.Text)
            d = HoursDate.Text
            If EmployeeID.Text = "" Then
                cls.MsgComplete()
            Else

                cmd.CommandText = "select COUNT(*) FROM Employees_Vacations WHERE '" & d.ToString("MM/dd/yyyy") & "' BETWEEN From_Date AND To_Date and employee_id = " & EmployeeID.SelectedValue
                If cmd.ExecuteScalar > 0 Then
                    cls.MsgExclamation("�� ����� ������ ��� ������ ������ �� ��� ������", "this employee has been registered as in vacation during this period")

                ElseIf FromTime.Text = "" Then
                    cls.MsgComplete()
                    FromTime.Focus()
                    FromTime.BackColor = Color.Yellow
                ElseIf ToTime.Text = "" Then
                    cls.MsgComplete()
                    ToTime.Focus()
                    ToTime.BackColor = Color.Yellow
                ElseIf RewardValue.Value = 0 Then
                    cls.MsgComplete()
                    RewardValue.Focus()
                    RewardValue.BackColor = Color.Yellow
                Else

                    Gcls.SaveRecord()
                End If
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
            EmployeeID.focus
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
                Gcls.SortData(BSourceEmployees_Added_Hours, OrderByCombo.SelectedValue)
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
            BSourceEmployees_Added_Hours.RemoveFilter()
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim aa As New Employees
        aa.ShowDialog()

    End Sub

    Private Sub RewardValue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RewardValue.GotFocus
        RewardValue.BackColor = Color.FromArgb(135, 180, 209)

    End Sub

    Private Sub RewardValue_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RewardValue.Leave

        RewardValue.BackColor = Color.White

    End Sub

    Private Sub ToTime_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToTime.GotFocus
        ToTime.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub ToTime_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToTime.Leave
        ToTime.BackColor = Color.Gainsboro
    End Sub

    Private Sub FromTime_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FromTime.GotFocus
        FromTime.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub FromTime_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FromTime.Leave
        FromTime.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim m As New Employees
        m.ShowDialog()
        cls.RefreshData(TblEmp, "Employees")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim M As New Jobs
        M.ShowDialog()
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
        Dim m As New EmployeesDiscounts
        m.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim m As New RewardsCategories
        m.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim m As New EmployeesRewards
        m.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim m As New PaySalary
        m.ShowDialog()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim m As New QueryByEmployee
        m.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim m As New QueryEmpByJobDep
        m.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m As New QueryEmployeesRewards
        m.ShowDialog()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim m As New EmployeesTasks
        m.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim m As New EmployeesVacations
        m.ShowDialog()
    End Sub
End Class
