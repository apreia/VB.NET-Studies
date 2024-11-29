Imports System

Module Program
    Sub Main(args As String())
        ' Solicita o limite ao usu�rio
        Console.WriteLine("Digite o limite para encontrar n�meros primos (>= 2):")
        Dim input As String = Console.ReadLine()
        Dim limit As Integer

        If Integer.TryParse(input, limit) Then
            Try
                ' Chama a fun��o Primes para encontrar os n�meros primos
                Dim primeNumbers As Integer() = Primes(limit)

                ' Exibe os n�meros primos
                Console.WriteLine($"Os n�meros primos menores ou iguais a {limit} s�o:")
                Console.WriteLine(String.Join(", ", primeNumbers))
            Catch ex As ArgumentOutOfRangeException
                Console.WriteLine($"Erro: {ex.Message}")
            End Try
        Else
            Console.WriteLine("Entrada inv�lida. Por favor, insira um n�mero inteiro.")
        End If

        ' Aguarda o usu�rio pressionar uma tecla para sair
        Console.ReadKey()
    End Sub
End Module