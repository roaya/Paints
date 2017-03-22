Public Class DailyProcedures

    Dim Gcls As GeneralSp.MasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceDailyProcedures As New BindingSource
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Procedure_Master"
    '-------------------------------
    Public SearchProID As Integer

    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Dim g As Integer = InputBox("")
            'cls.FillSelectedTable("select * from procedure_master where procedure_master_id < " & g, "procedure_master")
            cls.RefreshData("Procedure_Master")
            
            Dim B As New BindingSource
            B.DataSource = MyDs
            B.DataMember = "Table_Columns"
            B.Filter = "Table_ID ='" & TName & "'"
            OrderByCombo.ComboBox.DataSource = B
            OrderByCombo.ComboBox.DisplayMember = "Logical_Name"
            OrderByCombo.ComboBox.ValueMember = "Physical_Name"

            '-------------------------------
            'Must Specify Data Table Name
            '-------------------------------

            Gcls = New GeneralSp.MasterForms(TName, BSourceDailyProcedures, MenuNew, MenuSave, MenuDelete, MenuSearch, MenuExit, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, NavigationBar, ContentPanel, NavigationMenu, , CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "√”„«¡ «·Õ”«»« "
            Me.Text = Gcls.SetWTitle


            SSource = BSourceDailyProcedures

            Col_Procedure_Master_ID.DataPropertyName = "Procedure_Master_ID"
            Col_Daily_Procedure_Name.DataPropertyName = "Daily_Procedure_Name"
            Col_Reference_ID.DataPropertyName = "Reference_ID"
            Col_Generic_Desc.DataPropertyName = "Generic_Desc"
            Col_Balance.DataPropertyName = "Balance"
            Col_Procedure_Category.DataPropertyName = "Procedure_Category"
            Col_Procedure_Type.DataPropertyName = "Procedure_Type"

            DataGridView1.DataSource = BSourceDailyProcedures
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).HeaderText = "«”„ «·Õ”«»"
            DataGridView1.Columns(2).HeaderText = "ﬂÊœ «·Õ”«»"
            DataGridView1.Columns(3).HeaderText = "«·Ê’›"
            DataGridView1.Columns(4).HeaderText = "«·—’Ìœ «·«›  «ÕÌ"

            ''''For x As Integer = 0 To 22
            ''''    DataGridView1.Rows(x).Cells("Col_Procedure_Category").ReadOnly = True
            ''''    DataGridView1.Rows(x).Cells("Col_Procedure_Type").ReadOnly = True
            ''''Next
            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Gender_Name"

            B_EndLoad = True

            If SearchProID <> 0 Then
                BSourceDailyProcedures.Filter = "Procedure_Master_ID = " & SearchProID
            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, MenuNew.Click
        Try
            Gcls.NewRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try
            BSourceDailyProcedures.Filter = ""

            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(1).Value Is DBNull.Value Then
                    cls.MsgExclamation("»—Ã«¡ «œŒ· «”„ «·Õ”«»")
                    Exit Sub
                End If
                If DataGridView1.Rows(i).Cells(4).Value Is DBNull.Value Then
                    cls.MsgExclamation("»—Ã«¡ «œŒ· «·—’Ìœ «·«›  «ÕÌ")
                    Exit Sub
                End If
            Next
            

            Gcls.SaveRecord()
            BtnSave.Enabled = True
            MenuSave.Enabled = True
            MenuExit.Enabled = True
            BtnExit.Enabled = True
            cls.FillSelectedTable("select * from Procedure_Master", "Procedure_Master")
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click, MenuDelete.Click
        Try
            cmd.CommandText = "select dbo.Check_Procedure_Master(" & DataGridView1.SelectedRows(0).Cells(0).Value & ")"
            If cmd.ExecuteScalar > 0 Then
                cls.MsgExclamation("⁄›Ê« Â–« «·”Ã· „— »ÿ »”Ã·«  √Œ—Ï Ê ·« Ì„ﬂ‰ Õ–›Â")
                Exit Sub
            End If

            If DataGridView1.SelectedRows(0).Cells(0).Value <= 29 Then
                cls.MsgExclamation("·« Ì„ﬂ‰ Õ–› «·»Ì«‰«  «·«› —«÷ÌÂ")
            Else
                Gcls.DeleteRecord()
            End If
        Catch
            cls.MsgExclamation("»—Ã«¡ «Œ Ì«— ”Ã· ·Ì „ Õ–›Â")
        End Try
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLast.Click, BtnLast.Click
        Try
            Gcls.LastRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNext.Click, BtnNext.Click
        Try
            Gcls.NextRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnPervious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPrevious.Click, BtnPervious.Click
        Try
            Gcls.PreviousRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFirst.Click, BtnFirst.Click
        Try
            Gcls.FirstRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click, MenuSearch.Click
        Try
            Gcls.EditRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub



    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Try
            Gcls.CutData(ContentPanel)
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            Gcls.CopyData(ContentPanel)
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            Gcls.PasteData(ContentPanel)
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub OrderByCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderByCombo.SelectedIndexChanged
        Try
            If B_EndLoad = True Then
                Gcls.SortData(BSourceDailyProcedures, OrderByCombo.ComboBox.SelectedValue)
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click, MenuExit.Click
        Try
            Gcls.ExitForm()
            Me.Close()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    Private Sub MenuReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReload.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            cls.FillSelectedTable("select * from " & TName, TName)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    Private Sub MenuCancelSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCancelSearch.Click
        Try
            BSourceDailyProcedures.RemoveFilter()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    'Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
    '    cls.MsgExclamation("«œŒ· «·»Ì«‰«  »ÿ—ÌﬁÂ ’ÕÌÕÂ", "")
    'End Sub

    'Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
    '    cls.MsgExclamation("√œŒ· «·»Ì«‰«  »ÿ—ÌﬁÂ ’ÕÌÕÂ")
    'End Sub

    Private Sub PName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PName.CheckedChanged
        If PName.Checked = True Then
            SearchB.Items.Clear()
            SearchB.DropDownStyle = ComboBoxStyle.Simple
        End If
    End Sub

    Private Sub Category_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Category.CheckedChanged
        If Category.Checked = True Then
            SearchB.Items.Clear()
            SearchB.DropDownStyle = ComboBoxStyle.DropDownList
            SearchB.Items.Add("«Ì—«œ«  „ ‰Ê⁄Â")
            SearchB.Items.Add("⁄„·«¡")
            SearchB.Items.Add("„Ê—œÌ‰")
            SearchB.Items.Add("»‰Êﬂ")
            SearchB.Items.Add("Ã«—Ì «·‘—Ìﬂ")
            SearchB.Items.Add("›Ì“«")
            SearchB.Items.Add("√’Ê· À«» Â")
            SearchB.Items.Add("√’Ê· „ œ«Ê·Â")
            SearchB.Items.Add("√—’œÂ „œÌ‰Â")
            SearchB.Items.Add("√—’œÂ œ«∆‰Â")
            SearchB.Items.Add("ÕﬁÊﬁ „·ﬂÌÂ")
            SearchB.Items.Add("Œ’Ê„ „ œ«Ê·Â")
            SearchB.Items.Add("„Ã„⁄ «Â·«ﬂ« ")
            SearchB.Items.Add("„’«—Ì›  ”ÊÌﬁÌÂ")
            SearchB.Items.Add("„’«—Ì› «œ«—ÌÂ")
            SearchB.Items.Add("ﬁ«∆„… «·œŒ·")
        End If
    End Sub

    Private Sub Type_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Type.CheckedChanged
        If Type.Checked = True Then
            SearchB.Items.Clear()
            SearchB.DropDownStyle = ComboBoxStyle.DropDownList
            SearchB.Items.Add("„œÌ‰")
            SearchB.Items.Add("œ«∆‰")
        End If
    End Sub

    Private Sub SearchB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchB.TextChanged
    
    End Sub

    Private Sub SearchB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchB.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Type.Checked = True Then
                BSourceDailyProcedures.Filter = "procedure_type like '%" & SearchB.Text & "%'"
            ElseIf Category.Checked = True Then
                BSourceDailyProcedures.Filter = "procedure_category like '%" & SearchB.Text & "%'"
            Else
                BSourceDailyProcedures.Filter = "daily_procedure_name like '%" & SearchB.Text & "%'"
            End If

        End If
    End Sub
End Class
