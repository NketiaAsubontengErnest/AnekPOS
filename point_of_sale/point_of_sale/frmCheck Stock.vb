﻿Imports MySql.Data.MySqlClient

Public Class frmCheck_Stock
    Private Sub frmCheck_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInstock()
        loadOutStock()
        txtNewQuant.Text = 0

        FillItem()

    End Sub

    Public Sub loadOutStock()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection("server=localhost;userid=root;password=0554013980A@;database=point_of_sale")
        con.Open()

        ada = New MySqlDataAdapter("Select Product_ID,Pro_Name,instock FROM product WHERE 
                                   `instock` < `Average_Quantity`", con)
        ada.Fill(ds)
        dgvOutStock.DataSource = ds.Tables(0)
        countOutStock()
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

    Public Sub loadInstock()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection("server=localhost;userid=root;password=0554013980A@;database=point_of_sale")
        con.Open()

        ada = New MySqlDataAdapter("Select Product_ID,Pro_Name,instock FROM product WHERE 
                                   instock > '0'", con)
        ada.Fill(ds)
        dgvInstock.DataSource = ds.Tables(0)
    End Sub

    Private Sub dgvInstock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstock.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvInstock.Rows(e.RowIndex)
            txtPID.Text = row.Cells(0).Value.ToString
            txtQuantity.Text = row.Cells(0).Value.ToString
            cmbName.Text = row.Cells(1).Value.ToString
            txtQuantity.Text = row.Cells(2).Value.ToString
        End If
    End Sub

    Private Sub dgvOutStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOutStock.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvInstock.Rows(e.RowIndex)
            txtQuantity.Text = row.Cells(0).Value.ToString
            cmbName.Text = row.Cells(1).Value.ToString
            txtQuantity.Text = row.Cells(2).Value.ToString
        End If
    End Sub

    Public Sub updateProducts()
        Dim A As Integer = 0

        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

        Try
            If txtNewQuant.Text = "" Then
                txtNewQuant.Text = 0
            End If
            Dim quant As Integer = Convert.ToInt64(txtQuantity.Text) + Convert.ToInt64(txtNewQuant.Text)
            connection.Open()
            insertString_EmpDetiles = "Update `product` Set `Product_ID` = '" & txtPID.Text & "', `Pro_Name`='" & cmbName.Text & "', `instock`='" & quant & "', `Price`='" & txtPrice.Text & "', `selling_price`='" & txt_CostPrice.Text & "', `Average_Quantity`='" & txtAveQty.Text & "',`New_Quant_Added`='" & txtNewQuant.Text & "', `Date_Updated`='" & Convert.ToString(DateTime.Now) & "' WHERE `Product_ID`='" & cmbID.Text & "'"
            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            connection.Close()

            MsgBox("Product Updated")
            txtNewQuant.Text = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try

    End Sub

    Public Sub FillItem()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "Select Product_ID,Pro_Name,instock FROM product "

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
                        cmbID.Items.Add(reader("Product_ID"))
                        cmbName.Items.Add(reader("Pro_Name"))
                    End While

                    If reader.Read Then


                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Public Sub FillDetails()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "Select Product_ID, Pro_Name, instock, Price, Average_Quantity, selling_price FROM product WHERE Product_ID='" + cmbID.Text + "' order by ID desc"

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
                        txtQuantity.Text = reader("instock")
                        txtPrice.Text = reader("Price")
                        txt_CostPrice.Text = reader("selling_price")
                        txtAveQty.Text = reader("Average_Quantity")

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Private Sub cmbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbName.SelectedIndexChanged
        cmbID.Text = cmbID.Items(cmbName.SelectedIndex)
        txtPID.Text = cmbID.Text
        FillDetails()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(cmbName.Text) Then
            MsgBox("SELECT A PRODUCT TO UPDATE!!", MsgBoxStyle.Critical)
        Else
            updateProducts()
        End If
        loadInstock()
        loadOutStock()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub cmbName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbName.KeyPress
        Dim conn = New MySqlConnection
        With Me.cmbName

            Dim ToFind As String = .Text.Substring(0, .SelectionStart) & e.KeyChar
            Dim Index As Integer = .FindStringExact(ToFind)

            If Index = -1 Then Index = .FindString(ToFind)
            If Index = -1 Then Return

            .SelectedIndex = Index
            .SelectionStart = ToFind.Length
            .SelectionLength = .Text.Length - .SelectionStart

            e.Handled = True

            Try
                conn = New MySqlConnection("server=localhost;userid=root;password=0554013980A@;database=point_of_sale")
                conn.Open()
                Dim cmd1 As New MySqlCommand("SELECT Product_ID,Pro_Name,instock FROM `product` WHERE `Pro_Name`='" & cmbName.Text & "'", conn)
                Dim da1 As New MySqlDataAdapter
                Dim dt1 As New DataTable

                da1.SelectCommand = cmd1

                dt1.Clear()
                da1.Fill(dt1)
                dgvInstock.DataSource = dt1

                conn.Close()
            Catch ex As Exception
                MsgBox("Error: " + ex.Message,, MsgBoxStyle.Exclamation)

            End Try
        End With
    End Sub

    Private Sub cmbID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbID.SelectedIndexChanged
        txtPID.Text = cmbID.Text
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) = 46 Then

                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txt_CostPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CostPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) = 46 Then

                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtAveQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAveQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNewQuant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewQuant.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class