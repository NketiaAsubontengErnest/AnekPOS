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
    Public Companyid As String
    Public CompanyLogo As String
    Public folder = "c:\ANEK IT CONSULT\ANEK POS"

    'Queries
    Public dailysalesTable As String = "
                              USE point_of_sale;
                              CREATE TABLE IF NOT EXISTS `dailysales` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `employeeID` varchar(10) NOT NULL,
                              `totalSales` decimal(11,2) NOT NULL,
                              `date` varchar(10) NOT NULL,
                              `datePrepared` varchar(20) NOT NULL,
                              `isClosed` varchar(5) NOT NULL DEFAULT 'No',
                              PRIMARY KEY (`ID`)
                            );"


    Public employeeTable As String = "
                            USE point_of_sale;
                            CREATE TABLE IF NOT EXISTS `employee` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `employeeID` varchar(10) NOT NULL,
                              `name` varchar(35) NOT NULL,
                              `Phone` varchar(15) NOT NULL,
                              `address` varchar(50) NOT NULL,
                              `position` varchar(8) NOT NULL,
                              `block` varchar(3) NOT NULL,
                              PRIMARY KEY (`ID`),
                              UNIQUE KEY `employeeID` (`employeeID`)
                            );

                            INSERT INTO `employee` IF NOT (`ID`, `employeeID`, `name`, `Phone`, `address`, `position`, `block`) VALUES
                            (0, 'guest', 'ANEK IT CONSULT', '0554013980', 'nketiaernest18@gmail.com', 'Guest', 'NO');"

    Public loginTable As String = "
                            USE point_of_sale;
                            CREATE TABLE IF NOT EXISTS `login` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `employeeID` varchar(10) NOT NULL,
                              `password` varchar(300) NOT NULL,
                              `position` varchar(20) NOT NULL,
                              `block` varchar(3) NOT NULL,
                              PRIMARY KEY (`ID`),
                              UNIQUE KEY `employeeID` (`employeeID`)
                            );

                            INSERT INTO `login` (`ID`, `employeeID`, `password`, `position`, `block`) VALUES
                            (0, 'guest', 'guest', 'guest', 'NO');"


    Public productTable As String = " 
                            USE point_of_sale;
                            CREATE TABLE IF NOT EXISTS `product` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `Product_ID` varchar(100) NOT NULL,
                              `Pro_Name` varchar(50) NOT NULL,
                              `instock` int(11) NOT NULL,
                              `Price` decimal(11,2) NOT NULL,
                              `date` varchar(25) NOT NULL,
                              `catID` varchar(10) NOT NULL,
                              `selling_price` decimal(11,2) NOT NULL,
                              `hide` varchar(3) NOT NULL,
                              `Average_Quantity` int(11) NOT NULL,
                              `New_Quant_Added` int(11) NOT NULL,
                              `Date_Updated` varchar(25) NOT NULL,
                              `quant_soldq` int(11) DEFAULT '0',
                              `tot_num_add` int(11) DEFAULT '0',
                              PRIMARY KEY (`ID`),
                              UNIQUE KEY `Product_ID` (`Product_ID`)
                            );"

    Public producttypeTable As String = " 
                            USE point_of_sale;
                            CREATE TABLE IF NOT EXISTS `producttype` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `catID` varchar(10) NOT NULL,
                              `category` varchar(1000) NOT NULL,
                              PRIMARY KEY (`ID`)
                            );"

    Public salesTable As String = "
                            USE point_of_sale;
                            CREATE TABLE IF NOT EXISTS `sales` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `item` varchar(50) NOT NULL,
                              `Qty` int(11) NOT NULL,
                              `price` decimal(11,2) NOT NULL,
                              `amount` decimal(11,2) NOT NULL,
                              `trackRec` varchar(50) NOT NULL,
                              `employeeID` varchar(10) NOT NULL,
                              `date` varchar(25) NOT NULL,
                              `month` varchar(10) NOT NULL,
                              `profit` decimal(11,2) NOT NULL,
                              `Gen_Mount` varchar(2) NOT NULL,
                              `hide` varchar(3) NOT NULL,
                              PRIMARY KEY (`ID`)
                            );"

    Public companydetailsTable As String = "
                            USE point_of_sale;
                            CREATE TABLE IF NOT EXISTS `companydetails` (
                              `id` int(11) NOT NULL AUTO_INCREMENT,
                              `CompanyName` varchar(100) NOT NULL,
                              `CompanyPhone1` varchar(50) NOT NULL,
                              `CompanyPhone2` varchar(50) DEFAULT NULL,
                              `CompanyPhone3` varchar(45) DEFAULT NULL,
                              `CompanyAddress` varchar(200) DEFAULT NULL,
                              `CompanyLocation` varchar(200) NOT NULL,
                              `CompanyEmail` varchar(100) DEFAULT NULL,
                              `Country` varchar(50) NOT NULL,
                              `CompanyLog` varchar(100) DEFAULT NULL,
                              PRIMARY KEY (`id`)
                            );
                            "
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

    Function SelectingCount(newQuery As String) As Integer
        connection = New MySqlConnection
        Dim count
        connection.ConnectionString = connstring

        Try
            connection.close
            connection.Open()

            cmd = New MySqlCommand(newQuery, connection)

            reader = cmd.ExecuteReader
            While reader.Read
                count += 1
            End While

            connection.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            connection.close
            connection.Dispose()

        End Try

        Return count
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
        query = "SELECT * FROM companydetails order by id desc limit 1"
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
                        Companyid = reader("id")
                        CompanyName1 = reader("CompanyName")
                        CompanyPhone1 = reader("CompanyPhone1")
                        CompanyPhone2 = reader("CompanyPhone2")
                        CompanyPhone3 = reader("CompanyPhone3")
                        CompanyAddress = reader("CompanyAddress")
                        CompanyLocation = reader("CompanyLocation")
                        CompanyEmail = reader("CompanyEmail")
                        Country = reader("Country")
                        CompanyLogo = reader("CompanyLog")
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Public Sub CreateFolder()
        If Not System.IO.Directory.Exists(folder) Then
            System.IO.Directory.CreateDirectory(folder)
        End If
    End Sub

    Function DoesDBExist(DBConnectionString As String) As Boolean

        Dim conn As MySqlConnection = New MySqlConnection(DBConnectionString)
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT IF(EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'point_of_sale'), 'Y','N') as exixt", conn)

        conn.Open()
        Dim read As String = cmd.ExecuteNonQuery()

        Dim exists As String = cmd.ExecuteScalar().ToString()
        conn.Close()
        Return If(exists = "Y", True, False)
    End Function
    Public Sub createDatabase()
        splash.lblCreateD.Visible = True
        Try
            Dim con As MySqlConnection = New MySqlConnection("server=" & DBserver & ";userid=" & DBuserids & ";password=" & DBpassword & ";")
            con.Open()
            query = "CREATE DATABASE point_of_sale;"
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)

            cmd.ExecuteNonQuery()
            con.Close()
            createTables()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            splash.Close()
        End Try
    End Sub
    Sub createTables()
        Dim Tablenames() As Object = {dailysalesTable, employeeTable, loginTable, productTable, producttypeTable, salesTable, companydetailsTable}
        Dim con As MySqlConnection = New MySqlConnection(connstring)
        For i As Int16 = 0 To Tablenames.Length - 1
            Try
                con.Open()
                Dim cmd As New MySqlCommand(Tablenames(i), con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        Next

    End Sub

    Sub AlterTables(tablename As String, colname As String, datatype As String, typevalue As String)
        Dim Tablenames() As Object = {dailysalesTable, employeeTable, loginTable, productTable, producttypeTable, salesTable, companydetailsTable}
        query = "ALTER TABLE" & tablename & "ADD COLUMN IF NOT EXISTS" & colname & datatype & "(" & typevalue & ")"
        Dim con As MySqlConnection = New MySqlConnection(connstring)
        For i As Int16 = 0 To Tablenames.Length - 1
            Try
                con.Open()
                Dim cmd As New MySqlCommand(query, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        Next

    End Sub



End Module
