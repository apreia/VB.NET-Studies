Imports System

Module Program
    Sub Main(args As String())
        ' Solicita ao usuário para digitar uma palavra
        Console.WriteLine("Digite uma palavra para calcular a pontuação no Scrabble:")
        Dim input As String = Console.ReadLine()

        ' Calcula a pontuação usando a função Score
        Dim score As Integer = ScrabbleScore.Score(input) ' Chamando corretamente a função

        ' Exibe o resultado
        Console.WriteLine($"A pontuação de '{input}' no Scrabble é: {score}")

        ' Aguarda o usuário pressionar uma tecla para sair
        Console.ReadKey()
    End Sub
End Module