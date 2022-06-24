<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Addtype
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
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_Add = New Guna.UI.WinForms.GunaButton()
        Me.txt_CatName = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_CatID = New Guna.UI.WinForms.GunaTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(149, 146)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(151, 25)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "Category Name"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Gold
        Me.GunaLabel3.Location = New System.Drawing.Point(30, 1)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(355, 37)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "ADD PRODUCT CATEGORY"
        '
        'btn_Add
        '
        Me.btn_Add.AnimationHoverSpeed = 0.07!
        Me.btn_Add.AnimationSpeed = 0.03!
        Me.btn_Add.BackColor = System.Drawing.Color.Transparent
        Me.btn_Add.BaseColor = System.Drawing.Color.Yellow
        Me.btn_Add.BorderColor = System.Drawing.Color.Black
        Me.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Add.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Add.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.Black
        Me.btn_Add.Image = Nothing
        Me.btn_Add.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Add.Location = New System.Drawing.Point(35, 240)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Add.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Add.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Add.OnHoverImage = Nothing
        Me.btn_Add.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Add.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_Add.Radius = 20
        Me.btn_Add.Size = New System.Drawing.Size(360, 61)
        Me.btn_Add.TabIndex = 1
        Me.btn_Add.Text = "ADD"
        Me.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_CatName
        '
        Me.txt_CatName.BaseColor = System.Drawing.Color.White
        Me.txt_CatName.BorderColor = System.Drawing.Color.Silver
        Me.txt_CatName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CatName.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_CatName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_CatName.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_CatName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CatName.Location = New System.Drawing.Point(35, 174)
        Me.txt_CatName.Name = "txt_CatName"
        Me.txt_CatName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CatName.SelectedText = ""
        Me.txt_CatName.Size = New System.Drawing.Size(360, 49)
        Me.txt_CatName.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(140, 64)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(173, 25)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Category Number"
        '
        'txt_CatID
        '
        Me.txt_CatID.BaseColor = System.Drawing.Color.White
        Me.txt_CatID.BorderColor = System.Drawing.Color.Silver
        Me.txt_CatID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CatID.Enabled = False
        Me.txt_CatID.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_CatID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_CatID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_CatID.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CatID.Location = New System.Drawing.Point(35, 95)
        Me.txt_CatID.Name = "txt_CatID"
        Me.txt_CatID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CatID.SelectedText = ""
        Me.txt_CatID.Size = New System.Drawing.Size(360, 42)
        Me.txt_CatID.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 45)
        Me.Label7.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 45)
        Me.Label2.TabIndex = 44
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 306)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(432, 10)
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
        Me.Panel4.Controls.Add(Me.GunaLabel3)
        Me.Panel4.Controls.Add(Me.btn_Close)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(432, 40)
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
        'btn_Close
        '
        Me.btn_Close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_Close.ImageActive = Nothing
        Me.btn_Close.Location = New System.Drawing.Point(395, 2)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(35, 30)
        Me.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Close.TabIndex = 50
        Me.btn_Close.TabStop = False
        Me.btn_Close.Zoom = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(422, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 266)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 266)
        Me.Panel1.TabIndex = 46
        '
        'Frm_Addtype
        '
        Me.AcceptButton = Me.btn_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 316)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_CatName)
        Me.Controls.Add(Me.txt_CatID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Addtype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Addtype"
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_Add As Guna.UI.WinForms.GunaButton
    Friend WithEvents txt_CatName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_CatID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Close As Bunifu.Framework.UI.BunifuImageButton
End Class
