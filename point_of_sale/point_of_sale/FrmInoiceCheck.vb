Imports MySql.Data.MySqlClient

Public Class FrmInoiceCheck
    Private Sub FrmInoiceCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Data_Grid1()
        loadDetails()
    End Sub

    Public Sub load_Data_Grid1()
        If CmbInvoiceCode.Text = "" Then
            DataGridViewDetails.DataSource = Load_Data_Grid("Select invoicecode,item,Qty,price,Amount,month from sales").Tables(0)
        Else
            DataGridViewDetails.DataSource = Load_Data_Grid("Select invoicecode,item,Qty,price,Amount,month from sales where invoicecode='" + CmbInvoiceCode.Text + "'").Tables(0)
        End If
    End Sub

    Private Sub CmbInvoiceCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbInvoiceCode.KeyPress

        With Me.CmbInvoiceCode

            Dim ToFind As String = .Text.Substring(0, .SelectionStart) & e.KeyChar
            Dim Index As Integer = .FindStringExact(ToFind)

            If Index = -1 Then Index = .FindString(ToFind)
            If Index = -1 Then Return

            .SelectedIndex = Index
            .SelectionStart = ToFind.Length
            .SelectionLength = .Text.Length - .SelectionStart

            e.Handled = True

            Try
                DataGridViewDetails.DataSource = Load_Data_Grid("Select invoicecode,item,Qty,price,Amount,month from sales where invoicecode='" + CmbInvoiceCode.Text + "'").Tables(0)
            Catch ex As Exception
                MsgBox("Error: " + ex.Message,, MsgBoxStyle.Exclamation)

            End Try
        End With
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        CmbInvoiceCode.Text = ""
        loadInvoiceCode()
    End Sub

    Private Sub loadDetails()
        Dim conStringg As String = connstring
        Dim query As String
        query = "SELECT * FROM sales"
        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader
                    While reader.Read
                        CmbInvoiceCode.Items.Add(reader.Item("invoicecode"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class