<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTotalVisits
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RadAllCustomer = New System.Windows.Forms.RadioButton()
        Me.RadCustomer = New System.Windows.Forms.RadioButton()
        Me.CombCustomer = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.combSalesRep = New System.Windows.Forms.ComboBox()
        Me.RadSalesRep = New System.Windows.Forms.RadioButton()
        Me.combvisits = New System.Windows.Forms.ComboBox()
        Me.Radvisits = New System.Windows.Forms.RadioButton()
        Me.RadAllCheques = New System.Windows.Forms.RadioButton()
        Me.RadAllBills = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RadDesrevedBill = New System.Windows.Forms.RadioButton()
        Me.NumTotalBill = New System.Windows.Forms.NumericUpDown()
        Me.RadDeservedCheques = New System.Windows.Forms.RadioButton()
        Me.RadTotalBillBetween = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CombCheques = New System.Windows.Forms.ComboBox()
        Me.RadMAxTBill = New System.Windows.Forms.RadioButton()
        Me.RadChequeNumber = New System.Windows.Forms.RadioButton()
        Me.combBillId = New System.Windows.Forms.ComboBox()
        Me.RadBillByDate = New System.Windows.Forms.RadioButton()
        Me.RadBillID = New System.Windows.Forms.RadioButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.VisitName = New System.Windows.Forms.CheckBox()
        Me.SalesRepName = New System.Windows.Forms.CheckBox()
        Me.BillTime = New System.Windows.Forms.CheckBox()
        Me.ChequeNumber = New System.Windows.Forms.CheckBox()
        Me.RecieveDate = New System.Windows.Forms.CheckBox()
        Me.EmployeeName = New System.Windows.Forms.CheckBox()
        Me.VisaNumber = New System.Windows.Forms.CheckBox()
        Me.TotalCredit = New System.Windows.Forms.CheckBox()
        Me.TotalCash = New System.Windows.Forms.CheckBox()
        Me.BillID = New System.Windows.Forms.CheckBox()
        Me.BillDate = New System.Windows.Forms.CheckBox()
        Me.BillStatus = New System.Windows.Forms.CheckBox()
        Me.TotalBill = New System.Windows.Forms.CheckBox()
        Me.BillType = New System.Windows.Forms.CheckBox()
        Me.CustomerName = New System.Windows.Forms.CheckBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.NumTotalBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.RightToLeftLayout = True
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1284, 742)
        Me.TabControl2.TabIndex = 19
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TabControl3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1276, 716)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "تقرير تفصيلى"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 3)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.RightToLeftLayout = True
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1270, 710)
        Me.TabControl3.TabIndex = 19
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Controls.Add(Me.DataGridView2)
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1262, 684)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "الاستعلام"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(290, 645)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 38)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "الذهاب للتقرير"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.Paints.My.Resources.Resources.enter_screen
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(575, 425)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(764, 262)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "معاملات التقرير"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RadAllCustomer)
        Me.GroupBox7.Controls.Add(Me.RadCustomer)
        Me.GroupBox7.Controls.Add(Me.CombCustomer)
        Me.GroupBox7.Location = New System.Drawing.Point(527, 13)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(224, 100)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "بيانات العملاء"
        '
        'RadAllCustomer
        '
        Me.RadAllCustomer.AutoSize = True
        Me.RadAllCustomer.Checked = True
        Me.RadAllCustomer.Location = New System.Drawing.Point(135, 23)
        Me.RadAllCustomer.Name = "RadAllCustomer"
        Me.RadAllCustomer.Size = New System.Drawing.Size(83, 17)
        Me.RadAllCustomer.TabIndex = 21
        Me.RadAllCustomer.TabStop = True
        Me.RadAllCustomer.Text = "جميع العملاء"
        Me.RadAllCustomer.UseVisualStyleBackColor = True
        '
        'RadCustomer
        '
        Me.RadCustomer.AutoSize = True
        Me.RadCustomer.Location = New System.Drawing.Point(134, 64)
        Me.RadCustomer.Name = "RadCustomer"
        Me.RadCustomer.Size = New System.Drawing.Size(84, 17)
        Me.RadCustomer.TabIndex = 20
        Me.RadCustomer.Text = " اسم العميل"
        Me.RadCustomer.UseVisualStyleBackColor = True
        '
        'CombCustomer
        '
        Me.CombCustomer.FormattingEnabled = True
        Me.CombCustomer.Location = New System.Drawing.Point(13, 63)
        Me.CombCustomer.Name = "CombCustomer"
        Me.CombCustomer.Size = New System.Drawing.Size(115, 21)
        Me.CombCustomer.TabIndex = 19
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.combSalesRep)
        Me.GroupBox6.Controls.Add(Me.RadSalesRep)
        Me.GroupBox6.Controls.Add(Me.combvisits)
        Me.GroupBox6.Controls.Add(Me.Radvisits)
        Me.GroupBox6.Controls.Add(Me.RadAllCheques)
        Me.GroupBox6.Controls.Add(Me.RadAllBills)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.RadDesrevedBill)
        Me.GroupBox6.Controls.Add(Me.NumTotalBill)
        Me.GroupBox6.Controls.Add(Me.RadDeservedCheques)
        Me.GroupBox6.Controls.Add(Me.RadTotalBillBetween)
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Controls.Add(Me.CombCheques)
        Me.GroupBox6.Controls.Add(Me.RadMAxTBill)
        Me.GroupBox6.Controls.Add(Me.RadChequeNumber)
        Me.GroupBox6.Controls.Add(Me.combBillId)
        Me.GroupBox6.Controls.Add(Me.RadBillByDate)
        Me.GroupBox6.Controls.Add(Me.RadBillID)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(518, 244)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "البيانات التفصيليه"
        '
        'combSalesRep
        '
        Me.combSalesRep.Enabled = False
        Me.combSalesRep.FormattingEnabled = True
        Me.combSalesRep.Location = New System.Drawing.Point(40, 120)
        Me.combSalesRep.Name = "combSalesRep"
        Me.combSalesRep.Size = New System.Drawing.Size(115, 21)
        Me.combSalesRep.TabIndex = 80
        '
        'RadSalesRep
        '
        Me.RadSalesRep.AutoSize = True
        Me.RadSalesRep.BackColor = System.Drawing.Color.Transparent
        Me.RadSalesRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadSalesRep.Location = New System.Drawing.Point(170, 123)
        Me.RadSalesRep.Name = "RadSalesRep"
        Me.RadSalesRep.Size = New System.Drawing.Size(90, 17)
        Me.RadSalesRep.TabIndex = 79
        Me.RadSalesRep.Text = " اسم المندوب"
        Me.RadSalesRep.UseVisualStyleBackColor = False
        '
        'combvisits
        '
        Me.combvisits.Enabled = False
        Me.combvisits.FormattingEnabled = True
        Me.combvisits.Location = New System.Drawing.Point(289, 119)
        Me.combvisits.Name = "combvisits"
        Me.combvisits.Size = New System.Drawing.Size(133, 21)
        Me.combvisits.TabIndex = 78
        '
        'Radvisits
        '
        Me.Radvisits.AutoSize = True
        Me.Radvisits.BackColor = System.Drawing.Color.Transparent
        Me.Radvisits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Radvisits.Location = New System.Drawing.Point(430, 120)
        Me.Radvisits.Name = "Radvisits"
        Me.Radvisits.Size = New System.Drawing.Size(77, 17)
        Me.Radvisits.TabIndex = 77
        Me.Radvisits.Text = "اسم الجوله"
        Me.Radvisits.UseVisualStyleBackColor = False
        '
        'RadAllCheques
        '
        Me.RadAllCheques.AutoSize = True
        Me.RadAllCheques.BackColor = System.Drawing.Color.Transparent
        Me.RadAllCheques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadAllCheques.Location = New System.Drawing.Point(424, 85)
        Me.RadAllCheques.Name = "RadAllCheques"
        Me.RadAllCheques.Size = New System.Drawing.Size(84, 17)
        Me.RadAllCheques.TabIndex = 67
        Me.RadAllCheques.Text = " كل الشيكات"
        Me.RadAllCheques.UseVisualStyleBackColor = False
        '
        'RadAllBills
        '
        Me.RadAllBills.AutoSize = True
        Me.RadAllBills.BackColor = System.Drawing.Color.Transparent
        Me.RadAllBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadAllBills.Checked = True
        Me.RadAllBills.Location = New System.Drawing.Point(434, 21)
        Me.RadAllBills.Name = "RadAllBills"
        Me.RadAllBills.Size = New System.Drawing.Size(73, 17)
        Me.RadAllBills.TabIndex = 66
        Me.RadAllBills.TabStop = True
        Me.RadAllBills.Text = "كل الفواتير"
        Me.RadAllBills.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(197, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 38)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "استعلام"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RadDesrevedBill
        '
        Me.RadDesrevedBill.AutoSize = True
        Me.RadDesrevedBill.Location = New System.Drawing.Point(400, 51)
        Me.RadDesrevedBill.Name = "RadDesrevedBill"
        Me.RadDesrevedBill.Size = New System.Drawing.Size(108, 17)
        Me.RadDesrevedBill.TabIndex = 65
        Me.RadDesrevedBill.TabStop = True
        Me.RadDesrevedBill.Text = "الفواتير المستحقه"
        Me.RadDesrevedBill.UseVisualStyleBackColor = True
        '
        'NumTotalBill
        '
        Me.NumTotalBill.Enabled = False
        Me.NumTotalBill.Location = New System.Drawing.Point(29, 57)
        Me.NumTotalBill.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.NumTotalBill.Name = "NumTotalBill"
        Me.NumTotalBill.Size = New System.Drawing.Size(115, 20)
        Me.NumTotalBill.TabIndex = 18
        Me.NumTotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadDeservedCheques
        '
        Me.RadDeservedCheques.AutoSize = True
        Me.RadDeservedCheques.Location = New System.Drawing.Point(275, 53)
        Me.RadDeservedCheques.Name = "RadDeservedCheques"
        Me.RadDeservedCheques.Size = New System.Drawing.Size(119, 17)
        Me.RadDeservedCheques.TabIndex = 64
        Me.RadDeservedCheques.TabStop = True
        Me.RadDeservedCheques.Text = " الشيكات المستحقه"
        Me.RadDeservedCheques.UseVisualStyleBackColor = True
        '
        'RadTotalBillBetween
        '
        Me.RadTotalBillBetween.AutoSize = True
        Me.RadTotalBillBetween.BackColor = System.Drawing.Color.Transparent
        Me.RadTotalBillBetween.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadTotalBillBetween.Location = New System.Drawing.Point(150, 55)
        Me.RadTotalBillBetween.Name = "RadTotalBillBetween"
        Me.RadTotalBillBetween.Size = New System.Drawing.Size(124, 17)
        Me.RadTotalBillBetween.TabIndex = 10
        Me.RadTotalBillBetween.Text = "اجمالى فواتير اكبر من"
        Me.RadTotalBillBetween.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 146)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(421, 46)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "من :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(25, 13)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(108, 20)
        Me.DateTimePicker2.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "الي :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(231, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(108, 20)
        Me.DateTimePicker1.TabIndex = 56
        '
        'CombCheques
        '
        Me.CombCheques.Enabled = False
        Me.CombCheques.FormattingEnabled = True
        Me.CombCheques.Location = New System.Drawing.Point(182, 84)
        Me.CombCheques.Name = "CombCheques"
        Me.CombCheques.Size = New System.Drawing.Size(115, 21)
        Me.CombCheques.TabIndex = 63
        '
        'RadMAxTBill
        '
        Me.RadMAxTBill.AutoSize = True
        Me.RadMAxTBill.BackColor = System.Drawing.Color.Transparent
        Me.RadMAxTBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadMAxTBill.Location = New System.Drawing.Point(316, 22)
        Me.RadMAxTBill.Name = "RadMAxTBill"
        Me.RadMAxTBill.Size = New System.Drawing.Size(78, 17)
        Me.RadMAxTBill.TabIndex = 19
        Me.RadMAxTBill.Text = "اعلى فاتوره"
        Me.RadMAxTBill.UseVisualStyleBackColor = False
        '
        'RadChequeNumber
        '
        Me.RadChequeNumber.AutoSize = True
        Me.RadChequeNumber.Location = New System.Drawing.Point(315, 85)
        Me.RadChequeNumber.Name = "RadChequeNumber"
        Me.RadChequeNumber.Size = New System.Drawing.Size(79, 17)
        Me.RadChequeNumber.TabIndex = 62
        Me.RadChequeNumber.TabStop = True
        Me.RadChequeNumber.Text = " رقم الشيك"
        Me.RadChequeNumber.UseVisualStyleBackColor = True
        '
        'combBillId
        '
        Me.combBillId.Enabled = False
        Me.combBillId.FormattingEnabled = True
        Me.combBillId.Location = New System.Drawing.Point(28, 21)
        Me.combBillId.Name = "combBillId"
        Me.combBillId.Size = New System.Drawing.Size(115, 21)
        Me.combBillId.TabIndex = 61
        '
        'RadBillByDate
        '
        Me.RadBillByDate.AutoSize = True
        Me.RadBillByDate.BackColor = System.Drawing.Color.Transparent
        Me.RadBillByDate.Location = New System.Drawing.Point(432, 159)
        Me.RadBillByDate.Name = "RadBillByDate"
        Me.RadBillByDate.Size = New System.Drawing.Size(75, 17)
        Me.RadBillByDate.TabIndex = 59
        Me.RadBillByDate.TabStop = True
        Me.RadBillByDate.Text = "بين تاريخين" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadBillByDate.UseVisualStyleBackColor = False
        '
        'RadBillID
        '
        Me.RadBillID.AutoSize = True
        Me.RadBillID.BackColor = System.Drawing.Color.Transparent
        Me.RadBillID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadBillID.Location = New System.Drawing.Point(197, 22)
        Me.RadBillID.Name = "RadBillID"
        Me.RadBillID.Size = New System.Drawing.Size(77, 17)
        Me.RadBillID.TabIndex = 60
        Me.RadBillID.Text = "رقم الفاتوره"
        Me.RadBillID.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView2.Location = New System.Drawing.Point(5, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.DataGridView2.Size = New System.Drawing.Size(1334, 419)
        Me.DataGridView2.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.VisitName)
        Me.GroupBox3.Controls.Add(Me.SalesRepName)
        Me.GroupBox3.Controls.Add(Me.BillTime)
        Me.GroupBox3.Controls.Add(Me.ChequeNumber)
        Me.GroupBox3.Controls.Add(Me.RecieveDate)
        Me.GroupBox3.Controls.Add(Me.EmployeeName)
        Me.GroupBox3.Controls.Add(Me.VisaNumber)
        Me.GroupBox3.Controls.Add(Me.TotalCredit)
        Me.GroupBox3.Controls.Add(Me.TotalCash)
        Me.GroupBox3.Controls.Add(Me.BillID)
        Me.GroupBox3.Controls.Add(Me.BillDate)
        Me.GroupBox3.Controls.Add(Me.BillStatus)
        Me.GroupBox3.Controls.Add(Me.TotalBill)
        Me.GroupBox3.Controls.Add(Me.BillType)
        Me.GroupBox3.Controls.Add(Me.CustomerName)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 425)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(520, 188)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "البيانات المطلوب عرضها"
        '
        'VisitName
        '
        Me.VisitName.AutoSize = True
        Me.VisitName.Location = New System.Drawing.Point(303, 151)
        Me.VisitName.Name = "VisitName"
        Me.VisitName.Size = New System.Drawing.Size(78, 17)
        Me.VisitName.TabIndex = 23
        Me.VisitName.Text = "اسم الجوله"
        Me.VisitName.UseVisualStyleBackColor = True
        '
        'SalesRepName
        '
        Me.SalesRepName.AutoSize = True
        Me.SalesRepName.Location = New System.Drawing.Point(170, 151)
        Me.SalesRepName.Name = "SalesRepName"
        Me.SalesRepName.Size = New System.Drawing.Size(88, 17)
        Me.SalesRepName.TabIndex = 22
        Me.SalesRepName.Text = "اسم المندوب"
        Me.SalesRepName.UseVisualStyleBackColor = True
        '
        'BillTime
        '
        Me.BillTime.AutoSize = True
        Me.BillTime.Location = New System.Drawing.Point(29, 19)
        Me.BillTime.Name = "BillTime"
        Me.BillTime.Size = New System.Drawing.Size(81, 17)
        Me.BillTime.TabIndex = 17
        Me.BillTime.Text = "وقت الفاتوره"
        Me.BillTime.UseVisualStyleBackColor = True
        '
        'ChequeNumber
        '
        Me.ChequeNumber.AutoSize = True
        Me.ChequeNumber.Location = New System.Drawing.Point(303, 106)
        Me.ChequeNumber.Name = "ChequeNumber"
        Me.ChequeNumber.Size = New System.Drawing.Size(77, 17)
        Me.ChequeNumber.TabIndex = 16
        Me.ChequeNumber.Text = "رقم الشيك"
        Me.ChequeNumber.UseVisualStyleBackColor = True
        '
        'RecieveDate
        '
        Me.RecieveDate.AutoSize = True
        Me.RecieveDate.Location = New System.Drawing.Point(157, 106)
        Me.RecieveDate.Name = "RecieveDate"
        Me.RecieveDate.Size = New System.Drawing.Size(101, 17)
        Me.RecieveDate.TabIndex = 15
        Me.RecieveDate.Text = "تاريخ الاستحقاق"
        Me.RecieveDate.UseVisualStyleBackColor = True
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoSize = True
        Me.EmployeeName.Location = New System.Drawing.Point(24, 106)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(86, 17)
        Me.EmployeeName.TabIndex = 14
        Me.EmployeeName.Text = "اسم الموظف"
        Me.EmployeeName.UseVisualStyleBackColor = True
        '
        'VisaNumber
        '
        Me.VisaNumber.AutoSize = True
        Me.VisaNumber.Location = New System.Drawing.Point(433, 151)
        Me.VisaNumber.Name = "VisaNumber"
        Me.VisaNumber.Size = New System.Drawing.Size(70, 17)
        Me.VisaNumber.TabIndex = 12
        Me.VisaNumber.Text = "رقم الفيزا"
        Me.VisaNumber.UseVisualStyleBackColor = True
        '
        'TotalCredit
        '
        Me.TotalCredit.AutoSize = True
        Me.TotalCredit.Location = New System.Drawing.Point(170, 63)
        Me.TotalCredit.Name = "TotalCredit"
        Me.TotalCredit.Size = New System.Drawing.Size(88, 17)
        Me.TotalCredit.TabIndex = 10
        Me.TotalCredit.Text = "اجمالى الاجل"
        Me.TotalCredit.UseVisualStyleBackColor = True
        '
        'TotalCash
        '
        Me.TotalCash.AutoSize = True
        Me.TotalCash.Location = New System.Drawing.Point(15, 63)
        Me.TotalCash.Name = "TotalCash"
        Me.TotalCash.Size = New System.Drawing.Size(95, 17)
        Me.TotalCash.TabIndex = 9
        Me.TotalCash.Text = "اجمالى النقدى"
        Me.TotalCash.UseVisualStyleBackColor = True
        '
        'BillID
        '
        Me.BillID.AutoSize = True
        Me.BillID.Location = New System.Drawing.Point(302, 19)
        Me.BillID.Name = "BillID"
        Me.BillID.Size = New System.Drawing.Size(78, 17)
        Me.BillID.TabIndex = 8
        Me.BillID.Text = "رقم الفاتوره"
        Me.BillID.UseVisualStyleBackColor = True
        '
        'BillDate
        '
        Me.BillDate.AutoSize = True
        Me.BillDate.Location = New System.Drawing.Point(176, 19)
        Me.BillDate.Name = "BillDate"
        Me.BillDate.Size = New System.Drawing.Size(82, 17)
        Me.BillDate.TabIndex = 7
        Me.BillDate.Text = "تاريخ الفاتوره"
        Me.BillDate.UseVisualStyleBackColor = True
        '
        'BillStatus
        '
        Me.BillStatus.AutoSize = True
        Me.BillStatus.Location = New System.Drawing.Point(423, 106)
        Me.BillStatus.Name = "BillStatus"
        Me.BillStatus.Size = New System.Drawing.Size(80, 17)
        Me.BillStatus.TabIndex = 6
        Me.BillStatus.Text = "حاله الفاتوره"
        Me.BillStatus.UseVisualStyleBackColor = True
        '
        'TotalBill
        '
        Me.TotalBill.AutoSize = True
        Me.TotalBill.Location = New System.Drawing.Point(285, 63)
        Me.TotalBill.Name = "TotalBill"
        Me.TotalBill.Size = New System.Drawing.Size(95, 17)
        Me.TotalBill.TabIndex = 4
        Me.TotalBill.Text = "اجمالى الفاتوره"
        Me.TotalBill.UseVisualStyleBackColor = True
        '
        'BillType
        '
        Me.BillType.AutoSize = True
        Me.BillType.Location = New System.Drawing.Point(423, 63)
        Me.BillType.Name = "BillType"
        Me.BillType.Size = New System.Drawing.Size(76, 17)
        Me.BillType.TabIndex = 2
        Me.BillType.Text = "نوع الفاتوره"
        Me.BillType.UseVisualStyleBackColor = True
        '
        'CustomerName
        '
        Me.CustomerName.AutoSize = True
        Me.CustomerName.Location = New System.Drawing.Point(417, 19)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(82, 17)
        Me.CustomerName.TabIndex = 0
        Me.CustomerName.Text = "اسم العميل"
        Me.CustomerName.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.CrystalReportViewer2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1262, 684)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "التقرير"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1256, 678)
        Me.CrystalReportViewer2.TabIndex = 0
        '
        'FrmTotalVisits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1284, 742)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "FrmTotalVisits"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " تقرير الجولات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.NumTotalBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents RadAllCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents RadCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents CombCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RadAllCheques As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllBills As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RadDesrevedBill As System.Windows.Forms.RadioButton
    Friend WithEvents NumTotalBill As System.Windows.Forms.NumericUpDown
    Friend WithEvents RadDeservedCheques As System.Windows.Forms.RadioButton
    Friend WithEvents RadTotalBillBetween As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CombCheques As System.Windows.Forms.ComboBox
    Friend WithEvents RadMAxTBill As System.Windows.Forms.RadioButton
    Friend WithEvents RadChequeNumber As System.Windows.Forms.RadioButton
    Friend WithEvents combBillId As System.Windows.Forms.ComboBox
    Friend WithEvents RadBillByDate As System.Windows.Forms.RadioButton
    Friend WithEvents RadBillID As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BillTime As System.Windows.Forms.CheckBox
    Friend WithEvents ChequeNumber As System.Windows.Forms.CheckBox
    Friend WithEvents RecieveDate As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeeName As System.Windows.Forms.CheckBox
    Friend WithEvents VisaNumber As System.Windows.Forms.CheckBox
    Friend WithEvents TotalCredit As System.Windows.Forms.CheckBox
    Friend WithEvents TotalCash As System.Windows.Forms.CheckBox
    Friend WithEvents BillID As System.Windows.Forms.CheckBox
    Friend WithEvents BillDate As System.Windows.Forms.CheckBox
    Friend WithEvents BillStatus As System.Windows.Forms.CheckBox
    Friend WithEvents TotalBill As System.Windows.Forms.CheckBox
    Friend WithEvents BillType As System.Windows.Forms.CheckBox
    Friend WithEvents CustomerName As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents VisitName As System.Windows.Forms.CheckBox
    Friend WithEvents SalesRepName As System.Windows.Forms.CheckBox
    Friend WithEvents combSalesRep As System.Windows.Forms.ComboBox
    Friend WithEvents RadSalesRep As System.Windows.Forms.RadioButton
    Friend WithEvents combvisits As System.Windows.Forms.ComboBox
    Friend WithEvents Radvisits As System.Windows.Forms.RadioButton
End Class
