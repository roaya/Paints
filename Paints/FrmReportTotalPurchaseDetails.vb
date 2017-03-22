Public Class FrmReportTotalPurchaseDetails

    Dim rpt As New RptTotalpurchase
    Private CmdObj, WhereStmt As String
    Dim b As Boolean = False
    Dim ResChk As Boolean
    Dim rpt2 As New RptPurchaseTotalDetails
    Dim dr As SqlClient.SqlDataReader

    Private Sub RadallVedors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllVendors.CheckedChanged
        If RadAllVendors.Checked = True Then
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        MyDs.Tables("report_total_Purchase").Rows.Clear()

        If RadAllVendors.Checked = True Then
            cmd.CommandText = "Select * from report_total_Purchase"
            da.Fill(MyDs.Tables("report_total_Purchase"))
        ElseIf RadMaxBill.Checked = True Then
            cmd.CommandText = " select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from report_total_Purchase where maximum_bill = (select max(maximum_bill) from report_total_Purchase)"
            da.Fill(MyDs.Tables("report_total_Purchase"))

        ElseIf RadTotalBillBetweenDate.Checked = True Then
            If NumBill.Value = 0 Then
                MsgBox("من فضلك ادخل قيمه")

                Exit Sub
            Else
                cmd.CommandText = "Select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from report_total_Purchase where sum_bills > " & NumBill.Value

                da.Fill(MyDs.Tables("report_total_Purchase"))
                If MyDs.Tables("report_total_Purchase").Rows.Count > 0 Then
                    'For Each c As CheckBox In GroupBox3.Controls
                    '    c.Checked = True
                    'Next

                    DataGridView2.DataSource = MyDs.Tables("report_total_Purchase")
                    'For Each c As CheckBox In GroupBox2.Controls
                    '    c.Checked = True
                    'Next
                Else


                    cls.MsgExclamation("لا توجد بيانات", "")

                End If
               
            End If
            
        End If
        For Each c As CheckBox In GroupBox2.Controls
            c.Checked = True
        Next
    End Sub

    Private Sub FrmReportTotalPurchaseDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyDs.Tables("report_total_Purchase").Rows.Clear()
        DataGridView1.DataSource = MyDs.Tables("report_total_Purchase")
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).HeaderText = "اسم المورد"
        DataGridView1.Columns(2).HeaderText = "اجمالى الاصناف"
        DataGridView1.Columns(3).HeaderText = "عدد الفواتير"
        DataGridView1.Columns(4).HeaderText = "اعلى تعامل"
        DataGridView1.Columns(5).HeaderText = "اجمالى النقدى"
        DataGridView1.Columns(6).HeaderText = "اجمالى الاجل"
        DataGridView1.Columns(7).HeaderText = "اجمالى الفواتير"
        da.SelectCommand = cmd
        cmd.CommandText = "select Vendor_Name from vendors Details"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Combvendor.Items.Add(dr("Vendor_Name"))
        Loop
        dr.Close()
        'cmd.CommandText = "select Cheque_Number from report_total_purchse_Details where cheque_Number is not null "
        'dr = cmd.ExecuteReader
        'Do While dr.Read = True
        '    CombCheques.Items.Add(dr("Cheque_Number"))
        'Loop
        'dr.Close()

        'cmd.CommandText = "select Bill_ID from purchase_Header "
        'dr = cmd.ExecuteReader
        'Do While dr.Read = True
        '    combBillId.Items.Add(dr("Bill_ID"))
        'Loop
        'dr.Close()

        MyDs.Tables("report_total_purchse_Details").Rows.Clear()
        DataGridView2.DataSource = MyDs.Tables("report_total_purchse_Details")

        DataGridView2.Columns(0).HeaderText = "اسم المورد"
        DataGridView2.Columns(1).HeaderText = "رقم الفاتوره"
        DataGridView2.Columns(2).HeaderText = "تاريخ الفاتوره"

        DataGridView2.Columns(3).HeaderText = "وقت الفاتوره"
        DataGridView2.Columns(4).HeaderText = "نوع الفاتوره"
        DataGridView2.Columns(5).HeaderText = "اجمالى الفاتوره"
        DataGridView2.Columns(6).HeaderText = "اجمالى النقدى"
        DataGridView2.Columns(7).HeaderText = "اجمالى الاجل"

        DataGridView2.Columns(8).HeaderText = "اجمالى الاصناف"
        DataGridView2.Columns(9).HeaderText = "رقم الشيك"
        DataGridView2.Columns(10).HeaderText = "تاريخ الاستحقاق"
        DataGridView2.Columns(11).HeaderText = "اسم الموظف"

        DataGridView2.Columns(12).Visible = False
        DataGridView2.Columns(13).Visible = False
        DataGridView2.Columns(14).Visible = False

    End Sub


    Private Sub Vendor_Name_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vendor_Name.CheckedChanged
        If Vendor_Name.Checked = True Then
            rpt.ReportDefinition.ReportObjects("vendorname1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("Text1").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(1).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("vendorname1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("Text1").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(1).Visible = False

        End If
    End Sub

    Private Sub sum_items_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum_items.CheckedChanged
        If sum_items.Checked = True Then
            rpt.ReportDefinition.ReportObjects("sumitems1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("Text2").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(2).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("sumitems1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("Text2").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(2).Visible = False
        End If
    End Sub

    Private Sub total_bill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total_bill.CheckedChanged
        If total_bill.Checked = True Then
            rpt.ReportDefinition.ReportObjects("totalbill1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("Text3").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(3).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("totalbill1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("Text3").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(3).Visible = False
        End If
    End Sub

    Private Sub maximum_bill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximum_bill.CheckedChanged
        If maximum_bill.Checked = True Then
            rpt.ReportDefinition.ReportObjects("maximumbill1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("Text4").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(4).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("maximumbill1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("Text4").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(4).Visible = False
        End If
    End Sub

    Private Sub total_cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total_cash.CheckedChanged
        If total_cash.Checked = True Then
            rpt.ReportDefinition.ReportObjects("totalcash1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("Text5").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(5).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("totalcash1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("Text5").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(5).Visible = False
        End If
    End Sub

    Private Sub total_credit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total_credit.CheckedChanged
        If total_credit.Checked = True Then
            rpt.ReportDefinition.ReportObjects("totalcredit1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("Text6").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(6).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("totalcredit1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("Text6").ObjectFormat.EnableSuppress = True
            DataGridView1.Columns(6).Visible = False
        End If
    End Sub

    Private Sub sum_bills_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum_bills.CheckedChanged
        If sum_bills.Checked = True Then
            rpt.ReportDefinition.ReportObjects("sumbills1").ObjectFormat.EnableSuppress = False
            rpt.ReportDefinition.ReportObjects("Text7").ObjectFormat.EnableSuppress = False
            DataGridView1.Columns(7).Visible = True
        Else
            rpt.ReportDefinition.ReportObjects("sumbills1").ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.ReportObjects("Text7").ObjectFormat.EnableSuppress = True
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
        rpt.SetDataSource(MyDs.Tables("report_total_Purchase"))
        rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
        CrystalReportViewer1.ReportSource = rpt
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim d1, d2 As Date
        d1 = DateTimePicker1.Text
        d2 = DateTimePicker2.Text
        MyDs.Tables("Report_Total_purchse_Details").Rows.Clear()

       

        If Radvendor.Checked = True Then
          


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If RadAllBills.Checked = True Then
                If Combvendor.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Vendor_Name =  N'" & Combvendor.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))
                End If
            ElseIf RadMAxTBill.Checked = True Then
                If Combvendor.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Total_Bill = (select max(total_bill) from Report_Total_Sales_Details) and {ثىيخق_Name=  N'" & Combvendor.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))

                End If

            ElseIf RadTotalBillBetween.Checked = True Then
                If Combvendor.Text = "" Or NumTotalBill.Value <= 0 Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Total_Bill > " & NumTotalBill.Value & "and Vendor_Name= N'" & Combvendor.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))
                End If

            ElseIf RadBillID.Checked = True Then

               
                If Combvendor.Text = "" Or combBillId.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Bill_id = " & combBillId.Text & " and Vendor_Name= N'" & Combvendor.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))

                End If

            ElseIf RadBillByDate.Checked = True Then
                If Combvendor.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Bill_Date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' and Vendor_Name =N'" & Combvendor.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))
                End If

            ElseIf RadChequeNumber.Checked = True Then

                
                If Combvendor.Text = "" Or CombCheques.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where cheque_Number = " & CombCheques.Text & " and vendor_Name= N'" & Combvendor.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))

                End If
            ElseIf RadDeservedCheques.Checked = True Then
                If Combvendor.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where recieve_date < getdate() and Vendor_Name= N'" & Combvendor.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))

                End If
            ElseIf RadAllCheques.Checked = True Then


                If Combvendor.Text = "" Then
                    MsgBox("مف فضلك اختر اسم المورد")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from report_total_purchse_details where cheque_Number is not null  and Vendor_name= N'" & Combvendor.Text & "'"
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))

                End If
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf RadAllVendor.Checked = True Then
            combBillId.Items.Clear()
            CombCheques.Items.Clear()
           
            If RadAllBills.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details   "
                da.Fill(MyDs.Tables("Report_Total_purchse_Details"))

            ElseIf RadMAxTBill.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Total_Bill = (select max(total_bill) from Report_Total_purchse_Details) "
                da.Fill(MyDs.Tables("Report_Total_purchse_Details"))


            ElseIf RadTotalBillBetween.Checked = True Then
                If NumTotalBill.Value <= 0 Then
                    MsgBox("من فضلك ادخل قيمه")
                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Total_Bill > " & NumTotalBill.Value
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))
                End If

            ElseIf RadBillID.Checked = True Then

                If combBillId.Text = "" Then
                    MsgBox("من فضلك اختر رقم الفاتوره")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Bill_id = " & combBillId.Text
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))

                End If

            ElseIf RadBillByDate.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where Bill_Date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "' "
                da.Fill(MyDs.Tables("Report_Total_purchse_Details"))


            ElseIf RadChequeNumber.Checked = True Then
                
                If CombCheques.Text = "" Then
                    MsgBox("من فضلك اختر رقم الشيك")

                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where cheque_Number = " & CombCheques.Text
                    da.Fill(MyDs.Tables("Report_Total_purchse_Details"))
                End If
            ElseIf RadAllCheques.Checked = True Then
                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from report_total_purchse_details where cheque_Number is not null  "


            ElseIf RadDeservedCheques.Checked = True Then

                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Total_purchse_Details where recieve_date < getdate() "
                da.Fill(MyDs.Tables("Report_Total_purchse_Details"))


                If MyDs.Tables("Report_Total_purchse_Details").Rows.Count > 0 Then
                    'For Each c As CheckBox In GroupBox3.Controls
                    '    c.Checked = True
                    'Next

                    DataGridView2.DataSource = MyDs.Tables("Report_Total_purchse_Details")
                    For Each c As CheckBox In GroupBox3.Controls
                        c.Checked = True
                    Next
                Else


                    cls.MsgExclamation("لا توجد بيانات", "")

                End If

            End If

        End If
        For Each c As CheckBox In GroupBox3.Controls
            c.Checked = True
        Next
    End Sub

    Private Sub RadAllVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllVendor.CheckedChanged
        If RadAllVendor.Checked = True Then
            combBillId.Items.Clear()
            CombCheques.Items.Clear()
            RadAllBills.Checked = True
            RadMAxTBill.Checked = False
            RadBillID.Checked = False
            RadChequeNumber.Checked = False
            RadTotalBillBetween.Checked = False
            RadBillByDate.Checked = False
            RadChequeNumber.Checked = False
            Combvendor.Enabled = False

            cmd.CommandText = "select Bill_ID from report_total_purchse_Details "
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                combBillId.Items.Add(dr("Bill_ID"))
            Loop
            dr.Close()


            cmd.CommandText = "select Cheque_Number from report_total_purchse_Details where cheque_Number is not null "
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                CombCheques.Items.Add(dr("Cheque_Number"))
            Loop
            dr.Close()
        End If








    End Sub

    Private Sub Radvendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radvendor.CheckedChanged
        If Radvendor.Checked = True Then
            Combvendor.Enabled = True
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

    Private Sub RadAllBills_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllBills.CheckedChanged
        If RadAllBills.Checked = True Then
            combBillId.Enabled = False
            CombCheques.Enabled = False
            NumTotalBill.Enabled = False
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

    Private Sub RadChequeNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadChequeNumber.CheckedChanged
        If RadChequeNumber.Checked = True Then
            NumTotalBill.Enabled = False
            combBillId.Enabled = False
            CombCheques.Enabled = True
        End If
    End Sub

    Private Sub RadTotalBillBetween_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTotalBillBetween.CheckedChanged
        If RadTotalBillBetween.Checked = True Then
            combBillId.Enabled = False
            CombCheques.Enabled = False
            NumTotalBill.Enabled = True
        End If
    End Sub

    Private Sub RadDeservedCheques_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDeservedCheques.CheckedChanged
        If RadDeservedCheques.Checked = True Then

            combBillId.Enabled = False
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        rpt2.SetDataSource(MyDs.Tables("Report_Total_purchse_Details"))
        rpt2.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
        CrystalReportViewer2.ReportSource = rpt2
        TabControl3.SelectTab(1)
    End Sub

    Private Sub VendorName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorName.CheckedChanged
        If VendorName.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("VendorName1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text1").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(0).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("VendorName1").ObjectFormat.EnableSuppress = True
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
            rpt2.ReportDefinition.ReportObjects("Text5").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(4).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("PayType1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text5").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(4).Visible = False
        End If

    End Sub

    Private Sub TotalBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalBill.CheckedChanged
        If TotalBill.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("TotalBill1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text6").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(5).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("TotalBill1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text6").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(5).Visible = False
        End If
    End Sub

  
    Private Sub TotalCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalCash.CheckedChanged
        If TotalCash.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("CashValue1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text7").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(6).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("CashValue1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text7").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(6).Visible = False
        End If
    End Sub

    Private Sub TotalCredit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalCredit.CheckedChanged
        If TotalCredit.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("CreditValue1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text8").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(7).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("CreditValue1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text8").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(7).Visible = False
        End If
    End Sub

    Private Sub TotalItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalItems.CheckedChanged
        If TotalItems.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("TotalItems1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text9").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(8).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("TotalItems1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text9").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(8).Visible = False
        End If
    End Sub

    
    Private Sub ChequeNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequeNumber.CheckedChanged
        If ChequeNumber.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("ChequeNumber1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text10").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(9).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("ChequeNumber1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text10").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(9).Visible = False
        End If
    End Sub

    Private Sub RecieveDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecieveDate.CheckedChanged
        If RecieveDate.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("RecieveDate1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text11").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(10).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("RecieveDate1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text11").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(10).Visible = False
        End If
    End Sub

    Private Sub EmployeeName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeName.CheckedChanged
        If EmployeeName.Checked = True Then
            rpt2.ReportDefinition.ReportObjects("EmployeeName1").ObjectFormat.EnableSuppress = False
            rpt2.ReportDefinition.ReportObjects("Text12").ObjectFormat.EnableSuppress = False
            DataGridView2.Columns(11).Visible = True


        Else
            rpt2.ReportDefinition.ReportObjects("EmployeeName1").ObjectFormat.EnableSuppress = True
            rpt2.ReportDefinition.ReportObjects("Text12").ObjectFormat.EnableSuppress = True
            DataGridView2.Columns(11).Visible = False
        End If
    End Sub

   

   
    Private Sub Combvendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combvendor.SelectedIndexChanged
        If Combvendor.Text = "" Then
            Combvendor.Focus()
            MsgBox("من فضلك اختر اسم المورد")

        Else
            cmd.CommandText = "select Bill_ID from Report_Total_purchse_Details where Vendor_Name = N'" & Combvendor.Text & "'"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                combBillId.Items.Add(dr("Bill_ID"))
            Loop
            dr.Close()



            cmd.CommandText = "select Cheque_Number from Report_Total_purchse_Details where cheque_Number is not null and vendor_name = N'" & Combvendor.Text & "'"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                CombCheques.Items.Add(dr("Cheque_Number"))
            Loop
            dr.Close()
        End If
    End Sub
End Class
