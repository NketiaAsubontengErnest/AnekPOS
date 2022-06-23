Imports System.IO
Imports MySql.Data.MySqlClient
Public Class User_Lists
    Private Block As String
    Private Sub User_Lists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data_Grid()
    End Sub

    Public Sub load_Data_Grid()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection(connstring)
        con.Open()

        ada = New MySqlDataAdapter("SELECT `employeeID`, `name`, `Phone`, `address`, `position`,`block` FROM `employee`", con)
        ada.Fill(ds)
        dgvUsers.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

    End Sub
    Public Sub clear()
        txt_Name.Clear()
        txt_Phone.Clear()
        txt_UserID.Clear()
        txt_UserID.Focus()
        txt_Address.Clear()
        cmd_position.Text = ""
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Update_User()
        Update_login()
        load_Data_Grid()
    End Sub

    Public Sub Update_User()
        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()
            insertString_EmpDetiles = "UPDATE `login` SET `position`='" + cmd_position.Text + "' WHERE `employeeID`='" + txt_UserID.Text + "'"
            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            MsgBox("Account Successfully Updated", MsgBoxStyle.Information)

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try

    End Sub

    Public Sub Block_User_login()
        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()
            If btnBlock.Text = "Unblock" Then
                insertString_EmpDetiles = "UPDATE `login` SET `block`= 'NO' WHERE `employeeID`='" + txt_UserID.Text + "'"
            Else
                insertString_EmpDetiles = "UPDATE `login` SET `block`= 'YES' WHERE `employeeID`='" + txt_UserID.Text + "'"
            End If
            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            'MsgBox("Account Successfully Updated", MsgBoxStyle.Information)

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try
    End Sub

    Public Sub Block_User_Emp()
        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()
            If btnBlock.Text = "Unblock" Then
                insertString_EmpDetiles = "UPDATE `employee` SET `block`= 'NO' WHERE `employeeID`='" + txt_UserID.Text + "'"
            Else
                insertString_EmpDetiles = "UPDATE `employee` SET `block`= 'YES' WHERE `employeeID`='" + txt_UserID.Text + "'"
            End If
            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            MsgBox("Account Successfully Blocked", MsgBoxStyle.Information)

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try



    End Sub

    Public Sub Update_login()
        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try


            connection.Open()
            insertString_EmpDetiles = "UPDATE `employee` SET `name`='" + txt_Name.Text + "',`Phone`='" + txt_Phone.Text + "',`address`='" + txt_Address.Text + "',`position`='" + cmd_position.Text + "' WHERE `employeeID`='" + txt_UserID.Text + "'"
            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            MsgBox("Account Successfully Updated", MsgBoxStyle.Information)

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try

    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        Dim uid As Integer
        uid = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvUsers.Rows(uid)


        txt_UserID.Text = selectedRow.Cells(0).Value.ToString
        txt_Name.Text = selectedRow.Cells(1).Value.ToString
        txt_Phone.Text = selectedRow.Cells(2).Value.ToString
        txt_Address.Text = selectedRow.Cells(3).Value.ToString
        cmd_position.Text = selectedRow.Cells(4).Value.ToString
        Block = selectedRow.Cells(5).Value.ToString

        If Block = "YES" Then
            btnBlock.Text = "Unblock"
        Else
            btnBlock.Text = "Block"
        End If
    End Sub

    Private Sub btnBlock_Click(sender As Object, e As EventArgs) Handles btnBlock.Click
        Block_User_login()
        Block_User_Emp()
        load_Data_Grid()
    End Sub

    Public Sub Delete_User_Emp()
        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()

            insertString_EmpDetiles = "DELETE FROM `employee` WHERE `employeeID`='" + txt_UserID.Text + "'"

            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            MsgBox("Account Successfully Deleted", MsgBoxStyle.Information)

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try
    End Sub

    Public Sub Delete_User_login()
        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()
            insertString_EmpDetiles = "DELETE FROM `login`  WHERE `employeeID`='" + txt_UserID.Text + "'"

            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            'MsgBox("Account Successfully Updated", MsgBoxStyle.Information)

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete_User_login()
        Delete_User_Emp()
    End Sub
End Class