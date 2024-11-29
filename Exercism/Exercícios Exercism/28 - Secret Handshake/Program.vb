Imports System

Module Program
    Sub Main()
        ' Testando com o número 9
        Dim result As String() = SecretHandshake.Commands(9)
        Console.WriteLine(String.Join(", ", result))  ' Saída: wink, jump

        ' Testando com o número 26
        result = SecretHandshake.Commands(26)
        Console.WriteLine(String.Join(", ", result))  ' Saída: jump, double blink
    End Sub
End Module
