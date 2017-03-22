<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustmentVisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdjustmentVisit))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboSalesRepID = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSavePrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnHelp = New System.Windows.Forms.ToolStripButton()
        Me.GroupHeader = New System.Windows.Forms.GroupBox()
        Me.StockID = New System.Windows.Forms.Label()
        Me.VisitName = New System.Windows.Forms.Label()
        Me.GeneralLabel6 = New Paints.GeneralLabel()
        Me.EmpStockID = New System.Windows.Forms.Label()
        Me.GeneralLabel4 = New Paints.GeneralLabel()
        Me.GeneralLabel17 = New Paints.GeneralLabel()
        Me.GeneralLabel8 = New Paints.GeneralLabel()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.GroupItems = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboUmDetailID = New System.Windows.Forms.ComboBox()
        Me.GeneralLabel19 = New Paints.GeneralLabel()
        Me.GeneralLabel13 = New Paints.GeneralLabel()
        Me.Quantity = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ItemName = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BarCode = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupAvailable = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupDetails = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupHeader.SuspendLayout()
        Me.GroupItems.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupAvailable.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDetails.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ComboSalesRepID, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.BtnSave, Me.ToolStripSeparator1, Me.BtnSavePrint, Me.ToolStripSeparator3, Me.BtnDelete, Me.ToolStripSeparator12, Me.BtnHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(1293, 38)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 35)
        Me.ToolStripLabel1.Text = "اسم المندوب :"
        '
        'ComboSalesRepID
        '
        Me.ComboSalesRepID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSalesRepID.Name = "ComboSalesRepID"
        Me.ComboSalesRepID.Size = New System.Drawing.Size(121, 38)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = Global.Paints.My.Resources.Resources.View
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(150, 35)
        Me.ToolStripButton1.Text = "استعلام"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 38)
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = False
        Me.BtnSave.BackgroundImage = Global.Paints.My.Resources.Resources.save_2_18
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Enabled = False
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(150, 35)
        Me.BtnSave.Text = "حفظ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BtnSavePrint
        '
        Me.BtnSavePrint.AutoSize = False
        Me.BtnSavePrint.Enabled = False
        Me.BtnSavePrint.Image = Global.Paints.My.Resources.Resources.HP_Printer
        Me.BtnSavePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSavePrint.Name = "BtnSavePrint"
        Me.BtnSavePrint.Size = New System.Drawing.Size(150, 35)
        Me.BtnSavePrint.Text = "حفظ و طباعة"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'BtnDelete
        '
        Me.BtnDelete.AutoSize = False
        Me.BtnDelete.BackgroundImage = Global.Paints.My.Resources.Resources.EXIT_2_22
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(150, 35)
        Me.BtnDelete.Text = "خروج"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 38)
        Me.ToolStripSeparator12.Visible = False
        '
        'BtnHelp
        '
        Me.BtnHelp.Image = Global.Paints.My.Resources.Resources.Symbol_Help
        Me.BtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(62, 35)
        Me.BtnHelp.Text = "مساعدة"
        Me.BtnHelp.ToolTipText = "Help"
        Me.BtnHelp.Visible = False
        '
        'GroupHeader
        '
        Me.GroupHeader.BackColor = System.Drawing.Color.Transparent
        Me.GroupHeader.Controls.Add(Me.StockID)
        Me.GroupHeader.Controls.Add(Me.VisitName)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel6)
        Me.GroupHeader.Controls.Add(Me.EmpStockID)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel4)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel17)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel8)
        Me.GroupHeader.Controls.Add(Me.EmployeeID)
        Me.GroupHeader.Enabled = False
        Me.GroupHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupHeader.Location = New System.Drawing.Point(17, 60)
        Me.GroupHeader.Name = "GroupHeader"
        Me.GroupHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupHeader.Size = New System.Drawing.Size(1259, 116)
        Me.GroupHeader.TabIndex = 80
        Me.GroupHeader.TabStop = False
        Me.GroupHeader.Text = "البيانات الأساسية"
        '
        'StockID
        '
        Me.StockID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockID.Location = New System.Drawing.Point(458, 61)
        Me.StockID.Name = "StockID"
        Me.StockID.Size = New System.Drawing.Size(218, 30)
        Me.StockID.TabIndex = 113
        Me.StockID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VisitName
        '
        Me.VisitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisitName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitName.Location = New System.Drawing.Point(849, 25)
        Me.VisitName.Name = "VisitName"
        Me.VisitName.Size = New System.Drawing.Size(218, 30)
        Me.VisitName.TabIndex = 112
        Me.VisitName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GeneralLabel6
        '
        Me.GeneralLabel6.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel6.BackgroundImage = CType(resources.GetObject("GeneralLabel6.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel6.IsRequired = True
        Me.GeneralLabel6.Location = New System.Drawing.Point(1073, 25)
        Me.GeneralLabel6.Name = "GeneralLabel6"
        Me.GeneralLabel6.SetLabelTxt = "كود/اسم الجوله :"
        Me.GeneralLabel6.Size = New System.Drawing.Size(148, 30)
        Me.GeneralLabel6.TabIndex = 111
        Me.GeneralLabel6.TabStop = False
        '
        'EmpStockID
        '
        Me.EmpStockID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpStockID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpStockID.Location = New System.Drawing.Point(458, 25)
        Me.EmpStockID.Name = "EmpStockID"
        Me.EmpStockID.Size = New System.Drawing.Size(218, 30)
        Me.EmpStockID.TabIndex = 110
        Me.EmpStockID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GeneralLabel4
        '
        Me.GeneralLabel4.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel4.BackgroundImage = CType(resources.GetObject("GeneralLabel4.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel4.IsRequired = True
        Me.GeneralLabel4.Location = New System.Drawing.Point(682, 61)
        Me.GeneralLabel4.Name = "GeneralLabel4"
        Me.GeneralLabel4.SetLabelTxt = "محول من :"
        Me.GeneralLabel4.Size = New System.Drawing.Size(148, 30)
        Me.GeneralLabel4.TabIndex = 105
        Me.GeneralLabel4.TabStop = False
        '
        'GeneralLabel17
        '
        Me.GeneralLabel17.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel17.BackgroundImage = CType(resources.GetObject("GeneralLabel17.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel17.IsRequired = True
        Me.GeneralLabel17.Location = New System.Drawing.Point(682, 25)
        Me.GeneralLabel17.Name = "GeneralLabel17"
        Me.GeneralLabel17.SetLabelTxt = "مخزن العهده :"
        Me.GeneralLabel17.Size = New System.Drawing.Size(148, 30)
        Me.GeneralLabel17.TabIndex = 103
        Me.GeneralLabel17.TabStop = False
        '
        'GeneralLabel8
        '
        Me.GeneralLabel8.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel8.BackgroundImage = CType(resources.GetObject("GeneralLabel8.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel8.IsRequired = True
        Me.GeneralLabel8.Location = New System.Drawing.Point(1073, 61)
        Me.GeneralLabel8.Name = "GeneralLabel8"
        Me.GeneralLabel8.SetLabelTxt = "مشرف الجوله :"
        Me.GeneralLabel8.Size = New System.Drawing.Size(148, 30)
        Me.GeneralLabel8.TabIndex = 95
        Me.GeneralLabel8.TabStop = False
        '
        'EmployeeID
        '
        Me.EmployeeID.BackColor = System.Drawing.Color.Gainsboro
        Me.EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmployeeID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.Color.Black
        Me.EmployeeID.Location = New System.Drawing.Point(849, 61)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(218, 30)
        Me.EmployeeID.TabIndex = 80
        Me.EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupItems
        '
        Me.GroupItems.BackColor = System.Drawing.Color.Transparent
        Me.GroupItems.Controls.Add(Me.GroupBox3)
        Me.GroupItems.Controls.Add(Me.GroupBox2)
        Me.GroupItems.Enabled = False
        Me.GroupItems.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupItems.Location = New System.Drawing.Point(17, 182)
        Me.GroupItems.Name = "GroupItems"
        Me.GroupItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupItems.Size = New System.Drawing.Size(1259, 154)
        Me.GroupItems.TabIndex = 81
        Me.GroupItems.TabStop = False
        Me.GroupItems.Text = "البيانات العامة للأصناف"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboUmDetailID)
        Me.GroupBox3.Controls.Add(Me.GeneralLabel19)
        Me.GroupBox3.Controls.Add(Me.GeneralLabel13)
        Me.GroupBox3.Controls.Add(Me.Quantity)
        Me.GroupBox3.Location = New System.Drawing.Point(147, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 110)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "بيانات الأصناف المشتراة"
        '
        'ComboUmDetailID
        '
        Me.ComboUmDetailID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboUmDetailID.FormattingEnabled = True
        Me.ComboUmDetailID.Location = New System.Drawing.Point(31, 68)
        Me.ComboUmDetailID.Name = "ComboUmDetailID"
        Me.ComboUmDetailID.Size = New System.Drawing.Size(293, 26)
        Me.ComboUmDetailID.TabIndex = 105
        '
        'GeneralLabel19
        '
        Me.GeneralLabel19.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel19.BackgroundImage = CType(resources.GetObject("GeneralLabel19.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel19.IsRequired = True
        Me.GeneralLabel19.Location = New System.Drawing.Point(330, 68)
        Me.GeneralLabel19.Name = "GeneralLabel19"
        Me.GeneralLabel19.SetLabelTxt = "وحدة القياس :"
        Me.GeneralLabel19.Size = New System.Drawing.Size(118, 26)
        Me.GeneralLabel19.TabIndex = 104
        Me.GeneralLabel19.TabStop = False
        '
        'GeneralLabel13
        '
        Me.GeneralLabel13.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel13.BackgroundImage = CType(resources.GetObject("GeneralLabel13.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel13.IsRequired = True
        Me.GeneralLabel13.Location = New System.Drawing.Point(330, 32)
        Me.GeneralLabel13.Name = "GeneralLabel13"
        Me.GeneralLabel13.SetLabelTxt = "العدد :"
        Me.GeneralLabel13.Size = New System.Drawing.Size(118, 26)
        Me.GeneralLabel13.TabIndex = 71
        Me.GeneralLabel13.TabStop = False
        '
        'Quantity
        '
        Me.Quantity.BackColor = System.Drawing.Color.Gainsboro
        Me.Quantity.Location = New System.Drawing.Point(31, 32)
        Me.Quantity.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(293, 26)
        Me.Quantity.TabIndex = 60
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SplitContainer2)
        Me.GroupBox2.Controls.Add(Me.BarCode)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(650, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 110)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الأصناف المختارة"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer2.Location = New System.Drawing.Point(26, 32)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ItemName)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(289, 26)
        Me.SplitContainer2.SplitterDistance = 237
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 107
        '
        'ItemName
        '
        Me.ItemName.BackColor = System.Drawing.Color.Gainsboro
        Me.ItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemName.FormattingEnabled = True
        Me.ItemName.Location = New System.Drawing.Point(0, 0)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(237, 26)
        Me.ItemName.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Paints.My.Resources.Resources.Back
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 26)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BarCode
        '
        Me.BarCode.BackColor = System.Drawing.Color.Gainsboro
        Me.BarCode.Location = New System.Drawing.Point(26, 69)
        Me.BarCode.Name = "BarCode"
        Me.BarCode.Size = New System.Drawing.Size(289, 26)
        Me.BarCode.TabIndex = 3
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(329, 70)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(106, 22)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "بحث بالباركود"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(334, 34)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "بحث بالاسم"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupAvailable
        '
        Me.GroupAvailable.BackColor = System.Drawing.Color.Transparent
        Me.GroupAvailable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GroupAvailable.Controls.Add(Me.Panel2)
        Me.GroupAvailable.Enabled = False
        Me.GroupAvailable.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupAvailable.Location = New System.Drawing.Point(17, 351)
        Me.GroupAvailable.Name = "GroupAvailable"
        Me.GroupAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupAvailable.Size = New System.Drawing.Size(608, 379)
        Me.GroupAvailable.TabIndex = 83
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 375)
        Me.Panel2.TabIndex = 20
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(602, 373)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "مخزن العهده"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(596, 348)
        Me.DataGridView2.TabIndex = 0
        '
        'GroupDetails
        '
        Me.GroupDetails.BackColor = System.Drawing.Color.Transparent
        Me.GroupDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GroupDetails.Controls.Add(Me.Panel3)
        Me.GroupDetails.Enabled = False
        Me.GroupDetails.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDetails.Location = New System.Drawing.Point(668, 351)
        Me.GroupDetails.Name = "GroupDetails"
        Me.GroupDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupDetails.Size = New System.Drawing.Size(608, 379)
        Me.GroupDetails.TabIndex = 82
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(604, 375)
        Me.Panel3.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 373)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مخزن الجوله"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(596, 348)
        Me.DataGridView1.TabIndex = 0
        '
        'AdjustmentVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1293, 748)
        Me.Controls.Add(Me.GroupAvailable)
        Me.Controls.Add(Me.GroupDetails)
        Me.Controls.Add(Me.GroupItems)
        Me.Controls.Add(Me.GroupHeader)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AdjustmentVisit"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تحميل جوله بالأصناف"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupHeader.ResumeLayout(False)
        Me.GroupItems.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupAvailable.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDetails.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSavePrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupHeader As System.Windows.Forms.GroupBox
    Friend WithEvents GeneralLabel4 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel17 As Paints.GeneralLabel
    Friend WithEvents GroupItems As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboUmDetailID As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralLabel19 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel13 As Paints.GeneralLabel
    Friend WithEvents Quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ItemName As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BarCode As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupAvailable As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupDetails As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ComboSalesRepID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VisitName As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel6 As Paints.GeneralLabel
    Friend WithEvents EmpStockID As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel8 As Paints.GeneralLabel
    Friend WithEvents EmployeeID As System.Windows.Forms.Label
    Friend WithEvents StockID As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
