Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Module SumOfMultiples
    Public Function Sum(ByVal multiples As IEnumerable(Of Integer), ByVal max As Integer) As Integer
        ' Remover o múltiplo 0 da lista de múltiplos, se estiver presente
        multiples = multiples.Where(Function(m) m <> 0)

        ' Obter todos os múltiplos de cada valor base e combinar os resultados em uma lista única
        ' Remove as duplicatas e soma os valores restantes
        Return multiples _
            .SelectMany(Function(m) Enumerable.Range(1, (max - 1) \ m) _
                .Select(Function(n) n * m)) _
            .Distinct() _
            .Sum()
    End Function
End Module