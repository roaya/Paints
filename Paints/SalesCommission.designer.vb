<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesCommission
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Serial_PK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bill_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_ID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Commission_Pct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Commission_Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContentPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.White
        Me.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContentPanel.Controls.Add(Me.Button2)
        Me.ContentPanel.Controls.Add(Me.Button1)
        Me.ContentPanel.Controls.Add(Me.DataGridView1)
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(528, 314)
        Me.ContentPanel.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Œ—ÊÃ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(327, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Õ›Ÿ Ê Œ—ÊÃ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Serial_PK, Me.Bill_ID, Me.Employee_ID, Me.Commission_Pct, Me.Commission_Value})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 11)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'Serial_PK
        '
        Me.Serial_PK.HeaderText = "Serial_PK"
        Me.Serial_PK.Name = "Serial_PK"
        Me.Serial_PK.Visible = False
        '
        'Bill_ID
        '
        Me.Bill_ID.HeaderText = "Bill_ID"
        Me.Bill_ID.Name = "Bill_ID"
        Me.Bill_ID.Visible = False
        '
        'Employee_ID
        '
        Me.Employee_ID.HeaderText = "«”„ «·„ÊŸ›"
        Me.Employee_ID.Name = "Employee_ID"
        Me.Employee_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Employee_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Commission_Pct
        '
        Me.Commission_Pct.HeaderText = "‰”»… «·⁄„Ê·…"
        Me.Commission_Pct.Name = "Commission_Pct"
        '
        'Commission_Value
        '
        Me.Commission_Value.HeaderText = "ﬁÌ„… «·⁄„Ê·Â"
        Me.Commission_Value.Name = "Commission_Value"
        '
        'SalesCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.ContentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalesCommission"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContentPanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Serial_PK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bill_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employee_ID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Commission_Pct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Commission_Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
