Public Module ReverseString
    Public Function Reverse(ByVal inputString As String) As String
        Return New String(inputString.Reverse().ToArray())
    End Function
End Module