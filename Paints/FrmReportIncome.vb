Public Class FrmReportIncome

    Dim date1, date2 As Date
    Dim Tbl As New GeneralDataSet.Query_ShiftsDataTable
    Dim TblEmp As New GeneralDataSet.EmployeesDataTable
    Dim Shift, Employee As Integer
    Dim TblIncomeDtls As New DataTable
    Dim m As New ShowAllReports

    Private Sub FrmReportIncome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cls.RefreshData("select * from employees", TblEmp)

        emp.DataSource = TblEmp
        emp.DisplayMember = "Employee_name"
        emp.ValueMember = "employee_id"

    End Sub

    Private Sub Check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check.Click
        date1 = FromDate.Text
        date2 = ToDate.Text

        If byemp.Checked = True Then
            cls.RefreshData("select * from query_shifts where start_date between '" & date1.ToString("MM/dd/yyyy") & "' and '" & date2.ToString("MM/dd/yyyy") & "' and employee_id=" & emp.SelectedValue, Tbl)
        Else
            cls.RefreshData("select * from query_shifts where start_date between '" & date1.ToString("MM/dd/yyyy") & "' and '" & date2.ToString("MM/dd/yyyy") & "'", Tbl)
        End If

        Shifts.DataSource = Tbl
        Shifts.Columns(0).Visible = False
        Shifts.Columns(1).HeaderText = "اسم الورديه"
        Shifts.Columns(2).Visible = False
        Shifts.Columns(3).HeaderText = "تاريخ البدايه"
        Shifts.Columns(4).HeaderText = "تاريخ النهايه"
        Shifts.Columns(5).HeaderText = "وقت البدايه"
        Shifts.Columns(6).HeaderText = "وقت النهايه"
        Shifts.Columns(7).HeaderText = "الرصيد الافتتاحي"
        Shifts.Columns(8).Visible = False
        Shifts.Columns(9).HeaderText = "اسم الموظف"

    End Sub

    Private Sub byemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles byemp.CheckedChanged
        If byemp.Checked = True Then
            emp.Enabled = True

        End If
    End Sub

    Private Sub Shifts_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Shifts.MouseDoubleClick
        Try
            Shift = Shifts.SelectedRows(0).Cells("Shift_Detail_ID").Value
            ShiftName.Text = Shifts.SelectedRows(0).Cells("Employee_Name").Value & "-" & Shifts.SelectedRows(0).Cells("start_Time").Value & "-" & Shifts.SelectedRows(0).Cells("End_Time").Value & "-"

            MyDs.Tables("Income").Rows.Clear()

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مبيعات نقدي"
            cmd.CommandText = "select isnull(sum(Cash_Value),0) from Sales_Header where shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مبيعات اجل"
            cmd.CommandText = "select isnull(sum(Credit_Value),0) from Sales_Header where shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مشتريات نقدي"
            cmd.CommandText = "select isnull(sum(Cash_Value),0) from Purchase_Header where shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مشتريات اجل"
            cmd.CommandText = "select isnull(sum(Credit_Value),0) from Purchase_Header where shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مرتجعات موردين نقدي"
            cmd.CommandText = "select isnull(sum(Total_Bill),0) from Return_V_Header where Footer=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مرتجعات موردين اجل"
            cmd.CommandText = "select isnull(sum(Total_Bill),0) from Return_V_Header where Footer=N'اجل' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مرتجعات عملاء نقدي"
            cmd.CommandText = "select isnull(sum(Total_Bill),0) from Return_C_Header where Footer=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مرتجعات عملاء اجل"
            cmd.CommandText = "select isnull(sum(Total_Bill),0) from Return_C_Header where Footer=N'اجل' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مدفوعات موردين"
            cmd.CommandText = "select isnull(sum(Pay_Value),0) from money_payables M,Procedure_Master P where p.procedure_master_id=M.To_procedure_master_id and p.Procedure_Category=N'موردين' and Pay_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مصاريف اداريه"
            cmd.CommandText = "select isnull(sum(Pay_Value),0) from money_payables M,Procedure_Master P where p.procedure_master_id=M.To_procedure_master_id and p.Procedure_Category=N'مصاريف اداريه' and Pay_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مصاريف تسويقيه"
            cmd.CommandText = "select isnull(sum(Pay_Value),0) from money_payables M,Procedure_Master P where p.procedure_master_id=M.To_procedure_master_id and p.Procedure_Category=N'مصاريف تسويقيه' and Pay_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مدفوعات عملاء"
            cmd.CommandText = "select isnull(sum(Pay_Value),0) from money_payables M,Procedure_Master P where p.procedure_master_id=M.To_procedure_master_id and p.Procedure_Category=N'عملاء' and Pay_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "مدفوعات اخرى"
            cmd.CommandText = "select isnull(sum(Pay_Value),0) from money_payables M,Procedure_Master P where p.procedure_master_id=M.To_procedure_master_id and p.Procedure_Category<>N'موردين' and p.Procedure_Category<>N'مصاريف تسويقيه' and p.Procedure_Category<>N'مصاريف اداريه' and P.Procedure_Category<>N'عملاء' and Pay_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "استلام موردين"
            cmd.CommandText = "select isnull(sum(Rec_Value),0) from Money_Receivables M,Procedure_Master P where p.procedure_master_id=M.From_procedure_master_id and p.Procedure_Category=N'موردين' and Rec_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "استلام مصاريف اداريه"
            cmd.CommandText = "select isnull(sum(Rec_Value),0) from Money_Receivables M,Procedure_Master P where p.procedure_master_id=M.From_procedure_master_id and p.Procedure_Category=N'مصاريف اداريه' and Rec_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "استلام مصاريف تسويقيه"
            cmd.CommandText = "select isnull(sum(Rec_Value),0) from Money_Receivables M,Procedure_Master P where p.procedure_master_id=M.From_procedure_master_id and p.Procedure_Category=N'مصاريف تسويقيه' and Rec_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "استلام عملاء"
            cmd.CommandText = "select isnull(sum(Rec_Value),0) from Money_Receivables M,Procedure_Master P where p.procedure_master_id=M.From_procedure_master_id and p.Procedure_Category=N'عملاء' and Rec_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "اذونات استلام اخرى"
            cmd.CommandText = "select isnull(sum(Rec_Value),0) from Money_Receivables M,Procedure_Master P where p.procedure_master_id=M.From_procedure_master_id and p.Procedure_Category<>N'موردين' and p.Procedure_Category<>N'مصاريف تسويقيه' and p.Procedure_Category<>N'مصاريف اداريه' and P.Procedure_Category<>N'عملاء' and Rec_Type=N'نقدي' and shift_detail_id=" & Shift
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)

            r = MyDs.Tables("Income").NewRow
            r("Name") = "حساب خزنة الموظف"
            cmd.CommandText = "select dbo.Get_Employee_Account_ID(" & Shifts.SelectedRows(0).Cells("Employee_ID").Value & ")"
            Employee = cmd.ExecuteScalar
            cmd.CommandText = "select dbo.Get_Any_Balance_By_Shift(" & cmd.ExecuteScalar & ",'" & date1.ToString("MM/dd/yyyy") & "','" & date2.ToString("MM/dd/yyyy") & "'," & Shift & ")"
            r("Value") = cmd.ExecuteScalar
            MyDs.Tables("Income").Rows.Add(r)



            Income.DataSource = MyDs.Tables("Income")
            Income.Columns(0).HeaderText = "النوع"
            Income.Columns(1).HeaderText = "القيمة"

        Catch
            cls.ErrMsg()
        End Try
    End Sub

    Private Sub Income_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Income.MouseDoubleClick
        Try
            TblIncomeDtls.Rows.Clear()
            TblIncomeDtls.Columns.Clear()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Sales
            If Income.SelectedRows(0).Cells("Name").Value.ToString = "مبيعات نقدي" Then
                Type.Text = "مبيعات"
                cls.RefreshData("select Bill_ID N'رقم الفاتورة',Bill_Time N'وقت الفاتورة',Customer_Name N'اسم العميل',Total_Bill N'اجمالي الفاتورة',Cash_Value N'المدفوع' From Sales_Header S,Customers C where C.Customer_ID=S.Customer_ID and S.Cash_Value>0 and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مبيعات اجل" Then
                Type.Text = "مبيعات"
                cls.RefreshData("select Bill_ID N'رقم الفاتورة',Bill_Time N'وقت الفاتورة',Customer_Name N'اسم العميل',Total_Bill N'اجمالي الفاتورة',Credit_Value N'الاجل' From Sales_Header S,Customers C where C.Customer_ID=S.Customer_ID and S.Credit_Value>0 and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Purchase
            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مشتريات نقدي" Then
                Type.Text = "مشتريات"
                cls.RefreshData("select Bill_ID N'رقم الفاتورة',Bill_Time N'وقت الفاتورة',Vendor_Name N'اسم المورد',Total_Bill N'اجمالي الفاتورة',Cash_Value N'المدفوع' From Purchase_Header P,Vendors V where V.Vendor_ID=P.Vendor_ID and P.Cash_Value>0 and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مشتريات اجل" Then
                Type.Text = "مشتريات"
                cls.RefreshData("select Bill_ID N'رقم الفاتورة',Bill_Time N'وقت الفاتورة',Vendor_Name N'اسم المورد',Total_Bill N'اجمالي الفاتورة',Credit_Value N'الاجل' From Purchase_Header P,Vendors V where V.Vendor_ID=P.Vendor_ID and P.Credit_Value>0 and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Return Vendors
            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مرتجعات موردين نقدي" Then
                Type.Text = "مرتجعات موردين"
                cls.RefreshData("select R.Bill_ID N'رقم الفاتورة',R.Bill_Time N'وقت الفاتورة',Vendor_Name N'اسم المورد',P.Total_Bill N'اجمالي الفاتورة' from Return_V_Header R,Purchase_Header P,Vendors V where R.Purchase_Bill_Id=P.Bill_ID and V.Vendor_ID=P.Vendor_ID and R.footer=N'نقدي' and R.shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مرتجعات موردين اجل" Then
                Type.Text = "مرتجعات موردين"
                cls.RefreshData("select R.Bill_ID N'رقم الفاتورة',R.Bill_Time N'وقت الفاتورة',Vendor_Name N'اسم المورد',P.Total_Bill N'اجمالي الفاتورة' from Return_V_Header R,Purchase_Header P,Vendors V where R.Purchase_Bill_Id=P.Bill_ID and V.Vendor_ID=P.Vendor_ID and R.footer=N'نقدي' and R.Footer=N'اجل' and R.shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Return Customers
            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مرتجعات عملاء نقدي" Then
                Type.Text = "مرتجعات عملاء"
                cls.RefreshData("select R.Bill_ID N'رقم الفاتورة',R.Bill_Time N'وقت الفاتورة',Customer_Name N'اسم العميل',S.Total_Bill N'اجمالي الفاتورة' from Return_c_Header R,Sales_Header S,Customers C where R.Sal_Bill_Id=S.Bill_ID and C.Customer_ID=S.Customer_ID and R.Footer=N'نقدي' and R.shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مرتجعات عملاء اجل" Then
                Type.Text = "مرتجعات عملاء"
                cls.RefreshData("select R.Bill_ID N'رقم الفاتورة',R.Bill_Time N'وقت الفاتورة',Customer_Name N'اسم العميل',S.Total_Bill N'اجمالي الفاتورة' from Return_c_Header R,Sales_Header S,Customers C where R.Sal_Bill_Id=S.Bill_ID and C.Customer_ID=S.Customer_ID and R.Footer=N'اجل' and R.shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Payments
            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مدفوعات موردين" Then
                Type.Text = "اذونات الدفع"
                cls.RefreshData("Select Pay_ID,Daily_procedure_Name 'اسم الحساب',pay_Date 'تاريخ الدفع',Pay_Type 'نوع الدفع',Pay_Value 'القيمة المدفوعة',Pay_Desc 'الوصف' from money_Payables R,Procedure_Master P where p.procedure_Master_id=R.To_Procedure_Master_ID and P.Procedure_Category=N'موردين' and Pay_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مصاريف اداريه" Then
                Type.Text = "اذونات الدفع"
                cls.RefreshData("Select Pay_ID,Daily_procedure_Name 'اسم الحساب',pay_Date 'تاريخ الدفع',Pay_Type 'نوع الدفع',Pay_Value 'القيمة المدفوعة',Pay_Desc 'الوصف' from money_Payables R,Procedure_Master P where p.procedure_Master_id=R.To_Procedure_Master_ID and P.Procedure_Category=N'مصاريف اداريه' and Pay_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مصاريف تسويقيه" Then
                Type.Text = "اذونات الدفع"
                cls.RefreshData("Select Pay_ID,Daily_procedure_Name 'اسم الحساب',pay_Date 'تاريخ الدفع',Pay_Type 'نوع الدفع',Pay_Value 'القيمة المدفوعة',Pay_Desc 'الوصف' from money_Payables R,Procedure_Master P where p.procedure_Master_id=R.To_Procedure_Master_ID and P.Procedure_Category=N'مصاريف تسويقيه' and Pay_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مدفوعات عملاء" Then
                Type.Text = "اذونات الدفع"
                cls.RefreshData("Select Pay_ID,Daily_procedure_Name 'اسم الحساب',pay_Date 'تاريخ الدفع',Pay_Type 'نوع الدفع',Pay_Value 'القيمة المدفوعة',Pay_Desc 'الوصف' from money_Payables R,Procedure_Master P where p.procedure_Master_id=R.To_Procedure_Master_ID and P.Procedure_Category=N'عملاء' and Pay_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "مدفوعات اخرى" Then
                Type.Text = "اذونات الدفع"
                cls.RefreshData("Select Pay_ID,Daily_procedure_Name 'اسم الحساب',pay_Date 'تاريخ الدفع',Pay_Type 'نوع الدفع',Pay_Value 'القيمة المدفوعة',Pay_Desc 'الوصف' from money_Payables R,Procedure_Master P where p.procedure_Master_id=R.To_Procedure_Master_ID and p.Procedure_Category<>N'موردين' and p.Procedure_Category<>N'مصاريف تسويقيه' and p.Procedure_Category<>N'مصاريف اداريه' and P.Procedure_Category<>N'عملاء' and Pay_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Receivables
            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "استلام موردين" Then
                Type.Text = "اذونات الاستلام"
                cls.RefreshData("Select Rec_ID,Daily_procedure_Name 'اسم الحساب',Rec_Date 'تاريخ الاستلام',Rec_Type 'نوع الاستلام',Rec_Value 'القيمة المستلمة',Rec_Desc 'الوصف' from money_Receivables R,Procedure_Master P where p.procedure_Master_id=R.From_Procedure_Master_ID and P.Procedure_Category=N'موردين' and Rec_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "استلام مصاريف اداريه" Then
                Type.Text = "اذونات الاستلام"
                cls.RefreshData("Select Rec_ID,Daily_procedure_Name 'اسم الحساب',Rec_Date 'تاريخ الاستلام',Rec_Type 'نوع الاستلام',Rec_Value 'القيمة المستلمة',Rec_Desc 'الوصف' from money_Receivables R,Procedure_Master P where p.procedure_Master_id=R.From_Procedure_Master_ID and P.Procedure_Category=N'مصاريف اداريه' and Rec_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "استلام مصاريف تسويقيه" Then
                Type.Text = "اذونات الاستلام"
                cls.RefreshData("Select Rec_ID,Daily_procedure_Name 'اسم الحساب',Rec_Date 'تاريخ الاستلام',Rec_Type 'نوع الاستلام',Rec_Value 'القيمة المستلمة',Rec_Desc 'الوصف' from money_Receivables R,Procedure_Master P where p.procedure_Master_id=R.From_Procedure_Master_ID and P.Procedure_Category=N'مصاريف تسويقيه' and Rec_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "استلام عملاء" Then
                Type.Text = "اذونات الاستلام"
                cls.RefreshData("Select Rec_ID,Daily_procedure_Name 'اسم الحساب',Rec_Date 'تاريخ الاستلام',Rec_Type 'نوع الاستلام',Rec_Value 'القيمة المستلمة',Rec_Desc 'الوصف' from money_Receivables R,Procedure_Master P where p.procedure_Master_id=R.From_Procedure_Master_ID and P.Procedure_Category=N'عملاء' and Rec_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "اذونات استلام اخرى" Then
                Type.Text = "اذونات الاستلام"
                cls.RefreshData("Select Rec_ID,Daily_procedure_Name 'اسم الحساب',Rec_Date 'تاريخ الاستلام',Rec_Type 'نوع الاستلام',Rec_Value 'القيمة المستلمة',Rec_Desc 'الوصف' from money_Receivables R,Procedure_Master P where p.procedure_Master_id=R.From_Procedure_Master_ID and p.Procedure_Category<>N'موردين' and p.Procedure_Category<>N'مصاريف تسويقيه' and p.Procedure_Category<>N'مصاريف اداريه' and P.Procedure_Category<>N'عملاء' and Rec_Type=N'نقدي' and shift_Detail_id=" & Shift, TblIncomeDtls)
                IncomeDetails.DataSource = TblIncomeDtls
                IncomeDetails.Columns(0).Visible = False

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''Employee 
            ElseIf Income.SelectedRows(0).Cells("Name").Value.ToString = "حساب خزنة الموظف" Then
                Type.Text = "حساب خزنة الموظف"

                MyDs.Tables("MasterRecord").Clear()

                cmd.CommandText = "select daily_procedure_Name from procedure_master where Procedure_Master_ID=" & Employee
                MyDs.Tables("MasterRecord").Columns("daily_procedure_Name").DefaultValue = cmd.ExecuteScalar
                cmd.CommandText = "select procedure_type from procedure_master where procedure_master_id = " & Employee


                cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as To_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.To_Procedure_Master_ID=" & Employee & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "' and shift_Detail_id=" & Shift & " order by Procedure_Date"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))

                cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as From_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.From_Procedure_Master_ID=" & Employee & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "' and shift_detail_id=" & Shift & " order by Procedure_Date"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))

                'cmd.CommandText = "select dbo.Get_Any_Balance_by_Shift(" & Employee & ",'" & date1.ToString("MM/dd/yyyy") & "','" & date2.ToString("MM/dd/yyyy") & "'," & Shift & ") as procedure_balance"
                'da.SelectCommand = cmd
                'da.Fill(MyDs.Tables("MasterRecord"))


                IncomeDetails.DataSource = MyDs.Tables("MasterRecord")

                IncomeDetails.Columns(0).Visible = False
                IncomeDetails.Columns(1).HeaderText = "اسم الحساب"
                IncomeDetails.Columns(2).HeaderText = "وصف العملية"
                IncomeDetails.Columns(3).HeaderText = "تاريخ العملية"
                IncomeDetails.Columns(4).HeaderText = "دخل"
                IncomeDetails.Columns(5).HeaderText = "خرج"
                IncomeDetails.Columns(6).Visible = False

            End If
        Catch
            cls.ErrMsg()
        End Try
    End Sub

    Private Sub IncomeDetails_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles IncomeDetails.MouseDoubleClick
        If Type.Text = "مبيعات" Then
            Dim RptSales As New RptSalesOrder
            MyDs.Tables("Report_Sales").Rows.Clear()
            cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Sales where bill_id = " & IncomeDetails.SelectedRows(0).Cells("رقم الفاتورة").Value
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Report_Sales"))
            RptSales.SetDataSource(MyDs.Tables("Report_Sales"))
            RptSales.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            m.CrystalReportViewer1.ReportSource = RptSales
            m.ShowDialog()

        ElseIf Type.Text = "مشتريات" Then
            Dim RptPur As New RptSalesOrder
            MyDs.Tables("Report_Purchase").Rows.Clear()
            cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Purchase where bill_id = " & IncomeDetails.SelectedRows(0).Cells("رقم الفاتورة").Value
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Report_Purchase"))
            RptPur.SetDataSource(MyDs.Tables("Report_Purchase"))
            RptPur.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            m.CrystalReportViewer1.ReportSource = RptPur
            m.ShowDialog()

        ElseIf Type.Text = "مرتجعات موردين" Then
            Dim RptVenRet As New RptVendorReturns
            MyDs.Tables("Report_Vendors_Returns").Rows.Clear()
            cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Vendors_Returns where bill_id = " & IncomeDetails.SelectedRows(0).Cells("رقم الفاتورة").Value
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Report_Vendors_Returns"))
            RptVenRet.SetDataSource(MyDs.Tables("Report_Vendors_Returns"))
            RptVenRet.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            m.CrystalReportViewer1.ReportSource = RptVenRet
            m.ShowDialog()

        ElseIf Type.Text = "مرتجعات عملاء" Then
            Dim RptCustRet As New RptCustomerReturns
            MyDs.Tables("Report_Customers_Returns").Rows.Clear()
            cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Customers_Returns where bill_id = " & IncomeDetails.SelectedRows(0).Cells("رقم الفاتورة").Value
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Report_Customers_Returns"))
            RptCustRet.SetDataSource(MyDs.Tables("Report_Customers_Returns"))
            RptCustRet.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            m.CrystalReportViewer1.ReportSource = RptCustRet
            m.ShowDialog()
        ElseIf Type.Text = "اذونات الدفع" Then
            Dim RptPay As New RptReceivePay
            RptPay.ReportDefinition.ReportObjects.Item("TitleRecMoney").ObjectFormat.EnableSuppress = True
            RptPay.ReportDefinition.ReportObjects.Item("TitlePayMoney").ObjectFormat.EnableSuppress = False
            RptPay.ReportDefinition.ReportObjects.Item("TxtReceive").ObjectFormat.EnableSuppress = True
            RptPay.ReportDefinition.ReportObjects.Item("TxtPay").ObjectFormat.EnableSuppress = False

            MyDs.Tables("ReceivePay").Rows.Clear()
            cmd.CommandText = "select Pay_ID Rec_ID,Daily_Procedure_Name,Pay_Date Account_Date,Pay_Value Account_Value,Pay_Desc Account_Desc,N'نقدي' From Money_Payables M,Procedure_Master P where p.procedure_master_ID=M.To_procedure_Master_ID and Pay_ID=" & IncomeDetails.SelectedRows(0).Cells("Pay_ID").Value
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("ReceivePay"))
            RptPay.SetDataSource(MyDs.Tables("ReceivePay"))
            m.CrystalReportViewer1.ReportSource = RptPay
            m.ShowDialog()

        ElseIf Type.Text = "اذونات الاستلام" Then
            Dim RptPay As New RptReceivePay
            RptPay.ReportDefinition.ReportObjects.Item("TitleRecMoney").ObjectFormat.EnableSuppress = False
            RptPay.ReportDefinition.ReportObjects.Item("TitlePayMoney").ObjectFormat.EnableSuppress = True
            RptPay.ReportDefinition.ReportObjects.Item("TxtReceive").ObjectFormat.EnableSuppress = False
            RptPay.ReportDefinition.ReportObjects.Item("TxtPay").ObjectFormat.EnableSuppress = True

            MyDs.Tables("ReceivePay").Rows.Clear()
            cmd.CommandText = "select Rec_ID,Daily_Procedure_Name,Rec_Date Account_Date,Rec_Value Account_Value,Rec_Desc Account_Desc,N'نقدي' From Money_Receivables M,Procedure_Master P where p.procedure_master_ID=M.From_procedure_Master_ID and Rec_ID=" & IncomeDetails.SelectedRows(0).Cells("Rec_ID").Value
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("ReceivePay"))
            RptPay.SetDataSource(MyDs.Tables("ReceivePay"))
            m.CrystalReportViewer1.ReportSource = RptPay
            m.ShowDialog()

        End If

    End Sub

    Private Sub Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub


End Class
