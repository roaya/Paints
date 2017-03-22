Public Class ItemsSalesDetails

    Dim B_EndLoad As Boolean = False
    Dim B_Edited As Boolean = False
    Dim DTemp As Double
    Dim CurID, SeqID As New SqlClient.SqlParameter
    Dim cmdPro As New SqlClient.SqlCommand
    Dim TName As String = "Sales Details"
    Dim RowID, ItmID As Integer
    Dim ItmName, BarCde As String
    Dim ItmPrc As Double
    Dim BDate, BDateExpire As Date
    Private TblItmDtl As New GeneralDataSet.Items_stocksDataTable
    Public B_ID As Integer
    Dim Total As Integer = 0
    Dim BSourceItemsDetails As New BindingSource
    Public OType As String
    Dim PurPrice As Double
    Public Total_Eq As Double
    Public StkItmDtl As Integer

    Sub AddItem()
        Try
            If Quantity.Value = 0 Then
                cls.MsgExclamation("ادخل العدد", "Please enter Component quantity")
            ElseIf DataGridView2.SelectedRows.Count <= 0 Then
                cls.MsgExclamation("يجب اختيار صنف لتكوين الصنف التجاري", "please select a record")
            Else

                r = MyDs.Tables("Items_Sales_Details").NewRow
                r("Serial_PK") = ProjectSettings.CurrSerialPK
                r("Item_Name") = ComboUmDetailID.Text & " " & ItmName
                r("Item_ID") = ItmID
                r("Barcode") = BarCde
                r("um_detail_id") = ComboUmDetailID.SelectedValue
                r("Quantity") = Quantity.Value
                r("expired_date") = DataGridView2.SelectedRows(0).Cells("expired_date").Value
                r("Price") = Price.Value
                r("Total_Item") = Price.Value * Quantity.Value
                r("Bill_ID") = B_ID
                r("Total_Cost") = PurPrice * Quantity.Value

                MyDs.Tables("Items_Sales_Details").Rows.Add(r)
                Quantity.Value = 0
                Price.Value = 0

                Total_Eq = 0

                For I As Integer = 0 To DataGridView1.Rows.Count - 1
                    cmd.CommandText = "select dbo.Calculate_Base(" & DataGridView1.Rows(I).Cells("Item_ID").Value & "," & DataGridView1.Rows(I).Cells("Um_Detail_ID").Value & "," & DataGridView1.Rows(I).Cells("Quantity").Value & ")"
                    Total_Eq = Total_Eq + cmd.ExecuteScalar()
                Next

                'If MyDs.Tables("App_Preferences").Rows(0).Item("Ret_Ven_Def_Sch") = "الاسم" Then
                '    RadioButton1.Checked = True
                '    ItemName.Focus()
                'Else
                '    RadioButton2.Checked = True
                '    BarCode.Focus()
                'End If
                'Quantity.Value = MyDs.Tables("App_Preferences").Rows(0).Item("Adj_Def_Qty")
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub Quantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItem()
        End If

    End Sub

    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        RowID = DataGridView1.CurrentCell.RowIndex
    End Sub




    Private Sub ItemsSalesDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ' cls.SetGrant(MenuItemsStocks, "نافذة ربط الأصناف بالمحلات")

            ItemName.Items.Clear()
            'If B_EndLoad = True Then
            cmd.CommandText = "select distinct item_name from Query_Items_stocks where stock_id =" & StkItmDtl
            dr = cmd.ExecuteReader
            Do While Not dr.Read = False
                ItemName.Items.Add(dr("Item_Name"))
            Loop
            dr.Close()
            'End If

            BSourceItemsDetails.DataSource = MyDs
            BSourceItemsDetails.DataMember = "Items_Sales_Details"
            BSourceItemsDetails.Filter = "serial_pk = " & ProjectSettings.CurrSerialPK

            DataGridView1.DataSource = BSourceItemsDetails
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).HeaderText = "اسم الصنف"
            DataGridView1.Columns(3).ReadOnly = True
            DataGridView1.Columns(4).HeaderText = "الباركود"
            DataGridView1.Columns(4).ReadOnly = True
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).HeaderText = "تاريخ الصلاحيه"
            DataGridView1.Columns(7).HeaderText = "العدد"
            DataGridView1.Columns(8).HeaderText = "السعر"
            DataGridView1.Columns(9).HeaderText = "الاجمالي"
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).HeaderText = "التكلفه"



            REM cls.RefreshData("um_details")
            REM cls.RefreshData("Query_Items_Um")
            REM BSourceUmDetails.DataSource = MyDs
            REM BSourceUmDetails.DataMember = "Query_Items_Um"
            BSourceUmDetails.Filter = "item_id = 0"
            ComboUmDetailID.DataSource = BSourceUmDetails
            ComboUmDetailID.DisplayMember = "Equivalent_name"
            ComboUmDetailID.ValueMember = "Um_Detail_Id"

            TblItmDtl.Columns("Total").Expression = "Balance*Price"

            cls.RefreshData("select * from Items_Stocks", TblItmDtl)
            BSourceItemStocks.DataSource = TblItmDtl
            BSourceItemStocks.Filter = "Item_ID = 0"
            DataGridView2.DataSource = BSourceItemStocks
            DataGridView2.Columns(0).Visible = False
            DataGridView2.Columns(1).Visible = False
            DataGridView2.Columns(2).Visible = False
            DataGridView2.Columns(3).Visible = False
            DataGridView2.Columns(4).Visible = False
            DataGridView2.Columns(5).Visible = False
            DataGridView2.Columns(6).HeaderText = "تاريخ الصلاحيه"
            DataGridView2.Columns(7).HeaderText = "الرصيد"
            DataGridView2.Columns(8).HeaderText = "التكلفه"
            DataGridView2.Columns(9).HeaderText = "الاجمالي"


            B_EndLoad = True

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("Calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub ItemName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemName.Leave
        Try
            If B_EndLoad = True Then
                cmd.CommandText = "select Sale_Total_Price,Purchase_Price,Sale_price,Item_ID,Barcode from items where item_name = N'" & ItemName.Text & "'"
                dr = cmd.ExecuteReader
                Do While Not dr.Read = False
                    If OType = "جملة" Then
                        Price.Value = dr("Sale_Total_Price")
                    Else
                        Price.Value = dr("Sale_Price")
                    End If
                    ItmName = ItemName.Text
                    BarCde = dr("Barcode")
                    ItmID = dr("Item_ID")
                    PurPrice = dr("Purchase_Price")
                Loop
                dr.Close()

                BSourceUmDetails.Filter = "item_id = " & ItmID
                BSourceItemStocks.Filter = "item_id = " & ItmID & " and stock_id = " & StkItmDtl
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

   

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class