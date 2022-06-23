Imports MySql.Data.MySqlClient
Module GlobalConfig
    Public query As String
    Public cmd As MySqlCommand
    Public adapter As MySqlDataAdapter
    Public reader As MySqlDataReader
    Public conn As MySqlConnection
    Public connstring As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"



    Public Sub openConnection()
        conn = New MySqlConnection(connstring)
        Try
            If (conn.State = ConnectionState.Closed) Then
                conn.Open()

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())

        End Try
    End Sub

    Public Sub closings()
        frm_Addtype.Close()
        frm_ChanegePassword.Close()
        frm_GenSettings.Close()
        frm_ListOfProduct.Close()
        frm_MySales.Close()
        frm_Profit.Close()
        frm_Sale.Close()
        frmAddProduct.Close()
        frmAddSeler.Close()
        frmCheck_Stock.Close()
        frmReport.Close()
        frmStatics.Close()
    End Sub



End Module
