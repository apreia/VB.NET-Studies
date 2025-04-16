Imports System
Imports System.Linq

Public Class DndCharacter
    ' Usamos uma instância única de Random para gerar números aleatórios
    Private Shared ReadOnly Random As Random = New Random()

    ' Construtor para criar um personagem com todas as suas habilidades
    Public Sub New(ByVal strength As Integer, ByVal dexterity As Integer, ByVal constitution As Integer, ByVal intelligence As Integer, ByVal wisdom As Integer, ByVal charisma As Integer)
        ' Inicializa as propriedades com os valores passados no construtor
        Me.Strength = strength
        Me.Dexterity = dexterity
        Me.Constitution = constitution
        Me.Intelligence = intelligence
        Me.Wisdom = wisdom
        Me.Charisma = charisma
        ' Calcula e define os pontos de vida baseados na constituição
        Hitpoints = 10 + Modifier(constitution)
    End Sub

    ' Propriedades de leitura das habilidades (só leitura, não podem ser alteradas diretamente)
    Public ReadOnly Property Strength As Integer
    Public ReadOnly Property Dexterity As Integer
    Public ReadOnly Property Constitution As Integer
    Public ReadOnly Property Intelligence As Integer
    Public ReadOnly Property Wisdom As Integer
    Public ReadOnly Property Charisma As Integer
    Public ReadOnly Property Hitpoints As Integer

    ' Função para calcular o modificador de habilidade baseado na pontuação
    ' O modificador é (score - 10) / 2
    Public Shared Function Modifier(ByVal score As Integer) As Integer
        Return Math.Floor((score - 10) / 2.0)
    End Function

    ' Função para gerar uma habilidade aleatória, que é a soma dos 3 maiores valores de 4 dados lançados
    Public Shared Function Ability() As Integer
        ' Rola 4 dados e retorna a soma dos 3 maiores
        Return Enumerable.Take(Of Integer)(Enumerable.OrderByDescending(Of Integer, Global.System.Int32)(Enumerable.Select(Of Integer, Global.System.Int32)(Enumerable.Range(CInt(0), CInt(4)), CType(Function(__) CInt(RollDie()), Func(Of Integer, Integer))), CType(Function(score) CInt(score), Func(Of Integer, Integer))), CInt(3)).Sum()
    End Function

    ' Função privada para simular o lançamento de um dado de 6 lados
    Private Shared Function RollDie() As Integer
        Return Random.Next(1, 7)
    End Function

    ' Função para gerar um novo personagem com todas as habilidades aleatórias
    Public Shared Function Generate() As DndCharacter
        ' Gera um personagem com habilidades aleatórias
        Return New DndCharacter(Ability(), Ability(), Ability(), Ability(), Ability(), Ability())
    End Function
End Class