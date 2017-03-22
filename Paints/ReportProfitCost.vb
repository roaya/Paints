Public Class ReportProfitCost

    Private rpt As New RptSalesProfitCost
    Dim date1, date2 As Date

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            date1 = CDate(DateTimePicker1.Text)
            date2 = CDate(DateTimePicker2.Text)
            MyDs.Tables("Report_Sales_Profit_Cost").Rows.Clear()
            cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Sales_Profit_Cost where bill_date between '" & date1.ToString("MM/dd/yyyy") & "' and '" & date2.ToString("MM/dd/yyyy") & "'"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Report_Sales_Profit_Cost"))
            rpt.SetDataSource(MyDs.Tables("Report_Sales_Profit_Cost"))
            rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            CrystalReportViewer1.ReportSource = rpt
            TabControl1.SelectTab(1)
        Catch ex As Exception
            cls.WriteError(ex.Message, "Rpt Profit")
        End Try
    End Sub
End Class