Imports System

Module Program
    Sub Main()
        ' Solicita ao usu�rio o valor de N
        Console.WriteLine("Digite o valor de N:")
        Dim n As Integer = Integer.Parse(Console.ReadLine())

        ' Chama a fun��o para encontrar os tripletos
        Dim triplets = PythagoreanTriplet.TripletsWithSum(n)

        ' Exibe os tripletos encontrados
        If triplets.Any() Then
            Console.WriteLine($"Tripletos pitag�ricos com soma {n}:")
            For Each triplet In triplets
                Console.WriteLine($"({triplet.Item1}, {triplet.Item2}, {triplet.Item3})")
            Next
        Else
            Console.WriteLine("Nenhum tripletos pitag�ricos encontrado.")
        End If

        Console.ReadLine()
    End Sub
End Module