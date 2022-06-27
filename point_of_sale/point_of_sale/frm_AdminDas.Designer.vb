<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_AdminDas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AdminDas))
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
        Me.Btn_AddSaler = New Guna.UI2.WinForms.Guna2Button()
        Me.lblAvelable = New System.Windows.Forms.Label()
        Me.LblCompanyName = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatisticsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyProfitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_Minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblSetDash = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.btn_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2ShadowPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblRole)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Panel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnMakeSales)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_DailySales)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_AddProduct)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Btn_AddSaler)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 24)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(225, 677)
        Me.Guna2ShadowPanel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.point_of_sale.My.Resources.Resources.pos_logo
        Me.PictureBox1.Location = New System.Drawing.Point(55, 4)
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
        Me.btnMakeSales.Animated = True
        Me.btnMakeSales.AutoRoundedCorners = True
        Me.btnMakeSales.BackColor = System.Drawing.Color.Transparent
        Me.btnMakeSales.BorderRadius = 21
        Me.btnMakeSales.CheckedState.Parent = Me.btnMakeSales
        Me.btnMakeSales.CustomImages.Parent = Me.btnMakeSales
        Me.btnMakeSales.FillColor = System.Drawing.Color.Gold
        Me.btnMakeSales.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnMakeSales.ForeColor = System.Drawing.Color.Black
        Me.btnMakeSales.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.btnMakeSales.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnMakeSales.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.btnMakeSales.HoverState.Parent = Me.btnMakeSales
        Me.btnMakeSales.Location = New System.Drawing.Point(13, 216)
        Me.btnMakeSales.Name = "btnMakeSales"
        Me.btnMakeSales.ShadowDecoration.Parent = Me.btnMakeSales
        Me.btnMakeSales.Size = New System.Drawing.Size(228, 45)
        Me.btnMakeSales.TabIndex = 5
        Me.btnMakeSales.Text = "Make Sales"
        Me.btnMakeSales.UseTransparentBackground = True
        '
        'btn_DailySales
        '
        Me.btn_DailySales.Animated = True
        Me.btn_DailySales.AutoRoundedCorners = True
        Me.btn_DailySales.BackColor = System.Drawing.Color.Transparent
        Me.btn_DailySales.BorderRadius = 21
        Me.btn_DailySales.CheckedState.Parent = Me.btn_DailySales
        Me.btn_DailySales.CustomImages.Parent = Me.btn_DailySales
        Me.btn_DailySales.FillColor = System.Drawing.Color.Gold
        Me.btn_DailySales.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_DailySales.ForeColor = System.Drawing.Color.Black
        Me.btn_DailySales.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.btn_DailySales.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_DailySales.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.btn_DailySales.HoverState.Parent = Me.btn_DailySales
        Me.btn_DailySales.Location = New System.Drawing.Point(13, 267)
        Me.btn_DailySales.Name = "btn_DailySales"
        Me.btn_DailySales.ShadowDecoration.Parent = Me.btn_DailySales
        Me.btn_DailySales.Size = New System.Drawing.Size(228, 45)
        Me.btn_DailySales.TabIndex = 5
        Me.btn_DailySales.Text = "Daily Sales"
        Me.btn_DailySales.UseTransparentBackground = True
        '
        'btn_AddProduct
        '
        Me.btn_AddProduct.Animated = True
        Me.btn_AddProduct.AutoRoundedCorners = True
        Me.btn_AddProduct.BackColor = System.Drawing.Color.Transparent
        Me.btn_AddProduct.BorderRadius = 21
        Me.btn_AddProduct.CheckedState.Parent = Me.btn_AddProduct
        Me.btn_AddProduct.CustomImages.Parent = Me.btn_AddProduct
        Me.btn_AddProduct.FillColor = System.Drawing.Color.Gold
        Me.btn_AddProduct.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_AddProduct.ForeColor = System.Drawing.Color.Black
        Me.btn_AddProduct.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.btn_AddProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_AddProduct.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.btn_AddProduct.HoverState.Parent = Me.btn_AddProduct
        Me.btn_AddProduct.Location = New System.Drawing.Point(13, 165)
        Me.btn_AddProduct.Name = "btn_AddProduct"
        Me.btn_AddProduct.ShadowDecoration.Parent = Me.btn_AddProduct
        Me.btn_AddProduct.Size = New System.Drawing.Size(228, 45)
        Me.btn_AddProduct.TabIndex = 4
        Me.btn_AddProduct.Text = "Add Product"
        Me.btn_AddProduct.UseTransparentBackground = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(77, 655)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Logout"
        '
        'Btn_AddSaler
        '
        Me.Btn_AddSaler.Animated = True
        Me.Btn_AddSaler.AutoRoundedCorners = True
        Me.Btn_AddSaler.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AddSaler.BorderRadius = 21
        Me.Btn_AddSaler.CheckedState.Parent = Me.Btn_AddSaler
        Me.Btn_AddSaler.CustomImages.Parent = Me.Btn_AddSaler
        Me.Btn_AddSaler.FillColor = System.Drawing.Color.Gold
        Me.Btn_AddSaler.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_AddSaler.ForeColor = System.Drawing.Color.Black
        Me.Btn_AddSaler.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.Btn_AddSaler.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Btn_AddSaler.HoverState.ForeColor = System.Drawing.Color.Gold
        Me.Btn_AddSaler.HoverState.Parent = Me.Btn_AddSaler
        Me.Btn_AddSaler.Location = New System.Drawing.Point(13, 114)
        Me.Btn_AddSaler.Name = "Btn_AddSaler"
        Me.Btn_AddSaler.ShadowDecoration.Parent = Me.Btn_AddSaler
        Me.Btn_AddSaler.Size = New System.Drawing.Size(228, 45)
        Me.Btn_AddSaler.TabIndex = 3
        Me.Btn_AddSaler.Text = "Add Employee"
        Me.Btn_AddSaler.UseTransparentBackground = True
        '
        'lblAvelable
        '
        Me.lblAvelable.AutoSize = True
        Me.lblAvelable.BackColor = System.Drawing.Color.Transparent
        Me.lblAvelable.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvelable.ForeColor = System.Drawing.Color.Red
        Me.lblAvelable.Location = New System.Drawing.Point(596, -4)
        Me.lblAvelable.Name = "lblAvelable"
        Me.lblAvelable.Size = New System.Drawing.Size(62, 23)
        Me.lblAvelable.TabIndex = 9
        Me.lblAvelable.Text = "Label8"
        Me.lblAvelable.Visible = False
        '
        'LblCompanyName
        '
        Me.LblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCompanyName.AutoSize = True
        Me.LblCompanyName.BackColor = System.Drawing.Color.White
        Me.LblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompanyName.Location = New System.Drawing.Point(583, 2)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(114, 24)
        Me.LblCompanyName.TabIndex = 10
        Me.LblCompanyName.Text = "ANEK POS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSettings, Me.ProductToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1222, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnSettings
        '
        Me.mnSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemManagementToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.mnSettings.Name = "mnSettings"
        Me.mnSettings.Size = New System.Drawing.Size(37, 20)
        Me.mnSettings.Text = "File"
        '
        'SystemManagementToolStripMenuItem
        '
        Me.SystemManagementToolStripMenuItem.Name = "SystemManagementToolStripMenuItem"
        Me.SystemManagementToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SystemManagementToolStripMenuItem.Text = "System Setings"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCategoryToolStripMenuItem, Me.UpdateProductToolStripMenuItem, Me.ListOfProductToolStripMenuItem1})
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductToolStripMenuItem.Text = "Products"
        '
        'AddCategoryToolStripMenuItem
        '
        Me.AddCategoryToolStripMenuItem.Name = "AddCategoryToolStripMenuItem"
        Me.AddCategoryToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddCategoryToolStripMenuItem.Text = "Add Category"
        '
        'UpdateProductToolStripMenuItem
        '
        Me.UpdateProductToolStripMenuItem.Name = "UpdateProductToolStripMenuItem"
        Me.UpdateProductToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateProductToolStripMenuItem.Text = "Update Product"
        '
        'ListOfProductToolStripMenuItem1
        '
        Me.ListOfProductToolStripMenuItem1.Name = "ListOfProductToolStripMenuItem1"
        Me.ListOfProductToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ListOfProductToolStripMenuItem1.Text = "List Of Product"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatisticsToolStripMenuItem1, Me.MyProfitToolStripMenuItem1, Me.GeneralReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'StatisticsToolStripMenuItem1
        '
        Me.StatisticsToolStripMenuItem1.Name = "StatisticsToolStripMenuItem1"
        Me.StatisticsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.StatisticsToolStripMenuItem1.Text = "Statistics"
        '
        'MyProfitToolStripMenuItem1
        '
        Me.MyProfitToolStripMenuItem1.Name = "MyProfitToolStripMenuItem1"
        Me.MyProfitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.MyProfitToolStripMenuItem1.Text = "My Profit"
        '
        'GeneralReportToolStripMenuItem
        '
        Me.GeneralReportToolStripMenuItem.Name = "GeneralReportToolStripMenuItem"
        Me.GeneralReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GeneralReportToolStripMenuItem.Text = "General Report"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfUsersToolStripMenuItem, Me.AddNewUserToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ListOfUsersToolStripMenuItem
        '
        Me.ListOfUsersToolStripMenuItem.Name = "ListOfUsersToolStripMenuItem"
        Me.ListOfUsersToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ListOfUsersToolStripMenuItem.Text = "List Of Users"
        '
        'AddNewUserToolStripMenuItem
        '
        Me.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem"
        Me.AddNewUserToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AddNewUserToolStripMenuItem.Text = "Add New User"
        '
        'btn_Minimize
        '
        Me.btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimize.BackColor = System.Drawing.Color.Aqua
        Me.btn_Minimize.Image = Global.point_of_sale.My.Resources.Resources.gg
        Me.btn_Minimize.ImageActive = Nothing
        Me.btn_Minimize.Location = New System.Drawing.Point(1135, 0)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(29, 26)
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
        Me.btn_Maximize.Location = New System.Drawing.Point(1165, 0)
        Me.btn_Maximize.Name = "btn_Maximize"
        Me.btn_Maximize.Size = New System.Drawing.Size(28, 26)
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
        Me.btn_close.Location = New System.Drawing.Point(1194, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 26)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 7
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.lblTimer)
        Me.Guna2Panel1.Controls.Add(Me.lblSetDash)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(225, 24)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(997, 35)
        Me.Guna2Panel1.TabIndex = 12
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTimer.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Gold
        Me.lblTimer.Location = New System.Drawing.Point(926, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(71, 36)
        Me.lblTimer.TabIndex = 14
        Me.lblTimer.Text = "time"
        '
        'lblSetDash
        '
        Me.lblSetDash.AutoSize = True
        Me.lblSetDash.BackColor = System.Drawing.Color.Transparent
        Me.lblSetDash.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetDash.ForeColor = System.Drawing.Color.Gold
        Me.lblSetDash.Location = New System.Drawing.Point(7, 4)
        Me.lblSetDash.Name = "lblSetDash"
        Me.lblSetDash.Size = New System.Drawing.Size(210, 26)
        Me.lblSetDash.TabIndex = 13
        Me.lblSetDash.Text = "usuername / Dashbord"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.lblAvelable)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 701)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1222, 17)
        Me.Guna2Panel2.TabIndex = 14
        '
        'Timer1
        '
        '
        'Frm_AdminDas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1222, 718)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_Maximize)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LblCompanyName)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_AdminDas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_AdminDas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.btn_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btn_DailySales As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_AddProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_AddSaler As Guna.UI2.WinForms.Guna2Button
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
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents LblCompanyName As Label
    Friend WithEvents SystemManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAvelable As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSetDash As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTimer As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfProductToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MyProfitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListOfUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralReportToolStripMenuItem As ToolStripMenuItem
End Class
