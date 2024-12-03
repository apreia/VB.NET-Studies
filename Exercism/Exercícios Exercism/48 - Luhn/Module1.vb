Imports System

Public Module Luhn
    Public Function IsValid(ByVal number As String) As Boolean
        ' Remover espaços e validar caracteres
        Dim cleanNumber As String = New String(number.Where(Function(c) Not Char.IsWhiteSpace(c)).ToArray())

        ' Validar se a string contém apenas dígitos e se tem mais de 1 caractere
        If cleanNumber.Length <= 1 OrElse Not cleanNumber.All(AddressOf Char.IsDigit) Then
            Return False
        End If

        ' Aplicar o algoritmo de Luhn
        Dim sum As Integer = 0
        Dim doubleDigit As Boolean = False

        ' Percorrer os dígitos de trás para frente
        For i As Integer = cleanNumber.Length - 1 To 0 Step -1
            Dim digit As Integer = Integer.Parse(cleanNumber(i).ToString())

            If doubleDigit Then
                digit *= 2
                If digit > 9 Then
                    digit -= 9
                End If
            End If

            sum += digit
            doubleDigit = Not doubleDigit ' Alternar o estado do doubleDigit
        Next

        ' Verificar se a soma é divisível por 10
        Return sum Mod 10 = 0
    End Function
End Module