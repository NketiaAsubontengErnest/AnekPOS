<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChanegePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ChanegePassword))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_currentPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_NewPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_confPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserID = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_change = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(203, 60)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(65, 21)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "User ID"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(164, 144)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(143, 21)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "Current Password"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(179, 222)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(121, 21)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "New Password"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(167, 306)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(148, 21)
        Me.GunaLabel4.TabIndex = 0
        Me.GunaLabel4.Text = "Confirm Password"
        '
        'txt_currentPassword
        '
        Me.txt_currentPassword.BaseColor = System.Drawing.Color.White
        Me.txt_currentPassword.BorderColor = System.Drawing.Color.Silver
        Me.txt_currentPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_currentPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_currentPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_currentPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_currentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currentPassword.Location = New System.Drawing.Point(42, 167)
        Me.txt_currentPassword.Name = "txt_currentPassword"
        Me.txt_currentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_currentPassword.SelectedText = ""
        Me.txt_currentPassword.Size = New System.Drawing.Size(396, 43)
        Me.txt_currentPassword.TabIndex = 1
        Me.txt_currentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_NewPassword
        '
        Me.txt_NewPassword.BaseColor = System.Drawing.Color.White
        Me.txt_NewPassword.BorderColor = System.Drawing.Color.Silver
        Me.txt_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_NewPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_NewPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_NewPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_NewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewPassword.Location = New System.Drawing.Point(42, 246)
        Me.txt_NewPassword.Name = "txt_NewPassword"
        Me.txt_NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_NewPassword.SelectedText = ""
        Me.txt_NewPassword.Size = New System.Drawing.Size(396, 45)
        Me.txt_NewPassword.TabIndex = 2
        Me.txt_NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_confPassword
        '
        Me.txt_confPassword.BaseColor = System.Drawing.Color.White
        Me.txt_confPassword.BorderColor = System.Drawing.Color.Silver
        Me.txt_confPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_confPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_confPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_confPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_confPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confPassword.Location = New System.Drawing.Point(42, 330)
        Me.txt_confPassword.Name = "txt_confPassword"
        Me.txt_confPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_confPassword.SelectedText = ""
        Me.txt_confPassword.Size = New System.Drawing.Size(396, 41)
        Me.txt_confPassword.TabIndex = 3
        Me.txt_confPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(164, 16)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(166, 21)
        Me.GunaLabel5.TabIndex = 0
        Me.GunaLabel5.Text = "Reset Your Password"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(474, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 47)
        Me.Label8.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(-10, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 47)
        Me.Label7.TabIndex = 44
        '
        'txtUserID
        '
        Me.txtUserID.BaseColor = System.Drawing.Color.White
        Me.txtUserID.BorderColor = System.Drawing.Color.Silver
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.Enabled = False
        Me.txtUserID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUserID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(42, 82)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserID.SelectedText = ""
        Me.txtUserID.Size = New System.Drawing.Size(396, 43)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(10, 451)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(454, 10)
        Me.Panel6.TabIndex = 48
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(670, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(13, 472)
        Me.Panel7.TabIndex = 34
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(10, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(454, 10)
        Me.Panel4.TabIndex = 49
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(670, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(13, 472)
        Me.Panel5.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(464, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 461)
        Me.Panel2.TabIndex = 47
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(670, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 472)
        Me.Panel3.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 461)
        Me.Panel1.TabIndex = 46
        '
        'btn_close
        '
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(443, 1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 29)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 5
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'btn_change
        '
        Me.btn_change.AllowToggling = False
        Me.btn_change.AnimationSpeed = 200
        Me.btn_change.AutoGenerateColors = False
        Me.btn_change.BackColor = System.Drawing.Color.Transparent
        Me.btn_change.BackColor1 = System.Drawing.Color.Yellow
        Me.btn_change.BackgroundImage = CType(resources.GetObject("btn_change.BackgroundImage"), System.Drawing.Image)
        Me.btn_change.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_change.ButtonText = "change"
        Me.btn_change.ButtonTextMarginLeft = 0
        Me.btn_change.ColorContrastOnClick = 45
        Me.btn_change.ColorContrastOnHover = 45
        Me.btn_change.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_change.CustomizableEdges = BorderEdges1
        Me.btn_change.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_change.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btn_change.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_change.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_change.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_change.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btn_change.ForeColor = System.Drawing.Color.Black
        Me.btn_change.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_change.IconMarginLeft = 11
        Me.btn_change.IconPadding = 10
        Me.btn_change.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_change.IdleBorderColor = System.Drawing.Color.Black
        Me.btn_change.IdleBorderRadius = 3
        Me.btn_change.IdleBorderThickness = 1
        Me.btn_change.IdleFillColor = System.Drawing.Color.Yellow
        Me.btn_change.IdleIconLeftImage = Nothing
        Me.btn_change.IdleIconRightImage = Nothing
        Me.btn_change.IndicateFocus = False
        Me.btn_change.Location = New System.Drawing.Point(42, 390)
        Me.btn_change.Name = "btn_change"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.BorderRadius = 3
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btn_change.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 3
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btn_change.OnPressedState = StateProperties2
        Me.btn_change.Size = New System.Drawing.Size(396, 59)
        Me.btn_change.TabIndex = 4
        Me.btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_change.TextMarginLeft = 0
        Me.btn_change.UseDefaultRadiusAndThickness = True
        '
        'frm_ChanegePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(474, 461)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.txt_confPassword)
        Me.Controls.Add(Me.txt_NewPassword)
        Me.Controls.Add(Me.txt_currentPassword)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.txtUserID)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ChanegePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ChanegePassword"
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_currentPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_NewPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_confPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_change As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUserID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
End Class
