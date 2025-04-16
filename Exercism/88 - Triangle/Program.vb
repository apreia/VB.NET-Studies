Imports System

Module Program
    Sub Main()
        ' Testando os tipos de triângulos

        ' Triângulo equilátero
        Console.WriteLine(Triangle.IsEquilateral(5, 5, 5)) ' Deve retornar True
        Console.WriteLine(Triangle.IsEquilateral(5, 5, 4)) ' Deve retornar False

        ' Triângulo isósceles
        Console.WriteLine(Triangle.IsIsosceles(5, 5, 3)) ' Deve retornar True
        Console.WriteLine(Triangle.IsIsosceles(5, 3, 4)) ' Deve retornar False

        ' Triângulo escaleno
        Console.WriteLine(Triangle.IsScalene(3, 4, 5)) ' Deve retornar True
        Console.WriteLine(Triangle.IsScalene(5, 5, 5)) ' Deve retornar False
    End Sub
End Module
