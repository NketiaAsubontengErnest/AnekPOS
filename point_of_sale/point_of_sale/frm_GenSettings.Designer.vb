<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GenSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GenSettings))
        Dim BorderEdges1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.Winforms.BunifuButton.BunifuButton.StateProperties()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ResetAll = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnResetProType = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnChaPass = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.btnBack_up = New Bunifu.UI.Winforms.BunifuButton.BunifuButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(13, 36)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(787, 498)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(779, 466)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(779, 466)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(779, 466)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnChaPass)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(779, 466)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Change Password"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnBack_up)
        Me.TabPage5.Location = New System.Drawing.Point(4, 28)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Size = New System.Drawing.Size(779, 466)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Back Up"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Controls.Add(Me.Label4)
        Me.TabPage6.Controls.Add(Me.Label3)
        Me.TabPage6.Controls.Add(Me.Label1)
        Me.TabPage6.Controls.Add(Me.btn_ResetAll)
        Me.TabPage6.Controls.Add(Me.Button4)
        Me.TabPage6.Controls.Add(Me.btnResetProType)
        Me.TabPage6.Controls.Add(Me.Button2)
        Me.TabPage6.Controls.Add(Me.Button1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 28)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Size = New System.Drawing.Size(779, 466)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Reset System"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(233, 393)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "This is to clear the entire system." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(233, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 38)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "This is to clear all the sales that have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "been entered in to the system." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(233, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(327, 38)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "This is to clear all the product types that have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "been entered in to the system." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(233, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 38)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "This is to clear all the sales that have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "been made or entered in to the system." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(233, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This is to clear all the product that have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "been entered in to the system."
        '
        'btn_ResetAll
        '
        Me.btn_ResetAll.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_ResetAll.ForeColor = System.Drawing.Color.Black
        Me.btn_ResetAll.Location = New System.Drawing.Point(28, 393)
        Me.btn_ResetAll.Name = "btn_ResetAll"
        Me.btn_ResetAll.Size = New System.Drawing.Size(172, 50)
        Me.btn_ResetAll.TabIndex = 0
        Me.btn_ResetAll.Text = "Reset System"
        Me.btn_ResetAll.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Goldenrod
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(28, 309)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 50)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Reset Sales"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnResetProType
        '
        Me.btnResetProType.BackColor = System.Drawing.Color.Goldenrod
        Me.btnResetProType.ForeColor = System.Drawing.Color.Black
        Me.btnResetProType.Location = New System.Drawing.Point(28, 223)
        Me.btnResetProType.Name = "btnResetProType"
        Me.btnResetProType.Size = New System.Drawing.Size(172, 50)
        Me.btnResetProType.TabIndex = 0
        Me.btnResetProType.Text = "Reset Product Type"
        Me.btnResetProType.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Goldenrod
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(28, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 50)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Reset Daily Sales"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(28, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Reset Product"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.point_of_sale.My.Resources.Resources.close
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(778, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 30)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnChaPass
        '
        Me.btnChaPass.AllowToggling = False
        Me.btnChaPass.AnimationSpeed = 200
        Me.btnChaPass.AutoGenerateColors = False
        Me.btnChaPass.BackColor = System.Drawing.Color.Transparent
        Me.btnChaPass.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnChaPass.BackgroundImage = CType(resources.GetObject("btnChaPass.BackgroundImage"), System.Drawing.Image)
        Me.btnChaPass.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnChaPass.ButtonText = "Change Password"
        Me.btnChaPass.ButtonTextMarginLeft = 0
        Me.btnChaPass.ColorContrastOnClick = 45
        Me.btnChaPass.ColorContrastOnHover = 45
        Me.btnChaPass.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnChaPass.CustomizableEdges = BorderEdges1
        Me.btnChaPass.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChaPass.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnChaPass.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnChaPass.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnChaPass.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnChaPass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnChaPass.ForeColor = System.Drawing.Color.White
        Me.btnChaPass.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnChaPass.IconMarginLeft = 11
        Me.btnChaPass.IconPadding = 10
        Me.btnChaPass.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnChaPass.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnChaPass.IdleBorderRadius = 3
        Me.btnChaPass.IdleBorderThickness = 1
        Me.btnChaPass.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnChaPass.IdleIconLeftImage = Nothing
        Me.btnChaPass.IdleIconRightImage = Nothing
        Me.btnChaPass.IndicateFocus = False
        Me.btnChaPass.Location = New System.Drawing.Point(294, 162)
        Me.btnChaPass.Name = "btnChaPass"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.BorderRadius = 3
        StateProperties1.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnChaPass.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 3
        StateProperties2.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnChaPass.OnPressedState = StateProperties2
        Me.btnChaPass.Size = New System.Drawing.Size(210, 45)
        Me.btnChaPass.TabIndex = 0
        Me.btnChaPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChaPass.TextMarginLeft = 0
        Me.btnChaPass.UseDefaultRadiusAndThickness = True
        '
        'btnBack_up
        '
        Me.btnBack_up.AllowToggling = False
        Me.btnBack_up.AnimationSpeed = 200
        Me.btnBack_up.AutoGenerateColors = False
        Me.btnBack_up.BackColor = System.Drawing.Color.Transparent
        Me.btnBack_up.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnBack_up.BackgroundImage = CType(resources.GetObject("btnBack_up.BackgroundImage"), System.Drawing.Image)
        Me.btnBack_up.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBack_up.ButtonText = "Back Up"
        Me.btnBack_up.ButtonTextMarginLeft = 0
        Me.btnBack_up.ColorContrastOnClick = 45
        Me.btnBack_up.ColorContrastOnHover = 45
        Me.btnBack_up.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnBack_up.CustomizableEdges = BorderEdges2
        Me.btnBack_up.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBack_up.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnBack_up.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBack_up.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBack_up.FocusState = Bunifu.UI.Winforms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnBack_up.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnBack_up.ForeColor = System.Drawing.Color.White
        Me.btnBack_up.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack_up.IconMarginLeft = 11
        Me.btnBack_up.IconPadding = 10
        Me.btnBack_up.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack_up.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnBack_up.IdleBorderRadius = 20
        Me.btnBack_up.IdleBorderThickness = 1
        Me.btnBack_up.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnBack_up.IdleIconLeftImage = Nothing
        Me.btnBack_up.IdleIconRightImage = Nothing
        Me.btnBack_up.IndicateFocus = False
        Me.btnBack_up.Location = New System.Drawing.Point(268, 151)
        Me.btnBack_up.Name = "btnBack_up"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.BorderRadius = 20
        StateProperties3.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.btnBack_up.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 20
        StateProperties4.BorderStyle = Bunifu.UI.Winforms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btnBack_up.OnPressedState = StateProperties4
        Me.btnBack_up.Size = New System.Drawing.Size(210, 45)
        Me.btnBack_up.TabIndex = 0
        Me.btnBack_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBack_up.TextMarginLeft = 0
        Me.btnBack_up.UseDefaultRadiusAndThickness = True
        '
        'frm_GenSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 547)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_GenSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_GenSettings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btn_ResetAll As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnResetProType As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack_up As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnChaPass As Bunifu.UI.Winforms.BunifuButton.BunifuButton
End Class
