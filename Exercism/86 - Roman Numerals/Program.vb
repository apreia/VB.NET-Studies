Imports System

Module Program
    Sub Main()
        ' Solicita ao usu�rio para digitar um n�mero
        Console.Write("Digite um n�mero (1 a 3999): ")
        Dim input As String = Console.ReadLine()

        ' Converte a entrada para inteiro e chama o m�todo ToRoman
        Dim value As Integer
        If Integer.TryParse(input, value) AndAlso value >= 1 AndAlso value <= 3999 Then
            Dim roman As String = value.ToRoman()
            Console.WriteLine($"O n�mero romano correspondente �: {roman}")
        Else
            Console.WriteLine("N�mero inv�lido. Por favor, insira um n�mero entre 1 e 3999.")
        End If

        ' Espera o usu�rio pressionar uma tecla antes de sair
        Console.ReadLine()
    End Sub
End Module