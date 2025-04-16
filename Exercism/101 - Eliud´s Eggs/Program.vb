Module Program
    Sub Main(args As String())
        ' Testes de exemplo
        Console.WriteLine("EggCount(0) = " & EliudsEggs.EggCount(0))          ' Esperado: 0
        Console.WriteLine("EggCount(1) = " & EliudsEggs.EggCount(1))          ' Esperado: 1
        Console.WriteLine("EggCount(8) = " & EliudsEggs.EggCount(8))          ' Esperado: 1
        Console.WriteLine("EggCount(89) = " & EliudsEggs.EggCount(89))        ' Esperado: 4
        Console.WriteLine("EggCount(2000000000) = " & EliudsEggs.EggCount(2000000000)) ' Esperado: 13
    End Sub
End Module