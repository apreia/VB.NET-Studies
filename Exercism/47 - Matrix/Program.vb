Imports System

Module Program
    Sub Main()
        ' Exemplo de entrada da matriz
        Dim entrada As String = "9 8 7" & vbLf &
                                "5 3 2" & vbLf &
                                "6 6 7"

        ' Cria��o da matriz
        Dim matriz As New Matrix(entrada)

        ' Exibi��o do n�mero de linhas e colunas
        Console.WriteLine($"N�mero de linhas: {matriz.Rows}")
        Console.WriteLine($"N�mero de colunas: {matriz.Cols}")

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