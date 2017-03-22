Public Class ReportAllCustVenTran

    Dim date1, date2 As Date
    Dim Rpt As New RptVenCustTrans
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Try
        MyDs.Tables("Tran_Ven_Cust").Rows.Clear()
        date1 = CDate(DateTimePicker1.Text)
        date2 = CDate(DateTimePicker2.Text)

        
        cmd.CommandText = "SELECT Daily_Procedure_Name as Person_Name,Procedure_Desc as Tran_Desc,Procedure_Date as Tran_Date,Procedure_Value as Tran_Value,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_All_Ven_Cust_Tran where Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
        da.SelectCommand = cmd
        da.Fill(MyDs.Tables("Tran_Ven_Cust"))
        Rpt.SetDataSource(MyDs.Tables("Tran_Ven_Cust"))
        Rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
        CrystalReportViewer1.ReportSource = Rpt
        TabControl1.SelectTab(1)

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