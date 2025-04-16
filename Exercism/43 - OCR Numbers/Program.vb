Imports System

Module Program
    Sub Main()
        ' Testando a função Convert
        Dim input As String = " _  _  _  _  _  _  _  _  _ " & vbLf &
                              "|_||_ |_  | _||_ |_  |_||_|" & vbLf &
                              "|_  _||_ |  ||_ | _|  | _|" & vbLf &
                              "                         "

        Dim result As String = OcrNumbers.Convert(input)
        Console.WriteLine(result) ' Esperado: 1234567890
    End Sub
End Module