Imports System

Module Program
    Sub Main()
        ' Dicionário antigo no formato de um para muitos.
        Dim oldFormat As New Dictionary(Of Integer, String()) From {
            {1, {"A", "E", "I", "O", "U", "L", "N", "R", "S", "T"}},
            {2, {"D", "G"}},
            {3, {"B", "C", "M", "P"}},
            {4, {"F", "H", "V", "W", "Y"}},
            {5, {"K"}},
            {8, {"J", "X"}},
            {10, {"Q", "Z"}}
        }

        ' Chama o método Transform.
        Dim newFormat = Etl.Transform(oldFormat)

        ' Exibe o novo formato.
        Console.WriteLine("Novo formato:")
        For Each kvp In newFormat
            Console.WriteLine($"{kvp.Key}: {kvp.Value}")
        Next
    End Sub
End Module