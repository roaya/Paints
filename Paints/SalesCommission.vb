Public Class SalesCommission

    Dim BSourceSalesCommission As New BindingSource
    Dim B As Boolean = False

   
    Private Sub SalesCommission_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If B = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub SalesCommission_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        BSourceSalesCommission.DataSource = MyDs
        BSourceSalesCommission.DataMember = "Sales_Commission"

        Serial_PK.DataPropertyName = "serial_pk"
        Bill_ID.DataPropertyName = "Bill_ID"
        Commission_Pct.DataPropertyName = "Commission_Pct"
        Commission_Value.DataPropertyName = "Commission_Value"

        Employee_ID.DataSource = MyDs
        Employee_ID.DisplayMember = "Employees.Employee_Name"
        Employee_ID.ValueMember = "Employees.Employee_ID"
        Employee_ID.DataPropertyName = "Employee_ID"

        DataGridView1.DataSource = BSourceSalesCommission

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BSourceSalesCommission.EndEdit()
        For i As Integer = 0 To DataGridView1.Rows.Count - 2
            If DataGridView1.Rows(i).Cells("Commission_Value").Value > 0 And DataGridView1.Rows(i).Cells("Commission_Pct").Value > 0 Then

                B = False
                cls.MsgExclamation("ÌÃ» «œŒ«· ‰”»Â «Ê „»·€ À«» ", "you must enter commission either by value or by percentage")
                Exit Sub
            End If

        Next
        B = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MyDs.Tables("Sales_Commission").Rows.Clear()
        B = True
        Me.Close()
    End Sub
End Class
