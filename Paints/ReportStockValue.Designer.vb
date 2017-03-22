<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportStockValue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportStockValue))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StockID = New System.Windows.Forms.ComboBox()
        Me.ItemName = New System.Windows.Forms.ComboBox()
        Me.RadioItemStock = New System.Windows.Forms.RadioButton()
        Me.RadioItemName = New System.Windows.Forms.RadioButton()
        Me.RadioStockID = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.StockID)
        Me.GroupBox1.Controls.Add(Me.ItemName)
        Me.GroupBox1.Controls.Add(Me.RadioItemStock)
        Me.GroupBox1.Controls.Add(Me.RadioItemName)
        Me.GroupBox1.Controls.Add(Me.RadioStockID)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(442, 236)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معاملات التقرير"
        '
        'StockID
        '
        Me.StockID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StockID.Enabled = False
        Me.StockID.FormattingEnabled = True
        Me.StockID.Location = New System.Drawing.Point(30, 41)
        Me.StockID.Name = "StockID"
        Me.StockID.Size = New System.Drawing.Size(253, 26)
        Me.StockID.TabIndex = 46
        '
        'ItemName
        '
        Me.ItemName.Enabled = False
        Me.ItemName.FormattingEnabled = True
        Me.ItemName.Location = New System.Drawing.Point(30, 106)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(253, 26)
        Me.ItemName.TabIndex = 42
        '
        'RadioItemStock
        '
        Me.RadioItemStock.Location = New System.Drawing.Point(288, 170)
        Me.RadioItemStock.Name = "RadioItemStock"
        Me.RadioItemStock.Size = New System.Drawing.Size(125, 26)
        Me.RadioItemStock.TabIndex = 39
        Me.RadioItemStock.Text = "المخزن و الصنف"
        Me.RadioItemStock.UseVisualStyleBackColor = True
        '
        'RadioItemName
        '
        Me.RadioItemName.Location = New System.Drawing.Point(288, 106)
        Me.RadioItemName.Name = "RadioItemName"
        Me.RadioItemName.Size = New System.Drawing.Size(125, 26)
        Me.RadioItemName.TabIndex = 38
        Me.RadioItemName.Text = "اسم الصنف"
        Me.RadioItemName.UseVisualStyleBackColor = True
        '
        'RadioStockID
        '
        Me.RadioStockID.Checked = True
        Me.RadioStockID.Location = New System.Drawing.Point(288, 42)
        Me.RadioStockID.Name = "RadioStockID"
        Me.RadioStockID.Size = New System.Drawing.Size(125, 26)
        Me.RadioStockID.TabIndex = 37
        Me.RadioStockID.TabStop = True
        Me.RadioStockID.Text = "اسم المخزن"
        Me.RadioStockID.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(68, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 31)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(285, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 31)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "استعلام"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReportStockValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(477, 339)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ReportStockValue"
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير تقييم المخزن"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StockID As System.Windows.Forms.ComboBox
    Friend WithEvents ItemName As System.Windows.Forms.ComboBox
    Friend WithEvents RadioItemStock As System.Windows.Forms.RadioButton
    Friend WithEvents RadioItemName As System.Windows.Forms.RadioButton
    Friend WithEvents RadioStockID As System.Windows.Forms.RadioButton
End Class
