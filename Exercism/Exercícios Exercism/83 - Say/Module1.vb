Imports System

Public Module Say
    Private ReadOnly ones As String() = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"}
    Private ReadOnly tens As String() = {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"}

    Private Function ConvertUnderHundred(ByVal number As Integer) As String
        If number < 20 Then
            Return ones(number)
        Else
            Dim tenPart As Integer = number \ 10
            Dim onePart As Integer = number Mod 10
            If onePart > 0 Then
                Return $"{tens(tenPart)}-{ones(onePart)}"
            Else
                Return tens(tenPart)
            End If
        End If
    End Function

    Private Function ConvertToEnglish(ByVal number As Long) As String
        If number = 0 Then Return "zero"

        Dim parts As New List(Of String)()
        Dim scales As String() = {"", "thousand", "million", "billion", "trillion"}

        Dim scaleIndex As Integer = 0

        While number > 0
            Dim block As Integer = CInt(number Mod 1000)
            If block > 0 Then
                Dim blockStr As String = If(block < 100, ConvertUnderHundred(block), $"{ones(block \ 100)} hundred {ConvertUnderHundred(block Mod 100)}").Trim()
                parts.Insert(0, $"{blockStr} {scales(scaleIndex)}".Trim())
            End If
            number \= 1000
            scaleIndex += 1
        End While

        Return String.Join(" ", parts).Trim()
    End Function

    Public Function InEnglish(ByVal number As Long) As String
        If number < 0 OrElse number > 999999999999 Then
            Throw New ArgumentOutOfRangeException("number", "Number must be between 0 and 999,999,999,999")
        End If
        Return ConvertToEnglish(number)
    End Function
End Module