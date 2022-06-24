Imports MySql.Data.MySqlClient

Public Class splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            frmLogin.Show()
            Me.Close()
        Else
            ProgressBar1.Value += 10
            lblCreateD.Text = "Database Creating " + (ProgressBar1.Value).ToString + " %"
        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As String = "server=localhost;user id=root;password=0554013980A@;"
        Dim mey = DoesDBExist(conn)
        If mey.ToString = "True" Then

        Else
            createDatabase()
        End If

        Timer1.Start()
    End Sub
    Function DoesDBExist(DBConnectionString As String) As Boolean

        Dim conn As MySqlConnection = New MySqlConnection(DBConnectionString)
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT IF(EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'point_of_sale'), 'Y','N') as exixt", conn)

        conn.Open()
        Dim read As String = cmd.ExecuteNonQuery()

        Dim exists As String = cmd.ExecuteScalar().ToString()
        Console.WriteLine(exists)
        conn.Close()
        Return If(exists = "Y", True, False)

    End Function

    Private Sub createDatabase()
        lblCreateD.Visible = True
        Try
            Dim con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=0554013980A@;")
            con.Open()
            Dim query As String = "
                            CREATE DATABASE point_of_sale;

                            use point_of_sale;

                            CREATE TABLE IF NOT EXISTS `dailysales` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `employeeID` varchar(10) NOT NULL,
                              `totalSales` decimal(11,2) NOT NULL,
                              `date` varchar(10) NOT NULL,
                              `datePrepared` varchar(20) NOT NULL,
                              `isClosed` varchar(5) NOT NULL DEFAULT 'No',
                              PRIMARY KEY (`ID`)
                            );


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

                            INSERT INTO `employee` (`ID`, `employeeID`, `name`, `Phone`, `address`, `position`, `block`) VALUES
                            (0, 'guest', 'ANEK IT CONSULT', '0554013980', 'nketiaernest18@gmail.com', 'Guest', 'NO');
                            
                            CREATE TABLE IF NOT EXISTS `login` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `employeeID` varchar(10) NOT NULL,
                              `password` varchar(50) NOT NULL,
                              `position` varchar(20) NOT NULL,
                              `block` varchar(3) NOT NULL,
                              PRIMARY KEY (`ID`),
                              UNIQUE KEY `employeeID` (`employeeID`)
                            );

                            INSERT INTO `login` (`ID`, `employeeID`, `password`, `position`, `block`) VALUES
                            (0, 'guest', 'guest', 'guest', 'NO');

                           CREATE TABLE IF NOT EXISTS `product` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `Product_ID` varchar(11) NOT NULL,
                              `Pro_Name` varchar(50) NOT NULL,
                              `instock` int(11) NOT NULL,
                              `Price` decimal(11,2) NOT NULL,
                              `date` varchar(20) NOT NULL,
                              `catID` varchar(10) NOT NULL,
                              `selling_price` decimal(11,2) NOT NULL,
                              `hide` varchar(3) NOT NULL,
                              `Average_Quantity` int(11) DEFAULT '0',
                              `New_Quant_Added` int(11) DEFAULT '0',
                              `Date_Updated` varchar(20) NOT NULL,
                              `quant_soldq` int(11) DEFAULT '0',
                              PRIMARY KEY (`ID`),
                              UNIQUE KEY `Product_ID` (`Product_ID`)
                            );

                            CREATE TABLE IF NOT EXISTS `producttype` (
                              `ID` int(11) NOT NULL AUTO_INCREMENT,
                              `catID` varchar(10) NOT NULL,
                              `category` varchar(50) NOT NULL,
                              PRIMARY KEY (`ID`)
                            );

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
                            );
                            "
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)

            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Me.Close()
        End Try
    End Sub
End Class