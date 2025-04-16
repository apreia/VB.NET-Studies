Imports System

Module Program
    Sub Main(args As String())
        Try
            ' Testando a função com um exemplo
            Dim result As Long = LargestSeriesProduct.GetLargestProduct("639a15", 3)
            Console.WriteLine(result) ' Aqui vai lançar ArgumentException
        Catch ex As ArgumentException
            ' Exibe a mensagem de erro no console
            Console.WriteLine("Erro esperado: " & ex.Message)
        End Try
    End Sub
End Module