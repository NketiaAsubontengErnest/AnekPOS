Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_Sale
    Dim reader As MySqlDataReader
    Dim count As Integer = 0

    ' Dim ProName, proID, quant, price, catID As New ArrayList

    Dim totalPrice As Decimal
    Dim itemName As ArrayList = New ArrayList()
    Dim quanti As ArrayList = New ArrayList()
    Dim unit As ArrayList = New ArrayList()
    Dim prize As ArrayList = New ArrayList()
    Dim profit As ArrayList = New ArrayList()
    Dim hidden As ArrayList = New ArrayList()

    Dim unitPrice, quantity, total As Decimal
    Private Sub frm_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isClosed() And frm_AdminDas.lblRole.Text = "Sale"
            cmb_cID.Enabled = False
            cmb_ProductName.Enabled = False
            Label1.Visible = False

            Label2.Text = "ACCOUNTS CLOSED FOR THE DAY. " + vbCrLf + "CAN'T MAKE SALES."
        End If

        calculateSales(frm_AdminDas.lblUserID.Text)
        load_Data_Grid()
        txt_Quantity.Enabled = False
        btn_AddToList.Enabled = False
        btn_Done.Enabled = False

        ListBox1.Items.Add("ID" + vbTab + "Name" + vbTab + vbTab + "Qty" + vbTab + vbTab + "Price")


        fillReceipt()
        productType()
        ProductDetails()
        cmbType.Items.Add("Show All Products...")

        'load_Data_Grid()    "Unit Price" + vbTab + vbTab +
        'list_ShowAdded.Items.Add("Product       unitPrice       Quantity")
        'list_ShowAdded.Items.Add("***************************************")
    End Sub

    Private Sub txt_UnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        rtxtReceipt.Clear()

        confirmPurchase()
        calculateSales(frm_AdminDas.lblUserID.Text)
        updateProducts()

        rtxtReceipt.AppendText(vbTab + "ISAAC NYAMEKYE DRUG STORE" + vbCrLf)
        rtxtReceipt.AppendText("        Sales Receipt" + vbCrLf)
        rtxtReceipt.AppendText("--------------------------------------------------------------------" + vbCrLf)
        rtxtReceipt.AppendText("Item" + "                                " + "Price" + "          " + "Qty" + "        " + "Amount" + vbCrLf)
        fillReceipt()
        rtxtReceipt.AppendText("--------------------------------------------------------------------" + vbCrLf)
        rtxtReceipt.AppendText("                                                     Total: " + lblTotalPrice.Text + vbCrLf)
        rtxtReceipt.AppendText("                                                    -----------------------" + vbCrLf + vbCrLf)
        rtxtReceipt.AppendText("Issued By: " + frm_AdminDas.lblUserName.Text + vbCrLf)
        rtxtReceipt.AppendText("Date Issued: " + DateTime.Now.ToString + vbCrLf + vbCrLf)

        lblTotalPrice.Text = ""
        overallTotal = 0
        countOutStock()

        load_Data_Grid()

        Button1.PerformClick()
    End Sub
    Public Sub countOutStock()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "Select Product_ID FROM product WHERE `instock` < `Average_Quantity`"

        Dim countOut As Int16 = 0

        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        countOut += 1
                    End While

                    If countOut = 0 Then

                        frm_AdminDas.lblAvelable.Visible = False
                    Else
                        frm_AdminDas.lblAvelable.Visible = True
                        frm_AdminDas.lblAvelable.Text = countOut.ToString + " Products is out of stock!!!"

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub


    Public Sub ProductDetails()
        Dim CHECK As String = ""
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

        Dim query As String

        If cmbType.SelectedIndex = -1 Or cmbType.Text = "Show All Products..." Then
            query = "SELECT * FROM product"
        Else
            query = "SELECT * FROM product WHERE catID='" + cmb_cID.Text + "'"

        End If

        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        CHECK = reader.Item("hide")
                        If CHECK = "NO" Then
                            cmb_ProductName.Items.Add(reader.Item("Pro_Name"))
                            cmd_unitPrice.Items.Add(reader.Item("price"))
                            cmb_pID.Items.Add(reader.Item("Product_ID"))
                            cmb_cID.Items.Add(reader("type"))
                            cmbCost.Items.Add(reader("selling_price"))
                            cmb_QuantInstack.Items.Add(reader("instock"))
                            cmb_Hide.Items.Add(reader("hide"))
                        End If
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using

    End Sub

    Public Sub ProductDetailsAllHiden()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

        Dim query As String

        If cmbType.SelectedIndex = -1 Or cmbType.Text = "Show All Products..." Then
            query = "SELECT * FROM product"
        Else
            query = "SELECT * FROM product WHERE catID='" + cmb_cID.Text + "'"

        End If

        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        cmb_ProductName.Items.Add(reader.Item("Pro_Name"))
                        cmd_unitPrice.Items.Add(reader.Item("price"))
                        cmb_pID.Items.Add(reader.Item("Product_ID"))
                        cmb_cID.Items.Add(reader("type"))
                        cmbCost.Items.Add(reader("selling_price"))
                        cmb_QuantInstack.Items.Add(reader("instock"))
                        cmb_Hide.Items.Add(reader("hide"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using

    End Sub


    Public Sub productType()

        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT * FROM producttype"

        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        cmb_cID.Items.Add(reader("catID"))
                        cmbType.Items.Add(reader("category"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using

    End Sub
    Public Sub setCategory()
        Dim con1Stringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query1 As String = "SELECT * FROM producttype"

        Using conn As New MySqlConnection(con1Stringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query1
                End With

                Try
                    conn.Open()
                    Dim reader1 As MySqlDataReader = command.ExecuteReader

                    While reader1.Read
                        cmb_cID.Items.Add(reader1.Item("catID"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub


    Private Sub txt_Quantity_ValueChanged(sender As Object, e As EventArgs) Handles txt_Quantity.ValueChanged

        Try
            txtpri.Text = Convert.ToString(Convert.ToDecimal(txt_Quantity.Text) * Convert.ToDecimal(cmd_unitPrice.Text))
            Dim CALP As Double = Convert.ToDecimal(txt_Quantity.Text) * Convert.ToDecimal(cmbCost.Text)
            lblProf.Text = Convert.ToString(Convert.ToDecimal(txtpri.Text) - CALP)
        Catch ex As Exception

        End Try

        If lblInStock.Text = 0.ToString Then
            btn_AddToList.Enabled = False

        End If

    End Sub

    Private Sub cmb_ProductName_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_ProductName.SelectedIndexChanged


        Try
            cmd_unitPrice.Text = cmd_unitPrice.Items(cmb_ProductName.SelectedIndex)
            cmb_pID.Text = cmb_pID.Items(cmb_ProductName.SelectedIndex)
            cmb_cID.Text = cmb_cID.Items(cmb_ProductName.SelectedIndex)
            cmbCost.Text = cmbCost.Items(cmb_ProductName.SelectedIndex)
            cmb_QuantInstack.Text = cmb_QuantInstack.Items(cmb_ProductName.SelectedIndex)
            cmb_Hide.Text = cmb_Hide.Items(cmb_ProductName.SelectedIndex)

            txt_Quantity.Enabled = True
            btn_AddToList.Enabled = True

            inStock()

            If lblInStock.Text = 0 Then
                btn_AddToList.Enabled = False
                txt_Quantity.Enabled = False

            End If
            cal_Price()

            txt_Quantity.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cal_Price()

        Try
            txtpri.Text = Convert.ToString(Convert.ToDecimal(txt_Quantity.Text) * Convert.ToDecimal(cmd_unitPrice.Text))
            Dim CALP As Double = Convert.ToDecimal(txt_Quantity.Text) * Convert.ToDecimal(cmbCost.Text)
            lblProf.Text = Convert.ToString(Convert.ToDecimal(txtpri.Text) - CALP)
        Catch ex As Exception

        End Try

    End Sub


    Public Sub inStock()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT instock, hide from product where product_ID='" + cmb_pID.Text + "'"

        Dim todaySales As Decimal = 0.00

        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    If reader.Read Then
                        lblInStock.Text = reader("instock")
                        txt_Quantity.Maximum = Convert.ToInt32(lblInStock.Text)

                        'cmb_QuantInstack.Text = Convert.ToSingle(lblInStock.Text)
                    End If


                    'lblSales.Text = "Gh¢" + todaySales.ToString
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            If lstItemID.SelectedIndex > -1 Then
                lstItemID.Items.RemoveAt(lstItemID.SelectedIndex)

                itemName.RemoveAt(lstTrackPrice.SelectedIndex)
                unit.RemoveAt(lstTrackPrice.SelectedIndex)
                prize.RemoveAt(lstTrackPrice.SelectedIndex)
                quanti.RemoveAt(lstTrackPrice.SelectedIndex)
                profit.RemoveAt(lstTrackPrice.SelectedIndex)
                hidden.RemoveAt(lstTrackPrice.SelectedIndex)

                overallTotal -= Convert.ToDecimal(lstTrackPrice.Items(lstTrackPrice.SelectedIndex))
                lstTrackPrice.Items.RemoveAt(lstTrackPrice.SelectedIndex)
                lstID.Items.RemoveAt(lstID.SelectedIndex)
                lstTrackQty.Items.RemoveAt(lstTrackQty.SelectedIndex)

                lblTotalPrice.Text = overallTotal

                txtDeletePrice.Text = ""
                TextBox1.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub list_ShowAdded_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItemID.SelectedIndexChanged, lstTrackPrice.SelectedIndexChanged, lstTrackQty.SelectedIndexChanged, lstID.SelectedIndexChanged
        Try
            If lstItemID.Items.Count = -1 Then
            ElseIf Not lstItemID.SelectedIndex > -1 Then
            Else
                txtDeletePrice.Text = lstItemID.Items(lstItemID.SelectedIndex)
                lstTrackPrice.SelectedIndex = lstItemID.SelectedIndex
                lstTrackQty.SelectedIndex = lstItemID.SelectedIndex
                lstID.SelectedIndex = lstItemID.SelectedIndex

                Dim count As Integer = txtDeletePrice.Text.Count

            End If
        Catch ex As Exception

        End Try

    End Sub



    Dim overallTotal As Decimal


    Public Sub addItemsToList()

        Try
            totalPrice = Convert.ToDecimal(cmd_unitPrice.Text) * Convert.ToDecimal(txt_Quantity.Value)

            overallTotal += totalPrice

            itemName.Add(cmb_ProductName.Text)
            quanti.Add(txt_Quantity.Value)
            unit.Add(cmd_unitPrice.Text)
            prize.Add(totalPrice)
            profit.Add(lblProf.Text)
            hidden.Add(cmb_Hide.Text)

            lblTotalPrice.Text = "Gh¢" + overallTotal.ToString
        Catch ex As Exception

        End Try

    End Sub

    Public Sub addToList()
        Try
            Dim amount As Decimal = Convert.ToDecimal(cmd_unitPrice.Text) * Convert.ToDecimal(txt_Quantity.Value)
            txtpri.Text = amount.ToString

            lstItemID.Items.Add(
                                cmb_pID.Text +
                                     "              " +
                                     cmb_ProductName.Text +
                                     "          " +
                                     txt_Quantity.Value.ToString +
                                     "          " +
                                     amount.ToString + vbCrLf)

            lstTrackPrice.Items.Add(amount)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_AddToList_Click(sender As Object, e As EventArgs) Handles btn_AddToList.Click
        Try
            Dim qty As Integer = Convert.ToInt32(lblInStock.Text) - txt_Quantity.Value

            lstID.Items.Add(cmb_pID.Text)
            lstTrackQty.Items.Add(qty)

            btn_Done.Enabled = True

            addToList()
            addItemsToList()

            lblInStock.Text = qty.ToString
        Catch ex As Exception
            MsgBox("Please select a product !!", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    '"Unit Price" + vbTab + vbTab +  cmd_unitPrice.Text +

    Public Sub fillReceipt()


        Try
            Dim count As Integer = itemName.Count
            Dim i As Integer = 0

            While i < count
                rtxtReceipt.AppendText(itemName.ToArray.GetValue(i) + "                     " +
                                       unit.ToArray.GetValue(i).ToString + "            " +
                                       quanti.ToArray.GetValue(i).ToString + "                " +
                                       prize.ToArray.GetValue(i).ToString + vbCrLf)
                i += 1
            End While

            itemName.Clear()
            unit.Clear()
            quanti.Clear()
            prize.Clear()
            hidden.Clear()
            profit.Clear()

            lstID.Items.Clear()
            lstTrackQty.Items.Clear()

            load_Data_Grid()

            TextBox1.Text = itemName.Count

            btn_Clear.PerformClick()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Try
            lstItemID.Items.Add("ID" + vbTab + "Name" + vbTab + vbTab + "Qty" + vbTab + "Price")
            lstItemID.Items.Clear()
            lstTrackPrice.Items.Clear()
            lstTrackPrice.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub load_Data_Grid()
        Try
            Dim con As MySqlConnection

            Dim ada As New MySqlDataAdapter
            Dim ds As New DataSet

            con = New MySqlConnection("server=localhost;userid=root;password=0554013980A@;database=point_of_sale")
            con.Open()

            ada = New MySqlDataAdapter("Select ID,item,Qty,price,Amount,month from sales where month='" + Date.Now.ToString("dd/MM/yyyy") + "'
                                   AND employeeID='" + frm_AdminDas.lblUserID.Text + "' AND hide = 'NO'", con)
            ada.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub load_Data_Grid_All()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection("server=localhost;userid=root;password=0554013980A@;database=point_of_sale")
        con.Open()

        ada = New MySqlDataAdapter("Select ID,item,Qty,price,Amount,month from sales where month='" + Date.Now.ToString("dd/MM/yyyy") + "'
                                   AND employeeID='" + frm_AdminDas.lblUserID.Text + "'", con)
        ada.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Public Sub calculateSales(ByVal ids As String)
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT amount from sales where month='" + Date.Now.ToString("dd/MM/yyyy") + "' AND employeeID='" + ids + "'"

        Dim todaySales As Decimal = 0.00

        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        todaySales += reader("amount")

                    End While

                    lblSales.Text = "Gh¢" + todaySales.ToString("#,0.00")
                    frm_PointOfSale.lbl_TotalSales.Text = todaySales.ToString
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Public Sub confirmPurchase()
        Dim A As Integer = 0

        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

        Dim track As String = Path.GetRandomFileName()
        track.Replace(".", "")
        track.Replace("/", "")
        track.Replace("\", "")

        Try


            Dim count As Integer = itemName.Count
            Dim i As Integer = 0

            While i < count
                connection.Open()
                insertString_EmpDetiles = "INSERT INTO sales (item, Qty, price, amount, trackRec, employeeID,date,month,profit,	Gen_Mount, hide) VALUES (
                                                                '" + itemName.ToArray.GetValue(i).ToString + "', 
                                                                '" + quanti.ToArray.GetValue(i).ToString + "', 
                                                                '" + unit.ToArray.GetValue(i).ToString + "', 
                                                                '" + prize.ToArray.GetValue(i).ToString + "', 
                                                                '" + track + "', 
                                                                '" + frm_AdminDas.lblUserID.Text + "', 
                                                                '" + DateTime.Now.ToString + "',
                                                                '" + Date.Now.ToString("dd/MM/yyyy") + "',
                                                                '" + profit.ToArray.GetValue(i).ToString + "',
                                                                '" + Date.Now.ToString("MM") + "',
                                                                '" + hidden.ToArray.GetValue(i).ToString + "')"
                command = New MySqlCommand(insertString_EmpDetiles, connection)
                command.ExecuteNonQuery()

                connection.Close()

                i += 1
            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try
        'End While

    End Sub

    Public Sub updateProducts()
        Dim A As Integer = 0

        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

        Try


            Dim count As Integer = itemName.Count
            Dim i As Integer = 0

            While i < count
                Dim Qty As String = lstTrackQty.Items(i).ToString
                connection.Open()
                'MsgBox("Quantity: " + quanti.ToArray.GetValue(i).ToString + "Name: " + itemName.ToArray.GetValue(i).ToString) 
                insertString_EmpDetiles = "UPDATE `product` SET `instock`= instock - '" & Convert.ToInt32(quanti.ToArray.GetValue(i).ToString) & "', `quant_soldq`= quant_soldq + '" & Convert.ToInt32(quanti.ToArray.GetValue(i).ToString) & "' WHERE `Pro_Name`= '" & itemName.ToArray.GetValue(i).ToString & "'"

                command = New MySqlCommand(insertString_EmpDetiles, connection)
                command.ExecuteNonQuery()

                connection.Close()

                i += 1
            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try
        'End While

    End Sub

    Public Function isClosed()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT isClosed from dailysales where employeeID='" + frm_AdminDas.lblUserID.Text + "'
                              AND date='" + Date.Now.ToString("dd/MM/yyyy") + "'"

        Dim closed As Boolean = False

        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    If reader.Read Then
                        closed = True
                    Else
                        closed = False
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using

        Return closed
    End Function

    Public Sub dailySales()

        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

        Try


            connection.Open()
            insertString_EmpDetiles = "INSERT INTO dailysales (employeeID,totalsales,date,datePrepared,isClosed) VALUES (
                                                                   '" + frm_AdminDas.lblUserID.Text + "',
                                                                   '" + lblSales.Text + "',
                                                                   '" + Date.Now.ToString("dd/MM/yyyy") + "',
                                                                   '" + DateTime.Now.ToString + "',
                                                                   'Yes')"
            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            MsgBox("Sales Confirmed")

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try
        'End While

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rtxtReceipt.ResetText()
        Button1.PerformClick()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'If e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        '    TextBox2.Text = row.Cells(0).Value.ToString
        'End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Try
            Dim ans As DialogResult = MsgBox("Are you sure to End Today's Session? ", MsgBoxStyle.YesNo, "Confirm Close Account")

            If ans = DialogResult.Yes Then
                dailySales()
            End If

            cmb_cID.Enabled = False
            cmb_ProductName.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txt_Quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Quantity.KeyPress
        Try
            cal_Price()

            If e.KeyChar = ChrW(Keys.Enter) Then
                addToList()
                addItemsToList()
                btn_Done.Enabled = True
                cmb_ProductName.Focus()

                Dim qty As Integer = Convert.ToInt32(lblInStock.Text) - txt_Quantity.Value

                lstID.Items.Add(cmb_pID.Text)
                lstTrackQty.Items.Add(qty)

                lblInStock.Text = qty.ToString
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmb_ProductName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_ProductName.KeyPress, cmbType.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_Quantity.Focus()
        End If
    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click, lblInStock.Click, GunaLabel9.Click

    End Sub

    Private Sub cmd_unitPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmd_unitPrice.SelectedIndexChanged
        inStock()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        Try
            cmb_Hide.Items.Clear()
            cmb_Hide.Text = ""
            cmb_ProductName.Items.Clear()
            cmb_ProductName.Text = ""
            cmd_unitPrice.Items.Clear()
            cmd_unitPrice.Text = ""
            lblInStock.Text = ""
            cmb_QuantInstack.Items.Clear()
            cmb_QuantInstack.Text = ""
            txtpri.Text = ""
            cmbCost.Items.Clear()
            txt_Quantity.Value = 1
            cmb_cID.Text = cmb_cID.Items(cmbType.SelectedIndex)

        Catch ex As Exception
        Finally
            If ckShowAll.Checked = True Then
                ProductDetailsAllHiden()
            Else

                ProductDetails()
            End If

        End Try

    End Sub

    Private Sub txt_Quantity_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_Quantity.MouseClick
        cal_Price()
    End Sub

    Private Sub txt_Quantity_Click(sender As Object, e As EventArgs) Handles txt_Quantity.Click
        cal_Price()
    End Sub

    Private Sub ckShowAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckShowAll.CheckedChanged
        Try
            cmb_Hide.Items.Clear()
            cmb_Hide.Text = ""
            cmb_QuantInstack.Items.Clear()
            cmb_QuantInstack.Text = ""
            cmb_ProductName.Items.Clear()
            cmb_ProductName.Text = ""
            cmbCost.Items.Clear()
            cmd_unitPrice.Items.Clear()
            cmd_unitPrice.Text = ""
            lblInStock.Text = ""
            txtpri.Text = ""
            txt_Quantity.Value = 1
            cmb_cID.Text = cmb_cID.Items(cmbType.SelectedIndex)

        Catch ex As Exception

        Finally
            If ckShowAll.Checked = True Then
                ProductDetailsAllHiden()
                load_Data_Grid_All()
            Else
                ProductDetails()
                load_Data_Grid()
            End If
        End Try
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.Blue

    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Maroon

    End Sub
End Class