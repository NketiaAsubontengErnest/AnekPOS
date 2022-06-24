<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCreateD = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VERSION: 1.0.1"
        Me.Label1.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'lblCreateD
        '
        Me.lblCreateD.AutoSize = True
        Me.lblCreateD.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateD.ForeColor = System.Drawing.Color.Red
        Me.lblCreateD.Location = New System.Drawing.Point(429, 9)
        Me.lblCreateD.Name = "lblCreateD"
        Me.lblCreateD.Size = New System.Drawing.Size(53, 19)
        Me.lblCreateD.TabIndex = 2
        Me.lblCreateD.Text = "Label2"
        Me.lblCreateD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCreateD.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.FillThickness = 10
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Gold
        Me.ProgressBar1.Location = New System.Drawing.Point(627, 327)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.ProgressThickness = 10
        Me.ProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProgressBar1.ShadowDecoration.Parent = Me.ProgressBar1
        Me.ProgressBar1.ShowPercentage = True
        Me.ProgressBar1.Size = New System.Drawing.Size(68, 69)
        Me.ProgressBar1.TabIndex = 3
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.point_of_sale.My.Resources.Resources.Logo_mockup_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(712, 410)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblCreateD)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "splash"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblCreateD As Label
    Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class
