Public Class ChangeBillStatus

    Private Sub ChangeBillStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmd.CommandText = "select bill_id from sales_header where bill_status = 1"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                ComboBillID.Items.Add(dr("bill_id"))
            Loop
            dr.Close()
        Catch ex As Exception
            cls.WriteError(ex.Message, "change b status")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBillID.Text = "" Then
            cls.MsgExclamation("اختر رقم الفاتوره", "")
        Else
            Try
                cmd.CommandText = "update sales_header set bill_status = 0 where bill_id = " & ComboBillID.Text
                cmd.ExecuteScalar()
                ComboBillID.Items.Clear()
                cmd.CommandText = "select bill_id from sales_header where bill_status = 1"
                dr = cmd.ExecuteReader
                Do While dr.Read = True
                    ComboBillID.Items.Add(dr("bill_id"))
                Loop
                dr.Close()
                cls.MsgInfo("تم تغيير حالة الفاتوره بنجاح", "")
            Catch ex As Exception
                cls.WriteError(ex.Message, "change b status")
            End Try
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