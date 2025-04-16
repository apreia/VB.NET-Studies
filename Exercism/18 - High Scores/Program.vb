Imports System

Module Program
    Sub Main()
        Dim scores As New List(Of Integer)({40, 100, 70, 30, 80})
        Dim highScores As New HighScores(scores)

        Console.WriteLine("Scores: " & String.Join(", ", highScores.Scores()))
        Console.WriteLine("Latest: " & highScores.Latest())
        Console.WriteLine("Personal Best: " & highScores.PersonalBest())
        Console.WriteLine("Personal Top Three: " & String.Join(", ", highScores.PersonalTopThree()))
    End Sub
End Module
