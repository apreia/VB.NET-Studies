Imports System

Module Program
    Sub Main()
        ' Testando a fun��o IsLeapYear com diferentes anos
        Dim anos As Integer() = {1997, 1900, 2000, 2020, 2024, 2023}

        For Each ano As Integer In anos
            If Leap.IsLeapYear(ano) Then
                Console.WriteLine(ano & " � um ano bissexto.")
            Else
                Console.WriteLine(ano & " n�o � um ano bissexto.")
            End If
        Next

        ' Pausa para que o usu�rio possa ver os resultados
        Console.ReadLine()
    End Sub
End Module
