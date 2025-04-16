Imports System

Module Program
    Sub Main()
        ' Teste de ISBNs válidos
        Console.WriteLine(IsbnVerifier.IsValid("3-598-21508-8")) ' True
        Console.WriteLine(IsbnVerifier.IsValid("3-598-21507-X")) ' True

        ' Teste de ISBNs inválidos
        Console.WriteLine(IsbnVerifier.IsValid("3-598-21508-9")) ' False
        Console.WriteLine(IsbnVerifier.IsValid("359821507X")) ' True
        Console.WriteLine(IsbnVerifier.IsValid("3-598-2K507-X")) ' False
        Console.WriteLine(IsbnVerifier.IsValid("123456789")) ' False
    End Sub
End Module