<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAllQueries
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadAlert = New System.Windows.Forms.RadioButton()
        Me.CombBarcode = New System.Windows.Forms.TextBox()
        Me.RadVendor = New System.Windows.Forms.RadioButton()
        Me.CombVendor = New System.Windows.Forms.ComboBox()
        Me.RadBarcode = New System.Windows.Forms.RadioButton()
        Me.RadUm = New System.Windows.Forms.RadioButton()
        Me.RadItem = New System.Windows.Forms.RadioButton()
        Me.RadCategory = New System.Windows.Forms.RadioButton()
        Me.radCorporation = New System.Windows.Forms.RadioButton()
        Me.radStock = New System.Windows.Forms.RadioButton()
        Me.CombUm = New System.Windows.Forms.ComboBox()
        Me.CombItem = New System.Windows.Forms.ComboBox()
        Me.CombCategory = New System.Windows.Forms.ComboBox()
        Me.CombCorporation = New System.Windows.Forms.ComboBox()
        Me.CombStock = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Alert_Balance = New System.Windows.Forms.CheckBox()
        Me.Equivalent_Name = New System.Windows.Forms.CheckBox()
        Me.Vendor_Name = New System.Windows.Forms.CheckBox()
        Me.Sale_Total_Price = New System.Windows.Forms.CheckBox()
        Me.Expired_Date = New System.Windows.Forms.CheckBox()
        Me.Corporation_Name = New System.Windows.Forms.CheckBox()
        Me.Category_Name = New System.Windows.Forms.CheckBox()
        Me.Item_Name = New System.Windows.Forms.CheckBox()
        Me.Barcode = New System.Windows.Forms.CheckBox()
        Me.Um_Name = New System.Windows.Forms.CheckBox()
        Me.Sale_Price = New System.Windows.Forms.CheckBox()
        Me.Balance = New System.Windows.Forms.CheckBox()
        Me.Purchase_Price = New System.Windows.Forms.CheckBox()
        Me.Stock_Name = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.RadAlert)
        Me.GroupBox1.Controls.Add(Me.CombBarcode)
        Me.GroupBox1.Controls.Add(Me.RadVendor)
        Me.GroupBox1.Controls.Add(Me.CombVendor)
        Me.GroupBox1.Controls.Add(Me.RadBarcode)
        Me.GroupBox1.Controls.Add(Me.RadUm)
        Me.GroupBox1.Controls.Add(Me.RadItem)
        Me.GroupBox1.Controls.Add(Me.RadCategory)
        Me.GroupBox1.Controls.Add(Me.radCorporation)
        Me.GroupBox1.Controls.Add(Me.radStock)
        Me.GroupBox1.Controls.Add(Me.CombUm)
        Me.GroupBox1.Controls.Add(Me.CombItem)
        Me.GroupBox1.Controls.Add(Me.CombCategory)
        Me.GroupBox1.Controls.Add(Me.CombCorporation)
        Me.GroupBox1.Controls.Add(Me.CombStock)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(870, 451)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(488, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معاملات التقرير"
        '
        'RadAlert
        '
        Me.RadAlert.AutoSize = True
        Me.RadAlert.BackColor = System.Drawing.Color.Transparent
        Me.RadAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadAlert.Location = New System.Drawing.Point(182, 146)
        Me.RadAlert.Name = "RadAlert"
        Me.RadAlert.Size = New System.Drawing.Size(56, 17)
        Me.RadAlert.TabIndex = 15
        Me.RadAlert.Text = "التحذير"
        Me.RadAlert.UseVisualStyleBackColor = False
        '
        'CombBarcode
        '
        Me.CombBarcode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombBarcode.Location = New System.Drawing.Point(260, 102)
        Me.CombBarcode.Name = "CombBarcode"
        Me.CombBarcode.Size = New System.Drawing.Size(132, 21)
        Me.CombBarcode.TabIndex = 14
        '
        'RadVendor
        '
        Me.RadVendor.AutoSize = True
        Me.RadVendor.BackColor = System.Drawing.Color.Transparent
        Me.RadVendor.Location = New System.Drawing.Point(403, 143)
        Me.RadVendor.Name = "RadVendor"
        Me.RadVendor.Size = New System.Drawing.Size(77, 17)
        Me.RadVendor.TabIndex = 13
        Me.RadVendor.Text = "اسم المورد"
        Me.RadVendor.UseVisualStyleBackColor = False
        '
        'CombVendor
        '
        Me.CombVendor.FormattingEnabled = True
        Me.CombVendor.Location = New System.Drawing.Point(260, 142)
        Me.CombVendor.Name = "CombVendor"
        Me.CombVendor.Size = New System.Drawing.Size(132, 21)
        Me.CombVendor.TabIndex = 12
        '
        'RadBarcode
        '
        Me.RadBarcode.AutoSize = True
        Me.RadBarcode.BackColor = System.Drawing.Color.Transparent
        Me.RadBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadBarcode.Location = New System.Drawing.Point(423, 102)
        Me.RadBarcode.Name = "RadBarcode"
        Me.RadBarcode.Size = New System.Drawing.Size(57, 17)
        Me.RadBarcode.TabIndex = 11
        Me.RadBarcode.Text = "الباركود"
        Me.RadBarcode.UseVisualStyleBackColor = False
        '
        'RadUm
        '
        Me.RadUm.AutoSize = True
        Me.RadUm.BackColor = System.Drawing.Color.Transparent
        Me.RadUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadUm.Location = New System.Drawing.Point(140, 106)
        Me.RadUm.Name = "RadUm"
        Me.RadUm.Size = New System.Drawing.Size(98, 17)
        Me.RadUm.TabIndex = 10
        Me.RadUm.Text = "مجموعه القياس"
        Me.RadUm.UseVisualStyleBackColor = False
        '
        'RadItem
        '
        Me.RadItem.AutoSize = True
        Me.RadItem.BackColor = System.Drawing.Color.Transparent
        Me.RadItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadItem.Location = New System.Drawing.Point(159, 66)
        Me.RadItem.Name = "RadItem"
        Me.RadItem.Size = New System.Drawing.Size(79, 17)
        Me.RadItem.TabIndex = 9
        Me.RadItem.Text = "اسم الصنف"
        Me.RadItem.UseVisualStyleBackColor = False
        '
        'RadCategory
        '
        Me.RadCategory.AutoSize = True
        Me.RadCategory.BackColor = System.Drawing.Color.Transparent
        Me.RadCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadCategory.Location = New System.Drawing.Point(410, 62)
        Me.RadCategory.Name = "RadCategory"
        Me.RadCategory.Size = New System.Drawing.Size(70, 17)
        Me.RadCategory.TabIndex = 8
        Me.RadCategory.Text = "اسم البند"
        Me.RadCategory.UseVisualStyleBackColor = False
        '
        'radCorporation
        '
        Me.radCorporation.AutoSize = True
        Me.radCorporation.BackColor = System.Drawing.Color.Transparent
        Me.radCorporation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.radCorporation.Location = New System.Drawing.Point(154, 29)
        Me.radCorporation.Name = "radCorporation"
        Me.radCorporation.Size = New System.Drawing.Size(84, 17)
        Me.radCorporation.TabIndex = 7
        Me.radCorporation.Text = "اسم الشركه"
        Me.radCorporation.UseVisualStyleBackColor = False
        '
        'radStock
        '
        Me.radStock.AutoSize = True
        Me.radStock.BackColor = System.Drawing.Color.Transparent
        Me.radStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.radStock.Checked = True
        Me.radStock.Location = New System.Drawing.Point(398, 25)
        Me.radStock.Name = "radStock"
        Me.radStock.Size = New System.Drawing.Size(82, 17)
        Me.radStock.TabIndex = 6
        Me.radStock.TabStop = True
        Me.radStock.Text = "اسم المخزن"
        Me.radStock.UseVisualStyleBackColor = False
        '
        'CombUm
        '
        Me.CombUm.Enabled = False
        Me.CombUm.FormattingEnabled = True
        Me.CombUm.Location = New System.Drawing.Point(6, 106)
        Me.CombUm.Name = "CombUm"
        Me.CombUm.Size = New System.Drawing.Size(132, 21)
        Me.CombUm.TabIndex = 5
        '
        'CombItem
        '
        Me.CombItem.Enabled = False
        Me.CombItem.FormattingEnabled = True
        Me.CombItem.Location = New System.Drawing.Point(6, 69)
        Me.CombItem.Name = "CombItem"
        Me.CombItem.Size = New System.Drawing.Size(132, 21)
        Me.CombItem.TabIndex = 3
        '
        'CombCategory
        '
        Me.CombCategory.Enabled = False
        Me.CombCategory.FormattingEnabled = True
        Me.CombCategory.Location = New System.Drawing.Point(260, 62)
        Me.CombCategory.Name = "CombCategory"
        Me.CombCategory.Size = New System.Drawing.Size(132, 21)
        Me.CombCategory.TabIndex = 2
        '
        'CombCorporation
        '
        Me.CombCorporation.Enabled = False
        Me.CombCorporation.FormattingEnabled = True
        Me.CombCorporation.Location = New System.Drawing.Point(6, 29)
        Me.CombCorporation.Name = "CombCorporation"
        Me.CombCorporation.Size = New System.Drawing.Size(132, 21)
        Me.CombCorporation.TabIndex = 1
        '
        'CombStock
        '
        Me.CombStock.FormattingEnabled = True
        Me.CombStock.Location = New System.Drawing.Point(260, 25)
        Me.CombStock.Name = "CombStock"
        Me.CombStock.Size = New System.Drawing.Size(132, 21)
        Me.CombStock.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Alert_Balance)
        Me.GroupBox2.Controls.Add(Me.Equivalent_Name)
        Me.GroupBox2.Controls.Add(Me.Vendor_Name)
        Me.GroupBox2.Controls.Add(Me.Sale_Total_Price)
        Me.GroupBox2.Controls.Add(Me.Expired_Date)
        Me.GroupBox2.Controls.Add(Me.Corporation_Name)
        Me.GroupBox2.Controls.Add(Me.Category_Name)
        Me.GroupBox2.Controls.Add(Me.Item_Name)
        Me.GroupBox2.Controls.Add(Me.Barcode)
        Me.GroupBox2.Controls.Add(Me.Um_Name)
        Me.GroupBox2.Controls.Add(Me.Sale_Price)
        Me.GroupBox2.Controls.Add(Me.Balance)
        Me.GroupBox2.Controls.Add(Me.Purchase_Price)
        Me.GroupBox2.Controls.Add(Me.Stock_Name)
        Me.GroupBox2.Location = New System.Drawing.Point(346, 446)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(518, 163)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "البيانات المطلوب عرضها"
        '
        'Alert_Balance
        '
        Me.Alert_Balance.AutoSize = True
        Me.Alert_Balance.Location = New System.Drawing.Point(225, 120)
        Me.Alert_Balance.Name = "Alert_Balance"
        Me.Alert_Balance.Size = New System.Drawing.Size(73, 17)
        Me.Alert_Balance.TabIndex = 13
        Me.Alert_Balance.Text = "حد التحذير"
        Me.Alert_Balance.UseVisualStyleBackColor = True
        '
        'Equivalent_Name
        '
        Me.Equivalent_Name.AutoSize = True
        Me.Equivalent_Name.Location = New System.Drawing.Point(109, 75)
        Me.Equivalent_Name.Name = "Equivalent_Name"
        Me.Equivalent_Name.Size = New System.Drawing.Size(84, 17)
        Me.Equivalent_Name.TabIndex = 12
        Me.Equivalent_Name.Text = "وحده القياس"
        Me.Equivalent_Name.UseVisualStyleBackColor = True
        '
        'Vendor_Name
        '
        Me.Vendor_Name.AutoSize = True
        Me.Vendor_Name.Location = New System.Drawing.Point(115, 120)
        Me.Vendor_Name.Name = "Vendor_Name"
        Me.Vendor_Name.Size = New System.Drawing.Size(78, 17)
        Me.Vendor_Name.TabIndex = 11
        Me.Vendor_Name.Text = "اسم المورد"
        Me.Vendor_Name.UseVisualStyleBackColor = True
        '
        'Sale_Total_Price
        '
        Me.Sale_Total_Price.AutoSize = True
        Me.Sale_Total_Price.Location = New System.Drawing.Point(324, 120)
        Me.Sale_Total_Price.Name = "Sale_Total_Price"
        Me.Sale_Total_Price.Size = New System.Drawing.Size(81, 17)
        Me.Sale_Total_Price.TabIndex = 10
        Me.Sale_Total_Price.Text = "سعر الجمله"
        Me.Sale_Total_Price.UseVisualStyleBackColor = True
        '
        'Expired_Date
        '
        Me.Expired_Date.AutoSize = True
        Me.Expired_Date.Location = New System.Drawing.Point(422, 75)
        Me.Expired_Date.Name = "Expired_Date"
        Me.Expired_Date.Size = New System.Drawing.Size(90, 17)
        Me.Expired_Date.TabIndex = 9
        Me.Expired_Date.Text = "تاريخ الصلاحيه"
        Me.Expired_Date.UseVisualStyleBackColor = True
        '
        'Corporation_Name
        '
        Me.Corporation_Name.AutoSize = True
        Me.Corporation_Name.Location = New System.Drawing.Point(320, 30)
        Me.Corporation_Name.Name = "Corporation_Name"
        Me.Corporation_Name.Size = New System.Drawing.Size(85, 17)
        Me.Corporation_Name.TabIndex = 8
        Me.Corporation_Name.Text = "اسم الشركه"
        Me.Corporation_Name.UseVisualStyleBackColor = True
        '
        'Category_Name
        '
        Me.Category_Name.AutoSize = True
        Me.Category_Name.Location = New System.Drawing.Point(227, 30)
        Me.Category_Name.Name = "Category_Name"
        Me.Category_Name.Size = New System.Drawing.Size(71, 17)
        Me.Category_Name.TabIndex = 7
        Me.Category_Name.Text = "اسم البند"
        Me.Category_Name.UseVisualStyleBackColor = True
        '
        'Item_Name
        '
        Me.Item_Name.AutoSize = True
        Me.Item_Name.Location = New System.Drawing.Point(115, 30)
        Me.Item_Name.Name = "Item_Name"
        Me.Item_Name.Size = New System.Drawing.Size(80, 17)
        Me.Item_Name.TabIndex = 6
        Me.Item_Name.Text = "اسم الصنف"
        Me.Item_Name.UseVisualStyleBackColor = True
        '
        'Barcode
        '
        Me.Barcode.AutoSize = True
        Me.Barcode.Location = New System.Drawing.Point(28, 30)
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Size = New System.Drawing.Size(58, 17)
        Me.Barcode.TabIndex = 5
        Me.Barcode.Text = "الباركود"
        Me.Barcode.UseVisualStyleBackColor = True
        '
        'Um_Name
        '
        Me.Um_Name.AutoSize = True
        Me.Um_Name.Location = New System.Drawing.Point(199, 75)
        Me.Um_Name.Name = "Um_Name"
        Me.Um_Name.Size = New System.Drawing.Size(99, 17)
        Me.Um_Name.TabIndex = 4
        Me.Um_Name.Text = "مجموعه القياس"
        Me.Um_Name.UseVisualStyleBackColor = True
        '
        'Sale_Price
        '
        Me.Sale_Price.AutoSize = True
        Me.Sale_Price.Location = New System.Drawing.Point(441, 120)
        Me.Sale_Price.Name = "Sale_Price"
        Me.Sale_Price.Size = New System.Drawing.Size(71, 17)
        Me.Sale_Price.TabIndex = 3
        Me.Sale_Price.Text = "سعر البيع"
        Me.Sale_Price.UseVisualStyleBackColor = True
        '
        'Balance
        '
        Me.Balance.AutoSize = True
        Me.Balance.Location = New System.Drawing.Point(349, 75)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(56, 17)
        Me.Balance.TabIndex = 2
        Me.Balance.Text = "الرصيد"
        Me.Balance.UseVisualStyleBackColor = True
        '
        'Purchase_Price
        '
        Me.Purchase_Price.AutoSize = True
        Me.Purchase_Price.Location = New System.Drawing.Point(5, 74)
        Me.Purchase_Price.Name = "Purchase_Price"
        Me.Purchase_Price.Size = New System.Drawing.Size(81, 17)
        Me.Purchase_Price.TabIndex = 1
        Me.Purchase_Price.Text = "سعر الشراء"
        Me.Purchase_Price.UseVisualStyleBackColor = True
        '
        'Stock_Name
        '
        Me.Stock_Name.AutoSize = True
        Me.Stock_Name.Location = New System.Drawing.Point(429, 30)
        Me.Stock_Name.Name = "Stock_Name"
        Me.Stock_Name.Size = New System.Drawing.Size(83, 17)
        Me.Stock_Name.TabIndex = 0
        Me.Stock_Name.Text = "اسم المخزن"
        Me.Stock_Name.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1370, 717)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1362, 691)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "الاستعلام"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(545, 624)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "الذهاب الى التقرير"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(32, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.Size = New System.Drawing.Size(1357, 441)
        Me.DataGridView1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1362, 691)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "التقرير"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1356, 685)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmAllQueries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmAllQueries"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تقرير بيانات المخزن"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadBarcode As System.Windows.Forms.RadioButton
    Friend WithEvents RadUm As System.Windows.Forms.RadioButton
    Friend WithEvents RadItem As System.Windows.Forms.RadioButton
    Friend WithEvents RadCategory As System.Windows.Forms.RadioButton
    Friend WithEvents radCorporation As System.Windows.Forms.RadioButton
    Friend WithEvents radStock As System.Windows.Forms.RadioButton
    Friend WithEvents CombUm As System.Windows.Forms.ComboBox
    Friend WithEvents CombCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CombCorporation As System.Windows.Forms.ComboBox
    Friend WithEvents CombStock As System.Windows.Forms.ComboBox
    Friend WithEvents RadVendor As System.Windows.Forms.RadioButton
    Friend WithEvents CombVendor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Vendor_Name As System.Windows.Forms.CheckBox
    Friend WithEvents Sale_Total_Price As System.Windows.Forms.CheckBox
    Friend WithEvents Expired_Date As System.Windows.Forms.CheckBox
    Friend WithEvents Corporation_Name As System.Windows.Forms.CheckBox
    Friend WithEvents Category_Name As System.Windows.Forms.CheckBox
    Friend WithEvents Item_Name As System.Windows.Forms.CheckBox
    Friend WithEvents Barcode As System.Windows.Forms.CheckBox
    Friend WithEvents Um_Name As System.Windows.Forms.CheckBox
    Friend WithEvents Sale_Price As System.Windows.Forms.CheckBox
    Friend WithEvents Balance As System.Windows.Forms.CheckBox
    Friend WithEvents Purchase_Price As System.Windows.Forms.CheckBox
    Friend WithEvents Stock_Name As System.Windows.Forms.CheckBox
    Friend WithEvents Equivalent_Name As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CombBarcode As System.Windows.Forms.TextBox
    Friend WithEvents CombItem As System.Windows.Forms.ComboBox
    Friend WithEvents RadAlert As System.Windows.Forms.RadioButton
    Friend WithEvents Alert_Balance As System.Windows.Forms.CheckBox
End Class
