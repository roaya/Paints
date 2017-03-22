<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsSalesDetails
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemsSalesDetails))
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.LblTradeName = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupItems = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Price = New System.Windows.Forms.NumericUpDown()
        Me.ComboUmDetailID = New System.Windows.Forms.ComboBox()
        Me.Quantity = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ItemName = New System.Windows.Forms.ComboBox()
        Me.BarCode = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GeneralLabel1 = New Paints.GeneralLabel()
        Me.GeneralLabel14 = New Paints.GeneralLabel()
        Me.GeneralLabel19 = New Paints.GeneralLabel()
        Me.GeneralLabel13 = New Paints.GeneralLabel()
        Me.ContentPanel.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupItems.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContentPanel.Controls.Add(Me.GroupBox4)
        Me.ContentPanel.Controls.Add(Me.GroupBox1)
        Me.ContentPanel.Controls.Add(Me.LblTradeName)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel1)
        Me.ContentPanel.Controls.Add(Me.GroupItems)
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(1269, 633)
        Me.ContentPanel.TabIndex = 24
        '
        'LblTradeName
        '
        Me.LblTradeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTradeName.Location = New System.Drawing.Point(740, 8)
        Me.LblTradeName.Name = "LblTradeName"
        Me.LblTradeName.Size = New System.Drawing.Size(361, 36)
        Me.LblTradeName.TabIndex = 82
        Me.LblTradeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(20, 242)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(604, 378)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "الأصناف المتاحه"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(598, 353)
        Me.DataGridView2.TabIndex = 0
        '
        'GroupItems
        '
        Me.GroupItems.BackColor = System.Drawing.Color.Transparent
        Me.GroupItems.Controls.Add(Me.GroupBox3)
        Me.GroupItems.Controls.Add(Me.GroupBox2)
        Me.GroupItems.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupItems.Location = New System.Drawing.Point(20, 62)
        Me.GroupItems.Name = "GroupItems"
        Me.GroupItems.Size = New System.Drawing.Size(1226, 174)
        Me.GroupItems.TabIndex = 78
        Me.GroupItems.TabStop = False
        Me.GroupItems.Text = "البيانات العامة للأصناف"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GeneralLabel14)
        Me.GroupBox3.Controls.Add(Me.Price)
        Me.GroupBox3.Controls.Add(Me.ComboUmDetailID)
        Me.GroupBox3.Controls.Add(Me.GeneralLabel19)
        Me.GroupBox3.Controls.Add(Me.GeneralLabel13)
        Me.GroupBox3.Controls.Add(Me.Quantity)
        Me.GroupBox3.Location = New System.Drawing.Point(155, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(448, 135)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "بيانات الأصناف المشتراة"
        '
        'Price
        '
        Me.Price.DecimalPlaces = 5
        Me.Price.Location = New System.Drawing.Point(37, 62)
        Me.Price.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(234, 26)
        Me.Price.TabIndex = 106
        Me.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboUmDetailID
        '
        Me.ComboUmDetailID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboUmDetailID.FormattingEnabled = True
        Me.ComboUmDetailID.Location = New System.Drawing.Point(37, 27)
        Me.ComboUmDetailID.Name = "ComboUmDetailID"
        Me.ComboUmDetailID.Size = New System.Drawing.Size(234, 26)
        Me.ComboUmDetailID.TabIndex = 105
        '
        'Quantity
        '
        Me.Quantity.BackColor = System.Drawing.Color.Gainsboro
        Me.Quantity.Location = New System.Drawing.Point(37, 97)
        Me.Quantity.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(234, 26)
        Me.Quantity.TabIndex = 60
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ItemName)
        Me.GroupBox2.Controls.Add(Me.BarCode)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(622, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 135)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الأصناف المختارة"
        '
        'ItemName
        '
        Me.ItemName.BackColor = System.Drawing.Color.Gainsboro
        Me.ItemName.FormattingEnabled = True
        Me.ItemName.Location = New System.Drawing.Point(35, 36)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(263, 26)
        Me.ItemName.TabIndex = 4
        '
        'BarCode
        '
        Me.BarCode.BackColor = System.Drawing.Color.Gainsboro
        Me.BarCode.Location = New System.Drawing.Point(35, 80)
        Me.BarCode.Name = "BarCode"
        Me.BarCode.Size = New System.Drawing.Size(263, 26)
        Me.BarCode.TabIndex = 3
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(307, 81)
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
        Me.RadioButton1.Location = New System.Drawing.Point(312, 37)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "بحث بالاسم"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(642, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 378)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "الاصناف المنقوله"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(598, 353)
        Me.DataGridView1.TabIndex = 0
        '
        'GeneralLabel1
        '
        Me.GeneralLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel1.BackgroundImage = CType(resources.GetObject("GeneralLabel1.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel1.IsRequired = True
        Me.GeneralLabel1.Location = New System.Drawing.Point(1107, 8)
        Me.GeneralLabel1.Name = "GeneralLabel1"
        Me.GeneralLabel1.SetLabelTxt = "الاسم التجاري :"
        Me.GeneralLabel1.Size = New System.Drawing.Size(139, 36)
        Me.GeneralLabel1.TabIndex = 81
        '
        'GeneralLabel14
        '
        Me.GeneralLabel14.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel14.BackgroundImage = CType(resources.GetObject("GeneralLabel14.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel14.IsRequired = True
        Me.GeneralLabel14.Location = New System.Drawing.Point(277, 62)
        Me.GeneralLabel14.Name = "GeneralLabel14"
        Me.GeneralLabel14.SetLabelTxt = "سعر الصنف :"
        Me.GeneralLabel14.Size = New System.Drawing.Size(135, 26)
        Me.GeneralLabel14.TabIndex = 107
        '
        'GeneralLabel19
        '
        Me.GeneralLabel19.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel19.BackgroundImage = CType(resources.GetObject("GeneralLabel19.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel19.IsRequired = True
        Me.GeneralLabel19.Location = New System.Drawing.Point(277, 27)
        Me.GeneralLabel19.Name = "GeneralLabel19"
        Me.GeneralLabel19.SetLabelTxt = "وحدة القياس :"
        Me.GeneralLabel19.Size = New System.Drawing.Size(135, 26)
        Me.GeneralLabel19.TabIndex = 104
        '
        'GeneralLabel13
        '
        Me.GeneralLabel13.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel13.BackgroundImage = CType(resources.GetObject("GeneralLabel13.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel13.IsRequired = True
        Me.GeneralLabel13.Location = New System.Drawing.Point(277, 97)
        Me.GeneralLabel13.Name = "GeneralLabel13"
        Me.GeneralLabel13.SetLabelTxt = "العدد :"
        Me.GeneralLabel13.Size = New System.Drawing.Size(135, 26)
        Me.GeneralLabel13.TabIndex = 71
        '
        'ItemsSalesDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 633)
        Me.Controls.Add(Me.ContentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ItemsSalesDetails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تفاصيل الصنف التجاري"
        Me.ContentPanel.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupItems.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupItems As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboUmDetailID As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralLabel19 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel13 As Paints.GeneralLabel
    Friend WithEvents Quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ItemName As System.Windows.Forms.ComboBox
    Friend WithEvents BarCode As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GeneralLabel1 As Paints.GeneralLabel
    Friend WithEvents LblTradeName As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel14 As Paints.GeneralLabel
    Friend WithEvents Price As System.Windows.Forms.NumericUpDown
End Class
