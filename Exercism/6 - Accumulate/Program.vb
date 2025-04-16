Imports System

Module Program
    Sub Main()
        Dim numbers As IEnumerable(Of Integer) = {1, 2, 3, 4, 5}
        Dim squares = numbers.Accumulate(Function(x) x * x)

        Console.WriteLine(String.Join(", ", squares)) ' Saída esperada: 1, 4, 9, 16, 25
    End Sub
End Module