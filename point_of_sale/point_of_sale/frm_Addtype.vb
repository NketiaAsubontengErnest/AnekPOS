Imports MySql.Data.MySqlClient

Public Class frm_Addtype

    Public Sub insertProduct()

        Dim command1 As MySqlCommand
        Dim insertString_login As String
        Dim connection = New MySqlConnection

        connection.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

        Try
            connection.Open()
            insertString_login = "INSERT INTO `producttype` (`catID`, `category`) VALUES 
                                                           ('" & txt_CatID.Text & "',
                                                           '" & txt_CatName.Text & "')"

            command1 = New MySqlCommand(insertString_login, connection)

            Dim reader = command1.ExecuteReader

            connection.Close()

        Catch ex As MySqlException
            'MsgBox(ex)
        Finally

            connection.Dispose()

        End Try
        genrateID()
        txt_CatName.Clear()
    End Sub

    Public Sub genrateID()
        Dim conString As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT * FROM producttype"

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

        txt_CatID.Text = "Cat" + number + count.ToString
    End Sub

    Private Sub frm_Addtype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genrateID()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If Not txt_CatName.Text = "" Then
            insertProduct()
        Else
            ToolTip1.Show("Required field", txt_CatName, 2000)
        End If

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub txt_CatName_TextChanged(sender As Object, e As EventArgs) Handles txt_CatName.TextChanged

    End Sub

    Private Sub txt_CatName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CatName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Not txt_CatName.Text = "" Then
                insertProduct()
            Else
                ToolTip1.Show("Required field", txt_CatName, 2000)
            End If
        End If

        txt_CatName.Focus()

    End Sub

    Private Sub btn_Close_Click_1(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class