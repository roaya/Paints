<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChequesStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChequesStatus))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ComboProcedureID = New System.Windows.Forms.ComboBox()
        Me.CheckBoxRefuseProID = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChequeNo = New System.Windows.Forms.TextBox()
        Me.RadioChequeNo = New System.Windows.Forms.RadioButton()
        Me.RadioChequeStatus = New System.Windows.Forms.RadioButton()
        Me.ChequeStatus = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboProcedureID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxRefuseProID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChequeNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioChequeNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioChequeStatus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChequeStatus)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1041, 583)
        Me.SplitContainer1.SplitterDistance = 232
        Me.SplitContainer1.TabIndex = 0
        '
        'ComboProcedureID
        '
        Me.ComboProcedureID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProcedureID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboProcedureID.FormattingEnabled = True
        Me.ComboProcedureID.Items.AddRange(New Object() {"جديد", "غير محصل", "محصل", "غير منصرف", "منصرف"})
        Me.ComboProcedureID.Location = New System.Drawing.Point(20, 319)
        Me.ComboProcedureID.Name = "ComboProcedureID"
        Me.ComboProcedureID.Size = New System.Drawing.Size(192, 26)
        Me.ComboProcedureID.TabIndex = 6
        '
        'CheckBoxRefuseProID
        '
        Me.CheckBoxRefuseProID.AutoSize = True
        Me.CheckBoxRefuseProID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRefuseProID.Location = New System.Drawing.Point(30, 292)
        Me.CheckBoxRefuseProID.Name = "CheckBoxRefuseProID"
        Me.CheckBoxRefuseProID.Size = New System.Drawing.Size(182, 22)
        Me.CheckBoxRefuseProID.TabIndex = 5
        Me.CheckBoxRefuseProID.Text = "رفض الشيك علي حساب"
        Me.CheckBoxRefuseProID.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(10, 529)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 33)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "رفض"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(117, 529)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 33)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "تحصيل"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.Button2.Location = New System.Drawing.Point(10, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "صرف"
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
        Me.Button1.Location = New System.Drawing.Point(117, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "استعلام"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChequeNo
        '
        Me.ChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChequeNo.Enabled = False
        Me.ChequeNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeNo.Location = New System.Drawing.Point(20, 224)
        Me.ChequeNo.Name = "ChequeNo"
        Me.ChequeNo.Size = New System.Drawing.Size(192, 26)
        Me.ChequeNo.TabIndex = 4
        '
        'RadioChequeNo
        '
        Me.RadioChequeNo.AutoSize = True
        Me.RadioChequeNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioChequeNo.Location = New System.Drawing.Point(109, 198)
        Me.RadioChequeNo.Name = "RadioChequeNo"
        Me.RadioChequeNo.Size = New System.Drawing.Size(103, 22)
        Me.RadioChequeNo.TabIndex = 3
        Me.RadioChequeNo.Text = "رقم الشيك :"
        Me.RadioChequeNo.UseVisualStyleBackColor = True
        '
        'RadioChequeStatus
        '
        Me.RadioChequeStatus.AutoSize = True
        Me.RadioChequeStatus.Checked = True
        Me.RadioChequeStatus.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioChequeStatus.Location = New System.Drawing.Point(103, 93)
        Me.RadioChequeStatus.Name = "RadioChequeStatus"
        Me.RadioChequeStatus.Size = New System.Drawing.Size(109, 22)
        Me.RadioChequeStatus.TabIndex = 1
        Me.RadioChequeStatus.TabStop = True
        Me.RadioChequeStatus.Text = "حالة الشيك :"
        Me.RadioChequeStatus.UseVisualStyleBackColor = True
        '
        'ChequeStatus
        '
        Me.ChequeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChequeStatus.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeStatus.FormattingEnabled = True
        Me.ChequeStatus.Items.AddRange(New Object() {"جديد", "غير محصل", "محصل", "غير منصرف", "منصرف"})
        Me.ChequeStatus.Location = New System.Drawing.Point(20, 119)
        Me.ChequeStatus.Name = "ChequeStatus"
        Me.ChequeStatus.Size = New System.Drawing.Size(192, 26)
        Me.ChequeStatus.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(805, 583)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'ChequesStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Paints.My.Resources.Resources.Bigbg
        Me.ClientSize = New System.Drawing.Size(1041, 583)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChequesStatus"
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تفاصيل الشيكات"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents RadioChequeNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioChequeStatus As System.Windows.Forms.RadioButton
    Friend WithEvents ChequeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboProcedureID As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxRefuseProID As System.Windows.Forms.CheckBox
End Class
