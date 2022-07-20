<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductAnalysis
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
        Me.FloproductPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ComboItems = New System.Windows.Forms.ComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.CmbYear = New System.Windows.Forms.ComboBox()
        Me.CmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FloproductPanel
        '
        Me.FloproductPanel.AutoScroll = True
        Me.FloproductPanel.BackColor = System.Drawing.Color.White
        Me.FloproductPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FloproductPanel.Location = New System.Drawing.Point(11, 92)
        Me.FloproductPanel.Name = "FloproductPanel"
        Me.FloproductPanel.Size = New System.Drawing.Size(984, 579)
        Me.FloproductPanel.TabIndex = 0
        '
        'ComboItems
        '
        Me.ComboItems.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboItems.FormattingEnabled = True
        Me.ComboItems.Location = New System.Drawing.Point(149, 48)
        Me.ComboItems.Name = "ComboItems"
        Me.ComboItems.Size = New System.Drawing.Size(339, 31)
        Me.ComboItems.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Gold
        Me.GunaLabel1.Location = New System.Drawing.Point(359, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(259, 32)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "PRODUCT STATISTICS"
        '
        'btn_close
        '
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(974, 7)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 29)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 22
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'CmbYear
        '
        Me.CmbYear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbYear.FormattingEnabled = True
        Me.CmbYear.Location = New System.Drawing.Point(828, 48)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(136, 31)
        Me.CmbYear.TabIndex = 1
        '
        'CmbMonth
        '
        Me.CmbMonth.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMonth.FormattingEnabled = True
        Me.CmbMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.CmbMonth.Location = New System.Drawing.Point(639, 48)
        Me.CmbMonth.Name = "CmbMonth"
        Me.CmbMonth.Size = New System.Drawing.Size(86, 31)
        Me.CmbMonth.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 26)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(778, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 26)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(563, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 26)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Month"
        '
        'FrmProductAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1012, 679)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.CmbMonth)
        Me.Controls.Add(Me.CmbYear)
        Me.Controls.Add(Me.ComboItems)
        Me.Controls.Add(Me.FloproductPanel)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProductAnalysis"
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FloproductPanel As FlowLayoutPanel
    Friend WithEvents ComboItems As ComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents CmbYear As ComboBox
    Friend WithEvents CmbMonth As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
