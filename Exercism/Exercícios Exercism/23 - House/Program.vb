Imports System

Module Program
    Sub Main()
        ' Testando a fun��o para um �nico verso
        Console.WriteLine(House.Recite(1))
        Console.WriteLine()

        ' Testando a fun��o para um intervalo de versos
        Console.WriteLine(House.Recite(1, 3))
    End Sub
End Module