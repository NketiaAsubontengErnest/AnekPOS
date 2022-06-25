Imports MySql.Data.MySqlClient

Public Class FrmAddSeler

    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub txt_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Name.KeyPress
        e.Handled = ValidateNames(e)
    End Sub

    Private Sub txt_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Phone.KeyPress
        e.Handled = ValidateNumbers(e)
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        clear()

    End Sub

    Public Sub clear()
        txt_Name.Clear()
        txt_Password.Clear()
        txt_Phone.Clear()
        txt_Name.Focus()
        txt_Address.Clear()
        cmd_position.Text = ""
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Insert_to_Empdetails()
    End Sub
    Public Sub Insert_to_login()
        Dim Pass As String = Encrypt(txt_Password.Text)
        query = "INSERT INTO `login` (`employeeID`, `password`, `position`, `block`) VALUES 
                                                      ('" & (txt_UserID.Text).ToUpper & "', 
                                                      '" & Pass & "', 
                                                      '" & (cmd_position.Text).ToUpper & "',
                                                      'NO')"
        Try
            reader = Inserting(query)
            If reader.RecordsAffected > 0 Then
                MsgBox("Employee added Successfully", MsgBoxStyle.Information)
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        generateID()

    End Sub

    Public Sub Insert_to_Empdetails()
        If Not CheckExist("SELECT * FROM `employee` where employeeID = '" + (txt_UserID.Text).ToUpper + "'") Then
            If CheckExist("SELECT * FROM `employee` where Phone = '" + (txt_Phone.Text).ToUpper + "'") Then
                MsgBox("The Number is used by another employee!!!", MsgBoxStyle.Critical)
            Else
                query = "INSERT INTO `employee` (`employeeID`, `name`, `phone`, `address`, `position`,`block`) VALUES  
                                                              ('" & (txt_UserID.Text).ToUpper & "', 
                                                              '" & (txt_Name.Text).ToUpper & "', 
                                                              '" & (txt_Phone.Text).ToUpper & "', 
                                                              '" & (txt_Address.Text).ToUpper & "',
                                                              '" & (cmd_position.Text).ToUpper & "',
                                                              'NO'
                                                              )"
                Try
                    reader = Inserting(query)
                    If reader.RecordsAffected > 0 Then
                        Insert_to_login()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        Else

        End If

    End Sub

    Public Sub check_id(ByVal EmpId As String, ByVal Number As String, ByVal oldc As Integer)
        Dim count As Integer
        Dim conString As String = connstring

        Dim queryex As String = "SELECT * FROM  employee where employeeID = '" + EmpId + "'"

        cmd = New MySqlCommand(queryex, conn)

        Using conn As New MySqlConnection(conString)
            Using command As New MySqlCommand
                With command
                    .Connection = conn
                    .CommandText = queryex

                End With

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader

                    While reader.Read
                        count += 1
                    End While
                Catch ex As Exception

                Finally
                    conn.Close()

                End Try
            End Using
        End Using

        If count > 0 Then
            oldc += 1
            EmpId = "EMP" + Number + oldc.ToString
            check_id(EmpId, Number, count)
        Else
            txt_UserID.Text = EmpId
        End If
    End Sub

    Public Sub generateID()

        Dim conString As String = connstring
        Dim query As String = "SELECT * FROM `employee`"

        Dim count As Integer = 0
        Dim number As String = ""

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
                        count += 1
                    End While
                Catch ex As Exception

                End Try
            End Using
        End Using

        If count < 10 Then
            number = "000"
        ElseIf count < 100 Then
            number = "00"
        ElseIf count < 1000 Then
            number = "0"
        End If

        count += 1
        Dim proId As String = "EMP" + number + count.ToString
        check_id(proId, number, count)

    End Sub

    Private Sub frmAddSeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateID()
    End Sub
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        colorClear()
        Me.Close()

    End Sub

End Class