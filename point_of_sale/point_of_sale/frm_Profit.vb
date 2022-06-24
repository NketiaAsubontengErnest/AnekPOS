Imports MySql.Data.MySqlClient
Public Class frm_Profit
    Private Sub frm_Profit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMonth.Text = Date.Now.ToString("MM")
        calculateSales()
        employeeDetail()
        calculateGenAmount()
    End Sub

    Public Sub calculateGenAmount()
        Dim conStringg As String = connstring
        Dim query As String

        'If cmbDate.Text = "" Then
        query = "SELECT `instock`, `Price` FROM `product`"
        'Else
        ' query = "SELECT amount, profit from sales where month='" + cmbDate.Text + "' AND Gen_Mount ='" + cmbMonth.Text + "'"
        'End If

        Dim price As Decimal = 0.00
        Dim AllAmount As Decimal = 0.00
        Dim Quant As Integer = 0
        Dim totalmoney As Decimal = 0.00

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
                        Quant += reader("instock")
                        price += reader("Price")
                        totalmoney = Quant * price
                        AllAmount += totalmoney
                        Quant = 0
                        price = 0.00
                        totalmoney = 0.00

                    End While
                    lblGenAmount.Text = "Gh¢" + AllAmount.ToString("#,0.00")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub
    Public Sub calculateSales()
        Dim conStringg As String = connstring
        Dim query As String

        If cmbDate.Text = "" Then
            query = "SELECT amount, profit from sales where Gen_Mount = '" + cmbMonth.Text + "'"
        Else
            query = "SELECT amount, profit from sales where month='" + cmbDate.Text + "' AND Gen_Mount ='" + cmbMonth.Text + "'"
        End If

        Dim AllCost As Decimal = 0.00
        Dim Profit As Decimal = 0.00

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
                        Profit += reader("profit")
                        AllCost += reader("amount")

                    End While
                    lblProfit.Text = "Gh¢" + Profit.ToString("#,0.00")
                    lblCost.Text = "Gh¢" + AllCost.ToString("#,0.00")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Public Sub employeeDetail()
        Dim con1Stringg As String = connstring
        Dim query1 As String = "SELECT distinct month from sales"

        Using conn As New MySqlConnection(con1Stringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query1
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        cmbDate.Items.Add(reader("month"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        calculateSales()
    End Sub

    Private Sub cmbDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDate.SelectedIndexChanged
        calculateSales()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        colorClear()
        Me.Close()
    End Sub
End Class