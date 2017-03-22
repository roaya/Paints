Public Class GeneralSearch

    Dim STable As New GeneralDataSet.SearchTableDataTable
    Dim DtlTbl As New DataTable

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        STable.Rows.Clear()
        DtlTbl.Rows.Clear()
        DtlTbl.Columns.Clear()

        If e.KeyCode = Keys.Enter And TxtSearch.Text <> "" Then
            cmd.CommandText = "select customer_id as ColID,N'عملاء' as ColType,customer_name as ColName,N'البيانات الشخصيه للعميل' as ColDesc from customers where customer_name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Vendor_id as ColID,N'موردين' as ColType,Vendor_name as ColName,N'البيانات الشخصيه للمورد' as ColDesc from Vendors where Vendor_name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select item_id as ColID,N'بيانات الأصناف' as ColType,item_name as ColName,N'بيانات التفصيليه للأصناف' as ColDesc from Items where Item_name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select item_id as ColID,N'بيانات الأصناف' as ColType,item_name as ColName,N'بيانات التفصيليه للأصناف' as ColDesc from Items where barcode like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Employee_id as ColID,N'بيانات العاملين' as ColType,Employee_name as ColName,N'بيانات التفصيليه للعاملين' as ColDesc from employees where employee_name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            'cmd.CommandText = "select Expense_Detail_ID as ColID,N'المصروفات' as ColType,Expense_name as ColName,N'تفاصيل المصروفات' as ColDesc from Expenses_Details where Expense_Name like N'%" & TxtSearch.Text & "%'"
            'da.SelectCommand = cmd
            'da.Fill(STable)
            ''------------------------------------------
            cmd.CommandText = "select Expense_Category_ID as ColID,N'بنود المصروفات' as ColType,Expense_Category_name as ColName,N'بيانات بنود المصروفات' as ColDesc from Expenses_Header where Expense_Category_Name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Stock_ID as ColID,N'المحلات' as ColType,Stock_Name as ColName,N'بيانات المحلات' as ColDesc from Stocks where Stock_Name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Category_id as ColID,N'بنود المخزن' as ColType,Category_name as ColName,N'بيانات بنود المخزن' as ColDesc from categories where Category_name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Um_id as ColID,N'مجموعات القياس' as ColType,Um_name as ColName,N'الأصناف و مجموعات القياس' as ColDesc from Um_Master where Um_name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select corporation_id as ColID,N'الشركات' as ColType,corporation_name as ColName,N'بيانات الشركات التفصيليه' as ColDesc from corporations where corporation_name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Bank_ID as ColID,N'البنوك' as ColType,Bank_name as ColName,N'بيانات البنوك' as ColDesc from Banks where Bank_name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            ''------------------------------------------
            'cmd.CommandText = "select Account_ID as ColID,N'حسابات البنوك' as ColType,Account_Number as ColName,N'بيانات حسابات البنوك' as ColDesc from Banks_Accounts where Account_Number like N'%" & TxtSearch.Text & "%'"
            'da.SelectCommand = cmd
            'da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Cheque_ID as ColID,N'بيانات الشيكات' as ColType,Cheque_Number as ColName,N'تفاصيل الشيكات' as ColDesc from Cheques where Cheque_Number like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Level_ID as ColID,N'فئات الخصم' as ColType,Level_Name as ColName,N'العملاء بفئات الخصم' as ColDesc from Customer_Discount_Level where Level_Name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Level_ID as ColID,N'فئات الآجل' as ColType,Level_Name as ColName,N'العملاء بفئات الآجل' as ColDesc from Customer_Levels where Level_Name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Procedure_Master_ID as ColID,N'شجرة الحسابات' as ColType,Daily_Procedure_Name as ColName,N'بيانات شجرة الحسابات' as ColDesc from Procedure_Master where Daily_Procedure_Name like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------
            cmd.CommandText = "select Visa_ID as ColID,N'بيانات الفيزا' as ColType,Visa_Number as ColName,N'تفاصيل كروت الفيزا' as ColDesc from Visa where Visa_Number like N'%" & TxtSearch.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(STable)
            '------------------------------------------


            'cmd.CommandText = "select distinct item_id as ColID,N'بيانات الأصناف' as ColType,item_name as ColName,N'بيانات الأصناف بالشركات' as ColDesc from dbo.Query_All_Items where Corporation_Name like N'%" & TxtSearch.Text & "%'"
            'da.SelectCommand = cmd
            'da.Fill(STable)
            ''------------------------------------------
            'cmd.CommandText = "select distinct item_id as ColID,N'بيانات الأصناف' as ColType,item_name as ColName,N'بيانات الأصناف بالنوع' as ColDesc from dbo.Query_All_Items where Gender_Name like N'%" & TxtSearch.Text & "%'"
            'da.SelectCommand = cmd
            'da.Fill(STable)
            ''------------------------------------------
            'cmd.CommandText = "select distinct item_id as ColID,N'بيانات الأصناف' as ColType,item_name as ColName,N'بيانات الأصناف بالمقاس' as ColDesc from dbo.Query_All_Items where Size_Name like N'%" & TxtSearch.Text & "%'"
            'da.SelectCommand = cmd
            'da.Fill(STable)
            ''------------------------------------------
            'cmd.CommandText = "select distinct item_id as ColID,N'بيانات الأصناف' as ColType,item_name as ColName,N'بيانات الأصناف بالفئه' as ColDesc from dbo.Query_All_Items where Type_Name like N'%" & TxtSearch.Text & "%'"
            'da.SelectCommand = cmd
            'da.Fill(STable)

        End If
    End Sub

    Private Sub GeneralSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GrdSearch.DataSource = STable
        GrdSearch.Columns(0).Visible = False
        GrdSearch.Columns(1).HeaderText = "نوع البيانات"
        GrdSearch.Columns(2).HeaderText = "البيان التوضيحي"
        GrdSearch.Columns(3).HeaderText = "وصف البيانات"
        GrdSearchDetails.DataSource = DtlTbl
    End Sub

    Private Sub GrdSearch_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSearch.RowHeaderMouseDoubleClick

        DtlTbl.Rows.Clear()
        DtlTbl.Columns.Clear()

        Select Case GrdSearch.SelectedRows(0).Cells("ColType").Value
            Case "عملاء"
                cmd.CommandText = "select customer_id , customer_name as N'اسم العميل', address as N'العنوان', Mobile as N'الموبايل', Tele as N'التليفون' from customers where customer_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "موردين"
                cmd.CommandText = "select vendor_id , vendor_name as N'اسم المورد', address as N'العنوان', Mobile as N'الموبايل', Tele as N'التليفون' from vendors where vendor_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "بيانات العاملين"
                cmd.CommandText = "select employee_id , employee_name as N'اسم الموظف', address as N'العنوان', Mobile as N'الموبايل', Tele as N'التليفون' from employees where employee_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "بنود المصروفات"
                cmd.CommandText = "select Expense_Detail_id , Expense_name as N'اسم المصروف' from Expenses_Details where Expense_Category_ID = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "بيانات الأصناف"
                cmd.CommandText = "select distinct item_id , Corporation_Name as N'اسم المحل' ,item_name as N'اسم الصنف', barcode as N'الباركود', purchase_price as N'سعر الشراء', sale_price as N'سعر القطاعي' , sale_total_price as N'سعر الجمله' from Query_All_Items where item_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "المحلات"
                cmd.CommandText = "select distinct item_id ,Corporation_Name as N'اسم المحل' ,item_name as N'اسم الصنف', barcode as N'الباركود', purchase_price as N'سعر الشراء', sale_price as N'سعر القطاعي' , sale_total_price as N'سعر الجمله' from Query_All_Items where stock_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "بنود المخزن"
                cmd.CommandText = "select distinct item_id ,Corporation_Name as N'اسم المحل' ,item_name as N'اسم الصنف', barcode as N'الباركود', purchase_price as N'سعر الشراء', sale_price as N'سعر القطاعي' , sale_total_price as N'سعر الجمله' from Query_All_Items where category_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "الشركات"
                cmd.CommandText = "select distinct item_id ,Corporation_Name as N'اسم المحل' ,item_name as N'اسم الصنف', barcode as N'الباركود', purchase_price as N'سعر الشراء', sale_price as N'سعر القطاعي' , sale_total_price as N'سعر الجمله' from Query_All_Items where corporation_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "مجموعات القياس"
                cmd.CommandText = "select distinct item_id ,Corporation_Name as N'اسم المحل' ,item_name as N'اسم الصنف', barcode as N'الباركود', purchase_price as N'سعر الشراء', sale_price as N'سعر القطاعي' , sale_total_price as N'سعر الجمله' from Query_All_Items where Um_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "البنوك"
                cmd.CommandText = "select distinct Account_ID ,Account_Number as N'رقم الحساب' ,Created_Date as N'تاريخ الانشاء' from Banks_Accounts where Bank_ID = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "الشيكات"
                cmd.CommandText = "select distinct Cheque_ID ,Cheque_Number as N'رقم الشيك' ,Cheque_Value as N'قيمة الشيك',Cheque_Status as N'الحاله'  from Cheques where Cheque_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "فئات الآجل"
                cmd.CommandText = "select customer_id , customer_name as N'اسم العميل', address as N'العنوان', Mobile as N'الموبايل', Tele as N'التليفون' from customers where Level_ID = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "فئات الخصم"
                cmd.CommandText = "select customer_id , customer_name as N'اسم العميل', address as N'العنوان', Mobile as N'الموبايل', Tele as N'التليفون' from customers where Discount_Level_id = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "شجرة الحسابات"
                cmd.CommandText = "select Procedure_Master_ID , Daily_Procedure_Name as N'اسم الحساب', Procedure_Category as N'بند الحساب', Procedure_Type as N'طبيعة الحساب' from Procedure_Master where Procedure_Master_ID = " & GrdSearch.SelectedRows(0).Cells("ColID").Value
            Case "بيانات الفيزا"
                cmd.CommandText = "select Visa_ID , Visa_Number as N'رقم الفيزا', Created_Date as N'تاريخ الانشاء' from Visa where Visa_ID = " & GrdSearch.SelectedRows(0).Cells("ColID").Value

        End Select

        da.SelectCommand = cmd
        da.Fill(DtlTbl)
        GrdSearchDetails.Columns(0).Visible = False
    End Sub

    Private Sub GrdSearchDetails_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSearchDetails.RowHeaderMouseDoubleClick
        Select Case GrdSearchDetails.SelectedRows(0).Cells(0).OwningColumn.Name
            Case "customer_id"
                Dim m As New Customers
                m.SearchCustomerID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
            Case "vendor_id"
                Dim m As New Vendors
                m.SearchVendorID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
            Case "employee_id"
                Dim m As New Employees
                m.SearchEmployeeID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
            Case "Expense_Detail_id"
                Dim m As New ExpensesDetails
                m.SearchExpenseDetailID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
            Case "item_id"
                Dim m As New Items
                m.SearchItemID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
            Case "Account_ID"
                Dim m As New BankAccounts
                m.SearchAccID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
            Case "Cheque_ID"
                Dim m As New Cheques
                m.SearchChqID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
            Case "Procedure_Master_ID"
                Dim m As New DailyProcedures
                m.SearchProID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
            Case "Visa_ID"
                Dim m As New Visa
                m.SearchVisaID = GrdSearchDetails.SelectedRows(0).Cells(0).Value
                m.ShowDialog()
        End Select
    End Sub
End Class