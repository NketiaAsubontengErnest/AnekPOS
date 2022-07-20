Imports MySql.Data.MySqlClient

Public Class FrmProductAnalysis
    Private Sub FrmProductAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        LoadComboYear()
        LoadP("")
    End Sub
    Private Sub LoadCombo()
        Dim conStringg As String = connstring
        query = "SELECT DISTINCT (item) from sales"

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
                        ComboItems.Items.Add(reader("item"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub
    Private Sub LoadComboYear()
        Dim conStringg As String = connstring
        query = "SELECT DISTINCT (SoldYear) from sales"

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
                        CmbYear.Items.Add(reader("SoldYear"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Private Function LoadQuent(itemName As String, i As Integer) As Array
        Dim number As Integer = 0
        Dim totalAdded As Integer = 0
        Dim conStringg As String = connstring
        Dim query As String
        query = "SELECT * from product where Pro_Name = '" + ComboItems.GetItemText(ComboItems.Items(i)) + "'"

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
                        number = reader("instock")
                        totalAdded = reader("instock")
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
        Dim ara() = {number, totalAdded}
        Return ara
    End Function
    Private Sub LoadP(queryx As String)
        Dim conStringg As String = connstring

        Dim stoppage As Integer = 20
        'If cmbDate.Text = "" Then
        'query = "SELECT amount, profit from sales where Gen_Mount = '" + cmbMonth.Text + "'"
        Dim i As Integer
        For i = 0 To ComboItems.Items.Count - 1
            If queryx = "" Then
                query = "SELECT * from sales where item = '" + ComboItems.GetItemText(ComboItems.Items(i)) + "'"
            Else
                query = "SELECT * from sales where item = '" + ComboItems.GetItemText(ComboItems.Items(i)) + "' AND " + queryx
            End If
            'Else
            'query = "SELECT amount, profit from sales where month='" + cmbDate.Text + "' AND Gen_Mount ='" + cmbMonth.Text + "'"
            'End If

            Dim AllCost As Decimal = 0.00
            Dim Profit As Decimal = 0.00
            Dim name As String = ""
            Dim counter As Integer = 0
            Dim rowcount As Integer = 0

            Using conn As New MySqlConnection(conStringg)
                Using command As New MySqlCommand
                    With command
                        .Connection = conn
                        .CommandText = query
                    End With
                    Try
                        conn.Open()
                        Dim reader As MySqlDataReader = command.ExecuteReader
                        rowcount = reader.FieldCount
                        While reader.Read
                            name = reader("item")
                            Profit += reader("profit")
                            AllCost += reader("amount")
                            counter += 1
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End Using
            End Using
            If Not name = "" Then
                SingleProduct(name, Profit, AllCost, counter, i, rowcount)
            End If
        Next
    End Sub

    Private Sub LoadSeach(Sele As Integer, qstring As String)
        Dim conStringg As String = connstring
        Dim query As String
        'If cmbDate.Text = "" Then
        'query = "SELECT amount, profit from sales where Gen_Mount = '" + cmbMonth.Text + "'"
        Dim i As Integer = Sele
        'If ComboItems.Text = "" Then
        '    query = "SELECT * from sales where item = '" + ComboItems.GetItemText(ComboItems.Items(i)) + "'"
        'Else
        query = qstring ' "SELECT * from sales where item = '" + ComboItems.Text + "'"
        'End If
        'For i = 0 To ComboItems.Items.Count - 1

        'Else
        'query = "SELECT amount, profit from sales where month='" + cmbDate.Text + "' AND Gen_Mount ='" + cmbMonth.Text + "'"
        'End If

        Dim AllCost As Decimal = 0.00
        Dim Profit As Decimal = 0.00
        Dim name As String = ""
        Dim counter As Integer = 0
        Dim rowcount As Integer = 0


        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader
                    rowcount = reader.FieldCount
                    While reader.Read
                        name = reader("item")
                        Profit += reader("profit")
                        AllCost += reader("amount")
                        counter += 1
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

        SingleProduct(name, Profit, AllCost, counter, i, rowcount)
        'Next
    End Sub

    Private Sub SingleProduct(Name1 As String, Profit As Integer, AllCost As Decimal, counter As Integer, i As Integer, rowcout As Integer)
        Dim cPanel As New Panel
        Dim lblPName As New Label
        Dim lblQtySold As New Label
        Dim lblQtyAve As New Label
        Dim lblQtyAdded As New Label
        Dim lblTotalAmount As New Label
        Dim btnProfit As New Button

        'Panel Styling
        cPanel.AutoSize = False
        cPanel.BackColor = Color.FromArgb(46, 52, 88)
        cPanel.TabIndex = 0
        cPanel.Name = "Create Panel"
        cPanel.Location = New System.Drawing.Point(3, 3)
        cPanel.Size = New System.Drawing.Size(315, 163)

        'lblProductName
        lblPName.TextAlign = ContentAlignment.MiddleCenter
        lblPName.Size = New System.Drawing.Size(41, 10)
        lblPName.AutoSize = True
        lblPName.Location = New System.Drawing.Point(1, 3)
        lblPName.ForeColor = Color.Gold
        lblPName.Font = New Font("Calibri", 20, FontStyle.Bold)
        lblPName.Text = Name1
        lblPName.Name = "lblPname"
        lblPName.TabIndex = 0

        'lblQuantity Added
        lblQtyAdded.TextAlign = ContentAlignment.BottomCenter
        lblQtyAdded.Size = New System.Drawing.Size(41, 10)
        lblQtyAdded.AutoSize = True
        lblQtyAdded.ForeColor = Color.White
        lblQtyAdded.Font = New Font("Calibri", 15, FontStyle.Bold)
        lblQtyAdded.Text = "Qty. Added: " & LoadQuent(Name, i)(1)
        lblQtyAdded.Name = "lblQtySold"
        lblQtyAdded.Location = New System.Drawing.Point(19, 30)
        lblQtyAdded.TabIndex = 1

        'lblQuantity Available
        lblQtyAve.TextAlign = ContentAlignment.BottomCenter
        lblQtyAve.Size = New System.Drawing.Size(41, 20)
        lblQtyAve.AutoSize = True
        lblQtyAve.ForeColor = Color.White
        lblQtyAve.Font = New Font("Calibri", 15, FontStyle.Bold)
        lblQtyAve.Text = "Qty. Ave     : " & LoadQuent(Name, i)(0)
        lblQtyAve.Name = "lblQtySold"
        lblQtyAve.Location = New System.Drawing.Point(20, 55)
        lblQtyAve.TabIndex = 1

        'lblQuantity Sold
        lblQtySold.TextAlign = ContentAlignment.BottomCenter
        lblQtySold.Size = New System.Drawing.Size(41, 20)
        lblQtySold.AutoSize = True
        lblQtySold.ForeColor = Color.White
        lblQtySold.Font = New Font("Calibri", 15, FontStyle.Bold)
        lblQtySold.Text = "Qty. Sold    : " & counter
        lblQtySold.Name = "lblQtySold"
        lblQtySold.Location = New System.Drawing.Point(20, 79)
        lblQtySold.TabIndex = 2

        'label Total Amount
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New System.Drawing.Point(20, 100)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.ForeColor = Color.White
        lblTotalAmount.Font = New Font("Calibri", 15, FontStyle.Bold)
        lblTotalAmount.Size = New System.Drawing.Size(41, 15)
        lblTotalAmount.TabIndex = 3
        lblTotalAmount.Text = "Total Amt   : GH₵" & AllCost

        'Button Profit
        btnProfit.Location = New System.Drawing.Point(3, 133)
        btnProfit.Name = "btnProfit"
        btnProfit.Size = New System.Drawing.Size(310, 29)
        btnProfit.Font = New Font("Calibri", 15, FontStyle.Bold)
        btnProfit.TabIndex = 4
        btnProfit.BackColor = Color.Gold
        btnProfit.Text = "Profit: GH₵" & Profit
        btnProfit.UseVisualStyleBackColor = True

        'Add controls to panel
        cPanel.Controls.Add(lblPName)
        cPanel.Controls.Add(lblQtyAdded)
        cPanel.Controls.Add(lblQtySold)
        cPanel.Controls.Add(lblQtyAve)
        cPanel.Controls.Add(lblTotalAmount)
        cPanel.Controls.Add(btnProfit)

        'Add controls to flow layout panel
        Me.FloproductPanel.Controls.Add(cPanel)
    End Sub

    Private Sub ComboItems_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboItems.KeyPress
        Dim conn = New MySqlConnection
        With Me.ComboItems

            Dim ToFind As String = .Text.Substring(0, .SelectionStart) & e.KeyChar
            Dim Index As Integer = .FindStringExact(ToFind)

            If Index = -1 Then Index = .FindString(ToFind)
            If Index = -1 Then Return

            .SelectedIndex = Index
            .SelectionStart = ToFind.Length
            .SelectionLength = .Text.Length - .SelectionStart

            e.Handled = True
            FloproductPanel.Controls.Clear()

            Dim s As String = "SELECT * from sales where item = '" + ComboItems.Text + "'"

            LoadSeach(Index, s)
        End With
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub ComboItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboItems.SelectedIndexChanged
        FloproductPanel.Controls.Clear()
        Dim s As String
        If CmbYear.Text = "" Then
            s = "SELECT * from sales where item = '" + ComboItems.Text + "'"
        Else
            s = "SELECT * from sales where item = '" + ComboItems.Text + "' and SoldYear = '" + CmbYear.Text + "'"
        End If

        LoadSeach(ComboItems.SelectedIndex, s)
    End Sub

    Private Sub CmbYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbYear.KeyPress
        Dim conn = New MySqlConnection
        With Me.CmbYear

            Dim ToFind As String = .Text.Substring(0, .SelectionStart) & e.KeyChar
            Dim Index As Integer = .FindStringExact(ToFind)

            If Index = -1 Then Index = .FindString(ToFind)
            If Index = -1 Then Return

            .SelectedIndex = Index
            .SelectionStart = ToFind.Length
            .SelectionLength = .Text.Length - .SelectionStart

            e.Handled = True
            FloproductPanel.Controls.Clear()
            If CmbMonth.Text = "" Then
                LoadP("SoldYear = '" + CmbYear.Text + "'")
            Else
                LoadP("SoldYear = '" + CmbYear.Text + "' AND Gen_Mount = '" + CmbMonth.Text + "'")
            End If
        End With
    End Sub

    Private Sub CmbMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbMonth.KeyPress
        Dim conn = New MySqlConnection
        With Me.CmbMonth

            Dim ToFind As String = .Text.Substring(0, .SelectionStart) & e.KeyChar
            Dim Index As Integer = .FindStringExact(ToFind)

            If Index = -1 Then Index = .FindString(ToFind)
            If Index = -1 Then Return

            .SelectedIndex = Index
            .SelectionStart = ToFind.Length
            .SelectionLength = .Text.Length - .SelectionStart

            e.Handled = True
            FloproductPanel.Controls.Clear()

            If CmbYear.Text = "" Then
                LoadP("Gen_Mount = '" + CmbMonth.Text + "'")
            Else
                LoadP("SoldYear = '" + CmbYear.Text + "' AND Gen_Mount = '" + CmbMonth.Text + "'")
            End If
        End With
    End Sub

    Private Sub CmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbYear.SelectedIndexChanged
        FloproductPanel.Controls.Clear()
        If CmbMonth.Text = "" Then
            LoadP("SoldYear = '" + CmbYear.Text + "'")
        Else
            LoadP("SoldYear = '" + CmbYear.Text + "' AND Gen_Mount = '" + CmbMonth.Text + "'")
        End If
    End Sub

    Private Sub CmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMonth.SelectedIndexChanged
        FloproductPanel.Controls.Clear()
        If CmbYear.Text = "" Then
            LoadP("Gen_Mount = '" + CmbMonth.Text + "'")
        Else
            LoadP("SoldYear = '" + CmbYear.Text + "' AND Gen_Mount = '" + CmbMonth.Text + "'")
        End If
    End Sub
End Class