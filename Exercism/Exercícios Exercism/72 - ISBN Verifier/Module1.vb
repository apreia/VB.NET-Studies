Imports System

Public Module IsbnVerifier
    Public Function IsValid(ByVal number As String) As Boolean
        ' Remova hifens da string
        Dim cleanedNumber As String = number.Replace("-", "").Trim()

        ' Verifique se o comprimento é exatamente 10
        If cleanedNumber.Length <> 10 Then
            Return False
        End If

        Dim sum As Integer = 0

        For i As Integer = 0 To 9
            Dim currentChar As Char = cleanedNumber(i)

            ' Verifique se o último caractere é 'X', caso contrário, deve ser um dígito
            Dim digit As Integer
            If i = 9 AndAlso currentChar = "X"c Then
                digit = 10 ' 'X' é tratado como 10
            ElseIf Not Integer.TryParse(currentChar.ToString(), digit) Then
                Return False ' Caracteres inválidos
            End If

            ' Calcule o peso para este dígito
            sum += digit * (10 - i)
        Next

        ' Um ISBN-10 válido deve ter uma soma divisível por 11
        Return sum Mod 11 = 0
    End Function
End Module