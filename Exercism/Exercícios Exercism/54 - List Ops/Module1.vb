Public Module ListOps
    Public Function Length(Of T)(ByVal items As List(Of T)) As Integer
        Return items.Count
    End Function

    Public Function Reverse(Of T)(ByVal items As List(Of T)) As List(Of T)
        Dim reversed As New List(Of T)(items)
        reversed.Reverse()
        Return reversed
    End Function

    Public Function Map(Of TIn, TOut)(ByVal items As List(Of TIn), ByVal mapFunction As Func(Of TIn, TOut)) As List(Of TOut)
        Dim result As New List(Of TOut)(items.Count)
        For Each item In items
            result.Add(mapFunction(item))
        Next
        Return result
    End Function

    Public Function Filter(Of T)(ByVal items As List(Of T), ByVal predicate As Func(Of T, Boolean)) As List(Of T)
        Dim filtered As New List(Of T)
        For Each item In items
            If predicate(item) Then
                filtered.Add(item)
            End If
        Next
        Return filtered
    End Function

    Public Function Foldl(Of TIn, TOut)(ByVal items As List(Of TIn), ByVal start As TOut, ByVal func As Func(Of TOut, TIn, TOut)) As TOut
        Dim accumulator As TOut = start
        For Each item In items
            accumulator = func(accumulator, item)
        Next
        Return accumulator
    End Function

    Public Function Foldr(Of TIn, TOut)(ByVal items As List(Of TIn), ByVal start As TOut, ByVal func As Func(Of TIn, TOut, TOut)) As TOut
        ' Usando iteração no lugar da recursão para evitar estouro de pilha
        Dim accumulator As TOut = start
        For i As Integer = items.Count - 1 To 0 Step -1
            accumulator = func(items(i), accumulator)
        Next
        Return accumulator
    End Function

    Public Function Concat(Of T)(ByVal lists As List(Of List(Of T))) As List(Of T)
        Dim result As New List(Of T)
        For Each sublist In lists
            result.AddRange(sublist)
        Next
        Return result
    End Function

    Public Function Append(Of T)(ByVal left As List(Of T), ByVal right As List(Of T)) As List(Of T)
        Dim result As New List(Of T)(left)
        result.AddRange(right)
        Return result
    End Function
End Module