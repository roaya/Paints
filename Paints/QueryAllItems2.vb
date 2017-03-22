Public Class QueryAllItem2
    Dim B_EndLoad As Boolean = False
    Dim ITEM_NAME As String
    Dim selformula As String
    Dim QueryAllItems As New DataTable
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Query_All_Items"
    Private Sub QueryByEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataLoad()
    End Sub
#Region "DataMethods"


    Private Sub DataLoad()
        Try
            cmd.CommandText = "select Item_Name from Items"
            dr = cmd.ExecuteReader
            Do While Not dr.Read = False
                cmbItemID.Items.Add(dr("Item_Name"))
            Loop
            dr.Close()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Q by Item name")
        End Try
    End Sub


#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If cmbItemID.Text = "" Then
                cls.MsgExclamation("أدخل اسم الصنف", "please enter item name")
            Else
                QueryAllItems.Rows.Clear()
                cmd.CommandText = "SELECT Category_Name AS 'اسم البند',Corporation_Name AS 'اسم الشركة',Item_Name AS 'اسم الصنف',Barcode AS 'الباركود',Purchase_price AS 'سعر الشراء',Sale_Price AS 'سعر القطاعي',Sale_Total_Price AS 'سعر الجمله',Um_Name AS 'مجموعة القياس' FROM Query_All_Items where Item_Name=N'" & cmbItemID.Text & "'"
                da.SelectCommand = cmd
                da.Fill(QueryAllItems)
                DataGridView1.DataSource = QueryAllItems
                TabControl1.SelectTab(1)
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Q by Item name")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
    Private Sub Button1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.GotFocus
        Button1.BackgroundImage = My.Resources._end
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Leave
        Button1.BackgroundImage = My.Resources.enter
        Button1.ForeColor = Color.Black

    End Sub

    Private Sub Button2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Leave
        Button2.BackgroundImage = My.Resources.enter
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.GotFocus
        Button2.BackgroundImage = My.Resources._end
        Button2.ForeColor = Color.White
    End Sub
End Class