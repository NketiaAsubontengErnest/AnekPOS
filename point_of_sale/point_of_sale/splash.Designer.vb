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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCreateD = New System.Windows.Forms.Label()
        Me.lblPersent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(2, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VERSION: 1.0.1"
        Me.Label1.UseWaitCursor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-1, 261)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(468, 10)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'lblCreateD
        '
        Me.lblCreateD.AutoSize = True
        Me.lblCreateD.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateD.ForeColor = System.Drawing.Color.Red
        Me.lblCreateD.Location = New System.Drawing.Point(151, 193)
        Me.lblCreateD.Name = "lblCreateD"
        Me.lblCreateD.Size = New System.Drawing.Size(53, 19)
        Me.lblCreateD.TabIndex = 2
        Me.lblCreateD.Text = "Label2"
        Me.lblCreateD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCreateD.Visible = False
        '
        'lblPersent
        '
        Me.lblPersent.AutoSize = True
        Me.lblPersent.BackColor = System.Drawing.Color.Transparent
        Me.lblPersent.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersent.ForeColor = System.Drawing.Color.Blue
        Me.lblPersent.Location = New System.Drawing.Point(397, 232)
        Me.lblPersent.Name = "lblPersent"
        Me.lblPersent.Size = New System.Drawing.Size(69, 26)
        Me.lblPersent.TabIndex = 2
        Me.lblPersent.Text = "Label2"
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.point_of_sale.My.Resources.Resources.Logo_mockup_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(468, 265)
        Me.Controls.Add(Me.lblPersent)
        Me.Controls.Add(Me.lblCreateD)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblCreateD As Label
    Friend WithEvents lblPersent As Label
End Class
