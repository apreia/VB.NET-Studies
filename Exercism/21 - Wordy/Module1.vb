Imports System
Imports System.Text.RegularExpressions

Public Module Wordy
    ' Regex adaptada para português
    Private ReadOnly EquationRegex As Regex = New Regex("^Quanto é (?<left>-?\d+)(?<operations> (?<operand>mais|menos|vezes|dividido por) (?<right>-?\d+))*\?$", RegexOptions.Compiled)

    Public Function Answer(ByVal question As String) As Integer
        Return Solve(Parse(question))
    End Function

    Private Function Parse(ByVal question As String) As Match
        Return EquationRegex.Match(question)
    End Function

    Private Function Solve(ByVal parsedQuestion As Match) As Integer
        Dim left As Integer = Nothing
        If Not Integer.TryParse(parsedQuestion.Groups("left").Value, left) Then Throw New ArgumentException()
        Dim right As Integer = Nothing

        ' Processa as operações conforme a quantidade de vezes que aparece a palavra 'operacao'
        For i = 0 To parsedQuestion.Groups("operations").Captures.Count - 1
            Dim operand = parsedQuestion.Groups("operand").Captures(i).Value
            If Not Integer.TryParse(parsedQuestion.Groups("right").Captures(i).Value, right) Then Throw New ArgumentException()

            left = ApplyOperand(left, operand, right)
        Next

        Return left
    End Function

    Private Function ApplyOperand(ByVal left As Integer, ByVal operand As String, ByVal right As Integer) As Integer
        ' Mapeando as operações para os seus equivalentes em português
        Select Case operand
            Case "mais"
                Return left + right
            Case "menos"
                Return left - right
            Case "vezes"
                Return left * right
            Case "dividido por"
                Return left / right
            Case Else
                Throw New ArgumentException()
        End Select
    End Function
End Module