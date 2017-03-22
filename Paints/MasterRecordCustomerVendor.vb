Public Class MasterRecordCustomerVendor

    Dim date1, date2 As Date
    Dim TblCust, TblVen As New GeneralDataSet.Procedure_MasterDataTable
    Private rpt As New RptMasterRecord
    Private PType As String

    Private Sub MasterRecordCustomerVendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cls.RefreshData("Vendors", " Vendor_Name ")
        cls.RefreshData("Customers", " Customer_Name ")
        cmd.CommandText = "select * from procedure_master where Procedure_Category = N'موردين'"
        da.Fill(TblVen)
        cmd.CommandText = "select * from procedure_master where Procedure_Category = N'عملاء'"
        da.Fill(TblCust)

        ComboCustomerID.DataSource = TblCust
        ComboCustomerID.DisplayMember = "Daily_Procedure_Name"
        ComboCustomerID.ValueMember = "Procedure_Master_ID"

        ComboVendorID.DataSource = TblVen
        ComboVendorID.DisplayMember = "Daily_Procedure_Name"
        ComboVendorID.ValueMember = "Procedure_Master_ID"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            MyDs.Tables("MasterRecord").Rows.Clear()
            date1 = CDate(DateTimePicker1.Text)
            date2 = CDate(DateTimePicker2.Text)

            If RadioCustomer.Checked = True Then
                '-------------------------------------------------------------
                MyDs.Tables("MasterRecord").Columns("Daily_Procedure_Name").DefaultValue = ComboCustomerID.Text
                cmd.CommandText = "select procedure_type from procedure_master where procedure_master_id = " & ComboCustomerID.SelectedValue
                PType = cmd.ExecuteScalar
                If PType = "مدين" Then
                    cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as from_balance from procedure_Master where Procedure_Master_ID=" & ComboCustomerID.SelectedValue
                Else
                    cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as to_balance from procedure_Master where Procedure_Master_ID=" & ComboCustomerID.SelectedValue
                End If

                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))

                cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as To_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.From_Procedure_Master_ID=" & ComboCustomerID.SelectedValue & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))
                cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as From_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.To_Procedure_Master_ID=" & ComboCustomerID.SelectedValue & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))

                cmd.CommandText = "select dbo.Get_Any_Balance(" & ComboCustomerID.SelectedValue & ",'" & date1.ToString("MM/dd/yyyy") & "','" & date2.ToString("MM/dd/yyyy") & "') as procedure_balance"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))
                '------------------------------------------------------------
            ElseIf RadioVendor.Checked = True Then
                MyDs.Tables("MasterRecord").Columns("Daily_Procedure_Name").DefaultValue = ComboVendorID.Text
                cmd.CommandText = "select procedure_type from procedure_master where procedure_master_id = " & ComboVendorID.SelectedValue
                PType = cmd.ExecuteScalar
                If PType = "مدين" Then
                    cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as from_balance from procedure_Master where Procedure_Master_ID=" & ComboVendorID.SelectedValue
                Else
                    cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as to_balance from procedure_Master where Procedure_Master_ID=" & ComboVendorID.SelectedValue
                End If

                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))

                cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as To_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.To_Procedure_Master_ID=" & ComboVendorID.SelectedValue & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))
                cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as From_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.From_Procedure_Master_ID=" & ComboVendorID.SelectedValue & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))

                cmd.CommandText = "select dbo.Get_Any_Balance(" & ComboVendorID.SelectedValue & ",'" & date1.ToString("MM/dd/yyyy") & "','" & date2.ToString("MM/dd/yyyy") & "') as procedure_balance"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("MasterRecord"))
                '------------------------------------------------------------
            ElseIf RadioAllCustomer.Checked = True Then

                For i As Integer = 0 To TblCust.Rows.Count - 1
                    MyDs.Tables("MasterRecord").Columns("Daily_Procedure_Name").DefaultValue = TblCust.Rows(i).Item("Daily_Procedure_Name")
                    If TblCust.Rows(i).Item("Procedure_Type") = "مدين" Then
                        cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as from_balance from procedure_Master where Procedure_Master_ID=" & TblCust.Rows(i).Item("Procedure_Master_ID")
                    Else
                        cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as to_balance from procedure_Master where Procedure_Master_ID=" & TblCust.Rows(i).Item("Procedure_Master_ID")
                    End If
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                    cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as To_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.From_Procedure_Master_ID=" & TblCust.Rows(i).Item("Procedure_Master_ID") & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))
                    cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as From_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.To_Procedure_Master_ID=" & TblCust.Rows(i).Item("Procedure_Master_ID") & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                    cmd.CommandText = "select dbo.Get_Any_Balance(" & TblCust.Rows(i).Item("Procedure_Master_ID") & ",'" & date1.ToString("MM/dd/yyyy") & "','" & date2.ToString("MM/dd/yyyy") & "') as procedure_balance "
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                Next
                '-------------------------------------------------------------
            ElseIf RadioAllVendor.Checked = True Then

                For i As Integer = 0 To TblVen.Rows.Count - 1
                    MyDs.Tables("MasterRecord").Columns("Daily_Procedure_Name").DefaultValue = TblVen.Rows(i).Item("Daily_Procedure_Name")
                    If TblVen.Rows(i).Item("Procedure_Type") = "مدين" Then
                        cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as from_balance from procedure_Master where Procedure_Master_ID=" & TblVen.Rows(i).Item("Procedure_Master_ID")
                    Else
                        cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as to_balance from procedure_Master where Procedure_Master_ID=" & TblVen.Rows(i).Item("Procedure_Master_ID")
                    End If
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                    cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as To_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.To_Procedure_Master_ID=" & TblVen.Rows(i).Item("Procedure_Master_ID") & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))
                    cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as From_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.From_Procedure_Master_ID=" & TblVen.Rows(i).Item("Procedure_Master_ID") & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                    cmd.CommandText = "select dbo.Get_Any_Balance(" & TblVen.Rows(i).Item("Procedure_Master_ID") & ",'" & date1.ToString("MM/dd/yyyy") & "','" & date2.ToString("MM/dd/yyyy") & "') as procedure_balance "
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                Next
                '------------------------------------------------------------
            ElseIf RadioCustomerVendor.Checked = True Then
                '------------------------------------------------------------
                For i As Integer = 0 To TblCust.Rows.Count - 1
                    MyDs.Tables("MasterRecord").Columns("Daily_Procedure_Name").DefaultValue = TblCust.Rows(i).Item("Daily_Procedure_Name")
                    If TblCust.Rows(i).Item("Procedure_Type") = "مدين" Then
                        cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as from_balance from procedure_Master where Procedure_Master_ID=" & TblCust.Rows(i).Item("Procedure_Master_ID")
                    Else
                        cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as to_balance from procedure_Master where Procedure_Master_ID=" & TblCust.Rows(i).Item("Procedure_Master_ID")
                    End If
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                    cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as To_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.To_Procedure_Master_ID=" & TblCust.Rows(i).Item("Procedure_Master_ID") & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))
                    cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as From_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.From_Procedure_Master_ID=" & TblCust.Rows(i).Item("Procedure_Master_ID") & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                    cmd.CommandText = "select dbo.Get_Any_Balance(" & TblCust.Rows(i).Item("Procedure_Master_ID") & ",'" & date1.ToString("MM/dd/yyyy") & "','" & date2.ToString("MM/dd/yyyy") & "') as procedure_balance "
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                Next
                '-------------------------------------------------------------
                For i As Integer = 0 To TblVen.Rows.Count - 1
                    MyDs.Tables("MasterRecord").Columns("Daily_Procedure_Name").DefaultValue = TblVen.Rows(i).Item("Daily_Procedure_Name")
                    If TblVen.Rows(i).Item("Procedure_Type") = "مدين" Then
                        cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as from_balance from procedure_Master where Procedure_Master_ID=" & TblVen.Rows(i).Item("Procedure_Master_ID")
                    Else
                        cmd.CommandText = "select N'رصيد أول المده' as Procedure_Desc , Balance as to_balance from procedure_Master where Procedure_Master_ID=" & TblVen.Rows(i).Item("Procedure_Master_ID")
                    End If
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                    cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as To_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.To_Procedure_Master_ID=" & TblVen.Rows(i).Item("Procedure_Master_ID") & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))
                    cmd.CommandText = "SELECT D.Procedure_Desc,D.Procedure_Date,D.Procedure_Value as From_Balance FROM Procedure_Master H,Procedure_Details D,Procedure_Master H2 WHERE H.Procedure_Master_ID = D.From_Procedure_Master_ID AND H2.Procedure_Master_ID = D.TO_Procedure_Master_ID AND D.From_Procedure_Master_ID=" & TblVen.Rows(i).Item("Procedure_Master_ID") & " and Procedure_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                    cmd.CommandText = "select dbo.Get_Any_Balance(" & TblVen.Rows(i).Item("Procedure_Master_ID") & ",'" & date1.ToString("MM/dd/yyyy") & "','" & date2.ToString("MM/dd/yyyy") & "') as procedure_balance "
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("MasterRecord"))

                Next
            End If

            rpt.SetDataSource(MyDs.Tables("MasterRecord"))
            CrystalReportViewer1.ReportSource = rpt
            TabControl1.SelectTab(1)
        Catch ex As Exception
            cls.WriteError(ex.Message, "MasterRecord")
        End Try
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

    Private Sub ComboCustomerID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboCustomerID.GotFocus
        ComboCustomerID.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub ComboCustomerID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboCustomerID.Leave
        ComboCustomerID.BackColor = Color.Gainsboro
    End Sub

  
    Private Sub ComboVendorID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboVendorID.GotFocus
        ComboVendorID.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub ComboVendorID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboVendorID.Leave
        ComboVendorID.BackColor = Color.Gainsboro
    End Sub


End Class