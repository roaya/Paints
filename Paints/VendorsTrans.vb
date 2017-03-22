Public Class VendorsTrans

    Dim Gcls As GeneralSp.MasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceVendorsTran As New BindingSource
    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Vendors_Transactions"
    '-------------------------------

    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData("Vendors")
            cls.FillSelectedTable("select * from vendors_transactions where doc_type = N'ÇÐä ÏÝÚ'", "Vendors_Transactions")


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

            Gcls = New GeneralSp.MasterForms(TName, BSourceVendorsTran, MenuNew, MenuSave, MenuDelete, MenuSearch, MenuExit, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, NavigationBar, ContentPanel, NavigationMenu, MasterField1, CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "ÇÐæäÇÊ ÇáÏÝÚ"
            Me.Text = Gcls.SetWTitle

            MasterField1.TextBox1.DataBindings.Add("Text", BSourceVendorsTran, "Doc_ID")
            PayDate.DataBindings.Add("Text", BSourceVendorsTran, "Doc_Date")
            PayedValue.DataBindings.Add("Value", BSourceVendorsTran, "Doc_Value")
            VendorID.DataSource = MyDs
            VendorID.DisplayMember = "Vendors.Vendor_Name"
            VendorID.ValueMember = "Vendors.Vendor_ID"
            VendorID.DataBindings.Add("SelectedValue", BSourceVendorsTran, "Vendor_ID")
            TotalDoc.DataBindings.Add("Text", BSourceVendorsTran, "Total_Doc")

            SSource = BSourceVendorsTran

            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Doc_ID"

            B_EndLoad = True

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
            Gcls.SaveRecord()
            cls.FillSelectedTable("select * from vendors_transactions where doc_type = N'ÇÐä ÏÝÚ'", "Vendors_Transactions")
            CountRecords.Text = BSourceVendorsTran.Count
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click, MenuDelete.Click
        Try
            Gcls.DeleteRecord()
            cls.FillSelectedTable("select * from vendors_transactions where doc_type = N'ÇÐä ÏÝÚ'", "Vendors_Transactions")
            CountRecords.Text = BSourceVendorsTran.Count
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Try
            Gcls.LastRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Try
            Gcls.NextRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnPervious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPervious.Click
        Try
            Gcls.PreviousRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
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



    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Gcls.CutData(ContentPanel)
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Gcls.CopyData(ContentPanel)
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Gcls.PasteData(ContentPanel)
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub OrderByCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderByCombo.SelectedIndexChanged
        Try
            If B_EndLoad = True Then
                Gcls.SortData(BSourceVendorsTran, OrderByCombo.ComboBox.SelectedValue)
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHelp.Click

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click, MenuExit.Click
        Try
            Gcls.ExitForm()
            Me.Close()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    Private Sub MenuReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            cls.FillSelectedTable("select * from " & TName, TName)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    Private Sub MenuCancelSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            BSourceVendorsTran.RemoveFilter()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub PayedValue_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PayedValue.ValueChanged
        TotalDoc.Text = PayedValue.Value
    End Sub

    Private Sub MenuStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub
End Class
