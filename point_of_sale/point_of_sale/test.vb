Imports MySql.Data.MySqlClient

Public Class Test


    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("hh")
    End Sub
End Class