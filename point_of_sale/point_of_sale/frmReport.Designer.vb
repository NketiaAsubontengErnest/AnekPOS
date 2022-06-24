<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.cmbEmployeeID = New System.Windows.Forms.ComboBox()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalSales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_closed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbDate = New System.Windows.Forms.ComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblReport = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(711, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 29)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 38
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'cmbEmployeeID
        '
        Me.cmbEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cmbEmployeeID.FormattingEnabled = True
        Me.cmbEmployeeID.Location = New System.Drawing.Point(19, 73)
        Me.cmbEmployeeID.Name = "cmbEmployeeID"
        Me.cmbEmployeeID.Size = New System.Drawing.Size(326, 33)
        Me.cmbEmployeeID.TabIndex = 0
        '
        'cmbName
        '
        Me.cmbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(19, 145)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(326, 33)
        Me.cmbName.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 39)
        Me.Label7.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 39)
        Me.Label2.TabIndex = 43
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(17, 40)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(123, 25)
        Me.GunaLabel2.TabIndex = 44
        Me.GunaLabel2.Text = "Employee ID"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(19, 111)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(64, 25)
        Me.GunaLabel3.TabIndex = 45
        Me.GunaLabel3.Text = "Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.employeeID, Me.totalSales, Me.dat, Me.Date_closed})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(716, 390)
        Me.DataGridView1.TabIndex = 46
        '
        'id
        '
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "No"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'employeeID
        '
        Me.employeeID.DataPropertyName = "employeeID"
        Me.employeeID.HeaderText = "Employee ID"
        Me.employeeID.Name = "employeeID"
        Me.employeeID.ReadOnly = True
        '
        'totalSales
        '
        Me.totalSales.DataPropertyName = "totalSales"
        Me.totalSales.HeaderText = "Total Sales"
        Me.totalSales.Name = "totalSales"
        Me.totalSales.ReadOnly = True
        '
        'dat
        '
        Me.dat.DataPropertyName = "date"
        Me.dat.HeaderText = "Date"
        Me.dat.Name = "dat"
        Me.dat.ReadOnly = True
        '
        'Date_closed
        '
        Me.Date_closed.DataPropertyName = "datePrepared"
        Me.Date_closed.HeaderText = "Date Closed"
        Me.Date_closed.Name = "Date_closed"
        Me.Date_closed.ReadOnly = True
        '
        'cmbDate
        '
        Me.cmbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cmbDate.FormattingEnabled = True
        Me.cmbDate.Location = New System.Drawing.Point(360, 145)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(326, 33)
        Me.cmbDate.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(360, 111)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(53, 25)
        Me.GunaLabel1.TabIndex = 45
        Me.GunaLabel1.Text = "Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.point_of_sale.My.Resources.Resources.reload
        Me.PictureBox1.Location = New System.Drawing.Point(692, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblReport.Location = New System.Drawing.Point(418, 105)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(0, 37)
        Me.lblReport.TabIndex = 44
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(434, 56)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(125, 25)
        Me.GunaLabel5.TabIndex = 44
        Me.GunaLabel5.Text = "Report Date:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(13, 581)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(713, 10)
        Me.Panel6.TabIndex = 50
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel4.Controls.Add(Me.GunaLabel4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(13, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(713, 32)
        Me.Panel4.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(726, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 591)
        Me.Panel2.TabIndex = 49
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
        Me.Panel1.Size = New System.Drawing.Size(13, 591)
        Me.Panel1.TabIndex = 48
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Gold
        Me.GunaLabel4.Location = New System.Drawing.Point(272, 3)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(148, 25)
        Me.GunaLabel4.TabIndex = 52
        Me.GunaLabel4.Text = "General Report"
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 591)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbDate)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.cmbEmployeeID)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReport"
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cmbEmployeeID As ComboBox
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbDate As ComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents closedA As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblReport As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents employeeID As DataGridViewTextBoxColumn
    Friend WithEvents totalSales As DataGridViewTextBoxColumn
    Friend WithEvents dat As DataGridViewTextBoxColumn
    Friend WithEvents Date_closed As DataGridViewTextBoxColumn
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
End Class
