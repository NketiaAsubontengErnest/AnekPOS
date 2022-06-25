Imports MySql.Data.MySqlClient
Module QueriesModel
    Dim connection = connstring
    Public CompanyName1 As String
    Public CompanyPhone1 As String
    Public CompanyPhone2 As String
    Public CompanyPhone3 As String
    Public CompanyAddress As String
    Public CompanyLocation As String
    Public CompanyEmail As String
    Public Country As String
    Function Inserting(newQuery As String) As MySqlDataReader
        connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.close
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
        connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.close
            connection.Open()

            cmd = New MySqlCommand(newQuery, connection)

            reader = cmd.ExecuteReader

            connection.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            connection.close
            connection.Dispose()

        End Try

        Return reader
    End Function

    Function CheckExist(newQuery As String) As Boolean
        Dim conString As String = connstring
        Dim count As Integer = 0
        Dim bool As Boolean = False
        Using conn As New MySqlConnection(conString)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = newQuery
                End With
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader
                    While reader.Read
                        count += 1
                    End While
                    If count > 0 Then
                        bool = True
                    End If
                Catch ex As Exception
                End Try
            End Using
        End Using
        Return bool
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
    Function Load_Data_Grid(newQuery As String) As DataSet
        Dim con As MySqlConnection
        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection(connstring)
        con.Close()
        con.Open()

        ada = New MySqlDataAdapter(newQuery, con)
        ada.Fill(ds)
        Return ds
    End Function

    Public Sub LoadCompanyDetails()
        Dim conString As String = connstring
        query = "SELECT * FROM companydetails order by id desc"
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
                        CompanyName1 = reader("CompanyName")
                        CompanyPhone1 = reader("CompanyPhone1")
                        CompanyPhone2 = reader("CompanyPhone2")
                        CompanyPhone3 = reader("CompanyPhone3")
                        CompanyAddress = reader("CompanyAddress")
                        CompanyLocation = reader("CompanyLocation")
                        CompanyEmail = reader("CompanyEmail")
                        Country = reader("Country")
                        'PicCompanyLogo.Image = reader("CompanyLog")
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Module
