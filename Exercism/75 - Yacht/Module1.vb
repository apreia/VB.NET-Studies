Imports System
Imports System.Linq

Public Enum YachtCategory
    Ones = 1
    Twos = 2
    Threes = 3
    Fours = 4
    Fives = 5
    Sixes = 6
    FullHouse = 7
    FourOfAKind = 8
    LittleStraight = 9
    BigStraight = 10
    Choice = 11
    Yacht = 12
End Enum

Public Module YachtGame
    Public Function Score(ByVal dice As Integer(), ByVal category As YachtCategory) As Integer
        Select Case category
            Case YachtCategory.Ones
                Return dice.Count(Function(d) d = 1)
            Case YachtCategory.Twos
                Return dice.Count(Function(d) d = 2) * 2
            Case YachtCategory.Threes
                Return dice.Count(Function(d) d = 3) * 3
            Case YachtCategory.Fours
                Return dice.Count(Function(d) d = 4) * 4
            Case YachtCategory.Fives
                Return dice.Count(Function(d) d = 5) * 5
            Case YachtCategory.Sixes
                Return dice.Count(Function(d) d = 6) * 6
            Case YachtCategory.FullHouse
                ' Verifica se há 3 de um número e 2 de outro
                Dim groups = dice.GroupBy(Function(d) d).ToList()
                If groups.Count = 2 AndAlso (groups(0).Count = 3 AndAlso groups(1).Count = 2 OrElse groups(0).Count = 2 AndAlso groups(1).Count = 3) Then
                    Return dice.Sum()
                End If
                Return 0
            Case YachtCategory.FourOfAKind
                ' Verifica se há 4 dados iguais
                Dim group = dice.GroupBy(Function(d) d).FirstOrDefault(Function(g) g.Count() >= 4)
                If group IsNot Nothing Then
                    Return group.Key * 4
                End If
                Return 0
            Case YachtCategory.LittleStraight
                ' Verifica se os dados formam a sequência 1-2-3-4-5
                If dice.OrderBy(Function(d) d).SequenceEqual({1, 2, 3, 4, 5}) Then
                    Return 30
                End If
                Return 0
            Case YachtCategory.BigStraight
                ' Verifica se os dados formam a sequência 2-3-4-5-6
                If dice.OrderBy(Function(d) d).SequenceEqual({2, 3, 4, 5, 6}) Then
                    Return 30
                End If
                Return 0
            Case YachtCategory.Choice
                ' Soma todos os dados
                Return dice.Sum()
            Case YachtCategory.Yacht
                ' Verifica se todos os dados são iguais
                If dice.Distinct().Count() = 1 Then
                    Return 50
                End If
                Return 0
            Case Else
                Return 0
        End Select
    End Function
End Module