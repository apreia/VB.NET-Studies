Imports System

Public Module RotationalCipher
    Public Function Rotate(ByVal text As String, ByVal shiftKey As Integer) As String
        ' Normaliza o deslocamento para o intervalo 0-25
        shiftKey = shiftKey Mod 26

        ' Garante que a entrada seja válida
        If String.IsNullOrEmpty(text) Then
            Return text
        End If

        ' Aplica a cifra de César a cada caractere
        Return New String(text.[Select](Function(c) ShiftChar(c, shiftKey)).ToArray())
    End Function

    Private Function ShiftChar(ByVal c As Char, ByVal shiftKey As Integer) As Char
        If Char.IsLetter(c) Then
            ' Define o início do alfabeto (a/A)
            Dim offset As Integer = If(Char.IsUpper(c), Asc("A"c), Asc("a"c))
            ' Calcula a nova posição da letra
            Return Chr(((Asc(c) - offset + shiftKey) Mod 26) + offset)
        End If
        ' Retorna o caractere original para caracteres não alfabéticos
        Return c
    End Function
End Module