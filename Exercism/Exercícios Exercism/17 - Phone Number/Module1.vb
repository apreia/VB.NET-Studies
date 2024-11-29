Public Class PhoneNumber
    Public Shared Function Clean(ByVal phoneNumber As String) As String
        ' Remove todos os caracteres que não sejam dígitos
        Dim cleanedNumber As String = New String(phoneNumber.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Verifica se há um código de país válido (1) no início e o remove
        If cleanedNumber.StartsWith("1") AndAlso cleanedNumber.Length = 11 Then
            cleanedNumber = cleanedNumber.Substring(1)
        End If

        ' Verifica se o número tem exatamente 10 dígitos após o processamento
        If cleanedNumber.Length <> 10 Then
            Throw New ArgumentException("Número inválido.")
        End If

        ' Verifica se o código de área e o código de troca começam com dígitos válidos (2-9)
        If cleanedNumber(0) < "2"c OrElse cleanedNumber(3) < "2"c Then
            Throw New ArgumentException("Número inválido.")
        End If

        Return cleanedNumber
    End Function
End Class