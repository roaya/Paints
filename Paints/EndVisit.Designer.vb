<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndVisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndVisit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboSalesRepID = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSavePrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupHeader = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioClosed = New System.Windows.Forms.RadioButton()
        Me.RadioFinished = New System.Windows.Forms.RadioButton()
        Me.StockID = New System.Windows.Forms.Label()
        Me.VisitName = New System.Windows.Forms.Label()
        Me.GeneralLabel6 = New Paints.GeneralLabel()
        Me.EmpStockID = New System.Windows.Forms.Label()
        Me.GeneralLabel4 = New Paints.GeneralLabel()
        Me.GeneralLabel17 = New Paints.GeneralLabel()
        Me.GeneralLabel8 = New Paints.GeneralLabel()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupDetails = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupHeader.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ComboSalesRepID, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.BtnSave, Me.ToolStripSeparator1, Me.BtnSavePrint, Me.ToolStripSeparator3, Me.BtnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(1290, 38)
        Me.ToolStrip1.TabIndex = 23
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackgroundImage = Global.Paints.My.Resources.Resources.enter
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        'GroupHeader
        '
        Me.GroupHeader.BackColor = System.Drawing.Color.Transparent
        Me.GroupHeader.Controls.Add(Me.GroupBox5)
        Me.GroupHeader.Controls.Add(Me.StockID)
        Me.GroupHeader.Controls.Add(Me.VisitName)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel6)
        Me.GroupHeader.Controls.Add(Me.EmpStockID)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel4)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel17)
        Me.GroupHeader.Controls.Add(Me.GeneralLabel8)
        Me.GroupHeader.Controls.Add(Me.EmployeeID)
        Me.GroupHeader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupHeader.Location = New System.Drawing.Point(28, 51)
        Me.GroupHeader.Name = "GroupHeader"
        Me.GroupHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupHeader.Size = New System.Drawing.Size(1232, 141)
        Me.GroupHeader.TabIndex = 86
        Me.GroupHeader.TabStop = False
        Me.GroupHeader.Text = "البيانات الأساسية"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioClosed)
        Me.GroupBox5.Controls.Add(Me.RadioFinished)
        Me.GroupBox5.Location = New System.Drawing.Point(57, 44)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(309, 66)
        Me.GroupBox5.TabIndex = 115
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "حالة الجوله"
        '
        'RadioClosed
        '
        Me.RadioClosed.AutoSize = True
        Me.RadioClosed.Location = New System.Drawing.Point(56, 28)
        Me.RadioClosed.Name = "RadioClosed"
        Me.RadioClosed.Size = New System.Drawing.Size(63, 22)
        Me.RadioClosed.TabIndex = 2
        Me.RadioClosed.TabStop = True
        Me.RadioClosed.Text = "مغلقه"
        Me.RadioClosed.UseVisualStyleBackColor = True
        '
        'RadioFinished
        '
        Me.RadioFinished.AutoSize = True
        Me.RadioFinished.Checked = True
        Me.RadioFinished.Location = New System.Drawing.Point(180, 28)
        Me.RadioFinished.Name = "RadioFinished"
        Me.RadioFinished.Size = New System.Drawing.Size(66, 22)
        Me.RadioFinished.TabIndex = 1
        Me.RadioFinished.TabStop = True
        Me.RadioFinished.Text = "منتهيه"
        Me.RadioFinished.UseVisualStyleBackColor = True
        '
        'StockID
        '
        Me.StockID.BackColor = System.Drawing.Color.Gainsboro
        Me.StockID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StockID.Location = New System.Drawing.Point(446, 98)
        Me.StockID.Name = "StockID"
        Me.StockID.Size = New System.Drawing.Size(218, 25)
        Me.StockID.TabIndex = 4
        Me.StockID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VisitName
        '
        Me.VisitName.BackColor = System.Drawing.Color.Gainsboro
        Me.VisitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisitName.Location = New System.Drawing.Point(866, 43)
        Me.VisitName.Name = "VisitName"
        Me.VisitName.Size = New System.Drawing.Size(219, 25)
        Me.VisitName.TabIndex = 1
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
        Me.GeneralLabel6.Location = New System.Drawing.Point(1092, 43)
        Me.GeneralLabel6.Name = "GeneralLabel6"
        Me.GeneralLabel6.SetLabelTxt = "كود/اسم الجوله :"
        Me.GeneralLabel6.Size = New System.Drawing.Size(129, 25)
        Me.GeneralLabel6.TabIndex = 111
        Me.GeneralLabel6.TabStop = False
        '
        'EmpStockID
        '
        Me.EmpStockID.BackColor = System.Drawing.Color.Gainsboro
        Me.EmpStockID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpStockID.Location = New System.Drawing.Point(446, 44)
        Me.EmpStockID.Name = "EmpStockID"
        Me.EmpStockID.Size = New System.Drawing.Size(218, 25)
        Me.EmpStockID.TabIndex = 3
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
        Me.GeneralLabel4.Location = New System.Drawing.Point(670, 98)
        Me.GeneralLabel4.Name = "GeneralLabel4"
        Me.GeneralLabel4.SetLabelTxt = "محول من :"
        Me.GeneralLabel4.Size = New System.Drawing.Size(129, 25)
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
        Me.GeneralLabel17.Location = New System.Drawing.Point(670, 44)
        Me.GeneralLabel17.Name = "GeneralLabel17"
        Me.GeneralLabel17.SetLabelTxt = "مخزن العهده :"
        Me.GeneralLabel17.Size = New System.Drawing.Size(129, 25)
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
        Me.GeneralLabel8.Location = New System.Drawing.Point(1092, 97)
        Me.GeneralLabel8.Name = "GeneralLabel8"
        Me.GeneralLabel8.SetLabelTxt = "مشرف الجوله :"
        Me.GeneralLabel8.Size = New System.Drawing.Size(129, 25)
        Me.GeneralLabel8.TabIndex = 95
        Me.GeneralLabel8.TabStop = False
        '
        'EmployeeID
        '
        Me.EmployeeID.BackColor = System.Drawing.Color.Gainsboro
        Me.EmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmployeeID.ForeColor = System.Drawing.Color.Black
        Me.EmployeeID.Location = New System.Drawing.Point(867, 97)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(218, 25)
        Me.EmployeeID.TabIndex = 4
        Me.EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel3.Size = New System.Drawing.Size(1227, 526)
        Me.Panel3.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1225, 524)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مخزن العهده"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Size = New System.Drawing.Size(1219, 499)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupDetails
        '
        Me.GroupDetails.BackColor = System.Drawing.Color.Transparent
        Me.GroupDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GroupDetails.Controls.Add(Me.Panel3)
        Me.GroupDetails.Location = New System.Drawing.Point(26, 206)
        Me.GroupDetails.Name = "GroupDetails"
        Me.GroupDetails.Size = New System.Drawing.Size(1231, 530)
        Me.GroupDetails.TabIndex = 88
        '
        'EndVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Paints.My.Resources.Resources.Bigbg
        Me.ClientSize = New System.Drawing.Size(1290, 748)
        Me.Controls.Add(Me.GroupDetails)
        Me.Controls.Add(Me.GroupHeader)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "EndVisit"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انهاء الجوله"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupHeader.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ComboSalesRepID As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSavePrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupHeader As System.Windows.Forms.GroupBox
    Friend WithEvents StockID As System.Windows.Forms.Label
    Friend WithEvents VisitName As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel6 As Paints.GeneralLabel
    Friend WithEvents EmpStockID As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel4 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel17 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel8 As Paints.GeneralLabel
    Friend WithEvents EmployeeID As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupDetails As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioClosed As System.Windows.Forms.RadioButton
    Friend WithEvents RadioFinished As System.Windows.Forms.RadioButton
End Class
