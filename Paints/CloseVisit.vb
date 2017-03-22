Public Class CloseVisit

    Private TblVisit As New GeneralDataSet.Visit_HeaderDataTable
    Private SID, StkID As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If VisitID.Text = "" Then
            cls.MsgExclamation("اختر كود الجوله", "")
        Else

            cmd.CommandText = "update visit_header set status = N'منتهيه' where visit_id = " & VisitID.SelectedValue
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select sales_rep_id from visit_header where visit_id = " & VisitID.SelectedValue
            SID = cmd.ExecuteScalar
            cmd.CommandText = "select stock_id from stocks where Emp_Reference_ID = " & SID
            StkID = cmd.ExecuteScalar
            cmd.CommandText = "insert into end_visit(item_id,expired_date,balance,found_balance,price,visit_id) select item_id,expired_date,balance,0 as found_balance,price," & VisitID.SelectedValue & " as visit_id from Items_stocks where stock_id = " & StkID
            cmd.ExecuteNonQuery()
            cls.MsgInfo("تم انهاء الجوله بنجاح", "")
            cls.RefreshData("select visit_id , visit_name from Visit_Header where status = N'مفتوحه'", TblVisit)
        End If
        
    End Sub

    Private Sub CloseVisit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cls.RefreshData("select visit_id , visit_name from Visit_Header where status = N'مفتوحه'", TblVisit)
        VisitID.DataSource = TblVisit
        VisitID.DisplayMember = "Visit_Name"
        VisitID.ValueMember = "Visit_ID"
    End Sub
End Class