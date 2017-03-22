Public Class QueryItemsStocks

    Dim t As New DataTable

    Private Sub QueryItemsStocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            t.Rows.Clear()
            cls.RefreshData("Stocks")

            StockID.DataSource = MyDs
            StockID.DisplayMember = "Stocks.Stock_Name"
            StockID.ValueMember = "Stocks.Stock_ID"
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Items Stocks")
        End Try

    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If StockID.Text = "" Then
                cls.MsgExclamation("√œŒ· «”„ «·„Õ·", "please enter warehouse")
            Else
                t.Rows.Clear()
                cmd.CommandText = "select STOCK_NAME AS '«”„ «·„Œ“‰', ITEM_NAME AS '«”„ «·’‰›',BARCODE AS '«·»«—ﬂÊœ',UM_NAME AS '„Ã„Ê⁄… «·ﬁÌ«”',Equivalent_name AS '«·ÊÕœ…',expired_date as ' «—ÌŒ «·’·«ÕÌÂ' , ROUND(CAST (Available_quantity AS decimal (18,3)),3) AS '«·—’Ìœ' FROM report_items_stocks_balance WHERE stock_id = " & StockID.SelectedValue & " order by item_name,expired_date asc"

                da.SelectCommand = cmd
                da.Fill(t)

                DataGridView1.DataSource = t
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Items Stocks")
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