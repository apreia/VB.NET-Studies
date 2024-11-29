Imports System

Module Program
    Sub Main()
        ' Data de exemplo: 24 de janeiro de 2015, 22:00
        Dim initialDate As New Date(2015, 1, 24, 22, 0, 0)

        ' Calculando a data e hora de um gigasegundo após a data fornecida
        Dim gigasecondDate As Date = Gigasecond.Add(initialDate)

        ' Exibindo o resultado
        Console.WriteLine($"Data inicial: {initialDate}")
        Console.WriteLine($"Data após um gigasegundo: {gigasecondDate}")
    End Sub
End Module
