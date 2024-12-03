Imports System

Module Program
    Sub Main()
        ' Lista de textos para contar a frequência das letras
        Dim texts As New List(Of String) From {
            "Hello World",
            "Parallel Computing",
            "VB.NET is awesome"
        }

        ' Chama o método para calcular a frequência
        Dim result As Dictionary(Of Char, Integer) = ParallelLetterFrequency.Calculate(texts)

        ' Exibe o resultado
        For Each kvp As KeyValuePair(Of Char, Integer) In result
            Console.WriteLine($"{kvp.Key}: {kvp.Value}")
        Next
    End Sub
End Module