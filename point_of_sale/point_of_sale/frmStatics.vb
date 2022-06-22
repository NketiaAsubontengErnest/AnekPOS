Imports MySql.Data.MySqlClient
Public Class frmStatics

    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As DataTable
    Dim conn As String = "server=localhost;user id=root;password=0554013980A@;database=point_of_sale"
    Private Sub frmStatics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadA()
    End Sub

    Private Sub loadA()
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

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class