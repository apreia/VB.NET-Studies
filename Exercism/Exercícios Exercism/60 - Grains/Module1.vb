Imports System

Public Module Grains
    ' Função para calcular o número de grãos no quadrado n
    Public Function Square(ByVal n As Integer) As ULong
        ' Verificar se o número do quadrado é válido (de 1 a 64)
        If n < 1 Or n > 64 Then
            Throw New ArgumentOutOfRangeException("n", "O número do quadrado deve estar entre 1 e 64.")
        End If

        ' Usar o tipo ULong para o cálculo (limite de 64 bits)
        Return CType(Math.Pow(2, n - 1), ULong)
    End Function

    ' Função para calcular o número total de grãos em todos os 64 quadrados
    Public Function Total() As ULong
        Dim totalGrains As ULong = 0
        For i As Integer = 1 To 64
            totalGrains += Square(i)
        Next
        Return totalGrains
    End Function
End Module