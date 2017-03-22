Public Class FrmInvLog

    Dim Rpt As New ReportInvLog

    Private Sub RadioStockName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioStockName.CheckedChanged
        If RadioStockName.Checked = True Then
            StockName.Enabled = True
            ItemName.Enabled = False
            Panel1.Enabled = False
            DocType.Enabled = False
        End If
    End Sub

    Private Sub RadioItemName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioItemName.CheckedChanged
        If RadioItemName.Checked = True Then
            StockName.Enabled = False
            ItemName.Enabled = True
            Panel1.Enabled = False
            DocType.Enabled = False
        End If
    End Sub

    Private Sub RadioDocType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioDocType.CheckedChanged
        If RadioDocType.Checked = True Then
            StockName.Enabled = False
            ItemName.Enabled = False
            Panel1.Enabled = False
            DocType.Enabled = True
        End If
    End Sub

    Private Sub RadioDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioDate.CheckedChanged
        If RadioDate.Checked = True Then
            StockName.Enabled = False
            ItemName.Enabled = False
            Panel1.Enabled = True
            DocType.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            MyDs.Tables("Report_Inventory_Log").Rows.Clear()

            If RadioStockName.Checked = True Then
                If StockName.Text = "" Then
                    cls.MsgExclamation("اختر اسم المحل", "please select warehouse")
                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Inventory_Log where stock_name = N'" & StockName.Text & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("Report_Inventory_Log"))
                End If

            ElseIf RadioItemName.Checked = True Then
                If ItemName.Text = "" Then
                    cls.MsgExclamation("اختر اسم الصنف", "please select item name")
                Else
                    cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Inventory_Log where Item_name = N'" & ItemName.Text & "'"
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("Report_Inventory_Log"))
                End If

            ElseIf RadioDocType.Checked = True Then
                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Inventory_Log where Doc_Type = N'" & DocType.Text & "'"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("Report_Inventory_Log"))
            ElseIf RadioDate.Checked = True Then
                Dim date1 As Date = CDate(DateTimePicker1.Text)
                Dim date2 As Date = CDate(DateTimePicker2.Text)
                cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo from Report_Inventory_Log where doc_Date between '" & date1.ToString("MM/dd/yyyy") & "'  and   '" & date2.ToString("MM/dd/yyyy") & "'"
                da.SelectCommand = cmd
                da.Fill(MyDs.Tables("Report_Inventory_Log"))
            End If

            Rpt.SetDataSource(MyDs.Tables("Report_Inventory_Log"))
            Rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
            CrystalReportViewer1.ReportSource = Rpt
            TabControl1.SelectTab(1)
        Catch ex As Exception
            cls.WriteError(ex.Message, "Inv Log")
        End Try
    End Sub

    Private Sub FrmInvLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmd.CommandText = "select Stock_Name from stocks"
            dr = cmd.ExecuteReader
            Do While Not dr.Read = False
                StockName.Items.Add(dr("Stock_Name"))
            Loop
            dr.Close()

            cmd.CommandText = "select Item_Name from Items"
            dr = cmd.ExecuteReader
            Do While Not dr.Read = False
                ItemName.Items.Add(dr("Item_Name"))
            Loop
            dr.Close()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Inv Log")
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

    Private Sub DocType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DocType.GotFocus
        DocType.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub DocType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DocType.Leave

        DocType.BackColor = Color.Gainsboro
    End Sub

    Private Sub StockName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles StockName.GotFocus
        StockName.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub StockName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles StockName.Leave
        StockName.BackColor = Color.Gainsboro
    End Sub

    Private Sub ItemName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemName.GotFocus
        ItemName.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub ItemName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemName.Leave
        ItemName.BackColor = Color.Gainsboro
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