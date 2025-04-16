Imports System

Public Module Isogram
    Public Function IsIsogram(ByVal word As String) As Boolean
        ' Remover espaços e hifens
        word = word.Replace(" ", "").Replace("-", "")

        ' Converter para minúsculas para garantir que a comparação seja case-insensitive
        word = word.ToLower()

        ' Criar um conjunto para armazenar letras já encontradas
        Dim seenLetters As New HashSet(Of Char)()

        ' Iterar pelos caracteres da palavra
        For Each ch As Char In word
            ' Se a letra já foi encontrada, não é um isograma
            If seenLetters.Contains(ch) Then
                Return False
            End If
            ' Adicionar a letra ao conjunto
            seenLetters.Add(ch)
        Next

        ' Se não encontrou letras repetidas, é um isograma
        Return True
    End Function
End Module