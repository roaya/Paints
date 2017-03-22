Public Class FrmCustomerTeansaction


    Dim rpt As New Report_Daily_Pro
    Dim d1, d2 As Date
    ''Dim TotalFirstCredit, TotalBill, TotalCash, TotalCredit, TotalVisa, TotalCheque, TotalPayment, TotalReturn, TotalReserve, TotalReserveCash, TotalReserveCredit, TotalCustPayCheque As Double
    ''Dim TotalPayToCustCash, TotalPayToCustCheque As Double
    Dim ProID As Integer

    ''Private Sub RadCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    If RadCustomer.Checked = True Then
    ''        Combcustomer.Enabled = True
    ''        fromdate.Enabled = False
    ''        todate.Enabled = False

    ''    End If
    ''End Sub

    ''Private Sub Raddate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    If Raddate.Checked = True Then
    ''        Combcustomer.Enabled = False
    ''        fromdate.Enabled = True
    ''        todate.Enabled = True
    ''    End If
    ''End Sub


    Private Sub FrmCustomerTeansaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cls.RefreshData("Customers", " Customer_Name ")
        Combcustomer.DataSource = MyDs
        Combcustomer.DisplayMember = "Customers.Customer_Name"
        Combcustomer.ValueMember = "Customers.Customer_ID"

        'cmd.CommandText = "select customer_name from customers"
        'dr = cmd.ExecuteReader
        'Do While dr.Read = True
        '    Combcustomer.Items.Add(dr("customer_name"))
        'Loop
        'dr.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor

        If Combcustomer.Text = "" Then
            cls.MsgInfo("من فضلك اختر اسم العميل", "")
        Else
            cmd.CommandText = "select procedure_master_id,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from procedure_master where reference_id = " & Combcustomer.SelectedValue & " and procedure_category = N'عملاء'"
            ProID = cmd.ExecuteScalar

            MyDs.Tables("Report_Daily_Procedure").Rows.Clear()

            d1 = fromdate.Text
            d2 = todate.Text

            cmd.CommandText = " select * from Report_Daily_Procedure,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo where procedure_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and (from_procedure_id=" & ProID & " or to_procedure_id=" & ProID & ") ORDER BY Procedure_date"
            da.Fill(MyDs.Tables("Report_Daily_Procedure"))

            rpt.SetDataSource(MyDs.Tables("Report_Daily_Procedure"))
            rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            CrystalReportViewer2.ReportSource = rpt

            cmd.CommandText = "select dbo.Get_Any_Balance(" & ProID & ",'" & d1.ToString("MM/dd/yyyy") & "','" & d2.ToString("MM/dd/yyyy") & "')"
            TxtCustomerBalance.Text = cmd.ExecuteScalar

            TabControl1.SelectTab(1)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub




    ''Sub CalcBalance()

    ''    d1 = fromdate.Text
    ''    d2 = todate.Text

    ''    cmd.CommandText = "select balance from customers where customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalFirstCredit = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات' and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalBill = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات - اجل'  and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalCredit = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات - نقدي'  and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalCash = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات - بشيك' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalCheque = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات - فيزا'  and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalVisa = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن ارتجاع' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalReturn = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن دفع' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalPayment = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن حجز بضاعه' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalReserve = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن حجز بضاعه - نقدي' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalReserveCash = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن حجز بضاعه - اجل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalReserveCredit = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن دفع شيك' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalCustPayCheque = cmd.ExecuteScalar

    ''    '--------------------------------------------
    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'دفع نقديه للعميل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalPayToCustCash = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'دفع شيك للعميل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'  and customer_name = N'" & Combcustomer.Text & "'"
    ''    TotalPayToCustCheque = cmd.ExecuteScalar
    ''    '--------------------------------------------


    ''    TxtCustomerBalance.Text = (TotalFirstCredit + TotalBill + TotalReserve + TotalPayToCustCash + TotalPayToCustCheque) - (TotalCash + TotalCheque + TotalVisa + TotalReturn + TotalPayment + TotalReserveCash + TotalCustPayCheque)


    ''End Sub
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

    Private Sub Combcustomer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combcustomer.GotFocus
        Combcustomer.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub Combcustomer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combcustomer.Leave
        Combcustomer.BackColor = Color.Gainsboro
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