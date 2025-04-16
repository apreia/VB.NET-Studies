Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Public Module WordCount
    Public Function CountWords(ByVal phrase As String) As IDictionary(Of String, Integer)
        ' Inicializa o dicionário para armazenar as contagens das palavras
        Dim wordCount As New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase)

        ' Usar regex para separar as palavras (mantendo contrações)
        Dim words As MatchCollection = Regex.Matches(phrase, "\b\w+'\w+|\w+\b")

        ' Iterar sobre as palavras encontradas e contar as ocorrências
        For Each wordMatch As Match In words
            Dim word As String = wordMatch.Value.ToLower()

            If wordCount.ContainsKey(word) Then
                wordCount(word) += 1
            Else
                wordCount.Add(word, 1)
            End If
        Next

        ' Retorna o dicionário com a contagem das palavras
        Return wordCount
    End Function
End Module