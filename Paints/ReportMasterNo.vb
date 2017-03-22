Public Class ReportMasterNo

    Dim Rpt_Requests As New RptRequests
    Dim Rpt_Sales_Offer As New RptSalesOffer
    Dim Rpt_Sales_Order As New RptSalesOrder

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            If MasterNo.Text = "" Then
                cls.MsgExclamation("اختر الرقم العام", "please enter master ID")
            Else
                cmd.CommandText = "select count(*) from requests_header where master_no = " & MasterNo.Value
                If cmd.ExecuteScalar <= 0 Then
                    cls.MsgExclamation("الرقم غير موجود مسبقا", "master no doesnot exists")
                Else
                    MyDs.Tables("Report_Requests").Rows.Clear()
                    cmd.CommandText = "select * from Report_Requests where master_no = " & MasterNo.Text
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("Report_Requests"))
                    Rpt_Requests.SetDataSource(MyDs.Tables("Report_Requests"))
                    CrystalReportViewer1.ReportSource = Rpt_Requests
                End If
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Rpt Cust Ret")
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            If MasterNo.Text = "" Then
                cls.MsgExclamation("اختر الرقم العام", "please enter master ID")
            Else
                cmd.CommandText = "select count(*) from Sales_Offer_Header where master_no = " & MasterNo.Value
                If cmd.ExecuteScalar <= 0 Then
                    cls.MsgExclamation("الرقم غير موجود مسبقا", "master no doesnot exists")
                Else
                    MyDs.Tables("report_salaes_offer").Rows.Clear()
                    cmd.CommandText = "select * from report_salaes_offer where master_no = " & MasterNo.Text
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("report_salaes_offer"))
                    Rpt_Sales_Offer.SetDataSource(MyDs.Tables("report_salaes_offer"))
                    CrystalReportViewer1.ReportSource = Rpt_Sales_Offer
                End If
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Rpt Cust Ret")
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            If MasterNo.Text = "" Then
                cls.MsgExclamation("اختر الرقم العام", "please enter master ID")
            Else
                cmd.CommandText = "select count(*) from sales_header where master_no = " & MasterNo.Value
                If cmd.ExecuteScalar <= 0 Then
                    cls.MsgExclamation("الرقم غير موجود مسبقا", "master no doesnot exists")
                Else
                    MyDs.Tables("report_salaes_offer").Rows.Clear()
                    cmd.CommandText = "select * from report_sales where master_no = " & MasterNo.Text
                    da.SelectCommand = cmd
                    da.Fill(MyDs.Tables("report_sales"))
                    Rpt_Sales_Order.SetDataSource(MyDs.Tables("report_sales"))
                    CrystalReportViewer1.ReportSource = Rpt_Sales_Order
                End If
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Rpt Cust Ret")
        End Try
    End Sub

    
End Class