Imports System

Module Program
    Sub Main(args As String())
        Dim A As New List(Of Integer)({1, 2, 3})
        Dim B As New List(Of Integer)({1, 2, 3, 4, 5})

        Console.WriteLine(Sublist.Classify(A, B))  ' Saída: Sublist
        Console.WriteLine(Sublist.Classify(B, A))  ' Saída: Superlist
        Console.WriteLine(Sublist.Classify(A, A))  ' Saída: Equal
        Console.WriteLine(Sublist.Classify(New List(Of Integer)({1, 2, 4}), B))  ' Saída: Unequal
    End Sub
End Module