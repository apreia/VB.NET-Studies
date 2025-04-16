Imports System
Imports System.Text.RegularExpressions

Public Module Acronym
    ' Método Abbreviate converte uma frase em sua sigla.
    Public Function Abbreviate(ByVal phrase As String) As String
        ' Remove apostrófos antes de processar a frase
        Dim sanitizedPhrase As String = Regex.Replace(phrase, "'", "")

        ' Substitui hifens e underscores por espaços para tratá-los como separadores de palavras.
        sanitizedPhrase = Regex.Replace(sanitizedPhrase, "[-_]", " ")

        ' Usa uma expressão regular para encontrar as primeiras letras de cada palavra.
        Dim matches = Regex.Matches(sanitizedPhrase, "\b\w")

        ' Concatena as letras encontradas e converte para maiúsculas.
        Dim acronym As String = String.Concat(matches).ToUpper()

        Return acronym
    End Function
End Module