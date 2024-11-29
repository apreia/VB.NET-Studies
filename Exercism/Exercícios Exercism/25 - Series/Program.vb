Imports System

Module Program
    Sub Main()
        Dim numbers As String = "49142"
        Dim sliceLength As Integer = 3

        Try
            ' Obter as subsequ�ncias
            Dim slices As String() = Series.Slices(numbers, sliceLength)

            ' Exibir as subsequ�ncias
            For Each slice As String In slices
                Console.WriteLine(slice)
            Next
        Catch ex As ArgumentException
            ' Exibir a mensagem de erro caso ocorra uma exce��o
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module