<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSalComm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportSalComm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBillStatus = New System.Windows.Forms.ComboBox()
        Me.RadioBillStatus = New System.Windows.Forms.RadioButton()
        Me.ComboBillID = New System.Windows.Forms.ComboBox()
        Me.RadioBillID = New System.Windows.Forms.RadioButton()
        Me.RadioEmployeeID = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboEmployeeID = New System.Windows.Forms.ComboBox()
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
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1034, 748)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1026, 717)
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
        Me.Button2.Location = New System.Drawing.Point(347, 548)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 30)
        Me.Button2.TabIndex = 4
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
        Me.Button1.Location = New System.Drawing.Point(553, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "عرض التقرير"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBillStatus)
        Me.GroupBox1.Controls.Add(Me.RadioBillStatus)
        Me.GroupBox1.Controls.Add(Me.ComboBillID)
        Me.GroupBox1.Controls.Add(Me.RadioBillID)
        Me.GroupBox1.Controls.Add(Me.RadioEmployeeID)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.ComboEmployeeID)
        Me.GroupBox1.Location = New System.Drawing.Point(295, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 364)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معاملات التقرير"
        '
        'ComboBillStatus
        '
        Me.ComboBillStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBillStatus.FormattingEnabled = True
        Me.ComboBillStatus.Items.AddRange(New Object() {"مفتوحه", "مغلقه"})
        Me.ComboBillStatus.Location = New System.Drawing.Point(67, 156)
        Me.ComboBillStatus.Name = "ComboBillStatus"
        Me.ComboBillStatus.Size = New System.Drawing.Size(213, 26)
        Me.ComboBillStatus.TabIndex = 17
        '
        'RadioBillStatus
        '
        Me.RadioBillStatus.AutoSize = True
        Me.RadioBillStatus.BackColor = System.Drawing.Color.Transparent
        Me.RadioBillStatus.Location = New System.Drawing.Point(291, 158)
        Me.RadioBillStatus.Name = "RadioBillStatus"
        Me.RadioBillStatus.Size = New System.Drawing.Size(101, 22)
        Me.RadioBillStatus.TabIndex = 16
        Me.RadioBillStatus.Text = "حالة الفاتوره"
        Me.RadioBillStatus.UseVisualStyleBackColor = False
        '
        'ComboBillID
        '
        Me.ComboBillID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBillID.FormattingEnabled = True
        Me.ComboBillID.Location = New System.Drawing.Point(67, 107)
        Me.ComboBillID.Name = "ComboBillID"
        Me.ComboBillID.Size = New System.Drawing.Size(213, 26)
        Me.ComboBillID.TabIndex = 15
        '
        'RadioBillID
        '
        Me.RadioBillID.AutoSize = True
        Me.RadioBillID.BackColor = System.Drawing.Color.Transparent
        Me.RadioBillID.Location = New System.Drawing.Point(293, 109)
        Me.RadioBillID.Name = "RadioBillID"
        Me.RadioBillID.Size = New System.Drawing.Size(95, 22)
        Me.RadioBillID.TabIndex = 14
        Me.RadioBillID.Text = "رقم الفاتوره"
        Me.RadioBillID.UseVisualStyleBackColor = False
        '
        'RadioEmployeeID
        '
        Me.RadioEmployeeID.AutoSize = True
        Me.RadioEmployeeID.BackColor = System.Drawing.Color.Transparent
        Me.RadioEmployeeID.Checked = True
        Me.RadioEmployeeID.Location = New System.Drawing.Point(285, 56)
        Me.RadioEmployeeID.Name = "RadioEmployeeID"
        Me.RadioEmployeeID.Size = New System.Drawing.Size(108, 22)
        Me.RadioEmployeeID.TabIndex = 13
        Me.RadioEmployeeID.TabStop = True
        Me.RadioEmployeeID.Text = "اسم الموظف"
        Me.RadioEmployeeID.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(46, 202)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 130)
        Me.Panel1.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(41, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(242, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "حتي تاريخ :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(41, 83)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(250, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "من تاريخ :"
        '
        'ComboEmployeeID
        '
        Me.ComboEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEmployeeID.FormattingEnabled = True
        Me.ComboEmployeeID.Location = New System.Drawing.Point(67, 54)
        Me.ComboEmployeeID.Name = "ComboEmployeeID"
        Me.ComboEmployeeID.Size = New System.Drawing.Size(212, 26)
        Me.ComboEmployeeID.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1026, 722)
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1020, 716)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReportSalComm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 748)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ReportSalComm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عرض بيانات العمولات خلال فتره محدده"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioBillID As System.Windows.Forms.RadioButton
    Friend WithEvents RadioEmployeeID As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComboBillID As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBillStatus As System.Windows.Forms.ComboBox
    Friend WithEvents RadioBillStatus As System.Windows.Forms.RadioButton
End Class
