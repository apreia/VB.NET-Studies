Imports System

Module Program
    Sub Main()
        Dim encoded As String = Atbash.Encode("The quick brown fox jumps over the lazy dog")
        Console.WriteLine($"Encoded: {encoded}") ' Sa�da esperada: gsvjf rxpyi ldmul cqfnk hlevi gsvoz abwlt

        Dim decoded As String = Atbash.Decode(encoded)
        Console.WriteLine($"Decoded: {decoded}") ' Sa�da esperada: thequickbrownfoxjumpsoverthelazydog
    End Sub
End Module
