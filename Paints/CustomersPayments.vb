Public Class CustomersPayments


    Dim B_EndLoad As Boolean = False
    Dim BeforePay, AfterPay As New DataTable
    
            
    Private Sub CustomersPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cls.LoadList("Customer_Name", "Customers", CustomerID)
        Catch ex As Exception
            cls.WriteError(ex.Message, "Cust Payments")
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        FillData()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If DataGridViewNotPayed.SelectedRows.Count <= 0 Then
                cls.MsgCritical("áã íÊã ÊÍÏíÏ ÇáÏÝÚÉ ÇáãÑÇÏ ÓÏÇÏåÇ", "please select payed phase")
            Else
                cmd.CommandText = "update customers_payments set status = N'ãÏÝæÚÉ' , payed_date = getdate() where pay_c_id = " & DataGridViewNotPayed.SelectedRows(0).Cells(0).Value
                cmd.ExecuteNonQuery()
                FillData()
                cls.MsgInfo("Êã ÓÏÇÏ ÇáÏÝÚÉ ÈäÌÇÍ", "selected phase has been payed successfully")
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Cust Payments")
        End Try
    End Sub

    Sub FillData()
        If CustomerID.Text = "" Then
            cls.MsgExclamation("ÃÏÎá ÇÓã ÇáÚãíá", "please enter customer name")
        Else
            Try
                BeforePay.Rows.Clear()
                cmd.CommandText = "SELECT Pay_C_ID as 'ÑÞã ÇÐä ÇáÏÝÚ',Customer_Name as 'ÇÓã ÇáÚãíá',Bill_Date as 'ÊÇÑíÎ ÇáÏÝÚÉ',Payed_Date as 'ÊÇÑíÎ ÇáÓÏÇÏ',Pay_Value as 'ÇáÞíãÉ ÇáãÏÝæÚÉ',Status as 'ÍÇáÉ ÇáÏÝÚÉ' FROM Report_Customers_Payments where Status= N'ãÌÏæáÉ' and customer_name = N'" & CustomerID.Text & "' order by bill_date asc"
                da.SelectCommand = cmd
                da.Fill(BeforePay)
                DataGridViewNotPayed.DataSource = BeforePay

                AfterPay.Rows.Clear()
                cmd.CommandText = "SELECT Pay_C_ID as 'ÑÞã ÇÐä ÇáÏÝÚ',Customer_Name as 'ÇÓã ÇáÚãíá',Bill_Date as 'ÊÇÑíÎ ÇáÏÝÚÉ',Payed_Date as 'ÊÇÑíÎ ÇáÓÏÇÏ',Pay_Value as 'ÇáÞíãÉ ÇáãÏÝæÚÉ',Status as 'ÍÇáÉ ÇáÏÝÚÉ' FROM Report_Customers_Payments where Status= N'ãÏÝæÚÉ' and customer_name = N'" & CustomerID.Text & "' order by payed_date desc"
                da.SelectCommand = cmd
                da.Fill(AfterPay)
                DataGridViewPayed.DataSource = AfterPay
            Catch ex As Exception
                cls.WriteError(ex.Message, "Cust Payments")
            End Try
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If DataGridViewNotPayed.SelectedRows.Count <= 0 Then
            cls.MsgCritical("áã íÊã ÊÍÏíÏ ÇáÏÝÚÉ ÇáãÑÇÏ ÍÐÝåÇ", "please select deleted phase")
        Else
            AssistantSound.Speak("do you want to delete selected phase")
            If MsgBox("åá ÊÑíÏ ÍÐÝ ÇáÏÝÚÉ ÇáãÍÏÏÉ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, ProjectTitle) = MsgBoxResult.Yes Then
                Try
                    cmd.CommandText = "delete from customers_payments where pay_c_id = " & DataGridViewNotPayed.SelectedRows(0).Cells(0).Value
                    cmd.ExecuteNonQuery()
                    cls.MsgInfo("Êã ÍÐÝ ÇáÏÝÚÉ ÈäÌÇÍ", "selected phase has been deleted successfully")
                    FillData()
                Catch ex As Exception
                    cls.WriteError(ex.Message, "Cust Payments")
                End Try
            End If
        End If
    End Sub
End Class
