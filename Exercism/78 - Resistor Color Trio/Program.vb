Imports System

Module Program
    Sub Main(args As String())
        ' Exemplo de entrada com as cores
        Dim colors As String() = {"yellow", "violet", "yellow"}

        ' Exibindo o valor do resistor no console
        Console.WriteLine(ResistorColorTrio.Label(colors))
    End Sub
End Module