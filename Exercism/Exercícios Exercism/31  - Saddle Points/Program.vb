Imports System

Module Program
    Sub Main(args As String())
        ' Exemplo de matriz
        Dim matrix As Integer(,) = {
            {9, 8, 7, 8},
            {5, 3, 2, 4},
            {6, 6, 7, 1}
        }

        ' Calcula os pontos de sela
        Dim result = SaddlePoints.Calculate(matrix)

        ' Exibe os resultados
        Console.WriteLine("Pontos de sela encontrados:")
        For Each point In result
            Console.WriteLine($"Linha {point.Item1}, Coluna {point.Item2}")
        Next

        ' Aguarda o usuário pressionar uma tecla para sair
        Console.ReadKey()
    End Sub
End Module