Imports System

Module Program
    Sub Main()
        ' Testando a função para um único verso
        Console.WriteLine(House.Recite(1))
        Console.WriteLine()

        ' Testando a função para um intervalo de versos
        Console.WriteLine(House.Recite(1, 3))
    End Sub
End Module