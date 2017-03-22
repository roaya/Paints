Public Class NetProfit

    Dim d1, d2 As Date

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Try
            d1 = DateTimePicker1.Text
            d2 = DateTimePicker2.Text

            cmd.CommandText = "SELECT ISNULL(SUM(Doc_VALUE),0) FROM Vendors_Transactions WHERE Doc_Date  between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and doc_type = N'اذن دفع'"
            TotalVendorPayments.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(REWARD_VALUE),0) FROM Employees_Added_Hours WHERE Hours_Date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalAddedHours.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(EXPENSE_VALUE),0) FROM Expenses_Details WHERE EXPENSE_Date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalExpenses.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(NET_SALARY),0) FROM PAY_SALARY WHERE PAY_Date BETWEEN '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalPaySalary.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Cash_Value),0) FROM Purchase_Header where (Pay_Type = N'نقدي' OR Pay_Type =N'نقدي و اجل') and  Bill_Date BETWEEN '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalPurchase.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Total_Bill),0) FROM return_c_Header  WHERE Bill_Date BETWEEN '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalReturnCustomers.Text = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(SUM(Cash_Value),0) FROM Sales_Header WHERE (Pay_Type = N'نقدي' OR Pay_Type =N'نقدي و اجل') AND Bill_Date BETWEEN '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            ProfitSales.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Cash_Value),0) FROM Sales_Header WHERE Pay_Type = N'فيزا' AND Bill_Date BETWEEN '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            ProfitVisa.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Total_Bill),0) FROM return_v_Header  WHERE Bill_Date BETWEEN '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            ProfitReturnVendors.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Doc_VALUE),0) FROM Customers_Transactions WHERE Doc_Date  between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and doc_type = N'اذن دفع'"
            ProfitCustomerPayments.Text = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(SUM(Cheque_VALUE),0) FROM cheques WHERE direction = N'مبيعات' and cheque_status = N'منصرف'"
            TotalCustomersCheques.Text = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(SUM(Cheque_VALUE),0) FROM cheques WHERE direction = N'مشتريات' and cheque_status = N'منصرف'"
            TotalVendorsCheques.Text = cmd.ExecuteScalar

            
            '------------------------------------------------
            cmd.CommandText = " select isnull(sum(doc_value),0) from Customers_Transactions where doc_type = N'دفع نقديه للعميل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalCashToCustomer.Text = cmd.ExecuteScalar

            cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'دفع نقديه من المورد' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalCashFromVendor.Text = cmd.ExecuteScalar

            cmd.CommandText = " select isnull(sum(doc_value),0) from Money_Payments where doc_type = N'اذن دفع كاش' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalPayGeneralCash.Text = cmd.ExecuteScalar

            cmd.CommandText = " select isnull(sum(doc_value),0) from Money_Payments where doc_type = N'اذن استلام كاش' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
            TotalReceiveGeneralCash.Text = cmd.ExecuteScalar

            'cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'دفع شيك للعميل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'  and customer_name = N'" & Combcustomer.Text & "'"
            'TotalChequeToCustomer = cmd.ExecuteScalar
            '------------------------------------------------

            ProfitNet.Text = (CDbl(TotalReceiveGeneralCash.Text) + CDbl(TotalCashFromVendor.Text) + CDbl(ProfitCustomerPayments.Text) + CDbl(TotalCustomersCheques.Text) + CDbl(ProfitReturnVendors.Text) + CDbl(ProfitVisa.Text) + CDbl(ProfitSales.Text)) - (CDbl(TotalPayGeneralCash.Text) + CDbl(TotalAddedHours.Text) + CDbl(TotalExpenses.Text) + CDbl(TotalPaySalary.Text) + CDbl(TotalPurchase.Text) + CDbl(TotalReturnCustomers.Text) + CDbl(TotalVendorPayments.Text) + CDbl(TotalVendorsCheques.Text) + CDbl(TotalCashToCustomer.Text))
            If CDbl(ProfitNet.Text) >= 0 Then
                ProfitNet.ForeColor = Color.Blue
                LblProfit.BackColor = Color.Blue
            Else
                ProfitNet.ForeColor = Color.Red
                LblProfit.BackColor = Color.Red
            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, "Net Profit")
        End Try
    End Sub

   
End Class