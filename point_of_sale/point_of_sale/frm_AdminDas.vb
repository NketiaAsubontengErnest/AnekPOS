Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frm_AdminDas
    Private Sub btn_close_Click(sender As Object, e As EventArgs)

        Me.Close()
        frmLogin.Show()
    End Sub
    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_AddSaler_Click(sender As Object, e As EventArgs) Handles btn_AddSaler.Click

        Try
            colorClear()
            btn_AddSaler.FillColor = Color.FromArgb(43, 102, 121)
            btn_AddSaler.ForeColor = Color.Gold

            closings()

            frmAddSeler.MdiParent = Me
            frmAddSeler.Show()



        Catch ex As Exception

        End Try

    End Sub
    Private Sub btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        Try
            colorClear()
            btn_AddProduct.FillColor = Color.FromArgb(43, 102, 121)
            btn_AddProduct.ForeColor = Color.Gold

            closings()

            frmAddProduct.MdiParent = Me
            frmAddProduct.Show()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_DailySales_Click_1(sender As Object, e As EventArgs) Handles btn_DailySales.Click
        Try

            colorClear()
            btn_DailySales.FillColor = Color.FromArgb(43, 102, 121)
            btn_DailySales.ForeColor = Color.Gold

            closings()

            frm_MySales.MdiParent = Me
            frm_MySales.Show()

        Catch ex As Exception

        End Try


    End Sub

    Public Function isClosed()
        Dim conStringg As String = connstring
        Dim query As String = "SELECT isClosed from dailysales where employeeID='" + lblUserID.Text + "'
                              AND date='" + Date.Now.ToString("dd/MM/yyyy") + "'"

        Dim closed As Boolean = False

        Using conn As New MySqlConnection(conStringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    If reader.Read Then
                        closed = True
                    Else
                        closed = False
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using

        Return closed
    End Function
    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click

        Dim ans As DialogResult = MsgBox("Do You Want To  Exit? ", MsgBoxStyle.YesNo, "Exit System")

        If ans = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Public Sub dailySales()

        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = connstring

        Try
            connection.Open()
            insertString_EmpDetiles = "INSERT INTO dailysales (employeeID,totalsales,date,datePrepared,isClosed) VALUES (
                                                                   '" + lblUserID.Text + "',
                                                                   '" + frm_Sale.lblSales.Text + "',
                                                                   '" + Date.Now.ToString("dd/MM/yyyy") + "',
                                                                   '" + DateTime.Now.ToString + "',
                                                                   'Yes')"
            command = New MySqlCommand(insertString_EmpDetiles, connection)
            command.ExecuteNonQuery()

            MsgBox("Account Successfully Closed For The Day")

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            connection.Dispose()
        End Try
    End Sub
    Private Sub btn_Maximize_Click_1(sender As Object, e As EventArgs) Handles btn_Maximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

        If btn_Maximize.Tag = 0 Then
            btn_Maximize.Image = My.Resources.maximize_63_618164
            btn_Maximize.Tag = 1
        ElseIf btn_Maximize.Tag = 1 Then
            btn_Maximize.Image = My.Resources.ew
            btn_Maximize.Tag = 0
        End If
    End Sub
    Private Sub btn_Minimize_Click_1(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Try
            closings()

            frmReport.MdiParent = Me
            frmReport.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        closings()

        Dim f As New frmCheck_Stock

        f.MdiParent = Me
        f.Show()


    End Sub
    Private Sub AddCategoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddCategoryToolStripMenuItem1.Click
        Try
            closings()

            frm_Addtype.MdiParent = Me

            frm_Addtype.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UpdateProductToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateProductToolStripMenuItem1.Click
        Try
            closings()

            frmCheck_Stock.MdiParent = Me

            frmCheck_Stock.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        frmLogin.Show()
        lblUserID.Text = ""
        lblTime.Text = ""
        lblRole.Text = ""
        Me.Close()
    End Sub
    Private Sub UserListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserListToolStripMenuItem.Click
        Try
            closings()


            User_Lists.MdiParent = Me

            User_Lists.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListOfProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfProductToolStripMenuItem.Click
        Try
            closings()

            frm_ListOfProduct.MdiParent = Me

            frm_ListOfProduct.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MyProfitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyProfitToolStripMenuItem.Click
        Try
            closings()

            frm_Profit.MdiParent = Me

            frm_Profit.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_AdminDas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        countOutStock()
        lblUserID.Text = frmLogin.txt_Username.Text
    End Sub

    Public Sub countOutStock()
        Dim conStringg As String = connstring
        Dim query As String = "Select Product_ID FROM product WHERE `instock` < `Average_Quantity`"

        Dim countOut As int16 = 0

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
                       countOut +=1
                    End While

                    If countOut > 0 Then

                        'MsgBox(countOut.ToString + " Products is out of stock!!!")
                        lblAvelable.Visible = True
                        lblAvelable.Text = countOut.ToString + " Products is out of stock!!!"

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Private Sub GeneralSystemSetingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralSystemSetingsToolStripMenuItem.Click
        Try
            closings()

            frm_GenSettings.MdiParent = Me
            frm_GenSettings.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatisticsToolStripMenuItem.Click
        Try
            closings()

            frmStatics.MdiParent = Me
            frmStatics.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = TimeString
    End Sub

    Private Sub btnMakeSales_Click(sender As Object, e As EventArgs) Handles btnMakeSales.Click
        Try
            colorClear()
            btnMakeSales.FillColor = Color.FromArgb(43, 102, 121)
            btnMakeSales.ForeColor = Color.Gold

            closings()


            frm_Sale.MdiParent = Me
            frm_Sale.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class