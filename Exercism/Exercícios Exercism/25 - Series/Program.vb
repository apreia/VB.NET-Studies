Imports System

Module Program
    Sub Main()
        Dim numbers As String = "49142"
        Dim sliceLength As Integer = 3

        Try
            ' Obter as subsequências
            Dim slices As String() = Series.Slices(numbers, sliceLength)

            ' Exibir as subsequências
            For Each slice As String In slices
                Console.WriteLine(slice)
            Next
        Catch ex As ArgumentException
            ' Exibir a mensagem de erro caso ocorra uma exceção
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module