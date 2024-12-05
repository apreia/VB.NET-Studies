Imports System
Imports System.Collections.Generic

Public Enum SublistType
    Equal
    Unequal
    Superlist
    Sublist
End Enum

Public Module Sublist
    Public Function Classify(Of T As IComparable)(ByVal list1 As List(Of T), ByVal list2 As List(Of T)) As SublistType
        ' Caso as listas sejam iguais
        If list1.SequenceEqual(list2) Then
            Return SublistType.Equal
        End If

        ' Caso list1 seja uma superlista de list2
        If list1.Count > list2.Count AndAlso ContainsSublist(list1, list2) Then
            Return SublistType.Superlist
        End If

        ' Caso list2 seja uma sublista de list1
        If list2.Count > list1.Count AndAlso ContainsSublist(list2, list1) Then
            Return SublistType.Sublist
        End If

        ' Caso as listas sejam desiguais
        Return SublistType.Unequal
    End Function

    ' Função para verificar se uma lista contém uma subsequência
    Private Function ContainsSublist(Of T As IComparable)(ByVal largeList As List(Of T), ByVal subList As List(Of T)) As Boolean
        For i As Integer = 0 To largeList.Count - subList.Count
            Dim match As Boolean = True
            For j As Integer = 0 To subList.Count - 1
                If Not largeList(i + j).Equals(subList(j)) Then
                    match = False
                    Exit For
                End If
            Next
            If match Then Return True
        Next
        Return False
    End Function
End Module