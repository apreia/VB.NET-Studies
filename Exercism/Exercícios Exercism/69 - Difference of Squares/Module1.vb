Imports System

Public Module DifferenceOfSquares
    ' Calcula o quadrado da soma dos primeiros N números naturais
    Public Function CalculateSquareOfSum(ByVal max As Integer) As Integer
        Dim sum As Integer = (max * (max + 1)) / 2 ' Fórmula da soma dos N primeiros números
        Return sum * sum ' Retorna o quadrado da soma
    End Function

    ' Calcula a soma dos quadrados dos primeiros N números naturais
    Public Function CalculateSumOfSquares(ByVal max As Integer) As Integer
        Return (max * (max + 1) * (2 * max + 1)) / 6 ' Fórmula para a soma dos quadrados
    End Function

    ' Calcula a diferença entre o quadrado da soma e a soma dos quadrados
    Public Function CalculateDifferenceOfSquares(ByVal max As Integer) As Integer
        Dim squareOfSum As Integer = CalculateSquareOfSum(max) ' Calcula o quadrado da soma
        Dim sumOfSquares As Integer = CalculateSumOfSquares(max) ' Calcula a soma dos quadrados
        Return squareOfSum - sumOfSquares ' Retorna a diferença entre os dois valores
    End Function
End Module