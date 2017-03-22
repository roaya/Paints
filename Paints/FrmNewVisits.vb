Public Class FrmNewVisits
    Dim rpt As New RptNewVisit

    Private Sub FrmNewVisits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cls.RefreshData("Visit_Header")
        Visit_ID.DataSource = MyDs
        Visit_ID.DisplayMember = "visit_header.visit_name"
        Visit_ID.ValueMember = "visit_header.visit_id"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        cmd.CommandText = " select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_New_Visits where visit_id = " & Visit_ID.SelectedValue
        da.Fill(MyDs.Tables("Report_New_Visits"))
        rpt.SetDataSource(MyDs.Tables("Report_New_Visits"))
        rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
        CrystalReportViewer2.ReportSource = rpt
        TabControl1.SelectTab(1)


    End Sub

    Private Sub Visit_ID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Visit_ID.GotFocus
        Visit_ID.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub Visit_ID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Visit_ID.Leave

        Visit_ID.BackColor = Color.Gainsboro
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
End Class