Imports System

Module Program
    Sub Main()
        Try
            Dim dnaSequence As String = "GCTA"
            Dim rnaSequence As String = RnaTranscription.ToRna(dnaSequence)

            Console.WriteLine($"DNA: {dnaSequence}")
            Console.WriteLine($"RNA: {rnaSequence}")
        Catch ex As Exception
            Console.WriteLine($"Erro: {ex.Message}")
        End Try
    End Sub
End Module