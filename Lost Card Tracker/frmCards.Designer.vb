<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCards
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCards))
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.c2 = New DevExpress.XtraEditors.TextEdit()
        Me.c1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.groupBox11 = New System.Windows.Forms.GroupBox()
        Me.c8 = New DevExpress.XtraEditors.TextEdit()
        Me.c7 = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c6 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c5 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.label24 = New System.Windows.Forms.Label()
        Me.c4 = New DevExpress.XtraEditors.TextEdit()
        Me.label22 = New System.Windows.Forms.Label()
        Me.c3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label37 = New System.Windows.Forms.Label()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.TileBarItem1 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem2 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem3 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.TabPane1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPane1.SuspendLayout
        Me.TabNavigationPage1.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        Me.groupBox8.SuspendLayout
        CType(Me.c2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox11.SuspendLayout
        CType(Me.c8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.TabNavigationPage1.Caption = "Capture Card Details"
        Me.TabNavigationPage1.Controls.Add(Me.Panel3)
        Me.TabNavigationPage1.Controls.Add(Me.Panel2)
        Me.TabNavigationPage1.Controls.Add(Me.TileBar1)
        Me.TabNavigationPage1.Controls.Add(Me.PictureBox4)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1330, 576)
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(436, 113)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(855, 253)
        Me.Panel3.TabIndex = 348
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
        Me.DataGridView1.Size = New System.Drawing.Size(853, 251)
        Me.DataGridView1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.groupBox8)
        Me.Panel2.Controls.Add(Me.groupBox11)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 359)
        Me.Panel2.TabIndex = 347
        '
        'groupBox8
        '
        Me.groupBox8.Controls.Add(Me.c2)
        Me.groupBox8.Controls.Add(Me.c1)
        Me.groupBox8.Controls.Add(Me.Label1)
        Me.groupBox8.Controls.Add(Me.label27)
        Me.groupBox8.Font = New System.Drawing.Font("Corbel", 9!)
        Me.groupBox8.Location = New System.Drawing.Point(13, 21)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Size = New System.Drawing.Size(396, 74)
        Me.groupBox8.TabIndex = 9
        Me.groupBox8.TabStop = false
        Me.groupBox8.Text = "Date and Time"
        '
        'c2
        '
        Me.c2.Location = New System.Drawing.Point(147, 47)
        Me.c2.Name = "c2"
        Me.c2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.c2.Properties.Appearance.Options.UseBackColor = true
        Me.c2.Properties.ReadOnly = true
        Me.c2.Size = New System.Drawing.Size(202, 20)
        Me.c2.TabIndex = 20
        '
        'c1
        '
        Me.c1.Location = New System.Drawing.Point(147, 21)
        Me.c1.Name = "c1"
        Me.c1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.c1.Properties.Appearance.Options.UseBackColor = true
        Me.c1.Properties.ReadOnly = true
        Me.c1.Size = New System.Drawing.Size(202, 20)
        Me.c1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9!)
        Me.Label1.Location = New System.Drawing.Point(9, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Time"
        '
        'label27
        '
        Me.label27.AutoSize = true
        Me.label27.Font = New System.Drawing.Font("Corbel", 9!)
        Me.label27.Location = New System.Drawing.Point(9, 27)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(31, 14)
        Me.label27.TabIndex = 16
        Me.label27.Text = "Date"
        '
        'groupBox11
        '
        Me.groupBox11.Controls.Add(Me.c8)
        Me.groupBox11.Controls.Add(Me.SimpleButton6)
        Me.groupBox11.Controls.Add(Me.SimpleButton7)
        Me.groupBox11.Controls.Add(Me.c7)
        Me.groupBox11.Controls.Add(Me.Label3)
        Me.groupBox11.Controls.Add(Me.c6)
        Me.groupBox11.Controls.Add(Me.Label2)
        Me.groupBox11.Controls.Add(Me.c5)
        Me.groupBox11.Controls.Add(Me.label24)
        Me.groupBox11.Controls.Add(Me.c4)
        Me.groupBox11.Controls.Add(Me.label22)
        Me.groupBox11.Controls.Add(Me.c3)
        Me.groupBox11.Controls.Add(Me.Label6)
        Me.groupBox11.Controls.Add(Me.label37)
        Me.groupBox11.Font = New System.Drawing.Font("Corbel", 9!)
        Me.groupBox11.Location = New System.Drawing.Point(13, 101)
        Me.groupBox11.Name = "groupBox11"
        Me.groupBox11.Size = New System.Drawing.Size(396, 253)
        Me.groupBox11.TabIndex = 0
        Me.groupBox11.TabStop = false
        Me.groupBox11.Text = "Client Details"
        '
        'c8
        '
        Me.c8.Location = New System.Drawing.Point(149, 153)
        Me.c8.Name = "c8"
        Me.c8.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.c8.Properties.Appearance.Options.UseBackColor = true
        Me.c8.Properties.ReadOnly = true
        Me.c8.Size = New System.Drawing.Size(202, 20)
        Me.c8.TabIndex = 145
        '
        'c7
        '
        Me.c7.Location = New System.Drawing.Point(149, 127)
        Me.c7.Name = "c7"
        Me.c7.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.c7.Properties.Appearance.Options.UseBackColor = true
        Me.c7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.c7.Properties.Mask.BeepOnError = true
        Me.c7.Properties.Mask.EditMask = "c"
        Me.c7.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.c7.Properties.Mask.ShowPlaceHolders = false
        Me.c7.Size = New System.Drawing.Size(200, 20)
        Me.c7.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9!)
        Me.Label3.Location = New System.Drawing.Point(10, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 14)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Account Balance(After)"
        '
        'c6
        '
        Me.c6.Location = New System.Drawing.Point(149, 101)
        Me.c6.Name = "c6"
        Me.c6.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.c6.Properties.Appearance.Options.UseBackColor = true
        Me.c6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.c6.Properties.Mask.BeepOnError = true
        Me.c6.Properties.Mask.EditMask = "c"
        Me.c6.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.c6.Properties.Mask.ShowPlaceHolders = false
        Me.c6.Size = New System.Drawing.Size(200, 20)
        Me.c6.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9!)
        Me.Label2.Location = New System.Drawing.Point(10, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Account Balance"
        '
        'c5
        '
        Me.c5.Location = New System.Drawing.Point(149, 75)
        Me.c5.Name = "c5"
        Me.c5.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.c5.Properties.Appearance.Options.UseBackColor = true
        Me.c5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.c5.Properties.Items.AddRange(New Object() {"Damaged Card", "Lost Card", "Stolen Card"})
        Me.c5.Properties.Sorted = true
        Me.c5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.c5.Size = New System.Drawing.Size(200, 20)
        Me.c5.TabIndex = 2
        '
        'label24
        '
        Me.label24.AutoSize = true
        Me.label24.Font = New System.Drawing.Font("Corbel", 9!)
        Me.label24.Location = New System.Drawing.Point(12, 78)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(65, 14)
        Me.label24.TabIndex = 23
        Me.label24.Text = "Report Type"
        '
        'c4
        '
        Me.c4.Location = New System.Drawing.Point(149, 47)
        Me.c4.Name = "c4"
        Me.c4.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.c4.Properties.Appearance.Options.UseBackColor = true
        Me.c4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.c4.Properties.Mask.BeepOnError = true
        Me.c4.Properties.Mask.EditMask = "([ 0-9])* "
        Me.c4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.c4.Properties.Mask.ShowPlaceHolders = false
        Me.c4.Size = New System.Drawing.Size(200, 20)
        Me.c4.TabIndex = 1
        '
        'label22
        '
        Me.label22.AutoSize = true
        Me.label22.Font = New System.Drawing.Font("Corbel", 9!)
        Me.label22.Location = New System.Drawing.Point(10, 51)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(89, 14)
        Me.label22.TabIndex = 21
        Me.label22.Text = "Account Number"
        '
        'c3
        '
        Me.c3.Location = New System.Drawing.Point(149, 21)
        Me.c3.Name = "c3"
        Me.c3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.c3.Properties.Appearance.Options.UseBackColor = true
        Me.c3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.c3.Properties.Mask.BeepOnError = true
        Me.c3.Properties.Mask.EditMask = "+263700000000"
        Me.c3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.c3.Size = New System.Drawing.Size(200, 20)
        Me.c3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Corbel", 9!)
        Me.Label6.Location = New System.Drawing.Point(13, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 14)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Cell Phone"
        '
        'label37
        '
        Me.label37.AutoSize = true
        Me.label37.Font = New System.Drawing.Font("Corbel", 9!)
        Me.label37.Location = New System.Drawing.Point(12, 160)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(52, 14)
        Me.label37.TabIndex = 15
        Me.label37.Text = "Operator"
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
        Me.TileBar1.Location = New System.Drawing.Point(768, 12)
        Me.TileBar1.MaxId = 5
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.Size = New System.Drawing.Size(562, 99)
        Me.TileBar1.TabIndex = 346
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.TileBarItem1)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem2)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem3)
        Me.TileBarGroup2.Name = "TileBarGroup2"
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
        'Timer1
        '
        Me.Timer1.Enabled = true
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
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton6.Appearance.Options.UseBackColor = true
        Me.SimpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton6.Enabled = false
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"),System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(264, 184)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(87, 29)
        Me.SimpleButton6.TabIndex = 144
        Me.SimpleButton6.TabStop = false
        Me.SimpleButton6.Text = "&Delete"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.Options.UseBackColor = true
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"),System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(160, 184)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(87, 29)
        Me.SimpleButton7.TabIndex = 143
        Me.SimpleButton7.TabStop = false
        Me.SimpleButton7.Text = "&Save"
        '
        'TileBarItem1
        '
        Me.TileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"),System.Drawing.Image)
        TileItemElement1.Text = "Lost Cards"
        Me.TileBarItem1.Elements.Add(TileItemElement1)
        Me.TileBarItem1.Id = 0
        Me.TileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem1.Name = "TileBarItem1"
        '
        'TileBarItem2
        '
        Me.TileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"),System.Drawing.Image)
        TileItemElement2.Text = "Stolen Cards"
        Me.TileBarItem2.Elements.Add(TileItemElement2)
        Me.TileBarItem2.Id = 1
        Me.TileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem2.Name = "TileBarItem2"
        '
        'TileBarItem3
        '
        Me.TileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"),System.Drawing.Image)
        TileItemElement3.Text = "Damaged Cards"
        Me.TileBarItem3.Elements.Add(TileItemElement3)
        Me.TileBarItem3.Id = 4
        Me.TileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem3.Name = "TileBarItem3"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Lost_Card_Tracker.My.Resources.Resources.phasing_out_slips_slider2
        Me.PictureBox4.Location = New System.Drawing.Point(-120, 297)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1250, 708)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 345
        Me.PictureBox4.TabStop = false
        '
        'frmCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 621)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabPane1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmCards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CABS Lost Card Tracker "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabPane1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPane1.ResumeLayout(false)
        Me.TabNavigationPage1.ResumeLayout(false)
        Me.TabNavigationPage1.PerformLayout
        Me.Panel3.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.groupBox8.ResumeLayout(false)
        Me.groupBox8.PerformLayout
        CType(Me.c2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox11.ResumeLayout(false)
        Me.groupBox11.PerformLayout
        CType(Me.c8.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c7.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c6.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c5.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c4.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarItem1 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem2 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents Panel2 As Panel
    Private WithEvents groupBox11 As GroupBox
    Private WithEvents label37 As Label
    Private WithEvents groupBox8 As GroupBox
    Private WithEvents label27 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents c4 As DevExpress.XtraEditors.TextEdit
    Private WithEvents label22 As Label
    Friend WithEvents c3 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label6 As Label
    Friend WithEvents c5 As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents label24 As Label
    Friend WithEvents c7 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label3 As Label
    Friend WithEvents c6 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label2 As Label
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As Panel
    Private WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TileBarItem3 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents c2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents c1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents c8 As DevExpress.XtraEditors.TextEdit
End Class
