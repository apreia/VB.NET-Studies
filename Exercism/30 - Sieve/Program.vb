Imports System

Module Program
    Sub Main(args As String())
        ' Solicita o limite ao usuário
        Console.WriteLine("Digite o limite para encontrar números primos (>= 2):")
        Dim input As String = Console.ReadLine()
        Dim limit As Integer

        If Integer.TryParse(input, limit) Then
            Try
                ' Chama a função Primes para encontrar os números primos
                Dim primeNumbers As Integer() = Primes(limit)

                ' Exibe os números primos
                Console.WriteLine($"Os números primos menores ou iguais a {limit} são:")
                Console.WriteLine(String.Join(", ", primeNumbers))
            Catch ex As ArgumentOutOfRangeException
                Console.WriteLine($"Erro: {ex.Message}")
            End Try
        Else
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.")
        End If

        ' Aguarda o usuário pressionar uma tecla para sair
        Console.ReadKey()
    End Sub
End Module