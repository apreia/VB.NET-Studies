Imports System

Public Class Queen
    Public Sub New(ByVal row As Integer, ByVal column As Integer)
        ' Verificação de linhas e colunas válidas no tabuleiro (0 a 7)
        If row < 0 OrElse row > 7 Then
            Throw New ArgumentOutOfRangeException(NameOf(row), "Row must be between 0 and 7.")
        End If
        If column < 0 OrElse column > 7 Then
            Throw New ArgumentOutOfRangeException(NameOf(column), "Column must be between 0 and 7.")
        End If

        Me.Row = row
        Me.Column = column
    End Sub

    Public ReadOnly Property Row As Integer
    Public ReadOnly Property Column As Integer
End Class

Public Module QueenAttack
    ' Função que verifica se as rainhas podem atacar uma à outra
    Public Function CanAttack(ByVal white As Queen, ByVal black As Queen) As Boolean
        ' Verifica se estão na mesma linha ou na mesma coluna
        If white.Row = black.Row OrElse white.Column = black.Column Then
            Return True
        End If

        ' Verifica se estão na mesma diagonal
        If Math.Abs(white.Row - black.Row) = Math.Abs(white.Column - black.Column) Then
            Return True
        End If

        ' Se não estiverem em nenhuma condição de ataque
        Return False
    End Function

    ' Função para criar uma rainha com a posição fornecida
    Public Function Create(ByVal row As Integer, ByVal column As Integer) As Queen
        ' Verificação de linhas e colunas válidas no tabuleiro (0 a 7)
        If row < 0 OrElse row > 7 Then
            Throw New ArgumentOutOfRangeException(NameOf(row), "Row must be between 0 and 7.")
        End If
        If column < 0 OrElse column > 7 Then
            Throw New ArgumentOutOfRangeException(NameOf(column), "Column must be between 0 and 7.")
        End If
        Return New Queen(row, column)
    End Function
End Module