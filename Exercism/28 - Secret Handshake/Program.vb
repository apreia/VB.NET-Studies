Imports System

Module Program
    Sub Main()
        ' Testando com o n�mero 9
        Dim result As String() = SecretHandshake.Commands(9)
        Console.WriteLine(String.Join(", ", result))  ' Sa�da: wink, jump

        ' Testando com o n�mero 26
        result = SecretHandshake.Commands(26)
        Console.WriteLine(String.Join(", ", result))  ' Sa�da: jump, double blink
    End Sub
End Module
