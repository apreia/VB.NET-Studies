Imports System

Module Program
    Sub Main()
        ' Testando a fun��o IsPangram
        Dim testPhrase As String = "The quick brown fox jumps over the lazy dog"

        If Pangram.IsPangram(testPhrase) Then
            Console.WriteLine("A frase � um pangrama!")
        Else
            Console.WriteLine("A frase n�o � um pangrama.")
        End If
    End Sub
End Module