Imports System

Module Program
    Sub Main()
        Dim validNumber As String = "4539 3195 0343 6467"
        Dim invalidNumber As String = "8273 1232 7352 0569"

        Console.WriteLine($"N�mero v�lido '{validNumber}': {Luhn.IsValid(validNumber)}") ' Deve retornar True
        Console.WriteLine($"N�mero inv�lido '{invalidNumber}': {Luhn.IsValid(invalidNumber)}") ' Deve retornar False
    End Sub
End Module