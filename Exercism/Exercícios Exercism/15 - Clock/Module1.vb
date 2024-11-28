Imports System.ComponentModel.Design

Public Class Clock
    Public Property _Minutes As Integer

    Public Function ConvertHours(hours As Integer) As Integer
        Return hours * 60
    End Function

    Public Sub New(ByVal hours As Integer, ByVal minutes As Integer)
        _Minutes = ConvertHours(hours) + minutes
    End Sub

    Public Function Add(ByVal minutesToAdd As Integer) As Clock
        Throw New NotImplementedException("You need to implement this function")
    End Function

    Public Function Subtract(ByVal minutesToSubtract As Integer) As Clock
        Throw New NotImplementedException("You need to implement this function")
    End Function

    Public Overrides Function ToString() As String
        Dim hours As Integer = _Minutes \ 60
        Dim minutes As Integer = _Minutes Mod 60

        If hours = 24 AndAlso minutes = 0 Then
            Return "00:00"

        ElseIf hours = 24 Then
            Return String.Format("00:{0:D2}", minutes)

        Else
            Return String.Format("{0:D2}:{1:D2}", hours, minutes)
        End If
    End Function
End Class