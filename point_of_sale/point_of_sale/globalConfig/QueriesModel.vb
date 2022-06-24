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

    Function Updating(newQuery As String) As MySqlDataReader
        Try
            conn = New MySqlConnection(connstring)
            conn.Open()

            cmd = New MySqlCommand(newQuery, conn)

        Catch ex As Exception
            MsgBox("Fatal Error -> Database Not Reacheable")
        End Try
        reader = cmd.ExecuteReader
        conn.Close()
        Return reader
    End Function


    Function IsClosed(id As String) As Boolean
        Dim conStringg As String = connstring
        Dim query As String = "SELECT isClosed from dailysales where employeeID='" + id + "'
                              AND date='" + Date.Now.ToString("dd/MM/yyyy") + "'"

        Dim ACCclosed As Boolean = False

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
                        ACCclosed = True
                    Else
                        ACCclosed = False
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using

        Return ACCclosed
    End Function

End Module
