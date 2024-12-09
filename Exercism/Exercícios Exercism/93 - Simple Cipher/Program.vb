Imports System

Module Program
    Sub Main()
        ' Define o texto para criptografar
        Dim plaintext As String = "helloworld"

        ' Cria um cifrador com uma chave personalizada
        Dim customKey As String = "keycustom"
        Dim cipher As New SimpleCipher(customKey)

        Console.WriteLine($"Texto original: {plaintext}")
        Console.WriteLine($"Chave usada: {cipher.Key}")

        ' Codifica o texto
        Dim encodedText As String = cipher.Encode(plaintext)
        Console.WriteLine($"Texto codificado: {encodedText}")

        ' Decodifica o texto
        Dim decodedText As String = cipher.Decode(encodedText)
        Console.WriteLine($"Texto decodificado: {decodedText}")

        ' Verifica se o texto original e o decodificado s�o iguais
        If plaintext = decodedText Then
            Console.WriteLine("A codifica��o e decodifica��o foram bem-sucedidas!")
        Else
            Console.WriteLine("Houve um erro na codifica��o ou decodifica��o.")
        End If

        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module