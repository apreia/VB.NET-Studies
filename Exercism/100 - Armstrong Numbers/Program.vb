Imports System

Module Program
    Sub Main()
        Dim numbers() As Integer = {9, 10, 153, 154, 9474, 9475}

        For Each num In numbers
            Dim result As Boolean = ArmstrongNumbers.IsArmstrongNumber(num)
            Console.WriteLine($"{num} é um número de Armstrong? {result}")
        Next
    End Sub
End Module