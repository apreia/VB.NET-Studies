Imports System

Module Program
    Sub Main(args As String())
        Dim arr As Integer() = {4, 8, 12, 16, 23, 28, 32}
        Dim valueToFind As Integer = 23
        Dim result As Integer = BinarySearch.Find(arr, valueToFind)

        If result <> -1 Then
            Console.WriteLine("Valor encontrado no �ndice: " & result)
        Else
            Console.WriteLine("Valor n�o encontrado")
        End If
    End Sub
End Module