<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomePage))
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtusergroup = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dateIn = New System.Windows.Forms.TextBox()
        Me.timeIn = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TileBarItem1 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem2 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem3 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem4 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.TabPane1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPane1.SuspendLayout
        Me.TabNavigationPage1.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.TabNavigationPage1.Caption = "Home Page"
        Me.TabNavigationPage1.Controls.Add(Me.TileBar1)
        Me.TabNavigationPage1.Controls.Add(Me.PictureBox4)
        Me.TabNavigationPage1.Controls.Add(Me.Panel2)
        Me.TabNavigationPage1.Controls.Add(Me.PictureBox2)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1330, 576)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtusergroup)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.dateIn)
        Me.Panel2.Controls.Add(Me.timeIn)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(896, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 95)
        Me.Panel2.TabIndex = 344
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.Enabled = false
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.lblUsername.Location = New System.Drawing.Point(293, 65)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.ReadOnly = true
        Me.lblUsername.Size = New System.Drawing.Size(103, 18)
        Me.lblUsername.TabIndex = 337
        Me.lblUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label12.Location = New System.Drawing.Point(203, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 334
        Me.Label12.Text = "USERNAME :"
        '
        'txtusergroup
        '
        Me.txtusergroup.BackColor = System.Drawing.Color.White
        Me.txtusergroup.Enabled = false
        Me.txtusergroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.txtusergroup.Location = New System.Drawing.Point(93, 42)
        Me.txtusergroup.Name = "txtusergroup"
        Me.txtusergroup.ReadOnly = true
        Me.txtusergroup.Size = New System.Drawing.Size(103, 18)
        Me.txtusergroup.TabIndex = 339
        Me.txtusergroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label11.Location = New System.Drawing.Point(203, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 12)
        Me.Label11.TabIndex = 336
        Me.Label11.Text = "DATE LOGGED IN :"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label8.Location = New System.Drawing.Point(3, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 12)
        Me.Label8.TabIndex = 338
        Me.Label8.Text = "USER GROUP :"
        '
        'dateIn
        '
        Me.dateIn.BackColor = System.Drawing.Color.White
        Me.dateIn.Enabled = false
        Me.dateIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.dateIn.Location = New System.Drawing.Point(293, 44)
        Me.dateIn.Name = "dateIn"
        Me.dateIn.ReadOnly = true
        Me.dateIn.Size = New System.Drawing.Size(103, 18)
        Me.dateIn.TabIndex = 333
        Me.dateIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'timeIn
        '
        Me.timeIn.BackColor = System.Drawing.Color.White
        Me.timeIn.Enabled = false
        Me.timeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.timeIn.Location = New System.Drawing.Point(93, 66)
        Me.timeIn.Name = "timeIn"
        Me.timeIn.ReadOnly = true
        Me.timeIn.Size = New System.Drawing.Size(103, 18)
        Me.timeIn.TabIndex = 332
        Me.timeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label9.Location = New System.Drawing.Point(3, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 12)
        Me.Label9.TabIndex = 335
        Me.Label9.Text = "TIME LOGGED IN:"
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
        Me.TileBar1.Location = New System.Drawing.Point(12, 10)
        Me.TileBar1.MaxId = 4
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.Size = New System.Drawing.Size(866, 99)
        Me.TileBar1.TabIndex = 346
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.TileBarItem1)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem2)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem3)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem4)
        Me.TileBarGroup2.Name = "TileBarGroup2"
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
        'TileBarItem1
        '
        Me.TileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"),System.Drawing.Image)
        TileItemElement1.Text = "Log Card Details"
        Me.TileBarItem1.Elements.Add(TileItemElement1)
        Me.TileBarItem1.Id = 0
        Me.TileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem1.Name = "TileBarItem1"
        '
        'TileBarItem2
        '
        Me.TileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"),System.Drawing.Image)
        TileItemElement2.Text = "Issued Cards"
        Me.TileBarItem2.Elements.Add(TileItemElement2)
        Me.TileBarItem2.Id = 1
        Me.TileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem2.Name = "TileBarItem2"
        '
        'TileBarItem3
        '
        Me.TileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"),System.Drawing.Image)
        TileItemElement3.Text = "Administration"
        Me.TileBarItem3.Elements.Add(TileItemElement3)
        Me.TileBarItem3.Id = 2
        Me.TileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem3.Name = "TileBarItem3"
        '
        'TileBarItem4
        '
        Me.TileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement4.Image = CType(resources.GetObject("TileItemElement4.Image"),System.Drawing.Image)
        TileItemElement4.Text = "Reports"
        Me.TileBarItem4.Elements.Add(TileItemElement4)
        Me.TileBarItem4.Id = 3
        Me.TileBarItem4.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem4.Name = "TileBarItem4"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Lost_Card_Tracker.My.Resources.Resources.locate
        Me.PictureBox4.Location = New System.Drawing.Point(947, 113)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(380, 373)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 345
        Me.PictureBox4.TabStop = false
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(125, 33)
        Me.SimpleButton1.TabIndex = 341
        Me.SimpleButton1.Text = "Change Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Lost_Card_Tracker.My.Resources.Resources.output_Ps1ChL
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1330, 576)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = false
        '
        'frmHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 621)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabPane1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CABS Lost Card Tracker "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabPane1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPane1.ResumeLayout(false)
        Me.TabNavigationPage1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblUsername As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtusergroup As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dateIn As TextBox
    Friend WithEvents timeIn As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarItem1 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem2 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem3 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem4 As DevExpress.XtraBars.Navigation.TileBarItem
End Class
