Imports MySql.Data.MySqlClient

Public Class frmLogin


    Public Emp_Position, password, EID As String
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()

        frm_AdminDas.lblUserID.Text = ""
        frm_AdminDas.lblTime.Text = ""
        frm_AdminDas.lblRole.Text = ""

    End Sub


    Public Sub login()
        ProgressBar1.Value = 0
        openConnection()
        Dim Pass As String = ""

        query = "SELECT * FROM login WHERE employeeID='" + (txt_Username.Text).ToUpper + "'"

        Dim role As String = ""
        ProgressBar1.Value = 0
        Using conn As New MySqlConnection(connstring)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    If reader.Read Then
                        role = reader("position")
                        Pass = reader("password")
                    End If
                    If (Decrypt(Pass)).Trim = (txt_Password.Text).Trim Then


                        If (role).ToLower = "admin" Then
                            Timer1.Start()
                            frm_AdminDas.Show()

                            frm_AdminDas.lblUserID.Text = (txt_Username.Text).ToUpper
                            frm_AdminDas.lblTime.Text = DateTime.Now.ToString
                            frm_AdminDas.lblRole.Text = role
                            selectUsername()

                            Me.Close()


                        ElseIf (role).ToLower = "sale" Then
                            Timer1.Start()
                            frm_PointOfSale.Show()

                            frm_AdminDas.lblUserID.Text = (txt_Username.Text).ToUpper
                            'frm_PointOfSale.lblUserID.Text = (txt_Username.Text).ToUpper
                            frm_AdminDas.lblTime.Text = DateTime.Now.ToString
                            frm_AdminDas.lblRole.Text = role
                            selectUsername()

                            Me.Close()

                        ElseIf (role).ToLower = "guest" Then
                            Timer1.Start()
                            frm_AdminDas.Show()

                            frm_AdminDas.btn_AddProduct.Enabled = False
                            frm_AdminDas.btn_DailySales.Enabled = False
                            frm_AdminDas.btnMakeSales.Enabled = False
                            frm_AdminDas.Panel1.Visible = False

                            frm_AdminDas.mnSettings.Enabled = False


                            selectUsername()

                            Me.Close()
                        Else
                            MsgBox("No Role Found!!!", MsgBoxStyle.Critical)
                            ProgressBar1.Value = 0
                            txt_Password.Text = ""
                            txt_Password.Focus()
                        End If
                    Else
                        MsgBox("Invalid Login Attempt!!!", MsgBoxStyle.Critical)
                        ProgressBar1.Value = 0
                        txt_Password.Text = ""
                        txt_Password.Focus()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Public Sub selectUsername()
        Dim con1Stringg As String = connstring
        Dim query As String = "SELECT * FROM employee WHERE employeeID='" + (txt_Username.Text).ToUpper + "' "

        Dim role As String = ""

        Using conn As New MySqlConnection(con1Stringg)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    If reader.Read Then
                        frm_AdminDas.lblUserName.Text = reader("name")
                        frm_PointOfSale.lblUserName.Text = reader("name")
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using

        End Using
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Timer1.Start()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Username.Focus()
    End Sub

    Dim inc As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        inc += 4
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            inc = 0
            login()
        Else
            ProgressBar1.Value = inc
        End If
    End Sub



    Public Sub clearMe()
        txt_Username.Text = ""
        txt_Password.Text = ""
        ProgressBar1.Value = 0
        txt_Username.Focus()

    End Sub

End Class
