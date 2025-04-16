Imports System
Imports System.Linq

Public Class HighScores
    Private ReadOnly _scores As List(Of Integer)

    ' Construtor para inicializar a lista de pontuações
    Public Sub New(ByVal scores As List(Of Integer))
        _scores = New List(Of Integer)(scores)
    End Sub

    ' Retorna todas as pontuações
    Public Function Scores() As List(Of Integer)
        Return New List(Of Integer)(_scores)
    End Function

    ' Retorna a última pontuação adicionada
    Public Function Latest() As Integer
        Return _scores.Last()
    End Function

    ' Retorna a maior pontuação
    Public Function PersonalBest() As Integer
        Return _scores.Max()
    End Function

    ' Retorna as três maiores pontuações em ordem decrescente
    Public Function PersonalTopThree() As List(Of Integer)
        Return _scores.OrderByDescending(Function(score) score).Take(3).ToList()
    End Function
End Class