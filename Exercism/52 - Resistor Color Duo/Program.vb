Imports System

Module Program
    Sub Main()
        Dim resistorColors1 As String() = {"brown", "green"}
        Dim resistorColors2 As String() = {"red", "blue", "violet"}

        Console.WriteLine($"Valor do resistor (brown-green): {ResistorColorDuo.Value(resistorColors1)}") ' Sa�da: 15
        Console.WriteLine($"Valor do resistor (red-blue-violet): {ResistorColorDuo.Value(resistorColors2)}") ' Sa�da: 26
    End Sub
End Module