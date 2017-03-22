<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Corporations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Corporations))
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GeneralLabel2 = New Paints.GeneralLabel()
        Me.CorporationCode = New Paints.GeneralTextBox()
        Me.Tele = New Paints.GeneralTextBox()
        Me.Mobile = New Paints.GeneralTextBox()
        Me.GeneralLabel8 = New Paints.GeneralLabel()
        Me.GeneralLabel9 = New Paints.GeneralLabel()
        Me.GeneralLabel10 = New Paints.GeneralLabel()
        Me.Nationality = New Paints.GeneralTextBox()
        Me.Fax = New Paints.GeneralTextBox()
        Me.GeneralLabel6 = New Paints.GeneralLabel()
        Me.GeneralLabel4 = New Paints.GeneralLabel()
        Me.GeneralLabel7 = New Paints.GeneralLabel()
        Me.GeneralLabel5 = New Paints.GeneralLabel()
        Me.ContactPerson = New Paints.GeneralTextBox()
        Me.Address = New Paints.GeneralTextBox()
        Me.WebSite = New Paints.GeneralTextBox()
        Me.GeneralLabel3 = New Paints.GeneralLabel()
        Me.GeneralLabel1 = New Paints.GeneralLabel()
        Me.Email = New Paints.GeneralTextBox()
        Me.MasterField1 = New Paints.MasterField()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.OrderByCombo = New System.Windows.Forms.ComboBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.CountRecords = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BtnFile = New System.Windows.Forms.Button()
        Me.BtnData = New System.Windows.Forms.Button()
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnCancelSerach = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuAllCommands = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.ContentPanel.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ContentPanel.Controls.Add(Me.Button1)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel2)
        Me.ContentPanel.Controls.Add(Me.CorporationCode)
        Me.ContentPanel.Controls.Add(Me.Tele)
        Me.ContentPanel.Controls.Add(Me.Mobile)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel8)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel9)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel10)
        Me.ContentPanel.Controls.Add(Me.Nationality)
        Me.ContentPanel.Controls.Add(Me.Fax)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel6)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel4)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel7)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel5)
        Me.ContentPanel.Controls.Add(Me.ContactPerson)
        Me.ContentPanel.Controls.Add(Me.Address)
        Me.ContentPanel.Controls.Add(Me.WebSite)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel3)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel1)
        Me.ContentPanel.Controls.Add(Me.Email)
        Me.ContentPanel.Controls.Add(Me.MasterField1)
        Me.ContentPanel.Location = New System.Drawing.Point(23, 78)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(734, 419)
        Me.ContentPanel.TabIndex = 20
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.ItemSize = New System.Drawing.Size(90, 18)
        Me.TabControl1.Location = New System.Drawing.Point(32, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(223, 369)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 86
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(215, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "«·‰Ê«›–"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.Paints.My.Resources.Resources.aaa
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(3, 59)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(209, 28)
        Me.Button6.TabIndex = 47
        Me.Button6.TabStop = False
        Me.Button6.Text = "—’Ìœ √Ê· „œ… »«·„Œ“‰"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Paints.My.Resources.Resources.aaa
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(3, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 28)
        Me.Button2.TabIndex = 44
        Me.Button2.TabStop = False
        Me.Button2.Text = "»‰Êœ «·√’‰«›"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Paints.My.Resources.Resources.aaa
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(209, 28)
        Me.Button5.TabIndex = 43
        Me.Button5.TabStop = False
        Me.Button5.Text = "»Ì«‰«  «·√’‰«›"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(215, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "«· ﬁ«—Ì—"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.Paints.My.Resources.Resources.aaa
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(3, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(209, 28)
        Me.Button10.TabIndex = 46
        Me.Button10.TabStop = False
        Me.Button10.Text = "«·«” ⁄·«„ ⁄‰ «·«’‰«› »«·‘—ﬂ…"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Paints.My.Resources.Resources.HP_Explorer
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(267, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(37, 27)
        Me.Button1.TabIndex = 79
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GeneralLabel2
        '
        Me.GeneralLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel2.BackgroundImage = CType(resources.GetObject("GeneralLabel2.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel2.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel2.IsRequired = True
        Me.GeneralLabel2.Location = New System.Drawing.Point(558, 66)
        Me.GeneralLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel2.Name = "GeneralLabel2"
        Me.GeneralLabel2.SetLabelTxt = "ﬂÊœ «·‘—ﬂÂ :"
        Me.GeneralLabel2.Size = New System.Drawing.Size(144, 28)
        Me.GeneralLabel2.TabIndex = 78
        Me.GeneralLabel2.TabStop = False
        '
        'CorporationCode
        '
        Me.CorporationCode.BackColor = System.Drawing.Color.Gainsboro
        Me.CorporationCode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorporationCode.IsEmail = False
        Me.CorporationCode.IsNum = False
        Me.CorporationCode.IsRequired = False
        Me.CorporationCode.Location = New System.Drawing.Point(267, 66)
        Me.CorporationCode.Margin = New System.Windows.Forms.Padding(4)
        Me.CorporationCode.Name = "CorporationCode"
        Me.CorporationCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CorporationCode.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.CorporationCode.Size = New System.Drawing.Size(283, 28)
        Me.CorporationCode.TabIndex = 2
        '
        'Tele
        '
        Me.Tele.BackColor = System.Drawing.Color.Gainsboro
        Me.Tele.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tele.IsEmail = False
        Me.Tele.IsNum = True
        Me.Tele.IsRequired = False
        Me.Tele.Location = New System.Drawing.Point(267, 254)
        Me.Tele.Margin = New System.Windows.Forms.Padding(4)
        Me.Tele.Name = "Tele"
        Me.Tele.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tele.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.Tele.Size = New System.Drawing.Size(283, 28)
        Me.Tele.TabIndex = 7
        '
        'Mobile
        '
        Me.Mobile.BackColor = System.Drawing.Color.Gainsboro
        Me.Mobile.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile.IsEmail = False
        Me.Mobile.IsNum = True
        Me.Mobile.IsRequired = False
        Me.Mobile.Location = New System.Drawing.Point(267, 291)
        Me.Mobile.Margin = New System.Windows.Forms.Padding(4)
        Me.Mobile.Name = "Mobile"
        Me.Mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Mobile.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.Mobile.Size = New System.Drawing.Size(283, 28)
        Me.Mobile.TabIndex = 8
        '
        'GeneralLabel8
        '
        Me.GeneralLabel8.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel8.BackgroundImage = CType(resources.GetObject("GeneralLabel8.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel8.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel8.IsRequired = False
        Me.GeneralLabel8.Location = New System.Drawing.Point(558, 366)
        Me.GeneralLabel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel8.Name = "GeneralLabel8"
        Me.GeneralLabel8.SetLabelTxt = "«·Ã‰”Ì… :"
        Me.GeneralLabel8.Size = New System.Drawing.Size(144, 28)
        Me.GeneralLabel8.TabIndex = 76
        Me.GeneralLabel8.TabStop = False
        '
        'GeneralLabel9
        '
        Me.GeneralLabel9.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel9.BackgroundImage = CType(resources.GetObject("GeneralLabel9.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel9.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel9.IsRequired = False
        Me.GeneralLabel9.Location = New System.Drawing.Point(558, 291)
        Me.GeneralLabel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel9.Name = "GeneralLabel9"
        Me.GeneralLabel9.SetLabelTxt = "«·„Ê»«Ì· :"
        Me.GeneralLabel9.Size = New System.Drawing.Size(144, 28)
        Me.GeneralLabel9.TabIndex = 74
        Me.GeneralLabel9.TabStop = False
        '
        'GeneralLabel10
        '
        Me.GeneralLabel10.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel10.BackgroundImage = CType(resources.GetObject("GeneralLabel10.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel10.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel10.IsRequired = False
        Me.GeneralLabel10.Location = New System.Drawing.Point(558, 329)
        Me.GeneralLabel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel10.Name = "GeneralLabel10"
        Me.GeneralLabel10.SetLabelTxt = "«·›«ﬂ” :"
        Me.GeneralLabel10.Size = New System.Drawing.Size(144, 28)
        Me.GeneralLabel10.TabIndex = 75
        Me.GeneralLabel10.TabStop = False
        '
        'Nationality
        '
        Me.Nationality.BackColor = System.Drawing.Color.Gainsboro
        Me.Nationality.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nationality.IsEmail = False
        Me.Nationality.IsNum = False
        Me.Nationality.IsRequired = False
        Me.Nationality.Location = New System.Drawing.Point(267, 366)
        Me.Nationality.Margin = New System.Windows.Forms.Padding(4)
        Me.Nationality.Name = "Nationality"
        Me.Nationality.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Nationality.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.Nationality.Size = New System.Drawing.Size(283, 28)
        Me.Nationality.TabIndex = 10
        '
        'Fax
        '
        Me.Fax.BackColor = System.Drawing.Color.Gainsboro
        Me.Fax.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fax.IsEmail = False
        Me.Fax.IsNum = False
        Me.Fax.IsRequired = False
        Me.Fax.Location = New System.Drawing.Point(267, 329)
        Me.Fax.Margin = New System.Windows.Forms.Padding(4)
        Me.Fax.Name = "Fax"
        Me.Fax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Fax.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.Fax.Size = New System.Drawing.Size(283, 28)
        Me.Fax.TabIndex = 9
        '
        'GeneralLabel6
        '
        Me.GeneralLabel6.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel6.BackgroundImage = CType(resources.GetObject("GeneralLabel6.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel6.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel6.IsRequired = False
        Me.GeneralLabel6.Location = New System.Drawing.Point(558, 254)
        Me.GeneralLabel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel6.Name = "GeneralLabel6"
        Me.GeneralLabel6.SetLabelTxt = "«· ·Ì›Ê‰ :"
        Me.GeneralLabel6.Size = New System.Drawing.Size(144, 30)
        Me.GeneralLabel6.TabIndex = 73
        Me.GeneralLabel6.TabStop = False
        '
        'GeneralLabel4
        '
        Me.GeneralLabel4.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel4.BackgroundImage = CType(resources.GetObject("GeneralLabel4.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel4.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel4.IsRequired = False
        Me.GeneralLabel4.Location = New System.Drawing.Point(558, 179)
        Me.GeneralLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel4.Name = "GeneralLabel4"
        Me.GeneralLabel4.SetLabelTxt = "„„À· «·‘—ﬂ… :"
        Me.GeneralLabel4.Size = New System.Drawing.Size(144, 29)
        Me.GeneralLabel4.TabIndex = 71
        Me.GeneralLabel4.TabStop = False
        '
        'GeneralLabel7
        '
        Me.GeneralLabel7.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel7.BackgroundImage = CType(resources.GetObject("GeneralLabel7.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel7.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel7.IsRequired = False
        Me.GeneralLabel7.Location = New System.Drawing.Point(558, 216)
        Me.GeneralLabel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel7.Name = "GeneralLabel7"
        Me.GeneralLabel7.SetLabelTxt = "«·⁄‰Ê«‰ :"
        Me.GeneralLabel7.Size = New System.Drawing.Size(144, 28)
        Me.GeneralLabel7.TabIndex = 72
        Me.GeneralLabel7.TabStop = False
        '
        'GeneralLabel5
        '
        Me.GeneralLabel5.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel5.BackgroundImage = CType(resources.GetObject("GeneralLabel5.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel5.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel5.IsRequired = False
        Me.GeneralLabel5.Location = New System.Drawing.Point(558, 143)
        Me.GeneralLabel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel5.Name = "GeneralLabel5"
        Me.GeneralLabel5.SetLabelTxt = "„Êﬁ⁄ «·«‰ —‰  :"
        Me.GeneralLabel5.Size = New System.Drawing.Size(144, 27)
        Me.GeneralLabel5.TabIndex = 70
        Me.GeneralLabel5.TabStop = False
        '
        'ContactPerson
        '
        Me.ContactPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.ContactPerson.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactPerson.IsEmail = False
        Me.ContactPerson.IsNum = False
        Me.ContactPerson.IsRequired = False
        Me.ContactPerson.Location = New System.Drawing.Point(267, 179)
        Me.ContactPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.ContactPerson.Name = "ContactPerson"
        Me.ContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContactPerson.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.ContactPerson.Size = New System.Drawing.Size(283, 28)
        Me.ContactPerson.TabIndex = 5
        '
        'Address
        '
        Me.Address.BackColor = System.Drawing.Color.Gainsboro
        Me.Address.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.IsEmail = False
        Me.Address.IsNum = False
        Me.Address.IsRequired = False
        Me.Address.Location = New System.Drawing.Point(267, 216)
        Me.Address.Margin = New System.Windows.Forms.Padding(4)
        Me.Address.Name = "Address"
        Me.Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Address.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.Address.Size = New System.Drawing.Size(283, 28)
        Me.Address.TabIndex = 6
        '
        'WebSite
        '
        Me.WebSite.BackColor = System.Drawing.Color.Gainsboro
        Me.WebSite.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebSite.IsEmail = False
        Me.WebSite.IsNum = False
        Me.WebSite.IsRequired = False
        Me.WebSite.Location = New System.Drawing.Point(309, 143)
        Me.WebSite.Margin = New System.Windows.Forms.Padding(4)
        Me.WebSite.Name = "WebSite"
        Me.WebSite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WebSite.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.WebSite.Size = New System.Drawing.Size(242, 28)
        Me.WebSite.TabIndex = 4
        '
        'GeneralLabel3
        '
        Me.GeneralLabel3.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel3.BackgroundImage = CType(resources.GetObject("GeneralLabel3.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel3.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel3.IsRequired = False
        Me.GeneralLabel3.Location = New System.Drawing.Point(558, 104)
        Me.GeneralLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel3.Name = "GeneralLabel3"
        Me.GeneralLabel3.SetLabelTxt = "«·»—Ìœ «·«·ﬂ —Ê‰Ì :"
        Me.GeneralLabel3.Size = New System.Drawing.Size(144, 28)
        Me.GeneralLabel3.TabIndex = 68
        Me.GeneralLabel3.TabStop = False
        '
        'GeneralLabel1
        '
        Me.GeneralLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel1.BackgroundImage = CType(resources.GetObject("GeneralLabel1.BackgroundImage"), System.Drawing.Image)
        Me.GeneralLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GeneralLabel1.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel1.IsRequired = True
        Me.GeneralLabel1.Location = New System.Drawing.Point(558, 25)
        Me.GeneralLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GeneralLabel1.Name = "GeneralLabel1"
        Me.GeneralLabel1.SetLabelTxt = "«”„ «·‘—ﬂ… :"
        Me.GeneralLabel1.Size = New System.Drawing.Size(144, 28)
        Me.GeneralLabel1.TabIndex = 66
        Me.GeneralLabel1.TabStop = False
        '
        'Email
        '
        Me.Email.BackColor = System.Drawing.Color.Gainsboro
        Me.Email.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.IsEmail = False
        Me.Email.IsNum = False
        Me.Email.IsRequired = False
        Me.Email.Location = New System.Drawing.Point(267, 104)
        Me.Email.Margin = New System.Windows.Forms.Padding(4)
        Me.Email.Name = "Email"
        Me.Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Email.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.Email.Size = New System.Drawing.Size(283, 28)
        Me.Email.TabIndex = 3
        '
        'MasterField1
        '
        Me.MasterField1.BackColor = System.Drawing.Color.Gainsboro
        Me.MasterField1.EnableField = False
        Me.MasterField1.EnableLockup = True
        Me.MasterField1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterField1.IsNum = False
        Me.MasterField1.IsRequired = True
        Me.MasterField1.Location = New System.Drawing.Point(268, 25)
        Me.MasterField1.Margin = New System.Windows.Forms.Padding(4)
        Me.MasterField1.Name = "MasterField1"
        Me.MasterField1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MasterField1.SetDisplayMember = "Corporations.Corporation_Name"
        Me.MasterField1.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.MasterField1.SetLockupImage = Nothing
        Me.MasterField1.SetValueMember = "Corporations.Corporation_ID"
        Me.MasterField1.Size = New System.Drawing.Size(283, 28)
        Me.MasterField1.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BackgroundImage = Global.Paints.My.Resources.Resources.exit_22
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(733, 395)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(151, 57)
        Me.BtnExit.TabIndex = 82
        Me.BtnExit.TabStop = False
        Me.BtnExit.Text = "Œ—ÊÃ"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.BackgroundImage = Global.Paints.My.Resources.Resources.edit_1_19
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(733, 269)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(151, 57)
        Me.BtnSearch.TabIndex = 81
        Me.BtnSearch.TabStop = False
        Me.BtnSearch.Text = " ⁄œÌ·"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BackgroundImage = Global.Paints.My.Resources.Resources.save_18_18
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(733, 206)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(151, 57)
        Me.BtnSave.TabIndex = 80
        Me.BtnSave.TabStop = False
        Me.BtnSave.Text = "Õ›Ÿ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.Transparent
        Me.BtnNew.BackgroundImage = Global.Paints.My.Resources.Resources.without_text_16
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(733, 143)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(151, 57)
        Me.BtnNew.TabIndex = 79
        Me.BtnNew.TabStop = False
        Me.BtnNew.Text = "ÃœÌœ"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.BackgroundImage = Global.Paints.My.Resources.Resources.delete_1_21
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(733, 332)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(151, 57)
        Me.BtnDelete.TabIndex = 96
        Me.BtnDelete.TabStop = False
        Me.BtnDelete.Text = "Õ–›"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(163, 504)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "⁄œœ «·”Ã·«  :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.Transparent
        Me.BtnLast.BackgroundImage = Global.Paints.My.Resources.Resources.master_16
        Me.BtnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLast.FlatAppearance.BorderSize = 0
        Me.BtnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLast.Location = New System.Drawing.Point(298, 507)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(16, 16)
        Me.BtnLast.TabIndex = 102
        Me.BtnLast.TabStop = False
        Me.BtnLast.Text = "œŒÊ·"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Transparent
        Me.BtnNext.BackgroundImage = Global.Paints.My.Resources.Resources.master_18
        Me.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Location = New System.Drawing.Point(332, 507)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(16, 16)
        Me.BtnNext.TabIndex = 101
        Me.BtnNext.TabStop = False
        Me.BtnNext.Text = "œŒÊ·"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'OrderByCombo
        '
        Me.OrderByCombo.BackColor = System.Drawing.Color.Gainsboro
        Me.OrderByCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrderByCombo.FormattingEnabled = True
        Me.OrderByCombo.Location = New System.Drawing.Point(361, 506)
        Me.OrderByCombo.Name = "OrderByCombo"
        Me.OrderByCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OrderByCombo.Size = New System.Drawing.Size(151, 21)
        Me.OrderByCombo.TabIndex = 100
        Me.OrderByCombo.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsernameLabel.Location = New System.Drawing.Point(518, 504)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(56, 19)
        Me.UsernameLabel.TabIndex = 99
        Me.UsernameLabel.Text = "«· — Ì»"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrevious.BackgroundImage = Global.Paints.My.Resources.Resources.master_18_copy
        Me.BtnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrevious.FlatAppearance.BorderSize = 0
        Me.BtnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrevious.Location = New System.Drawing.Point(580, 507)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(16, 16)
        Me.BtnPrevious.TabIndex = 98
        Me.BtnPrevious.TabStop = False
        Me.BtnPrevious.Text = "œŒÊ·"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.Transparent
        Me.BtnFirst.BackgroundImage = Global.Paints.My.Resources.Resources.master_16_copy
        Me.BtnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFirst.FlatAppearance.BorderSize = 0
        Me.BtnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFirst.Location = New System.Drawing.Point(614, 507)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(16, 16)
        Me.BtnFirst.TabIndex = 97
        Me.BtnFirst.TabStop = False
        Me.BtnFirst.Text = "œŒÊ·"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'CountRecords
        '
        Me.CountRecords.BackColor = System.Drawing.Color.Transparent
        Me.CountRecords.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountRecords.ForeColor = System.Drawing.Color.White
        Me.CountRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CountRecords.Location = New System.Drawing.Point(76, 505)
        Me.CountRecords.Name = "CountRecords"
        Me.CountRecords.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CountRecords.Size = New System.Drawing.Size(92, 19)
        Me.CountRecords.TabIndex = 104
        Me.CountRecords.Text = "0"
        Me.CountRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(214, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(119, 64)
        Me.PictureBox5.TabIndex = 97
        Me.PictureBox5.TabStop = False
        '
        'BtnFile
        '
        Me.BtnFile.BackColor = System.Drawing.Color.Transparent
        Me.BtnFile.BackgroundImage = Global.Paints.My.Resources.Resources.master_09Selected
        Me.BtnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFile.FlatAppearance.BorderSize = 0
        Me.BtnFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFile.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFile.Location = New System.Drawing.Point(631, 9)
        Me.BtnFile.Name = "BtnFile"
        Me.BtnFile.Size = New System.Drawing.Size(126, 57)
        Me.BtnFile.TabIndex = 105
        Me.BtnFile.TabStop = False
        Me.BtnFile.UseVisualStyleBackColor = False
        '
        'BtnData
        '
        Me.BtnData.BackColor = System.Drawing.Color.Transparent
        Me.BtnData.BackgroundImage = Global.Paints.My.Resources.Resources.master_05
        Me.BtnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnData.FlatAppearance.BorderSize = 0
        Me.BtnData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnData.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnData.Location = New System.Drawing.Point(496, 9)
        Me.BtnData.Name = "BtnData"
        Me.BtnData.Size = New System.Drawing.Size(126, 57)
        Me.BtnData.TabIndex = 106
        Me.BtnData.TabStop = False
        Me.BtnData.UseVisualStyleBackColor = False
        '
        'BtnHelp
        '
        Me.BtnHelp.BackColor = System.Drawing.Color.Transparent
        Me.BtnHelp.BackgroundImage = Global.Paints.My.Resources.Resources.master_03
        Me.BtnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHelp.FlatAppearance.BorderSize = 0
        Me.BtnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHelp.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHelp.Location = New System.Drawing.Point(361, 9)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(126, 57)
        Me.BtnHelp.TabIndex = 107
        Me.BtnHelp.TabStop = False
        Me.BtnHelp.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.Color.Transparent
        Me.BtnReload.BackgroundImage = Global.Paints.My.Resources.Resources.without_texte_2_16
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReload.FlatAppearance.BorderSize = 0
        Me.BtnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReload.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReload.Location = New System.Drawing.Point(733, 143)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(151, 57)
        Me.BtnReload.TabIndex = 108
        Me.BtnReload.TabStop = False
        Me.BtnReload.Text = " Õ„Ì·"
        Me.BtnReload.UseVisualStyleBackColor = False
        Me.BtnReload.Visible = False
        '
        'BtnCancelSerach
        '
        Me.BtnCancelSerach.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelSerach.BackgroundImage = Global.Paints.My.Resources.Resources.save_2_18
        Me.BtnCancelSerach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelSerach.FlatAppearance.BorderSize = 0
        Me.BtnCancelSerach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelSerach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelSerach.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelSerach.Location = New System.Drawing.Point(733, 206)
        Me.BtnCancelSerach.Name = "BtnCancelSerach"
        Me.BtnCancelSerach.Size = New System.Drawing.Size(151, 57)
        Me.BtnCancelSerach.TabIndex = 109
        Me.BtnCancelSerach.TabStop = False
        Me.BtnCancelSerach.Text = "»ÕÀ ⁄«„"
        Me.BtnCancelSerach.UseVisualStyleBackColor = False
        Me.BtnCancelSerach.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAllCommands})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(906, 24)
        Me.MenuStrip1.TabIndex = 135
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuAllCommands
        '
        Me.MenuAllCommands.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNew, Me.MenuSave, Me.MenuSearch, Me.MenuDelete, Me.MenuExit})
        Me.MenuAllCommands.Name = "MenuAllCommands"
        Me.MenuAllCommands.Size = New System.Drawing.Size(84, 20)
        Me.MenuAllCommands.Text = "AllComands"
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
        'Corporations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Paints.My.Resources.Resources.enter_screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(906, 543)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.BtnCancelSerach)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.BtnHelp)
        Me.Controls.Add(Me.BtnData)
        Me.Controls.Add(Me.BtnFile)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CountRecords)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.OrderByCombo)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Corporations"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContentPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents OrderByCombo As System.Windows.Forms.ComboBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents CountRecords As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnFile As System.Windows.Forms.Button
    Friend WithEvents BtnData As System.Windows.Forms.Button
    Friend WithEvents BtnHelp As System.Windows.Forms.Button
    Friend WithEvents BtnReload As System.Windows.Forms.Button
    Friend WithEvents BtnCancelSerach As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GeneralLabel2 As Paints.GeneralLabel
    Friend WithEvents CorporationCode As Paints.GeneralTextBox
    Friend WithEvents Tele As Paints.GeneralTextBox
    Friend WithEvents Mobile As Paints.GeneralTextBox
    Friend WithEvents GeneralLabel8 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel9 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel10 As Paints.GeneralLabel
    Friend WithEvents Nationality As Paints.GeneralTextBox
    Friend WithEvents Fax As Paints.GeneralTextBox
    Friend WithEvents GeneralLabel6 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel4 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel7 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel5 As Paints.GeneralLabel
    Friend WithEvents ContactPerson As Paints.GeneralTextBox
    Friend WithEvents Address As Paints.GeneralTextBox
    Friend WithEvents WebSite As Paints.GeneralTextBox
    Friend WithEvents GeneralLabel3 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel1 As Paints.GeneralLabel
    Friend WithEvents Email As Paints.GeneralTextBox
    Friend WithEvents MasterField1 As Paints.MasterField
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuAllCommands As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
End Class
