Imports System

Module Program
    Sub Main(args As String())
        ' Exibe o nome da nacionalidade que bebe água
        Console.WriteLine("Resident who drinks water: " & DrinksWater().ToString())

        ' Exibe o nome da nacionalidade que possui a zebra
        Console.WriteLine("Resident who owns zebra: " & OwnsZebra().ToString())

        ' Aguarda uma tecla para encerrar
        Console.ReadLine()
    End Sub
End Module