<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_PointOfSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PointOfSale))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.GunaGradientPanel2 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.lbl_TotalSales = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.btn_MySale = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btn_Sale = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_Minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaGradientPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.btn_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradientPanel2
        '
        Me.GunaGradientPanel2.BackgroundImage = CType(resources.GetObject("GunaGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel2.Controls.Add(Me.lbl_TotalSales)
        Me.GunaGradientPanel2.Controls.Add(Me.lblUserName)
        Me.GunaGradientPanel2.Controls.Add(Me.lblUserID)
        Me.GunaGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaGradientPanel2.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradientPanel2.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradientPanel2.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel2.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel2.Location = New System.Drawing.Point(0, 29)
        Me.GunaGradientPanel2.Name = "GunaGradientPanel2"
        Me.GunaGradientPanel2.Size = New System.Drawing.Size(1199, 48)
        Me.GunaGradientPanel2.TabIndex = 3
        Me.GunaGradientPanel2.Text = "GunaGradientPanel2"
        '
        'lbl_TotalSales
        '
        Me.lbl_TotalSales.AutoSize = True
        Me.lbl_TotalSales.Location = New System.Drawing.Point(513, 17)
        Me.lbl_TotalSales.Name = "lbl_TotalSales"
        Me.lbl_TotalSales.Size = New System.Drawing.Size(39, 13)
        Me.lbl_TotalSales.TabIndex = 13
        Me.lbl_TotalSales.Text = "Label2"
        Me.lbl_TotalSales.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(12, 17)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(62, 23)
        Me.lblUserName.TabIndex = 12
        Me.lblUserName.Text = "Label2"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(1091, 17)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(62, 23)
        Me.lblUserID.TabIndex = 11
        Me.lblUserID.Text = "Label2"
        '
        'btn_MySale
        '
        Me.btn_MySale.AllowToggling = False
        Me.btn_MySale.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_MySale.AnimationSpeed = 200
        Me.btn_MySale.AutoGenerateColors = False
        Me.btn_MySale.BackColor = System.Drawing.Color.Transparent
        Me.btn_MySale.BackColor1 = System.Drawing.Color.Yellow
        Me.btn_MySale.BackgroundImage = CType(resources.GetObject("btn_MySale.BackgroundImage"), System.Drawing.Image)
        Me.btn_MySale.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_MySale.ButtonText = "My Sales"
        Me.btn_MySale.ButtonTextMarginLeft = 0
        Me.btn_MySale.ColorContrastOnClick = 45
        Me.btn_MySale.ColorContrastOnHover = 45
        Me.btn_MySale.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_MySale.CustomizableEdges = BorderEdges1
        Me.btn_MySale.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_MySale.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btn_MySale.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_MySale.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_MySale.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_MySale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_MySale.ForeColor = System.Drawing.Color.Black
        Me.btn_MySale.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_MySale.IconMarginLeft = 11
        Me.btn_MySale.IconPadding = 10
        Me.btn_MySale.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_MySale.IdleBorderColor = System.Drawing.Color.Black
        Me.btn_MySale.IdleBorderRadius = 3
        Me.btn_MySale.IdleBorderThickness = 1
        Me.btn_MySale.IdleFillColor = System.Drawing.Color.Yellow
        Me.btn_MySale.IdleIconLeftImage = Nothing
        Me.btn_MySale.IdleIconRightImage = Nothing
        Me.btn_MySale.IndicateFocus = False
        Me.btn_MySale.Location = New System.Drawing.Point(7, 83)
        Me.btn_MySale.Name = "btn_MySale"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.BorderRadius = 3
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btn_MySale.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 3
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btn_MySale.OnPressedState = StateProperties2
        Me.btn_MySale.Size = New System.Drawing.Size(189, 45)
        Me.btn_MySale.TabIndex = 10
        Me.btn_MySale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_MySale.TextMarginLeft = 0
        Me.btn_MySale.UseDefaultRadiusAndThickness = True
        '
        'btn_Sale
        '
        Me.btn_Sale.AllowToggling = False
        Me.btn_Sale.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Sale.AnimationSpeed = 200
        Me.btn_Sale.AutoGenerateColors = False
        Me.btn_Sale.BackColor = System.Drawing.Color.Transparent
        Me.btn_Sale.BackColor1 = System.Drawing.Color.Yellow
        Me.btn_Sale.BackgroundImage = CType(resources.GetObject("btn_Sale.BackgroundImage"), System.Drawing.Image)
        Me.btn_Sale.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_Sale.ButtonText = "Make Sales"
        Me.btn_Sale.ButtonTextMarginLeft = 0
        Me.btn_Sale.ColorContrastOnClick = 45
        Me.btn_Sale.ColorContrastOnHover = 45
        Me.btn_Sale.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btn_Sale.CustomizableEdges = BorderEdges2
        Me.btn_Sale.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Sale.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btn_Sale.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Sale.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_Sale.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_Sale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Sale.ForeColor = System.Drawing.Color.Black
        Me.btn_Sale.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Sale.IconMarginLeft = 11
        Me.btn_Sale.IconPadding = 10
        Me.btn_Sale.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Sale.IdleBorderColor = System.Drawing.Color.Black
        Me.btn_Sale.IdleBorderRadius = 3
        Me.btn_Sale.IdleBorderThickness = 1
        Me.btn_Sale.IdleFillColor = System.Drawing.Color.Yellow
        Me.btn_Sale.IdleIconLeftImage = Nothing
        Me.btn_Sale.IdleIconRightImage = Nothing
        Me.btn_Sale.IndicateFocus = False
        Me.btn_Sale.Location = New System.Drawing.Point(7, 30)
        Me.btn_Sale.Name = "btn_Sale"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.BorderRadius = 3
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.btn_Sale.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 3
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btn_Sale.OnPressedState = StateProperties4
        Me.btn_Sale.Size = New System.Drawing.Size(189, 45)
        Me.btn_Sale.TabIndex = 9
        Me.btn_Sale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Sale.TextMarginLeft = 0
        Me.btn_Sale.UseDefaultRadiusAndThickness = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1199, 29)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReportToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.CloseToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.SettingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(78, 25)
        Me.SettingToolStripMenuItem.Text = "Settings"
        '
        'ViewReportToolStripMenuItem
        '
        Me.ViewReportToolStripMenuItem.Name = "ViewReportToolStripMenuItem"
        Me.ViewReportToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ViewReportToolStripMenuItem.Text = "View Report"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'btn_Minimize
        '
        Me.btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimize.Image = Global.point_of_sale.My.Resources.Resources.gg
        Me.btn_Minimize.ImageActive = Nothing
        Me.btn_Minimize.Location = New System.Drawing.Point(1109, 0)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(29, 31)
        Me.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimize.TabIndex = 5
        Me.btn_Minimize.TabStop = False
        Me.btn_Minimize.Zoom = 10
        '
        'btn_Maximize
        '
        Me.btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximize.Image = Global.point_of_sale.My.Resources.Resources.ew
        Me.btn_Maximize.ImageActive = Nothing
        Me.btn_Maximize.Location = New System.Drawing.Point(1141, 0)
        Me.btn_Maximize.Name = "btn_Maximize"
        Me.btn_Maximize.Size = New System.Drawing.Size(28, 31)
        Me.btn_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Maximize.TabIndex = 6
        Me.btn_Maximize.TabStop = False
        Me.btn_Maximize.Zoom = 10
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(1169, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 31)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 7
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(406, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Sale)
        Me.Panel1.Controls.Add(Me.btn_MySale)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 604)
        Me.Panel1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(512, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ANEK POS"
        '
        'frm_PointOfSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.point_of_sale.My.Resources.Resources.flickr_marco_verch
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1199, 681)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Maximize)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.GunaGradientPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_PointOfSale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaGradientPanel2.ResumeLayout(False)
        Me.GunaGradientPanel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.btn_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaGradientPanel2 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn_Minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Maximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_MySale As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents btn_Sale As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_TotalSales As Label
End Class
