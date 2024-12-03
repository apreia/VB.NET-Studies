Imports System

Module Program
    Sub Main()
        Dim input As String() = {
            " * * ",
            "  *  ",
            "  *  ",
            "     "
        }

        Dim result As String() = Minesweeper.Annotate(input)

        Console.WriteLine("Tabuleiro anotado:")
        For Each line In result
            Console.WriteLine(line)
        Next
    End Sub
End Module