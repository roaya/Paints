Public Class Attendance

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceAttendance As New BindingSource
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Attendance"
    Dim tbl As New GeneralDataSet.EmployeesDataTable
    '-------------------------------

    Private Sub Code_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Code.KeyDown
        If e.KeyCode = Keys.Enter Then

            cmd.CommandText = "select isnull(employee_ID,0)from employees where barcode='" & Code.Text & "'"
            cmd.CommandText = "Select dbo.Get_Emp_Shift(" & cmd.ExecuteScalar & ",datename(dw,Getdate()))"
            If cmd.ExecuteScalar = 0 Then
                cls.MsgExclamation("⁄›Ê« Â–« «·„ÊŸ› €Ì— „”Ã· ›Ì Â–Â «·Ê—œÌ…")
                Exit Sub
            End If

                cmd.CommandText = "select isnull(employee_ID,0)from employees where barcode='" & Code.Text & "'"
                If cmd.ExecuteScalar = 0 Then
                    cls.MsgExclamation("»—Ã«¡ «· √ﬂœ „‰ «·ﬂÊœ «·„œŒ·")
                    Exit Sub
                Else

                    cmd.CommandText = "select count(*) from Employees_Vacations where employee_id=" & cmd.ExecuteScalar & " and getdate() between from_Date and to_Date"
                    If cmd.ExecuteScalar > 0 Then
                        cls.MsgExclamation("⁄›Ê« Â‰«ﬂ √Ã«“… ·Â–« «·„ÊŸ› ›Ì Â–Â «·› —… Ê ·« Ì„ﬂ‰ﬂ  ”ÃÌ· Õ÷Ê— ›Ì «·√Ã«“« ")
                        Exit Sub
                    End If


                    cmd.CommandText = "select count(*) from Employees_Vacations where getdate() between from_Date and to_Date"
                    If cmd.ExecuteScalar > 0 Then
                        cls.MsgExclamation("⁄›Ê« Â‰«ﬂ √Ã«“… —”„Ì… ›Ì Â–Â «·› —… Ê ·« Ì„ﬂ‰ﬂ  ”ÃÌ· Õ÷Ê— ›Ì «·√Ã«“« ")
                        Exit Sub
                    End If

                    cmd.CommandText = "select isnull(employee_ID,0)from employees where barcode='" & Code.Text & "'"




                    cmd.CommandText = "Exec Commit_Attendance " & cmd.ExecuteScalar
                End If

                cmd.ExecuteNonQuery()
                cmd.CommandText = "select employee_id from employees where barcode='" & Code.Text & "'"
                cmd.CommandText = "select leave_time from attendance where serial_pk=(select max(serial_pk) from attendance where employee_id=" & cmd.ExecuteScalar & ")"
                If cmd.ExecuteScalar Is DBNull.Value Then
                    cls.MsgInfo("·ﬁœ  „  ”ÃÌ· Õ÷Ê— ··„ÊŸ› »‰Ã«Õ")
                    type.Text = "Õ÷Ê—"
                Else
                    cls.MsgInfo("·ﬁœ  „  ”ÃÌ· «‰’—«› ··„ÊŸ› »‰Ã«Õ")
                    type.Text = "«‰’—«›"
                End If
                d.Text = Today.ToString("yyyy/MM/dd")
                t.Text = Now.ToString("HH:mm")
                cmd.CommandText = "select employee_Name from employees where barcode='" & Code.Text & "'"
                emp.Text = cmd.ExecuteScalar


            End If
    End Sub


End Class
