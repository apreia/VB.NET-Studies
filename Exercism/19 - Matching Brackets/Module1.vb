Imports System.Collections.Generic

Public Module MatchingBrackets
    Public Function IsPaired(ByVal input As String) As Boolean
        Dim stack As New Stack(Of Char)
        Dim pairs As New Dictionary(Of Char, Char) From {
            {")"c, "("c},
            {"]"c, "["c},
            {"}"c, "{"c}
        }

        For Each ch As Char In input
            If pairs.Values.Contains(ch) Then
                ' Se for um caractere de abertura, empilha
                stack.Push(ch)
            ElseIf pairs.Keys.Contains(ch) Then
                ' Se for um caractere de fechamento
                If stack.Count = 0 OrElse stack.Pop() <> pairs(ch) Then
                    Return False ' Não balanceado
                End If
            End If
        Next

        ' Se o stack estiver vazio, está balanceado
        Return stack.Count = 0
    End Function
End Module