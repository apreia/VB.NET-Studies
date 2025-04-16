Imports System

Module Program
    Sub Main(args As String())
        Dim result As Long() = PrimeFactors.Factors(60)
        Console.WriteLine(String.Join(", ", result))  ' Exibe: 2, 2, 3, 5
    End Sub
End Module