Imports MySql.Data.MySqlClient

Public Class Frm_ChanegePassword
    Private conn As MySqlConnection
    Private command As MySqlCommand
    Private reader As MySqlDataReader
    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        If txt_NewPassword.Text = txt_confPassword.Text Then
            checkCurrentPass()
            clearHere()
        Else
            MsgBox("New Password and Confirm Password do Not Match!!!", MsgBoxStyle.Critical)
            clearHere()
        End If
    End Sub

    Private Sub btn_SaveChanges_Click()
        Try
            conn = New MySqlConnection(connstring)
            conn.Open()

            command = New MySqlCommand("Update `login` Set `Password` = '" + Encrypt(txt_NewPassword.Text) + "' WHERE employeeID = '" + txtUserID.Text + "'", conn)

        Catch ex As Exception
            MsgBox("Fatal Error -> Database Not Reacheable")
        End Try

        reader = command.ExecuteReader

        MsgBox("Password Changed Successfully")

        conn.Close()
        reader.Close()

    End Sub

    ''' <summary>
    ''' compare the current password in the database to entered password
    ''' </summary>
    ''' <returns></returns>
    Public Function checkCurrentPass()
        Dim conString As String = connstring
        Dim query As String
        query = "SELECT * FROM login WHERE employeeID = '" + txtUserID.Text + "'"

        Dim correct As Boolean = True
        Dim password As String = ""

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
                        password = reader.Item("password")
                    End While
                    Dim pass As String = Decrypt(password)
                    conn.Close()
                    reader.Close()
                    If pass = txt_currentPassword.Text Then
                        btn_SaveChanges_Click()
                    Else
                        correct = False
                        MsgBox("Old password Invalid")
                    End If

                Catch ex As Exception


                End Try
            End Using
        End Using

        Return correct

    End Function
    Private Sub clearHere()
        txt_currentPassword.Clear()
        txt_confPassword.Clear()
        txt_NewPassword.Clear()
    End Sub

    Private Sub frm_ChanegePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Text = frm_AdminDas.lblUserID.Text

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        colorClear()
    End Sub



    Private Sub txt_confPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_confPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txt_NewPassword.Text = txt_confPassword.Text Then
                checkCurrentPass()
                clearHere()
            Else
                ToolTip1.Show("Passwords do not match", txt_confPassword, 2000)
                clearHere()
            End If
        End If
    End Sub
End Class