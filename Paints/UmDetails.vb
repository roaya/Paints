Public Class UmDetails

    Dim BSourceUmDetails As New BindingSource
    Dim cmdb As New SqlClient.SqlCommandBuilder

    Private Sub UmDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cls.RefreshData("um_master")
            ComboUmMaster.ComboBox.DataSource = MyDs
            ComboUmMaster.ComboBox.DisplayMember = "um_master.um_name"
            ComboUmMaster.ComboBox.ValueMember = "um_master.um_id"

            BSourceUmDetails.DataSource = MyDs
            BSourceUmDetails.DataMember = "um_details"

            DataGridView1.DataSource = BSourceUmDetails
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).HeaderText = "ÊÕœ… «·ﬁÌ«”"
            DataGridView1.Columns(2).HeaderText = "«·ﬂ„ÌÂ «·„ﬂ«›∆Â"
            DataGridView1.Columns(3).Visible = False

            BSourceUmDetails.Filter = "um_id=0"
        Catch ex As Exception
            cls.WriteError(ex.Message, "Um Details")
        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try
            BSourceUmDetails.Filter = "um_id=" & ComboUmMaster.ComboBox.SelectedValue
            cls.RefreshData("um_details")
            BtnNew.Enabled = True
            BtnSave.Enabled = True
            BtnDelete.Enabled = True
            BtnSearch.Enabled = False

        Catch ex As Exception
            cls.WriteError(ex.Message, "Um Details")
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Try
            MyDs.Tables("Um_Details").Columns("Um_ID").DefaultValue = ComboUmMaster.ComboBox.SelectedValue
            BSourceUmDetails.AddNew()
            BtnNew.Enabled = False
            BtnSearch.Enabled = False
        Catch ex As Exception
            cls.WriteError(ex.Message, "Um Details")
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(1).Value Is DBNull.Value Or DataGridView1.Rows(i).Cells(1).Value Is Nothing Then
                    cls.MsgExclamation("√œŒ· ÊÕœ… «·ﬁÌ«”")
                    Exit Sub
                ElseIf DataGridView1.Rows(i).Cells(2).Value Is DBNull.Value Or DataGridView1.Rows(i).Cells(2).Value Is Nothing Then
                    cls.MsgExclamation("√œŒ· «·ﬂ„ÌÂ «·„ﬂ«›∆Â")
                    Exit Sub
                End If
            Next
            BSourceUmDetails.EndEdit()
            cmd.CommandText = "select * from um_details"
            cmdb.DataAdapter = da
            da.Update(MyDs.Tables("um_details"))
            cls.MsgInfo(" „ Õ›Ÿ «·»Ì«‰«  »‰Ã«Õ")
            BtnNew.Enabled = True
            BtnSearch.Enabled = True
        Catch ex As Exception
            cls.WriteError(ex.Message, "Um Details")
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            If DataGridView1.SelectedRows.Count <= 0 Then
                cls.MsgExclamation("»—Ã«¡ «Œ Ì«— «·”Ã· «·„—«œ Õ–›Â")
            ElseIf DataGridView1.SelectedRows(0).Index = 0 Then
                cls.MsgExclamation("·« Ì„ﬂ‰ Õ–› «·»Ì«‰«  «·«› —«÷ÌÂ")
            Else
                BSourceUmDetails.RemoveCurrent()
                cmd.CommandText = "select * from um_details"
                cmdb.DataAdapter = da
                da.Update(MyDs.Tables("um_details"))
                cls.MsgInfo(" „ Õ–› «·»Ì«‰«  »‰Ã«Õ")
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Um Details")
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        MyDs.Tables("um_details").RejectChanges()
        Me.Close()
    End Sub
End Class
