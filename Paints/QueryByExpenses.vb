Public Class QueryByExpenses
    Dim t As New DataTable
    Private Sub QueryByExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EmployeeID.DataSource = MyDs
        EmployeeID.DisplayMember = "employees.Employee_name"
        EmployeeID.ValueMember = "employees.employee_id"
        DataGridView1.Columns(0).HeaderText = ""
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.CommandText = "select * from Query_Employees_Discounts where employee_id = " & EmployeeID.SelectedValue
        da.SelectCommand = cmd
        da.Fill(t)
        DataGridView1.DataSource = t

    End Sub
End Class