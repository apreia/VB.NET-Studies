Imports System

Public Class SpiralMatrix
    Public Shared Function GetMatrix(ByVal size As Integer) As Integer(,)
        ' Criar a matriz inicial com valores 0
        Dim matrix(size - 1, size - 1) As Integer
        Dim number As Integer = 1 ' O primeiro número a ser colocado
        Dim top As Integer = 0 ' Limite superior
        Dim bottom As Integer = size - 1 ' Limite inferior
        Dim left As Integer = 0 ' Limite esquerdo
        Dim right As Integer = size - 1 ' Limite direito

        ' Enquanto os limites não se cruzarem
        While top <= bottom AndAlso left <= right
            ' Preencher da esquerda para a direita
            For i = left To right
                matrix(top, i) = number
                number += 1
            Next
            top += 1

            ' Preencher de cima para baixo
            For i = top To bottom
                matrix(i, right) = number
                number += 1
            Next
            right -= 1

            If top <= bottom Then
                ' Preencher da direita para a esquerda
                For i = right To left Step -1
                    matrix(bottom, i) = number
                    number += 1
                Next
                bottom -= 1
            End If

            If left <= right Then
                ' Preencher de baixo para cima
                For i = bottom To top Step -1
                    matrix(i, left) = number
                    number += 1
                Next
                left += 1
            End If
        End While

        Return matrix
    End Function
End Class