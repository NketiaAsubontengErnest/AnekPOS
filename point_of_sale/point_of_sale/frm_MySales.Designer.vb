﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_MySales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_EmpName = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_EmpID = New Guna.UI.WinForms.GunaLabel()
        Me.data_MySales = New Bunifu.UI.Winforms.BunifuDataGridView()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.chk_show_Hide = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.lblDailySales = New Guna.UI.WinForms.GunaLabel()
        Me.cmbDate = New System.Windows.Forms.ComboBox()
        Me.cmbEmpID = New System.Windows.Forms.ComboBox()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.data_MySales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(22, 130)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(53, 25)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Date"
        '
        'lbl_EmpName
        '
        Me.lbl_EmpName.AutoSize = True
        Me.lbl_EmpName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmpName.Location = New System.Drawing.Point(283, 68)
        Me.lbl_EmpName.Name = "lbl_EmpName"
        Me.lbl_EmpName.Size = New System.Drawing.Size(64, 25)
        Me.lbl_EmpName.TabIndex = 0
        Me.lbl_EmpName.Text = "Name"
        '
        'lbl_EmpID
        '
        Me.lbl_EmpID.AutoSize = True
        Me.lbl_EmpID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmpID.Location = New System.Drawing.Point(13, 66)
        Me.lbl_EmpID.Name = "lbl_EmpID"
        Me.lbl_EmpID.Size = New System.Drawing.Size(123, 25)
        Me.lbl_EmpID.TabIndex = 0
        Me.lbl_EmpID.Text = "Employee ID"
        '
        'data_MySales
        '
        Me.data_MySales.AllowCustomTheming = False
        Me.data_MySales.AllowDrop = True
        Me.data_MySales.AllowUserToAddRows = False
        Me.data_MySales.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.data_MySales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data_MySales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_MySales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_MySales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_MySales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data_MySales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_MySales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.data_MySales.ColumnHeadersHeight = 40
        Me.data_MySales.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_MySales.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.data_MySales.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.data_MySales.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_MySales.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.data_MySales.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.data_MySales.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_MySales.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.data_MySales.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.data_MySales.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.data_MySales.CurrentTheme.Name = Nothing
        Me.data_MySales.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.data_MySales.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.data_MySales.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.data_MySales.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_MySales.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_MySales.DefaultCellStyle = DataGridViewCellStyle3
        Me.data_MySales.EnableHeadersVisualStyles = False
        Me.data_MySales.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_MySales.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.data_MySales.HeaderBgColor = System.Drawing.Color.Empty
        Me.data_MySales.HeaderForeColor = System.Drawing.Color.White
        Me.data_MySales.Location = New System.Drawing.Point(13, 209)
        Me.data_MySales.Name = "data_MySales"
        Me.data_MySales.ReadOnly = True
        Me.data_MySales.RowHeadersVisible = False
        Me.data_MySales.RowTemplate.Height = 40
        Me.data_MySales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_MySales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_MySales.Size = New System.Drawing.Size(794, 301)
        Me.data_MySales.TabIndex = 2
        Me.data_MySales.Theme = Bunifu.UI.Winforms.BunifuDataGridView.PresetThemes.Light
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.chk_show_Hide)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_close)
        Me.GunaShadowPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaShadowPanel1.Controls.Add(Me.Panel1)
        Me.GunaShadowPanel1.Controls.Add(Me.cmbDate)
        Me.GunaShadowPanel1.Controls.Add(Me.cmbEmpID)
        Me.GunaShadowPanel1.Controls.Add(Me.cmbName)
        Me.GunaShadowPanel1.Controls.Add(Me.lbl_EmpName)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaShadowPanel1.Controls.Add(Me.lbl_EmpID)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(822, 514)
        Me.GunaShadowPanel1.TabIndex = 3
        '
        'chk_show_Hide
        '
        Me.chk_show_Hide.AutoSize = True
        Me.chk_show_Hide.Location = New System.Drawing.Point(18, 19)
        Me.chk_show_Hide.Name = "chk_show_Hide"
        Me.chk_show_Hide.Size = New System.Drawing.Size(15, 14)
        Me.chk_show_Hide.TabIndex = 7
        Me.chk_show_Hide.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.lblDailySales)
        Me.Panel1.Location = New System.Drawing.Point(575, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 94)
        Me.Panel1.TabIndex = 4
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(11, 1)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(131, 25)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "DAILY SALES:"
        '
        'lblDailySales
        '
        Me.lblDailySales.AutoSize = True
        Me.lblDailySales.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblDailySales.ForeColor = System.Drawing.Color.Black
        Me.lblDailySales.Location = New System.Drawing.Point(9, 20)
        Me.lblDailySales.Name = "lblDailySales"
        Me.lblDailySales.Size = New System.Drawing.Size(0, 46)
        Me.lblDailySales.TabIndex = 0
        '
        'cmbDate
        '
        Me.cmbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cmbDate.FormattingEnabled = True
        Me.cmbDate.Location = New System.Drawing.Point(18, 158)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(263, 33)
        Me.cmbDate.TabIndex = 2
        '
        'cmbEmpID
        '
        Me.cmbEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmbEmpID.FormattingEnabled = True
        Me.cmbEmpID.Location = New System.Drawing.Point(18, 94)
        Me.cmbEmpID.Name = "cmbEmpID"
        Me.cmbEmpID.Size = New System.Drawing.Size(263, 32)
        Me.cmbEmpID.TabIndex = 0
        '
        'cmbName
        '
        Me.cmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(288, 94)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(238, 32)
        Me.cmbName.TabIndex = 1
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Goldenrod
        Me.GunaLabel2.Location = New System.Drawing.Point(207, 9)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(381, 65)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "SALES HISTORY"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(13, 504)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(796, 10)
        Me.Panel6.TabIndex = 38
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(13, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(796, 15)
        Me.Panel4.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(809, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 514)
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
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(13, 514)
        Me.Panel8.TabIndex = 36
        '
        'btn_close
        '
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(780, 16)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 29)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 6
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.point_of_sale.My.Resources.Resources.reload
        Me.PictureBox1.Location = New System.Drawing.Point(288, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frm_MySales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 514)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.data_MySales)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_MySales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_MySales"
        CType(Me.data_MySales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_EmpName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_EmpID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents data_MySales As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents cmbDate As ComboBox
    Friend WithEvents cmbEmpID As ComboBox
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents lblDailySales As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents chk_show_Hide As CheckBox
End Class