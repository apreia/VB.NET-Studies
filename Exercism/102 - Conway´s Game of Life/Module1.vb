Imports System
Imports System.Collections.Generic

Public Class GameOfLife
    Private _grid As List(Of List(Of Integer))
    Private ReadOnly _rows As Integer
    Private ReadOnly _cols As Integer

    Public Sub New(initialGrid As List(Of List(Of Integer)))
        _grid = initialGrid
        _rows = _grid.Count
        _cols = If(_rows > 0, _grid(0).Count, 0)
    End Sub

    Public Function Tick() As List(Of List(Of Integer))
        Dim nextGrid = CreateEmptyGrid(_rows, _cols)

        For row = 0 To _rows - 1
            For col = 0 To _cols - 1
                Dim currentCell = _grid(row)(col)
                Dim liveNeighbors = CountLiveNeighbors(row, col)

                nextGrid(row)(col) = GetNextCellState(currentCell, liveNeighbors)
            Next
        Next

        _grid = nextGrid
        Return _grid
    End Function

    Public Function Matrix() As List(Of List(Of Integer))
        Return _grid
    End Function

    Private Function GetNextCellState(current As Integer, neighbors As Integer) As Integer
        If current = 1 AndAlso (neighbors = 2 OrElse neighbors = 3) Then
            Return 1
        ElseIf current = 0 AndAlso neighbors = 3 Then
            Return 1
        End If
        Return 0
    End Function

    Private Function CountLiveNeighbors(row As Integer, col As Integer) As Integer
        Dim count = 0

        For i = Math.Max(0, row - 1) To Math.Min(_rows - 1, row + 1)
            For j = Math.Max(0, col - 1) To Math.Min(_cols - 1, col + 1)
                If i = row AndAlso j = col Then Continue For
                count += _grid(i)(j)
            Next
        Next

        Return count
    End Function

    Private Function CreateEmptyGrid(rows As Integer, cols As Integer) As List(Of List(Of Integer))
        Dim grid As New List(Of List(Of Integer))
        For i = 0 To rows - 1
            Dim row As New List(Of Integer)(New Integer(cols - 1) {})
            grid.Add(row)
        Next
        Return grid
    End Function
End Class