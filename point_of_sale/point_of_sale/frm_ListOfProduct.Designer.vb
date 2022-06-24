<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListOfProduct
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ListOfProduct))
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.dgv_Peoduct = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmb_ProductName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblPid = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkHide = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuButton3 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        CType(Me.dgv_Peoduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Peoduct
        '
        Me.dgv_Peoduct.AllowUserToAddRows = False
        Me.dgv_Peoduct.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgv_Peoduct.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Peoduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Peoduct.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Peoduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Peoduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Peoduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Peoduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Peoduct.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Peoduct.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Peoduct.EnableHeadersVisualStyles = False
        Me.dgv_Peoduct.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Peoduct.Location = New System.Drawing.Point(15, 80)
        Me.dgv_Peoduct.Name = "dgv_Peoduct"
        Me.dgv_Peoduct.ReadOnly = True
        Me.dgv_Peoduct.RowHeadersVisible = False
        Me.dgv_Peoduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Peoduct.Size = New System.Drawing.Size(1052, 553)
        Me.dgv_Peoduct.TabIndex = 1
        Me.dgv_Peoduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv_Peoduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Peoduct.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_Peoduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_Peoduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_Peoduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_Peoduct.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Peoduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Peoduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Peoduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Peoduct.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_Peoduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_Peoduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_Peoduct.ThemeStyle.HeaderStyle.Height = 4
        Me.dgv_Peoduct.ThemeStyle.ReadOnly = True
        Me.dgv_Peoduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_Peoduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_Peoduct.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_Peoduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_Peoduct.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_Peoduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Peoduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmb_ProductName
        '
        Me.cmb_ProductName.BackColor = System.Drawing.Color.Transparent
        Me.cmb_ProductName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ProductName.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_ProductName.FocusedState.Parent = Me.cmb_ProductName
        Me.cmb_ProductName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_ProductName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_ProductName.FormattingEnabled = True
        Me.cmb_ProductName.HoverState.Parent = Me.cmb_ProductName
        Me.cmb_ProductName.ItemHeight = 30
        Me.cmb_ProductName.ItemsAppearance.Parent = Me.cmb_ProductName
        Me.cmb_ProductName.Location = New System.Drawing.Point(117, 38)
        Me.cmb_ProductName.Name = "cmb_ProductName"
        Me.cmb_ProductName.ShadowDecoration.Parent = Me.cmb_ProductName
        Me.cmb_ProductName.Size = New System.Drawing.Size(236, 36)
        Me.cmb_ProductName.TabIndex = 0
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(45, 42)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(64, 26)
        Me.BunifuLabel1.TabIndex = 6
        Me.BunifuLabel1.Text = "Name: "
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblPid
        '
        Me.lblPid.AutoSize = True
        Me.lblPid.Location = New System.Drawing.Point(138, 145)
        Me.lblPid.Name = "lblPid"
        Me.lblPid.Size = New System.Drawing.Size(39, 13)
        Me.lblPid.TabIndex = 7
        Me.lblPid.Text = "Label1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(13, 678)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1060, 10)
        Me.Panel6.TabIndex = 38
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BunifuLabel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(13, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1060, 32)
        Me.Panel4.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1073, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 688)
        Me.Panel2.TabIndex = 37
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
        Me.Panel1.Size = New System.Drawing.Size(13, 688)
        Me.Panel1.TabIndex = 36
        '
        'chkHide
        '
        Me.chkHide.AutoSize = True
        Me.chkHide.Location = New System.Drawing.Point(16, 63)
        Me.chkHide.Name = "chkHide"
        Me.chkHide.Size = New System.Drawing.Size(15, 14)
        Me.chkHide.TabIndex = 40
        Me.chkHide.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.point_of_sale.My.Resources.Resources.close
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1055, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BunifuButton3
        '
        Me.BunifuButton3.AllowToggling = False
        Me.BunifuButton3.AnimationSpeed = 200
        Me.BunifuButton3.AutoGenerateColors = False
        Me.BunifuButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton3.BackgroundImage = CType(resources.GetObject("BunifuButton3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.ButtonText = "Delete"
        Me.BunifuButton3.ButtonTextMarginLeft = 0
        Me.BunifuButton3.ColorContrastOnClick = 45
        Me.BunifuButton3.ColorContrastOnHover = 45
        Me.BunifuButton3.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton3.CustomizableEdges = BorderEdges2
        Me.BunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton3.DisabledBorderColor = System.Drawing.Color.Empty
        Me.BunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.BunifuButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton3.IconMarginLeft = 11
        Me.BunifuButton3.IconPadding = 10
        Me.BunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton3.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton3.IdleBorderRadius = 3
        Me.BunifuButton3.IdleBorderThickness = 1
        Me.BunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton3.IdleIconLeftImage = Nothing
        Me.BunifuButton3.IdleIconRightImage = Nothing
        Me.BunifuButton3.IndicateFocus = False
        Me.BunifuButton3.Location = New System.Drawing.Point(894, 637)
        Me.BunifuButton3.Name = "BunifuButton3"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.BorderRadius = 3
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.BunifuButton3.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 3
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.BunifuButton3.OnPressedState = StateProperties4
        Me.BunifuButton3.Size = New System.Drawing.Size(161, 40)
        Me.BunifuButton3.TabIndex = 1
        Me.BunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton3.TextMarginLeft = 0
        Me.BunifuButton3.UseDefaultRadiusAndThickness = True
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.Gold
        Me.BunifuLabel2.Location = New System.Drawing.Point(442, -3)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(174, 34)
        Me.BunifuLabel2.TabIndex = 41
        Me.BunifuLabel2.Text = "List Of Product"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Frm_ListOfProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 688)
        Me.Controls.Add(Me.chkHide)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.cmb_ProductName)
        Me.Controls.Add(Me.BunifuButton3)
        Me.Controls.Add(Me.dgv_Peoduct)
        Me.Controls.Add(Me.lblPid)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ListOfProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ListOfProduct"
        CType(Me.dgv_Peoduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Peoduct As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BunifuButton3 As Bunifu.UI.Winforms.BunifuButton.BunifuButton
    Friend WithEvents Button1 As Button
    Friend WithEvents cmb_ProductName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents lblPid As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkHide As CheckBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
End Class
