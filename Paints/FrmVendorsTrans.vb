Public Class FrmVendorsTrans

    Dim Rpt As New Report_Daily_Pro
    Dim d1, d2 As Date
    ''Dim TotalBill, TotalCash, TotalCredit, TotalFirstCredit, TotalCheque, TotalPayment, TotalReturn As Double
    ''Dim TotalPayToVenCash, TotalPayToVenCheque, TotalVenPayCheque As Double
    Dim ProID As Integer

    Private Sub FrmVendorsTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cls.RefreshData("Vendors")
        VendorID.DataSource = MyDs
        VendorID.ValueMember = "Vendors.Vendor_ID"
        VendorID.DisplayMember = "Vendors.Vendor_Name"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cmd.CommandText = "select procedure_master_id from procedure_master where reference_id = " & VendorID.SelectedValue & " and procedure_category = N'موردين'"
            ProID = cmd.ExecuteScalar

            MyDs.Tables("Report_Daily_Procedure").Rows.Clear()
            d1 = CDate(DateTimePicker1.Text)
            d2 = CDate(DateTimePicker2.Text)
            cmd.CommandText = " select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Daily_Procedure where procedure_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and (from_procedure_id=" & ProID & " or to_procedure_id=" & ProID & ") ORDER BY Procedure_date"
            da.Fill(MyDs.Tables("Report_Daily_Procedure"))

            Rpt.SetDataSource(MyDs.Tables("Report_Daily_Procedure"))
            Rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            CrystalReportViewer1.ReportSource = Rpt

            cmd.CommandText = "select dbo.Get_Any_Balance(" & ProID & ",'" & d1.ToString("MM/dd/yyyy") & "','" & d2.ToString("MM/dd/yyyy") & "')"
            TxtVendorBalance.Text = cmd.ExecuteScalar

            TabControl1.SelectTab(1)
        Catch ex As Exception
            cls.WriteError(ex.Message, "Report_Vendors_Transactions")
        End Try
    End Sub

    ''Sub CalcBalance()


    ''    d1 = DateTimePicker1.Text
    ''    d2 = DateTimePicker2.Text

    ''    cmd.CommandText = "select balance from vendors where vendor_id = " & VendorID.SelectedValue
    ''    TotalFirstCredit = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'فاتورة مشتريات' and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendorID.SelectedValue
    ''    TotalBill = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'فاتورة مشتريات - اجل'  and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendorID.SelectedValue
    ''    TotalCredit = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'فاتورة مشتريات - نقدي'  and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendorID.SelectedValue
    ''    TotalCash = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'فاتورة مشتريات - بشيك' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendorID.SelectedValue
    ''    TotalCheque = cmd.ExecuteScalar

    ''    'cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Vendor_Transaction where doc_type = N'فاتورة مشتريات - فيزا'  and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
    ''    'TotalVisa = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'اذن ارتجاع' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendorID.SelectedValue
    ''    TotalReturn = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'اذن دفع' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendorID.SelectedValue
    ''    TotalPayment = cmd.ExecuteScalar

    ''    '--------------------------------------------
    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'اذن دفع شيك' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendorID.SelectedValue
    ''    TotalVenPayCheque = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'دفع نقديه من المورد' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendorID.SelectedValue
    ''    TotalPayToVenCash = cmd.ExecuteScalar

    ''    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'دفع شيك من المورد' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'  and vendor_id = " & VendorID.SelectedValue
    ''    TotalPayToVenCheque = cmd.ExecuteScalar
    ''    '--------------------------------------------

    ''    TxtVendorBalance.Text = (TotalFirstCredit + TotalBill + TotalPayToVenCash + TotalPayToVenCheque) - (TotalCash + TotalCheque + TotalReturn + TotalPayment + TotalVenPayCheque)

    ''End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

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

    Private Sub VendorID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles VendorID.GotFocus
        VendorID.BackColor = Color.Gainsboro
    End Sub

    Private Sub VendorID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles VendorID.Leave
        VendorID.BackColor = Color.FromArgb(135, 180, 209)
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