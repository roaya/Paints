Public Class FrmTotalSales
    Dim rpt As New RptTotalSale
    Private CmdObj, WhereStmt As String
    Dim b As Boolean = False
    Dim ResChk As Boolean
    Dim rpt2 As New RptSalesTotalDetails
    Dim dr As SqlClient.SqlDataReader

    Private Sub RadAllCustomers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllCustomers.CheckedChanged
        If RadAllCustomers.Checked = True Then
            NumBill.Enabled = False
        End If
    End Sub
    Private Sub RadTotalBillBetweenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTotalBillBetweenDate.CheckedChanged
        If RadTotalBillBetweenDate.Checked = True Then
            NumBill.Enabled = True
        End If
    End Sub

    Private Sub RadMaxBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMaxBill.CheckedChanged
        If RadMaxBill.Checked = True Then
            NumBill.Enabled = False
        End If
    End Sub
    Private Sub Customer_Name_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Customer_Name.CheckedChanged
        If Customer_Name.Checked = True Then
            rpt.ReportDefinition.ReportObjects("CustomerName1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("TxtCustomer").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(1).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("CustomerName1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("TxtCustomer").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(1).Visible = False

        End If
    End Sub

    Private Sub Sum_Items_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum_items.CheckedChanged
        If sum_items.Checked = True Then
            rpt.ReportDefinition.ReportObjects("sumitems1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("TxtSumItems").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(2).Visible = True

        Else
            rpt.ReportDefinition.ReportObjects("sumitems1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("TxtSumItems").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(2).Visible = False

        End If
    End Sub

    Private Sub total_bill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total_bill.CheckedChanged
        If total_bill.Checked = True Then
            rpt.ReportDefinition.ReportObjects("totalbill1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("TxtTotalBill").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(3).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("totalbill1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("TxtTotalBill").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(3).Visible = False

        End If
    End Sub

    Private Sub maximum_bill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximum_bill.CheckedChanged
        If maximum_bill.Checked = True Then
            rpt.ReportDefinition.ReportObjects("maximumbill1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("txtMaxBill").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(4).Visible = True

        Else
            rpt.ReportDefinition.ReportObjects("maximumbill1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("txtMaxBill").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(4).Visible = False

        End If
    End Sub

    Private Sub total_cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total_cash.CheckedChanged
        If total_cash.Checked = True Then
            rpt.ReportDefinition.ReportObjects("totalcash1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("TxtTotalCash").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(5).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("totalcash1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("TxtTotalCash").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(5).Visible = False

        End If
    End Sub

    Private Sub total_credit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total_credit.CheckedChanged
        If total_credit.Checked = True Then
            rpt.ReportDefinition.ReportObjects("totalcredit1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("txtTotalCredit").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(6).Visible = True

        Else
            rpt.ReportDefinition.ReportObjects("totalcredit1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("txtTotalCredit").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(6).Visible = False
        End If
    End Sub

    Private Sub sum_bills_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum_bills.CheckedChanged
        If sum_bills.Checked = True Then
            rpt.ReportDefinition.ReportObjects("sumbills1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("txtSumBills").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(7).Visible = True

        Else
            rpt.ReportDefinition.ReportObjects("sumbills1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("txtSumBills").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(7).Visible = False

        End If
    End Sub

    Sub emptyallcheckbox()
        CrystalReportViewer1.Visible = False
        For Each c As CheckBox In GroupBox2.Controls
            c.Checked = True
        Next
        CrystalReportViewer1.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rpt.SetDataSource(MyDs.Tables("report_total_sales"))
        rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
        CrystalReportViewer1.ReportSource = rpt
        TabControl1.SelectTab(1)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MyDs.Tables("report_total_sales").Rows.Clear()

        If RadAllCustomers.Checked = True Then
            cmd.CommandText = "Select * from report_total_sales"
            da.Fill(MyDs.Tables("report_total_sales"))
        ElseIf RadMaxBill.Checked = True Then
            cmd.CommandText = " select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from report_total_sales where maximum_bill = (select max(maximum_bill) from report_total_sales)"
            da.Fill(MyDs.Tables("report_total_sales"))

        ElseIf RadTotalBillBetweenDate.Checked = True Then
            If NumBill.Value = 0 Then
                MsgBox("من فضلك ادخل قيمه")

                'Exit Sub
            Else
                cmd.CommandText = "Select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from report_total_sales where sum_bills > " & NumBill.Value
                da.Fill(MyDs.Tables("report_total_sales"))
                If MyDs.Tables("report_total_sales").Rows.Count > 0 Then
                    'For Each c As CheckBox In GroupBox3.Controls
                    '    c.Checked = True
                    'Next

                    DataGridView2.DataSource = MyDs.Tables("report_total_sales")
                 
                Else


                    cls.MsgExclamation("لا توجد بيانات", "")

                End If

            End If

        End If
        For Each c As CheckBox In GroupBox2.Controls
            c.Checked = True
        Next
    End Sub

 
    Private Sub FrmTotalSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyDs.Tables("report_total_sales").Rows.Clear()
        DataGridView1.DataSource = MyDs.Tables("report_total_sales")
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "اسم العميل"
        DataGridView1.Columns(2).HeaderText = "اجمالى الاصناف"
        DataGridView1.Columns(3).HeaderText = "عدد الفواتير"
        DataGridView1.Columns(4).HeaderText = "اعلى تعامل"
        DataGridView1.Columns(5).HeaderText = "اجمالى النقدى"
        DataGridView1.Columns(6).HeaderText = "اجمالى الاجل"
        DataGridView1.Columns(7).HeaderText = "اجمالى الفواتير"
        da.SelectCommand = cmd
        cmd.CommandText = "select Customer_Name from Customers Details"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            CombCustomer.Items.Add(dr("customer_name"))
        Loop
        dr.Close()
        

        MyDs.Tables("Report_total_Sales_Details").Rows.Clear()
        DataGridView2.DataSource = MyDs.Tables("Report_total_Sales_Details")

        DataGridView2.Columns(0).HeaderText = "اسم العميل"
        DataGridView2.Columns(1).HeaderText = "رقم الفاتوره"
        DataGridView2.Columns(2).HeaderText = "تاريخ الفاتوره"

        DataGridView2.Columns(3).HeaderText = "وقت الفاتوره"
        DataGridView2.Columns(4).HeaderText = "حاله الفاتوره"
        DataGridView2.Columns(5).HeaderText = "نوع الفاتوره"
        DataGridView2.Columns(6).HeaderText = "اجمالى الفاتوره"
        DataGridView2.Columns(7).HeaderText = "اجمالى النقدى"
        DataGridView2.Columns(8).HeaderText = "اجمالى الاجل"

        DataGridView2.Columns(9).HeaderText = "اجمالى الاصناف"
        DataGridView2.Columns(10).HeaderText = "رقم الشيك"
        DataGridView2.Columns(11).HeaderText = "تاريخ الاستحقاق"
        DataGridView2.Columns(12).HeaderText = "رقم الفيزا"
        DataGridView2.Columns(13).HeaderText = "اسم الموظف"

        DataGridView2.Columns(14).Visible = False
        DataGridView2.Columns(15).Visible = False
        DataGridView2.Columns(16).Visible = False
        DataGridView2.Columns(17).Visible = False

     
    End Sub

  
   
   
    Private Sub RadTotalBillBetween_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTotalBillBetween.CheckedChanged
        If RadTotalBillBetween.Checked = True Then
            combBillId.Enabled = False
            CombCheques.Enabled = False
            NumTotalBill.Enabled = True
        End If
    End Sub

    Private Sub RadMAxTBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMAxTBill.CheckedChanged
        If RadMAxTBill.CheckAlign = True Then
            combBillId.Enabled = False
            CombCheques.Enabled = False
            NumTotalBill.Enabled = False
        End If

    End Sub

    Private Sub RadBillID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBillID.CheckedChanged
        If RadBillID.Checked = True Then
            combBillId.Enabled = True
            CombCheques.Enabled = False
            NumTotalBill.Enabled = False
        End If
      

    End Sub

    Private Sub RadBillByDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBillByDate.CheckedChanged
        If RadBillByDate.Checked = True Then
            combBillId.Enabled = False
            CombCheques.Enabled = False
            NumTotalBill.Enabled = False
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim d1, d2 As Date
        MyDs.Tables("Report_total_Sales_Details").Rows.Clear()
        d1 = DateTimePicker1.Text
        d2 = DateTimePicker2.Text

       


        If RadCustomer.Checked = True Then



            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If RadAllBills.Checked = True Then
                If CombCustomer.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where customer_name =  N'" & CombCustomer.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))
                End If
            ElseIf RadMAxTBill.Checked = True Then
                If CombCustomer.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Total_Bill = (select max(total_bill) from Report_Total_Sales_Details) and {ثىيخق_Name=  N'" & CombCustomer.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))

                End If

            ElseIf RadTotalBillBetween.Checked = True Then
                If CombCustomer.Text = "" Or NumTotalBill.Value <= 0 Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Total_Bill > " & NumTotalBill.Value & "and customer_name= N'" & CombCustomer.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))
                End If

            ElseIf RadBillID.Checked = True Then


                If CombCustomer.Text = "" Or combBillId.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Bill_id = " & combBillId.Text & " and customer_name= N'" & CombCustomer.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))

                End If

            ElseIf RadBillByDate.Checked = True Then
                If CombCustomer.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Bill_Date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and customer_name =N'" & CombCustomer.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))
                End If

            ElseIf RadChequeNumber.Checked = True Then


                If CombCustomer.Text = "" Or CombCheques.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where cheque_Number = " & CombCheques.Text & " and customer_name= N'" & CombCustomer.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))

                End If
            ElseIf RadDeservedCheques.Checked = True Then
                If CombCustomer.Text = "" Then
                    MsgBox("مف فضلك اختر اسم العميل")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where recieve_date < getdate() and customer_name= N'" & CombCustomer.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))

                End If
            ElseIf RadAllCheques.Checked = True Then


                If CombCustomer.Text = "" Then
                    MsgBox("مف فضلك اختر اسم العميل")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from report_total_sales_details where cheque_Number is not null  and customer_name= N'" & CombCustomer.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))

                End If


            End If




            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf RadAllCustomer.Checked = True Then

            If RadAllBills.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details   "
                da.Fill(MyDs.Tables("Report_Total_Sales_Details"))

            ElseIf RadMAxTBill.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Total_Bill = (select max(total_bill) from Report_Total_Sales_Details) "
                da.Fill(MyDs.Tables("Report_Total_Sales_Details"))


            ElseIf RadTotalBillBetween.Checked = True Then
                If NumTotalBill.Value <= 0 Then
                    MsgBox("من فضلك ادخل قيمه")
                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Total_Bill > " & NumTotalBill.Value
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))
                End If

            ElseIf RadBillID.Checked = True Then
                If combBillId.Text = "" Then
                    MsgBox("من فضلك اختر رقم الفاتوره")
                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Bill_id = " & combBillId.Text
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))

                End If

            ElseIf RadBillByDate.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Bill_Date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' "
                da.Fill(MyDs.Tables("Report_Total_Sales_Details"))


            ElseIf RadChequeNumber.Checked = True Then
                If CombCheques.Text = "" Then
                    MsgBox("من فضلك اختر رقم الشيك")
                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where cheque_Number = " & CombCheques.Text
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))
                End If
            ElseIf RadDeservedCheques.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where recieve_date < getdate() "
                da.Fill(MyDs.Tables("Report_Total_Sales_Details"))


            ElseIf RadDesrevedBill.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Total_Sales_Details where Bill_Status=N'مفتوحه' "
                da.Fill(MyDs.Tables("Report_Total_Sales_Details"))
            ElseIf RadAllCheques.Checked = True Then


               
                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from report_total_sales_details where cheque_Number is not null  "
                    da.Fill(MyDs.Tables("Report_Total_Sales_Details"))




            End If
            If MyDs.Tables("Report_Total_Sales_Details").Rows.Count > 0 Then
                'For Each c As CheckBox In GroupBox3.Controls
                '    c.Checked = True
                'Next

                DataGridView2.DataSource = MyDs.Tables("Report_Total_Sales_Details")

            Else


                cls.MsgExclamation("لا توجد بيانات", "")

            End If
        End If
        For Each c As CheckBox In GroupBox3.Controls
            c.Checked = True
        Next

    End Sub

   
    Private Sub RadChequeNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadChequeNumber.CheckedChanged
        If RadChequeNumber.Checked = True Then
            NumTotalBill.Enabled = False
            combBillId.Enabled = False
            CombCheques.Enabled = True
        End If
       
    End Sub

    Private Sub RadChequeRecieves_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDeservedCheques.CheckedChanged
        If RadDeservedCheques.Checked = True Then

          combBillId.Enabled = False
        CombCheques.Enabled = False
        NumTotalBill.Enabled = False
        End If

    End Sub

    Private Sub RadDesrevedBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDesrevedBill.CheckedChanged
        If RadDesrevedBill.Checked = True Then


            combBillId.Enabled = False
            CombCheques.Enabled = False
            NumTotalBill.Enabled = False
        End If
    End Sub

    Private Sub RadAllBills_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllBills.CheckedChanged
        combBillId.Enabled = False
        CombCheques.Enabled = False
        NumTotalBill.Enabled = False
    End Sub

    Private Sub RadCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCustomer.CheckedChanged
        If RadCustomer.Checked = True Then
            CombCustomer.Enabled = True
            combBillId.Items.Clear()
            CombCheques.Items.Clear()
            RadAllBills.Checked = True
            RadMAxTBill.Checked = False
            RadBillID.Checked = False
            RadChequeNumber.Checked = False
            RadTotalBillBetween.Checked = False
            RadBillByDate.Checked = False
            RadChequeNumber.Checked = False

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        rpt2.SetDataSource(MyDs.Tables("Report_Total_Sales_Details"))
        rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
        CrystalReportViewer2.ReportSource = rpt2
        TabControl3.SelectTab(1)
    End Sub

    Private Sub CustomerName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerName.CheckedChanged
        If CustomerName.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("CustomerName1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text1").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(0).Visible = True
           

        Else
            rpt2.ReportDefinition.ReportObjects("CustomerName1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text1").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(0).Visible = False

        End If
    End Sub

    Private Sub BillID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillID.CheckedChanged
        If BillID.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("BillId1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text2").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(1).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("BillId1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text2").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(1).Visible = False

        End If
    End Sub

    Private Sub BillDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillDate.CheckedChanged
        If BillDate.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("BillDate1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text3").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(2).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("BillDate1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text3").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(2).Visible = False

        End If
    End Sub

    Private Sub BillTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillTime.CheckedChanged
        If BillTime.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("BillTime1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text4").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(3).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("BillTime1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text4").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(3).Visible = False

        End If
    End Sub

    Private Sub BillType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillType.CheckedChanged
        If BillType.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("PayType1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text6").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(5).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("PayType1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text6").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(5).Visible = False

        End If
    End Sub

    Private Sub TotalBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalBill.CheckedChanged
        If TotalBill.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("TotalBill1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text7").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(6).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("TotalBill1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text7").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(6).Visible = False

        End If
    End Sub

    Private Sub TotalCredit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalCredit.CheckedChanged
        If TotalCredit.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("CreditValue1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text9").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(8).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("CreditValue1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text9").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(8).Visible = False

        End If
    End Sub

    Private Sub TotalCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalCash.CheckedChanged
        If TotalCash.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("CashValue1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text8").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(7).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("CashValue1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text8").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(7).Visible = False

        End If
    End Sub

    Private Sub TotalItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalItems.CheckedChanged
        If TotalItems.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("TotalItems1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text10").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(9).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("TotalItems1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text10").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(9).Visible = False

        End If
    End Sub

   
    Private Sub BillStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillStatus.CheckedChanged
        If BillStatus.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("billstatus1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text15").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(4).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("billstatus1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text15").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(4).Visible = False

        End If
    End Sub

    Private Sub ChequeNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequeNumber.CheckedChanged
        If ChequeNumber.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("ChequeNumber1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text11").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(10).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("ChequeNumber1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text11").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(10).Visible = False

        End If
    End Sub

    Private Sub RecieveDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecieveDate.CheckedChanged
        If RecieveDate.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("recieveDate1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text12").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(11).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("RecieveDate1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text12").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(11).Visible = False

        End If
    End Sub

    Private Sub EmployeeName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeName.CheckedChanged
        If EmployeeName.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("EmployeeName1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text14").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(13).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("EmployeeName1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text14").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(13).Visible = False

        End If
    End Sub

    Private Sub VisaNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisaNumber.CheckedChanged
        If VisaNumber.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("VisaNumber1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text13").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(12).Visible = True

        Else
            rpt2.ReportDefinition.ReportObjects("VisaNumber1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text13").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(12).Visible = False
        End If
    End Sub

    Private Sub RadAllCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllCustomer.CheckedChanged
        
        If RadAllCustomer.Checked = True Then
            combBillId.Items.Clear()
            CombCheques.Items.Clear()
            RadAllBills.Checked = True
            RadMAxTBill.Checked = False
            RadBillID.Checked = False
            RadChequeNumber.Checked = False
            RadTotalBillBetween.Checked = False
            RadBillByDate.Checked = False
            RadChequeNumber.Checked = False
            CombCustomer.Enabled = False

            cmd.CommandText = "select Bill_ID from Report_Total_Sales_Details "
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                combBillId.Items.Add(dr("Bill_ID"))
            Loop
            dr.Close()


            cmd.CommandText = "select Cheque_Number from Report_Total_Sales_Details where cheque_Number is not null "
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                CombCheques.Items.Add(dr("Cheque_Number"))
            Loop
            dr.Close()
        End If

    End Sub

    Private Sub CombCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombCustomer.SelectedIndexChanged
        If CombCustomer.Text = "" Then
            CombCustomer.Focus()
            MsgBox("من فضلك اختر اسم العميل")

        Else
            cmd.CommandText = "select Bill_ID from Report_Total_Sales_Details where Customer_Name = N'" & CombCustomer.Text & "'"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                combBillId.Items.Add(dr("Bill_ID"))
            Loop
            dr.Close()



            cmd.CommandText = "select Cheque_Number from Report_Total_Sales_Details where cheque_Number is not null and Customer_Name = N'" & CombCustomer.Text & "'"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                CombCheques.Items.Add(dr("Cheque_Number"))
            Loop
            dr.Close()
        End If
    End Sub

    Private Sub RadAllCheques_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllCheques.CheckedChanged
        If RadAllCheques.CheckAlign = True Then
            combBillId.Enabled = False
            CombCheques.Enabled = False
            NumTotalBill.Enabled = False
        End If
    End Sub

    
End Class