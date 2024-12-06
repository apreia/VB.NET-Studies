Imports System

Module Program
    Sub Main()
        ' Solicita ao usuário para digitar um número
        Console.Write("Digite um número (1 a 3999): ")
        Dim input As String = Console.ReadLine()

        ' Converte a entrada para inteiro e chama o método ToRoman
        Dim value As Integer
        If Integer.TryParse(input, value) AndAlso value >= 1 AndAlso value <= 3999 Then
            Dim roman As String = value.ToRoman()
            Console.WriteLine($"O número romano correspondente é: {roman}")
        Else
            Console.WriteLine("Número inválido. Por favor, insira um número entre 1 e 3999.")
        End If

        ' Espera o usuário pressionar uma tecla antes de sair
        Console.ReadLine()
    End Sub
End Module