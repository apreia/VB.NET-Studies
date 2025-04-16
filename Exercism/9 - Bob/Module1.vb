Public Class Bob
	Public Function Hey(youSay As String) As String
		Return thinkAnswer(youSay)
	End Function
	Private Function thinkAnswer(youSay As String) As String
		If isEmpty(youSay) Then Return "Fine. Be that way!"
		If isUpper(youSay) And isQuestion(youSay) Then Return "Calm down, I know what I'm doing!"
		If isUpper(youSay) Then Return "Whoa, chill out!"
		If isQuestion(youSay) Then Return "Sure."
		Return "Whatever."
	End Function
	Private Function isUpper(youSay As String) As Boolean
		Dim res As Boolean = True
		Dim hasLetter As Boolean
		For Each c In youSay.ToCharArray
			If Char.IsLetter(c) Then
				hasLetter = True
				res = Char.IsUpper(c) And res
			End If
		Next
		Return res And hasLetter
	End Function
	Private Function isQuestion(youSay As String) As Boolean
		Return youSay.EndsWith("?")
	End Function
	Private Function isEmpty(youSay As String) As Boolean
		Return youSay.Trim().Equals(String.Empty)
	End Function
End Class