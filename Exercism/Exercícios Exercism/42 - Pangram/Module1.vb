Imports System

Public Module Pangram
    Public Function IsPangram(ByVal input As String) As Boolean
        ' Converte a entrada para minúsculas para garantir que a comparação seja insensível a maiúsculas/minúsculas
        input = input.ToLower()

        ' Cria um conjunto de caracteres para armazenar as letras únicas encontradas na frase
        Dim letters As New HashSet(Of Char)()

        ' Itera por cada caractere na string
        For Each c As Char In input
            ' Verifica se o caractere é uma letra
            If Char.IsLetter(c) Then
                ' Adiciona a letra ao conjunto
                letters.Add(c)
            End If
        Next

        ' Verifica se o conjunto contém todas as 26 letras do alfabeto
        Return letters.Count = 26
    End Function
End Module