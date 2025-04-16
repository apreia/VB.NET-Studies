Imports System

Public Module ScrabbleScore
    Public Function Score(ByVal input As String) As Integer
        ' Definindo os valores das letras no Scrabble
        Dim letterValues As New Dictionary(Of Char, Integer) From {
            {"A"c, 1}, {"E"c, 1}, {"I"c, 1}, {"O"c, 1}, {"U"c, 1}, {"L"c, 1}, {"N"c, 1}, {"R"c, 1}, {"S"c, 1}, {"T"c, 1},
            {"D"c, 2}, {"G"c, 2},
            {"B"c, 3}, {"C"c, 3}, {"M"c, 3}, {"P"c, 3},
            {"F"c, 4}, {"H"c, 4}, {"V"c, 4}, {"W"c, 4}, {"Y"c, 4},
            {"K"c, 5},
            {"J"c, 8}, {"X"c, 8},
            {"Q"c, 10}, {"Z"c, 10}
        }

        ' Inicializando a pontuação total
        Dim totalScore As Integer = 0

        ' Convertendo a palavra para maiúsculas para garantir a comparação correta
        input = input.ToUpper()

        ' Somando os valores das letras
        For Each letter As Char In input
            If letterValues.ContainsKey(letter) Then
                totalScore += letterValues(letter)
            End If
        Next

        ' Retornar o valor total
        Return totalScore
    End Function
End Module