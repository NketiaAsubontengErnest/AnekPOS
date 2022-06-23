Imports MySql.Data.MySqlClient

Public Class frmAddSeler



    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub txt_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Name.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Phone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        clear()

    End Sub

    Public Sub clear()
        txt_Name.Clear()
        txt_Password.Clear()
        txt_Phone.Clear()
        txt_UserID.Focus()
        txt_Address.Clear()
        cmd_position.Text = ""
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        insert_to_Empdetails()
        insert_to_login()
    End Sub
    Public Sub insert_to_login()

        Dim command1 As MySqlCommand
        Dim insertString_login As String
        connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()
            insertString_login = "INSERT INTO `login` (`employeeID`, `password`, `position`, `block`) VALUES 
                                                      ('" & txt_UserID.Text & "', 
                                                      '" & txt_Password.Text & "', 
                                                      '" & cmd_position.Text & "',
                                                      'NO')"

            command1 = New MySqlCommand(insertString_login, connection)

            reader = command1.ExecuteReader

            connection.Close()

            generateID()
            txt_Name.Clear()
            txt_Password.Clear()
            txt_Phone.Clear()
            txt_UserID.Focus()
            txt_Address.Clear()
            cmd_position.Text = ""


        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally

            connection.Dispose()

        End Try
    End Sub

    Public Sub insert_to_Empdetails()
        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String
        connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()
            insertString_EmpDetiles = "INSERT INTO `employee` (`employeeID`, `name`, `phone`, `address`, `position`,`block`) VALUES  
                                                              ('" & txt_UserID.Text & "', 
                                                              '" & txt_Name.Text & "', 
                                                              '" & txt_Phone.Text & "', 
                                                              '" & txt_Address.Text & "',
                                                              '" & cmd_position.Text & "',
                                                              'NO')"

            command = New MySqlCommand(insertString_EmpDetiles, connection)

            reader = command.ExecuteReader
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally

            connection.Dispose()
        End Try
    End Sub

    Private Sub txt_Address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Address.KeyPress
        'If Not (Asc(e.KeyChar) = 8) Then
        '    If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
        '        e.KeyChar = ChrW(0)
        '        e.Handled = True
        '    End If
        'End If
    End Sub

    Public Sub generateID()

        Dim conString As String = connstring
        Dim query As String = "SELECT * FROM `employee`"

        Dim count As Integer = 0
        Dim number As String = ""

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

        txt_UserID.Text = "EMP" + number + count.ToString

    End Sub

    Private Sub frmAddSeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateID()
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

End Class