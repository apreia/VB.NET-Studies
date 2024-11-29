Imports System

Module Program
    Sub Main()
        Try
            Dim phone1 As String = "+1 (613)-995-0253"
            Dim phone2 As String = "1 613 995 0253"
            Dim phone3 As String = "613.995.0253"

            Console.WriteLine(PhoneNumber.Clean(phone1)) ' Saída: 6139950253
            Console.WriteLine(PhoneNumber.Clean(phone2)) ' Saída: 6139950253
            Console.WriteLine(PhoneNumber.Clean(phone3)) ' Saída: 6139950253
        Catch ex As Exception
            Console.WriteLine($"Erro: {ex.Message}")
        End Try
    End Sub
End Module