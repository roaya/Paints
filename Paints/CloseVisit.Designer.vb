<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloseVisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CloseVisit))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VisitID = New System.Windows.Forms.ComboBox()
        Me.GeneralLabel13 = New Paints.GeneralLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Paints.My.Resources.Resources.enter
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(194, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "انهاء الجوله"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Paints.My.Resources.Resources.enter
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(54, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'VisitID
        '
        Me.VisitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VisitID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitID.FormattingEnabled = True
        Me.VisitID.Location = New System.Drawing.Point(36, 61)
        Me.VisitID.Name = "VisitID"
        Me.VisitID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.VisitID.Size = New System.Drawing.Size(282, 26)
        Me.VisitID.TabIndex = 2
        '
        'GeneralLabel13
        '
        Me.GeneralLabel13.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel13.BackgroundImage = CType(resources.GetObject("GeneralLabel13.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel13.IsRequired = True
        Me.GeneralLabel13.Location = New System.Drawing.Point(200, 33)
        Me.GeneralLabel13.Name = "GeneralLabel13"
        Me.GeneralLabel13.SetLabelTxt = "كود الجوله :"
        Me.GeneralLabel13.Size = New System.Drawing.Size(118, 26)
        Me.GeneralLabel13.TabIndex = 72
        Me.GeneralLabel13.TabStop = False
        '
        'CloseVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Paints.My.Resources.Resources.Bigbg
        Me.ClientSize = New System.Drawing.Size(354, 198)
        Me.Controls.Add(Me.GeneralLabel13)
        Me.Controls.Add(Me.VisitID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CloseVisit"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انهاء جوله"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents VisitID As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralLabel13 As Paints.GeneralLabel
End Class
