Imports MySql.Data.MySqlClient

Public Class splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            FrmLogin.Show()
            Me.Close()
        Else
            ProgressBar1.Value += 10
            lblCreateD.Text = "Database Creating " + (ProgressBar1.Value).ToString + " %"
        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateFolder()


        Dim conn As String = "server=" & DBserver & ";userid=" & DBuserids & ";password=" & DBpassword & ";"
        Dim mey = DoesDBExist(conn)
        If mey.ToString = "True" Then

        Else
            createDatabase()
        End If
        createTables()
        LoadCompanyDetails()

        Timer1.Start()
    End Sub


End Class