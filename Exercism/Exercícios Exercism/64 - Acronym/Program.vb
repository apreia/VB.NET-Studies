Imports System

Module Program
    Sub Main()
        Dim phrases As String() = {
            "The_Rise_Of_New_Technology",
            "Howard's_Country",
            "Portable Network Graphics",
            "Thank God It's Friday!"
        }

        Console.WriteLine("Siglas:")
        For Each phrase In phrases
            Console.WriteLine($"{phrase} -> {Acronym.Abbreviate(phrase)}")
        Next
    End Sub
End Module