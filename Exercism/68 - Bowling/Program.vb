Imports System

Module Program
    Sub Main()
        Dim game As New BowlingGame()

        ' Exemplo de uma sequência de rolagens
        game.Roll(10) ' Strike
        game.Roll(5)  ' Lançamento 1 do segundo quadro
        game.Roll(5)  ' Spare
        game.Roll(9)  ' Lançamento 1 do terceiro quadro
        game.Roll(0)  ' Lançamento 2 do terceiro quadro

        ' Exibe a pontuação total
        Console.WriteLine("Pontuação total: " & game.Score())
    End Sub
End Module