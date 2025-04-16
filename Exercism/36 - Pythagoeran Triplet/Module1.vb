Imports System
Imports System.Collections.Generic

Public Module PythagoreanTriplet
    ' Função para encontrar tripletos pitagóricos cuja soma é igual a 'sum'
    Public Function TripletsWithSum(ByVal sum As Integer) As IEnumerable(Of (Integer, Integer, Integer))
        ' Lista para armazenar os tripletos encontrados
        Dim triplets As New List(Of (Integer, Integer, Integer))()

        ' Laços para iterar sobre os possíveis valores de a, b e c
        For a As Integer = 1 To sum \ 3
            For b As Integer = a + 1 To sum \ 2
                Dim c As Integer = sum - a - b ' Calcula c a partir da soma
                If a * a + b * b = c * c Then ' Verifica se a² + b² = c²
                    triplets.Add((a, b, c)) ' Adiciona o triplete à lista
                End If
            Next
        Next

        ' Retorna a lista de tripletos encontrados
        Return triplets
    End Function
End Module