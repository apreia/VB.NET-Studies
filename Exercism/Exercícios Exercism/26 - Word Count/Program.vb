Imports System

Module Program
    Sub Main()
        Dim phrase As String = "That's the password: 'PASSWORD 123'! cried the Special Agent. So I fled."
        Dim wordCounts As IDictionary(Of String, Integer) = WordCount.CountWords(phrase)

        ' Exibir as contagens de palavras
        For Each kvp As KeyValuePair(Of String, Integer) In wordCounts
            Console.WriteLine($"{kvp.Key}: {kvp.Value}")
        Next
    End Sub
End Module