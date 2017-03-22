Public Class ReportSalComm

    Dim date1, date2 As Date
    Dim rpt As New Report_Sales_Commission
    Dim b As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            MyDs.Tables("Report_Sales_Commission").Rows.Clear()
            date1 = CDate(DateTimePicker1.Text)
            date2 = CDate(DateTimePicker2.Text)
            If RadioEmployeeID.Checked = True Then
                If ComboEmployeeID.Text = "" Then
                    cls.MsgExclamation("اختر اسم الموظف", "please enter employee name")
                    Exit Sub
                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Sales_Commission where employee_id = " & ComboEmployeeID.SelectedValue & " and bill_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "' order by bill_Date"
                End If
            ElseIf RadioBillID.Checked = True Then
                If ComboBillID.Text = "" Then
                    cls.MsgExclamation("اختر اسم الحساب", "please enter bill number")
                    Exit Sub
                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Sales_Commission where bill_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "' and bill_id = " & ComboBillID.Text & " order by bill_Date"
                End If
            ElseIf RadioBillStatus.Checked = True Then
                If ComboBillStatus.Text = "" Then
                    cls.MsgExclamation("اختر حالة الفاتوره", "please enter bill status")
                    Exit Sub
                ElseIf ComboBillStatus.Text = "مفتوحه" Then
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Sales_Commission where bill_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "' and bill_status = 1 order by bill_Date"
                ElseIf ComboBillStatus.Text = "مغلقه" Then
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Report_Sales_Commission where bill_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "' and bill_status = 0 order by bill_Date"
                End If
            End If

            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Report_Sales_Commission"))

            rpt.SetDataSource(MyDs.Tables("Report_Sales_Commission"))
            rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            CrystalReportViewer1.ReportSource = Rpt
            TabControl1.SelectTab(1)
        Catch ex As Exception
            cls.WriteError(ex.Message, "Report_Sales_Commission")
        End Try
    End Sub

    Private Sub ReportSalComm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        b = False
    End Sub

    Private Sub ReportSalComm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmd.CommandText = "select bill_id from sales_header"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                ComboBillID.Items.Add(dr("Bill_ID"))
            Loop
            dr.Close()

            cls.RefreshData("Employees")
            ComboEmployeeID.DataSource = MyDs
            ComboEmployeeID.ValueMember = "Employees.Employee_ID"
            ComboEmployeeID.DisplayMember = "Employees.Employee_Name"
            b = True
        Catch ex As Exception
            cls.WriteError(ex.Message, "Report_Sales_Commission")
        End Try
    End Sub

    Private Sub RadioEmployeeID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioEmployeeID.CheckedChanged
        If RadioEmployeeID.Checked = True Then
            ComboEmployeeID.Enabled = True
            ComboBillID.Enabled = False
            ComboBillStatus.Enabled = False
        End If
    End Sub

    Private Sub RadioBillID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBillID.CheckedChanged
        If RadioBillID.Checked = True Then
            ComboBillID.Enabled = True
            RadioEmployeeID.Enabled = False
            ComboBillStatus.Enabled = False
        End If
    End Sub

    Private Sub RadioBillStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBillStatus.CheckedChanged
        If RadioBillStatus.Checked = True Then
            ComboBillID.Enabled = False
            RadioEmployeeID.Enabled = False
            ComboBillStatus.Enabled = True
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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class