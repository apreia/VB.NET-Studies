Imports System

Module Program
    Sub Main(args As String())
        ' Cria��o de algumas entradas de Ledger
        Dim entries As LedgerEntry() = {
            Ledger.CreateEntry("12/25/2023", "Christmas Bonus", 5000),
            Ledger.CreateEntry("11/01/2023", "Salary", 30000),
            Ledger.CreateEntry("10/31/2023", "Halloween Party", -200),
            Ledger.CreateEntry("12/01/2023", "Office Supplies", -150)
        }

        ' Exemplo 1: Formata��o para os EUA (USD)
        Console.WriteLine("Formata��o - en-US (USD):")
        Dim formattedUS = Ledger.Format("USD", "en-US", entries)
        Console.WriteLine(formattedUS)

        ' Exemplo 2: Formata��o para a Holanda (EUR)
        Console.WriteLine(vbCrLf & "Formata��o - nl-NL (EUR):")
        Dim formattedNL = Ledger.Format("EUR", "nl-NL", entries)
        Console.WriteLine(formattedNL)
    End Sub
End Module