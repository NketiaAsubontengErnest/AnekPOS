<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblInvalid = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txt_Password = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txt_Username = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.point_of_sale.My.Resources.Resources.pos_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.Gold
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLogin.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(157, 243)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Padding = New System.Windows.Forms.Padding(5)
        Me.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(324, 45)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.ProgressBar1)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnLogin)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuLabel1)
        Me.BunifuGradientPanel2.Controls.Add(Me.lblInvalid)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuLabel2)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuLabel3)
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_Close)
        Me.BunifuGradientPanel2.Controls.Add(Me.txt_Password)
        Me.BunifuGradientPanel2.Controls.Add(Me.txt_Username)
        Me.BunifuGradientPanel2.Controls.Add(Me.GunaPanel1)
        Me.BunifuGradientPanel2.Controls.Add(Me.GunaPanel2)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(503, 307)
        Me.BunifuGradientPanel2.TabIndex = 1
        Me.BunifuGradientPanel2.TabStop = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.ProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.ProgressBar1.Location = New System.Drawing.Point(134, 297)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressMaxColor = System.Drawing.Color.Goldenrod
        Me.ProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ProgressBar1.Size = New System.Drawing.Size(357, 10)
        Me.ProgressBar1.TabIndex = 49
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(270, 60)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(114, 27)
        Me.BunifuLabel1.TabIndex = 3
        Me.BunifuLabel1.Text = "Employee ID"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblInvalid
        '
        Me.lblInvalid.AutoEllipsis = False
        Me.lblInvalid.CursorType = Nothing
        Me.lblInvalid.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalid.Location = New System.Drawing.Point(157, 40)
        Me.lblInvalid.Name = "lblInvalid"
        Me.lblInvalid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInvalid.Size = New System.Drawing.Size(0, 0)
        Me.lblInvalid.TabIndex = 3
        Me.lblInvalid.Text = Nothing
        Me.lblInvalid.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblInvalid.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(287, 146)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(88, 27)
        Me.BunifuLabel2.TabIndex = 3
        Me.BunifuLabel2.Text = "Password"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(200, 5)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(237, 27)
        Me.BunifuLabel3.TabIndex = 3
        Me.BunifuLabel3.Text = "ANEK POS SYSTEM LOGIN"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btn_Close
        '
        Me.btn_Close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_Close.ImageActive = Nothing
        Me.btn_Close.Location = New System.Drawing.Point(472, 2)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(35, 30)
        Me.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Close.TabIndex = 0
        Me.btn_Close.TabStop = False
        Me.btn_Close.Zoom = 10
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.Color.White
        Me.txt_Password.BorderColorFocused = System.Drawing.Color.Blue
        Me.txt_Password.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Password.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txt_Password.BorderThickness = 3
        Me.txt_Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Password.isPassword = True
        Me.txt_Password.Location = New System.Drawing.Point(157, 180)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Password.MaxLength = 32767
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(324, 44)
        Me.txt_Password.TabIndex = 1
        Me.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Username
        '
        Me.txt_Username.BackColor = System.Drawing.Color.White
        Me.txt_Username.BorderColorFocused = System.Drawing.Color.Blue
        Me.txt_Username.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Username.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txt_Username.BorderThickness = 3
        Me.txt_Username.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Username.isPassword = False
        Me.txt_Username.Location = New System.Drawing.Point(157, 94)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Username.MaxLength = 32767
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(324, 44)
        Me.txt_Username.TabIndex = 0
        Me.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(134, 307)
        Me.GunaPanel1.TabIndex = 50
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel2.Location = New System.Drawing.Point(491, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(12, 307)
        Me.GunaPanel2.TabIndex = 51
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 307)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_Password As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txt_Username As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuLabel3 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents lblInvalid As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
End Class
