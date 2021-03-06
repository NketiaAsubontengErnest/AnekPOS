Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Frm_GenSettings
    Private reader As MySqlDataReader

    Dim ListOfTables As ArrayList = New ArrayList()
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim con As MySqlConnection = New MySqlConnection
    Dim pathstring As String = CompanyLogo
    Dim filextend As String = ""


    Private Sub btn_ResetAll_Click(sender As Object, e As EventArgs) Handles btn_ResetAll.Click


        Dim ans As DialogResult = MsgBox("Do You Want To Reset the whole system? ", MsgBoxStyle.YesNo, "Confirm Close Account")

        If ans = DialogResult.Yes Then
            ListOfTables.Add("dailysales")
            ListOfTables.Add("employee")
            ListOfTables.Add("login")
            ListOfTables.Add("product")
            ListOfTables.Add("producttype")
            ListOfTables.Add("sales")

            Dim conStringg As String = connstring

            Using con As New MySqlConnection(conStringg)
                con.Open()

                Dim i As Integer = 0

                While i < 6
                    Dim cmd As New MySqlCommand("truncate " + ListOfTables.ToArray.GetValue(i).ToString, con)
                    cmd.ExecuteNonQuery()
                    i += 1
                End While
                insert_to_login()
                insert_to_Empdetails()
                MsgBox("System is reseted!!", MsgBoxStyle.Information)
                ListOfTables.Clear()

            End Using
        ElseIf ans = DialogResult.No Then
            ListOfTables.Clear()
        End If
    End Sub

    Public Sub insert_to_login()
        Try
            query = "INSERT INTO `login` (`employeeID`, `password`, `position`, `block`) VALUES 
                                                      ('Emp0001', 
                                                      'guest', 
                                                      'guest',
                                                      'NO')"
            Inserting(query)
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally

            con.Dispose()

        End Try
    End Sub

    Public Sub insert_to_Empdetails()
        Try
            query = "INSERT INTO `employee` (`employeeID`, `name`, `phone`, `address`, `position`,`block`) VALUES  
                                                              ('Emp0001', 
                                                              'guest', 
                                                              '0554013980', 
                                                              'ANEK IT CONSULT',
                                                              'guest',
                                                              'NO')"

            reader = Inserting(query)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
        End Try
    End Sub

    Private Sub btnResetProType_Click(sender As Object, e As EventArgs) Handles btnResetProType.Click
        resetOne("producttype")
    End Sub

    Public Sub resetOne(ByVal tableName As String)
        Dim ans As DialogResult = MsgBox("Do You Want To Reset " + tableName + "? ", MsgBoxStyle.YesNo, "Confirm Close Account")

        If ans = DialogResult.Yes Then


            Dim conStringg As String = connstring

            Using con As New MySqlConnection(conStringg)
                con.Open()

                Dim cmd As New MySqlCommand("truncate " + tableName, con)
                ' MsgBox("truncate " + tableName + "")
                cmd.ExecuteNonQuery()

                MsgBox(tableName + " is reseted!!", MsgBoxStyle.Information)


            End Using
        ElseIf ans = DialogResult.No Then

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resetOne("dailysales")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        resetOne("sales")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resetOne("product")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorClear()
        Me.Close()
    End Sub

    Private Sub btnBack_up_Click(sender As Object, e As EventArgs) Handles btnBack_up.Click
        Try
            With FolderBrowserDialog1
                .SelectedPath = "C:\backup"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim conn As MySqlConnection = New MySqlConnection(connstring)
                    Dim cmd As MySqlCommand = New MySqlCommand
                    cmd.Connection = conn
                    conn.Open()
                    Dim mb As MySqlBackup
                    mb = New MySqlBackup(cmd)
                    mb.ExportToFile(.SelectedPath + "\point_of_sale.sql")
                    conn.Close()
                    MsgBox("Data is backed up to: " + .SelectedPath + " successfully", MsgBoxStyle.Information)

                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        If txt_NewPassword.Text = txt_confPassword.Text Then
            checkCurrentPass()
            clearHere()
        Else
            MsgBox("New Password and Confirm Password do Not Match!!!", MsgBoxStyle.Critical)
            clearHere()
        End If
    End Sub

    Private Sub btn_SaveChanges_Click()
        Try
            query = "Update `login` Set `Password` = '" + Encrypt(txt_NewPassword.Text) + "' WHERE employeeID = '" + txtUserID.Text + "'"

            reader = Updating(query)
            If reader.RecordsAffected > 0 Then
                MsgBox("Password Changed Successfully", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Fatal Error -> Database Not Reacheable")
        End Try


    End Sub

    ''' <summary>
    ''' compare the current password in the database to entered password
    ''' </summary>
    ''' <returns></returns>
    Public Function checkCurrentPass()
        Dim conString As String = connstring
        Dim query As String
        query = "SELECT * FROM login WHERE employeeID = '" + txtUserID.Text + "'"

        Dim correct As Boolean = True
        Dim password As String = ""

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
                        password = reader.Item("password")
                    End While
                    Dim pass As String = Decrypt(password)
                    conn.Close()
                    reader.Close()
                    If pass = txt_currentPassword.Text Then
                        btn_SaveChanges_Click()
                    Else
                        correct = False
                        MsgBox("Old password Invalid")
                    End If

                Catch ex As Exception


                End Try
            End Using
        End Using

        Return correct

    End Function
    Private Sub clearHere()
        txt_currentPassword.Clear()
        txt_confPassword.Clear()
        txt_NewPassword.Clear()
    End Sub

    Private Sub frm_ChanegePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Text = Frm_AdminDas.lblUserID.Text
        LoadCompanyDetails1()
    End Sub

    Private Sub txt_confPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_confPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txt_NewPassword.Text = txt_confPassword.Text Then
                checkCurrentPass()
                clearHere()
            Else
                ToolTip1.Show("Passwords do not match", txt_confPassword, 2000)
                clearHere()
            End If
        End If
    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click
        If TxtCompanyName.Text = "" Then
            ToolTip1.Show("Company Name required", TxtCompanyName, 2000)
            TxtCompanyName.Focus()

        ElseIf TxtPhone1.Text = "" Then
            ToolTip1.Show("This field is required", TxtPhone1, 2000)
            TxtPhone1.Focus()

        ElseIf TxtLocation.Text = "" Then
            ToolTip1.Show("This field is required", TxtLocation, 2000)
            TxtLocation.Focus()

        ElseIf TxtCountry.Text = "" Then
            ToolTip1.Show("This field is required", TxtCountry, 2000)
            TxtCountry.Focus()
        Else
            Dim word = TxtCompanyName.Text.Split
            Dim filename = ""
            If Not PicCompanyLogo.Image Is Nothing Then
                filename = word(0) & filextend
                pathstring = Path.Combine(folder, filename)
                Dim a As Image = PicCompanyLogo.Image
                a.Save(pathstring)
            End If
            Try
                query = "INSERT INTO `companydetails` (`CompanyName`, `CompanyPhone1`, `CompanyPhone2`, `CompanyAddress`,`CompanyLocation`,`CompanyEmail`,`Country`,`CompanyLog`) VALUES  
                                                    ('" + TxtCompanyName.Text + "', 
                                                    '" + TxtPhone1.Text + "', 
                                                    '" + TxtPhone2.Text + "', 
                                                    '" + TxtAddress.Text + "',
                                                    '" + TxtLocation.Text + "',
                                                    '" + TxtEmail.Text + "',
                                                    '" + TxtCountry.Text + "',
                                                    '" + filename + "')"
                reader = Inserting(query)
                If reader.RecordsAffected > 0 Then
                    MsgBox("Company Set Successfully", MsgBoxStyle.Information)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
            End Try
        End If
        LoadCompanyDetails()
        LoadCompanyDetails1()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If TxtCompanyName.Text = "" Then
            ToolTip1.Show("Company Name required", TxtCompanyName, 2000)
            TxtCompanyName.Focus()

        ElseIf TxtPhone1.Text = "" Then
            ToolTip1.Show("This field is required", TxtPhone1, 2000)
            TxtPhone1.Focus()

        ElseIf TxtLocation.Text = "" Then
            ToolTip1.Show("This field is required", TxtLocation, 2000)
            TxtLocation.Focus()

        ElseIf TxtCountry.Text = "" Then
            ToolTip1.Show("This field is required", TxtCountry, 2000)
            TxtCountry.Focus()
        Else
            Dim filename = ""
            Dim word = TxtCompanyName.Text.Split
            If Not PicCompanyLogo.Image Is Nothing Then
                filename = word(0) & filextend
                Dim a As Image = PicCompanyLogo.Image
                If File.Exists(Path.Combine(folder, filename)) Then
                    Dim i As Int16
                    For Each filepath As String In Directory.GetFiles(folder)
                        If filepath = filename Then
                            i += 1
                            filename = word(0) & i & filextend
                        End If
                    Next
                End If
                pathstring = Path.Combine(folder, filename)
                a.Save(pathstring)
                filextend = ""
            End If
                Try
                query = "Update `companydetails` Set `CompanyName` = '" + TxtCompanyName.Text + "',`CompanyPhone1` = '" + TxtPhone1.Text + "',`CompanyPhone2` = '" + TxtPhone2.Text + "',`CompanyAddress` = '" + TxtAddress.Text + "',`CompanyLocation` = '" + TxtLocation.Text + "',`CompanyEmail` = '" + TxtEmail.Text + "',`Country` = '" + TxtCountry.Text + "',`CompanyLog` = '" + filename + "' WHERE id = '" + LblID.Text + "'"

                reader = Updating(query)

                If reader.RecordsAffected > 0 Then
                    MsgBox("Company Updated Successfully", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox("Fatal Error -> Database Not Reacheable")
            End Try
            LoadCompanyDetails()
            LoadCompanyDetails1()
        End If
    End Sub

    Private Sub LoadCompanyDetails1()
        LblID.Text = Companyid
        If LblID.Text = "" Then
            BtnSet.Enabled = True
            BtnUpdate.Enabled = False
        Else
            BtnSet.Enabled = False
            TxtCompanyName.Text = CompanyName1
            TxtPhone1.Text = CompanyPhone1
            TxtPhone2.Text = CompanyPhone2
            TxtAddress.Text = CompanyAddress
            TxtLocation.Text = CompanyLocation
            TxtEmail.Text = CompanyEmail
            TxtCountry.Text = Country
            If Not CompanyLogo = "" Then
                Dim pathstring As String = Path.Combine(folder, CompanyLogo)
                PicCompanyLogo.Image = Image.FromFile(pathstring)
            End If


        End If

    End Sub

    Private Sub TxtPhone1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone1.KeyPress
        e.Handled = ValidateNumbers(e)
    End Sub

    Private Sub TxtPhone2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone2.KeyPress
        e.Handled = ValidateNumbers(e)
    End Sub

    Private Sub TxtPhone3_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = ValidateNumbers(e)
    End Sub

    Private Sub PicCompanyLogos_Click(sender As Object, e As EventArgs) Handles PicCompanyLogo.Click
        Dim op As OpenFileDialog = New OpenFileDialog
        If op.ShowDialog = DialogResult.OK Then
            filextend = Path.GetExtension(op.FileName)
            If filextend = ".jpg" Or filextend = ".png" Or filextend = ".jpeg" Then
                PicCompanyLogo.Image = Image.FromFile(op.FileName)
            End If
        End If
    End Sub
End Class