<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Sale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Sale))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_unitPrice = New System.Windows.Forms.ComboBox()
        Me.txt_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.cmb_pID = New System.Windows.Forms.ComboBox()
        Me.rtxtReceipt = New System.Windows.Forms.RichTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_cID = New System.Windows.Forms.ComboBox()
        Me.txtpri = New System.Windows.Forms.TextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.lblTotalPrice = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_ProductName = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDeletePrice = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lstItemID = New System.Windows.Forms.ListBox()
        Me.lstTrackPrice = New System.Windows.Forms.ListBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.lblSales = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.lblInStock = New Guna.UI.WinForms.GunaLabel()
        Me.lstTrackQty = New System.Windows.Forms.ListBox()
        Me.lstID = New System.Windows.Forms.ListBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_QuantInstack = New System.Windows.Forms.ComboBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ckShowAll = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.lblProf = New System.Windows.Forms.Label()
        Me.cmbCost = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmb_Hide = New System.Windows.Forms.ComboBox()
        Me.list_hide = New System.Windows.Forms.ListBox()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Clear = New Guna.UI.WinForms.GunaButton()
        Me.btn_Done = New Guna.UI.WinForms.GunaButton()
        Me.btn_AddToList = New Guna.UI.WinForms.GunaButton()
        Me.cmbType = New Guna.UI.WinForms.GunaComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Gold
        Me.GunaLabel1.Location = New System.Drawing.Point(419, -4)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(163, 32)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "SALES POINT"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(22, 82)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(141, 25)
        Me.GunaLabel2.TabIndex = 0
        Me.GunaLabel2.Text = "Product Name"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(24, 122)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(99, 25)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "Unit Price"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(24, 162)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(89, 25)
        Me.GunaLabel4.TabIndex = 0
        Me.GunaLabel4.Text = "Quantity"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.item, Me.Qty, Me.pri, Me.amount, Me.dat})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 534)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1025, 242)
        Me.DataGridView1.TabIndex = 8
        '
        'id
        '
        Me.id.DataPropertyName = "ID"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'item
        '
        Me.item.DataPropertyName = "item"
        Me.item.HeaderText = "Item Name"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'pri
        '
        Me.pri.DataPropertyName = "price"
        Me.pri.HeaderText = "Price"
        Me.pri.Name = "pri"
        Me.pri.ReadOnly = True
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'dat
        '
        Me.dat.DataPropertyName = "month"
        Me.dat.HeaderText = "Date"
        Me.dat.Name = "dat"
        Me.dat.ReadOnly = True
        '
        'cmd_unitPrice
        '
        Me.cmd_unitPrice.Enabled = False
        Me.cmd_unitPrice.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_unitPrice.FormattingEnabled = True
        Me.cmd_unitPrice.Location = New System.Drawing.Point(171, 122)
        Me.cmd_unitPrice.Name = "cmd_unitPrice"
        Me.cmd_unitPrice.Size = New System.Drawing.Size(90, 31)
        Me.cmd_unitPrice.TabIndex = 1
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity.Location = New System.Drawing.Point(171, 159)
        Me.txt_Quantity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_Quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(90, 31)
        Me.txt_Quantity.TabIndex = 1
        Me.txt_Quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmb_pID
        '
        Me.cmb_pID.FormattingEnabled = True
        Me.cmb_pID.Location = New System.Drawing.Point(202, 93)
        Me.cmb_pID.Name = "cmb_pID"
        Me.cmb_pID.Size = New System.Drawing.Size(121, 21)
        Me.cmb_pID.TabIndex = 11
        '
        'rtxtReceipt
        '
        Me.rtxtReceipt.AutoWordSelection = True
        Me.rtxtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rtxtReceipt.Location = New System.Drawing.Point(499, 112)
        Me.rtxtReceipt.Name = "rtxtReceipt"
        Me.rtxtReceipt.ReadOnly = True
        Me.rtxtReceipt.Size = New System.Drawing.Size(536, 368)
        Me.rtxtReceipt.TabIndex = 13
        Me.rtxtReceipt.Text = ""
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(727, 86)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(77, 25)
        Me.GunaLabel5.TabIndex = 0
        Me.GunaLabel5.Text = "Receipt"
        '
        'cmb_cID
        '
        Me.cmb_cID.FormattingEnabled = True
        Me.cmb_cID.Location = New System.Drawing.Point(329, 93)
        Me.cmb_cID.Name = "cmb_cID"
        Me.cmb_cID.Size = New System.Drawing.Size(156, 21)
        Me.cmb_cID.TabIndex = 12
        '
        'txtpri
        '
        Me.txtpri.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtpri.Location = New System.Drawing.Point(397, 160)
        Me.txtpri.Name = "txtpri"
        Me.txtpri.Size = New System.Drawing.Size(95, 29)
        Me.txtpri.TabIndex = 14
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(268, 159)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(126, 25)
        Me.GunaLabel6.TabIndex = 15
        Me.GunaLabel6.Text = "Price             :"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.Location = New System.Drawing.Point(199, 432)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(0, 54)
        Me.lblTotalPrice.TabIndex = 0
        '
        'cmb_ProductName
        '
        Me.cmb_ProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_ProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_ProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmb_ProductName.FormattingEnabled = True
        Me.cmb_ProductName.Location = New System.Drawing.Point(171, 85)
        Me.cmb_ProductName.Name = "cmb_ProductName"
        Me.cmb_ProductName.Size = New System.Drawing.Size(322, 32)
        Me.cmb_ProductName.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(389, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 30)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDeletePrice
        '
        Me.txtDeletePrice.Location = New System.Drawing.Point(579, 383)
        Me.txtDeletePrice.Name = "txtDeletePrice"
        Me.txtDeletePrice.Size = New System.Drawing.Size(257, 20)
        Me.txtDeletePrice.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(579, 356)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 20)
        Me.TextBox1.TabIndex = 18
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(19, 240)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(474, 25)
        Me.ListBox1.TabIndex = 19
        '
        'lstItemID
        '
        Me.lstItemID.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItemID.FormattingEnabled = True
        Me.lstItemID.ItemHeight = 21
        Me.lstItemID.Location = New System.Drawing.Point(19, 267)
        Me.lstItemID.Name = "lstItemID"
        Me.lstItemID.Size = New System.Drawing.Size(474, 172)
        Me.lstItemID.TabIndex = 4
        '
        'lstTrackPrice
        '
        Me.lstTrackPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTrackPrice.FormattingEnabled = True
        Me.lstTrackPrice.ItemHeight = 21
        Me.lstTrackPrice.Location = New System.Drawing.Point(634, 148)
        Me.lstTrackPrice.Name = "lstTrackPrice"
        Me.lstTrackPrice.Size = New System.Drawing.Size(104, 214)
        Me.lstTrackPrice.TabIndex = 4
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel7.Location = New System.Drawing.Point(81, 437)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(126, 54)
        Me.GunaLabel7.TabIndex = 0
        Me.GunaLabel7.Text = "Total:"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel8.Location = New System.Drawing.Point(531, 40)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(129, 54)
        Me.GunaLabel8.TabIndex = 0
        Me.GunaLabel8.Text = "Sales:"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblSales.Location = New System.Drawing.Point(644, 40)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(0, 54)
        Me.lblSales.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(6, 614)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(898, 216)
        Me.Panel1.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(812, 486)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 30)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(780, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Close Accounts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(35, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 29)
        Me.Label2.TabIndex = 23
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(78, 170)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(0, 25)
        Me.GunaLabel9.TabIndex = 0
        Me.GunaLabel9.Visible = False
        '
        'lblInStock
        '
        Me.lblInStock.AutoSize = True
        Me.lblInStock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInStock.Location = New System.Drawing.Point(493, 53)
        Me.lblInStock.Name = "lblInStock"
        Me.lblInStock.Size = New System.Drawing.Size(0, 25)
        Me.lblInStock.TabIndex = 0
        Me.lblInStock.Visible = False
        '
        'lstTrackQty
        '
        Me.lstTrackQty.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTrackQty.FormattingEnabled = True
        Me.lstTrackQty.ItemHeight = 21
        Me.lstTrackQty.Location = New System.Drawing.Point(744, 157)
        Me.lstTrackQty.Name = "lstTrackQty"
        Me.lstTrackQty.Size = New System.Drawing.Size(104, 193)
        Me.lstTrackQty.TabIndex = 4
        '
        'lstID
        '
        Me.lstID.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstID.FormattingEnabled = True
        Me.lstID.ItemHeight = 21
        Me.lstID.Location = New System.Drawing.Point(662, 136)
        Me.lstID.Name = "lstID"
        Me.lstID.Size = New System.Drawing.Size(104, 214)
        Me.lstID.TabIndex = 4
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(22, 48)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(94, 25)
        Me.GunaLabel10.TabIndex = 0
        Me.GunaLabel10.Text = "Category"
        '
        'cmb_QuantInstack
        '
        Me.cmb_QuantInstack.Enabled = False
        Me.cmb_QuantInstack.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_QuantInstack.FormattingEnabled = True
        Me.cmb_QuantInstack.Location = New System.Drawing.Point(397, 123)
        Me.cmb_QuantInstack.Name = "cmb_QuantInstack"
        Me.cmb_QuantInstack.Size = New System.Drawing.Size(96, 31)
        Me.cmb_QuantInstack.TabIndex = 24
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(263, 126)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(133, 25)
        Me.GunaLabel11.TabIndex = 25
        Me.GunaLabel11.Text = "Available Qty:"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Location = New System.Drawing.Point(684, 486)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 30)
        Me.btnPrint.TabIndex = 26
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'ckShowAll
        '
        Me.ckShowAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckShowAll.CheckedState.BorderRadius = 2
        Me.ckShowAll.CheckedState.BorderThickness = 0
        Me.ckShowAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckShowAll.CheckedState.Parent = Me.ckShowAll
        Me.ckShowAll.Location = New System.Drawing.Point(12, 5)
        Me.ckShowAll.Name = "ckShowAll"
        Me.ckShowAll.ShadowDecoration.Parent = Me.ckShowAll
        Me.ckShowAll.Size = New System.Drawing.Size(20, 20)
        Me.ckShowAll.TabIndex = 27
        Me.ckShowAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ckShowAll.UncheckedState.BorderRadius = 2
        Me.ckShowAll.UncheckedState.BorderThickness = 0
        Me.ckShowAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ckShowAll.UncheckedState.Parent = Me.ckShowAll
        '
        'lblProf
        '
        Me.lblProf.AutoSize = True
        Me.lblProf.Location = New System.Drawing.Point(574, 203)
        Me.lblProf.Name = "lblProf"
        Me.lblProf.Size = New System.Drawing.Size(39, 13)
        Me.lblProf.TabIndex = 28
        Me.lblProf.Text = "Label3"
        '
        'cmbCost
        '
        Me.cmbCost.FormattingEnabled = True
        Me.cmbCost.Location = New System.Drawing.Point(562, 219)
        Me.cmbCost.Name = "cmbCost"
        Me.cmbCost.Size = New System.Drawing.Size(52, 21)
        Me.cmbCost.TabIndex = 29
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 778)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1051, 10)
        Me.Panel6.TabIndex = 38
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.ckShowAll)
        Me.Panel4.Controls.Add(Me.GunaLabel1)
        Me.Panel4.Controls.Add(Me.btn_close)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1051, 29)
        Me.Panel4.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1038, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 749)
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
        Me.Panel8.Location = New System.Drawing.Point(0, 29)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(13, 749)
        Me.Panel8.TabIndex = 36
        '
        'cmb_Hide
        '
        Me.cmb_Hide.FormattingEnabled = True
        Me.cmb_Hide.Location = New System.Drawing.Point(562, 148)
        Me.cmb_Hide.Name = "cmb_Hide"
        Me.cmb_Hide.Size = New System.Drawing.Size(51, 21)
        Me.cmb_Hide.TabIndex = 40
        '
        'list_hide
        '
        Me.list_hide.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_hide.FormattingEnabled = True
        Me.list_hide.ItemHeight = 21
        Me.list_hide.Location = New System.Drawing.Point(575, 153)
        Me.list_hide.Name = "list_hide"
        Me.list_hide.Size = New System.Drawing.Size(104, 214)
        Me.list_hide.TabIndex = 41
        '
        'btn_close
        '
        Me.btn_close.Image = Global.point_of_sale.My.Resources.Resources.close
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(1021, -1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(27, 29)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 21
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'btn_Clear
        '
        Me.btn_Clear.AnimationHoverSpeed = 0.07!
        Me.btn_Clear.AnimationSpeed = 0.03!
        Me.btn_Clear.BaseColor = System.Drawing.Color.Gold
        Me.btn_Clear.BorderColor = System.Drawing.Color.Black
        Me.btn_Clear.BorderSize = 2
        Me.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Clear.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Clear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.Black
        Me.btn_Clear.Image = Nothing
        Me.btn_Clear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Clear.Location = New System.Drawing.Point(29, 486)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Clear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Clear.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Clear.OnHoverImage = Nothing
        Me.btn_Clear.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Clear.Size = New System.Drawing.Size(232, 42)
        Me.btn_Clear.TabIndex = 3
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Done
        '
        Me.btn_Done.AnimationHoverSpeed = 0.07!
        Me.btn_Done.AnimationSpeed = 0.03!
        Me.btn_Done.BaseColor = System.Drawing.Color.Gold
        Me.btn_Done.BorderColor = System.Drawing.Color.Black
        Me.btn_Done.BorderSize = 2
        Me.btn_Done.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Done.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Done.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Done.ForeColor = System.Drawing.Color.Black
        Me.btn_Done.Image = Nothing
        Me.btn_Done.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Done.Location = New System.Drawing.Point(279, 486)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Done.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Done.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Done.OnHoverImage = Nothing
        Me.btn_Done.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Done.Size = New System.Drawing.Size(208, 42)
        Me.btn_Done.TabIndex = 3
        Me.btn_Done.Text = "Confirm Purchase"
        Me.btn_Done.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_AddToList
        '
        Me.btn_AddToList.AnimationHoverSpeed = 0.07!
        Me.btn_AddToList.AnimationSpeed = 0.03!
        Me.btn_AddToList.BaseColor = System.Drawing.Color.Gold
        Me.btn_AddToList.BorderColor = System.Drawing.Color.Black
        Me.btn_AddToList.BorderSize = 2
        Me.btn_AddToList.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_AddToList.FocusedColor = System.Drawing.Color.Empty
        Me.btn_AddToList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddToList.ForeColor = System.Drawing.Color.Black
        Me.btn_AddToList.Image = CType(resources.GetObject("btn_AddToList.Image"), System.Drawing.Image)
        Me.btn_AddToList.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_AddToList.Location = New System.Drawing.Point(171, 194)
        Me.btn_AddToList.Name = "btn_AddToList"
        Me.btn_AddToList.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_AddToList.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_AddToList.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_AddToList.OnHoverImage = Nothing
        Me.btn_AddToList.OnPressedColor = System.Drawing.Color.Black
        Me.btn_AddToList.Size = New System.Drawing.Size(322, 42)
        Me.btn_AddToList.TabIndex = 2
        Me.btn_AddToList.Text = "Add to List"
        Me.btn_AddToList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.Transparent
        Me.cmbType.BaseColor = System.Drawing.Color.White
        Me.cmbType.BorderColor = System.Drawing.Color.Silver
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(171, 47)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbType.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbType.Size = New System.Drawing.Size(322, 26)
        Me.cmbType.TabIndex = 42
        '
        'Frm_Sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1051, 788)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.rtxtReceipt)
        Me.Controls.Add(Me.list_hide)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.cmb_QuantInstack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_ProductName)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.txtpri)
        Me.Controls.Add(Me.cmb_pID)
        Me.Controls.Add(Me.txt_Quantity)
        Me.Controls.Add(Me.cmd_unitPrice)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Done)
        Me.Controls.Add(Me.btn_AddToList)
        Me.Controls.Add(Me.lstItemID)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblInStock)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.cmb_cID)
        Me.Controls.Add(Me.lstTrackPrice)
        Me.Controls.Add(Me.txtDeletePrice)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lstID)
        Me.Controls.Add(Me.lstTrackQty)
        Me.Controls.Add(Me.cmbCost)
        Me.Controls.Add(Me.lblProf)
        Me.Controls.Add(Me.cmb_Hide)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Sale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Sale"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_AddToList As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_Done As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_Clear As Guna.UI.WinForms.GunaButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmd_unitPrice As ComboBox
    Friend WithEvents txt_Quantity As NumericUpDown
    Friend WithEvents cmb_pID As ComboBox
    Friend WithEvents rtxtReceipt As RichTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_cID As ComboBox
    Friend WithEvents txtpri As TextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblTotalPrice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_ProductName As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDeletePrice As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lstItemID As ListBox
    Friend WithEvents lstTrackPrice As ListBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblSales As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents pri As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents dat As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblInStock As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lstTrackQty As ListBox
    Friend WithEvents lstID As ListBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_QuantInstack As ComboBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnPrint As Button
    Friend WithEvents ckShowAll As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents lblProf As Label
    Friend WithEvents cmbCost As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cmb_Hide As ComboBox
    Friend WithEvents list_hide As ListBox
    Friend WithEvents cmbType As Guna.UI.WinForms.GunaComboBox
End Class
