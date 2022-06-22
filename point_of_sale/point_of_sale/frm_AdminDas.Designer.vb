<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AdminDas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminDas))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMakeSales = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_DailySales = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_AddProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_AddSaler = New Guna.UI2.WinForms.Guna2Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblAvelable = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCategoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyProfitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralSystemSetingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_Minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.btn_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblRole)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Panel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnMakeSales)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_DailySales)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_AddProduct)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_AddSaler)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 24)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(225, 694)
        Me.Guna2ShadowPanel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.point_of_sale.My.Resources.Resources.pos_logo
        Me.PictureBox1.Location = New System.Drawing.Point(52, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(25, 374)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(0, 13)
        Me.lblRole.TabIndex = 8
        Me.lblRole.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblUserName)
        Me.Panel1.Controls.Add(Me.lblUserID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 397)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 221)
        Me.Panel1.TabIndex = 7
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(-1, 174)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(99, 19)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Login Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-1, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Login Time"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(-1, 117)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(90, 19)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Username"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(-1, 63)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(71, 19)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-1, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-1, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER DETAILS"
        '
        'btnMakeSales
        '
        Me.btnMakeSales.CheckedState.Parent = Me.btnMakeSales
        Me.btnMakeSales.CustomImages.Parent = Me.btnMakeSales
        Me.btnMakeSales.FillColor = System.Drawing.Color.Yellow
        Me.btnMakeSales.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeSales.ForeColor = System.Drawing.Color.Black
        Me.btnMakeSales.HoverState.Parent = Me.btnMakeSales
        Me.btnMakeSales.Location = New System.Drawing.Point(12, 216)
        Me.btnMakeSales.Name = "btnMakeSales"
        Me.btnMakeSales.ShadowDecoration.Parent = Me.btnMakeSales
        Me.btnMakeSales.Size = New System.Drawing.Size(202, 45)
        Me.btnMakeSales.TabIndex = 5
        Me.btnMakeSales.Text = "Make Sales"
        '
        'btn_DailySales
        '
        Me.btn_DailySales.CheckedState.Parent = Me.btn_DailySales
        Me.btn_DailySales.CustomImages.Parent = Me.btn_DailySales
        Me.btn_DailySales.FillColor = System.Drawing.Color.Yellow
        Me.btn_DailySales.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DailySales.ForeColor = System.Drawing.Color.Black
        Me.btn_DailySales.HoverState.Parent = Me.btn_DailySales
        Me.btn_DailySales.Location = New System.Drawing.Point(12, 267)
        Me.btn_DailySales.Name = "btn_DailySales"
        Me.btn_DailySales.ShadowDecoration.Parent = Me.btn_DailySales
        Me.btn_DailySales.Size = New System.Drawing.Size(202, 45)
        Me.btn_DailySales.TabIndex = 5
        Me.btn_DailySales.Text = "Daily Sales"
        '
        'btn_AddProduct
        '
        Me.btn_AddProduct.CheckedState.Parent = Me.btn_AddProduct
        Me.btn_AddProduct.CustomImages.Parent = Me.btn_AddProduct
        Me.btn_AddProduct.FillColor = System.Drawing.Color.Yellow
        Me.btn_AddProduct.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddProduct.ForeColor = System.Drawing.Color.Black
        Me.btn_AddProduct.HoverState.Parent = Me.btn_AddProduct
        Me.btn_AddProduct.Location = New System.Drawing.Point(12, 165)
        Me.btn_AddProduct.Name = "btn_AddProduct"
        Me.btn_AddProduct.ShadowDecoration.Parent = Me.btn_AddProduct
        Me.btn_AddProduct.Size = New System.Drawing.Size(202, 45)
        Me.btn_AddProduct.TabIndex = 4
        Me.btn_AddProduct.Text = "Add Product"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(65, 666)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Logout"
        '
        'btn_AddSaler
        '
        Me.btn_AddSaler.CheckedState.Parent = Me.btn_AddSaler
        Me.btn_AddSaler.CustomImages.Parent = Me.btn_AddSaler
        Me.btn_AddSaler.FillColor = System.Drawing.Color.Yellow
        Me.btn_AddSaler.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddSaler.ForeColor = System.Drawing.Color.Black
        Me.btn_AddSaler.HoverState.Parent = Me.btn_AddSaler
        Me.btn_AddSaler.Location = New System.Drawing.Point(12, 114)
        Me.btn_AddSaler.Name = "btn_AddSaler"
        Me.btn_AddSaler.ShadowDecoration.Parent = Me.btn_AddSaler
        Me.btn_AddSaler.Size = New System.Drawing.Size(202, 45)
        Me.btn_AddSaler.TabIndex = 3
        Me.btn_AddSaler.Text = "Add Employee"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Gold
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.lblAvelable)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label5)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.HotTrack
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(225, 24)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(997, 29)
        Me.BunifuGradientPanel1.TabIndex = 1
        '
        'lblAvelable
        '
        Me.lblAvelable.AutoSize = True
        Me.lblAvelable.BackColor = System.Drawing.Color.Transparent
        Me.lblAvelable.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvelable.ForeColor = System.Drawing.Color.Red
        Me.lblAvelable.Location = New System.Drawing.Point(338, 2)
        Me.lblAvelable.Name = "lblAvelable"
        Me.lblAvelable.Size = New System.Drawing.Size(69, 26)
        Me.lblAvelable.TabIndex = 9
        Me.lblAvelable.Text = "Label8"
        Me.lblAvelable.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ADMINISTRATOR"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(518, -1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ANEK POS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1222, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnSettings
        '
        Me.mnSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.ReportToolStripMenuItem, Me.UserManagmentToolStripMenuItem, Me.SystemManagementToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.mnSettings.Name = "mnSettings"
        Me.mnSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnSettings.Text = "Settings"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCategoryToolStripMenuItem1, Me.UpdateProductToolStripMenuItem1, Me.ListOfProductToolStripMenuItem, Me.StatisticsToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'AddCategoryToolStripMenuItem1
        '
        Me.AddCategoryToolStripMenuItem1.Name = "AddCategoryToolStripMenuItem1"
        Me.AddCategoryToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.AddCategoryToolStripMenuItem1.Text = "Add Category"
        '
        'UpdateProductToolStripMenuItem1
        '
        Me.UpdateProductToolStripMenuItem1.Name = "UpdateProductToolStripMenuItem1"
        Me.UpdateProductToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.UpdateProductToolStripMenuItem1.Text = "Update Product"
        '
        'ListOfProductToolStripMenuItem
        '
        Me.ListOfProductToolStripMenuItem.Name = "ListOfProductToolStripMenuItem"
        Me.ListOfProductToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ListOfProductToolStripMenuItem.Text = "List of Product"
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.StatisticsToolStripMenuItem.Text = "Statistics"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'UserManagmentToolStripMenuItem
        '
        Me.UserManagmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserListToolStripMenuItem})
        Me.UserManagmentToolStripMenuItem.Name = "UserManagmentToolStripMenuItem"
        Me.UserManagmentToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.UserManagmentToolStripMenuItem.Text = "User Managment"
        '
        'UserListToolStripMenuItem
        '
        Me.UserListToolStripMenuItem.Name = "UserListToolStripMenuItem"
        Me.UserListToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.UserListToolStripMenuItem.Text = "User List"
        '
        'SystemManagementToolStripMenuItem
        '
        Me.SystemManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyProfitToolStripMenuItem, Me.GeneralSystemSetingsToolStripMenuItem})
        Me.SystemManagementToolStripMenuItem.Name = "SystemManagementToolStripMenuItem"
        Me.SystemManagementToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SystemManagementToolStripMenuItem.Text = "System Management"
        '
        'MyProfitToolStripMenuItem
        '
        Me.MyProfitToolStripMenuItem.Name = "MyProfitToolStripMenuItem"
        Me.MyProfitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MyProfitToolStripMenuItem.Text = "My Profit"
        '
        'GeneralSystemSetingsToolStripMenuItem
        '
        Me.GeneralSystemSetingsToolStripMenuItem.Name = "GeneralSystemSetingsToolStripMenuItem"
        Me.GeneralSystemSetingsToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GeneralSystemSetingsToolStripMenuItem.Text = "System Setings"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'btn_Minimize
        '
        Me.btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimize.BackColor = System.Drawing.Color.Aqua
        Me.btn_Minimize.Image = Global.point_of_sale.My.Resources.Resources.gg
        Me.btn_Minimize.ImageActive = Nothing
        Me.btn_Minimize.Location = New System.Drawing.Point(1135, 0)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(29, 29)
        Me.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimize.TabIndex = 5
        Me.btn_Minimize.TabStop = False
        Me.btn_Minimize.Zoom = 10
        '
        'btn_Maximize
        '
        Me.btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximize.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_Maximize.Image = Global.point_of_sale.My.Resources.Resources.ew
        Me.btn_Maximize.ImageActive = Nothing
        Me.btn_Maximize.Location = New System.Drawing.Point(1164, 0)
        Me.btn_Maximize.Name = "btn_Maximize"
        Me.btn_Maximize.Size = New System.Drawing.Size(28, 29)
        Me.btn_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Maximize.TabIndex = 6
        Me.btn_Maximize.TabStop = False
        Me.btn_Maximize.Zoom = 10
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(1192, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 29)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 7
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'frm_AdminDas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.BackgroundImage = Global.point_of_sale.My.Resources.Resources.flickr_marco_verch
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1222, 718)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Maximize)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_AdminDas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_AdminDas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.btn_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btn_DailySales As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_AddProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_AddSaler As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMakeSales As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRole As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn_Minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Maximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents mnSettings As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCategoryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdateProductToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents UserManagmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents MyProfitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralSystemSetingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAvelable As Label
End Class
