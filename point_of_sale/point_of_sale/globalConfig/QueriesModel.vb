Imports MySql.Data.MySqlClient
Module QueriesModel
    Dim connection = connstring
    Function Inserting(newQuery As String) As MySqlDataReader
        connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()

            cmd = New MySqlCommand(newQuery, connection)

            reader = cmd.ExecuteReader

            connection.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally

            connection.Dispose()

        End Try

        Return reader
    End Function

    Function Selecting(newQuery As String) As MySqlDataReader

        Dim conString As String = connstring
        Dim query As String = newQuery

        Using conn As New MySqlConnection(conString)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query

                End With

                Try
                    conn.Open()
                    reader = command.ExecuteReader
                Catch ex As Exception

                Finally
                    conn.Close()

                End Try
            End Using
        End Using

        Return reader
    End Function

    Function Deleting(newQuery As String) 
        openConnection()

        Return 0
    End Function

    Function Updating(newQuery As String)
        openConnection()

        Return 0
    End Function

End Module
