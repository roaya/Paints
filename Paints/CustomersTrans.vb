Public Class CustomersTrans

    Dim Gcls As GeneralSp.MasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceCustomersTran As New BindingSource

    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Customers_Transactions"
    '-------------------------------

    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData("Customers")
            cls.FillSelectedTable("select * from Customers_transactions where doc_type = N'ÇÐä ÏÝÚ'", "Customers_transactions")

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

            Gcls = New GeneralSp.MasterForms(TName, BSourceCustomersTran, MenuNew, MenuSave, MenuDelete, MenuSearch, MenuExit, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, NavigationBar, ContentPanel, NavigationMenu, MasterField1, CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "ÇÐä ÏÝÚ Úãíá"
            Me.Text = Gcls.SetWTitle

            MasterField1.TextBox1.DataBindings.Add("Text", BSourceCustomersTran, "Doc_ID")
            PayDate.DataBindings.Add("Text", BSourceCustomersTran, "Doc_Date")
            PayedValue.DataBindings.Add("Value", BSourceCustomersTran, "Doc_Value")
            CustomerID.DataSource = MyDs
            CustomerID.DisplayMember = "Customers.Customer_Name"
            CustomerID.ValueMember = "Customers.Customer_ID"
            CustomerID.DataBindings.Add("SelectedValue", BSourceCustomersTran, "Customer_ID")
            CustomerID.DataBindings.Add("Text", BSourceCustomersTran, "customer_id")

            SSource = BSourceCustomersTran

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
            If MasterField1.TextBox1.Text = "" Or CustomerID.Text = "" Then
                cls.MsgComplete()
            ElseIf PayedValue.Value = 0 Then
                PayedValue.BackColor = Color.Yellow
                PayedValue.Focus()
                cls.MsgComplete()
            Else
                PayedValue.BackColor = Color.Gainsboro
                Gcls.SaveRecord()
            End If

        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click, MenuDelete.Click
        Try
            PayedValue.BackColor = Color.Gainsboro
            Gcls.DeleteRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click, MenuLast.Click
        Try
            Gcls.LastRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click, MenuNext.Click
        Try
            Gcls.NextRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnPervious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPervious.Click, MenuPrevious.Click
        Try
            Gcls.PreviousRec()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click, MenuFirst.Click
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
                Gcls.SortData(BSourceCustomersTran, OrderByCombo.ComboBox.SelectedValue)
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
            BSourceCustomersTran.RemoveFilter()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub PayedValue_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayedValue.Leave
        If PayedValue.Value <> 0 Then
            PayedValue.BackColor = Color.Gainsboro
        End If
    End Sub
End Class
