Imports MySql.Data.MySqlClient

Public Class frmAddProduct
    Dim count As Integer = 0

    Dim con As New MySqlConnection
    'Dim cmd As MySqlCommand
    'Dim da As MySqlDataAdapter

    Private Sub btn_AddType_Click(sender As Object, e As EventArgs)
        Dim f As New frm_Addtype  'this is an object calling a form

    End Sub


    Private Sub txt_Quant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Quant.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            If cmb_ProductType.SelectedIndex = -1 Then
                ToolTip1.Show("Select product category", cmb_ProductType, 2000)
                cmb_ProductType.Focus()
            ElseIf txt_ProductName.Text = "" Then
                ToolTip1.Show("This field is required", txt_ProductName, 2000)
                txt_ProductName.Focus()

            ElseIf txt_Price.Text = "" Then
                ToolTip1.Show("This field is required", txt_Price, 2000)
                txt_Price.Focus()

            ElseIf txt_Quant.Text = "" Then
                ToolTip1.Show("This field is required", txt_Quant, 2000)
                txt_Quant.Focus()

            Else
                insertProduct()


            End If
        End If
    End Sub


    Public Sub insertProduct()

        Dim check As String = "NO"
        If checkHide.Checked = True Then
            check = "YES"
        End If
        Try
            Dim cmd As MySqlCommand
            con.Close()
            con.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"


            con.Open()



            Dim login As String = "INSERT INTO `product`(`Product_ID`, `Pro_Name`,`type`, `instock`, `Price`,`date`,`catID`,`selling_price`, `hide`, `Average_Quantity`, `New_Quant_Added`, `Date_Updated`) VALUES
                                                        ('" & txt_ProductID.Text & "', 
                                                        '" & (txt_ProductName.Text).ToUpper & "',
                                                        '" & cmbCatID.Text & "',
                                                        '" & txt_Quant.Text & "', 
                                                        '" & txt_Price.Text & "',
                                                        '" & DateTime.Now & "',
                                                        '" & cmbCatID.Text & "',
                                                        '" & txt_UnitPrice.Text & "',
                                                        '" & check & "',
                                                        '" & txt_Ave_Qty.Text & "',
                                                        '" & txt_Quant.Text & "',
                                                        '" & DateTime.Now & "')"

            cmd = New MySqlCommand(login, con)

            Dim reader = cmd.ExecuteNonQuery

            MsgBox("Product added Successfully")

            con.Close()
            clearMe()

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally

            con.Dispose()

            genrateID()

        End Try
    End Sub

    Public Sub genrateID()
        Dim conString As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT * FROM  product"

        count = 0
        Dim number As String = ""
        Dim cmd As MySqlCommand


        Using conn As New MySqlConnection(conString)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query

                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        count += 1
                    End While
                Catch ex As Exception

                Finally
                    conn.Close()

                End Try
            End Using
        End Using




        If count < 10 Then
            number = "000"
        ElseIf count < 100 Then
            number = "00"
        ElseIf count < 1000 Then
            number = "0"
        End If

        count += 1

        Dim proId As String = "PRD" + number + count.ToString

        Dim queryex As String = "SELECT * FROM  product where Product_ID = '" + proId + "'"

        cmd = New MySqlCommand(queryex, con)

        Using conn As New MySqlConnection(conString)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = queryex

                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        count += 1
                    End While
                Catch ex As Exception

                Finally
                    conn.Close()

                End Try
            End Using
        End Using

        proId = "PRD" + number + count.ToString

        txt_ProductID.Text = proId
    End Sub



    Public Sub clearMe()
        txt_Quant.Clear()
        txt_ProductName.Clear()
        txt_ProductID.Clear()
        txt_Price.Clear()
        cmb_ProductType.Text = ""
        txt_ProductName.Focus()
        txt_UnitPrice.Clear()
        txt_Ave_Qty.Clear()

        genrateID()
    End Sub
    Private Sub frmAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genrateID()
        data_fill_Product_type()
        cmb_ProductType.SelectedIndex = 0
        txt_ProductName.Focus()
    End Sub

    Public Sub data_fill_Product_type()

        Dim conString As String = "server=localhost;user id=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT * FROM producttype"

        Using conn As New MySqlConnection(conString)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query

                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        cmb_ProductType.Items.Add(reader.Item("category"))
                        cmbCatID.Items.Add(reader("catID"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        clearMe()
    End Sub

    Private Sub btn_addProduct_Click(sender As Object, e As EventArgs) Handles btn_addProduct.Click
        If cmb_ProductType.SelectedIndex = -1 Then
            ToolTip1.Show("Select product category", cmb_ProductType, 2000)
            cmb_ProductType.Focus()
        ElseIf txt_ProductName.Text = "" Then
            ToolTip1.Show("This field is required", txt_ProductName, 2000)
            txt_ProductName.Focus()

        ElseIf txt_Price.Text = "" Then
            ToolTip1.Show("This field is required", txt_Price, 2000)
            txt_Price.Focus()

        ElseIf txt_Quant.Text = "" Then
            ToolTip1.Show("This field is required", txt_Quant, 2000)
            txt_Quant.Focus()
        Else
            Try
                Dim x As Decimal = Convert.ToDecimal(txt_Price.Text)
                Dim y As Decimal = Convert.ToDecimal(txt_UnitPrice.Text)

                If x < y Then
                    MsgBox("Your selling price cant be smaller than cost price !!", MsgBoxStyle.Critical)
                Else
                    genrateID()

                    insertProduct()
                End If
            Catch ex As Exception

            End Try




        End If

    End Sub

    Private Sub cmb_ProductType_SelectedIndexChanged(sender As Object, e As EventArgs)
        cmbCatID.Text = cmbCatID.Items(cmb_ProductType.SelectedIndex)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub cmb_ProductType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_ProductType.SelectedIndexChanged
        cmbCatID.Text = cmbCatID.Items(cmb_ProductType.SelectedIndex)
        txt_ProductName.Focus()


    End Sub

    Private Sub txt_Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Price.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) = 46 Then

                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txt_UnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txt_UnitPrice_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txt_UnitPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) = 46 Then

                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txt_Ave_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Ave_Qty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class