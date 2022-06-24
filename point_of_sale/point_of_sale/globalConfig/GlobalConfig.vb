Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Security.Cryptography
Module GlobalConfig
    Public query As String
    Public cmd As MySqlCommand
    Public adapter As MySqlDataAdapter
    Public reader As MySqlDataReader
    Public conn As MySqlConnection
    Public connstring As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
    Private EncryptionKey As String = "MAKV2SPBNI99212"


    Public Sub OpenConnection()
        conn = New MySqlConnection(connstring)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Public Sub Closings()
        Frm_Addtype.Close()
        Frm_GenSettings.Close()
        Frm_ListOfProduct.Close()
        Frm_MySales.Close()
        Frm_Profit.Close()
        Frm_Sale.Close()
        FrmAddProduct.Close()
        FrmAddSeler.Close()
        frmCheck_Stock.Close()
        FrmReport.Close()
        FrmStatics.Close()
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

    Function Decrypt(cipherText As String) As String
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {
                                             &H49, &H76, &H61, &H6E, &H20, &H4D,
                                             &H65, &H64, &H76, &H65, &H64, &H65,
                                             &H76}
                                             )
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Public Sub ColorClear()

        Frm_AdminDas.btnMakeSales.FillColor = Color.Gold
        Frm_AdminDas.btnMakeSales.ForeColor = Color.Black
        Frm_AdminDas.btn_AddProduct.FillColor = Color.Gold
        Frm_AdminDas.btn_AddProduct.ForeColor = Color.Black
        Frm_AdminDas.Btn_AddSaler.FillColor = Color.Gold
        Frm_AdminDas.Btn_AddSaler.ForeColor = Color.Black
        Frm_AdminDas.btn_DailySales.FillColor = Color.Gold
        Frm_AdminDas.btn_DailySales.ForeColor = Color.Black

    End Sub
End Module
