Imports System
Imports System.Linq

Public Module BookStore
    ' Definir o preço fixo para cada livro
    Private Const BookPrice As Decimal = 8D

    ' Função principal para calcular o preço total
    Public Function Total(ByVal books As Integer()) As Decimal
        ' Se não houver livros, o preço total será 0
        If books.Length = 0 Then Return 0.0D

        ' Agrupar livros pelo título e contar a quantidade de cada
        Dim bookGroups = BookGroupsWithCount(books)

        ' Calcular o preço total, tentando remover livros de grupos de forma otimizada
        Return Enumerable.Range(1, bookGroups.Length).Min(Function(size) CalculateTotalCost(bookGroups, size, 0.0D))
    End Function

    ' Função para agrupar os livros e contar quantos de cada tipo existem
    Private Function BookGroupsWithCount(ByVal books As Integer()) As Integer()
        ' Agrupar os livros pelo título e contar a quantidade de cada
        Return books.GroupBy(Function(book) book).
                    [Select](Function(book) book.Count()).
                    OrderByDescending(Function(book) book).ToArray()
    End Function

    ' Função recursiva para calcular o custo total removendo livros
    Private Function CalculateTotalCost(ByVal bookGroups As Integer(), ByVal numberOfBooksToRemove As Integer, ByVal totalCost As Decimal) As Decimal
        ' Calcular quantos livros diferentes podemos remover
        Dim numberOfBooks = Math.Min(numberOfBooksToRemove, bookGroups.Length)

        ' Se não houver mais livros para remover, adicionar o custo regular
        If numberOfBooks = 0 Then
            Return totalCost + RegularPrice(bookGroups.Sum())
        End If

        ' Atualizar os grupos de livros e calcular o custo com o desconto
        Dim updatedBookGroups = RemoveBooks(bookGroups, numberOfBooks)
        Dim updatedTotalCost = totalCost + BooksPrice(numberOfBooks)

        ' Continuar o cálculo recursivamente
        Return CalculateTotalCost(updatedBookGroups, numberOfBooks, updatedTotalCost)
    End Function

    ' Função para remover os livros de um grupo
    Private Function RemoveBooks(ByVal bookGroups As Integer(), ByVal numberOfBooks As Integer) As Integer()
        ' Seleciona os livros para remover e reorganiza os grupos
        Return bookGroups.Take(numberOfBooks).
                          [Select](New Func(Of Integer, Integer)(AddressOf RemoveBook)).
                          Concat(bookGroups.Skip(numberOfBooks)).
                          Where(Function(i) i > 0).
                          OrderByDescending(Function(x) x).
                          ToArray()
    End Function

    ' Função para diminuir a quantidade de um livro
    Private Function RemoveBook(ByVal books As Integer) As Integer
        Return books - 1
    End Function

    ' Função para calcular o preço dos livros com desconto
    Private Function BooksPrice(ByVal differentBooks As Integer) As Decimal
        Return ApplyDiscount(RegularPrice(differentBooks), DiscountPercentage(differentBooks))
    End Function

    ' Função para calcular o preço regular (sem desconto) para um determinado número de livros
    Private Function RegularPrice(ByVal books As Integer) As Decimal
        Return books * BookPrice
    End Function

    ' Função para determinar a porcentagem de desconto com base no número de livros diferentes
    Private Function DiscountPercentage(ByVal differentBooks As Integer) As Decimal
        Select Case differentBooks
            Case 5
                Return 25D ' 25% de desconto para 5 livros diferentes
            Case 4
                Return 20D ' 20% de desconto para 4 livros diferentes
            Case 3
                Return 10D ' 10% de desconto para 3 livros diferentes
            Case 2
                Return 5D  ' 5% de desconto para 2 livros diferentes
            Case Else
                Return 0.0D  ' Sem desconto se não houver livros diferentes
        End Select
    End Function

    ' Função para aplicar o desconto ao preço total
    Private Function ApplyDiscount(ByVal price As Decimal, ByVal discountPercentage As Decimal) As Decimal
        Return Math.Round(price * (100D - discountPercentage) / 100D, 2) ' Calcula e arredonda para 2 casas decimais
    End Function
End Module
