Imports System

Module Program
    Sub Main(args As String())
        ' Solicita ao usu�rio para digitar uma palavra
        Console.WriteLine("Digite uma palavra para calcular a pontua��o no Scrabble:")
        Dim input As String = Console.ReadLine()

        ' Calcula a pontua��o usando a fun��o Score
        Dim score As Integer = ScrabbleScore.Score(input) ' Chamando corretamente a fun��o

        ' Exibe o resultado
        Console.WriteLine($"A pontua��o de '{input}' no Scrabble �: {score}")

        ' Aguarda o usu�rio pressionar uma tecla para sair
        Console.ReadKey()
    End Sub
End Module