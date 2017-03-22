Public Class Employees

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceEmployees As New BindingSource
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Employees"
    '-------------------------------
    Public SearchEmployeeID As Integer
    Dim TblJobs As New GeneralDataSet.jobsDataTable
    Dim TblDept As New GeneralDataSet.DepartmentsDataTable
    Dim TblInsurance As New GeneralDataSet.InsuranceDataTable
    Dim TblTaxes As New GeneralDataSet.Taxes_GroupsDataTable


    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData(TName)
            cls.RefreshData("select * from jobs", TblJobs)

            cls.RefreshData("select * from departments", TblDept)
            cls.RefreshData("select * from insurance", TblInsurance)
            ' cls.RefreshData("select * from attendance_Shifts", TblShifts)
            cls.RefreshData("select * from Taxes_Groups", TblTaxes)

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

            Gcls = New GeneralSp.NewMasterForms(TName, BSourceEmployees, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, BtnReload, BtnCancelSerach, BtnFirst, BtnPrevious, BtnNext, BtnLast, BtnFile, BtnData, BtnHelp, OrderByCombo, ContentPanel, MasterField1, CountRecords, MenuNew, MenuSave, MenuDelete, MenuSearch, MenuExit)



            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "������ ��������"
            Me.Text = Gcls.SetWTitle

            MasterField1.TextBox1.DataBindings.Add("Text", BSourceEmployees, "Employee_Name")
            Barcode.TextBox1.DataBindings.Add("Text", BSourceEmployees, "Barcode")
            Education.TextBox1.DataBindings.Add("Text", BSourceEmployees, "Education")
            Tele.TextBox1.DataBindings.Add("Text", BSourceEmployees, "Tele")
            Email.TextBox1.DataBindings.Add("Text", BSourceEmployees, "email")
            Mobile.TextBox1.DataBindings.Add("Text", BSourceEmployees, "Mobile")
            Address.TextBox1.DataBindings.Add("Text", BSourceEmployees, "Address")
            Salary.DataBindings.Add("Value", BSourceEmployees, "salary")
            HireDate.DataBindings.Add("Text", BSourceEmployees, "Hire_Date")

            JobID.DataSource = TblJobs
            JobID.DisplayMember = "Job_Title"
            JobID.ValueMember = "Job_ID"
            JobID.DataBindings.Add("SelectedValue", BSourceEmployees, "Job_ID")

            DepartmentID.DataSource = TblDept
            DepartmentID.DisplayMember = "Department_Name"
            DepartmentID.ValueMember = "Department_ID"
            DepartmentID.DataBindings.Add("SelectedValue", BSourceEmployees, "Department_ID")

            InsuranceID.DataSource = TblInsurance
            InsuranceID.DisplayMember = "Insurance_Name"
            InsuranceID.ValueMember = "Insurance_ID"
            InsuranceID.DataBindings.Add("SelectedValue", BSourceEmployees, "Insurance_ID")

            Emptax.DataSource = TblTaxes
            Emptax.DisplayMember = "Group_Name"
            Emptax.ValueMember = "Group_ID"
            Emptax.DataBindings.Add("SelectedValue", BSourceEmployees, "Tax_Group_ID")


            Photo.DataBindings.Add("backgroundImage", BSourceEmployees, "Photo", True)



            SSource = BSourceEmployees

            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Employee_Name"

            B_EndLoad = True

            If SearchEmployeeID <> 0 Then
                BSourceEmployees.Filter = "Employee_ID = " & SearchEmployeeID
            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, MenuNew.Click

        Try
            MyDs.Tables(TName).Columns("Hire_Date").DefaultValue = Now.ToString("dd/MM/yyyy")
            Gcls.NewRecord()
            MasterField1.TextBox1.Focus()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try
            If MasterField1.TextBox1.Text = "" Then
                cls.MsgComplete()
                MasterField1.TextBox1.Focus()
                MasterField1.TextBox1.BackColor = Color.Yellow
            ElseIf JobID.Text = "" Then
                cls.MsgComplete()
                JobID.Focus()
            ElseIf DepartmentID.Text = "" Then
                cls.MsgComplete()
                DepartmentID.Focus()
            ElseIf Salary.Value <= 0 Then
                cls.MsgComplete()
                Salary.Focus()
                Salary.BackColor = Color.Yellow
            ElseIf Emptax.SelectedValue = Nothing Or InsuranceID.SelectedValue = Nothing Then
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
            Salary.BackColor = Color.Gainsboro
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
            MasterField1.TextBox1.Focus()
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
                Gcls.SortData(BSourceEmployees, OrderByCombo.SelectedValue)
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
            BSourceEmployees.RemoveFilter()
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
        Dim ad As New Jobs
        ad.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ss As New Departments
        ss.ShowDialog()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Try
            Dim Fpath As String = ""

l:
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog1.Title = "���� ���� ������ ��� �������"
            OpenFileDialog1.Filter = "Image Files|*.JPG;*.JPEG;*.png;*.Gif;"
            If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then
                If MsgBox("�� ��� ������ ������ �� ���� ����� �������� �", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, ProjectTitle) = DialogResult.Yes Then
                    GoTo l
                End If
            Else
                Fpath = OpenFileDialog1.FileName
            End If

            Photo.BackgroundImage = Image.FromFile(Fpath)
        Catch ex As Exception
            Dim s As String = ""
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Photo.BackgroundImage = Nothing
    End Sub

    Private Sub Salary_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Salary.GotFocus
        Salary.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub Salary_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salary.Leave

        Salary.BackColor = Color.White
    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim m As New EmpAddedHours
        m.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim m As New Jobs
        m.ShowDialog()
        cls.RefreshData("Jobs")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim m As New Departments
        m.ShowDialog()
        cls.RefreshData("Departments")
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
        Dim m As New QueryEmployeesRewards
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
        Dim m As New EmployeesTasks
        m.ShowDialog()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim m As New EmployeesVacations
        m.ShowDialog()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Dim m As New Insurance
        m.ShowDialog()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New AttendanceShifts
        m.ShowDialog()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Dim m As New Taxes
        m.ShowDialog()
    End Sub
End Class
