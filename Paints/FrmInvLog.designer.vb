<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInvLog))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioDate = New System.Windows.Forms.RadioButton()
        Me.ItemName = New System.Windows.Forms.ComboBox()
        Me.RadioDocType = New System.Windows.Forms.RadioButton()
        Me.StockName = New System.Windows.Forms.ComboBox()
        Me.DocType = New System.Windows.Forms.ComboBox()
        Me.RadioItemName = New System.Windows.Forms.RadioButton()
        Me.RadioStockName = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1010, 579)
        Me.TabControl1.TabIndex = 3
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1002, 550)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "معاملات التقرير"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(339, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 34)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(541, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "عرض التقرير"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.RadioDate)
        Me.GroupBox1.Controls.Add(Me.ItemName)
        Me.GroupBox1.Controls.Add(Me.RadioDocType)
        Me.GroupBox1.Controls.Add(Me.StockName)
        Me.GroupBox1.Controls.Add(Me.DocType)
        Me.GroupBox1.Controls.Add(Me.RadioItemName)
        Me.GroupBox1.Controls.Add(Me.RadioStockName)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(283, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معاملات التقرير"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(45, 212)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 130)
        Me.Panel1.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(246, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "حتي تاريخ :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(38, 83)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(254, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "من تاريخ :"
        '
        'RadioDate
        '
        Me.RadioDate.AutoSize = True
        Me.RadioDate.BackColor = System.Drawing.Color.Transparent
        Me.RadioDate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioDate.Location = New System.Drawing.Point(269, 176)
        Me.RadioDate.Name = "RadioDate"
        Me.RadioDate.Size = New System.Drawing.Size(160, 23)
        Me.RadioDate.TabIndex = 7
        Me.RadioDate.TabStop = True
        Me.RadioDate.Text = "الفلترة بالفترة الزمنية"
        Me.RadioDate.UseVisualStyleBackColor = False
        '
        'ItemName
        '
        Me.ItemName.Enabled = False
        Me.ItemName.FormattingEnabled = True
        Me.ItemName.Location = New System.Drawing.Point(43, 85)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(214, 26)
        Me.ItemName.TabIndex = 4
        '
        'RadioDocType
        '
        Me.RadioDocType.AutoSize = True
        Me.RadioDocType.BackColor = System.Drawing.Color.Transparent
        Me.RadioDocType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioDocType.Location = New System.Drawing.Point(272, 130)
        Me.RadioDocType.Name = "RadioDocType"
        Me.RadioDocType.Size = New System.Drawing.Size(157, 23)
        Me.RadioDocType.TabIndex = 5
        Me.RadioDocType.TabStop = True
        Me.RadioDocType.Text = "الفلترة بنوع المستند"
        Me.RadioDocType.UseVisualStyleBackColor = False
        '
        'StockName
        '
        Me.StockName.FormattingEnabled = True
        Me.StockName.Location = New System.Drawing.Point(43, 39)
        Me.StockName.Name = "StockName"
        Me.StockName.Size = New System.Drawing.Size(214, 26)
        Me.StockName.TabIndex = 2
        '
        'DocType
        '
        Me.DocType.Enabled = False
        Me.DocType.FormattingEnabled = True
        Me.DocType.Items.AddRange(New Object() {"اذن تحويل - صادر", "اذن تحويل - وارد", "فاتورة مشتريات", "فاتورة مبيعات", "ارتجاع عميل", "ارتجاع مورد"})
        Me.DocType.Location = New System.Drawing.Point(43, 131)
        Me.DocType.Name = "DocType"
        Me.DocType.Size = New System.Drawing.Size(214, 26)
        Me.DocType.TabIndex = 6
        '
        'RadioItemName
        '
        Me.RadioItemName.AutoSize = True
        Me.RadioItemName.BackColor = System.Drawing.Color.Transparent
        Me.RadioItemName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioItemName.Location = New System.Drawing.Point(275, 88)
        Me.RadioItemName.Name = "RadioItemName"
        Me.RadioItemName.Size = New System.Drawing.Size(154, 23)
        Me.RadioItemName.TabIndex = 3
        Me.RadioItemName.Text = "الفلترة باسم الصنف"
        Me.RadioItemName.UseVisualStyleBackColor = False
        '
        'RadioStockName
        '
        Me.RadioStockName.AutoSize = True
        Me.RadioStockName.BackColor = System.Drawing.Color.Transparent
        Me.RadioStockName.Checked = True
        Me.RadioStockName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioStockName.Location = New System.Drawing.Point(277, 40)
        Me.RadioStockName.Name = "RadioStockName"
        Me.RadioStockName.Size = New System.Drawing.Size(152, 23)
        Me.RadioStockName.TabIndex = 1
        Me.RadioStockName.TabStop = True
        Me.RadioStockName.Text = "الفلترة باسم المحل"
        Me.RadioStockName.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1002, 550)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "نتيجة التقرير"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(996, 544)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmInvLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 579)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInvLog"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير حركة المخزون"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StockName As System.Windows.Forms.ComboBox
    Friend WithEvents RadioItemName As System.Windows.Forms.RadioButton
    Friend WithEvents RadioStockName As System.Windows.Forms.RadioButton
    Friend WithEvents DocType As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RadioDate As System.Windows.Forms.RadioButton
    Friend WithEvents RadioDocType As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ItemName As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
