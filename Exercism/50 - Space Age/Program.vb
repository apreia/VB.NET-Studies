Imports System

Module Program
    Sub Main()
        Try
            Dim age As New SpaceAge(1000000000) ' 1 bilh�o de segundos

            Console.WriteLine("Idade em diferentes planetas:")
            Console.WriteLine($"Merc�rio: {age.OnMercury()} anos")
            Console.WriteLine($"V�nus: {age.OnVenus()} anos")
            Console.WriteLine($"Terra: {age.OnEarth()} anos")
            Console.WriteLine($"Marte: {age.OnMars()} anos")
            Console.WriteLine($"J�piter: {age.OnJupiter()} anos")
            Console.WriteLine($"Saturno: {age.OnSaturn()} anos")
            Console.WriteLine($"Urano: {age.OnUranus()} anos")
            Console.WriteLine($"Netuno: {age.OnNeptune()} anos")
        Catch ex As Exception
            Console.WriteLine($"Erro: {ex.Message}")
        End Try
    End Sub
End Module