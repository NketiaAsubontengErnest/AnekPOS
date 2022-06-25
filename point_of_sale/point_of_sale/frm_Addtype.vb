Imports MySql.Data.MySqlClient

Public Class Frm_Addtype
    Public Sub InsertProduct()
        If CheckExist("SELECT * FROM producttype where category = '" + txt_CatName.Text + "'") Then
            MsgBox(" The Category Name Already Exist!!", MsgBoxStyle.Critical)
        Else
            query = "INSERT INTO `producttype` (`catID`, `category`) VALUES 
                                           ('" & txt_CatID.Text & "',
                                            '" & txt_CatName.Text & "'
                                           )"
            Try
                reader = Inserting(query)
                If reader.RecordsAffected > 0 Then
                    MsgBox("Product Category Added Succesfully!!", MsgBoxStyle.Information)
                    txt_CatName.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        genrateID()
    End Sub

    Public Sub genrateID()
        Dim conString As String = connstring
        query = "SELECT * FROM producttype"
        Dim count As Integer = 0
        Dim number As String = ""
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
                        count += 1
                    End While
                Catch ex As Exception

                End Try
            End Using
        End Using

        If count < 10 Then
            number = "000"
        ElseIf count < 100 Then
            number = "00"
        ElseIf count < 1000 Then
            number = "0"
        End If

        count += 1

        txt_CatID.Text = "CAT" + number + count.ToString
    End Sub

    Private Sub frm_Addtype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genrateID()
        LoadGrid()
    End Sub

    Public Sub LoadGrid()
        CatList.DataSource = Load_Data_Grid("SELECT `catID`, `category` FROM producttype").Tables(0)
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If Not txt_CatName.Text = "" Then
            InsertProduct()
        Else
            ToolTip1.Show("Required field", txt_CatName, 2000)
        End If

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        colorClear()
        Me.Close()
    End Sub

End Class