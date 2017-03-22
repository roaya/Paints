<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance))
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.type = New System.Windows.Forms.TextBox()
        Me.GeneralLabel4 = New Paints.GeneralLabel()
        Me.t = New System.Windows.Forms.TextBox()
        Me.d = New System.Windows.Forms.TextBox()
        Me.emp = New System.Windows.Forms.TextBox()
        Me.attendancetype = New System.Windows.Forms.TextBox()
        Me.GeneralLabel5 = New Paints.GeneralLabel()
        Me.Code = New System.Windows.Forms.TextBox()
        Me.AttendTime = New System.Windows.Forms.Label()
        Me.GeneralLabel3 = New Paints.GeneralLabel()
        Me.AttendDate = New System.Windows.Forms.Label()
        Me.GeneralLabel2 = New Paints.GeneralLabel()
        Me.EmployeeID = New System.Windows.Forms.ComboBox()
        Me.GeneralLabel1 = New Paints.GeneralLabel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ContentPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.ContentPanel.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContentPanel.Controls.Add(Me.type)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel4)
        Me.ContentPanel.Controls.Add(Me.t)
        Me.ContentPanel.Controls.Add(Me.d)
        Me.ContentPanel.Controls.Add(Me.emp)
        Me.ContentPanel.Controls.Add(Me.attendancetype)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel5)
        Me.ContentPanel.Controls.Add(Me.Code)
        Me.ContentPanel.Controls.Add(Me.AttendTime)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel3)
        Me.ContentPanel.Controls.Add(Me.AttendDate)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel2)
        Me.ContentPanel.Controls.Add(Me.EmployeeID)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel1)
        Me.ContentPanel.Location = New System.Drawing.Point(12, 12)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContentPanel.Size = New System.Drawing.Size(499, 273)
        Me.ContentPanel.TabIndex = 20
        '
        'type
        '
        Me.type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.type.Enabled = False
        Me.type.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.type.Location = New System.Drawing.Point(33, 214)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(290, 25)
        Me.type.TabIndex = 58
        Me.type.TabStop = False
        '
        'GeneralLabel4
        '
        Me.GeneralLabel4.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel4.BackgroundImage = CType(resources.GetObject("GeneralLabel4.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel4.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel4.IsRequired = False
        Me.GeneralLabel4.Location = New System.Drawing.Point(333, 212)
        Me.GeneralLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel4.Name = "GeneralLabel4"
        Me.GeneralLabel4.SetLabelTxt = "‰Ê⁄ «· ”ÃÌ· :"
        Me.GeneralLabel4.Size = New System.Drawing.Size(131, 27)
        Me.GeneralLabel4.TabIndex = 57
        Me.GeneralLabel4.TabStop = False
        '
        't
        '
        Me.t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t.Enabled = False
        Me.t.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.t.Location = New System.Drawing.Point(34, 173)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(290, 25)
        Me.t.TabIndex = 56
        '
        'd
        '
        Me.d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.d.Enabled = False
        Me.d.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.d.Location = New System.Drawing.Point(34, 130)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(290, 25)
        Me.d.TabIndex = 55
        '
        'emp
        '
        Me.emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emp.Enabled = False
        Me.emp.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.emp.Location = New System.Drawing.Point(34, 81)
        Me.emp.Name = "emp"
        Me.emp.Size = New System.Drawing.Size(290, 25)
        Me.emp.TabIndex = 2
        '
        'attendancetype
        '
        Me.attendancetype.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.attendancetype.Location = New System.Drawing.Point(119, 263)
        Me.attendancetype.Name = "attendancetype"
        Me.attendancetype.Size = New System.Drawing.Size(0, 25)
        Me.attendancetype.TabIndex = 53
        '
        'GeneralLabel5
        '
        Me.GeneralLabel5.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel5.BackgroundImage = CType(resources.GetObject("GeneralLabel5.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel5.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel5.IsRequired = True
        Me.GeneralLabel5.Location = New System.Drawing.Point(334, 34)
        Me.GeneralLabel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel5.Name = "GeneralLabel5"
        Me.GeneralLabel5.SetLabelTxt = "ﬂÊœ «·„ÊŸ›"
        Me.GeneralLabel5.Size = New System.Drawing.Size(131, 27)
        Me.GeneralLabel5.TabIndex = 52
        Me.GeneralLabel5.TabStop = False
        '
        'Code
        '
        Me.Code.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Code.Location = New System.Drawing.Point(35, 34)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(290, 25)
        Me.Code.TabIndex = 1
        '
        'AttendTime
        '
        Me.AttendTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttendTime.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendTime.Location = New System.Drawing.Point(44, 179)
        Me.AttendTime.Name = "AttendTime"
        Me.AttendTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AttendTime.Size = New System.Drawing.Size(0, 28)
        Me.AttendTime.TabIndex = 3
        '
        'GeneralLabel3
        '
        Me.GeneralLabel3.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel3.BackgroundImage = CType(resources.GetObject("GeneralLabel3.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel3.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel3.IsRequired = False
        Me.GeneralLabel3.Location = New System.Drawing.Point(334, 170)
        Me.GeneralLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel3.Name = "GeneralLabel3"
        Me.GeneralLabel3.SetLabelTxt = "Êﬁ  «· ”ÃÌ·"
        Me.GeneralLabel3.Size = New System.Drawing.Size(131, 27)
        Me.GeneralLabel3.TabIndex = 50
        Me.GeneralLabel3.TabStop = False
        '
        'AttendDate
        '
        Me.AttendDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttendDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendDate.Location = New System.Drawing.Point(44, 136)
        Me.AttendDate.Name = "AttendDate"
        Me.AttendDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AttendDate.Size = New System.Drawing.Size(0, 28)
        Me.AttendDate.TabIndex = 2
        '
        'GeneralLabel2
        '
        Me.GeneralLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel2.BackgroundImage = CType(resources.GetObject("GeneralLabel2.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel2.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel2.IsRequired = False
        Me.GeneralLabel2.Location = New System.Drawing.Point(334, 127)
        Me.GeneralLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel2.Name = "GeneralLabel2"
        Me.GeneralLabel2.SetLabelTxt = " «—ÌŒ «· ”ÃÌ· :"
        Me.GeneralLabel2.Size = New System.Drawing.Size(131, 27)
        Me.GeneralLabel2.TabIndex = 48
        Me.GeneralLabel2.TabStop = False
        '
        'EmployeeID
        '
        Me.EmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.EmployeeID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.FormattingEnabled = True
        Me.EmployeeID.Location = New System.Drawing.Point(44, 90)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EmployeeID.Size = New System.Drawing.Size(0, 28)
        Me.EmployeeID.TabIndex = 1
        '
        'GeneralLabel1
        '
        Me.GeneralLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel1.BackgroundImage = CType(resources.GetObject("GeneralLabel1.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel1.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel1.IsRequired = False
        Me.GeneralLabel1.Location = New System.Drawing.Point(334, 81)
        Me.GeneralLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel1.Name = "GeneralLabel1"
        Me.GeneralLabel1.SetLabelTxt = "«”„ «·„ÊŸ› :"
        Me.GeneralLabel1.Size = New System.Drawing.Size(131, 27)
        Me.GeneralLabel1.TabIndex = 46
        Me.GeneralLabel1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(283, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(119, 64)
        Me.PictureBox5.TabIndex = 97
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Paints.My.Resources.Resources.enter_screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(527, 297)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Attendance"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "»Ì«‰«  «·Õ÷Ê— Ê«·«‰’—«›"
        Me.ContentPanel.ResumeLayout(False)
        Me.ContentPanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents AttendTime As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel3 As Paints.GeneralLabel
    Friend WithEvents AttendDate As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel2 As Paints.GeneralLabel
    Friend WithEvents EmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralLabel1 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel5 As Paints.GeneralLabel
    Friend WithEvents Code As System.Windows.Forms.TextBox
    Friend WithEvents attendancetype As System.Windows.Forms.TextBox
    Friend WithEvents t As System.Windows.Forms.TextBox
    Friend WithEvents d As System.Windows.Forms.TextBox
    Friend WithEvents emp As System.Windows.Forms.TextBox
    Friend WithEvents type As System.Windows.Forms.TextBox
    Friend WithEvents GeneralLabel4 As Paints.GeneralLabel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
