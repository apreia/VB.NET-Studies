Imports System

Public Module ResistorColor

    ' Função que retorna o código de cor (número) associado a uma cor.
    Public Function ColorCode(ByVal color As String) As Integer
        ' Definir o mapeamento das cores para números (agora em inglês).
        Dim colors As String() = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"}

        ' Procurar o índice da cor no array.
        Dim index As Integer = Array.IndexOf(colors, color.ToLower())

        ' Se a cor não for encontrada, lançar uma exceção.
        If index = -1 Then
            Throw New ArgumentException("Cor inválida.")
        End If

        ' Retornar o índice (número associado à cor).
        Return index
    End Function

    ' Função que retorna todas as cores codificadas (em inglês).
    Public Function Colors() As String()
        ' Retornar a lista completa de cores (em inglês, incluindo "grey" ao invés de "gray").
        Return New String() {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"}
    End Function
End Module