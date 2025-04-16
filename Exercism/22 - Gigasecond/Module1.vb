Imports System

Public Module Gigasecond
    ' Função que adiciona um gigasegundo (1.000.000.000 de segundos) a uma data fornecida
    Public Function Add(ByVal moment As Date) As Date
        ' Adiciona 1.000.000.000 de segundos à data fornecida
        Return moment.AddSeconds(1000000000)
    End Function
End Module