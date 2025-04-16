Imports System

Module Program
    Sub Main()
        ' Testando os tipos de tri�ngulos

        ' Tri�ngulo equil�tero
        Console.WriteLine(Triangle.IsEquilateral(5, 5, 5)) ' Deve retornar True
        Console.WriteLine(Triangle.IsEquilateral(5, 5, 4)) ' Deve retornar False

        ' Tri�ngulo is�sceles
        Console.WriteLine(Triangle.IsIsosceles(5, 5, 3)) ' Deve retornar True
        Console.WriteLine(Triangle.IsIsosceles(5, 3, 4)) ' Deve retornar False

        ' Tri�ngulo escaleno
        Console.WriteLine(Triangle.IsScalene(3, 4, 5)) ' Deve retornar True
        Console.WriteLine(Triangle.IsScalene(5, 5, 5)) ' Deve retornar False
    End Sub
End Module
