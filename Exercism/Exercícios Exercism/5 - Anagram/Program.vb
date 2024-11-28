Imports System

Module Program
    Sub Main()
        Dim anagramFinder As New Anagram("stone")
        Dim candidates As String() = {"stone", "tones", "banana", "tons", "notes", "Seton"}
        Dim result As String() = anagramFinder.Match(candidates)

        ' Exibe os anagramas encontrados
        Console.WriteLine(String.Join(", ", result)) ' Saída esperada: tones, notes, Seton
    End Sub
End Module