Imports System

Module Program
    Sub Main()
        ' Texto de entrada
        Dim plaintext As String = "If man was meant to stay on the ground, god would have given us roots."

        ' Gera o texto cifrado
        Dim ciphertext As String = Crypto.Ciphertext(plaintext)

        ' Exibe a saída no console
        Console.WriteLine("Texto cifrado:")
        Console.WriteLine(ciphertext)
    End Sub
End Module