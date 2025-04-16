Imports System

Module Program
    Sub Main(args As String())
        ' Solicita ao usuário o texto a ser cifrado
        Console.WriteLine("Digite o texto para aplicar a cifra rotacional:")
        Dim text As String = Console.ReadLine()

        ' Solicita o valor da chave
        Console.WriteLine("Digite o valor da chave (deslocamento):")
        Dim shiftKey As Integer
        If Not Integer.TryParse(Console.ReadLine(), shiftKey) Then
            Console.WriteLine("Chave inválida. Encerrando o programa.")
            Return
        End If

        ' Aplica a cifra de César
        Dim encryptedText As String = RotationalCipher.Rotate(text, shiftKey)
        Console.WriteLine($"Texto cifrado: {encryptedText}")

        ' Aguarda o usuário pressionar uma tecla para sair
        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module