Imports MySql.Data.MySqlClient
Public Class frm_GenSettings
    Private reader As MySqlDataReader

    Dim ListOfTables As ArrayList = New ArrayList()
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim con As MySqlConnection = New MySqlConnection


    Private Sub btn_ResetAll_Click(sender As Object, e As EventArgs) Handles btn_ResetAll.Click


        Dim ans As DialogResult = MsgBox("Do You Want To Reset the whole system? ", MsgBoxStyle.YesNo, "Confirm Close Account")

        If ans = DialogResult.Yes Then
            ListOfTables.Add("dailysales")
            ListOfTables.Add("employee")
            ListOfTables.Add("login")
            ListOfTables.Add("product")
            ListOfTables.Add("producttype")
            ListOfTables.Add("sales")

            Dim conStringg As String = connstring

            Using con As New MySqlConnection(conStringg)
                con.Open()

                Dim i As Integer = 0

                While i < 6
                    Dim cmd As New MySqlCommand("truncate " + ListOfTables.ToArray.GetValue(i).ToString, con)
                    cmd.ExecuteNonQuery()
                    i += 1
                End While
                insert_to_login()
                insert_to_Empdetails()
                MsgBox("System is reseted!!", MsgBoxStyle.Information)
                ListOfTables.Clear()

            End Using
        ElseIf ans = DialogResult.No Then
            ListOfTables.Clear()
        End If
    End Sub

    Public Sub insert_to_login()

        Dim command1 As MySqlCommand
        Dim insertString_login As String
        con = New MySqlConnection

        con.ConnectionString = connstring

        Try
            con.Open()
            insertString_login = "INSERT INTO `login` (`employeeID`, `password`, `position`, `block`) VALUES 
                                                      ('guest', 
                                                      'guest', 
                                                      'guest',
                                                      'NO')"

            command1 = New MySqlCommand(insertString_login, con)

            command1.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally

            con.Dispose()

        End Try
    End Sub

    Public Sub insert_to_Empdetails()
        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String
        con = New MySqlConnection

        con.ConnectionString = connstring

        Try
            con.Open()
            insertString_EmpDetiles = "INSERT INTO `employee` (`employeeID`, `name`, `phone`, `address`, `position`,`block`) VALUES  
                                                              ('guest', 
                                                              'guest', 
                                                              '0554013980', 
                                                              'ANEK IT CONSULT',
                                                              'guest',
                                                              'NO')"

            command = New MySqlCommand(insertString_EmpDetiles, con)

            command.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally

            con.Dispose()
        End Try
    End Sub

    Private Sub btnResetProType_Click(sender As Object, e As EventArgs) Handles btnResetProType.Click
        resetOne("producttype")
    End Sub

    Public Sub resetOne(ByVal tableName As String)
        Dim ans As DialogResult = MsgBox("Do You Want To Reset " + tableName + "? ", MsgBoxStyle.YesNo, "Confirm Close Account")

        If ans = DialogResult.Yes Then


            Dim conStringg As String = connstring

            Using con As New MySqlConnection(conStringg)
                con.Open()

                Dim cmd As New MySqlCommand("truncate " + tableName, con)
                ' MsgBox("truncate " + tableName + "")
                cmd.ExecuteNonQuery()

                MsgBox(tableName + " is reseted!!", MsgBoxStyle.Information)


            End Using
        ElseIf ans = DialogResult.No Then

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resetOne("dailysales")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        resetOne("sales")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resetOne("product")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        colorClear()
        Me.Close()
    End Sub

    Private Sub btnBack_up_Click(sender As Object, e As EventArgs) Handles btnBack_up.Click
        Try
            With FolderBrowserDialog1
                .SelectedPath = "C:\backup"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim conn As MySqlConnection = New MySqlConnection(connstring)
                    Dim cmd As MySqlCommand = New MySqlCommand
                    cmd.Connection = conn
                    conn.Open()
                    Dim mb As MySqlBackup
                    mb = New MySqlBackup(cmd)
                    mb.ExportToFile(.SelectedPath + "\point_of_sale.sql")
                    conn.Close()
                    MsgBox("Data is backed up to: " + .SelectedPath + " successfully", MsgBoxStyle.Information)

                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

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

            cmd = New MySqlCommand("Update `login` Set `Password` = '" + Encrypt(txt_NewPassword.Text) + "' WHERE employeeID = '" + txtUserID.Text + "'", conn)

        Catch ex As Exception
            MsgBox("Fatal Error -> Database Not Reacheable")
        End Try

        reader = cmd.ExecuteReader

        MsgBox("Password Changed Successfully", MsgBoxStyle.Information)

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

    Private Sub txt_confPassword_TextChanged(sender As Object, e As EventArgs) Handles txt_confPassword.TextChanged

    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click

    End Sub
End Class