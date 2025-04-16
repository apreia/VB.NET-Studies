Imports System

Module Program
    Sub Main()
        ' Testes de sequ�ncia de DNA
        Dim sequences As String() = {
            "GATTACA", ' Sequ�ncia v�lida
            "AAGGTTCC", ' Sequ�ncia v�lida
            "", ' Sequ�ncia vazia
            "INVALID" ' Sequ�ncia inv�lida
        }

        For Each sequence In sequences
            Console.WriteLine($"Analisando a sequ�ncia: {sequence}")
            Try
                Dim result = NucleotideCount.Count(sequence)
                For Each kvp In result
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}")
                Next
            Catch ex As ArgumentException
                Console.WriteLine("Erro: Sequ�ncia de DNA inv�lida.")
            End Try
            Console.WriteLine(New String("-"c, 30))
        Next
    End Sub
End Module