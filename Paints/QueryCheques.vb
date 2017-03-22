Public Class QueryCheques

    Dim t As New DataTable

    Private Sub QueryCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmd.CommandText = "SELECT Vendors.Vendor_Name as person, dbo.Cheques.Cheque_Number,banks.Bank_Name,Banks_Accounts.Account_Number,dbo.Cheques.Received_Date, dbo.Cheques.Payed_Date, dbo.Cheques.Cheque_Value,dbo.Cheques.Cheque_Status, dbo.Cheques.Direction, dbo.Purchase_Header.Bill_Id FROM banks,banks_accounts,dbo.Cheques,dbo.Vendors,dbo.Purchase_Header where dbo.Cheques.Cheque_ID = dbo.Purchase_Header.Cheque_ID and dbo.Purchase_Header.Vendor_Id = dbo.Vendors.Vendor_Id and Banks.Bank_ID=Banks_Accounts.Bank_ID and Cheques.Account_ID=Banks_Accounts.Account_ID"
            da.SelectCommand = cmd
            da.Fill(t)
            cmd.CommandText = "SELECT Customers.Customer_Name as person, dbo.Cheques.Cheque_Number,banks.Bank_Name,Banks_Accounts.Account_Number,dbo.Cheques.Received_Date, dbo.Cheques.Payed_Date, dbo.Cheques.Cheque_Value,dbo.Cheques.Cheque_Status, dbo.Cheques.Direction, dbo.Sales_Header.Bill_Id FROM banks,banks_accounts,dbo.Cheques,dbo.Customers,dbo.Sales_Header where dbo.Cheques.Cheque_ID = dbo.Sales_Header.Cheque_ID and dbo.Sales_Header.Customer_Id = dbo.Customers.Customer_Id and Banks.Bank_ID=Banks_Accounts.Bank_ID and Cheques.Account_ID=Banks_Accounts.Account_ID"
            da.SelectCommand = cmd
            da.Fill(t)

            DataGridView1.DataSource = t
            DataGridView1.Columns(0).HeaderText = "اسم المستفيد"
            DataGridView1.Columns(1).HeaderText = "رقم الشيك"
            DataGridView1.Columns(2).HeaderText = "اسم البنك"
            DataGridView1.Columns(3).HeaderText = "رقم الحساب"
            DataGridView1.Columns(4).HeaderText = "تاريخ الاستحقاق"
            DataGridView1.Columns(5).HeaderText = "تاريخ الدفع"
            DataGridView1.Columns(6).HeaderText = "قيمة الشيك"
            DataGridView1.Columns(7).HeaderText = "حالة الشيك"
            DataGridView1.Columns(8).HeaderText = "نوع الشيك"
            DataGridView1.Columns(9).HeaderText = "رقم الفاتوره"
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Cheques Details")
            Me.Close()
        End Try
    End Sub
End Class