Imports System.Globalization
Public Class QuerEmployeesDiscounts
    Dim Gcls As GeneralSp.MasterForms
    Dim B_EndLoad As Boolean = False
    Dim ITEM_NAME As String
    Dim selformula As String
    Dim QueryEmployeeDiscount As New DataTable
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Query_Employees_Discounts"

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
        QueryEmployeeDiscount.Rows.Clear()
        'DataGridView1.DataSource = DBNull.Value
        'DataGridView1.ColumnCount = 5

    End Sub
    Private Sub DataLoad()
        Try
            cmd.CommandText = "select Category_Name from Discount_Categories"
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
        Catch ex As Exception
            cls.WriteError(ex.Message, "Cust Sch Payments")
        End Try
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
        da.Fill(QueryEmployeeDiscount)
        If QueryEmployeeDiscount.Rows.Count > 0 Then
            TabControl1.SelectedTab = TabPage2
            DataGridView1.Refresh()
            DataGridView1.DataSource = QueryEmployeeDiscount
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(0).HeaderText = "نوع الخصم"
            DataGridView1.Columns(1).HeaderText = "اسم الموظف"
            DataGridView1.Columns(2).HeaderText = "تاريخ الخصم"
            DataGridView1.Columns(3).HeaderText = "سبب الخصم"
            DataGridView1.Columns(4).HeaderText = "قيمة الخصم"
            DataGridView1.Columns(5).HeaderText = "كود الموظف"
            DataGridView1.Columns(6).HeaderText = "كود الخصم"
        Else
            cls.MsgExclamation("لا توجد بيانات للمعاملات المحدده", "please enter missing data")
        End If

    End Sub

    Private Sub RadEmpID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadEmpID.CheckedChanged
        If RadEmpID.Checked = True Then
            cmbEmployeeID.Enabled = True
            Panel1.Enabled = False
            cmbCat.Enabled = False
        Else
            'cmbEmployeeID.Enabled = False
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
            cmbEmployeeID.Enabled = False
            Panel1.Enabled = False
            cmbCat.Enabled = True
        Else
            'cmbCat.Enabled = False
            cmbCat.SelectedIndex = -1
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
            cmbEmployeeID.Enabled = False
            Panel1.Enabled = True
            cmbCat.Enabled = False
        Else
            'cmbCat.Enabled = False
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
        Try
            selformula = ""
            If cmbEmployeeID.SelectedIndex <> -1 Then
                selformula = "select * from Query_Employees_Discounts where Employee_Name=N'" & (cmbEmployeeID.Text) & "'"

            End If

            If cmbCat.SelectedIndex <> -1 Then
                selformula = "select * from Query_Employees_Discounts where Category_Name=N'" & (cmbCat.Text) & "'"
            End If

            If RadHirdate.Checked = True Then
                Dim date1 As Date = CDate(DateTimePicker1.Text)
                Dim date2 As Date = CDate(DateTimePicker2.Text)
                selformula = "select * from Query_Employees_Discounts where Discount_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"

            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Emp Discount")
        End Try
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