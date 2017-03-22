<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorsTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendorsTrans))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnHelp = New System.Windows.Forms.ToolStripButton()
        Me.NavigationBar = New System.Windows.Forms.ToolStrip()
        Me.BtnFirst = New System.Windows.Forms.ToolStripButton()
        Me.BtnPervious = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.OrderByCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnNext = New System.Windows.Forms.ToolStripButton()
        Me.BtnLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CountRecords = New System.Windows.Forms.ToolStripLabel()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.TotalDoc = New System.Windows.Forms.Label()
        Me.GeneralLabel4 = New Paints.GeneralLabel()
        Me.PayDate = New System.Windows.Forms.DateTimePicker()
        Me.GeneralLabel3 = New Paints.GeneralLabel()
        Me.GeneralLabel2 = New Paints.GeneralLabel()
        Me.PayedValue = New System.Windows.Forms.NumericUpDown()
        Me.VendorID = New System.Windows.Forms.ComboBox()
        Me.GeneralLabel1 = New Paints.GeneralLabel()
        Me.MasterField1 = New Paints.MasterField()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NavigationMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.NavigationBar.SuspendLayout()
        Me.ContentPanel.SuspendLayout()
        CType(Me.PayedValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.ToolStripSeparator2, Me.BtnSave, Me.ToolStripSeparator1, Me.BtnSearch, Me.ToolStripSeparator3, Me.BtnDelete, Me.ToolStripSeparator5, Me.BtnExit, Me.ToolStripSeparator12, Me.BtnHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(393, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNew
        '
        Me.BtnNew.Image = Global.Paints.My.Resources.Resources.Symbol_Add
        Me.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(48, 22)
        Me.BtnNew.Text = "ÃœÌœ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Image = Global.Paints.My.Resources.Resources.Save
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(46, 22)
        Me.BtnSave.Text = "Õ›Ÿ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnSearch
        '
        Me.BtnSearch.Image = Global.Paints.My.Resources.Resources.Edit
        Me.BtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(52, 22)
        Me.BtnSearch.Text = " ⁄œÌ·"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BtnDelete
        '
        Me.BtnDelete.Image = Global.Paints.My.Resources.Resources.Symbol_Delete
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(48, 22)
        Me.BtnDelete.Text = "Õ–›"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'BtnExit
        '
        Me.BtnExit.Image = Global.Paints.My.Resources.Resources.ExitRed
        Me.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(52, 22)
        Me.BtnExit.Text = "Œ—ÊÃ"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator12.Visible = False
        '
        'BtnHelp
        '
        Me.BtnHelp.Image = Global.Paints.My.Resources.Resources.Symbol_Help
        Me.BtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(62, 22)
        Me.BtnHelp.Text = "„”«⁄œ…"
        Me.BtnHelp.ToolTipText = "Help"
        Me.BtnHelp.Visible = False
        '
        'NavigationBar
        '
        Me.NavigationBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavigationBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.NavigationBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFirst, Me.BtnPervious, Me.ToolStripSeparator6, Me.ToolStripLabel1, Me.OrderByCombo, Me.ToolStripSeparator9, Me.BtnNext, Me.BtnLast, Me.ToolStripSeparator10, Me.ToolStripLabel2, Me.CountRecords})
        Me.NavigationBar.Location = New System.Drawing.Point(0, 181)
        Me.NavigationBar.Name = "NavigationBar"
        Me.NavigationBar.Size = New System.Drawing.Size(393, 25)
        Me.NavigationBar.TabIndex = 18
        Me.NavigationBar.Text = "ToolStrip2"
        '
        'BtnFirst
        '
        Me.BtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFirst.Image = Global.Paints.My.Resources.Resources.FirstRight
        Me.BtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(23, 22)
        Me.BtnFirst.Text = "ToolStripButton7"
        Me.BtnFirst.ToolTipText = "First Item"
        '
        'BtnPervious
        '
        Me.BtnPervious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPervious.Image = Global.Paints.My.Resources.Resources._Next
        Me.BtnPervious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPervious.Name = "BtnPervious"
        Me.BtnPervious.Size = New System.Drawing.Size(23, 22)
        Me.BtnPervious.Text = "ToolStripButton8"
        Me.BtnPervious.ToolTipText = "Previous Item"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel1.Text = "«· — Ì»"
        '
        'OrderByCombo
        '
        Me.OrderByCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderByCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrderByCombo.Name = "OrderByCombo"
        Me.OrderByCombo.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'BtnNext
        '
        Me.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNext.Image = Global.Paints.My.Resources.Resources.Previous
        Me.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(23, 22)
        Me.BtnNext.Text = "ToolStripButton9"
        Me.BtnNext.ToolTipText = "Next Item"
        '
        'BtnLast
        '
        Me.BtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLast.Image = Global.Paints.My.Resources.Resources.Left
        Me.BtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(23, 22)
        Me.BtnLast.Text = "ToolStripButton10"
        Me.BtnLast.ToolTipText = "Last Item"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Image = Global.Paints.My.Resources.Resources.rar_256
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel2.Text = "⁄œœ «·”Ã·«  :"
        '
        'CountRecords
        '
        Me.CountRecords.Name = "CountRecords"
        Me.CountRecords.Size = New System.Drawing.Size(13, 22)
        Me.CountRecords.Text = "0"
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContentPanel.Controls.Add(Me.TotalDoc)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel4)
        Me.ContentPanel.Controls.Add(Me.PayDate)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel3)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel2)
        Me.ContentPanel.Controls.Add(Me.PayedValue)
        Me.ContentPanel.Controls.Add(Me.VendorID)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel1)
        Me.ContentPanel.Controls.Add(Me.MasterField1)
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(0, 25)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(393, 156)
        Me.ContentPanel.TabIndex = 20
        '
        'TotalDoc
        '
        Me.TotalDoc.AutoSize = True
        Me.TotalDoc.Location = New System.Drawing.Point(373, 24)
        Me.TotalDoc.Name = "TotalDoc"
        Me.TotalDoc.Size = New System.Drawing.Size(13, 13)
        Me.TotalDoc.TabIndex = 21
        Me.TotalDoc.Text = "0"
        Me.TotalDoc.Visible = False
        '
        'GeneralLabel4
        '
        Me.GeneralLabel4.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel4.BackgroundImage = CType(resources.GetObject("GeneralLabel4.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel4.IsRequired = True
        Me.GeneralLabel4.Location = New System.Drawing.Point(266, 96)
        Me.GeneralLabel4.Name = "GeneralLabel4"
        Me.GeneralLabel4.SetLabelTxt = " «—ÌŒ «·œ›⁄ :"
        Me.GeneralLabel4.Size = New System.Drawing.Size(102, 20)
        Me.GeneralLabel4.TabIndex = 22
        '
        'PayDate
        '
        Me.PayDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PayDate.Location = New System.Drawing.Point(23, 96)
        Me.PayDate.Name = "PayDate"
        Me.PayDate.RightToLeftLayout = True
        Me.PayDate.Size = New System.Drawing.Size(241, 20)
        Me.PayDate.TabIndex = 21
        '
        'GeneralLabel3
        '
        Me.GeneralLabel3.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel3.BackgroundImage = CType(resources.GetObject("GeneralLabel3.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel3.IsRequired = True
        Me.GeneralLabel3.Location = New System.Drawing.Point(266, 70)
        Me.GeneralLabel3.Name = "GeneralLabel3"
        Me.GeneralLabel3.SetLabelTxt = "«·ﬁÌ„… «·„œ›Ê⁄… :"
        Me.GeneralLabel3.Size = New System.Drawing.Size(102, 20)
        Me.GeneralLabel3.TabIndex = 9
        '
        'GeneralLabel2
        '
        Me.GeneralLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel2.BackgroundImage = CType(resources.GetObject("GeneralLabel2.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel2.IsRequired = True
        Me.GeneralLabel2.Location = New System.Drawing.Point(266, 44)
        Me.GeneralLabel2.Name = "GeneralLabel2"
        Me.GeneralLabel2.SetLabelTxt = "«”„ «·„Ê—œ :"
        Me.GeneralLabel2.Size = New System.Drawing.Size(102, 20)
        Me.GeneralLabel2.TabIndex = 8
        '
        'PayedValue
        '
        Me.PayedValue.BackColor = System.Drawing.Color.Gainsboro
        Me.PayedValue.DecimalPlaces = 5
        Me.PayedValue.Location = New System.Drawing.Point(23, 70)
        Me.PayedValue.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.PayedValue.Name = "PayedValue"
        Me.PayedValue.Size = New System.Drawing.Size(241, 20)
        Me.PayedValue.TabIndex = 7
        Me.PayedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VendorID
        '
        Me.VendorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VendorID.FormattingEnabled = True
        Me.VendorID.Location = New System.Drawing.Point(23, 43)
        Me.VendorID.Name = "VendorID"
        Me.VendorID.Size = New System.Drawing.Size(241, 21)
        Me.VendorID.TabIndex = 6
        '
        'GeneralLabel1
        '
        Me.GeneralLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel1.BackgroundImage = CType(resources.GetObject("GeneralLabel1.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel1.IsRequired = True
        Me.GeneralLabel1.Location = New System.Drawing.Point(266, 16)
        Me.GeneralLabel1.Name = "GeneralLabel1"
        Me.GeneralLabel1.SetLabelTxt = "—ﬁ„ «–‰ «·œ›⁄ :"
        Me.GeneralLabel1.Size = New System.Drawing.Size(102, 20)
        Me.GeneralLabel1.TabIndex = 5
        '
        'MasterField1
        '
        Me.MasterField1.BackColor = System.Drawing.Color.Gainsboro
        Me.MasterField1.EnableField = False
        Me.MasterField1.EnableLockup = True
        Me.MasterField1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterField1.IsNum = True
        Me.MasterField1.IsRequired = True
        Me.MasterField1.Location = New System.Drawing.Point(23, 15)
        Me.MasterField1.Margin = New System.Windows.Forms.Padding(4)
        Me.MasterField1.Name = "MasterField1"
        Me.MasterField1.SetDisplayMember = "Vendors_Transactions.Doc_ID"
        Me.MasterField1.SetLeaveColor = System.Drawing.Color.Red
        Me.MasterField1.SetLockupImage = Nothing
        Me.MasterField1.SetValueMember = "Vendors_Transactions.Serial_PK"
        Me.MasterField1.Size = New System.Drawing.Size(241, 22)
        Me.MasterField1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NavigationMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(393, 24)
        Me.MenuStrip1.TabIndex = 158
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'NavigationMenu
        '
        Me.NavigationMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNew, Me.MenuSave, Me.MenuSearch, Me.MenuDelete, Me.MenuExit})
        Me.NavigationMenu.Name = "NavigationMenu"
        Me.NavigationMenu.Size = New System.Drawing.Size(84, 20)
        Me.NavigationMenu.Text = "AllComands"
        '
        'MenuNew
        '
        Me.MenuNew.Name = "MenuNew"
        Me.MenuNew.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.MenuNew.Size = New System.Drawing.Size(152, 22)
        Me.MenuNew.Text = "New"
        '
        'MenuSave
        '
        Me.MenuSave.Name = "MenuSave"
        Me.MenuSave.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.MenuSave.Size = New System.Drawing.Size(152, 22)
        Me.MenuSave.Text = "Save"
        '
        'MenuSearch
        '
        Me.MenuSearch.Name = "MenuSearch"
        Me.MenuSearch.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.MenuSearch.Size = New System.Drawing.Size(152, 22)
        Me.MenuSearch.Text = "Edit"
        '
        'MenuDelete
        '
        Me.MenuDelete.Name = "MenuDelete"
        Me.MenuDelete.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.MenuDelete.Size = New System.Drawing.Size(152, 22)
        Me.MenuDelete.Text = "Delete"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.MenuExit.Size = New System.Drawing.Size(152, 22)
        Me.MenuExit.Text = "Exit"
        '
        'VendorsTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 206)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.NavigationBar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendorsTrans"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.NavigationBar.ResumeLayout(False)
        Me.NavigationBar.PerformLayout()
        Me.ContentPanel.ResumeLayout(False)
        Me.ContentPanel.PerformLayout()
        CType(Me.PayedValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents NavigationBar As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPervious As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents OrderByCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CountRecords As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MasterField1 As Paints.MasterField
    Friend WithEvents GeneralLabel1 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel3 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel2 As Paints.GeneralLabel
    Friend WithEvents PayedValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents VendorID As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralLabel4 As Paints.GeneralLabel
    Friend WithEvents PayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalDoc As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NavigationMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
End Class
