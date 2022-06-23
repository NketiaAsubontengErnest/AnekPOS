Imports MySql.Data.MySqlClient
Module GlobalConfig
    Public query As String
    Public cmd As MySqlCommand
    Public adapter As MySqlDataAdapter
    Public reader As MySqlDataReader
    Public conn As MySqlConnection
    Public connstring As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"



    Public Sub openConnection()
        conn = New MySqlConnection(connstring)
        Try
            If (conn.State = ConnectionState.Closed) Then
                conn.Open()

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())

        End Try
    End Sub



End Module
