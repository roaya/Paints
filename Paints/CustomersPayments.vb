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
                cls.MsgCritical("�� ��� ����� ������ ������ ������", "please select payed phase")
            Else
                cmd.CommandText = "update customers_payments set status = N'������' , payed_date = getdate() where pay_c_id = " & DataGridViewNotPayed.SelectedRows(0).Cells(0).Value
                cmd.ExecuteNonQuery()
                FillData()
                cls.MsgInfo("�� ���� ������ �����", "selected phase has been payed successfully")
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Cust Payments")
        End Try
    End Sub

    Sub FillData()
        If CustomerID.Text = "" Then
            cls.MsgExclamation("���� ��� ������", "please enter customer name")
        Else
            Try
                BeforePay.Rows.Clear()
                cmd.CommandText = "SELECT Pay_C_ID as '��� ��� �����',Customer_Name as '��� ������',Bill_Date as '����� ������',Payed_Date as '����� ������',Pay_Value as '������ ��������',Status as '���� ������' FROM Report_Customers_Payments where Status= N'������' and customer_name = N'" & CustomerID.Text & "' order by bill_date asc"
                da.SelectCommand = cmd
                da.Fill(BeforePay)
                DataGridViewNotPayed.DataSource = BeforePay

                AfterPay.Rows.Clear()
                cmd.CommandText = "SELECT Pay_C_ID as '��� ��� �����',Customer_Name as '��� ������',Bill_Date as '����� ������',Payed_Date as '����� ������',Pay_Value as '������ ��������',Status as '���� ������' FROM Report_Customers_Payments where Status= N'������' and customer_name = N'" & CustomerID.Text & "' order by payed_date desc"
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
            cls.MsgCritical("�� ��� ����� ������ ������ �����", "please select deleted phase")
        Else
            AssistantSound.Speak("do you want to delete selected phase")
            If MsgBox("�� ���� ��� ������ �������", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, ProjectTitle) = MsgBoxResult.Yes Then
                Try
                    cmd.CommandText = "delete from customers_payments where pay_c_id = " & DataGridViewNotPayed.SelectedRows(0).Cells(0).Value
                    cmd.ExecuteNonQuery()
                    cls.MsgInfo("�� ��� ������ �����", "selected phase has been deleted successfully")
                    FillData()
                Catch ex As Exception
                    cls.WriteError(ex.Message, "Cust Payments")
                End Try
            End If
        End If
    End Sub
End Class
