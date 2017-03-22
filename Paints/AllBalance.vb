Public Class AllBalance

    Dim d1, d2 As Date
    ' Dim TotalBill, TotalCredit, TotalCash, TotalVisa, TotalCheque, TotalPayment, TotalReturn, TotalReserve, TotalReserveCash, TotalReserveCredit, TotalCustPayCheque As Double
    Dim Cid, Vid, ProID As Integer
    Dim TotalBalance As Double
    ' Dim CustAllBal, VenAllBal, TotalVenPayCheque, TotalPayToVenCash As Double
    ' Dim TotalFirstCredit, TotalPayToCustCash, TotalPayToCustCheque, TotalPayToVenCheque As Double
    Dim Rpt As New RptAllBalance

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        d1 = fromdate.Text
        d2 = todate.Text

        MyDs.Tables("CustVenTrans").Rows.Clear()

        If RadioAllPersons.Checked = True Then
            cls.RefreshData("Customers")
            For i As Integer = 0 To MyDs.Tables("Customers").Rows.Count - 1
                Cid = MyDs.Tables("Customers").Rows(i).Item("Customer_ID")
                '--------------------------------------------------------------
                cmd.CommandText = "select procedure_master_id from procedure_master where reference_id = " & Cid & " and procedure_category = N'عملاء'"
                ProID = cmd.ExecuteScalar
                cmd.CommandText = "select dbo.Get_Any_Balance(" & ProID & ",'" & d1.ToString("MM/dd/yyyy") & "','" & d2.ToString("MM/dd/yyyy") & "')"
                TotalBalance = cmd.ExecuteScalar
                '--------------------------------------------------------------
                r = MyDs.Tables("CustVenTrans").NewRow()
                r("Person_Name") = MyDs.Tables("Customers").Rows(i).Item("Customer_Name")
                r("Balance") = TotalBalance
                r("Person_Type") = "عميل"
                MyDs.Tables("CustVenTrans").Rows.Add(r)
            Next

            
            cls.RefreshData("Vendors")
            For i As Integer = 0 To MyDs.Tables("Vendors").Rows.Count - 1
                Vid = MyDs.Tables("Vendors").Rows(i).Item("Vendor_ID")
                '---------------------------------------------------------------
                cmd.CommandText = "select procedure_master_id from procedure_master where reference_id = " & Vid & " and procedure_category = N'موردين'"
                ProID = cmd.ExecuteScalar
                cmd.CommandText = "select dbo.Get_Any_Balance(" & ProID & ",'" & d1.ToString("MM/dd/yyyy") & "','" & d2.ToString("MM/dd/yyyy") & "')"
                TotalBalance = cmd.ExecuteScalar
                '---------------------------------------------------------------
                r = MyDs.Tables("CustVenTrans").NewRow()
                r("Person_Name") = MyDs.Tables("Vendors").Rows(i).Item("Vendor_Name")
                r("Balance") = TotalBalance
                r("Person_Type") = "مورد"
                MyDs.Tables("CustVenTrans").Rows.Add(r)
            Next
        ElseIf RadioAllCustomers.Checked = True Then
            cls.RefreshData("Customers")
            For i As Integer = 0 To MyDs.Tables("Customers").Rows.Count - 1
                Cid = MyDs.Tables("Customers").Rows(i).Item("Customer_ID")
                '--------------------------------------------------------------
                cmd.CommandText = "select procedure_master_id from procedure_master where reference_id = " & Cid & " and procedure_category = N'عملاء'"
                ProID = cmd.ExecuteScalar
                cmd.CommandText = "select dbo.Get_Any_Balance(" & ProID & ",'" & d1.ToString("MM/dd/yyyy") & "','" & d2.ToString("MM/dd/yyyy") & "')"
                TotalBalance = cmd.ExecuteScalar
                '--------------------------------------------------------------
                r = MyDs.Tables("CustVenTrans").NewRow()
                r("Person_Name") = MyDs.Tables("Customers").Rows(i).Item("Customer_Name")
                r("Balance") = TotalBalance
                r("Person_Type") = "عميل"
                MyDs.Tables("CustVenTrans").Rows.Add(r)
            Next
        ElseIf RadioAllVendors.Checked = True Then
            cls.RefreshData("Vendors")
            For i As Integer = 0 To MyDs.Tables("Vendors").Rows.Count - 1
                Vid = MyDs.Tables("Vendors").Rows(i).Item("Vendor_ID")
                '---------------------------------------------------------------
                cmd.CommandText = "select procedure_master_id from procedure_master where reference_id = " & Vid & " and procedure_category = N'موردين'"
                ProID = cmd.ExecuteScalar
                cmd.CommandText = "select dbo.Get_Any_Balance(" & ProID & ",'" & d1.ToString("MM/dd/yyyy") & "','" & d2.ToString("MM/dd/yyyy") & "')"
                TotalBalance = cmd.ExecuteScalar
                '---------------------------------------------------------------
                r = MyDs.Tables("CustVenTrans").NewRow()
                r("Person_Name") = MyDs.Tables("Vendors").Rows(i).Item("Vendor_Name")
                r("Balance") = TotalBalance
                r("Person_Type") = "مورد"
                MyDs.Tables("CustVenTrans").Rows.Add(r)
            Next
        End If

        Rpt.SetDataSource(MyDs.Tables("CustVenTrans"))
        CrystalReportViewer2.ReportSource = Rpt

        TabControl1.SelectTab(1)

    End Sub

    'Function CalculateCustBalance(ByVal CustID As Integer) As Double

    '    d1 = fromdate.Text
    '    d2 = todate.Text

    '    cmd.CommandText = "select balance from Customers where customer_id = " & CustID
    '    TotalFirstCredit = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات' and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalBill = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات - اجل'  and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalCredit = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات - نقدي'  and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalCash = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات - بشيك' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalCheque = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'فاتورة مبيعات - فيزا'  and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalVisa = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن ارتجاع' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalReturn = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن دفع' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalPayment = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن حجز بضاعه' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalReserve = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن حجز بضاعه - نقدي' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalReserveCash = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن حجز بضاعه - اجل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalReserveCredit = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'اذن دفع شيك' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalCustPayCheque = cmd.ExecuteScalar

    '    '--------------------------------------------
    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'دفع نقديه للعميل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_id = " & CustID
    '    TotalPayToCustCash = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'دفع شيك للعميل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'  and customer_id = " & CustID
    '    TotalPayToCustCheque = cmd.ExecuteScalar
    '    '--------------------------------------------

    '    CustAllBal = (TotalFirstCredit + TotalBill + TotalReserve + TotalPayToCustCash + TotalPayToCustCheque) - (TotalCash + TotalCheque + TotalVisa + TotalReturn + TotalPayment + TotalReserveCash + TotalCustPayCheque)

    '    Return CustAllBal
    'End Function

    'Function CalculateVenBalance(ByVal VendID As Integer) As Double

    '    d1 = fromdate.Text
    '    d2 = todate.Text

    '    cmd.CommandText = "select balance from vendors where vendor_id = " & VendID
    '    TotalFirstCredit = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'فاتورة مشتريات' and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendID
    '    TotalBill = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'فاتورة مشتريات - اجل'  and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendID
    '    TotalCredit = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'فاتورة مشتريات - نقدي'  and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendID
    '    TotalCash = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'فاتورة مشتريات - بشيك' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendID
    '    TotalCheque = cmd.ExecuteScalar

    '    'cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Vendor_Transaction where doc_type = N'فاتورة مشتريات - فيزا'  and doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
    '    'TotalVisa = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'اذن ارتجاع' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendID
    '    TotalReturn = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'اذن دفع' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendID
    '    TotalPayment = cmd.ExecuteScalar

    '    '--------------------------------------------
    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'اذن دفع شيك' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendID
    '    TotalVenPayCheque = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'دفع نقديه من المورد' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and vendor_id = " & VendID
    '    TotalPayToVenCash = cmd.ExecuteScalar

    '    cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'دفع شيك من المورد' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'  and vendor_id = " & VendID
    '    TotalPayToVenCheque = cmd.ExecuteScalar
    '    '--------------------------------------------

    '    VenAllBal = (TotalPayToVenCash + TotalPayToVenCheque + TotalFirstCredit + TotalBill) - (TotalCash + TotalCheque + TotalReturn + TotalPayment + TotalVenPayCheque)

    '    Return VenAllBal
    'End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class