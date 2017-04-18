<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssued
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIssued))
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.i2 = New DevExpress.XtraEditors.TextEdit()
        Me.i1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.groupBox11 = New System.Windows.Forms.GroupBox()
        Me.i5 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.i4 = New DevExpress.XtraEditors.TextEdit()
        Me.label22 = New System.Windows.Forms.Label()
        Me.i3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label37 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TabPane1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPane1.SuspendLayout
        Me.TabNavigationPage1.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        Me.groupBox8.SuspendLayout
        CType(Me.i2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.i1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox11.SuspendLayout
        CType(Me.i5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.i4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.i3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.TabNavigationPage1.Caption = "Issued Cards"
        Me.TabNavigationPage1.Controls.Add(Me.Panel3)
        Me.TabNavigationPage1.Controls.Add(Me.Panel2)
        Me.TabNavigationPage1.Controls.Add(Me.PictureBox4)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1330, 576)
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(436, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(855, 359)
        Me.Panel3.TabIndex = 348
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(853, 357)
        Me.DataGridView1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.groupBox8)
        Me.Panel2.Controls.Add(Me.groupBox11)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 259)
        Me.Panel2.TabIndex = 347
        '
        'groupBox8
        '
        Me.groupBox8.Controls.Add(Me.i2)
        Me.groupBox8.Controls.Add(Me.i1)
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
        'i2
        '
        Me.i2.Location = New System.Drawing.Point(147, 47)
        Me.i2.Name = "i2"
        Me.i2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.i2.Properties.Appearance.Options.UseBackColor = true
        Me.i2.Properties.ReadOnly = true
        Me.i2.Size = New System.Drawing.Size(202, 20)
        Me.i2.TabIndex = 20
        '
        'i1
        '
        Me.i1.Location = New System.Drawing.Point(147, 21)
        Me.i1.Name = "i1"
        Me.i1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.i1.Properties.Appearance.Options.UseBackColor = true
        Me.i1.Properties.ReadOnly = true
        Me.i1.Size = New System.Drawing.Size(202, 20)
        Me.i1.TabIndex = 19
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
        Me.groupBox11.Controls.Add(Me.i5)
        Me.groupBox11.Controls.Add(Me.SimpleButton7)
        Me.groupBox11.Controls.Add(Me.i4)
        Me.groupBox11.Controls.Add(Me.label22)
        Me.groupBox11.Controls.Add(Me.i3)
        Me.groupBox11.Controls.Add(Me.Label6)
        Me.groupBox11.Controls.Add(Me.label37)
        Me.groupBox11.Font = New System.Drawing.Font("Corbel", 9!)
        Me.groupBox11.Location = New System.Drawing.Point(13, 101)
        Me.groupBox11.Name = "groupBox11"
        Me.groupBox11.Size = New System.Drawing.Size(396, 150)
        Me.groupBox11.TabIndex = 0
        Me.groupBox11.TabStop = false
        Me.groupBox11.Text = "Client Details"
        '
        'i5
        '
        Me.i5.Location = New System.Drawing.Point(147, 76)
        Me.i5.Name = "i5"
        Me.i5.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.i5.Properties.Appearance.Options.UseBackColor = true
        Me.i5.Properties.ReadOnly = true
        Me.i5.Size = New System.Drawing.Size(202, 20)
        Me.i5.TabIndex = 145
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.Options.UseBackColor = true
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"),System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(246, 107)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(103, 29)
        Me.SimpleButton7.TabIndex = 143
        Me.SimpleButton7.TabStop = false
        Me.SimpleButton7.Text = "Card Issued"
        '
        'i4
        '
        Me.i4.Location = New System.Drawing.Point(149, 47)
        Me.i4.Name = "i4"
        Me.i4.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.i4.Properties.Appearance.Options.UseBackColor = true
        Me.i4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.i4.Properties.Mask.BeepOnError = true
        Me.i4.Properties.Mask.EditMask = "([ 0-9])* "
        Me.i4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.i4.Properties.Mask.ShowPlaceHolders = false
        Me.i4.Properties.ReadOnly = true
        Me.i4.Size = New System.Drawing.Size(200, 20)
        Me.i4.TabIndex = 1
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
        'i3
        '
        Me.i3.Location = New System.Drawing.Point(149, 21)
        Me.i3.Name = "i3"
        Me.i3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.i3.Properties.Appearance.Options.UseBackColor = true
        Me.i3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.i3.Properties.Mask.BeepOnError = true
        Me.i3.Properties.Mask.EditMask = "+263700000000"
        Me.i3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.i3.Properties.ReadOnly = true
        Me.i3.Size = New System.Drawing.Size(200, 20)
        Me.i3.TabIndex = 0
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
        Me.label37.Location = New System.Drawing.Point(10, 83)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(52, 14)
        Me.label37.TabIndex = 15
        Me.label37.Text = "Operator"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Lost_Card_Tracker.My.Resources.Resources.phasing_out_slips_slider2
        Me.PictureBox4.Location = New System.Drawing.Point(-135, 269)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1250, 708)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 345
        Me.PictureBox4.TabStop = false
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
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'frmIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 621)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabPane1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmIssued"
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
        CType(Me.i2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.i1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox11.ResumeLayout(false)
        Me.groupBox11.PerformLayout
        CType(Me.i5.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.i4.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.i3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Private WithEvents groupBox11 As GroupBox
    Private WithEvents label37 As Label
    Private WithEvents groupBox8 As GroupBox
    Private WithEvents label27 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents i4 As DevExpress.XtraEditors.TextEdit
    Private WithEvents label22 As Label
    Friend WithEvents i3 As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label6 As Label
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As Panel
    Private WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents i2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents i1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents i5 As DevExpress.XtraEditors.TextEdit
End Class
