Imports System

Module Program
    Sub Main()
        ' Testando a função IsLeapYear com diferentes anos
        Dim anos As Integer() = {1997, 1900, 2000, 2020, 2024, 2023}

        For Each ano As Integer In anos
            If Leap.IsLeapYear(ano) Then
                Console.WriteLine(ano & " é um ano bissexto.")
            Else
                Console.WriteLine(ano & " não é um ano bissexto.")
            End If
        Next

        ' Pausa para que o usuário possa ver os resultados
        Console.ReadLine()
    End Sub
End Module
