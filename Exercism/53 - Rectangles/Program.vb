Imports System

Module Program
    Sub Main(args As String())
        Dim rows As String() = {
    "   +--+",
    "  ++  |",
    "+-++--+",
    "|  |  |",
    "+--+--+"
}
        Console.WriteLine(Rectangles.Count(rows)) ' Sa�da esperada: 6
    End Sub
End Module