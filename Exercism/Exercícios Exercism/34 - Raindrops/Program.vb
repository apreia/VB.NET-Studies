Imports System

Module Program
    Sub Main()
        Console.WriteLine("Digite um n�mero:")
        Dim input As Integer
        If Integer.TryParse(Console.ReadLine(), input) Then
            Dim result As String = Raindrops.Convert(input)
            Console.WriteLine($"Resultado: {result}")
        Else
            Console.WriteLine("Entrada inv�lida. Por favor, insira um n�mero inteiro.")
        End If
    End Sub
End Module
