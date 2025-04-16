Imports System

Module Program
    Public Sub Main()
        ' Testando o m�todo Steps com diferentes n�meros
        Dim numbers As Integer() = {12, 5, 7, 10, 1, 0, -5}

        For Each number In numbers
            Try
                Dim result As Integer = CollatzConjecture.Steps(number)
                Console.WriteLine($"Para o n�mero {number}, o n�mero de passos � {result}.")
            Catch ex As ArgumentOutOfRangeException
                Console.WriteLine($"Erro: {ex.Message} para o n�mero {number}.")
            End Try
        Next
    End Sub
End Module