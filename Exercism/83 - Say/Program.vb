Imports System

Module Program
    Sub Main(args As String())
        ' Solicitar ao usuário para inserir um número
        Console.WriteLine("Digite um número entre 0 e 999,999,999,999:")
        Dim input As String = Console.ReadLine()

        ' Tentar converter o input para um número Long
        Dim number As Long
        If Long.TryParse(input, number) Then
            Try
                ' Chamar a função que converte o número para o inglês
                Dim result As String = Say.InEnglish(number)
                ' Exibir o resultado no console
                Console.WriteLine($"O número {number} em inglês é: {result}")
            Catch ex As ArgumentOutOfRangeException
                Console.WriteLine($"Erro: {ex.Message}")
            End Try
        Else
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.")
        End If

        ' Manter a janela do console aberta
        Console.ReadLine()
    End Sub
End Module