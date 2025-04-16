Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Module AccumulateExtensions
    <Extension()>
    Public Function Accumulate(Of TInput, TOutput)(collection As IEnumerable(Of TInput), operation As Func(Of TInput, TOutput)) As IEnumerable(Of TOutput)
        Return AccumulateIterator(collection, operation)
    End Function

    Private Iterator Function AccumulateIterator(Of TInput, TOutput)(collection As IEnumerable(Of TInput), operation As Func(Of TInput, TOutput)) As IEnumerable(Of TOutput)
        For Each item In collection
            Yield operation(item) ' Avalia sob demanda
        Next
    End Function
End Module