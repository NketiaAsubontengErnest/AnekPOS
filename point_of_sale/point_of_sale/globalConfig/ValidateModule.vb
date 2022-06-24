Module ValidateModule
    Function ValidateMoney(e As KeyPressEventArgs) As Boolean
        Dim bools As Boolean = False
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) = 46 Then
                Else
                    bools = True
                End If
            End If
        End If
        Return bools
    End Function

    Function ValidateNumbers(e As KeyPressEventArgs) As Boolean
        Dim bools As Boolean = False
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                bools = True
            End If
        End If
        Return bools
    End Function

    Function ValidateNames(e As KeyPressEventArgs) As Boolean
        Dim bools As Boolean = False
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32) Then
                bools = True
            End If
        End If
        Return bools
    End Function

End Module
