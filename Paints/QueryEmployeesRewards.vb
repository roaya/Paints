Public Class QueryEmployeesRewards

    Dim B_EndLoad As Boolean = False
    Dim ITEM_NAME As String
    Dim selformula As String
    Dim QueryEmployeesRewardsTable As New DataTable
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Query_Employees_Rewards"
    Private Sub QueryByEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataClear()
        DataLoad()
        RadEmpID.Checked = True
    End Sub
#Region "DataMethods"
    Private Sub DataClear()
        cmbCat.SelectedIndex = -1
        cmbEmployeeID.SelectedIndex = -1
        RadJop.Checked = False
        'DataGridView1.Rows.Clear()
        QueryEmployeesRewardsTable.Rows.Clear()
        'DataGridView1.DataSource = DBNull.Value
        'DataGridView1.ColumnCount = 5

    End Sub
    Private Sub DataLoad()
        cmd.CommandText = "select Category_Name from Rewards_Categories"
        dr = cmd.ExecuteReader
        Do While Not dr.Read = False
            cmbCat.Items.Add(dr("Category_Name"))
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
        If cmbCat.SelectedIndex = -1 And
            cmbEmployeeID.SelectedIndex = -1 Then
            DataValidate = False
            errorMessage = "لا توجد بيانات."
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
        If cmd.CommandText = "" Then MsgBox("لا توجد بيانات") : Exit Sub
        da.Fill(QueryEmployeesRewardsTable)
        If QueryEmployeesRewardsTable.Rows.Count > 0 Then
            TabControl1.SelectedTab = TabPage2
            DataGridView1.Refresh()
            DataGridView1.DataSource = QueryEmployeesRewardsTable
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(0).HeaderText = "نوع المكافاءة"
            DataGridView1.Columns(1).HeaderText = "اسم الموظف"
            DataGridView1.Columns(2).HeaderText = "تاريخ المكافاءة"
            DataGridView1.Columns(3).HeaderText = "سبب المكافاءة"
            DataGridView1.Columns(4).HeaderText = "قيمة المكافاءة"
            DataGridView1.Columns(5).HeaderText = "كود الموظف"
            DataGridView1.Columns(6).HeaderText = "كود المكافأة"
        Else
            MsgBox("لا توجد بيانات")
        End If

    End Sub

    Private Sub RadEmpID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadEmpID.CheckedChanged
        If RadEmpID.Checked = True Then
            cmbEmployeeID.Enabled = True
        Else
            cmbEmployeeID.Enabled = False
            cmbEmployeeID.SelectedIndex = -1
        End If
        cmbCat.SelectedIndex = -1
        cmbCat.Enabled = False
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False

    End Sub

    Private Sub RadJop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadJop.CheckedChanged
        If RadJop.Checked = True Then
            cmbCat.Enabled = True
        Else
            cmbCat.Enabled = False
            cmbCat.SelectedIndex = -1
        End If
        cmbEmployeeID.SelectedIndex = -1
        cmbEmployeeID.Enabled = False
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub RadHirdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadRewardDate.CheckedChanged
        If RadRewardDate.Checked = True Then
            RadRewardDate.Enabled = True
        Else
            cmbCat.Enabled = False
            cmbCat.SelectedIndex = -1
        End If
        cmbEmployeeID.SelectedIndex = -1
        cmbEmployeeID.Enabled = False
        cmbCat.SelectedIndex = -1
        cmbCat.Enabled = False
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
    End Sub
    Private Sub choseForm()
        selformula = ""
        If cmbEmployeeID.SelectedIndex <> -1 Then
            selformula = "select * from Query_Employees_Rewards where Employee_Name=N'" & (cmbEmployeeID.Text) & "'"

        End If

        If cmbCat.SelectedIndex <> -1 Then
            selformula = "select * from Query_Employees_Rewards where Category_Name=N'" & (cmbCat.Text) & "'"
        End If


        If RadRewardDate.Checked = True Then

            selformula = "select * from Query_Employees_Rewards where Discount_Date between '" & Format(Convert.ToDateTime(DateTimePicker1.Text), "mm/dd/yyyy") & "'  and   '" & Format(Convert.ToDateTime(DateTimePicker2.Text), "mm/dd/yyyy") & "'"

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
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