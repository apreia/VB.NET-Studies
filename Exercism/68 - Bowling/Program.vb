Imports System

Module Program
    Sub Main()
        Dim game As New BowlingGame()

        ' Exemplo de uma sequ�ncia de rolagens
        game.Roll(10) ' Strike
        game.Roll(5)  ' Lan�amento 1 do segundo quadro
        game.Roll(5)  ' Spare
        game.Roll(9)  ' Lan�amento 1 do terceiro quadro
        game.Roll(0)  ' Lan�amento 2 do terceiro quadro

        ' Exibe a pontua��o total
        Console.WriteLine("Pontua��o total: " & game.Score())
    End Sub
End Module