<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetProfit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetProfit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnHelp = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TotalReceiveGeneralCash = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TotalPayGeneralCash = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TotalCashFromVendor = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TotalCashToCustomer = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TotalCustomersCheques = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TotalVendorsCheques = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProfitVisa = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ProfitNet = New System.Windows.Forms.Label()
        Me.LblProfit = New System.Windows.Forms.Label()
        Me.ProfitReturnVendors = New System.Windows.Forms.Label()
        Me.ProfitSales = New System.Windows.Forms.Label()
        Me.TotalVendorPayments = New System.Windows.Forms.Label()
        Me.TotalReturnCustomers = New System.Windows.Forms.Label()
        Me.TotalPurchase = New System.Windows.Forms.Label()
        Me.TotalPaySalary = New System.Windows.Forms.Label()
        Me.TotalExpenses = New System.Windows.Forms.Label()
        Me.TotalAddedHours = New System.Windows.Forms.Label()
        Me.ProfitCustomerPayments = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator2, Me.BtnExit, Me.ToolStripSeparator12, Me.BtnHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(589, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.Image = Global.Paints.My.Resources.Resources.View
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(60, 22)
        Me.BtnNew.Text = "استعلام"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnExit
        '
        Me.BtnExit.Image = Global.Paints.My.Resources.Resources.ExitRed
        Me.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(52, 22)
        Me.BtnExit.Text = "خروج"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'BtnHelp
        '
        Me.BtnHelp.Image = Global.Paints.My.Resources.Resources.Symbol_Help
        Me.BtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(62, 22)
        Me.BtnHelp.Text = "مساعدة"
        Me.BtnHelp.ToolTipText = "Help"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalReceiveGeneralCash)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label20)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalPayGeneralCash)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalCashFromVendor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalCashToCustomer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalCustomersCheques)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalVendorsCheques)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProfitVisa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProfitNet)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LblProfit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProfitReturnVendors)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProfitSales)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalVendorPayments)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalReturnCustomers)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalPurchase)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalPaySalary)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalExpenses)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TotalAddedHours)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProfitCustomerPayments)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(589, 638)
        Me.SplitContainer1.SplitterDistance = 71
        Me.SplitContainer1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(484, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "من تاريخ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(197, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "الي تاريخ :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(334, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(49, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 25
        '
        'TotalReceiveGeneralCash
        '
        Me.TotalReceiveGeneralCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalReceiveGeneralCash.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalReceiveGeneralCash.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TotalReceiveGeneralCash.Location = New System.Drawing.Point(44, 285)
        Me.TotalReceiveGeneralCash.Name = "TotalReceiveGeneralCash"
        Me.TotalReceiveGeneralCash.Size = New System.Drawing.Size(116, 21)
        Me.TotalReceiveGeneralCash.TabIndex = 65
        Me.TotalReceiveGeneralCash.Text = "0"
        Me.TotalReceiveGeneralCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label20.Location = New System.Drawing.Point(166, 288)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 15)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "استلام نقديه عامه :"
        '
        'TotalPayGeneralCash
        '
        Me.TotalPayGeneralCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalPayGeneralCash.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPayGeneralCash.ForeColor = System.Drawing.Color.Red
        Me.TotalPayGeneralCash.Location = New System.Drawing.Point(329, 377)
        Me.TotalPayGeneralCash.Name = "TotalPayGeneralCash"
        Me.TotalPayGeneralCash.Size = New System.Drawing.Size(116, 21)
        Me.TotalPayGeneralCash.TabIndex = 63
        Me.TotalPayGeneralCash.Text = "0"
        Me.TotalPayGeneralCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(467, 380)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 15)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "دفع نقديه عامه :"
        '
        'TotalCashFromVendor
        '
        Me.TotalCashFromVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalCashFromVendor.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCashFromVendor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TotalCashFromVendor.Location = New System.Drawing.Point(44, 244)
        Me.TotalCashFromVendor.Name = "TotalCashFromVendor"
        Me.TotalCashFromVendor.Size = New System.Drawing.Size(116, 21)
        Me.TotalCashFromVendor.TabIndex = 61
        Me.TotalCashFromVendor.Text = "0"
        Me.TotalCashFromVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(166, 247)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 15)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "نقديه من المورد :"
        '
        'TotalCashToCustomer
        '
        Me.TotalCashToCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalCashToCustomer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCashToCustomer.ForeColor = System.Drawing.Color.Red
        Me.TotalCashToCustomer.Location = New System.Drawing.Point(329, 333)
        Me.TotalCashToCustomer.Name = "TotalCashToCustomer"
        Me.TotalCashToCustomer.Size = New System.Drawing.Size(116, 21)
        Me.TotalCashToCustomer.TabIndex = 59
        Me.TotalCashToCustomer.Text = "0"
        Me.TotalCashToCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(458, 336)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 15)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "دفع نقديه للعملاء :"
        '
        'TotalCustomersCheques
        '
        Me.TotalCustomersCheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalCustomersCheques.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCustomersCheques.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TotalCustomersCheques.Location = New System.Drawing.Point(44, 199)
        Me.TotalCustomersCheques.Name = "TotalCustomersCheques"
        Me.TotalCustomersCheques.Size = New System.Drawing.Size(116, 21)
        Me.TotalCustomersCheques.TabIndex = 53
        Me.TotalCustomersCheques.Text = "0"
        Me.TotalCustomersCheques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(166, 202)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 15)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "شيكات :"
        '
        'TotalVendorsCheques
        '
        Me.TotalVendorsCheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalVendorsCheques.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVendorsCheques.ForeColor = System.Drawing.Color.Red
        Me.TotalVendorsCheques.Location = New System.Drawing.Point(329, 289)
        Me.TotalVendorsCheques.Name = "TotalVendorsCheques"
        Me.TotalVendorsCheques.Size = New System.Drawing.Size(116, 21)
        Me.TotalVendorsCheques.TabIndex = 51
        Me.TotalVendorsCheques.Text = "0"
        Me.TotalVendorsCheques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(500, 292)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 15)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "شيكات :"
        '
        'ProfitVisa
        '
        Me.ProfitVisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfitVisa.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfitVisa.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ProfitVisa.Location = New System.Drawing.Point(44, 108)
        Me.ProfitVisa.Name = "ProfitVisa"
        Me.ProfitVisa.Size = New System.Drawing.Size(116, 21)
        Me.ProfitVisa.TabIndex = 49
        Me.ProfitVisa.Text = "0"
        Me.ProfitVisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(166, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "اجمالي الفيزا :"
        '
        'ProfitNet
        '
        Me.ProfitNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfitNet.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfitNet.ForeColor = System.Drawing.Color.Black
        Me.ProfitNet.Location = New System.Drawing.Point(105, 511)
        Me.ProfitNet.Name = "ProfitNet"
        Me.ProfitNet.Size = New System.Drawing.Size(256, 21)
        Me.ProfitNet.TabIndex = 47
        Me.ProfitNet.Text = "0"
        Me.ProfitNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblProfit
        '
        Me.LblProfit.AutoSize = True
        Me.LblProfit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfit.ForeColor = System.Drawing.Color.Black
        Me.LblProfit.Location = New System.Drawing.Point(367, 514)
        Me.LblProfit.Name = "LblProfit"
        Me.LblProfit.Size = New System.Drawing.Size(114, 15)
        Me.LblProfit.TabIndex = 46
        Me.LblProfit.Text = "الدخل المحقق عن الفترة :"
        '
        'ProfitReturnVendors
        '
        Me.ProfitReturnVendors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfitReturnVendors.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfitReturnVendors.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ProfitReturnVendors.Location = New System.Drawing.Point(44, 153)
        Me.ProfitReturnVendors.Name = "ProfitReturnVendors"
        Me.ProfitReturnVendors.Size = New System.Drawing.Size(116, 21)
        Me.ProfitReturnVendors.TabIndex = 44
        Me.ProfitReturnVendors.Text = "0"
        Me.ProfitReturnVendors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProfitSales
        '
        Me.ProfitSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfitSales.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfitSales.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ProfitSales.Location = New System.Drawing.Point(44, 66)
        Me.ProfitSales.Name = "ProfitSales"
        Me.ProfitSales.Size = New System.Drawing.Size(116, 21)
        Me.ProfitSales.TabIndex = 43
        Me.ProfitSales.Text = "0"
        Me.ProfitSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalVendorPayments
        '
        Me.TotalVendorPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalVendorPayments.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVendorPayments.ForeColor = System.Drawing.Color.Red
        Me.TotalVendorPayments.Location = New System.Drawing.Point(329, 22)
        Me.TotalVendorPayments.Name = "TotalVendorPayments"
        Me.TotalVendorPayments.Size = New System.Drawing.Size(116, 21)
        Me.TotalVendorPayments.TabIndex = 42
        Me.TotalVendorPayments.Text = "0"
        Me.TotalVendorPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalReturnCustomers
        '
        Me.TotalReturnCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalReturnCustomers.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalReturnCustomers.ForeColor = System.Drawing.Color.Red
        Me.TotalReturnCustomers.Location = New System.Drawing.Point(329, 247)
        Me.TotalReturnCustomers.Name = "TotalReturnCustomers"
        Me.TotalReturnCustomers.Size = New System.Drawing.Size(116, 21)
        Me.TotalReturnCustomers.TabIndex = 41
        Me.TotalReturnCustomers.Text = "0"
        Me.TotalReturnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalPurchase
        '
        Me.TotalPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalPurchase.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPurchase.ForeColor = System.Drawing.Color.Red
        Me.TotalPurchase.Location = New System.Drawing.Point(329, 202)
        Me.TotalPurchase.Name = "TotalPurchase"
        Me.TotalPurchase.Size = New System.Drawing.Size(116, 21)
        Me.TotalPurchase.TabIndex = 40
        Me.TotalPurchase.Text = "0"
        Me.TotalPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalPaySalary
        '
        Me.TotalPaySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalPaySalary.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPaySalary.ForeColor = System.Drawing.Color.Red
        Me.TotalPaySalary.Location = New System.Drawing.Point(329, 157)
        Me.TotalPaySalary.Name = "TotalPaySalary"
        Me.TotalPaySalary.Size = New System.Drawing.Size(116, 21)
        Me.TotalPaySalary.TabIndex = 39
        Me.TotalPaySalary.Text = "0"
        Me.TotalPaySalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalExpenses
        '
        Me.TotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalExpenses.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalExpenses.ForeColor = System.Drawing.Color.Red
        Me.TotalExpenses.Location = New System.Drawing.Point(329, 112)
        Me.TotalExpenses.Name = "TotalExpenses"
        Me.TotalExpenses.Size = New System.Drawing.Size(116, 21)
        Me.TotalExpenses.TabIndex = 38
        Me.TotalExpenses.Text = "0"
        Me.TotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalAddedHours
        '
        Me.TotalAddedHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAddedHours.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAddedHours.ForeColor = System.Drawing.Color.Red
        Me.TotalAddedHours.Location = New System.Drawing.Point(329, 67)
        Me.TotalAddedHours.Name = "TotalAddedHours"
        Me.TotalAddedHours.Size = New System.Drawing.Size(116, 21)
        Me.TotalAddedHours.TabIndex = 37
        Me.TotalAddedHours.Text = "0"
        Me.TotalAddedHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProfitCustomerPayments
        '
        Me.ProfitCustomerPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfitCustomerPayments.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfitCustomerPayments.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ProfitCustomerPayments.Location = New System.Drawing.Point(44, 21)
        Me.ProfitCustomerPayments.Name = "ProfitCustomerPayments"
        Me.ProfitCustomerPayments.Size = New System.Drawing.Size(116, 21)
        Me.ProfitCustomerPayments.TabIndex = 35
        Me.ProfitCustomerPayments.Text = "0"
        Me.ProfitCustomerPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label12.Location = New System.Drawing.Point(166, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 15)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "مرتجع الموردين :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.Location = New System.Drawing.Point(166, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "اجمالي الكاش و البنك :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(452, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "مدفوعات المرتبات :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(448, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "اجمالي المصروفات :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(452, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "اجمالي المشتريات :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(468, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "مرتجع العملاء :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(455, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "الساعات الاضافية :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(166, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "مدفوعات العملاء :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(450, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "مدفوعات الموردين :"
        '
        'NetProfit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 663)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NetProfit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اجمالي الدخل المحقق خلال فترة محددة"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProfitNet As System.Windows.Forms.Label
    Friend WithEvents LblProfit As System.Windows.Forms.Label
    Friend WithEvents ProfitReturnVendors As System.Windows.Forms.Label
    Friend WithEvents ProfitSales As System.Windows.Forms.Label
    Friend WithEvents TotalVendorPayments As System.Windows.Forms.Label
    Friend WithEvents TotalReturnCustomers As System.Windows.Forms.Label
    Friend WithEvents TotalPurchase As System.Windows.Forms.Label
    Friend WithEvents TotalPaySalary As System.Windows.Forms.Label
    Friend WithEvents TotalExpenses As System.Windows.Forms.Label
    Friend WithEvents TotalAddedHours As System.Windows.Forms.Label
    Friend WithEvents ProfitCustomerPayments As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProfitVisa As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TotalCustomersCheques As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TotalVendorsCheques As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TotalCashToCustomer As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TotalCashFromVendor As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TotalReceiveGeneralCash As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TotalPayGeneralCash As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
