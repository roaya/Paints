<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersRequests
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersRequests))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSavePrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.NavigationBar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.OrderByCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CountRecords = New System.Windows.Forms.ToolStripLabel()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.GroupHeader = New System.Windows.Forms.GroupBox()
        Me.GeneralLabel5 = New Paints.GeneralLabel()
        Me.ExpiredDate = New System.Windows.Forms.DateTimePicker()
        Me.GeneralNumber = New System.Windows.Forms.NumericUpDown()
        Me.GeneralLabel21 = New Paints.GeneralLabel()
        Me.BtnNewCustomer = New System.Windows.Forms.Button()
        Me.BillID = New System.Windows.Forms.Label()
        Me.GeneralLabel7 = New Paints.GeneralLabel()
        Me.GeneralLabel8 = New Paints.GeneralLabel()
        Me.GeneralLabel4 = New Paints.GeneralLabel()
        Me.GeneralLabel3 = New Paints.GeneralLabel()
        Me.GeneralLabel2 = New Paints.GeneralLabel()
        Me.GeneralLabel1 = New Paints.GeneralLabel()
        Me.Comments = New Paints.GeneralTextBox()
        Me.CustomerID = New System.Windows.Forms.ComboBox()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.BillDate = New System.Windows.Forms.DateTimePicker()
        Me.BillTime = New System.Windows.Forms.Label()
        Me.GroupItems = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboUmDetailID = New System.Windows.Forms.ComboBox()
        Me.GeneralLabel19 = New Paints.GeneralLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GeneralLabel13 = New Paints.GeneralLabel()
        Me.Quantity = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ItemName = New System.Windows.Forms.ComboBox()
        Me.BarCode = New System.Windows.Forms.TextBox()
        Me.RadioBarcode = New System.Windows.Forms.RadioButton()
        Me.RadioItemName = New System.Windows.Forms.RadioButton()
        Me.GroupDetails = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.NavigationBar.SuspendLayout()
        Me.ContentPanel.SuspendLayout()
        Me.GroupHeader.SuspendLayout()
        CType(Me.GeneralNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupItems.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupDetails.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator2, Me.BtnSave, Me.ToolStripSeparator1, Me.BtnSavePrint, Me.ToolStripSeparator3, Me.BtnDelete, Me.ToolStripSeparator5, Me.BtnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1183, 38)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.AutoSize = False
        Me.BtnNew.BackgroundImage = Global.Paints.My.Resources.Resources.without_texte_2_16
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(150, 35)
        Me.BtnNew.Text = "جديد"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
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
        Me.BtnSavePrint.BackgroundImage = Global.Paints.My.Resources.Resources.enter
        Me.BtnSavePrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.BtnDelete.BackgroundImage = Global.Paints.My.Resources.Resources.delete_2_21
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(150, 35)
        Me.BtnDelete.Text = "حذف"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 38)
        '
        'BtnExit
        '
        Me.BtnExit.AutoSize = False
        Me.BtnExit.BackgroundImage = Global.Paints.My.Resources.Resources.EXIT_2_22
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(150, 35)
        Me.BtnExit.Text = "خروج"
        '
        'NavigationBar
        '
        Me.NavigationBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavigationBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.NavigationBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.OrderByCombo, Me.ToolStripSeparator9, Me.ToolStripLabel2, Me.CountRecords})
        Me.NavigationBar.Location = New System.Drawing.Point(0, 682)
        Me.NavigationBar.Name = "NavigationBar"
        Me.NavigationBar.Size = New System.Drawing.Size(1183, 25)
        Me.NavigationBar.TabIndex = 23
        Me.NavigationBar.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel1.Text = "الترتيب"
        '
        'OrderByCombo
        '
        Me.OrderByCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderByCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrderByCombo.Name = "OrderByCombo"
        Me.OrderByCombo.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Image = Global.Paints.My.Resources.Resources.rar_256
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel2.Text = "عدد السجلات :"
        '
        'CountRecords
        '
        Me.CountRecords.Name = "CountRecords"
        Me.CountRecords.Size = New System.Drawing.Size(13, 22)
        Me.CountRecords.Text = "0"
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContentPanel.Controls.Add(Me.GroupHeader)
        Me.ContentPanel.Controls.Add(Me.GroupItems)
        Me.ContentPanel.Controls.Add(Me.GroupDetails)
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(0, 38)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(1183, 644)
        Me.ContentPanel.TabIndex = 24
        '
        'GroupHeader
        '
        Me.GroupHeader.BackColor = System.Drawing.Color.Transparent
        Me.GroupHeader.Controls.Add(Me.GeneralLabel5)
        Me.GroupHeader.Controls.Add(Me.ExpiredDate)
        Me.GroupHeader.Controls.Add(Me.GeneralNumber)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel21)
        Me.GroupHeader.Controls.Add(Me.BtnNewCustomer)
        Me.GroupHeader.Controls.Add(Me.BillID)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel7)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel8)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel4)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel3)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel2)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel1)
        Me.GroupHeader.Controls.Add(Me.Comments)
        Me.GroupHeader.Controls.Add(Me.CustomerID)
        Me.GroupHeader.Controls.Add(Me.EmployeeID)
        Me.GroupHeader.Controls.Add(Me.BillDate)
        Me.GroupHeader.Controls.Add(Me.BillTime)
        Me.GroupHeader.Enabled = False
        Me.GroupHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupHeader.Location = New System.Drawing.Point(11, 15)
        Me.GroupHeader.Name = "GroupHeader"
        Me.GroupHeader.Size = New System.Drawing.Size(1159, 149)
        Me.GroupHeader.TabIndex = 79
        Me.GroupHeader.TabStop = False
        Me.GroupHeader.Text = "البيانات الأساسية"
        '
        'GeneralLabel5
        '
        Me.GeneralLabel5.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel5.BackgroundImage = CType(resources.GetObject("GeneralLabel5.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel5.IsRequired = True
        Me.GeneralLabel5.Location = New System.Drawing.Point(611, 104)
        Me.GeneralLabel5.Name = "GeneralLabel5"
        Me.GeneralLabel5.SetLabelTxt = "تاريخ الانتهاء :"
        Me.GeneralLabel5.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel5.TabIndex = 137
        Me.GeneralLabel5.TabStop = False
        '
        'ExpiredDate
        '
        Me.ExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ExpiredDate.Location = New System.Drawing.Point(427, 104)
        Me.ExpiredDate.Name = "ExpiredDate"
        Me.ExpiredDate.RightToLeftLayout = True
        Me.ExpiredDate.Size = New System.Drawing.Size(181, 26)
        Me.ExpiredDate.TabIndex = 4
        '
        'GeneralNumber
        '
        Me.GeneralNumber.Location = New System.Drawing.Point(427, 70)
        Me.GeneralNumber.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.GeneralNumber.Name = "GeneralNumber"
        Me.GeneralNumber.Size = New System.Drawing.Size(181, 26)
        Me.GeneralNumber.TabIndex = 3
        Me.GeneralNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GeneralLabel21
        '
        Me.GeneralLabel21.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel21.BackgroundImage = CType(resources.GetObject("GeneralLabel21.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel21.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel21.IsRequired = True
        Me.GeneralLabel21.Location = New System.Drawing.Point(611, 69)
        Me.GeneralLabel21.Name = "GeneralLabel21"
        Me.GeneralLabel21.SetLabelTxt = "الرقم العام :"
        Me.GeneralLabel21.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel21.TabIndex = 134
        Me.GeneralLabel21.TabStop = False
        '
        'BtnNewCustomer
        '
        Me.BtnNewCustomer.BackgroundImage = Global.Paints.My.Resources.Resources.group_add_256
        Me.BtnNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewCustomer.Location = New System.Drawing.Point(426, 36)
        Me.BtnNewCustomer.Name = "BtnNewCustomer"
        Me.BtnNewCustomer.Size = New System.Drawing.Size(24, 27)
        Me.BtnNewCustomer.TabIndex = 21
        Me.BtnNewCustomer.TabStop = False
        Me.BtnNewCustomer.UseVisualStyleBackColor = True
        '
        'BillID
        '
        Me.BillID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BillID.Location = New System.Drawing.Point(808, 37)
        Me.BillID.Name = "BillID"
        Me.BillID.Size = New System.Drawing.Size(181, 26)
        Me.BillID.TabIndex = 101
        Me.BillID.Text = "0"
        Me.BillID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GeneralLabel7
        '
        Me.GeneralLabel7.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel7.BackgroundImage = CType(resources.GetObject("GeneralLabel7.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel7.IsRequired = False
        Me.GeneralLabel7.Location = New System.Drawing.Point(234, 71)
        Me.GeneralLabel7.Name = "GeneralLabel7"
        Me.GeneralLabel7.SetLabelTxt = "ملاحظات :"
        Me.GeneralLabel7.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel7.TabIndex = 96
        Me.GeneralLabel7.TabStop = False
        '
        'GeneralLabel8
        '
        Me.GeneralLabel8.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel8.BackgroundImage = CType(resources.GetObject("GeneralLabel8.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel8.IsRequired = True
        Me.GeneralLabel8.Location = New System.Drawing.Point(234, 37)
        Me.GeneralLabel8.Name = "GeneralLabel8"
        Me.GeneralLabel8.SetLabelTxt = "اسم الموظف :"
        Me.GeneralLabel8.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel8.TabIndex = 95
        Me.GeneralLabel8.TabStop = False
        '
        'GeneralLabel4
        '
        Me.GeneralLabel4.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel4.BackgroundImage = CType(resources.GetObject("GeneralLabel4.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel4.IsRequired = True
        Me.GeneralLabel4.Location = New System.Drawing.Point(611, 37)
        Me.GeneralLabel4.Name = "GeneralLabel4"
        Me.GeneralLabel4.SetLabelTxt = "اسم العميل :"
        Me.GeneralLabel4.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel4.TabIndex = 91
        Me.GeneralLabel4.TabStop = False
        '
        'GeneralLabel3
        '
        Me.GeneralLabel3.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel3.BackgroundImage = CType(resources.GetObject("GeneralLabel3.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel3.IsRequired = True
        Me.GeneralLabel3.Location = New System.Drawing.Point(992, 104)
        Me.GeneralLabel3.Name = "GeneralLabel3"
        Me.GeneralLabel3.SetLabelTxt = "وقت الفاتورة :"
        Me.GeneralLabel3.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel3.TabIndex = 90
        Me.GeneralLabel3.TabStop = False
        '
        'GeneralLabel2
        '
        Me.GeneralLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel2.BackgroundImage = CType(resources.GetObject("GeneralLabel2.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel2.IsRequired = True
        Me.GeneralLabel2.Location = New System.Drawing.Point(992, 71)
        Me.GeneralLabel2.Name = "GeneralLabel2"
        Me.GeneralLabel2.SetLabelTxt = "تاريخ الفاتورة :"
        Me.GeneralLabel2.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel2.TabIndex = 89
        Me.GeneralLabel2.TabStop = False
        '
        'GeneralLabel1
        '
        Me.GeneralLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel1.BackgroundImage = CType(resources.GetObject("GeneralLabel1.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel1.IsRequired = True
        Me.GeneralLabel1.Location = New System.Drawing.Point(992, 37)
        Me.GeneralLabel1.Name = "GeneralLabel1"
        Me.GeneralLabel1.SetLabelTxt = "رقم الفاتورة :"
        Me.GeneralLabel1.Size = New System.Drawing.Size(117, 26)
        Me.GeneralLabel1.TabIndex = 88
        Me.GeneralLabel1.TabStop = False
        '
        'Comments
        '
        Me.Comments.BackColor = System.Drawing.Color.Gainsboro
        Me.Comments.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comments.IsEmail = False
        Me.Comments.IsNum = False
        Me.Comments.IsRequired = False
        Me.Comments.Location = New System.Drawing.Point(50, 71)
        Me.Comments.Margin = New System.Windows.Forms.Padding(4)
        Me.Comments.Name = "Comments"
        Me.Comments.SetLeaveColor = System.Drawing.Color.Red
        Me.Comments.Size = New System.Drawing.Size(181, 26)
        Me.Comments.TabIndex = 3
        Me.Comments.TabStop = False
        '
        'CustomerID
        '
        Me.CustomerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustomerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerID.FormattingEnabled = True
        Me.CustomerID.Location = New System.Drawing.Point(451, 37)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(157, 26)
        Me.CustomerID.TabIndex = 2
        '
        'EmployeeID
        '
        Me.EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmployeeID.ForeColor = System.Drawing.Color.Black
        Me.EmployeeID.Location = New System.Drawing.Point(50, 37)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(181, 26)
        Me.EmployeeID.TabIndex = 80
        Me.EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BillDate
        '
        Me.BillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BillDate.Location = New System.Drawing.Point(808, 71)
        Me.BillDate.Name = "BillDate"
        Me.BillDate.RightToLeftLayout = True
        Me.BillDate.Size = New System.Drawing.Size(181, 26)
        Me.BillDate.TabIndex = 1
        '
        'BillTime
        '
        Me.BillTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BillTime.ForeColor = System.Drawing.Color.Black
        Me.BillTime.Location = New System.Drawing.Point(808, 104)
        Me.BillTime.Name = "BillTime"
        Me.BillTime.Size = New System.Drawing.Size(181, 26)
        Me.BillTime.TabIndex = 78
        Me.BillTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupItems
        '
        Me.GroupItems.BackColor = System.Drawing.Color.Transparent
        Me.GroupItems.Controls.Add(Me.GroupBox1)
        Me.GroupItems.Controls.Add(Me.GroupBox3)
        Me.GroupItems.Controls.Add(Me.GroupBox2)
        Me.GroupItems.Enabled = False
        Me.GroupItems.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupItems.Location = New System.Drawing.Point(11, 179)
        Me.GroupItems.Name = "GroupItems"
        Me.GroupItems.Size = New System.Drawing.Size(1159, 179)
        Me.GroupItems.TabIndex = 78
        Me.GroupItems.TabStop = False
        Me.GroupItems.Text = "البيانات العامة للأصناف"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboUmDetailID)
        Me.GroupBox1.Controls.Add(Me.GeneralLabel19)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 130)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تفاصيل وحدات القياس"
        '
        'ComboUmDetailID
        '
        Me.ComboUmDetailID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboUmDetailID.FormattingEnabled = True
        Me.ComboUmDetailID.Location = New System.Drawing.Point(29, 52)
        Me.ComboUmDetailID.Name = "ComboUmDetailID"
        Me.ComboUmDetailID.Size = New System.Drawing.Size(164, 26)
        Me.ComboUmDetailID.TabIndex = 7
        '
        'GeneralLabel19
        '
        Me.GeneralLabel19.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel19.BackgroundImage = CType(resources.GetObject("GeneralLabel19.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel19.IsRequired = True
        Me.GeneralLabel19.Location = New System.Drawing.Point(194, 52)
        Me.GeneralLabel19.Name = "GeneralLabel19"
        Me.GeneralLabel19.SetLabelTxt = "وحدة القياس :"
        Me.GeneralLabel19.Size = New System.Drawing.Size(124, 26)
        Me.GeneralLabel19.TabIndex = 70
        Me.GeneralLabel19.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GeneralLabel13)
        Me.GroupBox3.Controls.Add(Me.Quantity)
        Me.GroupBox3.Location = New System.Drawing.Point(381, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 130)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "بيانات الأصناف المشتراة"
        '
        'GeneralLabel13
        '
        Me.GeneralLabel13.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel13.BackgroundImage = CType(resources.GetObject("GeneralLabel13.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel13.IsRequired = True
        Me.GeneralLabel13.Location = New System.Drawing.Point(203, 52)
        Me.GeneralLabel13.Name = "GeneralLabel13"
        Me.GeneralLabel13.SetLabelTxt = "العدد :"
        Me.GeneralLabel13.Size = New System.Drawing.Size(83, 26)
        Me.GeneralLabel13.TabIndex = 71
        Me.GeneralLabel13.TabStop = False
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(16, 52)
        Me.Quantity.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(185, 26)
        Me.Quantity.TabIndex = 50
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ItemName)
        Me.GroupBox2.Controls.Add(Me.BarCode)
        Me.GroupBox2.Controls.Add(Me.RadioBarcode)
        Me.GroupBox2.Controls.Add(Me.RadioItemName)
        Me.GroupBox2.Location = New System.Drawing.Point(740, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 130)
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
        Me.ItemName.Location = New System.Drawing.Point(39, 37)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(226, 26)
        Me.ItemName.TabIndex = 5
        '
        'BarCode
        '
        Me.BarCode.Location = New System.Drawing.Point(39, 81)
        Me.BarCode.Name = "BarCode"
        Me.BarCode.Size = New System.Drawing.Size(226, 26)
        Me.BarCode.TabIndex = 6
        '
        'RadioBarcode
        '
        Me.RadioBarcode.AutoSize = True
        Me.RadioBarcode.Checked = True
        Me.RadioBarcode.Location = New System.Drawing.Point(269, 82)
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
        Me.RadioItemName.Location = New System.Drawing.Point(274, 37)
        Me.RadioItemName.Name = "RadioItemName"
        Me.RadioItemName.Size = New System.Drawing.Size(101, 22)
        Me.RadioItemName.TabIndex = 0
        Me.RadioItemName.Text = "بحث بالاسم"
        Me.RadioItemName.UseVisualStyleBackColor = True
        '
        'GroupDetails
        '
        Me.GroupDetails.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GroupDetails.Controls.Add(Me.Panel3)
        Me.GroupDetails.Enabled = False
        Me.GroupDetails.Location = New System.Drawing.Point(11, 364)
        Me.GroupDetails.Name = "GroupDetails"
        Me.GroupDetails.Size = New System.Drawing.Size(1159, 266)
        Me.GroupDetails.TabIndex = 77
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1155, 262)
        Me.Panel3.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.Size = New System.Drawing.Size(1153, 260)
        Me.DataGridView1.TabIndex = 0
        '
        'CustomersRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1183, 707)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.NavigationBar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "CustomersRequests"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "طلبات العميل"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.NavigationBar.ResumeLayout(False)
        Me.NavigationBar.PerformLayout()
        Me.ContentPanel.ResumeLayout(False)
        Me.GroupHeader.ResumeLayout(False)
        CType(Me.GeneralNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupItems.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupDetails.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSavePrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents NavigationBar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents OrderByCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CountRecords As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents GroupHeader As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents BillID As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel7 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel8 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel4 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel3 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel2 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel1 As Paints.GeneralLabel
    Friend WithEvents Comments As Paints.GeneralTextBox
    Friend WithEvents CustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeID As System.Windows.Forms.Label
    Friend WithEvents BillDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BillTime As System.Windows.Forms.Label
    Friend WithEvents GroupItems As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboUmDetailID As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralLabel19 As Paints.GeneralLabel
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GeneralNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents GeneralLabel21 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel5 As Paints.GeneralLabel
    Friend WithEvents ExpiredDate As System.Windows.Forms.DateTimePicker
End Class
