Public Class PaySalary

    Dim d1, d2 As Date
    Dim D As String
    Dim b As Boolean = False

    Private Sub PaySalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            cls.RefreshData("Employees")

            b = True

        Catch ex As Exception
            cls.WriteError(ex.Message, "Pay salary")
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Try
            D = PayMonth.Text

            cmd.CommandText = "select count(*) from pay_salary where salary_month='" & D & "'"
            If cmd.ExecuteScalar > 0 Then
                cls.MsgExclamation("لقد تم دفع مرتبات هذا الشهر من قبل")
                Exit Sub
            End If
            MyDs.Tables("Pay_Salary").Rows.Clear()
            If b = True Then
                Dim DayValue As Double = 0
                Dim AbsentVal As Double = 0


                d1 = "01/" & PayMonth.Text
                d2 = Date.DaysInMonth(CInt(PayMonth.Value.Year), CInt(PayMonth.Value.Month)) & "/" & PayMonth.Text



                For i As Integer = 0 To MyDs.Tables("employees").Rows.Count - 1
                    r = MyDs.Tables("Pay_Salary").NewRow

                    cmd.CommandText = "select employee_Name from employees where employee_id=" & MyDs.Tables("employees").Rows(i).Item("Employee_ID")
                    r("Employee_Name") = cmd.ExecuteScalar
                    cmd.CommandText = "select dbo.calc_emp_pay_salary_rewards(" & MyDs.Tables("employees").Rows(i).Item("employee_id") & ",'" & d1.ToString("MM/dd/yyyy") & "' , '" & d2.ToString("MM/dd/yyyy") & "')"
                    r("Emp_Rewards") = cmd.ExecuteScalar
                    cmd.CommandText = "select dbo.calc_emp_pay_salary_Extra_Added_Hours(" & MyDs.Tables("employees").Rows(i).Item("employee_id") & ",'" & d1.ToString("MM/dd/yyyy") & "' , '" & d2.ToString("MM/dd/yyyy") & "')"
                    r("Added_Hours") = cmd.ExecuteScalar
                    cmd.CommandText = "select dbo.calc_emp_pay_salary_discounts(" & MyDs.Tables("employees").Rows(i).Item("employee_id") & ",'" & d1.ToString("MM/dd/yyyy") & "' , '" & d2.ToString("MM/dd/yyyy") & "')"
                    r("Emp_Discounts") = cmd.ExecuteScalar
                    cmd.CommandText = "select dbo.calc_emp_pay_salary_absense(" & MyDs.Tables("employees").Rows(i).Item("employee_id") & ",'" & d1.ToString("MM/dd/yyyy") & "' , '" & d2.ToString("MM/dd/yyyy") & "') "
                    r("Absense") = cmd.ExecuteScalar
                    cmd.CommandText = "select dbo.calc_emp_pay_salary_delay(" & MyDs.Tables("employees").Rows(i).Item("employee_id") & ",'" & d1.ToString("MM/dd/yyyy") & "' , '" & d2.ToString("MM/dd/yyyy") & "')"
                    r("Delay") = cmd.ExecuteScalar
                    cmd.CommandText = "select dbo.calc_emp_pay_salary_tax(" & MyDs.Tables("employees").Rows(i).Item("employee_id") & ")"
                    r("Taxes") = cmd.ExecuteScalar
                    cmd.CommandText = "select dbo.calc_emp_pay_salary_company_insurance(" & MyDs.Tables("employees").Rows(i).Item("employee_id") & "," & r("Emp_Rewards") & " , " & r("Added_Hours") & ")"
                    r("Insurance_Company") = cmd.ExecuteScalar
                    cmd.CommandText = "select dbo.calc_emp_pay_salary_employees_insurance(" & MyDs.Tables("employees").Rows(i).Item("employee_id") & "," & r("Emp_Rewards") & " , " & r("Added_Hours") & ")"
                    r("Insurance_Employee") = cmd.ExecuteScalar
                    r("Employee_ID") = MyDs.Tables("employees").Rows(i).Item("Employee_ID")
                    r("Net_Salary") = r("Emp_Rewards") + r("Added_Hours") - (r("Emp_Discounts") + r("Absense") + r("Delay") + r("Taxes") + r("Insurance_Company") + r("Insurance_Employee"))
                    r("Salary") = MyDs.Tables("employees").Rows(i).Item("Salary")
                    r("Salary_Month") = D
                    r("Pay_Date") = Today
                    MyDs.Tables("Pay_Salary").Rows.Add(r)

                Next


                DataGridView1.DataSource = MyDs.Tables("Pay_Salary")
                DataGridView1.Columns(0).Visible = False
                DataGridView1.Columns(1).HeaderText = "اسم الموظف"
                DataGridView1.Columns(1).ReadOnly = True
                DataGridView1.Columns(2).HeaderText = "تاريخ المرتب "
                DataGridView1.Columns(2).ReadOnly = True
                DataGridView1.Columns(3).HeaderText = "المرتب الاساسي"
                DataGridView1.Columns(3).ReadOnly = True
                DataGridView1.Columns(4).HeaderText = "المكافآت"
                DataGridView1.Columns(4).ReadOnly = True
                DataGridView1.Columns(5).HeaderText = "الساعات الإضافيه"
                DataGridView1.Columns(5).ReadOnly = True
                DataGridView1.Columns(6).HeaderText = "الخصومات"
                DataGridView1.Columns(6).ReadOnly = True
                DataGridView1.Columns(7).HeaderText = "الغياب"
                DataGridView1.Columns(7).ReadOnly = True
                DataGridView1.Columns(8).HeaderText = "التأخير"
                DataGridView1.Columns(8).ReadOnly = True
                DataGridView1.Columns(9).HeaderText = "الضرائب"
                DataGridView1.Columns(9).ReadOnly = True
                DataGridView1.Columns(10).HeaderText = "تأمينات الشركة"
                DataGridView1.Columns(10).ReadOnly = True
                DataGridView1.Columns(11).HeaderText = "تأمينات الموظف"
                DataGridView1.Columns(11).ReadOnly = True
                DataGridView1.Columns(12).HeaderText = "صافي المرتب"
                DataGridView1.Columns(12).ReadOnly = True
                DataGridView1.Columns(13).HeaderText = "ملاحظات"
                DataGridView1.Columns(14).Visible = False
                DataGridView1.Columns(15).Visible = False

            Else
                cls.MsgExclamation("أدخل اسم الموظف", "please enter employee name")
            End If



        Catch ex As Exception
            cls.WriteError(ex.Message, "Pay Salary")
        End Try
    End Sub

  
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If CurrentShiftID = 0 Then
                cls.MsgExclamation("برجاء قم بفتح وردية")
                Exit Sub
            End If
            For i As Integer = 0 To DataGridView1.Rows.Count - 1

                cmd.CommandText = "insert into pay_Salary (Employee_ID,Pay_Date,Salary,Emp_Rewards,Added_Hours,Emp_Discounts,Absense,Delay,Taxes,Insurance_Company,Insurance_Employee,Net_Salary,Notes,Salary_Month) Values(" & DataGridView1.Rows(i).Cells("Employee_ID").Value & ",Getdate()," & DataGridView1.Rows(i).Cells("Salary").Value & "," & DataGridView1.Rows(i).Cells("Emp_Rewards").Value & "," & DataGridView1.Rows(i).Cells("Added_Hours").Value & "," & DataGridView1.Rows(i).Cells("Emp_Discounts").Value & "," & DataGridView1.Rows(i).Cells("Absense").Value & "," & DataGridView1.Rows(i).Cells("Delay").Value & "," & DataGridView1.Rows(i).Cells("Taxes").Value & "," & DataGridView1.Rows(i).Cells("Insurance_Company").Value & "," & DataGridView1.Rows(i).Cells("Insurance_Employee").Value & "," & DataGridView1.Rows(i).Cells("Net_Salary").Value & ",N'" & DataGridView1.Rows(i).Cells("Notes").Value & "','" & D & "')"
                cmd.ExecuteNonQuery()
            Next

            cmd.CommandText = "Exec dbo.Commit_Salary " & CurrentShiftId & "," & EmpIDVar & ",'" & D & "'"
            cmd.ExecuteNonQuery()

            cls.MsgInfo("تم حفظ البيانات بنجاح", "data has been saved successfully")
            MyDs.Tables("Pay_Salary").Rows.Clear()

        Catch ex As Exception
            cls.WriteError(ex.Message, "Pay Salary")
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

End Class