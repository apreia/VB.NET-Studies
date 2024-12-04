Imports System

Module Program
    Sub Main()
        ' Exemplo de cesta de livros
        Dim books As Integer() = {1, 1, 2, 2, 3, 3, 4, 5}
        Dim totalCost As Decimal = BookStore.Total(books)

        ' Exibir o preço total
        Console.WriteLine("Preço total: $" & totalCost)
    End Sub
End Module