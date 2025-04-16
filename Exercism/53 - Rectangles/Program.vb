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
        Console.WriteLine(Rectangles.Count(rows)) ' Saída esperada: 6
    End Sub
End Module