<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryExpensesByPeriod
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QueryExpensesByPeriod))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioAllExpenses = New System.Windows.Forms.RadioButton()
        Me.EmployeeName = New System.Windows.Forms.ComboBox()
        Me.RadioEmployeeName = New System.Windows.Forms.RadioButton()
        Me.ExpenseName = New System.Windows.Forms.ComboBox()
        Me.CategoryID = New System.Windows.Forms.ComboBox()
        Me.RadioExpenseName = New System.Windows.Forms.RadioButton()
        Me.RadioExpenseCategory = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckByPeriod = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(933, 610)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = Global.Paints.My.Resources.Resources.enter_screen
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(925, 584)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "„⁄«„·«  «· ﬁ—Ì—"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(312, 526)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Œ—ÊÃ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(496, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "⁄—÷"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioAllExpenses)
        Me.GroupBox1.Controls.Add(Me.EmployeeName)
        Me.GroupBox1.Controls.Add(Me.RadioEmployeeName)
        Me.GroupBox1.Controls.Add(Me.ExpenseName)
        Me.GroupBox1.Controls.Add(Me.CategoryID)
        Me.GroupBox1.Controls.Add(Me.RadioExpenseName)
        Me.GroupBox1.Controls.Add(Me.RadioExpenseCategory)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(244, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 467)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "„⁄«„·«  «· ﬁ—Ì—"
        '
        'RadioAllExpenses
        '
        Me.RadioAllExpenses.AutoSize = True
        Me.RadioAllExpenses.BackColor = System.Drawing.Color.Transparent
        Me.RadioAllExpenses.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioAllExpenses.Location = New System.Drawing.Point(266, 202)
        Me.RadioAllExpenses.Name = "RadioAllExpenses"
        Me.RadioAllExpenses.Size = New System.Drawing.Size(127, 17)
        Me.RadioAllExpenses.TabIndex = 13
        Me.RadioAllExpenses.TabStop = True
        Me.RadioAllExpenses.Text = "«·›· —… »ﬂ· «·„’—Ê›« "
        Me.RadioAllExpenses.UseVisualStyleBackColor = False
        '
        'EmployeeName
        '
        Me.EmployeeName.FormattingEnabled = True
        Me.EmployeeName.Location = New System.Drawing.Point(44, 91)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(196, 21)
        Me.EmployeeName.TabIndex = 11
        '
        'RadioEmployeeName
        '
        Me.RadioEmployeeName.AutoSize = True
        Me.RadioEmployeeName.BackColor = System.Drawing.Color.Transparent
        Me.RadioEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioEmployeeName.Location = New System.Drawing.Point(266, 92)
        Me.RadioEmployeeName.Name = "RadioEmployeeName"
        Me.RadioEmployeeName.Size = New System.Drawing.Size(127, 17)
        Me.RadioEmployeeName.TabIndex = 12
        Me.RadioEmployeeName.TabStop = True
        Me.RadioEmployeeName.Text = "«·›· —… »«”„ «·„”∆Ê·"
        Me.RadioEmployeeName.UseVisualStyleBackColor = False
        '
        'ExpenseName
        '
        Me.ExpenseName.FormattingEnabled = True
        Me.ExpenseName.Location = New System.Drawing.Point(44, 148)
        Me.ExpenseName.Name = "ExpenseName"
        Me.ExpenseName.Size = New System.Drawing.Size(196, 21)
        Me.ExpenseName.TabIndex = 2
        '
        'CategoryID
        '
        Me.CategoryID.FormattingEnabled = True
        Me.CategoryID.Location = New System.Drawing.Point(44, 34)
        Me.CategoryID.Name = "CategoryID"
        Me.CategoryID.Size = New System.Drawing.Size(196, 21)
        Me.CategoryID.TabIndex = 10
        '
        'RadioExpenseName
        '
        Me.RadioExpenseName.AutoSize = True
        Me.RadioExpenseName.BackColor = System.Drawing.Color.Transparent
        Me.RadioExpenseName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioExpenseName.Location = New System.Drawing.Point(246, 149)
        Me.RadioExpenseName.Name = "RadioExpenseName"
        Me.RadioExpenseName.Size = New System.Drawing.Size(147, 17)
        Me.RadioExpenseName.TabIndex = 8
        Me.RadioExpenseName.TabStop = True
        Me.RadioExpenseName.Text = "«·›· —… » ›«’Ì· «·„’—Ê›« "
        Me.RadioExpenseName.UseVisualStyleBackColor = False
        '
        'RadioExpenseCategory
        '
        Me.RadioExpenseCategory.AutoSize = True
        Me.RadioExpenseCategory.BackColor = System.Drawing.Color.Transparent
        Me.RadioExpenseCategory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioExpenseCategory.Location = New System.Drawing.Point(266, 35)
        Me.RadioExpenseCategory.Name = "RadioExpenseCategory"
        Me.RadioExpenseCategory.Size = New System.Drawing.Size(127, 17)
        Me.RadioExpenseCategory.TabIndex = 1
        Me.RadioExpenseCategory.TabStop = True
        Me.RadioExpenseCategory.Text = "«·›· —… »»‰œ «·„’—Ê›« "
        Me.RadioExpenseCategory.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CheckByPeriod)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(18, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 203)
        Me.Panel2.TabIndex = 9
        '
        'CheckByPeriod
        '
        Me.CheckByPeriod.AutoSize = True
        Me.CheckByPeriod.BackColor = System.Drawing.Color.Transparent
        Me.CheckByPeriod.Location = New System.Drawing.Point(243, 19)
        Me.CheckByPeriod.Name = "CheckByPeriod"
        Me.CheckByPeriod.Size = New System.Drawing.Size(129, 17)
        Me.CheckByPeriod.TabIndex = 1
        Me.CheckByPeriod.Text = "«·›· —… »«·› —«  «·“„‰Ì…"
        Me.CheckByPeriod.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(27, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 130)
        Me.Panel1.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(246, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Õ Ì  «—ÌŒ :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(38, 83)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(254, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "„‰  «—ÌŒ :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(925, 584)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "‰ ÌÃ… «· ﬁ—Ì—"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.Size = New System.Drawing.Size(919, 530)
        Me.DataGridView1.TabIndex = 2
        '
        'QueryExpensesByPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 610)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QueryExpensesByPeriod"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«·«” ⁄·«„ »»Ì«‰«  «·„’—Ê›« "
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckByPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExpenseName As System.Windows.Forms.ComboBox
    Friend WithEvents RadioExpenseName As System.Windows.Forms.RadioButton
    Friend WithEvents RadioExpenseCategory As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeName As System.Windows.Forms.ComboBox
    Friend WithEvents RadioEmployeeName As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioAllExpenses As System.Windows.Forms.RadioButton
End Class
