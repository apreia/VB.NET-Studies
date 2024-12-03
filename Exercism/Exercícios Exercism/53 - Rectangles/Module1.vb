Imports System

Public Module Rectangles
    Public Function Count(ByVal rows As String()) As Integer
        ' Verificar se a entrada está vazia
        If rows Is Nothing OrElse rows.Length = 0 Then
            Return 0
        End If

        Dim rowCount As Integer = rows.Length
        Dim colCount As Integer = rows(0).Length
        Dim corners As List(Of Corner) = New List(Of Corner)()

        ' Identificar todos os cantos representados por '+'
        For r As Integer = 0 To rowCount - 1
            For c As Integer = 0 To colCount - 1
                If rows(r)(c) = "+"c Then
                    corners.Add(New Corner(r, c))
                End If
            Next
        Next

        Dim rectangleCount As Integer = 0

        ' Para cada par de cantos possíveis
        For i As Integer = 0 To corners.Count - 1
            For j As Integer = i + 1 To corners.Count - 1
                Dim corner1 As Corner = corners(i)
                Dim corner2 As Corner = corners(j)

                ' Verificar se formam uma diagonal válida de um retângulo
                If corner1.Row < corner2.Row AndAlso corner1.Col < corner2.Col Then
                    ' Garantir que o retângulo é fechado
                    If IsHorizontalLine(rows, corner1.Row, corner1.Col, corner2.Col) AndAlso
                       IsHorizontalLine(rows, corner2.Row, corner1.Col, corner2.Col) AndAlso
                       IsVerticalLine(rows, corner1.Row, corner2.Row, corner1.Col) AndAlso
                       IsVerticalLine(rows, corner1.Row, corner2.Row, corner2.Col) Then
                        rectangleCount += 1
                    End If
                End If
            Next
        Next

        Return rectangleCount
    End Function

    ' Estrutura para representar um canto
    Private Structure Corner
        Public Row As Integer
        Public Col As Integer
        Public Sub New(ByVal row As Integer, ByVal col As Integer)
            Me.Row = row
            Me.Col = col
        End Sub
    End Structure

    ' Verifica se há uma linha horizontal válida entre duas colunas
    Private Function IsHorizontalLine(ByVal rows As String(), ByVal row As Integer, ByVal col1 As Integer, ByVal col2 As Integer) As Boolean
        For c As Integer = col1 To col2
            If rows(row)(c) <> "-"c AndAlso rows(row)(c) <> "+"c Then
                Return False
            End If
        Next
        Return True
    End Function

    ' Verifica se há uma linha vertical válida entre duas linhas
    Private Function IsVerticalLine(ByVal rows As String(), ByVal row1 As Integer, ByVal row2 As Integer, ByVal col As Integer) As Boolean
        For r As Integer = row1 To row2
            If rows(r)(col) <> "|"c AndAlso rows(r)(col) <> "+"c Then
                Return False
            End If
        Next
        Return True
    End Function
End Module