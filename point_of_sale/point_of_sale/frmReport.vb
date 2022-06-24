
Imports MySql.Data.MySqlClient

Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frm_AdminDas.lblRole.Text = "Sale" Then
            cmbEmployeeID.Text = frm_AdminDas.lblUserID.Text
            cmbName.Text = frm_AdminDas.lblUserName.Text

            cmbName.Enabled = False
            cmbEmployeeID.Enabled = False
            cmbDate.Visible = False
            GunaLabel1.Visible = False

            PictureBox1.Visible = False
        End If

        load_Data_Grid()
        employeeDetails()
        setDate()

        lblReport.Text = DateTime.Now.ToString

    End Sub

    Public Sub setDate()
        Dim conStringg As String = connstring
        Dim query As String = ""

        If cmbEmployeeID.Text = "" Then
            query = "SELECT DISTINCT date from dailysales"
        Else
            query = "SELECT DISTINCT date from dailysales WHERE employeeID='" + cmbEmployeeID.Text + "'"
        End If

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

                        cmbDate.Items.Add(reader("date"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Public Sub employeeDetails()
        Dim conStringg As String = connstring
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
                        cmbEmployeeID.Items.Add(reader("employeeID"))
                        cmbName.Items.Add(reader("name"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        colorClear()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Public Sub load_Data_Grid()
        Dim con As MySqlConnection

        Dim ada As New MySqlDataAdapter
        Dim ds As New DataSet

        con = New MySqlConnection(connstring)
        con.Open()

        If cmbDate.Text = "" And cmbEmployeeID.Text = "" Then
            ada = New MySqlDataAdapter("Select ID,employeeID,totalSales,date,datePrepared from dailysales ", con)
        ElseIf cmbEmployeeID.Text = "" Then
            ada = New MySqlDataAdapter("Select ID,employeeID,totalSales,date,datePrepared from dailysales where 
                                       date='" + cmbDate.Text + "'", con)
        ElseIf cmbDate.Text = "" Then
            ada = New MySqlDataAdapter("Select ID,employeeID,totalSales,date,datePrepared from dailysales where 
                                       employeeID='" + cmbEmployeeID.Text + "'", con)
        Else
            ada = New MySqlDataAdapter("Select ID,employeeID,totalSales,date,datePrepared from dailysales where 
                                       date='" + cmbDate.Text + "' AND employeeID='" + cmbEmployeeID.Text + "'", con)

        End If



        ada.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cmbDate.Text = ""
        cmbEmployeeID.Text = ""
        cmbName.Text = ""

        load_Data_Grid()
    End Sub

    Private Sub cmbEmployeeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployeeID.SelectedIndexChanged
        cmbName.Text = cmbName.Items(cmbEmployeeID.SelectedIndex)
        load_Data_Grid()
    End Sub

    Private Sub cmbDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDate.SelectedIndexChanged
        load_Data_Grid()
    End Sub

    Private Sub cmbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbName.SelectedIndexChanged

        cmbEmployeeID.Text = cmbEmployeeID.Items(cmbName.SelectedIndex)
        load_Data_Grid()
    End Sub

    Private Sub txt_Print_Click(sender As Object, e As EventArgs) 

    End Sub
End Class