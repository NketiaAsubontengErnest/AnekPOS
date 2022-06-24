<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Profit
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
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblCost = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblProfit = New Bunifu.UI.WinForms.BunifuLabel()
        Me.cmbDate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbMonth = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblGenAmount = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(19, 460)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(57, 28)
        Me.BunifuLabel3.TabIndex = 3
        Me.BunifuLabel3.Text = "Profit:"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.ForeColor = System.Drawing.Color.Gold
        Me.BunifuLabel4.Location = New System.Drawing.Point(463, 1)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(143, 38)
        Me.BunifuLabel4.TabIndex = 4
        Me.BunifuLabel4.Text = "Profit Table"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblCost
        '
        Me.lblCost.AutoEllipsis = False
        Me.lblCost.CursorType = Nothing
        Me.lblCost.Font = New System.Drawing.Font("Calibri", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(19, 300)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCost.Size = New System.Drawing.Size(602, 133)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "General Cost:"
        Me.lblCost.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblCost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblProfit
        '
        Me.lblProfit.AutoEllipsis = False
        Me.lblProfit.CursorType = Nothing
        Me.lblProfit.Font = New System.Drawing.Font("Calibri", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfit.Location = New System.Drawing.Point(19, 493)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProfit.Size = New System.Drawing.Size(602, 133)
        Me.lblProfit.TabIndex = 7
        Me.lblProfit.Text = "General Cost:"
        Me.lblProfit.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblProfit.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'cmbDate
        '
        Me.cmbDate.BackColor = System.Drawing.Color.Transparent
        Me.cmbDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDate.FocusedColor = System.Drawing.Color.Empty
        Me.cmbDate.FocusedState.Parent = Me.cmbDate
        Me.cmbDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDate.FormattingEnabled = True
        Me.cmbDate.HoverState.Parent = Me.cmbDate
        Me.cmbDate.ItemHeight = 30
        Me.cmbDate.ItemsAppearance.Parent = Me.cmbDate
        Me.cmbDate.Location = New System.Drawing.Point(321, 58)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.ShadowDecoration.Parent = Me.cmbDate
        Me.cmbDate.Size = New System.Drawing.Size(228, 36)
        Me.cmbDate.TabIndex = 8
        '
        'cmbMonth
        '
        Me.cmbMonth.BackColor = System.Drawing.Color.Transparent
        Me.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMonth.FocusedState.Parent = Me.cmbMonth
        Me.cmbMonth.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.HoverState.Parent = Me.cmbMonth
        Me.cmbMonth.ItemHeight = 30
        Me.cmbMonth.Items.AddRange(New Object() {"", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMonth.ItemsAppearance.Parent = Me.cmbMonth
        Me.cmbMonth.Location = New System.Drawing.Point(662, 58)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.ShadowDecoration.Parent = Me.cmbMonth
        Me.cmbMonth.Size = New System.Drawing.Size(87, 36)
        Me.cmbMonth.TabIndex = 9
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(19, 266)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(119, 28)
        Me.BunifuLabel1.TabIndex = 1
        Me.BunifuLabel1.Text = "General Cost:"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(265, 58)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(50, 28)
        Me.BunifuLabel2.TabIndex = 10
        Me.BunifuLabel2.Text = "Date:"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.Location = New System.Drawing.Point(589, 60)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(67, 28)
        Me.BunifuLabel5.TabIndex = 11
        Me.BunifuLabel5.Text = "Month:"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(13, 652)
        Me.Panel1.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1052, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 652)
        Me.Panel2.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(670, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 472)
        Me.Panel3.TabIndex = 34
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BunifuLabel4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(13, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1039, 42)
        Me.Panel4.TabIndex = 35
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(13, 642)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1039, 10)
        Me.Panel6.TabIndex = 35
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel6.Location = New System.Drawing.Point(19, 93)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(152, 28)
        Me.BunifuLabel6.TabIndex = 1
        Me.BunifuLabel6.Text = "General Amount:"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblGenAmount
        '
        Me.lblGenAmount.AutoEllipsis = False
        Me.lblGenAmount.CursorType = Nothing
        Me.lblGenAmount.Font = New System.Drawing.Font("Calibri", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenAmount.Location = New System.Drawing.Point(19, 127)
        Me.lblGenAmount.Name = "lblGenAmount"
        Me.lblGenAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGenAmount.Size = New System.Drawing.Size(602, 133)
        Me.lblGenAmount.TabIndex = 5
        Me.lblGenAmount.Text = "General Cost:"
        Me.lblGenAmount.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblGenAmount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btn_close
        '
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(1038, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 29)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 31
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'Frm_Profit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 652)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuLabel5)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbDate)
        Me.Controls.Add(Me.lblProfit)
        Me.Controls.Add(Me.lblGenAmount)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.BunifuLabel6)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Profit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Profit"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuLabel3 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents lblCost As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents lblProfit As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents cmbDate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbMonth As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.Winforms.BunifuLabel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblGenAmount As Bunifu.UI.Winforms.BunifuLabel
End Class
