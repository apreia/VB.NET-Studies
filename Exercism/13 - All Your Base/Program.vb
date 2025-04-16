Imports System

Module Program
    Sub Main()
        ' Exemplo de convers�o de base
        Dim inputBase As Integer = 10
        Dim inputDigits As Integer() = {1, 5} ' 15 em base 10
        Dim outputBase As Integer = 2 ' Convers�o para bin�rio (base 2)

        ' Chamando a fun��o Rebase
        Dim result As Integer() = AllYourBase.Rebase(inputBase, inputDigits, outputBase)

        ' Exibindo o resultado
        Console.WriteLine("Resultado da convers�o:")
        Console.WriteLine(String.Join(", ", result)) ' Exibe a lista de n�meros no formato de sa�da

        ' Espera uma tecla para encerrar o programa
        Console.ReadKey()
    End Sub
End Module