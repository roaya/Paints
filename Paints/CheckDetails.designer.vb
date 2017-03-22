<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckDetails))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.CheckID = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.RadioCheckClosed = New System.Windows.Forms.RadioButton()
        Me.RadioCheckOpened = New System.Windows.Forms.RadioButton()
        Me.GeneralLabel1 = New Paints.GeneralLabel()
        Me.GeneralLabel10 = New Paints.GeneralLabel()
        Me.GroupDetails = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupItems = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GeneralLabel2 = New Paints.GeneralLabel()
        Me.ExpiredDate = New System.Windows.Forms.DateTimePicker()
        Me.GeneralLabel13 = New Paints.GeneralLabel()
        Me.Quantity = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ItemName = New System.Windows.Forms.ComboBox()
        Me.BarCode = New System.Windows.Forms.TextBox()
        Me.RadioBarcode = New System.Windows.Forms.RadioButton()
        Me.RadioItemName = New System.Windows.Forms.RadioButton()
        Me.Col_Serial_PK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Check_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Item_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Item_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_System_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_User_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Expired_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Diff_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Check_Type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Col_Partner_ID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Col_Employee_ID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ContentPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        Me.GroupDetails.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupItems.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContentPanel.Controls.Add(Me.BtnSave)
        Me.ContentPanel.Controls.Add(Me.BtnExit)
        Me.ContentPanel.Controls.Add(Me.BtnNew)
        Me.ContentPanel.Controls.Add(Me.GroupBox1)
        Me.ContentPanel.Controls.Add(Me.GroupDetails)
        Me.ContentPanel.Controls.Add(Me.GroupItems)
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContentPanel.Size = New System.Drawing.Size(1368, 748)
        Me.ContentPanel.TabIndex = 116
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BackgroundImage = Global.Paints.My.Resources.Resources.main_screen_251
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSave.Location = New System.Drawing.Point(631, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(105, 61)
        Me.BtnSave.TabIndex = 119
        Me.BtnSave.TabStop = False
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BackgroundImage = Global.Paints.My.Resources.Resources.main_screen_251
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnExit.Location = New System.Drawing.Point(520, 6)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(105, 61)
        Me.BtnExit.TabIndex = 118
        Me.BtnExit.TabStop = False
        Me.BtnExit.Text = "خروج"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.Transparent
        Me.BtnNew.BackgroundImage = Global.Paints.My.Resources.Resources.main_screen_191
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Location = New System.Drawing.Point(742, 6)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(105, 61)
        Me.BtnNew.TabIndex = 117
        Me.BtnNew.TabStop = False
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.SplitContainer7)
        Me.GroupBox1.Controls.Add(Me.RadioCheckClosed)
        Me.GroupBox1.Controls.Add(Me.RadioCheckOpened)
        Me.GroupBox1.Controls.Add(Me.GeneralLabel1)
        Me.GroupBox1.Controls.Add(Me.GeneralLabel10)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(194, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(978, 77)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات العامة للأصناف"
        '
        'SplitContainer7
        '
        Me.SplitContainer7.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer7.Location = New System.Drawing.Point(520, 36)
        Me.SplitContainer7.Name = "SplitContainer7"
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.CheckID)
        Me.SplitContainer7.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.Button7)
        Me.SplitContainer7.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer7.Size = New System.Drawing.Size(237, 26)
        Me.SplitContainer7.SplitterDistance = 195
        Me.SplitContainer7.SplitterWidth = 1
        Me.SplitContainer7.TabIndex = 107
        '
        'CheckID
        '
        Me.CheckID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CheckID.FormattingEnabled = True
        Me.CheckID.Location = New System.Drawing.Point(0, 0)
        Me.CheckID.Name = "CheckID"
        Me.CheckID.Size = New System.Drawing.Size(195, 26)
        Me.CheckID.TabIndex = 58
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.Paints.My.Resources.Resources.Back
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(41, 26)
        Me.Button7.TabIndex = 0
        Me.Button7.UseVisualStyleBackColor = True
        '
        'RadioCheckClosed
        '
        Me.RadioCheckClosed.AutoSize = True
        Me.RadioCheckClosed.Location = New System.Drawing.Point(99, 38)
        Me.RadioCheckClosed.Name = "RadioCheckClosed"
        Me.RadioCheckClosed.Size = New System.Drawing.Size(59, 22)
        Me.RadioCheckClosed.TabIndex = 57
        Me.RadioCheckClosed.Text = "مغلق"
        Me.RadioCheckClosed.UseVisualStyleBackColor = True
        '
        'RadioCheckOpened
        '
        Me.RadioCheckOpened.AutoSize = True
        Me.RadioCheckOpened.Checked = True
        Me.RadioCheckOpened.Location = New System.Drawing.Point(185, 37)
        Me.RadioCheckOpened.Name = "RadioCheckOpened"
        Me.RadioCheckOpened.Size = New System.Drawing.Size(63, 22)
        Me.RadioCheckOpened.TabIndex = 56
        Me.RadioCheckOpened.TabStop = True
        Me.RadioCheckOpened.Text = "مفتوح"
        Me.RadioCheckOpened.UseVisualStyleBackColor = True
        '
        'GeneralLabel1
        '
        Me.GeneralLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel1.BackgroundImage = CType(resources.GetObject("GeneralLabel1.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel1.IsRequired = False
        Me.GeneralLabel1.Location = New System.Drawing.Point(269, 36)
        Me.GeneralLabel1.Name = "GeneralLabel1"
        Me.GeneralLabel1.SetLabelTxt = "حالة الجرد :"
        Me.GeneralLabel1.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel1.TabIndex = 55
        Me.GeneralLabel1.TabStop = False
        '
        'GeneralLabel10
        '
        Me.GeneralLabel10.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel10.BackgroundImage = CType(resources.GetObject("GeneralLabel10.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel10.IsRequired = False
        Me.GeneralLabel10.Location = New System.Drawing.Point(763, 36)
        Me.GeneralLabel10.Name = "GeneralLabel10"
        Me.GeneralLabel10.SetLabelTxt = "اسم الجرد :"
        Me.GeneralLabel10.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel10.TabIndex = 53
        Me.GeneralLabel10.TabStop = False
        '
        'GroupDetails
        '
        Me.GroupDetails.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GroupDetails.Controls.Add(Me.Panel3)
        Me.GroupDetails.Enabled = False
        Me.GroupDetails.Location = New System.Drawing.Point(17, 315)
        Me.GroupDetails.Name = "GroupDetails"
        Me.GroupDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupDetails.Size = New System.Drawing.Size(1333, 420)
        Me.GroupDetails.TabIndex = 114
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1329, 416)
        Me.Panel3.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Serial_PK, Me.Col_Check_ID, Me.Col_Item_ID, Me.Col_Item_Name, Me.Col_Barcode, Me.Col_System_Quantity, Me.Col_User_Quantity, Me.Col_Expired_Date, Me.Col_Diff_Quantity, Me.Col_Price, Me.Col_Check_Type, Me.Col_Partner_ID, Me.Col_Employee_ID})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1327, 414)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupItems
        '
        Me.GroupItems.BackColor = System.Drawing.Color.Transparent
        Me.GroupItems.Controls.Add(Me.GroupBox3)
        Me.GroupItems.Controls.Add(Me.GroupBox2)
        Me.GroupItems.Enabled = False
        Me.GroupItems.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupItems.ForeColor = System.Drawing.Color.Maroon
        Me.GroupItems.Location = New System.Drawing.Point(194, 170)
        Me.GroupItems.Name = "GroupItems"
        Me.GroupItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupItems.Size = New System.Drawing.Size(977, 134)
        Me.GroupItems.TabIndex = 115
        Me.GroupItems.TabStop = False
        Me.GroupItems.Text = "البيانات العامة للأصناف"
        Me.GroupItems.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GeneralLabel2)
        Me.GroupBox3.Controls.Add(Me.ExpiredDate)
        Me.GroupBox3.Controls.Add(Me.GeneralLabel13)
        Me.GroupBox3.Controls.Add(Me.Quantity)
        Me.GroupBox3.Location = New System.Drawing.Point(49, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 97)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "بيانات الأصناف المشتراة"
        '
        'GeneralLabel2
        '
        Me.GeneralLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel2.BackgroundImage = CType(resources.GetObject("GeneralLabel2.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel2.IsRequired = False
        Me.GeneralLabel2.Location = New System.Drawing.Point(247, 60)
        Me.GeneralLabel2.Name = "GeneralLabel2"
        Me.GeneralLabel2.SetLabelTxt = "تاريخ الصلاحية :"
        Me.GeneralLabel2.Size = New System.Drawing.Size(130, 26)
        Me.GeneralLabel2.TabIndex = 73
        Me.GeneralLabel2.TabStop = False
        '
        'ExpiredDate
        '
        Me.ExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ExpiredDate.Location = New System.Drawing.Point(21, 60)
        Me.ExpiredDate.Name = "ExpiredDate"
        Me.ExpiredDate.RightToLeftLayout = True
        Me.ExpiredDate.Size = New System.Drawing.Size(220, 26)
        Me.ExpiredDate.TabIndex = 75
        '
        'GeneralLabel13
        '
        Me.GeneralLabel13.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel13.BackgroundImage = CType(resources.GetObject("GeneralLabel13.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel13.IsRequired = False
        Me.GeneralLabel13.Location = New System.Drawing.Point(247, 24)
        Me.GeneralLabel13.Name = "GeneralLabel13"
        Me.GeneralLabel13.SetLabelTxt = "العدد الموجود :"
        Me.GeneralLabel13.Size = New System.Drawing.Size(130, 26)
        Me.GeneralLabel13.TabIndex = 71
        Me.GeneralLabel13.TabStop = False
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(21, 24)
        Me.Quantity.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(220, 26)
        Me.Quantity.TabIndex = 80
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ItemName)
        Me.GroupBox2.Controls.Add(Me.BarCode)
        Me.GroupBox2.Controls.Add(Me.RadioBarcode)
        Me.GroupBox2.Controls.Add(Me.RadioItemName)
        Me.GroupBox2.Location = New System.Drawing.Point(494, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 98)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الأصناف المختارة"
        '
        'ItemName
        '
        Me.ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ItemName.Enabled = False
        Me.ItemName.FormattingEnabled = True
        Me.ItemName.Location = New System.Drawing.Point(33, 25)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(240, 26)
        Me.ItemName.TabIndex = 70
        '
        'BarCode
        '
        Me.BarCode.Location = New System.Drawing.Point(33, 61)
        Me.BarCode.Name = "BarCode"
        Me.BarCode.Size = New System.Drawing.Size(240, 26)
        Me.BarCode.TabIndex = 70
        '
        'RadioBarcode
        '
        Me.RadioBarcode.AutoSize = True
        Me.RadioBarcode.Checked = True
        Me.RadioBarcode.Location = New System.Drawing.Point(276, 62)
        Me.RadioBarcode.Name = "RadioBarcode"
        Me.RadioBarcode.Size = New System.Drawing.Size(106, 22)
        Me.RadioBarcode.TabIndex = 1
        Me.RadioBarcode.TabStop = True
        Me.RadioBarcode.Text = "بحث بالباركود"
        Me.RadioBarcode.UseVisualStyleBackColor = True
        '
        'RadioItemName
        '
        Me.RadioItemName.AutoSize = True
        Me.RadioItemName.Location = New System.Drawing.Point(279, 26)
        Me.RadioItemName.Name = "RadioItemName"
        Me.RadioItemName.Size = New System.Drawing.Size(101, 22)
        Me.RadioItemName.TabIndex = 0
        Me.RadioItemName.Text = "بحث بالاسم"
        Me.RadioItemName.UseVisualStyleBackColor = True
        '
        'Col_Serial_PK
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Serial_PK.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col_Serial_PK.HeaderText = "Col_Serial_PK"
        Me.Col_Serial_PK.Name = "Col_Serial_PK"
        Me.Col_Serial_PK.Visible = False
        '
        'Col_Check_ID
        '
        Me.Col_Check_ID.HeaderText = "Col_Check_ID"
        Me.Col_Check_ID.Name = "Col_Check_ID"
        Me.Col_Check_ID.Visible = False
        '
        'Col_Item_ID
        '
        Me.Col_Item_ID.HeaderText = "Col_Item_ID"
        Me.Col_Item_ID.Name = "Col_Item_ID"
        Me.Col_Item_ID.Visible = False
        '
        'Col_Item_Name
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Item_Name.DefaultCellStyle = DataGridViewCellStyle4
        Me.Col_Item_Name.HeaderText = "اسم الصنف"
        Me.Col_Item_Name.Name = "Col_Item_Name"
        Me.Col_Item_Name.ReadOnly = True
        '
        'Col_Barcode
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Barcode.DefaultCellStyle = DataGridViewCellStyle5
        Me.Col_Barcode.HeaderText = "الباركود"
        Me.Col_Barcode.Name = "Col_Barcode"
        Me.Col_Barcode.ReadOnly = True
        '
        'Col_System_Quantity
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_System_Quantity.DefaultCellStyle = DataGridViewCellStyle6
        Me.Col_System_Quantity.HeaderText = "العدد الموجود بالبرنامج"
        Me.Col_System_Quantity.Name = "Col_System_Quantity"
        Me.Col_System_Quantity.ReadOnly = True
        '
        'Col_User_Quantity
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_User_Quantity.DefaultCellStyle = DataGridViewCellStyle7
        Me.Col_User_Quantity.HeaderText = "العدد المدخل"
        Me.Col_User_Quantity.Name = "Col_User_Quantity"
        '
        'Col_Expired_Date
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Expired_Date.DefaultCellStyle = DataGridViewCellStyle8
        Me.Col_Expired_Date.HeaderText = "تاريخ الصلاحيه"
        Me.Col_Expired_Date.Name = "Col_Expired_Date"
        Me.Col_Expired_Date.ReadOnly = True
        '
        'Col_Diff_Quantity
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Diff_Quantity.DefaultCellStyle = DataGridViewCellStyle9
        Me.Col_Diff_Quantity.HeaderText = "الفرق"
        Me.Col_Diff_Quantity.Name = "Col_Diff_Quantity"
        Me.Col_Diff_Quantity.ReadOnly = True
        '
        'Col_Price
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Price.DefaultCellStyle = DataGridViewCellStyle10
        Me.Col_Price.HeaderText = "سعر التكلفه"
        Me.Col_Price.Name = "Col_Price"
        Me.Col_Price.ReadOnly = True
        '
        'Col_Check_Type
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Check_Type.DefaultCellStyle = DataGridViewCellStyle11
        Me.Col_Check_Type.HeaderText = "سبب الفرق"
        Me.Col_Check_Type.Items.AddRange(New Object() {"لا يوجد", "طبيعي", "جاري الشركاء", "موظف", "زياده مخزنيه"})
        Me.Col_Check_Type.Name = "Col_Check_Type"
        Me.Col_Check_Type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_Check_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Col_Partner_ID
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Partner_ID.DefaultCellStyle = DataGridViewCellStyle12
        Me.Col_Partner_ID.HeaderText = "جاري الشركاء"
        Me.Col_Partner_ID.Name = "Col_Partner_ID"
        Me.Col_Partner_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_Partner_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Col_Employee_ID
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col_Employee_ID.DefaultCellStyle = DataGridViewCellStyle13
        Me.Col_Employee_ID.HeaderText = "الموظف المسئول"
        Me.Col_Employee_ID.Name = "Col_Employee_ID"
        Me.Col_Employee_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_Employee_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CheckDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 748)
        Me.Controls.Add(Me.ContentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CheckDetails"
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تفاصيل الجرد"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContentPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        Me.GroupDetails.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupItems.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupItems As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GeneralLabel13 As Paints.GeneralLabel
    Friend WithEvents Quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ItemName As System.Windows.Forms.ComboBox
    Friend WithEvents BarCode As System.Windows.Forms.TextBox
    Friend WithEvents RadioBarcode As System.Windows.Forms.RadioButton
    Friend WithEvents RadioItemName As System.Windows.Forms.RadioButton
    Friend WithEvents GroupDetails As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GeneralLabel10 As Paints.GeneralLabel
    Friend WithEvents RadioCheckClosed As System.Windows.Forms.RadioButton
    Friend WithEvents RadioCheckOpened As System.Windows.Forms.RadioButton
    Friend WithEvents GeneralLabel1 As Paints.GeneralLabel
    Friend WithEvents CheckID As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GeneralLabel2 As Paints.GeneralLabel
    Friend WithEvents ExpiredDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Col_Serial_PK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Check_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Item_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Item_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_System_Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_User_Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Expired_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Diff_Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Check_Type As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Col_Partner_ID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Col_Employee_ID As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
