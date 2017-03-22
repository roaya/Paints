Public Class ReportStockValue

    Private Rpt As New Report_Stock_Balance
    Private TblItem As New GeneralDataSet.itemsDataTable
    Private TblStk As New GeneralDataSet.stocksDataTable

    Private Sub RadioStockID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioStockID.CheckedChanged
        If RadioStockID.Checked = True Then
            StockID.Enabled = True
            ItemName.Enabled = False
        End If
    End Sub

    Private Sub RadioItemName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioItemName.CheckedChanged
        If RadioItemName.Checked = True Then
            StockID.Enabled = False
            ItemName.Enabled = True
        End If
    End Sub

    Private Sub RadioItemStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioItemStock.CheckedChanged
        If RadioItemStock.Checked = True Then
            StockID.Enabled = True
            ItemName.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioStockID.Checked = True Then
            If StockID.Text = "" Then
                cls.MsgExclamation("أدخل اسم المخزن")
                Exit Sub
            Else
                cmd.CommandText = "SELECT * from Vu_Stock_Value where Stock_ID=" & StockID.SelectedValue
            End If
        ElseIf RadioItemName.Checked = True Then
            If ItemName.Text = "" Then
                cls.MsgExclamation("أدخل اسم الصنف")
                Exit Sub
            Else
                cmd.CommandText = "SELECT * from Vu_Stock_Value where Item_Name = N'" & ItemName.Text & "'"
            End If
        ElseIf RadioItemStock.Checked = True Then
            If StockID.Text = "" Then
                cls.MsgExclamation("أدخل اسم المخزن")
                Exit Sub
            ElseIf ItemName.Text = "" Then
                cls.MsgExclamation("أدخل اسم الصنف")
                Exit Sub
            Else
                cmd.CommandText = "SELECT * from Vu_Stock_Value where Item_Name = N'" & ItemName.Text & "' and Stock_ID=" & StockID.SelectedValue
            End If
        End If

        MyDs.Tables("Vu_Stock_Value").Rows.Clear()
        da.SelectCommand = cmd
        da.Fill(MyDs.Tables("Vu_Stock_Value"))
        Rpt.SetDataSource(MyDs.Tables("Vu_Stock_Value"))
        Dim m As New ShowAllReports
        m.CrystalReportViewer1.ReportSource = Rpt
        m.Show()

    End Sub

    Private Sub ReportStockValue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cls.RefreshData("select Item_ID,Item_Name from Items Order By Item_Name", TblItem)
        ItemName.DataSource = TblItem
        ItemName.DisplayMember = "Item_Name"
        ItemName.ValueMember = "Item_ID"

        cls.RefreshData("select Stock_ID,Stock_Name from Stocks Order By Stock_Name", TblStk)
        StockID.DataSource = TblStk
        StockID.DisplayMember = "stock_Name"
        StockID.ValueMember = "stock_ID"

    End Sub
End Class