Imports System

Module Program
    Sub Main()
        ' Exemplo de conversão de base
        Dim inputBase As Integer = 10
        Dim inputDigits As Integer() = {1, 5} ' 15 em base 10
        Dim outputBase As Integer = 2 ' Conversão para binário (base 2)

        ' Chamando a função Rebase
        Dim result As Integer() = AllYourBase.Rebase(inputBase, inputDigits, outputBase)

        ' Exibindo o resultado
        Console.WriteLine("Resultado da conversão:")
        Console.WriteLine(String.Join(", ", result)) ' Exibe a lista de números no formato de saída

        ' Espera uma tecla para encerrar o programa
        Console.ReadKey()
    End Sub
End Module