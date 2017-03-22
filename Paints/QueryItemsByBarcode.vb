Public Class QueryItemsByBarcode

    Dim t As New DataTable
    Dim b As Boolean = False

    Private Sub QueryItemsStocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        t.Rows.Clear()

        b = True

    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Barcode.Text = "" Then
                cls.MsgExclamation("أدخل الباركود", "please enter barcode")
            Else
                cmd.CommandText = "SELECT COUNT(*) from items where barcode = N'" & Barcode.Text & "'"
                If cmd.ExecuteScalar = 0 Then
                    cls.MsgCritical("هذا الصنف غير موجود")
                Else
                    t.Rows.Clear()
                    cmd.CommandText = "select STOCK_NAME AS 'اسم المخزن', ITEM_NAME AS 'اسم الصنف',BARCODE AS 'الباركود',UM_NAME AS 'مجموعة القياس',Equivalent_name AS 'الوحدة',expired_date as 'تاريخ الصلاحيه' , ROUND(CAST (Available_quantity AS decimal (18,3)),3) AS 'الرصيد' FROM report_items_stocks_balance WHERE BARCODE = N'" & Barcode.Text & "' and equivalent_name = N'" & UmDetailName.Text & "' order by expired_date asc"

                    da.SelectCommand = cmd
                    da.Fill(t)
                    DataGridView1.DataSource = t

                End If
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query Items Stocks")
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Barcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Barcode.Leave
        If b = True Then
            UmDetailName.Items.Clear()
            cmd.CommandText = "SELECT distinct dbo.Um_Details.Equivalent_name FROM dbo.Items,dbo.Um_Details,dbo.Um_Master where dbo.Items.Um_id = dbo.Um_Master.Um_Id and dbo.Um_Master.Um_Id = dbo.Um_Details.Um_Id and barcode = N'" & Barcode.Text & "'"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                UmDetailName.Items.Add(dr("Equivalent_Name"))
            Loop
            dr.Close()
        End If
    End Sub
End Class