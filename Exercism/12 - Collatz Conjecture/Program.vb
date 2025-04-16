Imports System

Module Program
    Public Sub Main()
        ' Testando o método Steps com diferentes números
        Dim numbers As Integer() = {12, 5, 7, 10, 1, 0, -5}

        For Each number In numbers
            Try
                Dim result As Integer = CollatzConjecture.Steps(number)
                Console.WriteLine($"Para o número {number}, o número de passos é {result}.")
            Catch ex As ArgumentOutOfRangeException
                Console.WriteLine($"Erro: {ex.Message} para o número {number}.")
            End Try
        Next
    End Sub
End Module