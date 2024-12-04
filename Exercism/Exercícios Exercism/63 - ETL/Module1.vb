Imports System
Imports System.Collections.Generic

Public Module Etl
    ' Método Transform converte o formato antigo para o formato novo.
    Public Function Transform(ByVal old As Dictionary(Of Integer, String())) As Dictionary(Of String, Integer)
        ' Dicionário para armazenar o novo formato de mapeamento.
        Dim newFormat As New Dictionary(Of String, Integer)

        ' Itera sobre cada entrada do dicionário antigo.
        For Each kvp In old
            Dim points = kvp.Key ' Obtém a pontuação (chave do dicionário).
            Dim letters = kvp.Value ' Obtém o array de letras associado a essa pontuação.

            ' Para cada letra no array, adiciona ao novo dicionário.
            For Each letter In letters
                newFormat(letter.ToLower()) = points ' Converte para minúsculas e atribui a pontuação.
            Next
        Next

        Return newFormat ' Retorna o dicionário transformado.
    End Function
End Module