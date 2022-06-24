Imports MySql.Data.MySqlClient
Public Class Frm_ListOfProduct
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        colorClear()
        Me.Close()
    End Sub

    Public Sub load_Data_GridAll()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection(connstring)
        con.Open()

        ada = New MySqlDataAdapter("SELECT `Product_ID`, `Pro_Name`, `instock`, `Price`, `selling_price`,`New_Quant_Added`, `Date_Updated` FROM `product`", con)
        ada.Fill(ds)
        dgv_Peoduct.DataSource = ds.Tables(0)
    End Sub

    Public Sub load_Data_Grid()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection(connstring)
        con.Open()

        ada = New MySqlDataAdapter("SELECT `Product_ID`, `Pro_Name`, `instock`, `Price`, `selling_price`,`New_Quant_Added`, `Date_Updated` FROM `product` WHERE hide = 'NO'", con)
        ada.Fill(ds)
        dgv_Peoduct.DataSource = ds.Tables(0)
    End Sub

    Private Sub frm_ListOfProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data_Grid()
        ProductDetails()
    End Sub

    Public Sub ProductDetails()
        Dim conStringg As String = connstring
        cmb_ProductName.Items.Clear()
        Dim query As String


        query = "SELECT Pro_Name FROM product WHERE hide = 'NO'"


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
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using

    End Sub

    Public Sub ProductDetailsAll()
        Dim conStringg As String = connstring
        cmb_ProductName.Items.Clear()
        Dim query As String


        query = "SELECT Pro_Name FROM product"


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
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using

    End Sub
    Public Sub loadSelected()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection(connstring)
        con.Open()

        ada = New MySqlDataAdapter("SELECT `Product_ID`, `Pro_Name`, `instock`, `Price`, `selling_price`,`New_Quant_Added`, `Date_Updated` FROM `product` WHERE `Pro_Name` ='" + cmb_ProductName.Text + "' AND hide = 'NO'", con)
        ada.Fill(ds)
        dgv_Peoduct.DataSource = ds.Tables(0)
    End Sub

    Public Sub loadSelectedAll()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection(connstring)
        con.Open()

        ada = New MySqlDataAdapter("SELECT `Product_ID`, `Pro_Name, `instock`, `Price`, `selling_price`,`New_Quant_Added`, `Date_Updated` FROM `product` WHERE `Pro_Name` ='" + cmb_ProductName.Text + "'", con)
        ada.Fill(ds)
        dgv_Peoduct.DataSource = ds.Tables(0)
    End Sub

    Private Sub cmb_ProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ProductName.SelectedIndexChanged
        loadSelected()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Dim ans As DialogResult = MsgBox("Do You Want To  Delete the selected Product? ", MsgBoxStyle.YesNo, "Deleting A Product")

        If ans = DialogResult.Yes Then
            Delete_Product()
        End If
    End Sub
    Public Sub Delete_Product()
        Dim ans As DialogResult = MsgBox("Do You Want To  Delete this product? ", MsgBoxStyle.YesNo, "Exit System")

        If ans = DialogResult.Yes Then
            Dim command As MySqlCommand
            Dim insertString_EmpDetiles As String = ""
            Dim connection = New MySqlConnection

            connection.ConnectionString = connstring

            Try
                connection.Open()

                insertString_EmpDetiles = "DELETE FROM `product` WHERE `Product_ID`='" + lblPid.Text + "'"

                command = New MySqlCommand(insertString_EmpDetiles, connection)
                command.ExecuteNonQuery()

                MsgBox("Product Successfully Deleted", MsgBoxStyle.Information)

                connection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                connection.Dispose()
            End Try
            load_Data_Grid()
            ProductDetails()
        End If

    End Sub

    Private Sub dgv_Peoduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Peoduct.CellContentClick
        Dim pid As Integer
        pid = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgv_Peoduct.Rows(pid)


        lblPid.Text = selectedRow.Cells(0).Value.ToString
    End Sub

    Private Sub chkHide_CheckedChanged(sender As Object, e As EventArgs) Handles chkHide.CheckedChanged
        If chkHide.Checked = True Then
            load_Data_GridAll()
            ProductDetailsAll()
        Else
            load_Data_Grid()
            ProductDetails()
        End If
    End Sub
End Class