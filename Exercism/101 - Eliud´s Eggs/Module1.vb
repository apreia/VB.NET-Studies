Public Module EliudsEggs
    Public Function EggCount(ByVal number As Integer) As Integer
        If number = 1 Then
            Return 0
        End If

        Dim count As Integer = 0

        While number > 0
            If number Mod 2 = 1 Then
                count += 1
            End If
            number = number \ 2
        End While

        Return count
    End Function
End Module