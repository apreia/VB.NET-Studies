Imports System

Module Program
    Sub Main()
        Dim dna1 As String = "GAGCCTACTAACGGGAT"
        Dim dna2 As String = "CATCGTAATGACGGCCT"

        Dim hammingDistance As Integer = Hamming.Distance(dna1, dna2)
        Console.WriteLine($"Distância de Hamming: {hammingDistance}")
    End Sub
End Module
