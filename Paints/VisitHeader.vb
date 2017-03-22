Public Class VisitHeader

    Dim Gcls As GeneralSp.NewMasterForms
    Dim B_EndLoad As Boolean = False
    Dim BSourceVisitHeader As New BindingSource

    '-------------------------------
    'Set The Data Table Name
    Dim TName As String = "Visit_Header"
    '-------------------------------
    Dim CurID, SeqID As New SqlClient.SqlParameter
    Dim cmdPro As New SqlClient.SqlCommand

    Private Sub Categories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Gcls.ExitForm()
    End Sub

    Private Sub Customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cls.RefreshData("Employees")
            cls.RefreshData("Stocks")
            cls.RefreshData("Visit_Header")
            cls.FillSelectedTable("select employee_id , employee_name from employees where job_id = 2", "EmpSalesRep")

            cmdPro.CommandType = CommandType.StoredProcedure
            cmdPro.Connection = cn


            CurID.DbType = DbType.Int32
            CurID.ParameterName = "CURR_ID"
            CurID.Direction = ParameterDirection.Output
            SeqID.DbType = DbType.Int32
            SeqID.ParameterName = "S_ID"
            SeqID.Direction = ParameterDirection.Input
            SeqID.Value = 14
            cmdPro.Parameters.Add(SeqID)
            cmdPro.Parameters.Add(CurID)
            cmdPro.CommandText = "UPDATE_SEQ"


            Dim B As New BindingSource
            B.DataSource = MyDs
            B.DataMember = "Table_Columns"
            B.Filter = "Table_ID ='" & TName & "'"
            OrderByCombo.DataSource = B
            OrderByCombo.DisplayMember = "Logical_Name"
            OrderByCombo.ValueMember = "Physical_Name"

            '-------------------------------
            'Must Specify Data Table Name
            '-------------------------------

            Gcls = New GeneralSp.NewMasterForms(TName, BSourceVisitHeader, BtnNew, BtnSave, BtnDelete, BtnSearch, BtnExit, BtnReload, BtnCancelSerach, BtnFirst, BtnPrevious, BtnNext, BtnLast, BtnFile, BtnData, BtnHelp, OrderByCombo, ContentPanel, MasterField1, CountRecords)

            '-------------------------------
            'Must Specify Window Title 
            '-------------------------------

            Gcls.SetWTitle = "»Ì«‰«  «·ÃÊ·« "
            Me.Text = Gcls.SetWTitle

            MasterField1.TextBox1.DataBindings.Add("Text", BSourceVisitHeader, "visit_Name")
            GenericDesc.DataBindings.Add("Text", BSourceVisitHeader, "Generic_Desc")
            Status.DataBindings.Add("Text", BSourceVisitHeader, "Status")
            StartDate.DataBindings.Add("Text", BSourceVisitHeader, "Start_Date")
            EndDate.DataBindings.Add("Text", BSourceVisitHeader, "End_Date")

            EmployeeID.DataSource = MyDs
            EmployeeID.DisplayMember = "Employees.Employee_Name"
            EmployeeID.ValueMember = "Employees.Employee_ID"
            EmployeeID.DataBindings.Add("SelectedValue", BSourceVisitHeader, "Employee_ID")

            SalesRepID.DataSource = MyDs
            SalesRepID.DisplayMember = "EmpSalesRep.Employee_Name"
            SalesRepID.ValueMember = "EmpSalesRep.Employee_ID"
            SalesRepID.DataBindings.Add("SelectedValue", BSourceVisitHeader, "Sales_Rep_ID")

            StockID.DataSource = MyDs
            StockID.DisplayMember = "Stocks.Stock_Name"
            StockID.ValueMember = "Stocks.Stock_ID"
            StockID.DataBindings.Add("SelectedValue", BSourceVisitHeader, "Stock_ID")

            SSource = BSourceVisitHeader

            '-------------------------------
            'Must Specify search field
            '-------------------------------

            RVal = "Visit_Name"

            B_EndLoad = True


        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click, MenuNew.Click
        Try
            cmdPro.ExecuteNonQuery()
            MyDs.Tables("Visit_Header").Columns("Visit_Name").DefaultValue = CurID.Value
            Gcls.NewRecord()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click, MenuSave.Click
        Try
            cmd.CommandText = "select count(*) from visit_header where sales_rep_id = " & SalesRepID.SelectedValue & " and status = N'„› ÊÕÂ'"
            If cmd.ExecuteScalar > 0 Then
                cls.MsgExclamation("Â‰«ﬂ ÃÊ·Â „› ÊÕÂ »«·›⁄· »«”„ «·„‰œÊ» «·„Õœœ", "")
            ElseIf MasterField1.TextBox1.Text = "" Then
                cls.MsgComplete()
                MasterField1.TextBox1.Focus()
                MasterField1.TextBox1.BackColor = Color.Yellow
            ElseIf EmployeeID.SelectedValue = Nothing Or SalesRepID.SelectedValue = Nothing Or StockID.SelectedValue = Nothing Then
                cls.MsgComplete()
            Else
                Gcls.SaveRecord()
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click, MenuDelete.Click
        Try
            Gcls.DeleteRecord()
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

    Private Sub BtnPervious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
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



    'Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Gcls.CutData(ContentPanel)
    '    Catch ex As Exception
    '        cls.WriteError(ex.Message, TName)
    '    End Try
    'End Sub

    'Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Gcls.CopyData(ContentPanel)
    '    Catch ex As Exception
    '        cls.WriteError(ex.Message, TName)
    '    End Try
    'End Sub

    'Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Gcls.PasteData(ContentPanel)
    '    Catch ex As Exception
    '        cls.WriteError(ex.Message, TName)
    '    End Try
    'End Sub

    Private Sub OrderByCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderByCombo.SelectedIndexChanged
        Try
            If B_EndLoad = True Then
                Gcls.SortData(BSourceVisitHeader, OrderByCombo.SelectedValue)
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub



    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click, MenuExit.Click
        Try
            Gcls.ExitForm()
            Me.Close()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReload.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Gcls.ReloadData()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub


    Private Sub BtnCancelSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelSerach.Click
        Try
            BSourceVisitHeader.RemoveFilter()
        Catch ex As Exception
            cls.WriteError(ex.Message, TName)
        End Try
    End Sub

    Private Sub BtnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFile.Click
        Gcls.BtnFile()
    End Sub

    Private Sub BtnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnData.Click
        Gcls.BtnData()
    End Sub

    Private Sub BtnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHelp.Click
        Gcls.BtnHelp()
    End Sub
End Class
