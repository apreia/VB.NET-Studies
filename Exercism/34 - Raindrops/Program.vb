Imports System

Module Program
    Sub Main()
        Console.WriteLine("Digite um número:")
        Dim input As Integer
        If Integer.TryParse(Console.ReadLine(), input) Then
            Dim result As String = Raindrops.Convert(input)
            Console.WriteLine($"Resultado: {result}")
        Else
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.")
        End If
    End Sub
End Module
