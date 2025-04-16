Imports System

Public Module PrimeFactors
    Public Function Factors(ByVal number As Long) As Long()
        Dim factorsList As New List(Of Long)()

        ' Começamos com o menor número primo, 2
        Dim divisor As Long = 2

        ' Enquanto o número for maior que 1
        While number > 1
            ' Enquanto o número for divisível pelo divisor atual
            While number Mod divisor = 0
                factorsList.Add(divisor)
                number \= divisor  ' Divide o número pelo divisor
            End While
            divisor += 1  ' Testa o próximo divisor
        End While

        ' Retorna os fatores primos encontrados como um array
        Return factorsList.ToArray()
    End Function
End Module