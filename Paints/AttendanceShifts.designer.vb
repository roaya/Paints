<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceShifts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceShifts))
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.Friday = New System.Windows.Forms.CheckBox()
        Me.Thursday = New System.Windows.Forms.CheckBox()
        Me.Wednesday = New System.Windows.Forms.CheckBox()
        Me.Tuseday = New System.Windows.Forms.CheckBox()
        Me.Sunday = New System.Windows.Forms.CheckBox()
        Me.Monday = New System.Windows.Forms.CheckBox()
        Me.Saturday = New System.Windows.Forms.CheckBox()
        Me.ToTime = New System.Windows.Forms.DateTimePicker()
        Me.DelayAllowed = New System.Windows.Forms.NumericUpDown()
        Me.FromTime = New System.Windows.Forms.DateTimePicker()
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
        Me.GeneralLabel11 = New Paints.GeneralLabel()
        Me.GeneralLabel10 = New Paints.GeneralLabel()
        Me.GeneralLabel9 = New Paints.GeneralLabel()
        Me.GeneralLabel8 = New Paints.GeneralLabel()
        Me.MasterField1 = New Paints.MasterField()
        Me.GeneralLabel7 = New Paints.GeneralLabel()
        Me.GeneralLabel6 = New Paints.GeneralLabel()
        Me.GeneralLabel5 = New Paints.GeneralLabel()
        Me.GeneralLabel4 = New Paints.GeneralLabel()
        Me.GeneralLabel3 = New Paints.GeneralLabel()
        Me.GeneralLabel2 = New Paints.GeneralLabel()
        Me.GeneralLabel1 = New Paints.GeneralLabel()
        Me.AttendTo = New System.Windows.Forms.DateTimePicker()
        Me.GeneralLabel12 = New Paints.GeneralLabel()
        Me.AttendFrom = New System.Windows.Forms.DateTimePicker()
        Me.GeneralLabel13 = New Paints.GeneralLabel()
        Me.ContentPanel.SuspendLayout()
        CType(Me.DelayAllowed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.ContentPanel.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContentPanel.Controls.Add(Me.AttendTo)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel12)
        Me.ContentPanel.Controls.Add(Me.AttendFrom)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel13)
        Me.ContentPanel.Controls.Add(Me.Friday)
        Me.ContentPanel.Controls.Add(Me.Thursday)
        Me.ContentPanel.Controls.Add(Me.Wednesday)
        Me.ContentPanel.Controls.Add(Me.Tuseday)
        Me.ContentPanel.Controls.Add(Me.Sunday)
        Me.ContentPanel.Controls.Add(Me.Monday)
        Me.ContentPanel.Controls.Add(Me.Saturday)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel11)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel10)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel9)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel8)
        Me.ContentPanel.Controls.Add(Me.ToTime)
        Me.ContentPanel.Controls.Add(Me.DelayAllowed)
        Me.ContentPanel.Controls.Add(Me.MasterField1)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel7)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel6)
        Me.ContentPanel.Controls.Add(Me.FromTime)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel5)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel4)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel3)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel2)
        Me.ContentPanel.Controls.Add(Me.GeneralLabel1)
        Me.ContentPanel.Location = New System.Drawing.Point(18, 81)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContentPanel.Size = New System.Drawing.Size(558, 597)
        Me.ContentPanel.TabIndex = 20
        '
        'Friday
        '
        Me.Friday.AutoSize = True
        Me.Friday.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Friday.Location = New System.Drawing.Point(312, 336)
        Me.Friday.Name = "Friday"
        Me.Friday.Size = New System.Drawing.Size(15, 14)
        Me.Friday.TabIndex = 88
        Me.Friday.UseVisualStyleBackColor = True
        '
        'Thursday
        '
        Me.Thursday.AutoSize = True
        Me.Thursday.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Thursday.Location = New System.Drawing.Point(312, 293)
        Me.Thursday.Name = "Thursday"
        Me.Thursday.Size = New System.Drawing.Size(15, 14)
        Me.Thursday.TabIndex = 86
        Me.Thursday.UseVisualStyleBackColor = True
        '
        'Wednesday
        '
        Me.Wednesday.AutoSize = True
        Me.Wednesday.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Wednesday.Location = New System.Drawing.Point(312, 250)
        Me.Wednesday.Name = "Wednesday"
        Me.Wednesday.Size = New System.Drawing.Size(15, 14)
        Me.Wednesday.TabIndex = 85
        Me.Wednesday.UseVisualStyleBackColor = True
        '
        'Tuseday
        '
        Me.Tuseday.AutoSize = True
        Me.Tuseday.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Tuseday.Location = New System.Drawing.Point(312, 207)
        Me.Tuseday.Name = "Tuseday"
        Me.Tuseday.Size = New System.Drawing.Size(15, 14)
        Me.Tuseday.TabIndex = 84
        Me.Tuseday.UseVisualStyleBackColor = True
        '
        'Sunday
        '
        Me.Sunday.AutoSize = True
        Me.Sunday.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Sunday.Location = New System.Drawing.Point(312, 121)
        Me.Sunday.Name = "Sunday"
        Me.Sunday.Size = New System.Drawing.Size(15, 14)
        Me.Sunday.TabIndex = 83
        Me.Sunday.UseVisualStyleBackColor = True
        '
        'Monday
        '
        Me.Monday.AutoSize = True
        Me.Monday.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Monday.Location = New System.Drawing.Point(312, 164)
        Me.Monday.Name = "Monday"
        Me.Monday.Size = New System.Drawing.Size(15, 14)
        Me.Monday.TabIndex = 82
        Me.Monday.UseVisualStyleBackColor = True
        '
        'Saturday
        '
        Me.Saturday.AutoSize = True
        Me.Saturday.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Saturday.Location = New System.Drawing.Point(312, 78)
        Me.Saturday.Name = "Saturday"
        Me.Saturday.Size = New System.Drawing.Size(15, 14)
        Me.Saturday.TabIndex = 81
        Me.Saturday.UseVisualStyleBackColor = True
        '
        'ToTime
        '
        Me.ToTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.ToTime.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ToTime.Location = New System.Drawing.Point(25, 502)
        Me.ToTime.Name = "ToTime"
        Me.ToTime.RightToLeftLayout = True
        Me.ToTime.ShowUpDown = True
        Me.ToTime.Size = New System.Drawing.Size(319, 26)
        Me.ToTime.TabIndex = 76
        '
        'DelayAllowed
        '
        Me.DelayAllowed.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelayAllowed.Location = New System.Drawing.Point(25, 545)
        Me.DelayAllowed.Name = "DelayAllowed"
        Me.DelayAllowed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DelayAllowed.Size = New System.Drawing.Size(319, 26)
        Me.DelayAllowed.TabIndex = 75
        Me.DelayAllowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FromTime
        '
        Me.FromTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.FromTime.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.FromTime.Location = New System.Drawing.Point(25, 459)
        Me.FromTime.Name = "FromTime"
        Me.FromTime.RightToLeftLayout = True
        Me.FromTime.ShowUpDown = True
        Me.FromTime.Size = New System.Drawing.Size(319, 26)
        Me.FromTime.TabIndex = 5
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
        Me.BtnExit.Location = New System.Drawing.Point(552, 382)
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
        Me.BtnSearch.Location = New System.Drawing.Point(552, 256)
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
        Me.BtnSave.Location = New System.Drawing.Point(552, 193)
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
        Me.BtnNew.Location = New System.Drawing.Point(552, 130)
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
        Me.BtnDelete.Location = New System.Drawing.Point(552, 319)
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
        Me.Label1.Location = New System.Drawing.Point(92, 681)
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
        Me.BtnLast.Location = New System.Drawing.Point(227, 684)
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
        Me.BtnNext.Location = New System.Drawing.Point(261, 684)
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
        Me.OrderByCombo.Location = New System.Drawing.Point(290, 683)
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
        Me.UsernameLabel.Location = New System.Drawing.Point(447, 681)
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
        Me.BtnPrevious.Location = New System.Drawing.Point(509, 684)
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
        Me.BtnFirst.Location = New System.Drawing.Point(543, 684)
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
        Me.CountRecords.Location = New System.Drawing.Point(18, 681)
        Me.CountRecords.Name = "CountRecords"
        Me.CountRecords.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CountRecords.Size = New System.Drawing.Size(74, 19)
        Me.CountRecords.TabIndex = 104
        Me.CountRecords.Text = "0"
        Me.CountRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(18, 12)
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
        Me.BtnFile.Location = New System.Drawing.Point(450, 12)
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
        Me.BtnData.Location = New System.Drawing.Point(315, 12)
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
        Me.BtnHelp.Location = New System.Drawing.Point(180, 12)
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
        Me.BtnReload.Location = New System.Drawing.Point(552, 130)
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
        Me.BtnCancelSerach.Location = New System.Drawing.Point(552, 193)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(920, 24)
        Me.MenuStrip1.TabIndex = 157
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
        Me.MenuNew.Size = New System.Drawing.Size(126, 22)
        Me.MenuNew.Text = "New"
        '
        'MenuSave
        '
        Me.MenuSave.Name = "MenuSave"
        Me.MenuSave.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.MenuSave.Size = New System.Drawing.Size(126, 22)
        Me.MenuSave.Text = "Save"
        '
        'MenuSearch
        '
        Me.MenuSearch.Name = "MenuSearch"
        Me.MenuSearch.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.MenuSearch.Size = New System.Drawing.Size(126, 22)
        Me.MenuSearch.Text = "Edit"
        '
        'MenuDelete
        '
        Me.MenuDelete.Name = "MenuDelete"
        Me.MenuDelete.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.MenuDelete.Size = New System.Drawing.Size(126, 22)
        Me.MenuDelete.Text = "Delete"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.MenuExit.Size = New System.Drawing.Size(126, 22)
        Me.MenuExit.Text = "Exit"
        '
        'GeneralLabel11
        '
        Me.GeneralLabel11.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel11.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel11.IsRequired = False
        Me.GeneralLabel11.Location = New System.Drawing.Point(349, 330)
        Me.GeneralLabel11.Name = "GeneralLabel11"
        Me.GeneralLabel11.SetLabelTxt = "«·Ã„⁄… :"
        Me.GeneralLabel11.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel11.TabIndex = 80
        Me.GeneralLabel11.TabStop = False
        '
        'GeneralLabel10
        '
        Me.GeneralLabel10.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel10.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel10.IsRequired = False
        Me.GeneralLabel10.Location = New System.Drawing.Point(349, 287)
        Me.GeneralLabel10.Name = "GeneralLabel10"
        Me.GeneralLabel10.SetLabelTxt = "«·Œ„Ì” :"
        Me.GeneralLabel10.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel10.TabIndex = 79
        Me.GeneralLabel10.TabStop = False
        '
        'GeneralLabel9
        '
        Me.GeneralLabel9.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel9.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel9.IsRequired = False
        Me.GeneralLabel9.Location = New System.Drawing.Point(349, 244)
        Me.GeneralLabel9.Name = "GeneralLabel9"
        Me.GeneralLabel9.SetLabelTxt = "«·«—»⁄«¡ :"
        Me.GeneralLabel9.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel9.TabIndex = 78
        Me.GeneralLabel9.TabStop = False
        '
        'GeneralLabel8
        '
        Me.GeneralLabel8.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel8.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel8.IsRequired = False
        Me.GeneralLabel8.Location = New System.Drawing.Point(349, 201)
        Me.GeneralLabel8.Name = "GeneralLabel8"
        Me.GeneralLabel8.SetLabelTxt = "«·À·«À«¡ :"
        Me.GeneralLabel8.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel8.TabIndex = 77
        Me.GeneralLabel8.TabStop = False
        '
        'MasterField1
        '
        Me.MasterField1.BackColor = System.Drawing.Color.Gainsboro
        Me.MasterField1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MasterField1.EnableField = False
        Me.MasterField1.EnableLockup = True
        Me.MasterField1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterField1.IsNum = False
        Me.MasterField1.IsRequired = True
        Me.MasterField1.Location = New System.Drawing.Point(25, 28)
        Me.MasterField1.Margin = New System.Windows.Forms.Padding(4)
        Me.MasterField1.Name = "MasterField1"
        Me.MasterField1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MasterField1.SetDisplayMember = "Money_Payables.Pay_ID"
        Me.MasterField1.SetLeaveColor = System.Drawing.SystemColors.ActiveCaption
        Me.MasterField1.SetLockupImage = Nothing
        Me.MasterField1.SetValueMember = "Money_Payables.Pay_ID"
        Me.MasterField1.Size = New System.Drawing.Size(318, 28)
        Me.MasterField1.TabIndex = 0
        '
        'GeneralLabel7
        '
        Me.GeneralLabel7.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel7.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel7.IsRequired = False
        Me.GeneralLabel7.Location = New System.Drawing.Point(349, 545)
        Me.GeneralLabel7.Name = "GeneralLabel7"
        Me.GeneralLabel7.SetLabelTxt = "œﬁ«∆ﬁ «· √ŒÌ— :"
        Me.GeneralLabel7.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel7.TabIndex = 74
        Me.GeneralLabel7.TabStop = False
        '
        'GeneralLabel6
        '
        Me.GeneralLabel6.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel6.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel6.IsRequired = False
        Me.GeneralLabel6.Location = New System.Drawing.Point(349, 459)
        Me.GeneralLabel6.Name = "GeneralLabel6"
        Me.GeneralLabel6.SetLabelTxt = "«·› —… „‰ :"
        Me.GeneralLabel6.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel6.TabIndex = 73
        Me.GeneralLabel6.TabStop = False
        '
        'GeneralLabel5
        '
        Me.GeneralLabel5.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel5.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel5.IsRequired = False
        Me.GeneralLabel5.Location = New System.Drawing.Point(349, 502)
        Me.GeneralLabel5.Name = "GeneralLabel5"
        Me.GeneralLabel5.SetLabelTxt = "«·Ï :"
        Me.GeneralLabel5.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel5.TabIndex = 71
        Me.GeneralLabel5.TabStop = False
        '
        'GeneralLabel4
        '
        Me.GeneralLabel4.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel4.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel4.IsRequired = False
        Me.GeneralLabel4.Location = New System.Drawing.Point(349, 158)
        Me.GeneralLabel4.Name = "GeneralLabel4"
        Me.GeneralLabel4.SetLabelTxt = "«·«À‰Ì‰ :"
        Me.GeneralLabel4.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel4.TabIndex = 70
        Me.GeneralLabel4.TabStop = False
        '
        'GeneralLabel3
        '
        Me.GeneralLabel3.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel3.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel3.IsRequired = False
        Me.GeneralLabel3.Location = New System.Drawing.Point(349, 115)
        Me.GeneralLabel3.Name = "GeneralLabel3"
        Me.GeneralLabel3.SetLabelTxt = "«·√Õœ :"
        Me.GeneralLabel3.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel3.TabIndex = 69
        Me.GeneralLabel3.TabStop = False
        '
        'GeneralLabel2
        '
        Me.GeneralLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel2.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel2.IsRequired = False
        Me.GeneralLabel2.Location = New System.Drawing.Point(349, 72)
        Me.GeneralLabel2.Name = "GeneralLabel2"
        Me.GeneralLabel2.SetLabelTxt = "«·”»  :"
        Me.GeneralLabel2.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel2.TabIndex = 68
        Me.GeneralLabel2.TabStop = False
        '
        'GeneralLabel1
        '
        Me.GeneralLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel1.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel1.IsRequired = True
        Me.GeneralLabel1.Location = New System.Drawing.Point(349, 29)
        Me.GeneralLabel1.Name = "GeneralLabel1"
        Me.GeneralLabel1.SetLabelTxt = "«”„ «·Ê—œÌ… :"
        Me.GeneralLabel1.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel1.TabIndex = 67
        Me.GeneralLabel1.TabStop = False
        '
        'AttendTo
        '
        Me.AttendTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.AttendTo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendTo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.AttendTo.Location = New System.Drawing.Point(25, 417)
        Me.AttendTo.Name = "AttendTo"
        Me.AttendTo.RightToLeftLayout = True
        Me.AttendTo.ShowUpDown = True
        Me.AttendTo.Size = New System.Drawing.Size(319, 26)
        Me.AttendTo.TabIndex = 92
        '
        'GeneralLabel12
        '
        Me.GeneralLabel12.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel12.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel12.IsRequired = False
        Me.GeneralLabel12.Location = New System.Drawing.Point(349, 374)
        Me.GeneralLabel12.Name = "GeneralLabel12"
        Me.GeneralLabel12.SetLabelTxt = "«·Õ÷Ê— „”„ÊÕ „‰ :"
        Me.GeneralLabel12.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel12.TabIndex = 91
        Me.GeneralLabel12.TabStop = False
        '
        'AttendFrom
        '
        Me.AttendFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.AttendFrom.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.AttendFrom.Location = New System.Drawing.Point(25, 374)
        Me.AttendFrom.Name = "AttendFrom"
        Me.AttendFrom.RightToLeftLayout = True
        Me.AttendFrom.ShowUpDown = True
        Me.AttendFrom.Size = New System.Drawing.Size(319, 26)
        Me.AttendFrom.TabIndex = 89
        '
        'GeneralLabel13
        '
        Me.GeneralLabel13.BackColor = System.Drawing.Color.Gainsboro
        Me.GeneralLabel13.BackgroundImage = Global.Paints.My.Resources.Resources.conatin_box_03
        Me.GeneralLabel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GeneralLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel13.IsRequired = False
        Me.GeneralLabel13.Location = New System.Drawing.Point(349, 417)
        Me.GeneralLabel13.Name = "GeneralLabel13"
        Me.GeneralLabel13.SetLabelTxt = "«·Ï :"
        Me.GeneralLabel13.Size = New System.Drawing.Size(174, 26)
        Me.GeneralLabel13.TabIndex = 90
        Me.GeneralLabel13.TabStop = False
        '
        'AttendanceShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Paints.My.Resources.Resources.enter_screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(724, 716)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AttendanceShifts"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContentPanel.ResumeLayout(False)
        Me.ContentPanel.PerformLayout()
        CType(Me.DelayAllowed, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MasterField1 As Paints.MasterField
    Friend WithEvents GeneralLabel7 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel6 As Paints.GeneralLabel
    Friend WithEvents FromTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents GeneralLabel5 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel4 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel3 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel2 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel1 As Paints.GeneralLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuAllCommands As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Friday As System.Windows.Forms.CheckBox
    Friend WithEvents Thursday As System.Windows.Forms.CheckBox
    Friend WithEvents Wednesday As System.Windows.Forms.CheckBox
    Friend WithEvents Tuseday As System.Windows.Forms.CheckBox
    Friend WithEvents Sunday As System.Windows.Forms.CheckBox
    Friend WithEvents Monday As System.Windows.Forms.CheckBox
    Friend WithEvents Saturday As System.Windows.Forms.CheckBox
    Friend WithEvents GeneralLabel11 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel10 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel9 As Paints.GeneralLabel
    Friend WithEvents GeneralLabel8 As Paints.GeneralLabel
    Friend WithEvents ToTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents DelayAllowed As System.Windows.Forms.NumericUpDown
    Friend WithEvents AttendTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GeneralLabel12 As Paints.GeneralLabel
    Friend WithEvents AttendFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents GeneralLabel13 As Paints.GeneralLabel
End Class
