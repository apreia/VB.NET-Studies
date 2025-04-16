Imports System

Module Program
    Sub Main()
        Dim allergies As New Allergies(34)

        ' Verifica alergias individuais
        Console.WriteLine(allergies.AllergicTo("peanuts"))  ' True
        Console.WriteLine(allergies.AllergicTo("chocolate")) ' True
        Console.WriteLine(allergies.AllergicTo("cats")) ' False

        ' Lista todas as alergias
        Dim allergyList = allergies.List()
        Console.WriteLine(String.Join(", ", allergyList)) ' peanuts, chocolate
    End Sub
End Module

