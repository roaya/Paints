Public Class FrmAllQueries
    Dim rpt As New RptAllQueries
    Private CmdObj, WhereStmt As String
    Dim b As Boolean = True
    Dim ResChk As Boolean
    Private ClearChk As Boolean = False
    Private validateentry As Boolean = True

    Private Sub FrmAllQueries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyDs.Tables("report_all_queries").Rows.Clear()
        da.SelectCommand = cmd
        cmd.CommandText = "select stock_id from stocks"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            CombStock.Items.Add(dr("stock_id"))
        Loop
        dr.Close()
        cmd.CommandText = "select corporation_id from corporations"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            CombCorporation.Items.Add(dr("Corporation_id"))
        Loop
        dr.Close()

        cmd.CommandText = "select Category_id from categories"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            CombCategory.Items.Add(dr("Category_id"))
        Loop
        dr.Close()

        cmd.CommandText = "select Item_id from Items"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            CombItem.Items.Add(dr("Item_id"))
        Loop
        dr.Close()



        cmd.CommandText = "select Um_id from Um_Master"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            CombUm.Items.Add(dr("Um_id"))
        Loop
        dr.Close()
        cmd.CommandText = "select Vendor_id from Vendors"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            CombVendor.Items.Add(dr("Vendor_id"))
        Loop
        dr.Close()
        'CombStock.DataSource = MyDs
        'CombStock.DisplayMember = "stocks.stock_Name"
        'CombStock.ValueMember = "stocks.stock_id"
        'CombCorporation.DataSource = MyDs
        'CombCorporation.DisplayMember = "corporations.corporation_Name"
        'CombCorporation.ValueMember = "corporations.corporation_Id"
        'CombCategory.DataSource = MyDs
        'CombCategory.DisplayMember = "Categories.Category_Name"
        'CombCategory.ValueMember = "Categories.Category_Id"


        'CombItem.DataSource = MyDs
        'CombItem.DisplayMember = "items.item_Name"
        'CombItem.ValueMember = "items.item_ID"

        'CombUm.DataSource = MyDs
        'CombUm.DisplayMember = "Um_master.um_name"
        'CombUm.ValueMember = "um_master.um_ID"

        'CombVendor.DataSource = MyDs
        'CombVendor.DisplayMember = "Vendors.vendor_Name"
        'CombVendor.ValueMember = "Vendors.vendor_Id"



        DataGridView1.DataSource = MyDs.Tables("report_all_queries")
        DataGridView1.Columns(0).HeaderText = "اسم المخزن"
        DataGridView1.Columns(1).HeaderText = "اسم الشركه"
        DataGridView1.Columns(2).HeaderText = "اسم البند"
        DataGridView1.Columns(3).HeaderText = "اسم الصنف"
        DataGridView1.Columns(4).HeaderText = "الباركود"
        DataGridView1.Columns(7).HeaderText = "مجموعه القياس"
        DataGridView1.Columns(8).HeaderText = "وحده القياس"
        DataGridView1.Columns(5).HeaderText = "تاريخ الصلاحيه"
        DataGridView1.Columns(6).HeaderText = "الرصيد"
        DataGridView1.Columns(9).HeaderText = "سعر الشراء"
        DataGridView1.Columns(10).HeaderText = "سعر البيع"
        DataGridView1.Columns(11).HeaderText = "سعر الجمله"
        DataGridView1.Columns(12).HeaderText = "حد التحذير"
        DataGridView1.Columns(13).HeaderText = "اسم المورد"
        DataGridView1.Columns(14).Visible = False
        DataGridView1.Columns(15).Visible = False
        DataGridView1.Columns(16).Visible = False
        DataGridView1.Columns(17).Visible = False
        DataGridView1.Columns(18).Visible = False
        DataGridView1.Columns(19).Visible = False
        DataGridView1.Columns(20).Visible = False


    End Sub



    Private Sub radStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStock.CheckedChanged
        emptyallcheckbox()
        If radStock.Checked = True Then

            CombStock.Enabled = True
            CombBarcode.Enabled = False
            CombCategory.Enabled = False
            CombItem.Enabled = False
            CombBarcode.Enabled = False
            CombCorporation.Enabled = False
            CombUm.Enabled = False
            CombVendor.Enabled = False

        End If
    End Sub

    Private Sub radCorporation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCorporation.CheckedChanged
        emptyallcheckbox()
        If radCorporation.Checked = True Then

            CombStock.Enabled = False
            CombBarcode.Enabled = False
            CombCategory.Enabled = False
            CombItem.Enabled = False
            CombBarcode.Enabled = False
            CombCorporation.Enabled = True
            CombUm.Enabled = False
            CombVendor.Enabled = False

        End If
    End Sub

    Private Sub RadCategory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCategory.CheckedChanged
        emptyallcheckbox()
        If RadCategory.Checked = True Then


            CombStock.Enabled = False
            CombBarcode.Enabled = False
            CombCategory.Enabled = True
            CombItem.Enabled = False
            CombBarcode.Enabled = False
            CombCorporation.Enabled = False
            CombUm.Enabled = False
            CombVendor.Enabled = False

        End If
    End Sub

    Private Sub RadItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadItem.CheckedChanged
        emptyallcheckbox()
        If RadItem.Checked = True Then

            CombStock.Enabled = False
            CombBarcode.Enabled = False
            CombCategory.Enabled = False
            CombItem.Enabled = True
            CombBarcode.Enabled = False
            CombCorporation.Enabled = False
            CombUm.Enabled = False
            CombVendor.Enabled = False

        End If
    End Sub

    Private Sub RadBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBarcode.CheckedChanged
        emptyallcheckbox()
        If RadBarcode.Checked = True Then

            CombStock.Enabled = False
            CombBarcode.Enabled = False
            CombCategory.Enabled = False
            CombItem.Enabled = False
            CombBarcode.Enabled = True
            CombCorporation.Enabled = False
            CombUm.Enabled = False
            CombVendor.Enabled = False

        End If
    End Sub

    Private Sub RadUm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadUm.CheckedChanged
        emptyallcheckbox()
        If RadUm.Checked = True Then

            CombStock.Enabled = False
            CombBarcode.Enabled = False
            CombCategory.Enabled = False
            CombItem.Enabled = False
            CombBarcode.Enabled = False
            CombCorporation.Enabled = False
            CombUm.Enabled = True
            CombVendor.Enabled = False

        End If
    End Sub

    Private Sub RadVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadVendor.CheckedChanged
        emptyallcheckbox()
        If RadVendor.Checked = True Then

            CombStock.Enabled = False
            CombBarcode.Enabled = False
            CombCategory.Enabled = False
            CombItem.Enabled = False
            CombBarcode.Enabled = False
            CombCorporation.Enabled = False
            CombUm.Enabled = False
            CombVendor.Enabled = True

        End If
    End Sub

    Private Sub chkstock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stock_Name.CheckedChanged

        If Stock_Name.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub

    Private Sub chkcorporation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Corporation_Name.CheckedChanged

        If Corporation_Name.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub ChkCategory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Category_Name.CheckedChanged

        If Category_Name.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub ChkItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Item_Name.CheckedChanged


        If Item_Name.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub ChkBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Barcode.CheckedChanged

        If Barcode.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If


    End Sub

    Private Sub ChkUm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Um_Name.CheckedChanged


        If Um_Name.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub ChkexpiredDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Expired_Date.CheckedChanged

        If Expired_Date.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub ChkBalance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Balance.CheckedChanged

        If Balance.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub ChkPurchasePrice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purchase_Price.CheckedChanged

        If Purchase_Price.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub CkkSalePrice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sale_Price.CheckedChanged

        If Sale_Price.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub ChkTotalPrice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sale_Total_Price.CheckedChanged

        If Sale_Total_Price.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Private Sub ChkVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vendor_Name.CheckedChanged

            If Vendor_Name.Checked = True Then
                FillReport(False)
            Else
                FillReport(True)
            End If

    End Sub

    Private Sub ChkUmDetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Equivalent_Name.CheckedChanged

        If Equivalent_Name.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If

    End Sub

    Function GenerateSelect(ByVal BChk As Boolean) As String
        CmdObj = "select distinct "
        b = True
        For Each c As CheckBox In GroupBox2.Controls
            If c.Checked = True Then
                If b = True Then
                    CmdObj = CmdObj & c.Name
                    b = False
                Else
                    CmdObj = CmdObj & "," & c.Name
                End If
                Select Case c.Name
                    Case "Category_Name"
                        rpt.ReportDefinition.ReportObjects("CategoryName1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtcategory").ObjectFormat.EnableSuppress = BChk
                    Case "Stock_Name"
                        rpt.ReportDefinition.ReportObjects("StockName1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtStock").ObjectFormat.EnableSuppress = BChk
                    Case "Barcode"
                        rpt.ReportDefinition.ReportObjects("Barcode1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtbarcode").ObjectFormat.EnableSuppress = BChk
                    Case "Item_Name"
                        rpt.ReportDefinition.ReportObjects("ItemName1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtItem").ObjectFormat.EnableSuppress = BChk
                    Case "Corporation_Name"
                        rpt.ReportDefinition.ReportObjects("CorporationName1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtCorporation").ObjectFormat.EnableSuppress = BChk
                    Case "Um_Name"
                        rpt.ReportDefinition.ReportObjects("UmName1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtUm").ObjectFormat.EnableSuppress = BChk
                    Case "Expired_Date"
                        rpt.ReportDefinition.ReportObjects("ExpiredDate1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtExpiredDate").ObjectFormat.EnableSuppress = BChk
                    Case "Balance"
                        rpt.ReportDefinition.ReportObjects("Balance1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtBalance").ObjectFormat.EnableSuppress = BChk
                    Case "Equivalent_Name"
                        rpt.ReportDefinition.ReportObjects("Equivalentname1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtumdetail").ObjectFormat.EnableSuppress = BChk
                    Case "Purchase_Price"
                        rpt.ReportDefinition.ReportObjects("Purchaseprice1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtpurchaseprice").ObjectFormat.EnableSuppress = BChk
                    Case "Sale_Price"
                        rpt.ReportDefinition.ReportObjects("SalePrice1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtsaleprice").ObjectFormat.EnableSuppress = BChk
                    Case "Sale_Total_Price"
                        rpt.ReportDefinition.ReportObjects("SaleTotalPrice1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txttotalprice").ObjectFormat.EnableSuppress = BChk
                    Case "Vendor_Name"
                        rpt.ReportDefinition.ReportObjects("vendorname1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("txtvendor").ObjectFormat.EnableSuppress = BChk

                    Case "alert_balance"
                        rpt.ReportDefinition.ReportObjects("AlertBalance1").ObjectFormat.EnableSuppress = BChk
                        rpt.ReportDefinition.ReportObjects("Text4").ObjectFormat.EnableSuppress = BChk
                End Select
            Else
                If BChk = True Then
                    ResChk = False
                Else
                    ResChk = True
                End If
                Select Case c.Name
                    Case "Category_Name"
                        rpt.ReportDefinition.ReportObjects("CategoryName1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtcategory").ObjectFormat.EnableSuppress = ResChk
                    Case "Stock_Name"
                        rpt.ReportDefinition.ReportObjects("StockName1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtStock").ObjectFormat.EnableSuppress = ResChk
                    Case "Barcode"
                        rpt.ReportDefinition.ReportObjects("Barcode1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtbarcode").ObjectFormat.EnableSuppress = ResChk
                    Case "Item_Name"
                        rpt.ReportDefinition.ReportObjects("ItemName1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtItem").ObjectFormat.EnableSuppress = ResChk
                    Case "Corporation_Name"
                        rpt.ReportDefinition.ReportObjects("CorporationName1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtCorporation").ObjectFormat.EnableSuppress = ResChk
                    Case "Um_Name"
                        rpt.ReportDefinition.ReportObjects("UmName1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtUm").ObjectFormat.EnableSuppress = ResChk
                    Case "Expired_Date"
                        rpt.ReportDefinition.ReportObjects("ExpiredDate1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtExpiredDate").ObjectFormat.EnableSuppress = ResChk
                    Case "Balance"
                        rpt.ReportDefinition.ReportObjects("Balance1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtBalance").ObjectFormat.EnableSuppress = ResChk
                    Case "Equivalent_Name"
                        rpt.ReportDefinition.ReportObjects("Equivalentname1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtumdetail").ObjectFormat.EnableSuppress = ResChk
                    Case "Purchase_Price"
                        rpt.ReportDefinition.ReportObjects("Purchaseprice1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtpurchaseprice").ObjectFormat.EnableSuppress = ResChk
                    Case "Sale_Price"
                        rpt.ReportDefinition.ReportObjects("SalePrice1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtsaleprice").ObjectFormat.EnableSuppress = ResChk
                    Case "Sale_Total_Price"
                        rpt.ReportDefinition.ReportObjects("SaleTotalPrice1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txttotalprice").ObjectFormat.EnableSuppress = ResChk
                    Case "Vendor_Name"
                        rpt.ReportDefinition.ReportObjects("vendorname1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("txtvendor").ObjectFormat.EnableSuppress = ResChk
                   
                    Case "alert_balance"
                        rpt.ReportDefinition.ReportObjects("AlertBalance1").ObjectFormat.EnableSuppress = ResChk
                        rpt.ReportDefinition.ReportObjects("Text4").ObjectFormat.EnableSuppress = ResChk
                End Select
            End If
        Next
        If radStock.Checked = True Then
            WhereStmt = " stock_id= " & CombStock.Text
        ElseIf RadBarcode.Checked = True Then
            WhereStmt = " barcode= N'" & CombBarcode.Text & "'"
        ElseIf RadCategory.Checked = True Then
            WhereStmt = " category_id = " & CombCategory.Text
        ElseIf radCorporation.Checked = True Then
            WhereStmt = " corporation_id = " & CombCorporation.Text
        ElseIf RadItem.Checked = True Then
            WhereStmt = " item_id = " & CombItem.Text
        ElseIf RadUm.Checked = True Then
            WhereStmt = " um_id = " & CombUm.Text

        ElseIf RadVendor.Checked = True Then
            WhereStmt = " vendor_id = " & CombVendor.Text

        ElseIf RadAlert.Checked = True Then
            WhereStmt = " Balance <= Alert_Balance"

        End If
        CmdObj = CmdObj & ",(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  FROM Report_All_Queries WHERE " & WhereStmt


        b = True
        Return CmdObj
    End Function


    Sub FillReport(ByVal Bch As Boolean)
        Dim c As Integer

        Try
            MyDs.Tables("Report_All_Queries").Rows.Clear()
            If radStock.Checked = True Then

                If CombStock.Text = "" And validateentry = True Then
                    MsgBox("من فضلك اختر اسم المخزن")

                    Exit Sub

                Else
                    cmd.CommandText = GenerateSelect(Bch)
                    da.Fill(MyDs.Tables("Report_All_Queries"))
                    DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")
                End If
            ElseIf radCorporation.Checked = True Then



                If CombCorporation.Text = "" And validateentry = True Then
                    MsgBox("من فضلك اختر اسم الشركه")

                    Exit Sub

                Else
                    cmd.CommandText = GenerateSelect(Bch)
                    da.Fill(MyDs.Tables("Report_All_Queries"))
                    DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")
                End If

            ElseIf RadCategory.Checked = True Then
                If CombCategory.Text = "" And validateentry = True Then
                    MsgBox("من فضلك اختر اسم البند")

                    Exit Sub

                Else
                    cmd.CommandText = GenerateSelect(Bch)
                    da.Fill(MyDs.Tables("Report_All_Queries"))
                    DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")
                End If
            ElseIf RadItem.Checked = True Then
                If CombItem.Text = "" And validateentry = True Then
                    MsgBox("من فضلك اختر اسم الصنف")


                    Exit Sub
                Else
                    cmd.CommandText = GenerateSelect(Bch)
                    da.Fill(MyDs.Tables("Report_All_Queries"))
                    DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")
                End If
            ElseIf RadUm.Checked = True Then
                If CombUm.Text = "" And validateentry = True Then
                    MsgBox("من فضلك اختر مجموعه القياس")

                    Exit Sub
                Else
                    cmd.CommandText = GenerateSelect(Bch)
                    da.Fill(MyDs.Tables("Report_All_Queries"))
                    DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")
                End If
            ElseIf RadBarcode.Checked = True Then
                If CombBarcode.Text = "" And validateentry = True Then
                    MsgBox("من فضلك ادخل الباركود")

                    Exit Sub

                Else
                    cmd.CommandText = GenerateSelect(Bch)
                    da.Fill(MyDs.Tables("Report_All_Queries"))
                    DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")
                End If
            ElseIf RadVendor.Checked = True Then
                If CombVendor.Text = "" And validateentry = True Then
                    MsgBox("من فضلك اختر اسم المورد")

                    Exit Sub

                Else
                    cmd.CommandText = GenerateSelect(Bch)
                    da.Fill(MyDs.Tables("Report_All_Queries"))
                    DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")
                End If
            ElseIf RadAlert.Checked = True Then

                cmd.CommandText = GenerateSelect(Bch)
                da.Fill(MyDs.Tables("Report_All_Queries"))
                DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")

            End If
            'cmd.CommandText = GenerateSelect(Bch)
            'da.Fill(MyDs.Tables("Report_All_Queries"))
            'DataGridView1.DataSource = MyDs.Tables("Report_All_Queries")



        Catch
            c = 5


        End Try
    End Sub

    Sub emptyallcheckbox()
        validateentry = False
        CrystalReportViewer1.Visible = False
        For Each c As CheckBox In GroupBox2.Controls
            c.Checked = False
        Next
        CrystalReportViewer1.Visible = True
        validateentry = True
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rpt.SetDataSource(MyDs.Tables("Report_All_Queries"))
        rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
        CrystalReportViewer1.ReportSource = rpt
        TabControl1.SelectTab(1)
    End Sub

   

    Private Sub Alert_Balance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alert_Balance.CheckedChanged
        If Alert_Balance.Checked = True Then
            FillReport(False)
        Else
            FillReport(True)
        End If
    End Sub

    Private Sub RadAlert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAlert.CheckedChanged
        emptyallcheckbox()
        CombStock.Enabled = False
        CombBarcode.Enabled = False
        CombCategory.Enabled = False
        CombItem.Enabled = False
        CombBarcode.Enabled = False
        CombCorporation.Enabled = False
        CombUm.Enabled = False
        CombVendor.Enabled = False

    End Sub
End Class