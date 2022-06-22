
Imports MySql.Data.MySqlClient

Public Class frm_MySales

    Private Sub frm_MySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculateSales()
        setName()
        load_Data_Grid()

        If frm_AdminDas.lblRole.Text = "Sale" Then

            cmbName.Enabled = False
            cmbEmpID.Enabled = False
            PictureBox1.Visible = False

            cmbEmpID.Text = frm_AdminDas.lblUserID.Text
            cmbName.Text = frm_AdminDas.lblUserName.Text


        End If

    End Sub

    Public Sub employeeDetail()
        Dim con1Stringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query1 As String = "SELECT distinct month from sales where employeeID='" + cmbEmpID.Text + "'"

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

    Public Sub calculateSales()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String

        If cmbEmpID.Text = "" Then
            query = "SELECT amount from sales"
        Else
            query = "SELECT amount from sales where employeeID='" + cmbEmpID.Text + "' AND month='" + cmbDate.Text + "'"
        End If

        Dim todaySales As Decimal = 0.00

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
                        todaySales += reader("amount")

                    End While


                    lblDailySales.Text = "Gh¢" + todaySales.ToString
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub


    Public Sub setName()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT employeeID,name from employee"

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
                        cmbEmpID.Items.Add(reader("employeeID"))
                        cmbName.Items.Add(reader("name"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub


    Public Sub load_Data_Grid_All()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection("server=localhost;userid=root;password=0554013980A@;database=point_of_sale")
        con.Open()

        If cmbEmpID.Text = "" Then
            ada = New MySqlDataAdapter("Select ID,item,Qty,price,Amount,month from sales", con)
        Else
            ada = New MySqlDataAdapter("Select ID,item,Qty,price,Amount,month from sales where employeeID='" +
                                       cmbEmpID.Text + "' AND month='" + cmbDate.Text + "'", con)

        End If

        ada.Fill(ds)
        data_MySales.DataSource = ds.Tables(0)
    End Sub

    Public Sub load_Data_Grid()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection("server=localhost;userid=root;password=0554013980A@;database=point_of_sale")
        con.Open()

        If cmbEmpID.Text = "" Then
            ada = New MySqlDataAdapter("Select ID,item,Qty,price,Amount,month from sales WHERE hide = 'NO'", con)
        Else
            ada = New MySqlDataAdapter("Select ID,item,Qty,price,Amount,month from sales where employeeID='" +
                                       cmbEmpID.Text + "' AND month='" + cmbDate.Text + "' AND hide = 'NO'", con)

        End If

        ada.Fill(ds)
        data_MySales.DataSource = ds.Tables(0)
    End Sub

    Private Sub cmbEmpID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpID.SelectedIndexChanged
        cmbDate.Enabled = True
        cmbName.Text = cmbName.Items(cmbEmpID.SelectedIndex)
        load_Data_Grid()
        employeeDetail()
    End Sub

    Private Sub cmbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbName.SelectedIndexChanged
        cmbDate.Enabled = True
        cmbEmpID.Text = cmbEmpID.Items(cmbName.SelectedIndex)
        load_Data_Grid()
        calculateSales()
        calculateSales()
    End Sub

    Private Sub cmbDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDate.SelectedIndexChanged
        load_Data_Grid()
        calculateSales()


    End Sub

    Private Sub data_MySales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_MySales.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        'cmbEmpID.SelectedIndex = -1
        'cmbName.SelectedIndex = -1
        'cmbDate.SelectedIndex = -1

        cmbDate.Text = ""
        cmbEmpID.Text = ""
        cmbName.Text = ""

        load_Data_Grid()
        calculateSales()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub chk_show_Hide_CheckedChanged(sender As Object, e As EventArgs) Handles chk_show_Hide.CheckedChanged
        If chk_show_Hide.Checked = True Then
            load_Data_Grid_All()
        Else
            load_Data_Grid()
        End If
    End Sub
End Class