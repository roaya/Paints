﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterRecordCustomerVendor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterRecordCustomerVendor))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboCustomerID = New System.Windows.Forms.ComboBox()
        Me.RadioCustomerVendor = New System.Windows.Forms.RadioButton()
        Me.RadioAllCustomer = New System.Windows.Forms.RadioButton()
        Me.RadioAllVendor = New System.Windows.Forms.RadioButton()
        Me.RadioCustomer = New System.Windows.Forms.RadioButton()
        Me.RadioVendor = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboVendorID = New System.Windows.Forms.ComboBox()
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
        Me.TabControl1.Size = New System.Drawing.Size(1290, 742)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.BackgroundImage = Global.Paints.My.Resources.Resources.Bigbg
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1282, 711)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "معاملات التقرير"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(476, 539)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 38)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(684, 539)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "عرض التقرير"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboCustomerID)
        Me.GroupBox1.Controls.Add(Me.RadioCustomerVendor)
        Me.GroupBox1.Controls.Add(Me.RadioAllCustomer)
        Me.GroupBox1.Controls.Add(Me.RadioAllVendor)
        Me.GroupBox1.Controls.Add(Me.RadioCustomer)
        Me.GroupBox1.Controls.Add(Me.RadioVendor)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.ComboVendorID)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(405, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 413)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معاملات التقرير"
        '
        'ComboCustomerID
        '
        Me.ComboCustomerID.FormattingEnabled = True
        Me.ComboCustomerID.Location = New System.Drawing.Point(84, 86)
        Me.ComboCustomerID.Name = "ComboCustomerID"
        Me.ComboCustomerID.Size = New System.Drawing.Size(214, 26)
        Me.ComboCustomerID.TabIndex = 4
        '
        'RadioCustomerVendor
        '
        Me.RadioCustomerVendor.AutoSize = True
        Me.RadioCustomerVendor.BackColor = System.Drawing.Color.Transparent
        Me.RadioCustomerVendor.Location = New System.Drawing.Point(291, 228)
        Me.RadioCustomerVendor.Name = "RadioCustomerVendor"
        Me.RadioCustomerVendor.Size = New System.Drawing.Size(134, 22)
        Me.RadioCustomerVendor.TabIndex = 7
        Me.RadioCustomerVendor.Text = "الموردين و العملاء"
        Me.RadioCustomerVendor.UseVisualStyleBackColor = False
        '
        'RadioAllCustomer
        '
        Me.RadioAllCustomer.AutoSize = True
        Me.RadioAllCustomer.BackColor = System.Drawing.Color.Transparent
        Me.RadioAllCustomer.Location = New System.Drawing.Point(335, 181)
        Me.RadioAllCustomer.Name = "RadioAllCustomer"
        Me.RadioAllCustomer.Size = New System.Drawing.Size(90, 22)
        Me.RadioAllCustomer.TabIndex = 6
        Me.RadioAllCustomer.Text = "كل العملاء"
        Me.RadioAllCustomer.UseVisualStyleBackColor = False
        '
        'RadioAllVendor
        '
        Me.RadioAllVendor.AutoSize = True
        Me.RadioAllVendor.BackColor = System.Drawing.Color.Transparent
        Me.RadioAllVendor.Location = New System.Drawing.Point(325, 134)
        Me.RadioAllVendor.Name = "RadioAllVendor"
        Me.RadioAllVendor.Size = New System.Drawing.Size(100, 22)
        Me.RadioAllVendor.TabIndex = 5
        Me.RadioAllVendor.Text = "كل الموردين"
        Me.RadioAllVendor.UseVisualStyleBackColor = False
        '
        'RadioCustomer
        '
        Me.RadioCustomer.AutoSize = True
        Me.RadioCustomer.BackColor = System.Drawing.Color.Transparent
        Me.RadioCustomer.Location = New System.Drawing.Point(327, 87)
        Me.RadioCustomer.Name = "RadioCustomer"
        Me.RadioCustomer.Size = New System.Drawing.Size(98, 22)
        Me.RadioCustomer.TabIndex = 3
        Me.RadioCustomer.Text = "عميل محدد"
        Me.RadioCustomer.UseVisualStyleBackColor = False
        '
        'RadioVendor
        '
        Me.RadioVendor.AutoSize = True
        Me.RadioVendor.BackColor = System.Drawing.Color.Transparent
        Me.RadioVendor.Checked = True
        Me.RadioVendor.Location = New System.Drawing.Point(334, 40)
        Me.RadioVendor.Name = "RadioVendor"
        Me.RadioVendor.Size = New System.Drawing.Size(91, 22)
        Me.RadioVendor.TabIndex = 1
        Me.RadioVendor.TabStop = True
        Me.RadioVendor.Text = "مورد محدد"
        Me.RadioVendor.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(48, 276)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 98)
        Me.Panel1.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(43, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(246, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "حتي تاريخ :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(43, 63)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(240, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "من تاريخ :"
        '
        'ComboVendorID
        '
        Me.ComboVendorID.FormattingEnabled = True
        Me.ComboVendorID.Location = New System.Drawing.Point(84, 39)
        Me.ComboVendorID.Name = "ComboVendorID"
        Me.ComboVendorID.Size = New System.Drawing.Size(214, 26)
        Me.ComboVendorID.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1282, 711)
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1276, 705)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MasterRecordCustomerVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 742)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "MasterRecordCustomerVendor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حسابات الموردين و العملاء"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents RadioVendor As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboVendorID As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComboCustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents RadioCustomerVendor As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAllCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAllVendor As System.Windows.Forms.RadioButton
End Class
