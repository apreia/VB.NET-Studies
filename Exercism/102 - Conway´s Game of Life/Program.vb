Module Program
    Sub Main()
        Dim initialGrid As New List(Of List(Of Integer)) From {
            New List(Of Integer) From {0, 1, 0},
            New List(Of Integer) From {0, 1, 0},
            New List(Of Integer) From {0, 1, 0}
        }

        Dim game As New GameOfLife(initialGrid)

        Console.WriteLine("Geração Inicial:")
        PrintMatrix(game.Matrix())

        game.Tick()

        Console.WriteLine(vbCrLf & "Próxima Geração:")
        PrintMatrix(game.Matrix())
    End Sub

    Private Sub PrintMatrix(matrix As List(Of List(Of Integer)))
        For Each row In matrix
            For Each cell In row
                Console.Write(cell & " ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module