Imports MySql.Data.MySqlClient
Public Class frm_GenSettings
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

            Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

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

        con.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

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

        con.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

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


            Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

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
        Me.Close()
    End Sub

    Private Sub btnBack_up_Click(sender As Object, e As EventArgs) Handles btnBack_up.Click
        Try
            With FolderBrowserDialog1
                .SelectedPath = "C:\backup"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;userid=root;password=0554013980A@;database=point_of_sale")
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

    Private Sub btnChaPass_Click(sender As Object, e As EventArgs) Handles btnChaPass.Click
        frm_ChanegePassword.MdiParent = Me

        frm_ChanegePassword.Show()
    End Sub
End Class