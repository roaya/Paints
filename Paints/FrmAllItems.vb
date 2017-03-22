Public Class FrmAllItems

    Dim rpt As New RptAllItems

    Private Sub Radstockname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radallitems.CheckedChanged
        If Radallitems.Checked = True Then
            Combitem.Enabled = False
            Txtbarcode.Enabled = False
            Combcat.Enabled = False
            Combcorpration.Enabled = False
        End If
    End Sub

    Private Sub Raditemname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Raditemname.CheckedChanged
        If Raditemname.Checked = True Then
            Combitem.Enabled = True
            Txtbarcode.Enabled = False
            Combcat.Enabled = False
            Combcorpration.Enabled = False
        End If
    End Sub

    Private Sub Radbarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radbarcode.CheckedChanged
        If Radbarcode.Checked = True Then
            Txtbarcode.Enabled = True
            Combitem.Enabled = False
            Combcat.Enabled = False
            Combcorpration.Enabled = False
        End If
    End Sub

    Private Sub FrmAllItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        da.SelectCommand = cmd
        cmd.CommandText = " select item_name from items "
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Combitem.Items.Add(dr("item_name"))
        Loop
        dr.Close()
        cmd.CommandText = "select corporation_name from corporations"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Combcorpration.Items.Add(dr("corporation_name"))
        Loop
        dr.Close()
        cmd.CommandText = "select category_name from categories"
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            Combcat.Items.Add(dr("category_name"))
        Loop
        dr.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MyDs.Tables("Query_All_Items").Rows.Clear()

        If Radallitems.Checked = True Then
            cmd.CommandText = "select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Query_All_Items "
            da.Fill(MyDs.Tables("Query_All_Items"))
        ElseIf Raditemname.Checked = True Then
            If Combitem.Text = "" Then
                cls.MsgInfo(" من فضلك اختر اسم الصنف ", "")
                Exit Sub
            Else
                cmd.CommandText = " select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Query_All_Items where item_name  = N'" & Combitem.Text & "'"
                da.Fill(MyDs.Tables("Query_All_Items"))
            End If
        ElseIf Radbarcode.Checked = True Then
            If Txtbarcode.Enabled = "" Then
                cls.MsgInfo("من فضلك ادخل الباركود ", "")
                Exit Sub
            Else
                cmd.CommandText = " select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Query_All_Items where barcode  = N'" & Txtbarcode.Text & "'"
                da.Fill(MyDs.Tables("Query_All_Items"))
            End If
        ElseIf Combcorpration.Enabled = True Then
            If Combcorpration.Text = "" Then
                MsgBox("من فضلك ادخل اسم الشركه")
            Else
                cmd.CommandText = " select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Query_All_Items where CORPORATION_NAME  = N'" & Combcorpration.Text & "'"
                da.Fill(MyDs.Tables("Query_All_Items"))

            End If
        ElseIf Radcat.Enabled = True Then
            If Combcat.Text = "" Then
                MsgBox("من فضلك اختر اسم البند")
            Else
                cmd.CommandText = " select *,(select logo from stocks where stock_id=" & ProjectSettings.CurrentStockID & ") as logo  from Query_All_Items where category_name  = N'" & Combcat.Text & "'"
                da.Fill(MyDs.Tables("Query_All_Items"))

            End If

        End If

        'If RadioOne.Checked = True Then
        '    rpt.ReportDefinition.ReportObjects.Item("").ObjectFormat.EnableSuppress = True
        'End If
        rpt.SetDataSource(MyDs.Tables("Query_All_Items"))
        rpt.SetParameterValue("P_HeaderReport", MyDs.Tables("App_Preferences").Rows(0).Item("P_HeaderReport"))
        CrystalReportViewer1.ReportSource = rpt
        TabControl1.SelectTab(1)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    


    Private Sub Radcat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radcat.CheckedChanged
        If Radcat.Enabled = True Then
            Combcat.Enabled = True
            Combcorpration.Enabled = False
            Combitem.Enabled = False
            Txtbarcode.Enabled = False

        End If
    End Sub

    Private Sub Radcorporation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radcorporation.CheckedChanged
        If Radcorporation.Checked = True Then
            Combcorpration.Enabled = True
            Combcat.Enabled = False
            Combitem.Enabled = False
            Txtbarcode.Enabled = False

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

    Private Sub Combitem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combitem.GotFocus
        Combitem.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub Combitem_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combitem.Leave

        Combitem.BackColor = Color.Gainsboro
    End Sub

    Private Sub Txtbarcode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtbarcode.GotFocus
        Txtbarcode.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub Txtbarcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtbarcode.Leave
        Txtbarcode.BackColor = Color.Gainsboro
    End Sub

    Private Sub Combcat_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combcat.GotFocus
        Combcat.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub Combcat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combcat.Leave
        Combcat.BackColor = Color.Gainsboro

    End Sub

    Private Sub Combcorpration_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combcorpration.GotFocus
        Combcorpration.BackColor = Color.FromArgb(135, 180, 209)
    End Sub

    Private Sub Combcorpration_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combcorpration.Leave
        Combcorpration.BackColor = Color.Gainsboro
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