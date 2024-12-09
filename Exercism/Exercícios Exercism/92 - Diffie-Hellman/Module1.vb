Imports System
Imports System.Numerics

Public Module DiffieHellman
    ' Cria uma instância de gerador de números aleatórios
    Private ReadOnly Random As Random = New Random()

    ' Gera uma chave privada aleatória entre 1 e (primeP - 1)
    Public Function PrivateKey(ByVal primeP As BigInteger) As BigInteger
        ' CInt converte primeP para Integer, adequado para Random.Next.
        Return New BigInteger(Random.Next(1, CInt(primeP) - 1))
    End Function

    ' Calcula a chave pública usando a fórmula: gᵃ mod p
    Public Function PublicKey(ByVal primeP As BigInteger, ByVal primeG As BigInteger, ByVal privateKey As BigInteger) As BigInteger
        ' Usa BigInteger.ModPow para cálculo eficiente de potência modular
        Return BigInteger.ModPow(primeG, privateKey, primeP)
    End Function

    ' Calcula a chave secreta compartilhada usando a fórmula: Bᵃ mod p
    Public Function Secret(ByVal primeP As BigInteger, ByVal publicKey As BigInteger, ByVal privateKey As BigInteger) As BigInteger
        ' Usa BigInteger.ModPow para garantir precisão mesmo com números grandes
        Return BigInteger.ModPow(publicKey, privateKey, primeP)
    End Function
End Module