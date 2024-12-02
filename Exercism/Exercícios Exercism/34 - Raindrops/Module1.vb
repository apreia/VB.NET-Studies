Imports System

Public Module Raindrops
    Public Function Convert(ByVal number As Integer) As String
        Dim result As String = ""

        If number Mod 3 = 0 Then
            result &= "Pling"
        End If

        If number Mod 5 = 0 Then
            result &= "Plang"
        End If

        If number Mod 7 = 0 Then
            result &= "Plong"
        End If

        If String.IsNullOrEmpty(result) Then
            result = number.ToString()
        End If

        Return result
    End Function
End Module