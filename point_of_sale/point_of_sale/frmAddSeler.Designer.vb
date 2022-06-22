<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSeler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSeler))
        Dim BorderEdges1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_UserID = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_Name = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_Phone = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_Password = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_Add = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.btn_Clear = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.cmd_position = New System.Windows.Forms.ComboBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_Address = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.Location = New System.Drawing.Point(197, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(216, 37)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "ADD EMPLOYEE"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(19, 66)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(77, 25)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "User ID"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(303, 66)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(64, 25)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "Name"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(19, 133)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(69, 25)
        Me.GunaLabel4.TabIndex = 0
        Me.GunaLabel4.Text = "Phone"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(303, 202)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(97, 25)
        Me.GunaLabel5.TabIndex = 0
        Me.GunaLabel5.Text = "Password"
        '
        'txt_UserID
        '
        Me.txt_UserID.BaseColor = System.Drawing.Color.White
        Me.txt_UserID.BorderColor = System.Drawing.Color.Silver
        Me.txt_UserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_UserID.Enabled = False
        Me.txt_UserID.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_UserID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_UserID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_UserID.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UserID.Location = New System.Drawing.Point(19, 94)
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_UserID.SelectedText = ""
        Me.txt_UserID.Size = New System.Drawing.Size(278, 35)
        Me.txt_UserID.TabIndex = 7
        Me.txt_UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Name
        '
        Me.txt_Name.BaseColor = System.Drawing.Color.White
        Me.txt_Name.BorderColor = System.Drawing.Color.Silver
        Me.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Name.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Name.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Name.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Name.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(303, 94)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Name.SelectedText = ""
        Me.txt_Name.Size = New System.Drawing.Size(278, 34)
        Me.txt_Name.TabIndex = 0
        Me.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Phone
        '
        Me.txt_Phone.BaseColor = System.Drawing.Color.White
        Me.txt_Phone.BorderColor = System.Drawing.Color.Silver
        Me.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Phone.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Phone.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Phone.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Phone.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Phone.Location = New System.Drawing.Point(19, 161)
        Me.txt_Phone.MaxLength = 10
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Phone.SelectedText = ""
        Me.txt_Phone.Size = New System.Drawing.Size(278, 36)
        Me.txt_Phone.TabIndex = 1
        Me.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Password
        '
        Me.txt_Password.BaseColor = System.Drawing.Color.White
        Me.txt_Password.BorderColor = System.Drawing.Color.Silver
        Me.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Password.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Password.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Password.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Password.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(303, 230)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.SelectedText = ""
        Me.txt_Password.Size = New System.Drawing.Size(278, 32)
        Me.txt_Password.TabIndex = 4
        Me.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Add
        '
        Me.btn_Add.AllowToggling = False
        Me.btn_Add.AnimationSpeed = 200
        Me.btn_Add.AutoGenerateColors = False
        Me.btn_Add.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_Add.BackgroundImage = CType(resources.GetObject("btn_Add.BackgroundImage"), System.Drawing.Image)
        Me.btn_Add.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_Add.ButtonText = "Add"
        Me.btn_Add.ButtonTextMarginLeft = 0
        Me.btn_Add.ColorContrastOnClick = 45
        Me.btn_Add.ColorContrastOnHover = 45
        Me.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_Add.CustomizableEdges = BorderEdges1
        Me.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Add.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btn_Add.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Add.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_Add.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_Add.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.btn_Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Add.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add.IconMarginLeft = 11
        Me.btn_Add.IconPadding = 10
        Me.btn_Add.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_Add.IdleBorderRadius = 20
        Me.btn_Add.IdleBorderThickness = 2
        Me.btn_Add.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btn_Add.IdleIconLeftImage = Nothing
        Me.btn_Add.IdleIconRightImage = Nothing
        Me.btn_Add.IndicateFocus = False
        Me.btn_Add.Location = New System.Drawing.Point(19, 284)
        Me.btn_Add.Name = "btn_Add"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.BorderRadius = 20
        StateProperties1.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 2
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btn_Add.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 20
        StateProperties2.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 2
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btn_Add.OnPressedState = StateProperties2
        Me.btn_Add.Size = New System.Drawing.Size(278, 61)
        Me.btn_Add.TabIndex = 5
        Me.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Add.TextMarginLeft = 0
        Me.btn_Add.UseDefaultRadiusAndThickness = True
        '
        'btn_Clear
        '
        Me.btn_Clear.AllowToggling = False
        Me.btn_Clear.AnimationSpeed = 200
        Me.btn_Clear.AutoGenerateColors = False
        Me.btn_Clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_Clear.BackColor1 = System.Drawing.Color.PapayaWhip
        Me.btn_Clear.BackgroundImage = CType(resources.GetObject("btn_Clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_Clear.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_Clear.ButtonText = "Clear"
        Me.btn_Clear.ButtonTextMarginLeft = 0
        Me.btn_Clear.ColorContrastOnClick = 45
        Me.btn_Clear.ColorContrastOnHover = 45
        Me.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btn_Clear.CustomizableEdges = BorderEdges2
        Me.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Clear.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btn_Clear.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Clear.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_Clear.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_Clear.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.btn_Clear.ForeColor = System.Drawing.Color.Black
        Me.btn_Clear.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Clear.IconMarginLeft = 11
        Me.btn_Clear.IconPadding = 10
        Me.btn_Clear.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Clear.IdleBorderColor = System.Drawing.Color.Black
        Me.btn_Clear.IdleBorderRadius = 20
        Me.btn_Clear.IdleBorderThickness = 2
        Me.btn_Clear.IdleFillColor = System.Drawing.Color.PapayaWhip
        Me.btn_Clear.IdleIconLeftImage = Nothing
        Me.btn_Clear.IdleIconRightImage = Nothing
        Me.btn_Clear.IndicateFocus = False
        Me.btn_Clear.Location = New System.Drawing.Point(303, 284)
        Me.btn_Clear.Name = "btn_Clear"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.BorderRadius = 20
        StateProperties3.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 2
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.btn_Clear.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 20
        StateProperties4.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 2
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btn_Clear.OnPressedState = StateProperties4
        Me.btn_Clear.Size = New System.Drawing.Size(278, 61)
        Me.btn_Clear.TabIndex = 6
        Me.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Clear.TextMarginLeft = 0
        Me.btn_Clear.UseDefaultRadiusAndThickness = True
        '
        'cmd_position
        '
        Me.cmd_position.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_position.FormattingEnabled = True
        Me.cmd_position.Items.AddRange(New Object() {"", "Admin", "Sale"})
        Me.cmd_position.Location = New System.Drawing.Point(19, 230)
        Me.cmd_position.Name = "cmd_position"
        Me.cmd_position.Size = New System.Drawing.Size(278, 33)
        Me.cmd_position.TabIndex = 3
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(19, 202)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(84, 25)
        Me.GunaLabel6.TabIndex = 0
        Me.GunaLabel6.Text = "Position"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(303, 133)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(83, 25)
        Me.GunaLabel7.TabIndex = 0
        Me.GunaLabel7.Text = "Address"
        '
        'txt_Address
        '
        Me.txt_Address.BaseColor = System.Drawing.Color.White
        Me.txt_Address.BorderColor = System.Drawing.Color.Silver
        Me.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Address.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_Address.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Address.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Address.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(303, 161)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Address.SelectedText = ""
        Me.txt_Address.Size = New System.Drawing.Size(278, 35)
        Me.txt_Address.TabIndex = 2
        Me.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_close
        '
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(573, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 29)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 38
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(13, 368)
        Me.Panel1.TabIndex = 42
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(670, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(13, 472)
        Me.Panel7.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(13, 358)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(576, 10)
        Me.Panel6.TabIndex = 44
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(670, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(13, 472)
        Me.Panel5.TabIndex = 34
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(13, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(576, 15)
        Me.Panel4.TabIndex = 45
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(670, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 472)
        Me.Panel3.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(589, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 368)
        Me.Panel2.TabIndex = 43
        '
        'frmAddSeler
        '
        Me.AcceptButton = Me.btn_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 368)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.cmd_position)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.txt_UserID)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddSeler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddSeler"
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_UserID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_Name As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_Phone As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_Password As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_Add As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btn_Clear As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents cmd_position As ComboBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_Address As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
