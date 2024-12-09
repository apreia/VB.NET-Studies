Imports System
Imports System.Numerics

Module Program
    Sub Main()
        ' Exemplo de números primos p e g
        Dim primeP As BigInteger = 23 ' Primo grande
        Dim primeG As BigInteger = 5  ' Base geradora

        Console.WriteLine($"Número primo P: {primeP}")
        Console.WriteLine($"Base geradora G: {primeG}")

        ' Alice escolhe uma chave privada
        Dim alicePrivateKey = DiffieHellman.PrivateKey(primeP)
        Dim alicePublicKey = DiffieHellman.PublicKey(primeP, primeG, alicePrivateKey)

        Console.WriteLine($"Chave privada de Alice: {alicePrivateKey}")
        Console.WriteLine($"Chave pública de Alice: {alicePublicKey}")

        ' Bob escolhe uma chave privada
        Dim bobPrivateKey = DiffieHellman.PrivateKey(primeP)
        Dim bobPublicKey = DiffieHellman.PublicKey(primeP, primeG, bobPrivateKey)

        Console.WriteLine($"Chave privada de Bob: {bobPrivateKey}")
        Console.WriteLine($"Chave pública de Bob: {bobPublicKey}")

        ' Alice calcula a chave secreta compartilhada
        Dim aliceSecret = DiffieHellman.Secret(primeP, bobPublicKey, alicePrivateKey)
        ' Bob calcula a chave secreta compartilhada
        Dim bobSecret = DiffieHellman.Secret(primeP, alicePublicKey, bobPrivateKey)

        ' Exibindo os segredos compartilhados
        Console.WriteLine($"Segredo compartilhado de Alice: {aliceSecret}")
        Console.WriteLine($"Segredo compartilhado de Bob: {bobSecret}")

        ' Verificação
        If aliceSecret = bobSecret Then
            Console.WriteLine("A troca de chaves foi bem-sucedida!")
        Else
            Console.WriteLine("Algo deu errado na troca de chaves.")
        End If

        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module