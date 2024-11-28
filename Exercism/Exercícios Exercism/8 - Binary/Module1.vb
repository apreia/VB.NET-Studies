Public Class Binary
    Private binaryValue As String

    Public Sub New(value As String)
        ' Validar se a string contém apenas '0' e '1'. Se não, a string será tratada como inválida.
        If String.IsNullOrWhiteSpace(value) OrElse Not value.All(Function(c) c = "0"c OrElse c = "1"c) Then
            binaryValue = "" ' Se inválido, definimos o valor como uma string vazia.
        Else
            binaryValue = value
        End If
    End Sub

    Public Function ToDecimal() As Integer
        ' Se a string binária for inválida (vazia), retornamos 0.
        If String.IsNullOrEmpty(binaryValue) Then
            Return 0
        End If

        Dim decimalValue As Integer = 0
        Dim power As Integer = 0

        ' Iterar da direita para a esquerda, somando as potências de 2
        For i As Integer = binaryValue.Length - 1 To 0 Step -1
            If binaryValue(i) = "1"c Then
                decimalValue += Math.Pow(2, power)
            End If
            power += 1
        Next

        Return decimalValue
    End Function
End Class