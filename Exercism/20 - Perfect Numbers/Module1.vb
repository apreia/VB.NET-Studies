Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Enum Classification
    Perfect
    Abundant
    Deficient
End Enum

Public Module PerfectNumbers
    Public Function Classify(ByVal number As Integer) As Classification
        If number <= 0 Then
            ' Lança ArgumentOutOfRangeException conforme esperado pelos testes
            Throw New ArgumentOutOfRangeException("number", "O número deve ser um inteiro positivo maior que zero.")
        End If

        ' Calcula a soma dos divisores próprios
        Dim aliquotSum As Integer = Enumerable.Range(1, number \ 2) _
            .Where(Function(divisor) number Mod divisor = 0) _
            .Sum()

        ' Determina a classificação com base na soma de alíquota
        If aliquotSum = number Then
            Return Classification.Perfect
        ElseIf aliquotSum > number Then
            Return Classification.Abundant
        Else
            Return Classification.Deficient
        End If
    End Function
End Module