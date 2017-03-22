<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shifts_details
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shifts_details))
        Me.ShiftID = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GeneralLabel1 = New Paints.GeneralLabel()
        Me.GeneralLabel2 = New Paints.GeneralLabel()
        Me.FirstBalance = New System.Windows.Forms.NumericUpDown()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShiftID
        '
        Me.ShiftID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShiftID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftID.FormattingEnabled = True
        Me.ShiftID.Location = New System.Drawing.Point(495, 93)
        Me.ShiftID.Name = "ShiftID"
        Me.ShiftID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShiftID.Size = New System.Drawing.Size(268, 26)
        Me.ShiftID.TabIndex = 34
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 157)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(915, 579)
        Me.DataGridView1.TabIndex = 39
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BackgroundImage = Global.Paints.My.Resources.Resources.save_2_18
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(580, 11)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(162, 57)
        Me.BtnSave.TabIndex = 112
        Me.BtnSave.Text = "«€·«ﬁ «·Ê—œÌÂ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNew.BackColor = System.Drawing.Color.Transparent
        Me.BtnNew.BackgroundImage = Global.Paints.My.Resources.Resources.without_texte_2_16
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(770, 14)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(162, 54)
        Me.BtnNew.TabIndex = 111
        Me.BtnNew.Text = "Ê—œÌÂ ÃœÌœÂ"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Paints.My.Resources.Resources.EXIT_2_22
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(390, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 57)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Œ—ÊÃ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GeneralLabel1
        '
        Me.GeneralLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneralLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel1.BackgroundImage = CType(resources.GetObject("GeneralLabel1.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel1.IsRequired = True
        Me.GeneralLabel1.Location = New System.Drawing.Point(770, 93)
        Me.GeneralLabel1.Name = "GeneralLabel1"
        Me.GeneralLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GeneralLabel1.SetLabelTxt = "«”„ «·Ê—œÌ… :"
        Me.GeneralLabel1.Size = New System.Drawing.Size(157, 26)
        Me.GeneralLabel1.TabIndex = 33
        '
        'GeneralLabel2
        '
        Me.GeneralLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneralLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel2.BackgroundImage = CType(resources.GetObject("GeneralLabel2.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel2.IsRequired = True
        Me.GeneralLabel2.Location = New System.Drawing.Point(770, 125)
        Me.GeneralLabel2.Name = "GeneralLabel2"
        Me.GeneralLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GeneralLabel2.SetLabelTxt = "«·—’Ìœ «·«›  «ÕÌ :"
        Me.GeneralLabel2.Size = New System.Drawing.Size(157, 26)
        Me.GeneralLabel2.TabIndex = 113
        '
        'FirstBalance
        '
        Me.FirstBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstBalance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.FirstBalance.Location = New System.Drawing.Point(495, 125)
        Me.FirstBalance.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.FirstBalance.Name = "FirstBalance"
        Me.FirstBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FirstBalance.Size = New System.Drawing.Size(268, 25)
        Me.FirstBalance.TabIndex = 114
        Me.FirstBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Shifts_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Paints.My.Resources.Resources.enter_screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 748)
        Me.Controls.Add(Me.FirstBalance)
        Me.Controls.Add(Me.GeneralLabel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShiftID)
        Me.Controls.Add(Me.GeneralLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Shifts_details"
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "› Õ Ê «€·«ﬁ «·Ê—œÌ« "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShiftID As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralLabel1 As Paints.GeneralLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GeneralLabel2 As Paints.GeneralLabel
    Friend WithEvents FirstBalance As System.Windows.Forms.NumericUpDown
End Class
