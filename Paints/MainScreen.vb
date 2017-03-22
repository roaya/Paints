Imports System.Runtime.InteropServices
Imports System.Management

Public Class MainScreen

    Dim b As New BindingSource
    Dim objMOS As ManagementObjectSearcher
    Dim objMOC As Management.ManagementObjectCollection
    Dim objMO As Management.ManagementObject
    Dim PwdDefault As String
    Dim PnlSze As New Size(239, 673)

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_SMS_Is_Send") = True Then
                Dim Ie As New WebBrowser
                Dim TIncome As Double
                cmd.CommandText = "SELECT ISNULL(SUM(Cash_Value),0) FROM Sales_Header  WHERE Bill_Date BETWEEN '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
                TIncome = cmd.ExecuteScalar
                Ie.Navigate(MyDs.Tables("App_Preferences").Rows(0).Item("Gen_SMS_URL") & " Total Income Today = " & TIncome)
                If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Msg") = True Then
                    cls.MsgInfo("تم ارسال رسالة الموبايل الخاصة بالمبيعات بنجاح", "SMS has been sent successfully")
                End If
            End If
        Catch ex As Exception
            cls.MsgCritical("تعذر ارسال رسالة الموبايل", "last SMS hasnot been sent please contact your system administrator")
        End Try
        Try
            If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Send_Action") = "انتهاء البرنامج" Then
                Me.Opacity = 0
                Dim m As New CloseEmails
                m.Show()
            End If
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try

        Try
            cmd.CommandText = "insert into user_log(user_id,action) values(" & UserIDVar & ",N'تسجيل خروج')"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Dim ReturnedProperty = "", ProcID As String
            'REM Yotun ProcID = "BFEBFBFF0001067A"


            'ProcID = "BFEBFBFF0001067A"

            ''''ProcID = "BFEBFBFF0001067A"
            'objMOS = New ManagementObjectSearcher("Select ProcessorID From Win32_Processor")
            'objMOC = objMOS.Get

            'For Each objMO In objMOC

            '    ReturnedProperty = objMO("ProcessorID")

            'Next

            'If ReturnedProperty <> ProcID Then
            '    MsgBox("هذه النسخة غير مرخصة للعمل علي هذا الجهاز", MsgBoxStyle.Critical, ProjectTitle)
            '    '''''''cls.MsgCritical("هذه النسخة غير مرخصة للعمل علي هذا الجهاز", "this version isnot licensed to work on this machine please contact your system administrator")
            '    End
            'End If



            REM REM REM Dim s As New SplashScreen1
            REM REM REM s.Show()
            Dim x As New LoginForm
            x.ShowDialog()

            '-----------------set security-------------------------
            'Dim isopen, isopenfile As Integer

            'If My.Computer.FileSystem.FileExists("C:\data.sys.c") = True Then
            '    isopenfile = My.Computer.FileSystem.ReadAllText("C:\data.sys.c")
            'Else
            '    cls.MsgCritical("رجاء الاتصال بمدير النظام")
            '    End
            'End If

            'cmd.CommandText = "select backup_c from app_preferences where serial_pk = 1"
            'isopen = cmd.ExecuteScalar

            'If isopen = isopenfile Then
            '    If isopen > 3 Then
            '        My.Computer.FileSystem.DeleteFile("C:\data.sys.c")
            '        cls.MsgCritical("رجاء الاتصال بمدير النظام")
            '        End
            '    Else
            '        cmd.CommandText = "update app_preferences set backup_c = backup_c + 1"
            '        cmd.ExecuteNonQuery()
            '        isopenfile = isopenfile + 1
            '        My.Computer.FileSystem.WriteAllText("C:\data.sys.c", isopenfile, False)
            '    End If
            'Else
            '    cls.MsgCritical("رجاء الاتصال بمدير النظام")
            '    End
            'End If
            ''------------------------------------------

            SetPermission()

            If ShowLogReport = True Then
                Dim n As New LogRpt
                n.DataGridView1.DataSource = LogTbl
                n.Show()
            End If

            TxtStockName.Text = ProjectSettings.CurrentStockName
            TxtUserName.Text = UserNameVar


            If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_View_Alert") = True Then
                Dim m As New Alerts
                m.Show()
            End If

            '''If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Main_Screen") = "قائمة" Then
            '''    'MenuStrip1.Visible = True
            '''    'ToolStrip1.Visible = True
            '''    ToolStrip2.Visible = True
            '''    ToolStrip3.Visible = True
            '''    'TabControl1.Visible = False
            '''    '''SplitContainer1.Panel1.Visible = False
            '''    '''SplitContainer1.SplitterDistance = 0
            '''Else
            '''    'MenuStrip1.Visible = False
            '''    'ToolStrip1.Visible = False
            '''    ToolStrip2.Visible = False
            '''    ToolStrip3.Visible = False
            '''    'TabControl1.Visible = True
            '''    '''SplitContainer1.Panel1.Visible = True
            '''    '''SplitContainer1.SplitterDistance = 157
            '''End If

            '-------------------------Set Trial Version---------------------
            'If IsTrial = True Then
            '    cmd.CommandText = "select count(*) from Items_Stocks_T_D"
            '    If cmd.ExecuteScalar <= 0 Then
            '        cls.MsgCritical("تم انتهاء الفترة التجريبية الخاصة بالبرنامج", "trial version period has been expired please contact roaya corporation")
            '        End
            '    Else
            '        cmd.CommandText = "update Items_Stocks_T_D set stock_id=stock_id + 1 where item_id = 990"
            '        cmd.ExecuteNonQuery()
            '        cmd.CommandText = "select stock_id from Items_Stocks_T_D where item_id = 990"
            '        If cmd.ExecuteScalar >= 1050 Then
            '            cmd.CommandText = "delete from Items_Stocks_T_D"
            '            cmd.ExecuteNonQuery()
            '            cls.MsgCritical("تم انتهاء الفترة التجريبية الخاصة بالبرنامج", "trial version period has been expired please contact roaya corporation")
            '            End
            '        End If
            '    End If
            'End If
            '---------------------------------------------------------------

            Dim b As New BindingSource
            cmd.CommandText = "select Gen_Back_Photo from App_Preferences where serial_pk=1"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("MainBkG"))
            b.DataSource = MyDs
            b.DataMember = "MainBkG"
            PictureBox1.DataBindings.Add("backgroundImage", b, "Gen_Back_Photo", True)

            'MenuPurchaseOrderDesigner.Visible = True

            REM '''''''''''''''''''SetDefaultValues()

            cmd.CommandText = "select Sal_Footer from app_preferences where serial_pk = 1"
            PurFooter = cmd.ExecuteScalar

            'MenuMainQueryCheck.Visible = False

            cmd.CommandText = "insert into user_log(user_id,action) values(" & UserIDVar & ",N'تسجيل دخول')"
            cmd.ExecuteNonQuery()

            MenuCustomerReservation.Visible = True

            Dim srchWin As New GeneralSearch
            srchWin.MdiParent = Me
            srchWin.Dock = DockStyle.Left
            srchWin.Show()


            cmd.CommandText = "select shift_detail_id from shift_details where End_Date is NULL and employee_id=" & EmpIDVar
            Try
                CurrentShiftID = cmd.ExecuteScalar
            Catch
                CurrentShiftID = 0
            End Try

            Me.Opacity = 100

            'ToolStrip1.Visible = False
            ''' ToolStrip2.Visible = False
            '''  ToolStrip3.Visible = False

        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Sub SetDefaultValues()
        cmd.CommandText = "select count(*) from discount_cards where card_id = 0"
        If cmd.ExecuteScalar <= 0 Then
            cmd.CommandText = "SET IDENTITY_INSERT [dbo].[discount_cards] ON; insert into discount_cards(card_id,card_code,card_status,expired_date,card_value) values(0,'0',N'منتهي',getdate(),0); SET IDENTITY_INSERT [dbo].[discount_cards] Off;"
            cmd.ExecuteNonQuery()
        End If
        '--------------------------------------------------------------
        cmd.CommandText = "select count(*) from Ages where Age_id = 0"
        If cmd.ExecuteScalar <= 0 Then
            cmd.CommandText = "SET IDENTITY_INSERT dbo.Ages ON;INSERT INTO Ages(Age_ID,Age_Desc) VALUES(0,N'عام');SET IDENTITY_INSERT dbo.Ages OFF;"
            cmd.ExecuteNonQuery()
        End If
        cmd.CommandText = "update ages set from_age=0 , to_age=0"
        cmd.ExecuteNonQuery()
        '--------------------------------------------------------------
        cmd.CommandText = "select count(*) from Corporations where Corporation_id = 0"
        If cmd.ExecuteScalar <= 0 Then
            cmd.CommandText = "SET IDENTITY_INSERT dbo.Corporations ON;INSERT INTO dbo.Corporations(Corporation_ID,Corporation_Name) VALUES(0,N'عام');SET IDENTITY_INSERT dbo.Corporations OFF;"
            cmd.ExecuteNonQuery()
        End If
        '--------------------------------------------------------------
        cmd.CommandText = "select count(*) from Gender where Gender_id = 0"
        If cmd.ExecuteScalar <= 0 Then
            cmd.CommandText = "SET IDENTITY_INSERT dbo.Gender ON;INSERT INTO dbo.Gender(Gender_ID,Gender_Name) VALUES(0,N'عام');SET IDENTITY_INSERT dbo.Gender OFF;"
            cmd.ExecuteNonQuery()
        End If
        '--------------------------------------------------------------
        cmd.CommandText = "select count(*) from Items_Types where Type_ID = 0"
        If cmd.ExecuteScalar <= 0 Then
            cmd.CommandText = "SET IDENTITY_INSERT dbo.Items_Types ON;INSERT INTO Items_Types(Type_ID,Type_Name) VALUES(0,N'عام');SET IDENTITY_INSERT dbo.Items_Types OFF;"
            cmd.ExecuteNonQuery()
        End If
        '--------------------------------------------------------------
        cmd.CommandText = "select count(*) from Item_Sizes where Size_ID = 0"
        If cmd.ExecuteScalar <= 0 Then
            cmd.CommandText = "SET IDENTITY_INSERT dbo.Item_Sizes ON;INSERT INTO Item_Sizes(Size_ID,Size_Name) VALUES(0,N'عام');SET IDENTITY_INSERT dbo.Item_Sizes OFF;"
            cmd.ExecuteNonQuery()
        End If
        '--------------------------------------------------------------
        cmd.CommandText = "select count(*) from Categories where Category_ID = 0"
        If cmd.ExecuteScalar <= 0 Then
            cmd.CommandText = "SET IDENTITY_INSERT dbo.Categories ON;INSERT INTO dbo.Categories(Category_ID,Category_Name,Generic_Desc,Category_Discount) VALUES(0,N'عام',NULL,0);SET IDENTITY_INSERT dbo.Ages OFF;"
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Sub SetPermission()
        Try
            For i As Integer = 0 To LogTbl.Rows.Count - 1
                If LogTbl.Rows(i).Item(0) = "نافذة الادارات" Then
                    MenuDepartments.Visible = LogTbl.Rows(i).Item(1)

                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الموظفين" Then
                    MenuEmployees.Visible = LogTbl.Rows(i).Item(1)


                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الوظائف" Then

                    MenuJobs.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'ElseIf LogTbl.Rows(i).Item(0) = "Product Rang" Then

                    '    MenuProductRange.Visible = LogTbl.Rows(i).Item(1)

                    '    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'ElseIf LogTbl.Rows(i).Item(0) = "Logistics" Then

                    '    MenuLogistics.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'ElseIf LogTbl.Rows(i).Item(0) = "Coeff" Then

                    '    MenuCoeff.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذه حساب شئون العاملين" Then
                    Button17.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة مجموعه القياس" Then
                    MenuUmMaster.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة تفاصيل مجموعه القياس" Then
                    MenuUmDetails.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الحضور و الانصراف" Then
                    MenuAttendance = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الأجازات" Then
                    MenuVacations.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الخصومات" Then
                    MenuEmpDiscountCategories.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة بيانات المخازن" Then
                    MenuStocks.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الاصناف الاساسيه" Then
                    MenuItems.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة بيانات الشركات" Then
                    MenuCompanies.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة بنود الاصناف الاساسيه" Then
                    MenuCategories.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اهلاك الاصناف" Then
                    MenuItemsOut.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اذن التحويل" Then
                    MenuAdjustments.Visible = LogTbl.Rows(i).Item(1)

                ElseIf LogTbl.Rows(i).Item(0) = "نافذة جرد الاصناف" Then
                    MenuCheckHeader.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة تفاصيل جرد الاصناف" Then
                    MenuCheckDetails.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة عرض مستمر للاصناف" Then
                    MenuSlideShow.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة المهمات" Then
                    BtnTasks.Visible = LogTbl.Rows(i).Item(1)
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة بيانات العملاء" Then
                    MenuCustomers.Visible = LogTbl.Rows(i).Item(1)
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ElseIf LogTbl.Rows(i).Item(0) = "نافذة مرتجع العملاء" Then
                    MenuCustomerReturns.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اذن حجز اصناف" Then
                    MenuCustomerReservation.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ElseIf LogTbl.Rows(i).Item(0) = "نافذة عرض الأسعار" Then
                    MenuSalesOffer.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الموردين" Then
                    MenuVendors.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اذن ارتجاع مورد" Then
                    MenuVendorReturns.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة ربط الموردين بالأصناف" Then
                    MenuItemsVendor.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة فاتورة المشتريات" Then
                    MenuPurchaseOrdre.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة تصميم فاتورة المشتريات" Then
                    '  MenuPurchaseOrderDesigner.Visible = LogTbl.Rows(i).Item(1)
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ElseIf LogTbl.Rows(i).Item(0) = "نافذة المصروفات" Then
                    MenuExpenses.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اذونات الدفع" Then
                    MenuPayAllSalaries.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة بدأ جوله" Then
                    MenuVisits.Visible = LogTbl.Rows(i).Item(1)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ElseIf LogTbl.Rows(i).Item(0) = "تحميل جوله الاصناف" Then
                    Button9.Visible = LogTbl.Rows(i).Item(1)

                ElseIf LogTbl.Rows(i).Item(0) = "انهاء جوله" Then
                    MenuEndVisit.Visible = LogTbl.Rows(i).Item(1)
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "فئه العميل" Then
                    Button14.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'ElseIf LogTbl.Rows(i).Item(0) = "نافذة قائمه الدخل التفصيليه" Then
                    '  Button14.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اسماء الحسابات" Then
                    MenuDailyProNames.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة القيود" Then
                    constraint.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الشيكات" Then
                    Cheques.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة تعاملات البنوك" Then
                    Banks.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اذونات الدفع" Then
                    Button18.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة حساب الاستاذ" Then
                    MenuMasterRecord.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة ميزان المراجعه" Then
                    MenuBalanceBook.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الميزانيه العموميه" Then
                    MenuBalanceSheet.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اهلاك الاصول الثابته" Then
                    MenuDepPro.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "احصائيه الاصناف الاكثر شراء" Then
                    MenuMostPurchase.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "استعلام الاكثر مبيعا" Then
                    MenuMostSales.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الشيكات" Then
                    Cheques.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الشيكات" Then
                    Cheques.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "احصائيه الاصناف الاكثر مبيعا اليوم" Then
                    Menusalesdaily.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "احصائيه الاصناف الاكثر اهلاكا" Then
                    MenuMostDep.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "احصائيه اجمالى المبيعات" Then
                    MostSalesByEmp.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "احصائيه الرصيد الاجل للعملاء" Then
                    MenuStatMostCredit.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة مجموعه الامان" Then
                    MenuSecurityGroupHeader.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة صلاحيات مجموعه الامان" Then
                    MenuSecurityGroupDetails.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذه بيانات المستخدمين" Then
                    MenuUsers.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اعدادات البرنامج" Then
                    MenuUserPreferences.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الورديات" Then
                    MenuPeriods.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الوضع الافتراضى" Then
                    MenuSetDefault.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة اوامر النظام" Then
                    MenuSystemCommands.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة تشغيل سيرفر الشات" Then
                    MenuChatServer.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "نافذة الدخول للشات" Then
                    MenuChatClient.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ElseIf LogTbl.Rows(i).Item(0) = "تقرير المبيعات" Then
                    MenuRptSales.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير المشتريات" Then
                    MunuRptPurchase.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير اذونات التحويل" Then
                    MenuAdjust.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير مرتجع العملاء" Then
                    MenuRptCustReturns.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير مرتجع الموردين" Then
                    MenuRptVendorReturns.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير طباعه الباركود" Then
                    MenuPrintBarcode.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير تقييم المخزن" Then
                    MenuReportStockValue.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير حركه المخزون" Then
                    MenuStockTrns.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير حركه الموردين" Then
                    MenuVendorTrans.Visible = LogTbl.Rows(i).Item(1)

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير حركه العملاء" Then
                    MenuCustTrans.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير تفصيلى بالمبيعات" Then
                    MenuSalesDetails.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير حركه المستخدمين على النظام" Then
                    MenuRptUsers.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير الارقام العامه" Then
                    MenuGeneralNumbers.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير عمولات الموظفين" Then
                    MenuCustCommission.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير ارصده الحسابات" Then
                    MenuRptAccountsBalance.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير تفصيلى بالشيكات" Then
                    MenuRptCheques.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير اسعار الاصناف" Then
                    MenuRptItemPrices.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير كشف حساب بنك" Then
                    MenuRptBanks.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير اجمالى الارصده النهائيه" Then
                    MenuRptFinalBalance.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير تفصيلى لتعاملات الموردين والعملاء" Then
                    MenuCustVendTrans.Visible = LogTbl.Rows(i).Item(1)
                ElseIf LogTbl.Rows(i).Item(0) = "تقرير الارصده" Then
                    MeunBalance.Visible = LogTbl.Rows(i).Item(1)




                    'ElseIf LogTbl.Rows(i).Item(0) = "شئون العاملين" Then
                    '    MenuQueryEmp.Visible = LogTbl.Rows(i).Item(1)

                    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'ElseIf LogTbl.Rows(i).Item(0) = "المخازن" Then
                    '    MenuStocksInf.Visible = LogTbl.Rows(i).Item(1)

                    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'ElseIf LogTbl.Rows(i).Item(0) = "العملاء" Then
                    '    MenuCust.Visible = LogTbl.Rows(i).Item(1)

                    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'ElseIf LogTbl.Rows(i).Item(0) = "الموردين" Then
                    '    MeunVendors.Visible = LogTbl.Rows(i).Item(1)

                End If

            Next
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuDepartments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepartments.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New Departments
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuJobs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuJobs.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New Jobs
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmployees.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New Employees
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAttendance.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New Attendance
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuVacations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVacations.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New EmployeesVacations
        m.MdiParent = Me
        m.Show()
    End Sub





    Private Sub MenuEmpTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTaxes.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New Taxes
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStocks.Click
        Dim m As New Stocks
        m.MdiParent = Me
        m.Show()
    End Sub



    Private Sub MenuDiscountCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmpDiscountCategories.Click
        Dim m As New DiscountCategories
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuEmpDiscounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmpDiscountDetails.Click
        Dim m As New EmployeesDiscounts
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItems.Click
        Dim m As New Items
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCategories.Click
        Dim m As New Categories
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCompanies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCompanies.Click
        Dim m As New Corporations
        m.MdiParent = Me
        m.Show()
    End Sub


    Private Sub MenuAdjustments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAdjustments.Click
        Dim m As New Adjustments
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuUserPreferences_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUserPreferences.Click
        Dim m As New FrmUserPreferences
        m.MdiParent = Me
        m.Show()
        '''Me.Opacity = 0
        '''If MyDs.Tables("App_Preferences").Rows(0).Item("Gen_Main_Screen") = "قائمة" Then
        '''    'MenuStrip1.Visible = True
        '''    'ToolStrip1.Visible = True
        '''    ToolStrip2.Visible = True
        '''    ToolStrip3.Visible = True
        '''    'TabControl1.Visible = False
        '''    '''''SplitContainer1.Panel1.Visible = False
        '''    '''''SplitContainer1.SplitterDistance = 0
        '''Else
        '''    'MenuStrip1.Visible = False
        '''    'ToolStrip1.Visible = False
        '''    ToolStrip2.Visible = False
        '''    ToolStrip3.Visible = False
        '''    'TabControl1.Visible = True
        '''    '''''SplitContainer1.Panel1.Visible = True
        '''    '''''SplitContainer1.SplitterDistance = 157
        '''End If
        '''Me.Opacity = 100
    End Sub

    Private Sub MenuSalesOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSalesOrder.Click



        If MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Def_Style") = "مبسطه" Then
            Dim m As New salesordersimple
            m.MdiParent = Me
            m.Show()
        Else
            Dim m As New SalesOrderNormal
            m.MdiParent = Me
            m.Show()
        End If
        'ElseIf MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Def_Style") = "مقسمة" Then
        'Dim n As New SalesOrderButtons
        'n.Show()
        'ElseIf MyDs.Tables("App_Preferences").Rows(0).Item("Sal_Def_Style") = "فلتر" Then
        'Dim x As New SalesOrderFilter
        'x.Show()
        'End If
    End Sub

    Private Sub PurchaseOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPurchaseOrdre.Click
        'If MyDs.Tables("App_Preferences").Rows(0).Item("Pur_Def_Style") = "عادية" Then
        Dim m As New PurchaseOrderNormal
        m.MdiParent = Me
        m.Show()
        'ElseIf MyDs.Tables("App_Preferences").Rows(0).Item("Pur_Def_Style") = "مقسمة" Then
        'Dim n As New PurchaseOrderButtons
        'n.Show()
        'ElseIf MyDs.Tables("App_Preferences").Rows(0).Item("Pur_Def_Style") = "فلتر" Then
        'Dim x As New PurchaseOrderFilter
        'x.Show()
        'End If
    End Sub


    Private Sub MenuItemsOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemsOut.Click
        Dim m As New ItemsDep
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCheckHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCheckHeader.Click
        Dim m As New CheckHeader
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCheckDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCheckDetails.Click
        Dim m As New CheckDetails
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuMaxCustCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMaxCustCredit.Click
        Dim m As New CustomerLevels
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuMaxCustDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMaxCustDiscount.Click
        Dim m As New CustomerDiscountLevel
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCustomerRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustomerRequest.Click
        Panel1.Visible = False
        Panel3.Visible = False
        Dim m As New CustomersRequests
        m.MdiParent = Me
        m.Show()
    End Sub




    Private Sub MenuSalesOffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSalesOffer.Click
        Panel1.Visible = False
        Panel1.Visible = False
        Dim m As New SalesOffer
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCustomerReturns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustomerReturns.Click
        Panel1.Visible = False
        Panel3.Visible = False
        Dim m As New ReturnsCustomers
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuVendors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVendors.Click
        Panel17.Visible = False
        Dim m As New Vendors
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuVendorReturns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVendorReturns.Click
        Panel17.Visible = False
        Dim m As New ReturnsVendors
        m.MdiParent = Me
        m.Show()
    End Sub

    'Private Sub MenuVendorPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MENUVendorsPayments.Click
    '    Dim m As New VendorsTrans
    '    m.Show()
    'End Sub

    Private Sub MenuItemsVendors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemsVendor.Click
        Panel17.Visible = False
        Dim m As New ItemsVendors
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuExpensesHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExpensesHeader.Click
        Dim m As New ExpensesMaster
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuEmpRewardsCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmpRewardsCategories.Click
        Dim m As New RewardsCategories
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuEmpRewards_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MENUEmpRewards.Click
        Dim m As New EmployeesRewards
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuEmpAddedHours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmpAddedHours.Click
        Dim m As New EmpAddedHours
        m.MdiParent = Me
        m.Show()
    End Sub





    Private Sub MenuExpensesOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExpensesOther.Click
        Dim m As New ExpensesDetails
        m.MdiParent = Me
        'm.Exp_Type = 0
        m.Show()

    End Sub

    Private Sub EmpDiscountCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New DiscountCategories
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub EmpDiscountDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New EmployeesDiscounts
        m.Show()
    End Sub

    Private Sub MenuMostPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostPurchase.Click
        Try
            MyDs.Tables("Most_Purchase").Clear()
            cmd.CommandText = "select * from most_purchase"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Purchase"))
            Dim m As New ShowAllReports
            Dim rpt As New StatMostPurchase
            rpt.SetDataSource(MyDs.Tables("Most_Purchase"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuMostSalesOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostSalesOne.Click
        Try
            MyDs.Tables("Most_Sales_One").Clear()
            cmd.CommandText = "select * from Most_Sales_One"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Sales_One"))
            Dim m As New ShowAllReports
            Dim rpt As New StatMostSalesOne
            rpt.SetDataSource(MyDs.Tables("Most_Sales_One"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuMostSalesAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostSalesAll.Click
        Try
            MyDs.Tables("Most_Sales_All").Clear()
            cmd.CommandText = "select * from Most_Sales_All"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Sales_All"))
            Dim m As New ShowAllReports
            Dim rpt As New StatMostSalesAll
            rpt.SetDataSource(MyDs.Tables("Most_Sales_All"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuMostSalesOneByDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostSalesOneByDay.Click
        Try
            MyDs.Tables("Most_Sales_All").Clear()
            cmd.CommandText = "select * from Most_Sales_One_Day"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Sales_All"))
            Dim m As New ShowAllReports
            Dim rpt As New StatMostSalesAll
            rpt.SetDataSource(MyDs.Tables("Most_Sales_All"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuMostSalesAllByDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostSalesAllByDay.Click
        Try
            MyDs.Tables("Most_Sales_All").Clear()
            cmd.CommandText = "select * from Most_Sales_All_Day"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Sales_All"))
            Dim m As New ShowAllReports
            Dim rpt As New StatMostSalesAll
            rpt.SetDataSource(MyDs.Tables("Most_Sales_All"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuMostSalesEmpAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostSalesEmpAll.Click

        Try
            MyDs.Tables("Most_Sales_Emp_All").Clear()
            cmd.CommandText = "select * from Most_Sales_Emp_All"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Sales_Emp_All"))
            Dim m As New ShowAllReports
            Dim rpt As New StatMostSalesEmpAll
            rpt.SetDataSource(MyDs.Tables("Most_Sales_Emp_All"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuMostSalesEmpPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostSalesEmpPeriod.Click
        Dim m As New ShowAllReportByPeriod
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuMostDepAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostDep.Click
        Try
            MyDs.Tables("Most_Dep_All").Clear()
            cmd.CommandText = "select * from Most_Dep_All"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Dep_All"))
            Dim m As New ShowAllReports
            Dim rpt As New StatMostDepAll
            rpt.SetDataSource(MyDs.Tables("Most_Dep_All"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub QueryStocksByItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryAllItem2
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByCorporation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryAllItems1
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByCategoryName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryAllItem3
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByGender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryAllItem4
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksBySeason_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryAllItem5
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryByBarcode
        m.Show()
    End Sub



    Private Sub MenuQueryAttendAbsent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryAttendance
        m.Show()
    End Sub

    Private Sub MenuQueryEmployeesDiscounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QuerEmployeesDiscounts
        m.Show()
    End Sub

    Private Sub MenuQueryEmployeesRewards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryEmployeesRewards
        m.Show()
    End Sub

    Private Sub MenuSlideShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSlideShow.Click
        Dim m As New ItemsSlideShow
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub QueryItemsByStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryItemsStocks
        m.Show()
    End Sub

    Private Sub MenuQueryByBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryItemsByBarcode
        m.Show()
    End Sub

    Private Sub MenuQueryByItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryItemsByStock
        m.Show()
    End Sub

    Private Sub MenuQueryByDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryItemsDep
        m.RadioItemName.Checked = True
        m.Show()
    End Sub


    Private Sub MenuQueryDepByStockName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryItemsDep
        m.RadioStockName.Checked = True
        m.Show()
    End Sub

    Private Sub MenuQueryDepByBillID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryItemsDep
        m.RadioBillID.Checked = True
        m.Show()
    End Sub

    Private Sub MenuReportAdjByStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New ReportAdjustments
        m.RadioStockName.Checked = True
        m.Show()
    End Sub

    Private Sub MenuReportAdjByItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New ReportAdjustments
        m.RadioItemName.Checked = True
        m.Show()
    End Sub

    Private Sub MenuReportAdjByBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New ReportAdjustments
        m.RadioBarCode.Checked = True
        m.Show()
    End Sub

    Private Sub MenuReportAdjByAdjID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New ReportAdjustments
        m.RadioToStockID.Checked = True
        m.Show()
    End Sub

    Private Sub MenuQueryMaxCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryCustomerLevel
        m.Show()
    End Sub

    Private Sub MenuCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustomers.Click
        Panel1.Visible = False
        Panel3.Visible = False
        Dim m As New Customers
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryCustomerDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryCustomerDiscount
        m.Show()
    End Sub

    Private Sub MenuQueryCusCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MyDs.Tables("Most_Customer_Credit").Rows.Clear()
            cmd.CommandText = "select customer_name , TOTAL_CREDIT from Most_Customer_Credit order by customer_name"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Customer_Credit"))
            Dim m As New ShowAllQueries
            m.DataGridView1.DataSource = MyDs.Tables("Most_Customer_Credit")
            m.DataGridView1.Columns(0).HeaderText = "اسم العميل"
            m.DataGridView1.Columns(1).HeaderText = "اجمالي الآجل"
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuStatMostCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStatMostCredit.Click
        Try
            MyDs.Tables("Most_Customer_Credit").Clear()
            cmd.CommandText = "select * from Most_Customer_Credit"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_Customer_Credit"))
            Dim m As New ShowAllReports
            Dim rpt As New StatMostCusCredit
            rpt.SetDataSource(MyDs.Tables("Most_Customer_Credit"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub


    Private Sub MenuMostCustOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim t As New DataTable
            t.Rows.Clear()
            cmd.CommandText = "SELECT CUSTOMER_NAME as 'اسم العميل',Total_Order as 'اجمالي قيمة فواتير المبيعات',Count_Orders as 'عدد الفواتير',Total_Cash as 'اجمالي النقدي',Total_Credit as 'اجمالي الآجل',Count_Items as 'عدد الأصناف في كل الفواتير' FROM Most_Cust_Orders "
            da.SelectCommand = cmd
            da.Fill(t)
            Dim m As New ShowAllQueries
            m.DataGridView1.DataSource = t
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    '''Private Sub MenuMostCustDisCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostCustDisCards.Click, TabMenuMostCustDisCards.Click
    '''    Try
    '''        Dim t As New DataTable
    '''        t.Rows.Clear()
    '''        cmd.CommandText = "SELECT CUSTOMER_NAME as 'اسم العميل',Total_cards as 'اجمالي عدد كوبونات الخصم' FROM Most_Cust_Cards "
    '''        da.SelectCommand = cmd
    '''        da.Fill(t)
    '''        Dim m As New ShowAllQueries
    '''        m.DataGridView1.DataSource = t
    '''        m.Show()
    '''    Catch ex As Exception
    '''        cls.WriteError(ex.Message, "Main Form")
    '''    End Try
    '''End Sub

    Private Sub QueryItemsVendorsByItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryItemsVendors
        m.RadioItemName.Checked = True
        m.Show()
    End Sub

    Private Sub QueryItemsVendorsByVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryItemsVendors
        m.RadioVendorName.Checked = True
        m.Show()
    End Sub

    Private Sub MenuQueryVenCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MyDs.Tables("Most_vendor_Credit").Rows.Clear()
            cmd.CommandText = "select vendor_name , TOTAL_payment from Most_vendor_Credit order by vendor_name"
            da.SelectCommand = cmd
            da.Fill(MyDs.Tables("Most_vendor_Credit"))
            Dim m As New ShowAllQueries
            m.DataGridView1.DataSource = MyDs.Tables("Most_vendor_Credit")
            m.DataGridView1.Columns(0).HeaderText = "اسم المورد"
            m.DataGridView1.Columns(1).HeaderText = "اجمالي المدفوع"
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub MenuMostVenOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim t As New DataTable
            t.Rows.Clear()
            cmd.CommandText = "SELECT vendor_NAME as 'اسم المورد',Total_Order as 'اجمالي قيمة فواتير المشتريات',Count_Orders as 'عدد الفواتير',Total_Cash as 'اجمالي النقدي',Total_Credit as 'اجمالي الآجل',Count_Items as 'عدد الأصناف في كل الفواتير' FROM Most_Ven_Orders "
            da.SelectCommand = cmd
            da.Fill(t)
            Dim m As New ShowAllQueries
            m.DataGridView1.DataSource = t
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub


    Private Sub QueryEmpByDepID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryEmpByJobDep
        m.RadioDepID.Checked = True
        m.Show()
    End Sub

    Private Sub QueryEmpByJobID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryEmpByJobDep
        m.RadioJobID.Checked = True
        m.Show()
    End Sub

    Private Sub MenuQueryExpensesByCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryExpensesByPeriod
        m.RadioExpenseCategory.Checked = True
        m.Show()
    End Sub









    Private Sub MenuSecurityGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSecurityGroupHeader.Click
        Dim m As New SecurityGroupHeader
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuSecurityGroupDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSecurityGroupDetails.Click
        Dim m As New SecurityGroupDetails
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUsers.Click
        Dim m As New AppUsers
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryAllItem5
        m.Show()
    End Sub

    Private Sub MenuQueryEmpGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryByEmployee
        m.Show()
    End Sub

    Private Sub MenuQueryExpensesByExpenseName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryExpensesByPeriod
        m.RadioExpenseName.Checked = True
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryExpensesByEmName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New QueryExpensesByPeriod
        m.RadioEmployeeName.Checked = True
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuPeriods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPeriods.Click
        Dim m As New Periods
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuItemsStocks_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemsStocks.Click
        Dim m As New FirstBalanceStock
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuIncomeByPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New NetProfit
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuIncomeToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim m As New NetProfit


        Try
            m.DateTimePicker1.Visible = False
            m.DateTimePicker2.Visible = False
            m.Label1.Visible = False
            m.Label2.Visible = False

            cmd.CommandText = "SELECT ISNULL(SUM(Doc_VALUE),0) FROM Vendors_Transactions WHERE Doc_Date  between '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "' and doc_type = N'اذن دفع'"
            m.TotalVendorPayments.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(REWARD_VALUE),0) FROM Employees_Added_Hours WHERE Hours_Date between '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalAddedHours.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(EXPENSE_VALUE),0) FROM Expenses_Details WHERE EXPENSE_Date between '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalExpenses.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(NET_SALARY),0) FROM PAY_SALARY WHERE PAY_Date BETWEEN '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalPaySalary.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Cash_Value),0) FROM Purchase_Header where (Pay_Type = N'نقدي' OR Pay_Type =N'نقدي و اجل') and  Bill_Date BETWEEN '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalPurchase.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Total_Bill),0) FROM return_c_Header  WHERE Bill_Date BETWEEN '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalReturnCustomers.Text = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(SUM(Cash_Value),0) FROM Sales_Header WHERE (Pay_Type = N'نقدي' OR Pay_Type =N'نقدي و اجل') AND Bill_Date BETWEEN '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.ProfitSales.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Cash_Value),0) FROM Sales_Header WHERE Pay_Type = N'فيزا' AND Bill_Date BETWEEN '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.ProfitVisa.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Total_Bill),0) FROM return_v_Header  WHERE Bill_Date BETWEEN '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.ProfitReturnVendors.Text = cmd.ExecuteScalar
            cmd.CommandText = "SELECT ISNULL(SUM(Doc_VALUE),0) FROM Customers_Transactions WHERE Doc_Date  between '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "' and doc_type = N'اذن دفع'"
            m.ProfitCustomerPayments.Text = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(SUM(Cheque_VALUE),0) FROM cheques WHERE direction = N'مبيعات' and cheque_status = N'منصرف'"
            m.TotalCustomersCheques.Text = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(SUM(Cheque_VALUE),0) FROM cheques WHERE direction = N'مشتريات' and cheque_status = N'منصرف'"
            m.TotalVendorsCheques.Text = cmd.ExecuteScalar

            '---------------------------------------------------
            cmd.CommandText = " select isnull(sum(doc_value),0) from Customers_Transactions where doc_type = N'دفع نقديه للعميل' and  doc_date between '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalCashToCustomer.Text = cmd.ExecuteScalar

            cmd.CommandText = " select isnull(sum(doc_value),0) from Vendors_Transactions where doc_type = N'دفع نقديه من المورد' and  doc_date between '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalCashFromVendor.Text = cmd.ExecuteScalar

            cmd.CommandText = " select isnull(sum(doc_value),0) from Money_Payments where doc_type = N'اذن دفع كاش' and  doc_date between '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalPayGeneralCash.Text = cmd.ExecuteScalar

            cmd.CommandText = " select isnull(sum(doc_value),0) from Money_Payments where doc_type = N'اذن استلام كاش' and  doc_date between '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
            m.TotalReceiveGeneralCash.Text = cmd.ExecuteScalar

            'cmd.CommandText = " select isnull(sum(doc_value),0) from Report_Customer_Transaction where doc_type = N'دفع شيك للعميل' and  doc_date between '" & d1.ToString("MM/dd/yyyy") & "' and '" & d2.ToString("MM/dd/yyyy") & "'  and customer_name = N'" & Combcustomer.Text & "'"
            'TotalChequeToCustomer = cmd.ExecuteScalar
            '---------------------------------------------------

            m.ProfitNet.Text = (CDbl(m.TotalReceiveGeneralCash.Text) + CDbl(m.TotalCashFromVendor.Text) + CDbl(m.ProfitCustomerPayments.Text) + CDbl(m.TotalCustomersCheques.Text) + CDbl(m.ProfitReturnVendors.Text) + CDbl(m.ProfitVisa.Text) + CDbl(m.ProfitSales.Text)) - (CDbl(m.TotalPayGeneralCash.Text) + CDbl(m.TotalAddedHours.Text) + CDbl(m.TotalExpenses.Text) + CDbl(m.TotalPaySalary.Text) + CDbl(m.TotalPurchase.Text) + CDbl(m.TotalReturnCustomers.Text) + CDbl(m.TotalVendorPayments.Text) + CDbl(m.TotalVendorsCheques.Text) + CDbl(m.TotalCashToCustomer.Text))

            If CDbl(m.ProfitNet.Text) >= 0 Then
                m.ProfitNet.ForeColor = Color.Blue
                m.LblProfit.BackColor = Color.Blue
            Else
                m.ProfitNet.ForeColor = Color.Red
                m.LblProfit.BackColor = Color.Red
            End If

            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Net Profit")
        End Try

        'Try
        '    cmd.CommandText = "SELECT ISNULL(SUM(Cash_Value),0) FROM Sales_Header  WHERE Bill_Date BETWEEN '" & Now.ToString("MM/dd/yyyy") & "' and '" & Now.ToString("MM/dd/yyyy") & "'"
        '    cls.MsgInfo(cmd.ExecuteScalar, "total income today is " & cmd.ExecuteScalar)
        'Catch ex As Exception
        '    cls.WriteError(ex.Message, "User Pref")
        'End Try
    End Sub

    REM REM REM Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    REM REM REM     TxtDateNow.Text = Now.ToString("dd/MM/yyyy")
    REM REM REM     TxtTimeNow.Text = Now.ToLongTimeString
    REM REM REM End Sub

    Private Sub MenuSetDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSetDefault.Click
        Try
            REM AssistantSound.Speak("please enter system password")
            PwdDefault = InputBox("أدخل كلمة السر الخاصة بالنظام", ProjectTitle)
            If PwdDefault = "hosest" Then
                cls.MsgInfo("برجاء الانتظار حتي يتم الانتهاء", "process has been started please donot shutdown your system")
                Me.Cursor = Cursors.WaitCursor
                cmd.CommandText = "DELETE FROM Adjustment_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Purchase_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Request_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Return_C_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Return_V_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Sales_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Dep_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Vendors_Payments"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Customers_Payments"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Customer_Discount_Level"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Customer_Levels"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Attendance"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Check_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Check_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM Sales_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Purchase_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Request_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Return_C_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Return_V_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM Adjustment_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Dep_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Discount_Cards"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Employees_Discounts"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Discount_Categories"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Employees_Added_Hours"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Employees_Rewards"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Employees_Tasks"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Employees_Vacations"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Expenses_Details"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Expenses_Header"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Items_Stocks"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Items_Vendors"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Pay_Salary"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Vendors"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Customers"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Items"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Ages"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Gender"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Item_Sizes"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Categories"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Items_Types"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Discount_Categories"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Corporations"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Rewards_Categories"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM dbo.Stocks"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "UPDATE Security_Group_Details SET Granted =1"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "UPDATE Seq_Table SET Curr_Val = 1"
                cmd.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
                cls.MsgInfo("تم اعادة النظام للوضع الافتراضي برجاء اعادة التشغيل", "system has been returned to default settings please restart your system")
                End
            Else
                cls.MsgCritical("خطأ في ادخال كلمة السر الخاصة بالنظام", "invalid password please contact your system administrator")
            End If
        Catch ex As Exception
            cls.MsgCritical("خطأ في ادخال كلمة السر الخاصة بالنظام", "invalid password please contact your system administrator")
        End Try
    End Sub

    Private Sub MenuReportStockValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New ReportStockValue
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuInvLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New FrmInvLog
        m.Show()
    End Sub

    Private Sub MenuVendorTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New FrmVendorsTrans
        m.Show()
    End Sub

    Private Sub MenuRptSalesDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New FrmReportDetailsSales
        m.Show()
    End Sub

    Private Sub MenuSystemCommands_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSystemCommands.Click
        Try
            REM AssistantSound.Speak("please enter system password")
            Dim s As String = InputBox("أدخل كلمة السر الخاصة بأوامر النظام", ProjectTitle)
            If s = "roaya123" Then
                Dim m As New FrmWindows
                m.MdiParent = Me
                m.Show()
            Else
                cls.MsgCritical("كلمة السر خاطئة", "invalid password please contact your system administrator")
            End If
        Catch ex As Exception
            cls.MsgCritical(ex.Message)
        End Try
    End Sub

    Private Sub MenuChatServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuChatServer.Click
        Try
            Dim p As New Process
            For Each p In Process.GetProcesses
                If p.ProcessName = "server" Then
                    cls.MsgExclamation("نافذة الشات سرفر مفتوحة بالفعل", "chatting server window already opened")
                    Exit Sub
                End If
            Next

            Process.Start(My.Application.Info.DirectoryPath & "\Server.exe")

        Catch ex As Exception
            cls.MsgCritical("لا يمكن تشغيل الشات سرفر في الوقت الحالي", "unable to start chat server please contact your system administrator")
        End Try
    End Sub

    Private Sub MenuChatClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuChatClient.Click
        Dim m As New ChatClient
        m.MdiParent = Me
        m.Show()
    End Sub


    'Private Sub TabMenuQueryDepByItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim m As New QueryItemsDep
    '    m.Show()
    'End Sub

    'Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim m As New ReportAdjustments
    '    m.Show()
    'End Sub

    'Private Sub TabMenuMainCustRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim m As New ReportCustomerRequest
    '    m.Show()
    'End Sub


    'Private Sub TabMenuMainVendorsReturns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim m As New ReportVenReturns
    '    m.Show()
    'End Sub

    'Private Sub TabMenuMainPurchaseOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim m As New ReportPurchaseOrder
    '    m.Show()
    'End Sub

    'Private Sub TabMenuMainSalesOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim m As New ReportSalesOrder
    '    m.Show()
    'End Sub


    'Private Sub MenuUserLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim m As New ReportUserLog
    '    m.Show()
    'End Sub

    Private Sub MenuIncomeDetailsByPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuIncomeDetailsByPeriod.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
        Dim m As New NetProfitDetails
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuDailyProcedures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDailyProcedures.Click
        Dim m As New ReportDailyPro
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuDailyProNames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDailyProNames.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
        Dim m As New DailyProcedures
        m.MdiParent = Me
        m.Show()
    End Sub




    Private Sub MenuUmMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUmMaster.Click
        Dim m As New UmMaster
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuUmDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUmDetails.Click

        Dim m As New UmDetails
        m.MdiParent = Me
        m.Show()
    End Sub


    Private Sub MenuMasterNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New ReportMasterNo
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCustomerReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustomerReservation.Click
        Panel1.Visible = False
        Panel3.Visible = False
        Dim m As New CustomerReservation
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuNewProcedureTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNewProcedureTran.Click
        Dim m As New ProceduresTrans
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCheques.Click
        Dim m As New Cheques
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuChequeStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuChequeStatus.Click
        Dim m As New ChequesStatus
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuBanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBanks.Click
        Dim m As New Banks
        m.MdiParent = Me

        m.Show()
    End Sub

    Private Sub MenuBanksAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBanksAccounts.Click
        Dim m As New BankAccounts
        m.MdiParent = Me
        m.Show()
    End Sub

   

    Private Sub MenuVisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVisa.Click
        Dim m As New Visa
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuReportStockBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New FrmReportItemsStocks
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuReportItemsUm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MyDs.Tables("query_items_um").Rows.Clear()
            Dim rpt As New RptItemsUm
            Dim m As New ShowAllReports
            da.SelectCommand = cmd
            cmd.CommandText = "select * from query_items_um order by item_name asc"
            da.Fill(MyDs.Tables("query_items_um"))
            rpt.SetDataSource(MyDs.Tables("query_items_um"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query items um")
        End Try

    End Sub

    Private Sub MenuChangeBillStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuChangeBillStatus.Click
        Dim m As New ChangeBillStatus
        m.MdiParent = Me
        m.Show()
    End Sub

   

   

    Private Sub MenuMoneyPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMoneyPayments.Click
        Dim m As New MoneyPayments
        m.MdiParent = Me
        m.Show()
    End Sub

   

    Private Sub MenuPayAllSalaries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPayAllSalaries.Click
        Panel4.Visible = False
        Panel20.Visible = False
        Dim m As New PayTotalSalary
        m.MdiParent = Me
        m.Show()
    End Sub



    Private Sub MenuMoneyReceivable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMoneyReceivable.Click
        Dim m As New MoneyReceivables
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuMasterRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMasterRecord.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
        Dim m As New MasterRecord
        m.MdiParent = Me
        m.show()
    End Sub

    Private Sub MenuRptCustVenTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New MasterRecordCustomerVendor
        m.MdiParent = Me
        m.show()
    End Sub

    Private Sub MenuBalanceSheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBalanceBook.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
        Dim m As New BalanceBook
        m.MdiParent = Me
        m.show()
    End Sub

    Private Sub MenuDepPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepPro.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
        Dim m As New DepProcedures
        m.MdiParent = Me
        m.show()
    End Sub

    Private Sub MenuVisits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVisits.Click
        Dim m As New VisitHeader
        m.MdiParent = Me
        m.show()
    End Sub

    Private Sub MenuVisitAdjustments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim m As New AdjustmentVisit
        m.MdiParent = Me
        m.show()
    End Sub



    Private Sub MenuProductRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New ProductRange
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuLogistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New Logistics
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuCoeff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New Taxes
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuBalanceSheet_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBalanceSheet.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
        Dim m As New BalanceSheet
        m.MdiParent = Me

        m.show()
    End Sub



    Private Sub MenuMostSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMostSales.Click
        Panel12.Visible = True
        Panel13.Visible = False
        Panel14.Visible = False
    End Sub



    Private Sub Menusalesdaily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menusalesdaily.Click
        Panel12.Visible = False
        Panel13.Visible = True
        Panel14.Visible = False
    End Sub

    Private Sub MostSalesByEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostSalesByEmp.Click
        Panel12.Visible = False
        Panel13.Visible = False
        Panel14.Visible = True
    End Sub






    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Panel15.Visible = True
        Panel4.Visible = False
        Panel20.Visible = False
    End Sub

    Private Sub MenuRewards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRewards.Click

        Panel4.Visible = True
        Panel20.Visible = False
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Panel4.Visible = False

        Panel20.Visible = True
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Panel1.Visible = True
        Panel3.Visible = False

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel10.Visible = True
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
    End Sub

    Private Sub constraint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles constraint.Click
        Panel10.Visible = False
        Panel16.Visible = True
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
    End Sub

    Private Sub Cheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cheques.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = True
        Panel18.Visible = False
        Panel19.Visible = False
    End Sub

    Private Sub Banks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Banks.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = True
        Panel19.Visible = False
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Panel10.Visible = False
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = True
    End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccounting.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = False
        PanelVendor.Visible = False
        PanelStock.Visible = False
        PanelAccounting.Visible = True
        PanelSecurity.Visible = False
        PanelSeeting.Visible = False
        PanelMost.Visible = False
        PanelQuery.Visible = False
        panelReports.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub

    Private Sub MenuPaySalaries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPaySalaries.Click
        Panel4.Visible = False
        Panel20.Visible = False
        Dim m As New PaySalary
        m.MdiParent = Me
        m.Show()
    End Sub



    Private Sub PurchaseBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseBill.Click
        Panel7.Visible = True
    End Sub


    Private Sub SalesOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesOrder.Click
        Panel1.Visible = False
        Panel3.Visible = True
    End Sub


    Private Sub BtnEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmp.Click
        PanelEmployees.Visible = True
        PanelCustomer.Visible = False
        PanelVendor.Visible = False
        PanelStock.Visible = False
        PanelAccounting.Visible = False
        PanelSecurity.Visible = False
        PanelSeeting.Visible = False
        PanelMost.Visible = False
        panelReports.Visible = False
        PanelQuery.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStock.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = False
        PanelVendor.Visible = False
        PanelStock.Visible = True
        PanelAccounting.Visible = False
        PanelSecurity.Visible = False
        PanelSeeting.Visible = False
        panelReports.Visible = False
        PanelMost.Visible = False
        PanelQuery.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCust.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = True
        PanelVendor.Visible = False
        PanelStock.Visible = False
        PanelAccounting.Visible = False
        PanelSecurity.Visible = False
        PanelSeeting.Visible = False
        PanelMost.Visible = False
        panelReports.Visible = False
        PanelQuery.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVendor.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = False
        PanelVendor.Visible = True
        PanelStock.Visible = False
        PanelAccounting.Visible = False
        PanelSecurity.Visible = False
        PanelSeeting.Visible = False
        PanelMost.Visible = False
        panelReports.Visible = False
        PanelQuery.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatistics.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = False
        PanelVendor.Visible = False
        PanelStock.Visible = False
        PanelAccounting.Visible = False
        PanelSecurity.Visible = False
        PanelSeeting.Visible = False
        PanelMost.Visible = True
        panelReports.Visible = False
        PanelQuery.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSettings.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = False
        PanelVendor.Visible = False
        PanelStock.Visible = False
        PanelAccounting.Visible = False
        PanelSecurity.Visible = False
        PanelSeeting.Visible = True
        PanelMost.Visible = False
        panelReports.Visible = False
        PanelQuery.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSecurity.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = False
        PanelVendor.Visible = False
        PanelStock.Visible = False
        PanelAccounting.Visible = False
        PanelSecurity.Visible = True
        PanelSeeting.Visible = False
        PanelMost.Visible = False
        panelReports.Visible = False
        PanelQuery.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub


    Private Sub MunuRptPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MunuRptPurchase.Click
        Dim aa As New ReportPurchaseOrder
        aa.MdiParent = Me
        aa.show()
        Panel2.Visible = False

    End Sub

    Private Sub MenuRptSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptSales.Click
        Dim asd As New ReportSalesOrder
        asd.MdiParent = Me
        asd.Show()

        Panel2.Visible = False
    End Sub



    Private Sub MenuRptCustReturns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptCustReturns.Click
        Dim salah As New ReportCusReturns
        salah.MdiParent = Me
        salah.Show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuRptVendorReturns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptVendorReturns.Click
        Dim salah As New ReportVenReturns
        salah.MdiParent = Me

        salah.Show()
        Panel2.Visible = False

    End Sub

    Private Sub MenuPrintBarcode_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPrintBarcode.Click
        Dim salah As New PrintBarCode
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub


    Private Sub MenuStockTrns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStockTrns.Click
        Dim salah As New FrmInvLog
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuCustTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustTrans.Click
        Dim salah As New FrmCustomerTeansaction
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuVendorTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVendorTrans.Click
        Dim salah As New FrmVendorsTrans
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuSalesDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSalesDetails.Click
        Dim salah As New FrmReportDetailsSales
        salah.MdiParent = Me

        salah.show()

        Panel2.Visible = False
    End Sub

    Private Sub MenuRptUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptUsers.Click
        Dim salah As New ReportUserLog
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuGeneralNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuGeneralNumbers.Click
        Dim salah As New ReportMasterNo
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuCustCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustCommission.Click
        Dim salah As New ReportSalComm
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuRptBanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptBanks.Click
        Dim salah As New ReportBanksBalance
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuRptCheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptCheques.Click
        Dim salah As New QueryCheques
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuRptAccountsBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptAccountsBalance.Click
        Dim salah As New ReportMoneyPayments
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub

    Private Sub MenuRptItemPrices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptItemPrices.Click
        Dim salah As New FrmAllItems
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub


    Private Sub MenuRptFinalBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRptFinalBalance.Click
        Dim salah As New AllBalance
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub




    Private Sub MenuCustVendTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustVendTrans.Click
        Dim salah As New MasterRecordCustomerVendor
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = False
    End Sub



    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim salah As New FrmItemsStocksBalance
        salah.MdiParent = Me

        salah.Show()

        Panel2.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim salah As New FrmReportItemsStocks
        salah.MdiParent = Me

        salah.show()
        Panel2.Visible = True
    End Sub


    Private Sub MeunBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeunBalance.Click
        Panel2.Visible = True
    End Sub

    Private Sub MenuAdjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAdjust.Click
        Panel2.Visible = False
        Dim salah As New ReportAdjustments
        salah.MdiParent = Me

        salah.show()



    End Sub





    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = False
        PanelVendor.Visible = False
        PanelStock.Visible = False
        PanelAccounting.Visible = False
        PanelSecurity.Visible = False
        PanelSeeting.Visible = False
        PanelMost.Visible = False
        panelReports.Visible = True
        PanelQuery.Visible = False
        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub




    Private Sub MenuExpenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExpenses.Click
        Panel10.Visible = True
        Panel16.Visible = False
        Panel17.Visible = False
        Panel18.Visible = False
        Panel19.Visible = False
    End Sub




    Private Sub MenuEndVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEndVisit.Click
        Dim m As New EndVisit
        m.MdiParent = Me

        m.show()
    End Sub

    Private Sub BtnActivatePanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActivatePanel.Click
        PnlSze.Height = 673
        If Panel5.Size.Width = 10 Then
            PnlSze.Width = 239
            Panel5.Size = PnlSze
        Else
            PnlSze.Width = 10
            Panel5.Size = PnlSze
        End If

    End Sub

    'Private Sub BtnActivatePanel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnActivatePanel.MouseEnter
    '    PnlSze.Height = 673
    '    PnlSze.Width = 239
    '    Panel5.Size = PnlSze

    'End Sub

    'Private Sub PanelAll_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave, PanelEmployees.MouseLeave, PanelAccounting.MouseLeave, PanelCustomer.MouseLeave, PanelMost.MouseLeave, panelReports.MouseLeave, PanelSecurity.MouseLeave, PanelSeeting.MouseLeave, PanelStock.MouseLeave, PanelVendor.MouseLeave
    '    PnlSze.Height = 673
    '    PnlSze.Width = 10
    '    Panel5.Size = PnlSze

    'End Sub

    Private Sub ButtonQueryEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQueryEmployee.Click
        PanelQueryEmp.Visible = True
        PanelQueryStocks.Visible = False
        PanelQueryVendor.Visible = False
    End Sub

    Private Sub ButtonQueryStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQueryStocks.Click
        PanelQueryEmp.Visible = False
        PanelQueryStocks.Visible = True
        PanelQueryVendor.Visible = False
    End Sub

    Private Sub ButtonQueryCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQueryCustomers.Click
        Try
            Dim t As New DataTable
            t.Rows.Clear()
            cmd.CommandText = "SELECT CUSTOMER_NAME as 'اسم العميل',Total_Order as 'اجمالي قيمة فواتير المبيعات',Count_Orders as 'عدد الفواتير',Total_Cash as 'اجمالي النقدي',Total_Credit as 'اجمالي الآجل',Count_Items as 'عدد الأصناف في كل الفواتير' FROM Most_Cust_Orders "
            da.SelectCommand = cmd
            da.Fill(t)
            Dim m As New ShowAllQueries
            m.DataGridView1.DataSource = t
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub ButtonQueryVendors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQueryVendors.Click
        PanelQueryEmp.Visible = False
        PanelQueryStocks.Visible = False
        PanelQueryVendor.Visible = True
    End Sub

    Private Sub MenuQueryAttendAbsent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryAttendAbsent.Click
        Dim m As New QueryAttendance
        m.Show()
    End Sub

    Private Sub MenuQueryEmployeesDiscounts_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryEmployeesDiscounts.Click
        Dim m As New QuerEmployeesDiscounts
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryEmployeesRewards_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryEmployeesRewards.Click
        Dim m As New QueryEmployeesRewards
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryEmpGeneral_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryEmpGeneral.Click
        Dim m As New QueryByEmployee
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub QueryEmpByJobID_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryEmpByJobID.Click
        Dim m As New QueryEmpByJobDep
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryStocksByItemName.Click
        Dim m As New QueryAllItem2
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByBarCode_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryStocksByBarCode.Click
        Dim m As New QueryByBarcode
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByCategoryName_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryStocksByCategoryName.Click
        Dim m As New QueryAllItem3
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryStocksByCorporation_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryStocksByCorporation.Click
        Dim m As New QueryAllItems1
        m.MdiParent = Me
        m.Show()
    End Sub


    Private Sub QueryItemsByStock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryItemsByStock.Click
        Dim m As New QueryItemsStocks
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryByBarcode_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryByBarcode.Click
        Dim m As New QueryItemsByBarcode
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryByItemName_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryByItemName.Click
        Dim m As New QueryItemsByStock
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryDepByItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryDepByItemName.Click
        Dim m As New QueryItemsDep
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryDepByStockName_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryDepByStockName.Click
        Dim m As New QueryItemsDep
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuQueryDepByBillID_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryDepByBillID.Click
        Dim m As New QueryItemsDep
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim t As New DataTable
            t.Rows.Clear()
            cmd.CommandText = "SELECT vendor_NAME as 'اسم المورد',Total_Order as 'اجمالي قيمة فواتير المشتريات',Count_Orders as 'عدد الفواتير',Total_Cash as 'اجمالي النقدي',Total_Credit as 'اجمالي الآجل',Count_Items as 'عدد الأصناف في كل الفواتير' FROM Most_Ven_Orders "
            da.SelectCommand = cmd
            da.Fill(t)
            Dim m As New ShowAllQueries
            m.DataGridView1.DataSource = t
            m.MdiParent = Me
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Main Form")
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim m As New QueryItemsVendors
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub Btnqueries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnqueries.Click
        PanelEmployees.Visible = False
        PanelCustomer.Visible = False
        PanelVendor.Visible = False
        PanelStock.Visible = False
        PanelAccounting.Visible = False
        PanelSecurity.Visible = False
        PanelSeeting.Visible = False
        PanelMost.Visible = False
        PanelQuery.Visible = True
        panelReports.Visible = False

        PnlSze.Height = 673
        PnlSze.Width = 239
        Panel5.Size = PnlSze
    End Sub

    Private Sub MenuReportStockValue_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReportStockValue.Click
        Dim m As New ReportStockValue
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuReportItemsUm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReportItemsUm.Click
        Try
            MyDs.Tables("query_items_um").Rows.Clear()
            Dim rpt As New RptItemsUm
            Dim m As New ShowAllReports
            da.SelectCommand = cmd
            cmd.CommandText = "select * from query_items_um order by item_name asc"
            da.Fill(MyDs.Tables("query_items_um"))
            rpt.SetDataSource(MyDs.Tables("query_items_um"))
            m.CrystalReportViewer1.ReportSource = rpt
            m.Show()
        Catch ex As Exception
            cls.WriteError(ex.Message, "Query items um")
        End Try
    End Sub

    Private Sub BtnReportAllTranVenCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReportAllTranVenCust.Click
        Dim m As New ReportAllCustVenTran
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub BtnReportVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReportVisit.Click
        Dim m As New FrmNewVisits
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub BtnALLQueries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnALLQueries.Click
        Dim m As New FrmAllQueries
        m.MdiParent = Me
        m.Show()

    End Sub

    Private Sub BtnTotalurchaseDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTotalurchaseDetails.Click
        Dim m As New FrmReportTotalPurchaseDetails
        m.MdiParent = Me
        m.Show()

    End Sub

    Private Sub BtnTotalSalesDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTotalSalesDetails.Click
        Dim m As New FrmTotalSales
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub BtnRptSalesProfitCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRptSalesProfitCost.Click
        Dim m As New ReportProfitCost
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuFinishVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFinishVisit.Click
        Dim m As New CloseVisit
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub BtnReportVisitDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReportVisitDetails.Click
        Dim m As New FrmTotalVisits
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuOfficialVacations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOfficialVacations.Click
        Dim m As New officialVacations
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub MenuInsurance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuInsurance.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New Insurance
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAttShifts.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New AttendanceShifts
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTasks.Click
        Panel4.Visible = False
        Panel15.Visible = False
        Panel20.Visible = False
        Dim m As New EmployeesTasks
        m.MdiParent = Me
        m.Show()
    End Sub

    Private Sub BtnShiftsDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShiftsDetails.Click
        Dim m As New Shifts_details
        m.MdiParent = Me
        m.Show()
    End Sub
End Class
