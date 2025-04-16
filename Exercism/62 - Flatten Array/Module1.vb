Imports System.Collections

Public Module FlattenArray
    ' Define uma função iteradora para achatar listas aninhadas
    Public Iterator Function Flatten(ByVal input As IEnumerable) As IEnumerable
        ' Itera sobre cada elemento no input
        For Each element In input
            ' Tenta converter o elemento atual para IEnumerable
            Dim enumerable = TryCast(element, IEnumerable)
            If enumerable IsNot Nothing Then
                ' Caso o elemento seja uma coleção (IEnumerable), chama a função Flatten recursivamente
                For Each flattenedElement In Flatten(enumerable)
                    ' Retorna cada elemento achado pela função recursiva
                    Yield flattenedElement
                Next
            ElseIf element IsNot Nothing Then
                ' Caso o elemento não seja nulo, retorna o próprio elemento
                Yield element
            End If
        Next
    End Function
End Module