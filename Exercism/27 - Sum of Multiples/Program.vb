Imports System

Module Program
    Sub Main()
        Dim multiples As IEnumerable(Of Integer) = New Integer() {0}
        Dim max As Integer = 20
        Console.WriteLine(SumOfMultiples.Sum(multiples, max)) ' Resultado esperado: 0
    End Sub
End Module