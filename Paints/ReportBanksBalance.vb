Public Class ReportBanksBalance

    Dim AccBal, PurBal, SalBal As Double
    Private b As Boolean = False

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MyDs.Tables("Query_Banks_Accounts").Rows.Clear()
        If AccountNumber.Text = "" Then
            cls.MsgExclamation("أدخل رقم الحساب", "")
        Else
            cmd.CommandText = "select ISNULL(balance,0) from banks_accounts where account_number = N'" & AccountNumber.Text & "'"
            AccBal = cmd.ExecuteScalar
            cmd.CommandText = "select ISNULL(Sum(Cheque_Value),0) from Query_Banks_Accounts where cheque_status = N'منصرف' and direction = N'مبيعات'"
            SalBal = cmd.ExecuteScalar
            cmd.CommandText = "select ISNULL(Sum(Cheque_Value),0) from Query_Banks_Accounts where cheque_status = N'منصرف' and direction = N'مشتريات'"
            PurBal = cmd.ExecuteScalar
            cmd.CommandText = "select * from Query_Banks_Accounts where account_number = N'" & AccountNumber.Text & "' and (direction = N'مبيعات' or direction = N'مشتريات') and cheque_status = N'منصرف'"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Query_Banks_Accounts"))
            TotalAccount.Text = (AccBal + SalBal) - PurBal
        End If

    End Sub

    Private Sub ReportBanksBalance_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        b = False
    End Sub

    Private Sub ReportBanksBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = MyDs.Tables("Query_Banks_Accounts")
        DataGridView1.Columns(0).HeaderText = "اسم البنك"
        DataGridView1.Columns(1).HeaderText = "رقم الحساب"
        DataGridView1.Columns(2).HeaderText = "رقم الشيك"
        DataGridView1.Columns(3).HeaderText = "تاريخ الاستحقاق"
        DataGridView1.Columns(4).HeaderText = "تاريخ الاستلام"
        DataGridView1.Columns(5).HeaderText = "قيمة الشيك"
        DataGridView1.Columns(6).HeaderText = "حالة الشيك"
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        b = True
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
End Class