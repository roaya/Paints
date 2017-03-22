Imports System.Net.Mail

Public Class CloseEmails




    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False

        '-----------------Email Msg-------------------------------
        Try
            Me.Cursor = Cursors.WaitCursor
            If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Is_Send") = True Then
                If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Send_Action") = "انتهاء البرنامج" Then
                    Dim SmtpServer As New SmtpClient()
                    Dim mail As New MailMessage()
                    SmtpServer.EnableSsl = True
                    SmtpServer.Credentials = New  _
            Net.NetworkCredential(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Sender_Email").ToString, MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Sender_Pwd").ToString)

                    SmtpServer.EnableSsl = True
                    SmtpServer.Port = 587
                    SmtpServer.Host = "smtp.live.com"



                    cmd.CommandText = "select count(c.category_id) FROM CATEGORIES C , ITEMS I , ITEMS_STOCKS IST , Stocks S where S.STOCK_ID = IST.STOCK_ID And C.Category_Id = I.Category_Id And I.ITEM_ID = IST.ITEM_Id And IST.Balance <= i.Order_Balance"

                    If cmd.ExecuteScalar > 0 Then
                        mail = New MailMessage()
                        mail.From = New MailAddress(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Sender_Email"))
                        mail.To.Add(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Receipt_Email"))
                        mail.Subject = "Warehouse Manager - System Alerts"
                        mail.Body = "هناك بعض الأصناف وصلت لحد اعادة الطلب برجاء الاطلاع علي تقرير تحذيرات الأصناف"
                        SmtpServer.Send(mail)
                    End If

                    ProgressBar1.Value = ProgressBar1.Value + 10
                    ' ProgressTxt.Text = "%" & ProgressBar1.Value

                    cmd.CommandText = "select count(c.category_id) FROM CATEGORIES C , ITEMS I , ITEMS_STOCKS IST , Stocks S where S.STOCK_ID = IST.STOCK_ID And C.Category_Id = I.Category_Id And I.ITEM_ID = IST.ITEM_Id And IST.Balance <= I.Alert_Balance "

                    If cmd.ExecuteScalar > 0 Then
                        mail = New MailMessage()
                        mail.From = New MailAddress(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Sender_Email"))
                        mail.To.Add(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Receipt_Email"))
                        mail.Subject = "Warehouse Manager - System Alerts"
                        mail.Body = "هناك بعض الأصناف وصلت لحد التحذير برجاء الاطلاع علي تقرير تحذيرات الأصناف"
                        SmtpServer.Send(mail)
                    End If



                    cmd.CommandText = "select count(*) from report_salaes_offer where Expired_Date-GETDATE() <= 7"
                    If cmd.ExecuteScalar > 0 Then
                        mail = New MailMessage()
                        mail.From = New MailAddress(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Sender_Email"))
                        mail.To.Add(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Receipt_Email"))
                        mail.Subject = "Warehouse Manager - System Alerts"
                        mail.Body = "هناك بعض المناقصات التي قاربت علي الانتهاء برجاء الاطلاع علي تقرير التحذيرات"
                        SmtpServer.Send(mail)
                    End If

                    ProgressBar1.Value = ProgressBar1.Value + 10
                    'ProgressTxt.Text = "%" & ProgressBar1.Value

                    cmd.CommandText = "SELECT count(*) FROM Report_Customers_Payments where status = N'مجدولة' and Bill_Date-GETDATE() <= 7"
                    If cmd.ExecuteScalar > 0 Then
                        mail = New MailMessage()
                        mail.From = New MailAddress(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Sender_Email"))
                        mail.To.Add(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Receipt_Email"))
                        mail.Subject = "Warehouse Manager - System Alerts"
                        mail.Body = "هناك بعض الأقساط بقي علي تاريخ استحقاقها اقل من أسبوع برجاء الاطلاع علي تقرير التحذيرات"
                        SmtpServer.Send(mail)
                    End If



                    cmd.CommandText = "SELECT count(*) FROM Query_Employees_Tasks where approved=0 and To_Employee = " & EmpIDVar
                    If cmd.ExecuteScalar > 0 Then
                        mail = New MailMessage()
                        mail.From = New MailAddress(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Sender_Email"))
                        mail.To.Add(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Receipt_Email"))
                        mail.Subject = "Warehouse Manager - System Alerts"
                        mail.Body = "هناك بعض المهام لم يتم الاطلاع عليها برجاء الاطلاع علي تقرير التحذيرات"
                        SmtpServer.Send(mail)
                    End If

                    ProgressBar1.Value = ProgressBar1.Value + 10
                    'ProgressTxt.Text = "%" & ProgressBar1.Value

                    cmd.CommandText = "select count(*) from report_requests where Expired_Date-GETDATE() <= 7"
                    If cmd.ExecuteScalar > 0 Then
                        mail = New MailMessage()
                        mail.From = New MailAddress(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Sender_Email"))
                        mail.To.Add(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Receipt_Email"))
                        mail.Subject = "Warehouse Manager - System Alerts"
                        mail.Body = "هناك بعض طلبات العملاء لم يتبق لها الا أقل من أسبوع برجاء الاطلاع علي تقرير التحذيرات"
                        SmtpServer.Send(mail)
                    End If
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            cls.MsgInfo("لم يتم ارسال ايميلات النظام برجاء التأكد من اتصالك بالانترنت او مراجعة اعدادات النظام")
            End
        End Try
        '---------------------------------------------------------

    End Sub
End Class
