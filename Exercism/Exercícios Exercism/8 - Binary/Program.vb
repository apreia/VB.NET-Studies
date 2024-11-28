Imports System

Module Program
    Sub Main()
        Try
            ' Exemplo com entrada v�lida
            Dim bin As New Binary("101010")
            Console.WriteLine(bin.ToDecimal()) ' Sa�da esperada: 42

            ' Exemplos com entradas inv�lidas
            Dim invalid1 As New Binary("carrot")
            Console.WriteLine(invalid1.ToDecimal()) ' Sa�da esperada: 0

            Dim invalid2 As New Binary("9")
            Console.WriteLine(invalid2.ToDecimal()) ' Sa�da esperada: 0

            Dim invalid3 As New Binary("2")
            Console.WriteLine(invalid3.ToDecimal()) ' Sa�da esperada: 0
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module