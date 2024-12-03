Imports System

Public Module Minesweeper
    Public Function Annotate(ByVal input As String()) As String()
        Dim rows As Integer = input.Length
        Dim cols As Integer = If(rows > 0, input(0).Length, 0)
        Dim output As String() = New String(rows - 1) {}

        For row As Integer = 0 To rows - 1
            Dim annotatedRow As Char() = input(row).ToCharArray()
            For col As Integer = 0 To cols - 1
                If input(row)(col) = "*"c Then
                    Continue For
                End If

                Dim mineCount As Integer = CountAdjacentMines(input, row, col)
                If mineCount > 0 Then
                    annotatedRow(col) = ChrW(mineCount + AscW("0"c))
                Else
                    annotatedRow(col) = " "c
                End If
            Next
            output(row) = New String(annotatedRow)
        Next

        Return output
    End Function

    Private Function CountAdjacentMines(ByVal board As String(), ByVal row As Integer, ByVal col As Integer) As Integer
        Dim count As Integer = 0
        For i As Integer = -1 To 1
            For j As Integer = -1 To 1
                If i = 0 AndAlso j = 0 Then
                    Continue For
                End If

                Dim newRow As Integer = row + i
                Dim newCol As Integer = col + j
                If newRow >= 0 AndAlso newRow < board.Length AndAlso newCol >= 0 AndAlso newCol < board(newRow).Length AndAlso board(newRow)(newCol) = "*"c Then
                    count += 1
                End If
            Next
        Next
        Return count
    End Function
End Module