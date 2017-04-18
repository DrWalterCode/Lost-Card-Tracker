<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TileBarItem1 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem2 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem3 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtgroup = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtforename = New DevExpress.XtraEditors.TextEdit()
        Me.txtsurname = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.Email_addressTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.txtphonenumber = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TabPane1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPane1.SuspendLayout
        Me.TabNavigationPage1.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox3.SuspendLayout
        CType(Me.txtgroup.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtforename.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtsurname.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtUsername.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Email_addressTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtphonenumber.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TabPane1
        '
        Me.TabPane1.Appearance.BackColor = System.Drawing.Color.White
        Me.TabPane1.Appearance.Options.UseBackColor = true
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1348, 621)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1348, 621)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Administration"
        Me.TabNavigationPage1.Controls.Add(Me.TileBar1)
        Me.TabNavigationPage1.Controls.Add(Me.Panel2)
        Me.TabNavigationPage1.Controls.Add(Me.GroupBox3)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1330, 576)
        '
        'TileBar1
        '
        Me.TileBar1.AllowDrag = false
        Me.TileBar1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LimeGreen
        Me.TileBar1.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.White
        Me.TileBar1.AppearanceItem.Hovered.Options.UseBackColor = true
        Me.TileBar1.AppearanceItem.Hovered.Options.UseForeColor = true
        Me.TileBar1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileBar1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.LimeGreen
        Me.TileBar1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Blue
        Me.TileBar1.AppearanceItem.Normal.Options.UseBackColor = true
        Me.TileBar1.AppearanceItem.Normal.Options.UseBorderColor = true
        Me.TileBar1.AppearanceItem.Normal.Options.UseForeColor = true
        Me.TileBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileBar1.Groups.Add(Me.TileBarGroup2)
        Me.TileBar1.Location = New System.Drawing.Point(3, 3)
        Me.TileBar1.MaxId = 4
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.Size = New System.Drawing.Size(549, 99)
        Me.TileBar1.TabIndex = 347
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.TileBarItem1)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem2)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem3)
        Me.TileBarGroup2.Name = "TileBarGroup2"
        '
        'TileBarItem1
        '
        Me.TileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"),System.Drawing.Image)
        TileItemElement1.Text = "Database Backup"
        Me.TileBarItem1.Elements.Add(TileItemElement1)
        Me.TileBarItem1.Id = 0
        Me.TileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem1.Name = "TileBarItem1"
        '
        'TileBarItem2
        '
        Me.TileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"),System.Drawing.Image)
        TileItemElement2.Text = "Database Restore"
        Me.TileBarItem2.Elements.Add(TileItemElement2)
        Me.TileBarItem2.Id = 1
        Me.TileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem2.Name = "TileBarItem2"
        '
        'TileBarItem3
        '
        Me.TileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"),System.Drawing.Image)
        TileItemElement3.Text = "Clear System Data"
        Me.TileBarItem3.Elements.Add(TileItemElement3)
        Me.TileBarItem3.Id = 2
        Me.TileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem3.Name = "TileBarItem3"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(381, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(590, 279)
        Me.Panel2.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(588, 277)
        Me.DataGridView1.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtgroup)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.SimpleButton6)
        Me.GroupBox3.Controls.Add(Me.SimpleButton7)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtforename)
        Me.GroupBox3.Controls.Add(Me.txtsurname)
        Me.GroupBox3.Controls.Add(Me.txtUsername)
        Me.GroupBox3.Controls.Add(Me.Email_addressTextBox)
        Me.GroupBox3.Controls.Add(Me.txtphonenumber)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtPassword)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(20, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 279)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Username Details"
        '
        'txtgroup
        '
        Me.txtgroup.Location = New System.Drawing.Point(117, 12)
        Me.txtgroup.Name = "txtgroup"
        Me.txtgroup.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.txtgroup.Properties.Appearance.Options.UseBackColor = true
        Me.txtgroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtgroup.Properties.Items.AddRange(New Object() {"ADMIN", "EMPLOYEE"})
        Me.txtgroup.Properties.Sorted = true
        Me.txtgroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtgroup.Size = New System.Drawing.Size(222, 20)
        Me.txtgroup.TabIndex = 144
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.Location = New System.Drawing.Point(8, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 14)
        Me.Label28.TabIndex = 143
        Me.Label28.Text = "User Group"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton6.Appearance.Options.UseBackColor = true
        Me.SimpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton6.Enabled = false
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"),System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(252, 224)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(87, 29)
        Me.SimpleButton6.TabIndex = 142
        Me.SimpleButton6.TabStop = false
        Me.SimpleButton6.Text = "&Delete"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.Options.UseBackColor = true
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"),System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(148, 224)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(87, 29)
        Me.SimpleButton7.TabIndex = 141
        Me.SimpleButton7.TabStop = false
        Me.SimpleButton7.Text = "&Save"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightGray
        Me.TextBox1.Location = New System.Drawing.Point(117, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(222, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(8, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 14)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Confirm Password"
        '
        'txtforename
        '
        Me.txtforename.Location = New System.Drawing.Point(117, 170)
        Me.txtforename.Name = "txtforename"
        Me.txtforename.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtforename.Properties.Appearance.Options.UseBackColor = true
        Me.txtforename.Properties.Mask.BeepOnError = true
        Me.txtforename.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.txtforename.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtforename.Properties.Mask.ShowPlaceHolders = false
        Me.txtforename.Size = New System.Drawing.Size(222, 20)
        Me.txtforename.TabIndex = 5
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(117, 144)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtsurname.Properties.Appearance.Options.UseBackColor = true
        Me.txtsurname.Properties.Mask.BeepOnError = true
        Me.txtsurname.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.txtsurname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtsurname.Properties.Mask.ShowPlaceHolders = false
        Me.txtsurname.Size = New System.Drawing.Size(222, 20)
        Me.txtsurname.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(117, 38)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.txtUsername.Properties.Appearance.Options.UseBackColor = true
        Me.txtUsername.Properties.Mask.BeepOnError = true
        Me.txtUsername.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.txtUsername.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtUsername.Size = New System.Drawing.Size(222, 20)
        Me.txtUsername.TabIndex = 0
        '
        'Email_addressTextBox
        '
        Me.Email_addressTextBox.Location = New System.Drawing.Point(117, 118)
        Me.Email_addressTextBox.Name = "Email_addressTextBox"
        Me.Email_addressTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Email_addressTextBox.Properties.Appearance.Options.UseBackColor = true
        Me.Email_addressTextBox.Properties.Mask.BeepOnError = true
        Me.Email_addressTextBox.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"
        Me.Email_addressTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.Email_addressTextBox.Size = New System.Drawing.Size(222, 20)
        Me.Email_addressTextBox.TabIndex = 3
        '
        'txtphonenumber
        '
        Me.txtphonenumber.Location = New System.Drawing.Point(117, 196)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtphonenumber.Properties.Appearance.Options.UseBackColor = true
        Me.txtphonenumber.Properties.Mask.BeepOnError = true
        Me.txtphonenumber.Properties.Mask.EditMask = "+263700000000"
        Me.txtphonenumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtphonenumber.Size = New System.Drawing.Size(222, 20)
        Me.txtphonenumber.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(8, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 14)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Cell Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(8, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 14)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "First Name(s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(8, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 14)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Email"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.LightGray
        Me.txtPassword.Location = New System.Drawing.Point(117, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(222, 22)
        Me.txtPassword.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(8, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 14)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Surname"
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(8, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 14)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Password"
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(8, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 14)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "User Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(190,Byte),Integer), CType(CType(65,Byte),Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 577)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 44)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.Lost_Card_Tracker.My.Resources.Resources.Capture1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 514)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1348, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 621)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabPane1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CABS Lost Card Tracker "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabPane1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPane1.ResumeLayout(false)
        Me.TabNavigationPage1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        CType(Me.txtgroup.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtforename.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtsurname.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtUsername.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Email_addressTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtphonenumber.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtgroup As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents Label28 As Label
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents txtforename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtsurname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Email_addressTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtphonenumber As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents Label13 As Label
    Private WithEvents Label15 As Label
    Private WithEvents Label17 As Label
    Friend WithEvents Panel2 As Panel
    Private WithEvents DataGridView1 As DataGridView
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarItem1 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem2 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem3 As DevExpress.XtraBars.Navigation.TileBarItem
End Class
