Imports System

Module Program
    Sub Main(args As String())
        ' Teste de Length
        Dim list1 As New List(Of Integer)({1, 2, 3, 4, 5})
        Console.WriteLine($"Length: {ListOps.Length(list1)}")

        ' Teste de Reverse
        Dim reversedList = ListOps.Reverse(list1)
        Console.WriteLine("Reverse: " & String.Join(", ", reversedList))

        ' Teste de Map
        Dim mappedList = ListOps.Map(list1, Function(x) x * 2)
        Console.WriteLine("Map: " & String.Join(", ", mappedList))

        ' Teste de Filter
        Dim filteredList = ListOps.Filter(list1, Function(x) x > 2)
        Console.WriteLine("Filter: " & String.Join(", ", filteredList))

        ' Teste de Foldl
        Dim sum = ListOps.Foldl(list1, 0, Function(acc, x) acc + x)
        Console.WriteLine($"Foldl (sum): {sum}")

        ' Teste de Foldr
        Dim sumFromRight = ListOps.Foldr(list1, 0, Function(x, acc) x + acc)
        Console.WriteLine($"Foldr (sum): {sumFromRight}")

        ' Teste de Concat
        Dim list2 As New List(Of Integer)({6, 7, 8})
        Dim concatenatedList = ListOps.Concat(New List(Of List(Of Integer))({list1, list2}))
        Console.WriteLine("Concat: " & String.Join(", ", concatenatedList))

        ' Teste de Append
        Dim appendedList = ListOps.Append(list1, list2)
        Console.WriteLine("Append: " & String.Join(", ", appendedList))
    End Sub
End Module