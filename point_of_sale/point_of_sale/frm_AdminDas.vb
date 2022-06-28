Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Frm_AdminDas
    Private Sub btn_close_Click(sender As Object, e As EventArgs)

        Me.Close()
        frmLogin.Show()
    End Sub
    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_AddSaler_Click(sender As Object, e As EventArgs) Handles Btn_AddSaler.Click

        Try
            ColorClear()
            Btn_AddSaler.FillColor = Color.FromArgb(43, 102, 121)
            Btn_AddSaler.ForeColor = Color.Gold

            Closings()

            FrmAddSeler.MdiParent = Me
            FrmAddSeler.Show()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        Try
            ColorClear()
            btn_AddProduct.FillColor = Color.FromArgb(43, 102, 121)
            btn_AddProduct.ForeColor = Color.Gold

            Closings()

            FrmAddProduct.MdiParent = Me
            FrmAddProduct.Show()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_DailySales_Click_1(sender As Object, e As EventArgs) Handles btn_DailySales.Click
        Try

            ColorClear()
            btn_DailySales.FillColor = Color.FromArgb(43, 102, 121)
            btn_DailySales.ForeColor = Color.Gold

            Closings()

            Frm_MySales.MdiParent = Me
            Frm_MySales.Show()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click

        Dim ans As DialogResult = MsgBox("Do You Want To  Exit? ", MsgBoxStyle.YesNo, "Exit System")

        If ans = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Public Sub DailySales()

        query = "INSERT INTO DailySales (employeeID,totalsales,date,datePrepared,isClosed) VALUES (
                                        '" + lblUserID.Text + "',
                                        '" + Frm_Sale.lblSales.Text + "',
                                        '" + Date.Now.ToString("dd/MM/yyyy") + "',
                                        '" + DateTime.Now.ToString + "',
                                        'Yes')"
        Try
            reader = Inserting(query)
            If reader.RecordsAffected > 0 Then
                MsgBox("Account Successfully Closed For The Day, See you next day", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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


    Private Sub UpdateProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Closings()

        Dim f As New frmCheck_Stock

        f.MdiParent = Me
        f.Show()


    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        FrmLogin.Show()
        lblUserID.Text = ""
        lblTime.Text = ""
        lblRole.Text = ""
        Me.Close()
    End Sub

    Private Sub Frm_AdminDas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        countOutStock()
        lblUserID.Text = FrmLogin.txt_Username.Text
        LblCompanyName.Text = CompanyName1
    End Sub

    Public Sub countOutStock()
        Dim conStringg As String = connstring
        Dim query As String = "Select Product_ID FROM product WHERE `instock` < `Average_Quantity`"

        Dim countOut As Int16 = 0

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
                        countOut += 1
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


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim H As String = Convert.ToInt16(DateTime.Now.ToString("hh")) + 1
        Dim M As String = DateTime.Now.ToString("mm")
        Dim S As String = DateTime.Now.ToString("ss")
        Dim T As String = DateTime.Now.ToString("tt")
        lblTimer.Text = H + ":" + M + ":" + S + " " + T
        LblCompanyName.Text = CompanyName1
    End Sub

    Private Sub BtnMakeSales_Click(sender As Object, e As EventArgs) Handles btnMakeSales.Click
        Try
            ColorClear()
            btnMakeSales.FillColor = Color.FromArgb(43, 102, 121)
            btnMakeSales.ForeColor = Color.Gold

            Closings()


            Frm_Sale.MdiParent = Me
            Frm_Sale.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateProductToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UpdateProductToolStripMenuItem.Click
        Try
            ColorClear()
            Closings()

            frmCheck_Stock.MdiParent = Me

            frmCheck_Stock.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListOfProductToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListOfProductToolStripMenuItem1.Click
        Try
            ColorClear()
            Closings()

            Frm_ListOfProduct.MdiParent = Me

            Frm_ListOfProduct.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StatisticsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StatisticsToolStripMenuItem1.Click
        Try
            ColorClear()
            Closings()

            FrmStatics.MdiParent = Me
            FrmStatics.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListOfUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfUsersToolStripMenuItem.Click
        Try
            ColorClear()
            Closings()


            User_Lists.MdiParent = Me

            User_Lists.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MyProfitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MyProfitToolStripMenuItem1.Click
        Try
            ColorClear()
            Closings()

            Frm_Profit.MdiParent = Me

            Frm_Profit.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GeneralReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralReportToolStripMenuItem.Click
        Try
            ColorClear()
            Closings()

            FrmReport.MdiParent = Me
            FrmReport.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCategoryToolStripMenuItem.Click
        Try
            ColorClear()
            Closings()

            Frm_Addtype.MdiParent = Me
            Frm_Addtype.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem.Click

        Try
            ColorClear()
            Btn_AddSaler.FillColor = Color.FromArgb(43, 102, 121)
            Btn_AddSaler.ForeColor = Color.Gold

            Closings()

            FrmAddSeler.MdiParent = Me
            FrmAddSeler.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SystemManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemManagementToolStripMenuItem.Click
        Try
            ColorClear()
            Closings()

            Frm_GenSettings.MdiParent = Me
            Frm_GenSettings.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckInvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInvoicesToolStripMenuItem.Click
        Try
            ColorClear()
            Closings()
            FrmInoiceCheck.MdiParent = Me
            FrmInoiceCheck.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class