Public Class PayTotalSalary

    Dim ChValue As Double
    Dim ChqID, FAccID, ToAccID As Integer
    Dim d1, d2 As Date

    Private Sub TxtCheque_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCheque.GotFocus
        TxtCheque.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub TxtCheque_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCheque.Leave

        If RadioBank.Checked = True Then
            If TxtCheque.Text <> "" Then
                cmd.CommandText = "select dbo.Is_Cheque_Valid('" & TxtCheque.Text & "')"
                ChqID = cmd.ExecuteScalar
                If ChqID = 0 Then
                    cls.MsgExclamation("الشيك غير صالح للاستخدام", "CURRENT CHEQUE NUMBER ISNOT VALID")
                    TxtCheque.Focus()
                    Exit Sub
                Else
                    cmd.CommandText = "select cheque_value from cheques where cheque_number = " & TxtCheque.Text
                    ChValue = cmd.ExecuteScalar
                End If
            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("هل أنت متأكد", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, ProjectTitle) = MsgBoxResult.Yes Then
            If RadioCash.Checked = True Then
                cmd.CommandText = "Exec Commit_Procedure_Tran 12,4," & TotalSalaryDep.Text & ",N'" & PaymentDesc.Text & "'"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Exec Commit_Procedure_Tran 28,4," & TotalSalaryMarketing.Text & ",N'" & PaymentDesc.Text & "'"
                cmd.ExecuteNonQuery()
            ElseIf RadioBank.Checked = True Then
                'cmd.CommandText = "select dbo.Get_Bank_Procedure_ID(" & TxtCheque.Text & ")"
                'ToAccID = cmd.ExecuteScalar
                cmd.CommandText = "Exec Commit_Procedure_Tran 12,24," & TotalSalaryDep.Text & ",N'" & PaymentDesc.Text & "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Exec Commit_Procedure_Tran 28,24," & TotalSalaryMarketing.Text & ",N'" & PaymentDesc.Text & "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "UPDATE Cheques SET Cheque_Status=N'غير منصرف' WHERE Cheque_No = '" & TxtCheque.Text & "'"
                cmd.ExecuteNonQuery()
            End If
            cls.MsgInfo("تم سداد المرتبات بنجاح", "")
        End If
    End Sub

    Private Sub PayTotalSalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d1 = "01/" & Now.ToString("MM") & "/" & Now.ToString("yyyy")

        d2 = Date.DaysInMonth(CInt(Now.Year), CInt(Now.Month)) & "/" & Now.ToString("MM") & "/" & Now.Year
        cmd.CommandText = "select isnull(sum(P.net_salary),0) from pay_salary P,Departments D,Employees E WHERE E.Department_Id=D.Department_Id AND P.Employee_ID=E.Employee_Id AND D.Generic_Desc =N'اداريه' and p.pay_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
        TotalSalaryDep.Text = cmd.ExecuteScalar

        cmd.CommandText = "select isnull(sum(P.net_salary),0) from pay_salary P,Departments D,Employees E WHERE E.Department_Id=D.Department_Id AND P.Employee_ID=E.Employee_Id AND D.Generic_Desc =N'تسويقيه' and p.pay_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'"
        TotalSalaryMarketing.Text = cmd.ExecuteScalar

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim m As New Cheques
        m.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PaymentDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PaymentDesc.GotFocus
        PaymentDesc.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub PaymentDesc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PaymentDesc.Leave
        PaymentDesc.BackColor = Color.Gainsboro

    End Sub
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackgroundImage = My.Resources._end
        Button1.ForeColor = Color.White

    End Sub

    Private Sub Button3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.BackgroundImage = My.Resources._end
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.enter
        Button1.ForeColor = Color.Black

    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackgroundImage = My.Resources.enter
        Button3.ForeColor = Color.Black
    End Sub
    Private Sub Button1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.GotFocus
        Button1.BackgroundImage = My.Resources._end
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Leave
        Button1.BackgroundImage = My.Resources.enter
        Button1.ForeColor = Color.Black

    End Sub

    Private Sub Button3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Leave
        Button3.BackgroundImage = My.Resources.enter
        Button3.ForeColor = Color.Black
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.GotFocus
        Button3.BackgroundImage = My.Resources._end
        Button3.ForeColor = Color.White
    End Sub
End Class