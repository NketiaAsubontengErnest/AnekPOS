Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Test
    Private DBserver As String = "localhost"
    Private DBuserids As String = "root"
    Private DBpassword As String = "0554013980A@"
    Private DBdatabase As String = "point_of_sale"
    Private connstring As String = "server=" & DBserver & ";userid=" & DBuserids & ";password=" & DBpassword & ";database=" & DBdatabase & ""
    Private EncryptionKey As String = "MAKV2SPBNI99212"
    Dim Lbs() As Object = {Label3}
    Dim reader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AlterTables("ALTER TABLE product DROP COLUMN type;")
        AlterTables("ALTER TABLE product ADD COLUMN tot_num_add INT(11);")
        AlterTables("ALTER TABLE product MODIFY COLUMN product_ID VARCHAR(10);")
        AlterTables("ALTER TABLE sales ADD COLUMN invoicecode VARCHAR(50);")
    End Sub
    Function AlterTables(queryA As String)
        Dim con As MySqlConnection = New MySqlConnection(connstring)
        Try
            con.Open()
            Dim cmd As New MySqlCommand(queryA, con)
            reader = cmd.ExecuteReader()

            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return reader

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        reader = AlterTables("Update `login` Set `Password` = '" + Encrypt(TextBox2.Text) + "' WHERE employeeID = '" + TextBox1.Text + "'")
        If reader.RecordsAffected > 0 Then

            MsgBox("We are Done, Please install ANEK POS", MsgBoxStyle.Information)
        End If
    End Sub

    Function Encrypt(clearText As String) As String

        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {
                                            &H49, &H76, &H61, &H6E, &H20, &H4D,
                                            &H65, &H64, &H76, &H65, &H64, &H65,
                                            &H76}
                                           )
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
End Class
