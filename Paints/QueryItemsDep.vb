Public Class QueryItemsDep

    Dim t As New DataTable

    Private Sub QueryItemsDep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData("Items")
            ItemName.DataSource = MyDs
            ItemName.DisplayMember = "items.item_name"
            ItemName.ValueMember = "items.item_id"

            cmd.CommandText = "select * from report_dep where bill_id=0"
            da.SelectCommand = cmd
            da.Fill(t)

            DataGridView1.DataSource = t
            DataGridView1.Columns(0).HeaderText = "رقم المستند"
            DataGridView1.Columns(1).HeaderText = "التاريخ"
            DataGridView1.Columns(2).HeaderText = "الوقت"
            DataGridView1.Columns(3).HeaderText = "اسم المخزن"
            DataGridView1.Columns(4).HeaderText = "اسم الموظف"
            DataGridView1.Columns(5).HeaderText = "اسم الصنف"
            DataGridView1.Columns(6).HeaderText = "العدد"
            DataGridView1.Columns(7).HeaderText = "السبب"


            BillID.Items.Clear()

            cmd.CommandText = "select bill_id from Dep_Header order by bill_id"
            dr = cmd.ExecuteReader
            Do While Not dr.Read = False
                BillID.Items.Add(dr("Bill_ID"))
            Loop
            dr.Close()

            cls.RefreshData("Stocks")

            StockID.DataSource = MyDs
            StockID.DisplayMember = "Stocks.Stock_Name"
            StockID.ValueMember = "Stocks.Stock_ID"
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Items Dep")
        End Try
    End Sub

    Private Sub RadioBillID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBillID.CheckedChanged
        If RadioBillID.Checked = True Then
            BillID.Enabled = True
            ItemName.Enabled = False
            StockID.Enabled = False
        End If
    End Sub

    Private Sub RadioItemName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioItemName.CheckedChanged
        If RadioItemName.Checked = True Then
            BillID.Enabled = False
            ItemName.Enabled = True
            StockID.Enabled = False
        End If
    End Sub


    Private Sub RadioStockName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioStockName.CheckedChanged
        If RadioStockName.Checked = True Then
            BillID.Enabled = False
            ItemName.Enabled = False
            StockID.Enabled = True
        End If
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            t.Rows.Clear()
            If RadioBillID.Checked = True Then
                cmd.CommandText = "select * from report_dep where bill_id = " & BillID.Text
                da.SelectCommand = cmd
                da.Fill(t)
            ElseIf RadioStockName.Checked = True Then
                cmd.CommandText = "select * from report_dep where stock_name = N'" & StockID.Text & "'"
                da.SelectCommand = cmd
                da.Fill(t)
            ElseIf RadioItemName.Checked = True Then
                cmd.CommandText = "select * from report_dep where item_id = " & ItemName.SelectedValue
                da.SelectCommand = cmd
                da.Fill(t)
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Items Dep")
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackgroundImage = My.Resources._end
        Button1.ForeColor = Color.White

    End Sub

    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.BackgroundImage = My.Resources._end
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.enter
        Button1.ForeColor = Color.Black

    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources.enter
        Button2.ForeColor = Color.Black
    End Sub
End Class