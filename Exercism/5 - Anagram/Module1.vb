Public Class Anagram
    Private ReadOnly _baseWord As String

    Public Sub New(baseWord As String)
        ' Armazena a palavra base em minúsculas para comparação
        _baseWord = baseWord.ToLower()
    End Sub

    Public Function Match(potentialMatches As String()) As String()
        Dim sortedBaseWord As String = SortString(_baseWord)
        Dim anagrams As New List(Of String)

        For Each candidate As String In potentialMatches
            Dim lowerCandidate As String = candidate.ToLower()

            ' Verifica se o candidato não é idêntico à palavra base e se é um anagrama
            If lowerCandidate <> _baseWord AndAlso SortString(lowerCandidate) = sortedBaseWord Then
                anagrams.Add(candidate) ' Adiciona o candidato com a caixa de letras original
            End If
        Next

        ' Ordena a lista de anagramas para garantir a ordem consistente
        anagrams.Sort()

        Return anagrams.ToArray()
    End Function

    Private Function SortString(word As String) As String
        ' Ordena as letras da palavra
        Return New String(word.ToCharArray().OrderBy(Function(c) c).ToArray())
    End Function
End Class