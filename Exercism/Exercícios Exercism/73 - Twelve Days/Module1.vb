Imports System
Imports System.Text

Public Module TwelveDays
    Private ReadOnly Days As String() = {
        "first", "second", "third", "fourth", "fifth", "sixth",
        "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth"
    }

    Private ReadOnly Gifts As String() = {
        "a Partridge in a Pear Tree",
        "two Turtle Doves",
        "three French Hens",
        "four Calling Birds",
        "five Gold Rings",
        "six Geese-a-Laying",
        "seven Swans-a-Swimming",
        "eight Maids-a-Milking",
        "nine Ladies Dancing",
        "ten Lords-a-Leaping",
        "eleven Pipers Piping",
        "twelve Drummers Drumming"
    }

    Public Function Recite(ByVal verseNumber As Integer) As String
        Return BuildVerse(verseNumber)
    End Function

    Public Function Recite(ByVal startVerse As Integer, ByVal endVerse As Integer) As String
        Dim verses As New StringBuilder()
        For i As Integer = startVerse To endVerse
            verses.Append(BuildVerse(i))
            If i < endVerse Then
                verses.AppendLine() ' Adiciona uma nova linha apenas entre os versos
            End If
        Next
        Return verses.ToString()
    End Function

    Private Function BuildVerse(ByVal verseNumber As Integer) As String
        Dim verse As New StringBuilder($"On the {Days(verseNumber - 1)} day of Christmas my true love gave to me: ")
        For i As Integer = verseNumber - 1 To 0 Step -1
            If i = 0 AndAlso verseNumber > 1 Then
                verse.Append("and ")
            End If
            verse.Append(Gifts(i))
            If i > 0 Then
                verse.Append(", ")
            Else
                verse.Append(".")
            End If
        Next
        Return verse.ToString()
    End Function
End Module