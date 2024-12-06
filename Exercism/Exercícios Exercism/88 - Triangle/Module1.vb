Imports System

Public Module Triangle
    ' Função para verificar se o triângulo é escaleno (todos os lados diferentes)
    Public Function IsScalene(ByVal side1 As Double, ByVal side2 As Double, ByVal side3 As Double) As Boolean
        ' Verifica se os lados formam um triângulo válido
        If side1 + side2 > side3 AndAlso side2 + side3 > side1 AndAlso side1 + side3 > side2 Then
            ' Para ser escaleno, todos os lados precisam ser diferentes
            Return side1 <> side2 AndAlso side2 <> side3 AndAlso side1 <> side3
        End If
        Return False
    End Function

    ' Função para verificar se o triângulo é isósceles (pelo menos dois lados iguais)
    Public Function IsIsosceles(ByVal side1 As Double, ByVal side2 As Double, ByVal side3 As Double) As Boolean
        ' Verifica se os lados formam um triângulo válido
        If side1 + side2 > side3 AndAlso side2 + side3 > side1 AndAlso side1 + side3 > side2 Then
            ' Para ser isósceles, pelo menos dois lados precisam ser iguais
            Return side1 = side2 OrElse side2 = side3 OrElse side1 = side3
        End If
        Return False
    End Function

    ' Função para verificar se o triângulo é equilátero (todos os lados iguais)
    Public Function IsEquilateral(ByVal side1 As Double, ByVal side2 As Double, ByVal side3 As Double) As Boolean
        ' Verifica se os lados formam um triângulo válido
        If side1 + side2 > side3 AndAlso side2 + side3 > side1 AndAlso side1 + side3 > side2 Then
            ' Para ser equilátero, todos os lados precisam ser iguais
            Return side1 = side2 AndAlso side2 = side3
        End If
        Return False
    End Function
End Module