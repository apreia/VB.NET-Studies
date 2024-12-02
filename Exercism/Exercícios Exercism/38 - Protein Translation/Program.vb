Imports System

Module Program
    Sub Main(args As String())
        Dim result As String() = ProteinTranslation.Proteins("AUGUUUUCUUAAAUG")
        Console.WriteLine(String.Join(", ", result))
    End Sub
End Module