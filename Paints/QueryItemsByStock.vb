Public Class QueryItemsByStock

    Dim t As New DataTable
    Dim b As Boolean = False

    Private Sub QueryItemsStocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            t.Rows.Clear()

            ItemName.Items.Clear()
            cmd.CommandText = "select item_name from items"
            dr = cmd.ExecuteReader
            Do While Not dr.Read = False
                ItemName.Items.Add(dr("Item_Name"))
            Loop
            dr.Close()

            b = True
        Catch ex As Exception
            cls.WriteError(ex.Message, "Qry Itms by Stks")
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ItemName.Text = "" Then
                cls.MsgExclamation("أدخل اسم الصنف", "please enter item name")
            ElseIf UmDetailName.Text = "" Then
                cls.MsgExclamation("أدخل وحدة القياس", "please enter unit of measure")
            Else
                cmd.CommandText = "SELECT count(*) from items where item_name = N'" & ItemName.Text & "'"
                If cmd.ExecuteScalar = 0 Then
                    cls.MsgCritical("هذا الصنف غير موجود", "invalid item name")
                Else
                    t.Rows.Clear()
                    cmd.CommandText = "select STOCK_NAME AS 'اسم المخزن', ITEM_NAME AS 'اسم الصنف',BARCODE AS 'الباركود',UM_NAME AS 'مجموعة القياس',Equivalent_name AS 'الوحدة',expired_date as 'تاريخ الصلاحيه' , ROUND(CAST (Available_quantity AS decimal (18,3)),3) AS 'الرصيد' FROM report_items_stocks_balance WHERE ITEM_NAME = N'" & ItemName.Text & "' and equivalent_name = N'" & UmDetailName.Text & "' order by expired_date asc"
                    da.SelectCommand = cmd
                    da.Fill(t)

                    DataGridView1.DataSource = t

                End If
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Qry Itms by Stks")
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub ItemName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemName.SelectedIndexChanged
        If b = True Then
            UmDetailName.Items.Clear()
            cmd.CommandText = "select distinct Equivalent_Name from Query_Items_Um where item_name = N'" & ItemName.Text & "'"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                UmDetailName.Items.Add(dr("Equivalent_Name"))
            Loop
            dr.Close()
        End If
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