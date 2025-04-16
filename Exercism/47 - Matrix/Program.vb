Imports System

Module Program
    Sub Main()
        ' Exemplo de entrada da matriz
        Dim entrada As String = "9 8 7" & vbLf &
                                "5 3 2" & vbLf &
                                "6 6 7"

        ' Criação da matriz
        Dim matriz As New Matrix(entrada)

        ' Exibição do número de linhas e colunas
        Console.WriteLine($"Número de linhas: {matriz.Rows}")
        Console.WriteLine($"Número de colunas: {matriz.Cols}")

        ' Testar as linhas
        For i As Integer = 1 To matriz.Rows
            Console.WriteLine($"Linha {i}: " & String.Join(", ", matriz.Row(i)))
        Next

        ' Testar as colunas
        For i As Integer = 1 To matriz.Cols
            Console.WriteLine($"Coluna {i}: " & String.Join(", ", matriz.Column(i)))
        Next
    End Sub
End Module