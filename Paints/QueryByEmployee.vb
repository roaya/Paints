Public Class QueryByEmployee

    Dim B_EndLoad As Boolean = False
    Dim ITEM_NAME As String
    Dim selformula As String
    Dim Query_Employee As New DataTable
    Dim d1, d2 As Date

    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Query_Employees"
    Private Sub QueryByEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataClear()
        DataLoad()
    End Sub
#Region "DataMethods"
    Private Sub DataClear()
        cmbJops.SelectedIndex = -1
        cmbEmployeeID.SelectedIndex = -1
        RadJop.Checked = False
        Query_Employee.Rows.Clear()
        RadEmpID.Checked = True
    End Sub
    Private Sub DataLoad()
        cmd.CommandText = "select Job_Title from Jobs"
        dr = cmd.ExecuteReader
        Do While Not dr.Read = False
            cmbJops.Items.Add(dr("Job_Title"))
        Loop
        dr.Close()
        cmd.CommandText = "select Employee_Name from Employees"
        dr = cmd.ExecuteReader
        Do While Not dr.Read = False
            cmbEmployeeID.Items.Add(dr("Employee_Name"))
        Loop
        dr.Close()
    End Sub

    Private Function DataValidate(ByVal errorMessage As String) As Boolean
        If cmbJops.SelectedIndex = -1 And
            cmbEmployeeID.SelectedIndex = -1 Then
            DataValidate = False
            errorMessage = "All required fields not been enterd data."
        Else
            DataValidate = True
            errorMessage = ""

        End If

    End Function

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        choseForm()
        DataClear()
        cmd.CommandText = "" & selformula & ""
        da.SelectCommand = cmd
        If cmd.CommandText = "" Then cls.MsgExclamation("من فضلك ادخل البيانات الناقصة", "please enter missing data") : Exit Sub
        da.Fill(Query_Employee)
        If Query_Employee.Rows.Count > 0 Then
            TabControl1.SelectedTab = TabPage2
            DataGridView1.Refresh()
            DataGridView1.DataSource = Query_Employee
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(0).HeaderText = "كود الموظف"
            DataGridView1.Columns(1).HeaderText = "اسم الموظف"
            DataGridView1.Columns(2).HeaderText = "الوظيفة"
            DataGridView1.Columns(3).HeaderText = "العنوان"
            DataGridView1.Columns(4).HeaderText = "التليفون"
            DataGridView1.Columns(5).HeaderText = "المحمول"
            DataGridView1.Columns(6).HeaderText = "المرتب"
            DataGridView1.Columns(7).HeaderText = "تاريخ التعيين"
            DataGridView1.Columns(8).HeaderText = "المستوى التعليمى"
            DataGridView1.Columns(9).HeaderText = "البريد الالكترونى"
        Else
            cls.MsgExclamation("من فضلك ادخل البيانات الناقصة", "please enter missing data")
        End If

    End Sub

    Private Sub RadEmpID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadEmpID.CheckedChanged
        If RadEmpID.Checked = True Then
            cmbEmployeeID.Enabled = True
        Else
            cmbEmployeeID.Enabled = False
            cmbEmployeeID.SelectedIndex = -1
        End If
        cmbJops.SelectedIndex = -1
        cmbJops.Enabled = False
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False

    End Sub

    Private Sub RadJop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadJop.CheckedChanged
        If RadJop.Checked = True Then
            cmbJops.Enabled = True
        Else
            cmbJops.Enabled = False
            cmbJops.SelectedIndex = -1
        End If
        cmbEmployeeID.SelectedIndex = -1
        cmbEmployeeID.Enabled = False
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub RadHirdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadHirdate.CheckedChanged
        If RadHirdate.Checked = True Then
            RadHirdate.Enabled = True
        Else
            cmbJops.Enabled = False
            cmbJops.SelectedIndex = -1
        End If
        cmbEmployeeID.SelectedIndex = -1
        cmbEmployeeID.Enabled = False
        cmbJops.SelectedIndex = -1
        cmbJops.Enabled = False
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
    End Sub
    Private Sub choseForm()
        selformula = ""
        If cmbEmployeeID.SelectedIndex <> -1 Then
            selformula = "select * from Query_Employees where Employee_Name=N'" & (cmbEmployeeID.Text) & "'"

        End If

        If cmbJops.SelectedIndex <> -1 Then
            selformula = "select * from Query_Employees where Job_Title=N'" & (cmbJops.Text) & "'"
        End If


        If RadHirdate.Checked = True Then
            d1 = DateTimePicker1.Text
            d2 = DateTimePicker2.Text

            selformula = "select * from Query_Employees where Hire_Date between '" & d1.ToString("MM/dd/yyyy") & "'  and   '" & d2.ToString("MM/dd/yyyy") & "'"

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.GotFocus
        Button1.BackgroundImage = My.Resources._end
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Leave
        Button1.BackgroundImage = My.Resources.enter
        Button1.ForeColor = Color.Black

    End Sub

    Private Sub Button2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Leave
        Button2.BackgroundImage = My.Resources.enter
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.GotFocus
        Button2.BackgroundImage = My.Resources._end
        Button2.ForeColor = Color.White
    End Sub

    Private Sub cmbEmployeeID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEmployeeID.GotFocus
        cmbEmployeeID.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub cmbEmployeeID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEmployeeID.Leave
        cmbEmployeeID.BackColor = Color.Gainsboro
    End Sub

    Private Sub cmbJops_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJops.GotFocus
        cmbJops.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub cmbJops_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJops.Leave
        cmbJops.BackColor = Color.Gainsboro
    End Sub
End Class