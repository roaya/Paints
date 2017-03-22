Public Class QueryCustomerLevel

    Dim t As New DataTable

    Private Sub QueryCustomerLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cls.LoadList("Level_Name", "Customer_Levels", LevelID)

        cmd.CommandText = "select * from Query_Customer_Credit_Limit where level_name is null"
        da.Fill(t)
        DataGridView1.DataSource = t

        DataGridView1.Columns(0).HeaderText = "اسم العميل"
        DataGridView1.Columns(1).HeaderText = "فئة العميل"
        'DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(2).HeaderText = "الحد الأقصي للآجل"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click


        t.Rows.Clear()

        cmd.CommandText = "select * from Query_Customer_Credit_Limit where level_name = N'" & LevelID.Text & "'"
        da.SelectCommand = cmd
        da.Fill(t)
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles button1.MouseMove
        Button1.BackgroundImage = My.Resources._end
        Button1.ForeColor = Color.White

    End Sub

    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.BackgroundImage = My.Resources._end
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.MouseLeave
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