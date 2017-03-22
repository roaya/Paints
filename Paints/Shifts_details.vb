Public Class Shifts_details
    ''''' Dim BSourceShiftsDetails As BindingSource

    Dim B_EndLoad As Boolean = False
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Shift_Details"
    Dim t As New DataTable
    Dim T_Delivery, T_Takeaway, T_Sales, T_End_Money, T_Returns, T_Expenses, T_Purchase, T_Receive, T_Payment As Double
    Dim d As Date
    '-------------------------------
    Private Sub Shifts_Details_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Shiftsdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData("Shifts")
            cls.RefreshData(TName)

            Me.Text = " ›«’Ì· «·Ê—œÌ…"


            ShiftID.DataSource = MyDs
            ShiftID.DisplayMember = "Shifts.Shift_Name"
            ShiftID.ValueMember = "Shifts.Shift_ID"

            cmd.CommandText = "select * from query_shifts where End_Date is null"
            da.SelectCommand = cmd
            da.Fill(t)
            DataGridView1.DataSource = t
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).HeaderText = "«”„ «·Ê—œÌÂ"
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).HeaderText = " «—ÌŒ «·»œ«ÌÂ"
            DataGridView1.Columns(4).HeaderText = " «—ÌŒ «·‰Â«ÌÂ"
            DataGridView1.Columns(5).HeaderText = "Êﬁ  «·»œ«ÌÂ"
            DataGridView1.Columns(6).HeaderText = "Êﬁ  «·‰Â«ÌÂ"
            DataGridView1.Columns(7).HeaderText = "«·—’Ìœ «·«›  «ÕÌ"
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).HeaderText = "«”„ «·„ÊŸ›"


            RVal = "Shift_ID"

            B_EndLoad = True

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Try

            If ShiftID.SelectedValue = Nothing Then
                cls.MsgExclamation("»—Ã«¡ «Œ Ì«— ‰Ê⁄ «·Ê—œÌÂ")
                Exit Sub
            End If
            If CurrentShiftId <> 0 Then
                cls.MsgExclamation("ÌÃ» «€·«ﬁ «·Ê—œÌÂ «·„› ÊÕÂ √Ê·«")
            Else





                cmd.CommandText = "select count(*) from shift_details where end_date is null"
                If cmd.ExecuteNonQuery <= 0 Then

                    Try
                        cmd.CommandText = "insert into shift_details(shift_id,start_money,start_date,start_time,employee_id) values(" & ShiftID.SelectedValue & "," & FirstBalance.Value & ", getdate() , '" & Now.ToLongTimeString & "' , " & EmpIDVar & ")"
                        cmd.ExecuteNonQuery()
                    Catch
                        cls.MsgExclamation("·ﬁœ  „ › Õ Ê—œÌ… ·‰›” «·„ÊŸ› ⁄·Ï ‰›” ‰Ê⁄ «·Ê—œÌ… ")
                        Exit Sub
                    End Try
                    t.Rows.Clear()
                    cmd.CommandText = "select * from query_shifts where End_Date is null"
                    da.SelectCommand = cmd
                    da.Fill(t)

                    cmd.CommandText = "select max(shift_detail_id) from shift_details"
                    CurrentShiftId = cmd.ExecuteScalar


                    cls.MsgInfo(" „ › Õ «·Ê—œÌÂ «·ÃœÌœÂ »‰Ã«Õ")
                Else
                    cls.MsgCritical("»—Ã«¡ «€·«ﬁ «·Ê—œÌÂ «·„› ÊÕÂ √Ê·«")
                End If
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try

            If DataGridView1.SelectedRows.Count <= 0 Then
                cls.MsgExclamation("«Œ — «·Ê—œÌÂ «·„—«œ «€·«ﬁÂ«")
            Else
                '--------------------------------------------------


                cmd.CommandText = "select employee_id from shift_Details where shift_detail_id=" & DataGridView1.SelectedRows(0).Cells("shift_detail_id").Value
                If EmpIDVar <> cmd.ExecuteScalar Then
                    cls.MsgExclamation("⁄›Ê« Â–Â «·Ê—œÌ… ·«  Œ’ﬂ Ê ·« Ì„ﬂ‰ﬂ «€·«ﬁ Ê—œÌ«  «·„ÊŸ›Ì‰ «·√Œ—Ì‰")
                    Exit Sub
                End If

                Dim ProID As Integer
                cmd.CommandText = "select dbo.Get_Employee_Account_ID(" & DataGridView1.SelectedRows(0).Cells("Employee_ID").Value & ")"
                ProID = cmd.ExecuteScalar
                cmd.CommandText = "select dbo.Get_Any_Balance_By_Shift(" & cmd.ExecuteScalar & ",(Select Start_Date from Shift_Details where shift_Detail_id=" & CurrentShiftID & "),getdate()," & DataGridView1.SelectedRows(0).Cells("shift_detail_id").Value & ")"

                cmd.CommandText = "Exec Commit_Procedure_Tran 4," & ProID & "," & cmd.ExecuteScalar & ",N' —’Ìœ «€·«ﬁ Ê—œÌ… - " & EmpNameVar & "'," & CurrentShiftId & ",0,N'ﬁÌÊœ ÌÊ„Ì…'"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "update shift_details set end_date = getdate() ,  end_time = ' " & Now.ToLongTimeString & "' where shift_detail_id = " & CurrentShiftId
                cmd.ExecuteNonQuery()

                t.Rows.Clear()
                cmd.CommandText = "select * from query_shifts where end_date is null"
                da.SelectCommand = cmd
                da.Fill(t)
                cls.MsgInfo(" „ «€·«ﬁ «·Ê—œÌÂ »‰Ã«Õ")
                CurrentShiftID = 0
                Exit Sub
            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

 



End Class
