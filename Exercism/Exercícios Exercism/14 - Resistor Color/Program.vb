Imports System

Module Program
    Sub Main()
        ' Testando as fun��es
        Try
            ' Obtendo o c�digo da cor "green"
            Console.WriteLine("C�digo da cor 'green': " & ResistorColor.ColorCode("green"))

            ' Listando todas as cores
            Console.WriteLine("Cores dispon�veis:")
            Dim allColors As String() = ResistorColor.Colors()
            For Each color In allColors
                Console.WriteLine(color)
            Next

        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try

        ' Espera uma tecla para encerrar o programa
        Console.ReadKey()
    End Sub
End Module