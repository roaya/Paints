<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportIncome
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.IncomeDetails = New System.Windows.Forms.DataGridView()
        Me.Income = New System.Windows.Forms.DataGridView()
        Me.Type = New System.Windows.Forms.Label()
        Me.Shifts = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShiftName = New System.Windows.Forms.Label()
        Me.ShowReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.byemp = New System.Windows.Forms.CheckBox()
        Me.Check = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.emp = New System.Windows.Forms.ComboBox()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        CType(Me.IncomeDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Income, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.IncomeDetails)
        Me.TabPage1.Controls.Add(Me.Income)
        Me.TabPage1.Controls.Add(Me.Type)
        Me.TabPage1.Controls.Add(Me.Shifts)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1013, 640)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "معاملات التقرير"
        '
        'IncomeDetails
        '
        Me.IncomeDetails.AllowUserToAddRows = False
        Me.IncomeDetails.AllowUserToDeleteRows = False
        Me.IncomeDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IncomeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IncomeDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IncomeDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.IncomeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IncomeDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.IncomeDetails.Location = New System.Drawing.Point(6, 357)
        Me.IncomeDetails.Name = "IncomeDetails"
        Me.IncomeDetails.ReadOnly = True
        Me.IncomeDetails.RowHeadersVisible = False
        Me.IncomeDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IncomeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.IncomeDetails.Size = New System.Drawing.Size(587, 275)
        Me.IncomeDetails.TabIndex = 27
        '
        'Income
        '
        Me.Income.AllowUserToAddRows = False
        Me.Income.AllowUserToDeleteRows = False
        Me.Income.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Income.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Income.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Income.DefaultCellStyle = DataGridViewCellStyle4
        Me.Income.Location = New System.Drawing.Point(6, 151)
        Me.Income.Name = "Income"
        Me.Income.ReadOnly = True
        Me.Income.RowHeadersVisible = False
        Me.Income.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Income.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Income.Size = New System.Drawing.Size(587, 177)
        Me.Income.TabIndex = 26
        '
        'Type
        '
        Me.Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Type.Location = New System.Drawing.Point(8, 331)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(585, 23)
        Me.Type.TabIndex = 25
        Me.Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Shifts
        '
        Me.Shifts.AllowUserToAddRows = False
        Me.Shifts.AllowUserToDeleteRows = False
        Me.Shifts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Shifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Shifts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Shifts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Shifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Shifts.DefaultCellStyle = DataGridViewCellStyle6
        Me.Shifts.Location = New System.Drawing.Point(599, 151)
        Me.Shifts.Name = "Shifts"
        Me.Shifts.ReadOnly = True
        Me.Shifts.RowHeadersVisible = False
        Me.Shifts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Shifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Shifts.Size = New System.Drawing.Size(408, 481)
        Me.Shifts.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ShiftName)
        Me.GroupBox1.Controls.Add(Me.ShowReport)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ToDate)
        Me.GroupBox1.Controls.Add(Me.byemp)
        Me.GroupBox1.Controls.Add(Me.Check)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.emp)
        Me.GroupBox1.Controls.Add(Me.FromDate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1007, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معاملات التقرير"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(41, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 28)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "حركة المخزن"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "الوردية"
        '
        'ShiftName
        '
        Me.ShiftName.BackColor = System.Drawing.Color.LightGray
        Me.ShiftName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShiftName.ForeColor = System.Drawing.Color.Black
        Me.ShiftName.Location = New System.Drawing.Point(155, 107)
        Me.ShiftName.Name = "ShiftName"
        Me.ShiftName.Size = New System.Drawing.Size(334, 26)
        Me.ShiftName.TabIndex = 101
        Me.ShiftName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShowReport
        '
        Me.ShowReport.BackColor = System.Drawing.Color.Silver
        Me.ShowReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShowReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ShowReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ShowReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowReport.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowReport.Location = New System.Drawing.Point(41, 106)
        Me.ShowReport.Name = "ShowReport"
        Me.ShowReport.Size = New System.Drawing.Size(105, 28)
        Me.ShowReport.TabIndex = 23
        Me.ShowReport.Text = "عرض التقرير"
        Me.ShowReport.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(521, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "الى"
        '
        'ToDate
        '
        Me.ToDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ToDate.Location = New System.Drawing.Point(215, 25)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.RightToLeftLayout = True
        Me.ToDate.Size = New System.Drawing.Size(274, 26)
        Me.ToDate.TabIndex = 21
        '
        'byemp
        '
        Me.byemp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.byemp.AutoSize = True
        Me.byemp.Location = New System.Drawing.Point(918, 60)
        Me.byemp.Name = "byemp"
        Me.byemp.Size = New System.Drawing.Size(79, 22)
        Me.byemp.TabIndex = 20
        Me.byemp.Text = "بالموظف"
        Me.byemp.UseVisualStyleBackColor = True
        '
        'Check
        '
        Me.Check.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Check.BackColor = System.Drawing.Color.Silver
        Me.Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Check.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Check.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check.Location = New System.Drawing.Point(876, 92)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(95, 28)
        Me.Check.TabIndex = 3
        Me.Check.Text = "استعلام"
        Me.Check.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(918, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "التاريخ من"
        '
        'emp
        '
        Me.emp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emp.Enabled = False
        Me.emp.FormattingEnabled = True
        Me.emp.Location = New System.Drawing.Point(596, 60)
        Me.emp.Name = "emp"
        Me.emp.Size = New System.Drawing.Size(274, 26)
        Me.emp.TabIndex = 17
        '
        'FromDate
        '
        Me.FromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FromDate.Location = New System.Drawing.Point(596, 25)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.RightToLeftLayout = True
        Me.FromDate.Size = New System.Drawing.Size(274, 26)
        Me.FromDate.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1013, 640)
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1007, 634)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1021, 666)
        Me.TabControl1.TabIndex = 9
        '
        'FrmReportIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 666)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmReportIncome"
        Me.Text = "تقرير الدخل اليومي"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage1.ResumeLayout(False)
        CType(Me.IncomeDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Income, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Check As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents emp As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents byemp As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Shifts As System.Windows.Forms.DataGridView
    Friend WithEvents ShowReport As System.Windows.Forms.Button
    Friend WithEvents Type As System.Windows.Forms.Label
    Friend WithEvents Income As System.Windows.Forms.DataGridView
    Friend WithEvents IncomeDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShiftName As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button


End Class
