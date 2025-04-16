Imports System

Public Module LargestSeriesProduct
    Public Function GetLargestProduct(ByVal digits As String, ByVal span As Integer) As Long
        ' Verifica se a string de dígitos está vazia e se o span é maior que 0
        If String.IsNullOrEmpty(digits) AndAlso span > 0 Then
            Throw New ArgumentException("Empty string and non-zero span.")
        End If

        ' Verifica se o span é maior que o comprimento da string ou se o span é menor ou igual a zero
        If span > digits.Length OrElse span <= 0 Then
            Throw New ArgumentException("Invalid span value.")
        End If

        ' Verifica se todos os caracteres na string são dígitos
        If Not digits.All(Function(c) Char.IsDigit(c)) Then
            Throw New ArgumentException("The input string contains invalid characters.")
        End If

        ' Variável para armazenar o maior produto
        Dim maxProduct As Long = 0

        ' Itera pelas séries possíveis na sequência de dígitos
        For i As Integer = 0 To digits.Length - span
            ' Extrai a série de dígitos da posição atual até o tamanho da série
            Dim series As String = digits.Substring(i, span)

            ' Calcula o produto da série
            Dim product As Long = 1
            For Each digit As Char In series
                product *= Convert.ToInt32(digit.ToString()) ' Converte o caractere para inteiro e multiplica
            Next

            ' Atualiza o maior produto, se necessário
            If product > maxProduct Then
                maxProduct = product
            End If
        Next

        Return maxProduct
    End Function
End Module