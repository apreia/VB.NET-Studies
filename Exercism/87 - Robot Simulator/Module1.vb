Imports System

Public Enum DirectionType
    North
    East
    South
    West
End Enum

Public Class RobotSimulator
    ' Propriedades
    Private _direction As DirectionType
    Private _x As Integer
    Private _y As Integer

    ' Construtor
    Public Sub New(ByVal direction As DirectionType, ByVal x As Integer, ByVal y As Integer)
        _direction = direction
        _x = x
        _y = y
    End Sub

    ' Propriedade de direção
    Public ReadOnly Property Direction As DirectionType
        Get
            Return _direction
        End Get
    End Property

    ' Propriedade X
    Public ReadOnly Property X As Integer
        Get
            Return _x
        End Get
    End Property

    ' Propriedade Y
    Public ReadOnly Property Y As Integer
        Get
            Return _y
        End Get
    End Property

    ' Função para executar os movimentos
    Public Sub Move(ByVal instructions As String)
        ' Define as direções de movimento
        Dim directionOffsets As Dictionary(Of DirectionType, Tuple(Of Integer, Integer)) = New Dictionary(Of DirectionType, Tuple(Of Integer, Integer)) From {
            {DirectionType.North, New Tuple(Of Integer, Integer)(0, 1)},   ' Norte: Y aumenta
            {DirectionType.East, New Tuple(Of Integer, Integer)(1, 0)},    ' Leste: X aumenta
            {DirectionType.South, New Tuple(Of Integer, Integer)(0, -1)},  ' Sul: Y diminui
            {DirectionType.West, New Tuple(Of Integer, Integer)(-1, 0)}    ' Oeste: X diminui
        }

        ' Executa cada instrução
        For Each instruction In instructions
            Select Case instruction
                Case "R"
                    _direction = CType((CInt(_direction) + 1) Mod 4, DirectionType) ' Vira à direita (90 graus)
                Case "L"
                    _direction = CType((CInt(_direction) + 3) Mod 4, DirectionType) ' Vira à esquerda (90 graus)
                Case "A"
                    ' Avança na direção atual
                    _x += directionOffsets(_direction).Item1
                    _y += directionOffsets(_direction).Item2
            End Select
        Next
    End Sub
End Class