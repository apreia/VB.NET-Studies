Imports System

Module Program
    Sub Main()
        ' Recitar um �nico verso
        Console.WriteLine(TwelveDays.Recite(1))
        Console.WriteLine()

        ' Recitar do primeiro ao terceiro verso
        Console.WriteLine(TwelveDays.Recite(1, 3))
        Console.WriteLine()

        ' Recitar a m�sica completa
        Console.WriteLine(TwelveDays.Recite(1, 12))
    End Sub
End Module