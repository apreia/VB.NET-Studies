Imports System.Collections.Generic
Imports System

Public Class BowlingGame
    ' Constantes para definir o número de quadros e a pontuação máxima por quadro.
    Private Const NumberOfFrames As Integer = 10
    Private Const MaximumFrameScore As Integer = 10

    ' Lista que armazena os pinos derrubados durante as jogadas.
    Private ReadOnly rolls As List(Of Integer) = New List(Of Integer)()

    ' Método que registra uma jogada, adicionando o número de pinos derrubados à lista de rolagens.
    Public Sub Roll(ByVal pins As Integer)
        ' Valida se a entrada (pinos) é válida.
        If Not ValidInput(pins) Then Throw New ArgumentException()

        rolls.Add(pins)
    End Sub

    ' Função que calcula e retorna a pontuação total do jogo.
    Public Function Score() As Integer?
        Dim lScore = 0 ' Variável para armazenar o total da pontuação.
        Dim frameIndex = 0 ' Índice do quadro atual.

        ' Verifica se o número de rolagens está entre 12 e 21 (o número esperado de rolagens no boliche).
        If rolls.Count < 12 OrElse rolls.Count > 21 Then Throw New ArgumentException()

        ' Loop para iterar sobre os quadros.
        For i = 1 To NumberOfFrames
            ' Verifica se o índice do quadro está dentro dos limites das rolagens.
            If rolls.Count <= frameIndex Then
                Throw New ArgumentException()
            End If

            ' Caso seja um strike (todos os pinos derrubados no primeiro lançamento).
            If IsStrike(frameIndex) Then
                ' Verifica se há rolagens suficientes para o bônus do strike.
                If rolls.Count <= frameIndex + 2 Then
                    Throw New ArgumentException()
                End If

                ' Calcula o bônus do strike e adiciona ao total.
                Dim strikeBonus = Me.StrikeBonus(frameIndex)
                If strikeBonus > MaximumFrameScore AndAlso Not IsStrike(frameIndex + 1) OrElse strikeBonus > 20 Then
                    Throw New ArgumentException()
                End If

                lScore += 10 + strikeBonus
                frameIndex += If(i = NumberOfFrames, 3, 1) ' Avança o índice conforme o tipo de jogada (strike ou normal).
                ' Caso seja um spare (todos os pinos derrubados no segundo lançamento do quadro).
            ElseIf IsSpare(frameIndex) Then
                ' Verifica se há rolagens suficientes para o bônus do spare.
                If rolls.Count <= frameIndex + 2 Then
                    Throw New ArgumentException()
                End If

                lScore += 10 + SpareBonus(frameIndex)
                frameIndex += If(i = NumberOfFrames, 3, 2) ' Avança o índice conforme o tipo de jogada (spare ou normal).
                ' Caso seja um quadro normal (não é strike nem spare).
            Else
                Dim frameScore = Me.FrameScore(frameIndex)
                ' Verifica se a pontuação do quadro é válida (não pode ser negativa ou maior que 10).
                If frameScore < 0 OrElse frameScore > 10 Then
                    Throw New ArgumentException()
                End If

                lScore += frameScore
                frameIndex += 2 ' Avança para o próximo quadro, que tem dois lançamentos.
            End If
        Next

        ' Verifica se o número de rolagens está correto e retorna a pontuação total ou Nothing.
        Return If(CorrectNumberOfRolls(frameIndex), lScore, CType(Nothing, Integer?))
    End Function

    ' Verifica se o número total de rolagens está correto.
    Private Function CorrectNumberOfRolls(ByVal frameIndex As Integer) As Boolean
        Return frameIndex = rolls.Count
    End Function

    ' Verifica se o quadro atual é um strike (todos os pinos derrubados no primeiro lançamento).
    Private Function IsStrike(ByVal frameIndex As Integer) As Boolean
        Return rolls(frameIndex) = MaximumFrameScore
    End Function

    ' Verifica se o quadro atual é um spare (todos os pinos derrubados no segundo lançamento do quadro).
    Private Function IsSpare(ByVal frameIndex As Integer) As Boolean
        Return rolls(frameIndex) + rolls(frameIndex + 1) = MaximumFrameScore
    End Function

    ' Calcula o bônus de um strike, que é a soma dos pinos derrubados nos dois próximos lançamentos.
    Private Function StrikeBonus(ByVal frameIndex As Integer) As Integer
        Return rolls(frameIndex + 1) + rolls(frameIndex + 2)
    End Function

    ' Calcula o bônus de um spare, que é o número de pinos derrubados no próximo lançamento.
    Private Function SpareBonus(ByVal frameIndex As Integer) As Integer
        Return rolls(frameIndex + 2)
    End Function

    ' Calcula a pontuação total de um quadro (primeiro e segundo lançamento).
    Private Function FrameScore(ByVal frameIndex As Integer) As Integer
        Return rolls(frameIndex) + rolls(frameIndex + 1)
    End Function

    ' Valida a entrada (número de pinos derrubados).
    Private Function ValidInput(ByVal pins As Integer) As Boolean
        ' Verifica condições como número de rolagens excessivo, pinos negativos ou maiores que 10, etc.
        If rolls.Count >= 21 OrElse pins < 0 OrElse pins > 10 OrElse rolls.Count + 1 Mod 2 = 0 AndAlso rolls(rolls.Count - 1) + pins > 10 Then
            Return False
        End If

        If (rolls.Count + 1) Mod 2 = 0 AndAlso rolls(rolls.Count - 1) <> 10 AndAlso rolls(rolls.Count - 1) + pins > 10 Then
            Return False
        End If

        ' Valida as condições específicas para o último quadro.
        If rolls.Count = 20 Then
            If rolls(18) <> 10 AndAlso rolls(18) + rolls(19) <> 10 Then Return False

            If pins = 10 AndAlso (rolls(18) <> 10 OrElse rolls(19) <> 10 OrElse rolls(19) + pins > 10 AndAlso rolls(19) + pins <> 20) AndAlso rolls(18) + rolls(19) <> 10 Then Return False

            If pins <> 10 AndAlso rolls(19) + pins > 10 AndAlso rolls(19) <> 10 Then Return False
        End If

        Return True
    End Function
End Class
