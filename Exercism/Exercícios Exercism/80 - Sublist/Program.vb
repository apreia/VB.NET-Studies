Imports System

Module Program
    Sub Main(args As String())
        Dim A As New List(Of Integer)({1, 2, 3})
        Dim B As New List(Of Integer)({1, 2, 3, 4, 5})

        Console.WriteLine(Sublist.Classify(A, B))  ' Sa�da: Sublist
        Console.WriteLine(Sublist.Classify(B, A))  ' Sa�da: Superlist
        Console.WriteLine(Sublist.Classify(A, A))  ' Sa�da: Equal
        Console.WriteLine(Sublist.Classify(New List(Of Integer)({1, 2, 4}), B))  ' Sa�da: Unequal
    End Sub
End Module