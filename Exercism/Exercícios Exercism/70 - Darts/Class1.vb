Imports System

Public Module Darts
    Public Function Score(ByVal x As Double, ByVal y As Double) As Integer
        ' Calcula a distância do ponto (x, y) até a origem (0, 0)
        Dim distance As Double = Math.Sqrt(x * x + y * y)

        ' Verifica em qual região do alvo o dardo caiu
        If distance > 10 Then
            Return 0 ' Fora do alvo
        ElseIf distance > 5 Then
            Return 1 ' Círculo externo
        ElseIf distance > 1 Then
            Return 5 ' Círculo central
        Else
            Return 10 ' Círculo interno
        End If
    End Function
End Module