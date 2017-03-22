<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAllItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAllItems))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Combcorpration = New System.Windows.Forms.ComboBox()
        Me.Radcorporation = New System.Windows.Forms.RadioButton()
        Me.Radcat = New System.Windows.Forms.RadioButton()
        Me.Combcat = New System.Windows.Forms.ComboBox()
        Me.Radbarcode = New System.Windows.Forms.RadioButton()
        Me.Raditemname = New System.Windows.Forms.RadioButton()
        Me.Radallitems = New System.Windows.Forms.RadioButton()
        Me.Txtbarcode = New System.Windows.Forms.TextBox()
        Me.Combitem = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1034, 748)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1026, 721)
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
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(319, 572)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Combcorpration)
        Me.GroupBox1.Controls.Add(Me.Radcorporation)
        Me.GroupBox1.Controls.Add(Me.Radcat)
        Me.GroupBox1.Controls.Add(Me.Combcat)
        Me.GroupBox1.Controls.Add(Me.Radbarcode)
        Me.GroupBox1.Controls.Add(Me.Raditemname)
        Me.GroupBox1.Controls.Add(Me.Radallitems)
        Me.GroupBox1.Controls.Add(Me.Txtbarcode)
        Me.GroupBox1.Controls.Add(Me.Combitem)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(248, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 381)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معاملات التقرير"
        '
        'Combcorpration
        '
        Me.Combcorpration.Enabled = False
        Me.Combcorpration.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combcorpration.FormattingEnabled = True
        Me.Combcorpration.Location = New System.Drawing.Point(56, 292)
        Me.Combcorpration.Name = "Combcorpration"
        Me.Combcorpration.Size = New System.Drawing.Size(275, 26)
        Me.Combcorpration.TabIndex = 9
        '
        'Radcorporation
        '
        Me.Radcorporation.AutoSize = True
        Me.Radcorporation.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radcorporation.Location = New System.Drawing.Point(367, 292)
        Me.Radcorporation.Name = "Radcorporation"
        Me.Radcorporation.Size = New System.Drawing.Size(106, 22)
        Me.Radcorporation.TabIndex = 8
        Me.Radcorporation.TabStop = True
        Me.Radcorporation.Text = "اسم الشركه"
        Me.Radcorporation.UseVisualStyleBackColor = True
        '
        'Radcat
        '
        Me.Radcat.AutoSize = True
        Me.Radcat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radcat.Location = New System.Drawing.Point(387, 232)
        Me.Radcat.Name = "Radcat"
        Me.Radcat.Size = New System.Drawing.Size(86, 22)
        Me.Radcat.TabIndex = 6
        Me.Radcat.TabStop = True
        Me.Radcat.Text = "اسم البند"
        Me.Radcat.UseVisualStyleBackColor = True
        '
        'Combcat
        '
        Me.Combcat.Enabled = False
        Me.Combcat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combcat.FormattingEnabled = True
        Me.Combcat.Location = New System.Drawing.Point(56, 232)
        Me.Combcat.Name = "Combcat"
        Me.Combcat.Size = New System.Drawing.Size(275, 26)
        Me.Combcat.TabIndex = 7
        '
        'Radbarcode
        '
        Me.Radbarcode.AutoSize = True
        Me.Radbarcode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbarcode.Location = New System.Drawing.Point(404, 174)
        Me.Radbarcode.Name = "Radbarcode"
        Me.Radbarcode.Size = New System.Drawing.Size(69, 22)
        Me.Radbarcode.TabIndex = 4
        Me.Radbarcode.TabStop = True
        Me.Radbarcode.Text = "الباركود"
        Me.Radbarcode.UseVisualStyleBackColor = True
        '
        'Raditemname
        '
        Me.Raditemname.AutoSize = True
        Me.Raditemname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Raditemname.Location = New System.Drawing.Point(373, 112)
        Me.Raditemname.Name = "Raditemname"
        Me.Raditemname.Size = New System.Drawing.Size(100, 22)
        Me.Raditemname.TabIndex = 2
        Me.Raditemname.TabStop = True
        Me.Raditemname.Text = "اسم الصنف"
        Me.Raditemname.UseVisualStyleBackColor = True
        '
        'Radallitems
        '
        Me.Radallitems.AutoSize = True
        Me.Radallitems.Checked = True
        Me.Radallitems.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radallitems.Location = New System.Drawing.Point(376, 55)
        Me.Radallitems.Name = "Radallitems"
        Me.Radallitems.Size = New System.Drawing.Size(96, 22)
        Me.Radallitems.TabIndex = 4
        Me.Radallitems.TabStop = True
        Me.Radallitems.Text = "كل الاصناف"
        Me.Radallitems.UseVisualStyleBackColor = True
        '
        'Txtbarcode
        '
        Me.Txtbarcode.Enabled = False
        Me.Txtbarcode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbarcode.Location = New System.Drawing.Point(56, 174)
        Me.Txtbarcode.Name = "Txtbarcode"
        Me.Txtbarcode.Size = New System.Drawing.Size(275, 26)
        Me.Txtbarcode.TabIndex = 5
        '
        'Combitem
        '
        Me.Combitem.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combitem.FormattingEnabled = True
        Me.Combitem.Location = New System.Drawing.Point(56, 111)
        Me.Combitem.Name = "Combitem"
        Me.Combitem.Size = New System.Drawing.Size(275, 26)
        Me.Combitem.TabIndex = 3
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
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(575, 572)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "استعلام"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1026, 721)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "نتيجه التقرير"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1020, 715)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmAllItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 748)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmAllItems"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير اسعار الاصناف"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Radbarcode As System.Windows.Forms.RadioButton
    Friend WithEvents Raditemname As System.Windows.Forms.RadioButton
    Friend WithEvents Radallitems As System.Windows.Forms.RadioButton
    Friend WithEvents Txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Combitem As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Radcorporation As System.Windows.Forms.RadioButton
    Friend WithEvents Radcat As System.Windows.Forms.RadioButton
    Friend WithEvents Combcat As System.Windows.Forms.ComboBox
    Friend WithEvents Combcorpration As System.Windows.Forms.ComboBox
End Class
