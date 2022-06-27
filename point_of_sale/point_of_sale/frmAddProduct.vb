Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FrmAddProduct
    Private Sub txt_Quant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Quant.KeyPress
        e.Handled = ValidateNumbers(e)

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
                InsertProduct()


            End If
        End If
    End Sub



    Public Sub InsertProduct()

        If CheckExist("SELECT * FROM product where Pro_Name = '" + (txt_ProductName.Text).ToUpper + "'") Then
            MsgBox("Product Already Exist", MsgBoxStyle.Critical)
        Else
            Dim check As String = "NO"
            If checkHide.Checked = True Then
                check = "YES"
            End If
            query = "INSERT INTO `product`(`Product_ID`, `Pro_Name`, `instock`, `Price`,`date`,`catID`,`selling_price`, `hide`, `Average_Quantity`, `New_Quant_Added`, `Date_Updated`) VALUES
                                                        ('" & txt_ProductID.Text & "', 
                                                        '" & (txt_ProductName.Text).ToUpper & "',
                                                        '" & txt_Quant.Text & "', 
                                                        '" & txt_Price.Text & "',
                                                        '" & DateTime.Now & "',
                                                        '" & cmbCatID.Text & "',
                                                        '" & txt_UnitPrice.Text & "',
                                                        '" & check & "',
                                                        '" & txt_Ave_Qty.Text & "',
                                                        '" & txt_Quant.Text & "',
                                                        '" & DateTime.Now & "')"

            reader = Inserting(query)
            Try
                If reader.RecordsAffected > 0 Then
                    MsgBox("Product added Successfully", MsgBoxStyle.Information)
                    ClearMe()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        genrateID()
    End Sub

    Public Sub genrateID()
        query = "SELECT * FROM  product"

        Dim count As Integer = 0
        Dim number As String = ""
        Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        count = SelectingCount(query)
        Dim sb As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 7
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i
        count += 1

        Dim proId As String = "P" + sb.ToString() + count.ToString
        check_id(proId, sb.ToString(), count)

    End Sub

    Public Sub check_id(ByVal proId As String, ByVal Number As String, ByVal oldc As Integer)
        Dim count As Integer
        Dim conString As String = connstring

        query = "SELECT * FROM  product where Product_ID = '" + proId + "'"
        count = SelectingCount(query)
        If count > 0 Then
            oldc += 1
            proId = "PRD" + Number + oldc.ToString
            check_id(proId, Number, count)
        Else

            txt_ProductID.Text = proId
        End If
    End Sub
    Public Sub ClearMe()
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

        Dim conString As String = connstring
        query = "SELECT * FROM producttype"

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
        ClearMe()
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

                    InsertProduct()
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub cmb_ProductType_SelectedIndexChanged(sender As Object, e As EventArgs)
        cmbCatID.Text = cmbCatID.Items(cmb_ProductType.SelectedIndex)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        ColorClear()
        Me.Close()

    End Sub

    Private Sub cmb_ProductType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_ProductType.SelectedIndexChanged
        cmbCatID.Text = cmbCatID.Items(cmb_ProductType.SelectedIndex)
        txt_ProductName.Focus()
    End Sub

    Private Sub txt_Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Price.KeyPress
        e.Handled = ValidateMoney(e)
    End Sub
    Private Sub txt_UnitPrice_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txt_UnitPrice.KeyPress
        e.Handled = ValidateMoney(e)
    End Sub

    Private Sub txt_Ave_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Ave_Qty.KeyPress
        e.Handled = ValidateNumbers(e)
    End Sub
End Class