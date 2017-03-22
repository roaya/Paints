Public Class QueryByBarcode

    Dim selformula As String
    Dim QueryAllItems As New DataTable
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Query_All_Items"
    Private Sub QueryByEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataClear()
        ' DataLoad()
    End Sub
#Region "DataMethods"
    Private Sub DataClear()

        QueryAllItems.Rows.Clear()

    End Sub
    'Private Sub DataLoad()
    '    cmbAgeID.DataSource = MyDs
    '    cmbAgeID.DisplayMember = "Ages.Age_Desc"
    '    cmbAgeID.ValueMember = "Ages.Age_ID"
    'End Sub

    Private Function DataValidate(ByVal errorMessage As String) As Boolean
        If TxtBarCode.Text = "" Then
            DataValidate = False
            errorMessage = "لا توجد بيانات."
        Else
            DataValidate = True
            errorMessage = ""

        End If

    End Function

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        choseForm()
        DataClear()
        cmd.CommandText = "" & selformula & ""
        If cmd.CommandText = "" Then cls.MsgExclamation("من فضلك ادخل البيانات الناقصة", "please enter missing data") : Exit Sub
        da.SelectCommand = cmd
        da.Fill(QueryAllItems)
        DataGridView1.DataSource = QueryAllItems
        If QueryAllItems.Rows.Count > 0 Then
            TabControl1.SelectedTab = TabPage2

        Else
            cls.MsgExclamation("من فضلك ادخل البيانات الناقصة", "please enter missing data")
        End If

    End Sub

    Private Sub choseForm()
        selformula = ""
        If TxtBarCode.Text <> "" Then
            selformula = "SELECT Category_Name AS 'اسم البند',Corporation_Name AS 'اسم الشركة',Item_Name AS 'اسم الصنف',Barcode AS 'الباركود',Purchase_price AS 'سعر الشراء',Sale_Price AS 'سعر القطاعي',Sale_Total_Price AS 'سعر الجمله',Um_Name AS 'مجموعة القياس' FROM Query_All_Items  where Barcode ='" & TxtBarCode.Text & "'"

        End If
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

    Private Sub TxtBarCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBarCode.GotFocus
        TxtBarCode.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub TxtBarCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBarCode.Leave
        TxtBarCode.BackColor = Color.Gainsboro
    End Sub
End Class