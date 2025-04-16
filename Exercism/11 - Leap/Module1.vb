Public Module Leap
    Public Function IsLeapYear(ByVal year As Integer) As Boolean
        ' Verifica se o ano é divisível por 400
        If year Mod 400 = 0 Then
            Return True
            ' Verifica se o ano é divisível por 100, mas não por 400
        ElseIf year Mod 100 = 0 Then
            Return False
            ' Verifica se o ano é divisível por 4, mas não por 100
        ElseIf year Mod 4 = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module