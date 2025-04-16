Imports System

Public Module Proverb
    Public Function Recite(ByVal subjects As String()) As String()
        ' Verifica se a lista de entrada está vazia
        If subjects.Length = 0 Then
            Return New String() {} ' Retorna um array vazio
        End If

        ' Lista para armazenar as frases geradas
        Dim result As New List(Of String)()

        ' Cria as frases conforme a ordem da lista
        For i As Integer = 0 To subjects.Length - 2
            result.Add($"For want of a {subjects(i)} the {subjects(i + 1)} was lost.")
        Next

        ' Adiciona a última linha com o formato especial
        result.Add($"And all for the want of a {subjects(0)}.")

        ' Retorna o resultado como um array de strings
        Return result.ToArray()
    End Function
End Module