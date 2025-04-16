Imports System

Module Program
    Sub Main(args As String())
        Dim coins As Integer() = {1, 5, 10, 25, 100}
        Dim target As Integer = 40
        Dim result = Change.FindFewestCoins(coins, target)

        Console.WriteLine("Moedas necessárias: " & String.Join(", ", result))
    End Sub
End Module