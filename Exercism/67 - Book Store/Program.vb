Imports System

Module Program
    Sub Main()
        ' Exemplo de cesta de livros
        Dim books As Integer() = {1, 1, 2, 2, 3, 3, 4, 5}
        Dim totalCost As Decimal = BookStore.Total(books)

        ' Exibir o pre�o total
        Console.WriteLine("Pre�o total: $" & totalCost)
    End Sub
End Module