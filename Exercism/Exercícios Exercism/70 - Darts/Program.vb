Imports System

Module Program
    Sub Main()
        ' Testando o método Score com diferentes coordenadas
        Console.WriteLine(Darts.Score(0, 0)) ' 10 pontos (círculo interno)
        Console.WriteLine(Darts.Score(3, 4)) ' 5 pontos (círculo central)
        Console.WriteLine(Darts.Score(6, 8)) ' 1 ponto (círculo externo)
        Console.WriteLine(Darts.Score(11, 11)) ' 0 pontos (fora do alvo)
    End Sub
End Module