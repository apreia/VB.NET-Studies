Imports System

Module Program
    Sub Main()
        ' Testando o m�todo Score com diferentes coordenadas
        Console.WriteLine(Darts.Score(0, 0)) ' 10 pontos (c�rculo interno)
        Console.WriteLine(Darts.Score(3, 4)) ' 5 pontos (c�rculo central)
        Console.WriteLine(Darts.Score(6, 8)) ' 1 ponto (c�rculo externo)
        Console.WriteLine(Darts.Score(11, 11)) ' 0 pontos (fora do alvo)
    End Sub
End Module