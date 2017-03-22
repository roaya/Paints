<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserPreferences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserPreferences))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.SMSURL = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CheckSendSMS = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GenReceiptEmail = New System.Windows.Forms.TextBox()
        Me.GenSenderEmail = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GenSendAction = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GenIsSend = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GenSenderPwd = New System.Windows.Forms.TextBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GenCmbNoBarCodes = New System.Windows.Forms.ComboBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.GenChkItemVendor = New System.Windows.Forms.CheckBox()
        Me.GenChkItemStock = New System.Windows.Forms.CheckBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.GenPhotoDefBackGrd = New System.Windows.Forms.PictureBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.ComboHelpSystem = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GenMainScreen = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GenChkShowMsg = New System.Windows.Forms.CheckBox()
        Me.GenCmbCurrPeriod = New System.Windows.Forms.ComboBox()
        Me.GenChkShowAlert = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CmdPurOrdStyle = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbPurDefStkID = New System.Windows.Forms.ComboBox()
        Me.NumPurNextID = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbPurSchType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumPurDefQty = New System.Windows.Forms.NumericUpDown()
        Me.CmdPurDefFilter = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtSalFooter = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GenCmbPrintType = New System.Windows.Forms.ComboBox()
        Me.GenChkShowBefPrint = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.SalChkShowDate = New System.Windows.Forms.CheckBox()
        Me.SalChkShowEmpID = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CmdSalOrdStyle = New System.Windows.Forms.ComboBox()
        Me.NumSalNextID = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmdSalDefOdrType = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbSalSchType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NumSalDefQty = New System.Windows.Forms.NumericUpDown()
        Me.CmdSalDefFilter = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbRetCusSchType = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NumRetCustDefQty = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumRetCustNextID = New System.Windows.Forms.NumericUpDown()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbRetVenSchType = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NumRetVenDefQty = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NumRetVenNextID = New System.Windows.Forms.NumericUpDown()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbCusReqType = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.NumCustReqDefQty = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.NumCustReqNextID = New System.Windows.Forms.NumericUpDown()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbAdjSchType = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.NumAdjDefQty = New System.Windows.Forms.NumericUpDown()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.NumAdjNextID = New System.Windows.Forms.NumericUpDown()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CmbDepSchType = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.NumDepDefQty = New System.Windows.Forms.NumericUpDown()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.NumDepNextID = New System.Windows.Forms.NumericUpDown()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.P_HeaderReport = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.GenPhotoDefBackGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumPurNextID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumPurDefQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumSalNextID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.NumSalDefQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.NumRetCustDefQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRetCustNextID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.NumRetVenDefQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRetVenNextID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.NumCustReqDefQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCustReqNextID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        CType(Me.NumAdjDefQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAdjNextID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        CType(Me.NumDepDefQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDepNextID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(781, 459)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.GroupBox11)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox15)
        Me.TabPage1.Controls.Add(Me.GroupBox14)
        Me.TabPage1.Controls.Add(Me.GroupBox13)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(773, 433)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "اعدادات عامة"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.SMSURL)
        Me.GroupBox11.Controls.Add(Me.Label36)
        Me.GroupBox11.Controls.Add(Me.CheckSendSMS)
        Me.GroupBox11.Location = New System.Drawing.Point(25, 114)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(354, 90)
        Me.GroupBox11.TabIndex = 112
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "رسائل الموبايل"
        '
        'SMSURL
        '
        Me.SMSURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SMSURL.Location = New System.Drawing.Point(22, 57)
        Me.SMSURL.Name = "SMSURL"
        Me.SMSURL.Size = New System.Drawing.Size(202, 20)
        Me.SMSURL.TabIndex = 129
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(245, 55)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(87, 20)
        Me.Label36.TabIndex = 128
        Me.Label36.Text = "عنوان الرسالة :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckSendSMS
        '
        Me.CheckSendSMS.AutoSize = True
        Me.CheckSendSMS.Location = New System.Drawing.Point(107, 28)
        Me.CheckSendSMS.Name = "CheckSendSMS"
        Me.CheckSendSMS.Size = New System.Drawing.Size(222, 17)
        Me.CheckSendSMS.TabIndex = 116
        Me.CheckSendSMS.Text = "ارسال اجمالي المبيعات عند اغلاق البرنامج"
        Me.CheckSendSMS.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GenReceiptEmail)
        Me.GroupBox8.Controls.Add(Me.GenSenderEmail)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Controls.Add(Me.GenSendAction)
        Me.GroupBox8.Controls.Add(Me.Label33)
        Me.GroupBox8.Controls.Add(Me.GenIsSend)
        Me.GroupBox8.Controls.Add(Me.Label32)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.GenSenderPwd)
        Me.GroupBox8.Location = New System.Drawing.Point(25, 210)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(354, 202)
        Me.GroupBox8.TabIndex = 111
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "التحذيرات و الايميلات"
        '
        'GenReceiptEmail
        '
        Me.GenReceiptEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenReceiptEmail.Location = New System.Drawing.Point(22, 98)
        Me.GenReceiptEmail.Name = "GenReceiptEmail"
        Me.GenReceiptEmail.Size = New System.Drawing.Size(202, 20)
        Me.GenReceiptEmail.TabIndex = 128
        '
        'GenSenderEmail
        '
        Me.GenSenderEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenSenderEmail.Location = New System.Drawing.Point(22, 24)
        Me.GenSenderEmail.Name = "GenSenderEmail"
        Me.GenSenderEmail.Size = New System.Drawing.Size(202, 20)
        Me.GenSenderEmail.TabIndex = 127
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(230, 134)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(102, 20)
        Me.Label34.TabIndex = 126
        Me.Label34.Text = "توقيت الارسال :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenSendAction
        '
        Me.GenSendAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenSendAction.FormattingEnabled = True
        Me.GenSendAction.Items.AddRange(New Object() {"بدء البرنامج", "انتهاء البرنامج"})
        Me.GenSendAction.Location = New System.Drawing.Point(22, 135)
        Me.GenSendAction.Name = "GenSendAction"
        Me.GenSendAction.Size = New System.Drawing.Size(202, 21)
        Me.GenSendAction.TabIndex = 125
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(230, 97)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(102, 20)
        Me.Label33.TabIndex = 124
        Me.Label33.Text = "ايميل المرسل اليه :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenIsSend
        '
        Me.GenIsSend.AutoSize = True
        Me.GenIsSend.Location = New System.Drawing.Point(173, 174)
        Me.GenIsSend.Name = "GenIsSend"
        Me.GenIsSend.Size = New System.Drawing.Size(156, 17)
        Me.GenIsSend.TabIndex = 122
        Me.GenIsSend.Text = "ارسال ايميل بتحذيرات النظام"
        Me.GenIsSend.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(230, 60)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(102, 20)
        Me.Label32.TabIndex = 121
        Me.Label32.Text = "كلمة السر :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(230, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 20)
        Me.Label24.TabIndex = 120
        Me.Label24.Text = "ايميل الراسل :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenSenderPwd
        '
        Me.GenSenderPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenSenderPwd.Location = New System.Drawing.Point(22, 61)
        Me.GenSenderPwd.Name = "GenSenderPwd"
        Me.GenSenderPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.GenSenderPwd.Size = New System.Drawing.Size(202, 20)
        Me.GenSenderPwd.TabIndex = 1
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label21)
        Me.GroupBox15.Controls.Add(Me.GenCmbNoBarCodes)
        Me.GroupBox15.Location = New System.Drawing.Point(385, 341)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(363, 71)
        Me.GroupBox15.TabIndex = 110
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "مقاس طباعة الباركود"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(218, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 20)
        Me.Label21.TabIndex = 119
        Me.Label21.Text = "عدد الأكواد :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenCmbNoBarCodes
        '
        Me.GenCmbNoBarCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenCmbNoBarCodes.FormattingEnabled = True
        Me.GenCmbNoBarCodes.Items.AddRange(New Object() {"96", "48"})
        Me.GenCmbNoBarCodes.Location = New System.Drawing.Point(71, 33)
        Me.GenCmbNoBarCodes.Name = "GenCmbNoBarCodes"
        Me.GenCmbNoBarCodes.Size = New System.Drawing.Size(141, 21)
        Me.GenCmbNoBarCodes.TabIndex = 118
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.GenChkItemVendor)
        Me.GroupBox14.Controls.Add(Me.GenChkItemStock)
        Me.GroupBox14.Location = New System.Drawing.Point(25, 21)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(354, 87)
        Me.GroupBox14.TabIndex = 109
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "اعدادات الأصناف"
        '
        'GenChkItemVendor
        '
        Me.GenChkItemVendor.AutoSize = True
        Me.GenChkItemVendor.Location = New System.Drawing.Point(59, 58)
        Me.GenChkItemVendor.Name = "GenChkItemVendor"
        Me.GenChkItemVendor.Size = New System.Drawing.Size(238, 17)
        Me.GenChkItemVendor.TabIndex = 116
        Me.GenChkItemVendor.Text = "ربط الموردين بكل الأصناف عند اضافة مورد جديد"
        Me.GenChkItemVendor.UseVisualStyleBackColor = True
        '
        'GenChkItemStock
        '
        Me.GenChkItemStock.AutoSize = True
        Me.GenChkItemStock.Location = New System.Drawing.Point(57, 25)
        Me.GenChkItemStock.Name = "GenChkItemStock"
        Me.GenChkItemStock.Size = New System.Drawing.Size(240, 17)
        Me.GenChkItemStock.TabIndex = 115
        Me.GenChkItemStock.Text = "ربط الأصناف بكل المحلات عند اضافة صنف جديد"
        Me.GenChkItemStock.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Panel11)
        Me.GroupBox13.Controls.Add(Me.Panel10)
        Me.GroupBox13.Location = New System.Drawing.Point(385, 21)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(363, 314)
        Me.GroupBox13.TabIndex = 1
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "اعدادات عامة"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.GenPhotoDefBackGrd)
        Me.Panel11.Controls.Add(Me.ToolStrip2)
        Me.Panel11.Location = New System.Drawing.Point(22, 20)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(318, 97)
        Me.Panel11.TabIndex = 108
        '
        'GenPhotoDefBackGrd
        '
        Me.GenPhotoDefBackGrd.BackColor = System.Drawing.Color.Transparent
        Me.GenPhotoDefBackGrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GenPhotoDefBackGrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenPhotoDefBackGrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GenPhotoDefBackGrd.Location = New System.Drawing.Point(24, 0)
        Me.GenPhotoDefBackGrd.Name = "GenPhotoDefBackGrd"
        Me.GenPhotoDefBackGrd.Size = New System.Drawing.Size(290, 93)
        Me.GenPhotoDefBackGrd.TabIndex = 1
        Me.GenPhotoDefBackGrd.TabStop = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(24, 93)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Paints.My.Resources.Resources.Symbol_Add
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "اختر صورة الخلفية"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Paints.My.Resources.Resources.Symbol_Delete
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "الغاء الصورة"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.ComboHelpSystem)
        Me.Panel10.Controls.Add(Me.Label38)
        Me.Panel10.Controls.Add(Me.GenMainScreen)
        Me.Panel10.Controls.Add(Me.Label37)
        Me.Panel10.Controls.Add(Me.GenChkShowMsg)
        Me.Panel10.Controls.Add(Me.GenCmbCurrPeriod)
        Me.Panel10.Controls.Add(Me.GenChkShowAlert)
        Me.Panel10.Controls.Add(Me.Label27)
        Me.Panel10.Location = New System.Drawing.Point(22, 124)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(316, 173)
        Me.Panel10.TabIndex = 107
        '
        'ComboHelpSystem
        '
        Me.ComboHelpSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboHelpSystem.FormattingEnabled = True
        Me.ComboHelpSystem.Items.AddRange(New Object() {"عادية", "صوتية"})
        Me.ComboHelpSystem.Location = New System.Drawing.Point(37, 129)
        Me.ComboHelpSystem.Name = "ComboHelpSystem"
        Me.ComboHelpSystem.Size = New System.Drawing.Size(121, 21)
        Me.ComboHelpSystem.TabIndex = 120
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(161, 132)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(117, 13)
        Me.Label38.TabIndex = 119
        Me.Label38.Text = "النظام العام للمساعدة :"
        '
        'GenMainScreen
        '
        Me.GenMainScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenMainScreen.FormattingEnabled = True
        Me.GenMainScreen.Items.AddRange(New Object() {"قائمة", "تبويبات"})
        Me.GenMainScreen.Location = New System.Drawing.Point(37, 102)
        Me.GenMainScreen.Name = "GenMainScreen"
        Me.GenMainScreen.Size = New System.Drawing.Size(121, 21)
        Me.GenMainScreen.TabIndex = 118
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(159, 105)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(119, 13)
        Me.Label37.TabIndex = 117
        Me.Label37.Text = "نظام الشاشة الرئيسية :"
        '
        'GenChkShowMsg
        '
        Me.GenChkShowMsg.AutoSize = True
        Me.GenChkShowMsg.Location = New System.Drawing.Point(123, 45)
        Me.GenChkShowMsg.Name = "GenChkShowMsg"
        Me.GenChkShowMsg.Size = New System.Drawing.Size(152, 17)
        Me.GenChkShowMsg.TabIndex = 116
        Me.GenChkShowMsg.Text = "عرض رسائل التأكيد و الحفظ"
        Me.GenChkShowMsg.UseVisualStyleBackColor = True
        '
        'GenCmbCurrPeriod
        '
        Me.GenCmbCurrPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenCmbCurrPeriod.FormattingEnabled = True
        Me.GenCmbCurrPeriod.Location = New System.Drawing.Point(37, 74)
        Me.GenCmbCurrPeriod.Name = "GenCmbCurrPeriod"
        Me.GenCmbCurrPeriod.Size = New System.Drawing.Size(164, 21)
        Me.GenCmbCurrPeriod.TabIndex = 115
        '
        'GenChkShowAlert
        '
        Me.GenChkShowAlert.AutoSize = True
        Me.GenChkShowAlert.Location = New System.Drawing.Point(58, 13)
        Me.GenChkShowAlert.Name = "GenChkShowAlert"
        Me.GenChkShowAlert.Size = New System.Drawing.Size(217, 17)
        Me.GenChkShowAlert.TabIndex = 114
        Me.GenChkShowAlert.Text = "عرض شاشة التحذيرات عند الدخول للنظام"
        Me.GenChkShowAlert.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(203, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 13)
        Me.Label27.TabIndex = 107
        Me.Label27.Text = "الوردية الحالية :"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(773, 433)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "فاتورة المشتريات"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 395)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الافتراضية لفواتير المشتريات"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.CmdPurOrdStyle)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CmbPurDefStkID)
        Me.GroupBox2.Controls.Add(Me.NumPurNextID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 351)
        Me.GroupBox2.TabIndex = 121
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "البيانات الأساسية"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(203, 164)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(121, 20)
        Me.Label22.TabIndex = 124
        Me.Label22.Text = "شكل الفاتورة الافتراضي :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdPurOrdStyle
        '
        Me.CmdPurOrdStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmdPurOrdStyle.FormattingEnabled = True
        Me.CmdPurOrdStyle.Items.AddRange(New Object() {"عادية", "فلتر", "مقسمة"})
        Me.CmdPurOrdStyle.Location = New System.Drawing.Point(29, 163)
        Me.CmdPurOrdStyle.Name = "CmdPurOrdStyle"
        Me.CmdPurOrdStyle.Size = New System.Drawing.Size(167, 21)
        Me.CmdPurOrdStyle.TabIndex = 123
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(203, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "المحل الافتراضي :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbPurDefStkID
        '
        Me.CmbPurDefStkID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPurDefStkID.FormattingEnabled = True
        Me.CmbPurDefStkID.Location = New System.Drawing.Point(29, 271)
        Me.CmbPurDefStkID.Name = "CmbPurDefStkID"
        Me.CmbPurDefStkID.Size = New System.Drawing.Size(167, 21)
        Me.CmbPurDefStkID.TabIndex = 121
        '
        'NumPurNextID
        '
        Me.NumPurNextID.Location = New System.Drawing.Point(31, 55)
        Me.NumPurNextID.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.NumPurNextID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumPurNextID.Name = "NumPurNextID"
        Me.NumPurNextID.Size = New System.Drawing.Size(165, 20)
        Me.NumPurNextID.TabIndex = 117
        Me.NumPurNextID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumPurNextID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(203, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "رقم الفاتورة التالي :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CmbPurSchType)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.NumPurDefQty)
        Me.GroupBox3.Controls.Add(Me.CmdPurDefFilter)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 351)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "بيانات الأصناف الافتراضية"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(199, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "البحث بواسطة :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbPurSchType
        '
        Me.CmbPurSchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPurSchType.FormattingEnabled = True
        Me.CmbPurSchType.Items.AddRange(New Object() {"الاسم", "الباركود"})
        Me.CmbPurSchType.Location = New System.Drawing.Point(26, 164)
        Me.CmbPurSchType.Name = "CmbPurSchType"
        Me.CmbPurSchType.Size = New System.Drawing.Size(167, 21)
        Me.CmbPurSchType.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(198, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "الفلترة الافتراضية :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(197, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "العدد الافتراضي :"
        '
        'NumPurDefQty
        '
        Me.NumPurDefQty.Location = New System.Drawing.Point(26, 57)
        Me.NumPurDefQty.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumPurDefQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumPurDefQty.Name = "NumPurDefQty"
        Me.NumPurDefQty.Size = New System.Drawing.Size(167, 20)
        Me.NumPurDefQty.TabIndex = 60
        Me.NumPurDefQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumPurDefQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CmdPurDefFilter
        '
        Me.CmdPurDefFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmdPurDefFilter.FormattingEnabled = True
        Me.CmdPurDefFilter.Items.AddRange(New Object() {"اسم البند", "المقاس", "الشركة", "الفئة", "المورد", "النوع"})
        Me.CmdPurDefFilter.Location = New System.Drawing.Point(25, 272)
        Me.CmdPurDefFilter.Name = "CmdPurDefFilter"
        Me.CmdPurDefFilter.Size = New System.Drawing.Size(167, 21)
        Me.CmdPurDefFilter.TabIndex = 84
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(773, 433)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "فاتورة المبيعات"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox16)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(736, 395)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "البيانات الافتراضية لفواتير المبيعات"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Label35)
        Me.GroupBox16.Controls.Add(Me.TxtSalFooter)
        Me.GroupBox16.Controls.Add(Me.Label16)
        Me.GroupBox16.Controls.Add(Me.GenCmbPrintType)
        Me.GroupBox16.Controls.Add(Me.GenChkShowBefPrint)
        Me.GroupBox16.Location = New System.Drawing.Point(362, 247)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(352, 130)
        Me.GroupBox16.TabIndex = 123
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "طباعة الفواتير"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(240, 95)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 20)
        Me.Label35.TabIndex = 121
        Me.Label35.Text = "خاتمة الفاتورة :"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSalFooter
        '
        Me.TxtSalFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSalFooter.Location = New System.Drawing.Point(28, 95)
        Me.TxtSalFooter.Name = "TxtSalFooter"
        Me.TxtSalFooter.Size = New System.Drawing.Size(210, 20)
        Me.TxtSalFooter.TabIndex = 120
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(240, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 20)
        Me.Label16.TabIndex = 119
        Me.Label16.Text = "طريقة الطباعة :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenCmbPrintType
        '
        Me.GenCmbPrintType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenCmbPrintType.FormattingEnabled = True
        Me.GenCmbPrintType.Items.AddRange(New Object() {"شيك", "طباعة عادية"})
        Me.GenCmbPrintType.Location = New System.Drawing.Point(28, 58)
        Me.GenCmbPrintType.Name = "GenCmbPrintType"
        Me.GenCmbPrintType.Size = New System.Drawing.Size(210, 21)
        Me.GenCmbPrintType.TabIndex = 118
        '
        'GenChkShowBefPrint
        '
        Me.GenChkShowBefPrint.AutoSize = True
        Me.GenChkShowBefPrint.Location = New System.Drawing.Point(178, 24)
        Me.GenChkShowBefPrint.Name = "GenChkShowBefPrint"
        Me.GenChkShowBefPrint.Size = New System.Drawing.Size(143, 17)
        Me.GenChkShowBefPrint.TabIndex = 117
        Me.GenChkShowBefPrint.Text = "عرض الفاتورة قبل الطباعة"
        Me.GenChkShowBefPrint.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.SalChkShowDate)
        Me.GroupBox7.Controls.Add(Me.SalChkShowEmpID)
        Me.GroupBox7.Location = New System.Drawing.Point(22, 247)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(321, 130)
        Me.GroupBox7.TabIndex = 122
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "بيانات اخري"
        '
        'SalChkShowDate
        '
        Me.SalChkShowDate.AutoSize = True
        Me.SalChkShowDate.Location = New System.Drawing.Point(87, 81)
        Me.SalChkShowDate.Name = "SalChkShowDate"
        Me.SalChkShowDate.Size = New System.Drawing.Size(178, 17)
        Me.SalChkShowDate.TabIndex = 120
        Me.SalChkShowDate.Text = "تعديل التاريخ علي فاتورة المبيعات"
        Me.SalChkShowDate.UseVisualStyleBackColor = True
        '
        'SalChkShowEmpID
        '
        Me.SalChkShowEmpID.AutoSize = True
        Me.SalChkShowEmpID.Location = New System.Drawing.Point(55, 38)
        Me.SalChkShowEmpID.Name = "SalChkShowEmpID"
        Me.SalChkShowEmpID.Size = New System.Drawing.Size(210, 17)
        Me.SalChkShowEmpID.TabIndex = 119
        Me.SalChkShowEmpID.Text = "تعديل اسم الموظف علي فاتورة المبيعات"
        Me.SalChkShowEmpID.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.CmdSalOrdStyle)
        Me.GroupBox5.Controls.Add(Me.NumSalNextID)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.CmdSalDefOdrType)
        Me.GroupBox5.Location = New System.Drawing.Point(362, 26)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(352, 215)
        Me.GroupBox5.TabIndex = 121
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "البيانات الأساسية"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(199, 97)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(127, 20)
        Me.Label23.TabIndex = 120
        Me.Label23.Text = "شكل الفاتورة الافتراضي :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdSalOrdStyle
        '
        Me.CmdSalOrdStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmdSalOrdStyle.FormattingEnabled = True
        Me.CmdSalOrdStyle.Items.AddRange(New Object() {"مبسطه", "تفصيليه"})
        Me.CmdSalOrdStyle.Location = New System.Drawing.Point(27, 97)
        Me.CmdSalOrdStyle.Name = "CmdSalOrdStyle"
        Me.CmdSalOrdStyle.Size = New System.Drawing.Size(165, 21)
        Me.CmdSalOrdStyle.TabIndex = 119
        '
        'NumSalNextID
        '
        Me.NumSalNextID.Location = New System.Drawing.Point(27, 38)
        Me.NumSalNextID.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumSalNextID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumSalNextID.Name = "NumSalNextID"
        Me.NumSalNextID.Size = New System.Drawing.Size(165, 20)
        Me.NumSalNextID.TabIndex = 117
        Me.NumSalNextID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumSalNextID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(199, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 20)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "رقم الفاتورة التالي :"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(198, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 20)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "نوع الفاتورة الافتراضي :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdSalDefOdrType
        '
        Me.CmdSalDefOdrType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmdSalDefOdrType.FormattingEnabled = True
        Me.CmdSalDefOdrType.Items.AddRange(New Object() {"جملة", "قطاعي"})
        Me.CmdSalDefOdrType.Location = New System.Drawing.Point(27, 165)
        Me.CmdSalDefOdrType.Name = "CmdSalDefOdrType"
        Me.CmdSalDefOdrType.Size = New System.Drawing.Size(165, 21)
        Me.CmdSalDefOdrType.TabIndex = 116
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.CmbSalSchType)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.NumSalDefQty)
        Me.GroupBox6.Controls.Add(Me.CmdSalDefFilter)
        Me.GroupBox6.Location = New System.Drawing.Point(22, 26)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(321, 215)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "بيانات الأصناف الافتراضية"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(198, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "البحث بواسطة :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbSalSchType
        '
        Me.CmbSalSchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSalSchType.FormattingEnabled = True
        Me.CmbSalSchType.Items.AddRange(New Object() {"الاسم", "الباركود"})
        Me.CmbSalSchType.Location = New System.Drawing.Point(25, 97)
        Me.CmbSalSchType.Name = "CmbSalSchType"
        Me.CmbSalSchType.Size = New System.Drawing.Size(167, 21)
        Me.CmbSalSchType.TabIndex = 118
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(199, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 20)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "الفلترة الافتراضية :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(197, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 20)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "العدد الافتراضي :"
        '
        'NumSalDefQty
        '
        Me.NumSalDefQty.Location = New System.Drawing.Point(26, 38)
        Me.NumSalDefQty.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumSalDefQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumSalDefQty.Name = "NumSalDefQty"
        Me.NumSalDefQty.Size = New System.Drawing.Size(167, 20)
        Me.NumSalDefQty.TabIndex = 60
        Me.NumSalDefQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumSalDefQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CmdSalDefFilter
        '
        Me.CmdSalDefFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmdSalDefFilter.FormattingEnabled = True
        Me.CmdSalDefFilter.Items.AddRange(New Object() {"اسم البند", "المقاس", "الشركة", "الفئة", "المورد", "النوع"})
        Me.CmdSalDefFilter.Location = New System.Drawing.Point(26, 165)
        Me.CmdSalDefFilter.Name = "CmdSalDefFilter"
        Me.CmdSalDefFilter.Size = New System.Drawing.Size(167, 21)
        Me.CmdSalDefFilter.TabIndex = 84
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage4.Controls.Add(Me.GroupBox10)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(773, 433)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "مرتجع العملاء"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label5)
        Me.GroupBox10.Controls.Add(Me.CmbRetCusSchType)
        Me.GroupBox10.Controls.Add(Me.Label17)
        Me.GroupBox10.Controls.Add(Me.NumRetCustDefQty)
        Me.GroupBox10.Controls.Add(Me.Label18)
        Me.GroupBox10.Controls.Add(Me.NumRetCustNextID)
        Me.GroupBox10.Location = New System.Drawing.Point(191, 53)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(390, 327)
        Me.GroupBox10.TabIndex = 6
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "البيانات الافتراضية"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(223, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "البحث بواسطة :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbRetCusSchType
        '
        Me.CmbRetCusSchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRetCusSchType.FormattingEnabled = True
        Me.CmbRetCusSchType.Items.AddRange(New Object() {"الاسم", "الباركود"})
        Me.CmbRetCusSchType.Location = New System.Drawing.Point(50, 243)
        Me.CmbRetCusSchType.Name = "CmbRetCusSchType"
        Me.CmbRetCusSchType.Size = New System.Drawing.Size(167, 21)
        Me.CmbRetCusSchType.TabIndex = 118
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(223, 153)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 20)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "العدد الافتراضي :"
        '
        'NumRetCustDefQty
        '
        Me.NumRetCustDefQty.Location = New System.Drawing.Point(50, 153)
        Me.NumRetCustDefQty.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.NumRetCustDefQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumRetCustDefQty.Name = "NumRetCustDefQty"
        Me.NumRetCustDefQty.Size = New System.Drawing.Size(167, 20)
        Me.NumRetCustDefQty.TabIndex = 115
        Me.NumRetCustDefQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumRetCustDefQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(224, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 20)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "رقم اذن ارتجاع العميل : :"
        '
        'NumRetCustNextID
        '
        Me.NumRetCustNextID.Location = New System.Drawing.Point(50, 63)
        Me.NumRetCustNextID.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumRetCustNextID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumRetCustNextID.Name = "NumRetCustNextID"
        Me.NumRetCustNextID.Size = New System.Drawing.Size(167, 20)
        Me.NumRetCustNextID.TabIndex = 60
        Me.NumRetCustNextID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumRetCustNextID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage5.Controls.Add(Me.GroupBox9)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(773, 433)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "مرتجع الموردين"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Controls.Add(Me.CmbRetVenSchType)
        Me.GroupBox9.Controls.Add(Me.Label19)
        Me.GroupBox9.Controls.Add(Me.NumRetVenDefQty)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.NumRetVenNextID)
        Me.GroupBox9.Location = New System.Drawing.Point(191, 53)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(390, 327)
        Me.GroupBox9.TabIndex = 7
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "البيانات الافتراضية"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(240, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "البحث بواسطة :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbRetVenSchType
        '
        Me.CmbRetVenSchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRetVenSchType.FormattingEnabled = True
        Me.CmbRetVenSchType.Items.AddRange(New Object() {"الاسم", "الباركود"})
        Me.CmbRetVenSchType.Location = New System.Drawing.Point(50, 236)
        Me.CmbRetVenSchType.Name = "CmbRetVenSchType"
        Me.CmbRetVenSchType.Size = New System.Drawing.Size(167, 21)
        Me.CmbRetVenSchType.TabIndex = 118
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(220, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 20)
        Me.Label19.TabIndex = 116
        Me.Label19.Text = "العدد الافتراضي :"
        '
        'NumRetVenDefQty
        '
        Me.NumRetVenDefQty.Location = New System.Drawing.Point(50, 145)
        Me.NumRetVenDefQty.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.NumRetVenDefQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumRetVenDefQty.Name = "NumRetVenDefQty"
        Me.NumRetVenDefQty.Size = New System.Drawing.Size(167, 20)
        Me.NumRetVenDefQty.TabIndex = 115
        Me.NumRetVenDefQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumRetVenDefQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(221, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 20)
        Me.Label20.TabIndex = 114
        Me.Label20.Text = "رقم اذن ارتجاع المورد :"
        '
        'NumRetVenNextID
        '
        Me.NumRetVenNextID.Location = New System.Drawing.Point(50, 69)
        Me.NumRetVenNextID.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumRetVenNextID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumRetVenNextID.Name = "NumRetVenNextID"
        Me.NumRetVenNextID.Size = New System.Drawing.Size(167, 20)
        Me.NumRetVenNextID.TabIndex = 60
        Me.NumRetVenNextID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumRetVenNextID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage6.Controls.Add(Me.GroupBox17)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(773, 433)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "أمر حجز عميل"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.Label9)
        Me.GroupBox17.Controls.Add(Me.CmbCusReqType)
        Me.GroupBox17.Controls.Add(Me.Label25)
        Me.GroupBox17.Controls.Add(Me.NumCustReqDefQty)
        Me.GroupBox17.Controls.Add(Me.Label28)
        Me.GroupBox17.Controls.Add(Me.NumCustReqNextID)
        Me.GroupBox17.Location = New System.Drawing.Point(191, 53)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(390, 327)
        Me.GroupBox17.TabIndex = 2
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "البيانات الافتراضية"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(223, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 20)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "البحث بواسطة :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbCusReqType
        '
        Me.CmbCusReqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCusReqType.FormattingEnabled = True
        Me.CmbCusReqType.Items.AddRange(New Object() {"الاسم", "الباركود"})
        Me.CmbCusReqType.Location = New System.Drawing.Point(50, 231)
        Me.CmbCusReqType.Name = "CmbCusReqType"
        Me.CmbCusReqType.Size = New System.Drawing.Size(167, 21)
        Me.CmbCusReqType.TabIndex = 118
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(223, 127)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 20)
        Me.Label25.TabIndex = 116
        Me.Label25.Text = "العدد الافتراضي :"
        '
        'NumCustReqDefQty
        '
        Me.NumCustReqDefQty.Location = New System.Drawing.Point(50, 127)
        Me.NumCustReqDefQty.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.NumCustReqDefQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumCustReqDefQty.Name = "NumCustReqDefQty"
        Me.NumCustReqDefQty.Size = New System.Drawing.Size(167, 20)
        Me.NumCustReqDefQty.TabIndex = 115
        Me.NumCustReqDefQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumCustReqDefQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(224, 51)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(116, 20)
        Me.Label28.TabIndex = 114
        Me.Label28.Text = "رقم أمر الحجز التالي :"
        '
        'NumCustReqNextID
        '
        Me.NumCustReqNextID.Location = New System.Drawing.Point(50, 51)
        Me.NumCustReqNextID.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.NumCustReqNextID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumCustReqNextID.Name = "NumCustReqNextID"
        Me.NumCustReqNextID.Size = New System.Drawing.Size(167, 20)
        Me.NumCustReqNextID.TabIndex = 60
        Me.NumCustReqNextID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumCustReqNextID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage7.Controls.Add(Me.GroupBox19)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(773, 433)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "اذن تحويل رصيد"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.Label10)
        Me.GroupBox19.Controls.Add(Me.CmbAdjSchType)
        Me.GroupBox19.Controls.Add(Me.Label26)
        Me.GroupBox19.Controls.Add(Me.NumAdjDefQty)
        Me.GroupBox19.Controls.Add(Me.Label29)
        Me.GroupBox19.Controls.Add(Me.NumAdjNextID)
        Me.GroupBox19.Location = New System.Drawing.Point(191, 53)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(390, 327)
        Me.GroupBox19.TabIndex = 3
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "البيانات الافتراضية"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(223, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 20)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "البحث بواسطة :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbAdjSchType
        '
        Me.CmbAdjSchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAdjSchType.FormattingEnabled = True
        Me.CmbAdjSchType.Items.AddRange(New Object() {"الاسم", "الباركود"})
        Me.CmbAdjSchType.Location = New System.Drawing.Point(50, 243)
        Me.CmbAdjSchType.Name = "CmbAdjSchType"
        Me.CmbAdjSchType.Size = New System.Drawing.Size(167, 21)
        Me.CmbAdjSchType.TabIndex = 118
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(223, 153)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 20)
        Me.Label26.TabIndex = 116
        Me.Label26.Text = "العدد الافتراضي :"
        '
        'NumAdjDefQty
        '
        Me.NumAdjDefQty.Location = New System.Drawing.Point(50, 153)
        Me.NumAdjDefQty.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.NumAdjDefQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumAdjDefQty.Name = "NumAdjDefQty"
        Me.NumAdjDefQty.Size = New System.Drawing.Size(167, 20)
        Me.NumAdjDefQty.TabIndex = 115
        Me.NumAdjDefQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumAdjDefQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(224, 63)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(116, 20)
        Me.Label29.TabIndex = 114
        Me.Label29.Text = "رقم اذن التحويل التالي :"
        '
        'NumAdjNextID
        '
        Me.NumAdjNextID.Location = New System.Drawing.Point(50, 63)
        Me.NumAdjNextID.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumAdjNextID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumAdjNextID.Name = "NumAdjNextID"
        Me.NumAdjNextID.Size = New System.Drawing.Size(167, 20)
        Me.NumAdjNextID.TabIndex = 60
        Me.NumAdjNextID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumAdjNextID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage8.Controls.Add(Me.GroupBox21)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(773, 433)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "أمر الاهلاك"
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.Label15)
        Me.GroupBox21.Controls.Add(Me.CmbDepSchType)
        Me.GroupBox21.Controls.Add(Me.Label30)
        Me.GroupBox21.Controls.Add(Me.NumDepDefQty)
        Me.GroupBox21.Controls.Add(Me.Label31)
        Me.GroupBox21.Controls.Add(Me.NumDepNextID)
        Me.GroupBox21.Location = New System.Drawing.Point(191, 53)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(390, 327)
        Me.GroupBox21.TabIndex = 3
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "البيانات الافتراضية"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(243, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 20)
        Me.Label15.TabIndex = 119
        Me.Label15.Text = "البحث بواسطة :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbDepSchType
        '
        Me.CmbDepSchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDepSchType.FormattingEnabled = True
        Me.CmbDepSchType.Items.AddRange(New Object() {"الاسم", "الباركود"})
        Me.CmbDepSchType.Location = New System.Drawing.Point(50, 243)
        Me.CmbDepSchType.Name = "CmbDepSchType"
        Me.CmbDepSchType.Size = New System.Drawing.Size(167, 21)
        Me.CmbDepSchType.TabIndex = 118
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(223, 155)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(117, 20)
        Me.Label30.TabIndex = 116
        Me.Label30.Text = "العدد الافتراضي :"
        '
        'NumDepDefQty
        '
        Me.NumDepDefQty.Location = New System.Drawing.Point(50, 153)
        Me.NumDepDefQty.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.NumDepDefQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumDepDefQty.Name = "NumDepDefQty"
        Me.NumDepDefQty.Size = New System.Drawing.Size(167, 20)
        Me.NumDepDefQty.TabIndex = 115
        Me.NumDepDefQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumDepDefQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(233, 63)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(116, 20)
        Me.Label31.TabIndex = 114
        Me.Label31.Text = "رقم أمر الاهلاك التالي :"
        '
        'NumDepNextID
        '
        Me.NumDepNextID.Location = New System.Drawing.Point(50, 63)
        Me.NumDepNextID.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumDepNextID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumDepNextID.Name = "NumDepNextID"
        Me.NumDepNextID.Size = New System.Drawing.Size(167, 20)
        Me.NumDepNextID.TabIndex = 60
        Me.NumDepNextID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumDepNextID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(923, 461)
        Me.SplitContainer1.SplitterDistance = 783
        Me.SplitContainer1.TabIndex = 1
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(3, 410)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(129, 39)
        Me.Button12.TabIndex = 109
        Me.Button12.Text = "الوضع الافتراضي"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(3, 360)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(129, 39)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "أمر الاهلاك"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(3, 310)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(129, 39)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "اذن تحويل رصيد"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(3, 260)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(129, 39)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "أمر حجز عميل"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(3, 210)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(129, 39)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "مرتجع الموردين"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(3, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 39)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "مرتجع العملاء"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(3, 110)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 39)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "فاتورة المبيعات"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "فاتورة المشتريات"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "اعدادات عامة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(595, 467)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(168, 38)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "الغاء"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(377, 467)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(168, 38)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "تطبيق"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(159, 467)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(168, 38)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "موافق"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.Label39)
        Me.TabPage9.Controls.Add(Me.P_HeaderReport)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(773, 433)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "مقدمة التقارير"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'P_HeaderReport
        '
        Me.P_HeaderReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_HeaderReport.Location = New System.Drawing.Point(155, 93)
        Me.P_HeaderReport.Multiline = True
        Me.P_HeaderReport.Name = "P_HeaderReport"
        Me.P_HeaderReport.Size = New System.Drawing.Size(463, 284)
        Me.P_HeaderReport.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(505, 70)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(116, 20)
        Me.Label39.TabIndex = 115
        Me.Label39.Text = "نص مقدمة التقرير :"
        '
        'FrmUserPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 506)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUserPreferences"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اعدادات النظام"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.GenPhotoDefBackGrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NumPurNextID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NumPurDefQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.NumSalNextID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.NumSalDefQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.NumRetCustDefQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRetCustNextID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.NumRetVenDefQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRetVenNextID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        CType(Me.NumCustReqDefQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCustReqNextID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        CType(Me.NumAdjDefQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAdjNextID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        CType(Me.NumDepDefQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDepNextID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumPurDefQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdPurDefFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents GenChkItemVendor As System.Windows.Forms.CheckBox
    Friend WithEvents GenChkItemStock As System.Windows.Forms.CheckBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GenPhotoDefBackGrd As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GenCmbCurrPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents GenChkShowAlert As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents NumCustReqDefQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents NumCustReqNextID As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents NumAdjDefQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents NumAdjNextID As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents NumDepDefQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents NumDepNextID As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NumRetCustDefQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents NumRetCustNextID As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents NumRetVenDefQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents NumRetVenNextID As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbPurDefStkID As System.Windows.Forms.ComboBox
    Friend WithEvents NumPurNextID As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents NumSalNextID As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmdSalDefOdrType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NumSalDefQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents CmdSalDefFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents SalChkShowDate As System.Windows.Forms.CheckBox
    Friend WithEvents SalChkShowEmpID As System.Windows.Forms.CheckBox
    Friend WithEvents GenChkShowMsg As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GenCmbNoBarCodes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbPurSchType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbSalSchType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbRetCusSchType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbRetVenSchType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbCusReqType As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CmbAdjSchType As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CmbDepSchType As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmdPurOrdStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CmdSalOrdStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GenIsSend As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GenSenderPwd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GenCmbPrintType As System.Windows.Forms.ComboBox
    Friend WithEvents GenChkShowBefPrint As System.Windows.Forms.CheckBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GenSendAction As System.Windows.Forms.ComboBox
    Friend WithEvents GenReceiptEmail As System.Windows.Forms.TextBox
    Friend WithEvents GenSenderEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TxtSalFooter As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents SMSURL As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CheckSendSMS As System.Windows.Forms.CheckBox
    Friend WithEvents GenMainScreen As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents ComboHelpSystem As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents P_HeaderReport As System.Windows.Forms.TextBox
End Class
