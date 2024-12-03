Imports System

Module Program
    Sub Main()
        ' Testando a função IsPangram
        Dim testPhrase As String = "The quick brown fox jumps over the lazy dog"

        If Pangram.IsPangram(testPhrase) Then
            Console.WriteLine("A frase é um pangrama!")
        Else
            Console.WriteLine("A frase não é um pangrama.")
        End If
    End Sub
End Module