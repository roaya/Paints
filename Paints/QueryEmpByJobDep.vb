Public Class QueryEmpByJobDep

    Dim t As New DataTable

    Private Sub QueryEmpByJobDep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cls.RefreshData("Jobs")
            cls.RefreshData("Departments")

            JobID.DataSource = MyDs
            JobID.DisplayMember = "Jobs.Job_Title"
            JobID.ValueMember = "Jobs.Job_ID"

            DepartmentID.DataSource = MyDs
            DepartmentID.DisplayMember = "Departments.Department_Name"
            DepartmentID.ValueMember = "Departments.Department_ID"
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Emp Job Dep")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If RadioJobID.Checked = True Then
                If JobID.Text = "" Then
                    cls.MsgExclamation("اختر المسمي الوظيفي", "please enter job title")
                Else
                    t.Rows.Clear()
                    cmd.CommandText = "select employee_name as 'اسم الموظف' , hire_date as 'تاريخ التعاقد' , salary as 'المرتب' , mobile as 'الموبايل' , tele as 'التليفون' , address as 'العنوان' from employees where job_id = " & JobID.SelectedValue
                    da.SelectCommand = cmd
                    da.Fill(t)
                    DataGridView1.DataSource = t
                End If
            ElseIf RadioDepID.Checked = True Then
                If DepartmentID.Text = "" Then
                    cls.MsgExclamation("اختر اسم الادارة", "please enter department name")
                Else
                    t.Rows.Clear()
                    cmd.CommandText = "select employee_name as 'اسم الموظف' , hire_date as 'تاريخ التعاقد' , salary as 'المرتب' , mobile as 'الموبايل' , tele as 'التليفون' , address as 'العنوان' from employees where department_id = " & DepartmentID.SelectedValue
                    da.SelectCommand = cmd
                    da.Fill(t)
                    DataGridView1.DataSource = t
                End If
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Emp Job Dep")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioJobID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioJobID.CheckedChanged
        If RadioJobID.Checked = True Then
            JobID.Enabled = True
            DepartmentID.Enabled = False
        End If
    End Sub

    Private Sub RadioDepID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioDepID.CheckedChanged
        If RadioDepID.Checked = True Then
            DepartmentID.Enabled = True
            JobID.Enabled = False
        End If
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackgroundImage = My.Resources._end
        Button1.ForeColor = Color.White

    End Sub

    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.BackgroundImage = My.Resources._end
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.enter
        Button1.ForeColor = Color.Black

    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.enter
        Button2.ForeColor = Color.Black
    End Sub
End Class