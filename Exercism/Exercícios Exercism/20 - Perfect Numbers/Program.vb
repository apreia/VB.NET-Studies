Imports System

Module Program
    Sub Main()
        Try
            Console.WriteLine(PerfectNumbers.Classify(6))  ' Output: Perfect
            Console.WriteLine(PerfectNumbers.Classify(28)) ' Output: Perfect
            Console.WriteLine(PerfectNumbers.Classify(-5)) ' Lança ArgumentOutOfRangeException
        Catch ex As ArgumentOutOfRangeException
            Console.WriteLine(ex.Message)  ' "O número deve ser um inteiro positivo maior que zero."
        End Try
    End Sub
End Module
