Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class TreeBuildingRecord
    Private Const RootRecordId As Integer = 0

    Public Property ParentId As Integer
    Public Property RecordId As Integer

    Public ReadOnly Property IsRoot As Boolean
        Get
            Return RecordId = RootRecordId
        End Get
    End Property
End Class

Public Class Tree
    Public Sub New(ByVal id As Integer)
        Me.Id = id
        Children = New List(Of Tree)()
    End Sub

    Public ReadOnly Property Id As Integer

    Public ReadOnly Property Children As List(Of Tree)

    Public ReadOnly Property IsLeaf As Boolean
        Get
            Return Children.Count = 0
        End Get
    End Property
End Class

Public Module TreeBuilder
    Private Const RootRecordId As Integer = 0

    ' Função para construir a árvore a partir dos registros
    Public Function BuildTree(ByVal records As IEnumerable(Of TreeBuildingRecord)) As Tree
        Dim orderedRecords = GetOrderedRecords(records)

        If orderedRecords.Count = 0 Then Throw New ArgumentException()

        Dim nodes = New Dictionary(Of Integer, Tree)()
        Dim previousRecordId = -1

        For Each record In orderedRecords
            ValidateRecord(record, previousRecordId)

            nodes(record.RecordId) = New Tree(record.RecordId)

            If Not record.IsRoot Then nodes(record.ParentId).Children.Add(nodes(record.RecordId))

            previousRecordId += 1
        Next

        Return nodes(RootRecordId)
    End Function

    ' Função para validar os registros durante a construção da árvore
    Private Sub ValidateRecord(ByVal record As TreeBuildingRecord, ByVal previousRecordId As Integer)
        If record.IsRoot AndAlso record.ParentId <> RootRecordId Then
            Throw New ArgumentException()
        ElseIf Not record.IsRoot AndAlso record.ParentId >= record.RecordId Then
            Throw New ArgumentException()
        ElseIf Not record.IsRoot AndAlso record.RecordId <> previousRecordId + 1 Then
            Throw New ArgumentException()
        End If
    End Sub

    ' Função para ordenar os registros pelo RecordId
    Private Function GetOrderedRecords(ByVal records As IEnumerable(Of TreeBuildingRecord)) As List(Of TreeBuildingRecord)
        Return records.OrderBy(Function(record) record.RecordId).ToList()
    End Function

    ' Função para imprimir a árvore no formato esperado
    Public Sub PrintTree(ByVal tree As Tree, ByVal indent As String)
        Console.WriteLine(indent & "ID: " & tree.Id)

        For Each child In tree.Children
            PrintTree(child, indent & "  |-- ")
        Next
    End Sub
End Module