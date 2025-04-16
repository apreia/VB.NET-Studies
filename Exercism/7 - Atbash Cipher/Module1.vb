Public Module Atbash
    Private Const Alphabet As String = "abcdefghijklmnopqrstuvwxyz"

    Public Function Encode(arg As String) As String
        Dim cleanedInput As String = New String(arg.ToLowerInvariant().Where(Function(c) Char.IsLetterOrDigit(c)).ToArray())
        Dim encoded As New Text.StringBuilder()

        For Each c As Char In cleanedInput
            If Char.IsLetter(c) Then
                Dim index As Integer = Alphabet.IndexOf(c)
                encoded.Append(Alphabet(Alphabet.Length - 1 - index))
            ElseIf Char.IsDigit(c) Then
                encoded.Append(c)
            End If
        Next

        ' Adicionar espaços a cada 5 caracteres
        Return String.Join(" ", SplitInChunks(encoded.ToString(), 5))
    End Function

    Public Function Decode(arg As String) As String
        Dim cleanedInput As String = arg.Replace(" ", "").ToLowerInvariant()
        Dim decoded As New Text.StringBuilder()

        For Each c As Char In cleanedInput
            If Char.IsLetter(c) Then
                Dim index As Integer = Alphabet.IndexOf(c)
                decoded.Append(Alphabet(Alphabet.Length - 1 - index))
            ElseIf Char.IsDigit(c) Then
                decoded.Append(c)
            End If
        Next

        Return decoded.ToString()
    End Function

    Private Function SplitInChunks(input As String, chunkSize As Integer) As IEnumerable(Of String)
        Return Enumerable.Range(0, Math.Ceiling(input.Length / chunkSize)).
                Select(Function(i) input.Substring(i * chunkSize, Math.Min(chunkSize, input.Length - i * chunkSize)))
    End Function
End Module