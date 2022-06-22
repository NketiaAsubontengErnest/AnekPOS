Imports MySql.Data.MySqlClient

Public Class frm_PointOfSale
    ' Dim name As String
    Dim ID As String

    Private Sub btn_close_Click(sender As Object, e As EventArgs)

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub btn_Maximize_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub btn_Minimize_Click_1(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized

    End Sub
    Private Sub btn_close_Click_1(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click

    End Sub

    Private Sub btn_MySale_Click(sender As Object, e As EventArgs) Handles btn_MySale.Click
        frm_MySales.MdiParent = Me

        frm_MySales.Show()

        frm_Sale.Close()
        frm_ChanegePassword.Close()
        frmReport.Close()
    End Sub

    Private Sub btn_Sale_Click(sender As Object, e As EventArgs) Handles btn_Sale.Click
        frm_Sale.MdiParent = Me

        frm_Sale.Show()

        frm_MySales.Close()
        frmReport.Close()
        frm_ChanegePassword.Close()
    End Sub

    Private Sub btn_close_Click_2(sender As Object, e As EventArgs) Handles btn_close.Click

        If isClosed() Then
            Me.Close()
        Else
            Dim ans As DialogResult = MsgBox("Do You Want To Close Account Before Exiting? ", MsgBoxStyle.YesNo, "Confirm Close Account")

            If ans = DialogResult.Yes Then
                dailySales()
                Me.Close()
            ElseIf ans = DialogResult.No Then
                Me.Close()
            End If

        End If

    End Sub


    Public Function isClosed()
        Dim conStringg As String = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"
        Dim query As String = "SELECT isClosed from dailysales where employeeID='" + frm_AdminDas.lblUserID.Text + "'
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

    Public Sub dailySales()

        Dim command As MySqlCommand
        Dim insertString_EmpDetiles As String = ""
        Dim connection = New MySqlConnection

        connection.ConnectionString = "server=localhost;userid=root;password=0554013980A@;database=point_of_sale"

        Try


            connection.Open()
            insertString_EmpDetiles = "INSERT INTO dailysales (employeeID,totalsales,date,datePrepared,isClosed) VALUES (
                                                                   '" + lblUserID.Text + "',
                                                                   '" + lbl_TotalSales.Text + "',
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
        'End While

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

    Private Sub btn_Minimize_Click_2(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frm_ChanegePassword.MdiParent = Me

        frm_ChanegePassword.Show()

    End Sub

    Private Sub ViewReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReportToolStripMenuItem.Click
        frmReport.MdiParent = Me

        frmReport.Show()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) 
        frmLogin.Show()

        Me.Close()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        frm_AdminDas.lblUserID.Text = ""
        frm_AdminDas.lblTime.Text = ""
        frm_AdminDas.lblRole.Text = ""
        Me.Close()

    End Sub

    Private Sub frm_PointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserID.Text = (frmLogin.txt_Username.Text).ToUpper
        frm_Sale.calculateSales(lblUserID.Text)
    End Sub
End Class