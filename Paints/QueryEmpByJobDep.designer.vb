<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryEmpByJobDep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QueryEmpByJobDep))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.JobID = New System.Windows.Forms.ComboBox()
        Me.DepartmentID = New System.Windows.Forms.ComboBox()
        Me.RadioDepID = New System.Windows.Forms.RadioButton()
        Me.RadioJobID = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.JobID)
        Me.GroupBox1.Controls.Add(Me.DepartmentID)
        Me.GroupBox1.Controls.Add(Me.RadioDepID)
        Me.GroupBox1.Controls.Add(Me.RadioJobID)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(879, 75)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معاملات الاستعلام"
        '
        'JobID
        '
        Me.JobID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JobID.FormattingEnabled = True
        Me.JobID.Location = New System.Drawing.Point(467, 29)
        Me.JobID.Name = "JobID"
        Me.JobID.Size = New System.Drawing.Size(186, 21)
        Me.JobID.TabIndex = 46
        '
        'DepartmentID
        '
        Me.DepartmentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentID.Enabled = False
        Me.DepartmentID.FormattingEnabled = True
        Me.DepartmentID.Location = New System.Drawing.Point(109, 28)
        Me.DepartmentID.Name = "DepartmentID"
        Me.DepartmentID.Size = New System.Drawing.Size(186, 21)
        Me.DepartmentID.TabIndex = 44
        '
        'RadioDepID
        '
        Me.RadioDepID.Location = New System.Drawing.Point(301, 29)
        Me.RadioDepID.Name = "RadioDepID"
        Me.RadioDepID.Size = New System.Drawing.Size(83, 17)
        Me.RadioDepID.TabIndex = 40
        Me.RadioDepID.Text = "اسم الادارة"
        Me.RadioDepID.UseVisualStyleBackColor = True
        '
        'RadioJobID
        '
        Me.RadioJobID.Checked = True
        Me.RadioJobID.Location = New System.Drawing.Point(659, 30)
        Me.RadioJobID.Name = "RadioJobID"
        Me.RadioJobID.Size = New System.Drawing.Size(111, 17)
        Me.RadioJobID.TabIndex = 37
        Me.RadioJobID.TabStop = True
        Me.RadioJobID.Text = "المسمي الوظيفي"
        Me.RadioJobID.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(879, 435)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الأصناف المرتبطة بالمخزن"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.Size = New System.Drawing.Size(873, 416)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(685, 570)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 26)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "استعلام"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(122, 570)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 26)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'QueryEmpByJobDep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Paints.My.Resources.Resources.enter_screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 622)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QueryEmpByJobDep"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الاستعلام عن الموظف بالمسمي الوظيفي - الادارة"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents JobID As System.Windows.Forms.ComboBox
    Friend WithEvents DepartmentID As System.Windows.Forms.ComboBox
    Friend WithEvents RadioDepID As System.Windows.Forms.RadioButton
    Friend WithEvents RadioJobID As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
