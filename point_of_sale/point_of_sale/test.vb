Imports MySql.Data.MySqlClient

Public Class Test
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As DataTable
    Dim conn As String = "server=localhost;user id=root;password=0554013980A@;database=point_of_sale"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = conn

        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from point_of_sale.product"
            Dim COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Chart1.Series("stat").Points.AddXY(READER.GetString("Pro_Name"), READER.GetInt32("quant_soldq"))
            End While

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try



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

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class