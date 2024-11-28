Public Module TwoFer
    ' O método Speak pode ser chamado com ou sem argumentos.
    Public Function Speak(Optional name As String = "you") As String
        Return $"One for {name}, one for me."
    End Function
End Module