Imports System

Module Program
    Sub Main()
        ' Testes de sequência de DNA
        Dim sequences As String() = {
            "GATTACA", ' Sequência válida
            "AAGGTTCC", ' Sequência válida
            "", ' Sequência vazia
            "INVALID" ' Sequência inválida
        }

        For Each sequence In sequences
            Console.WriteLine($"Analisando a sequência: {sequence}")
            Try
                Dim result = NucleotideCount.Count(sequence)
                For Each kvp In result
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}")
                Next
            Catch ex As ArgumentException
                Console.WriteLine("Erro: Sequência de DNA inválida.")
            End Try
            Console.WriteLine(New String("-"c, 30))
        Next
    End Sub
End Module