Imports System

Public Class Deque(Of T)
    ' Classe interna para representar um nó duplamente encadeado
    Private Class Node
        Public Value As T
        Public NextNode As Node
        Public PrevNode As Node

        Public Sub New(ByVal value As T)
            Me.Value = value
            Me.NextNode = Nothing
            Me.PrevNode = Nothing
        End Sub
    End Class

    ' Referências para o primeiro e o último nó
    Private head As Node
    Private tail As Node

    Public Sub New()
        head = Nothing
        tail = Nothing
    End Sub

    ' Adicionar um valor no final (Push)
    Public Sub Push(ByVal value As T)
        Dim newNode As New Node(value)

        ' Se a lista estiver vazia, o novo nó será o primeiro e o último
        If tail Is Nothing Then
            head = newNode
            tail = newNode
        Else
            ' Caso contrário, adiciona ao final
            tail.NextNode = newNode
            newNode.PrevNode = tail
            tail = newNode
        End If
    End Sub

    ' Remover e retornar o valor do final (Pop)
    Public Function Pop() As T
        If tail Is Nothing Then
            Throw New InvalidOperationException("Deque is empty.")
        End If

        Dim value As T = tail.Value
        If head Is tail Then
            ' Caso a lista tenha um único elemento
            head = Nothing
            tail = Nothing
        Else
            tail = tail.PrevNode
            tail.NextNode = Nothing
        End If

        Return value
    End Function

    ' Adicionar um valor no início (Unshift)
    Public Sub Unshift(ByVal value As T)
        Dim newNode As New Node(value)

        ' Se a lista estiver vazia, o novo nó será o primeiro e o último
        If head Is Nothing Then
            head = newNode
            tail = newNode
        Else
            ' Caso contrário, adiciona ao início
            newNode.NextNode = head
            head.PrevNode = newNode
            head = newNode
        End If
    End Sub

    ' Remover e retornar o valor do início (Shift)
    Public Function Shift() As T
        If head Is Nothing Then
            Throw New InvalidOperationException("Deque is empty.")
        End If

        Dim value As T = head.Value
        If head Is tail Then
            ' Caso a lista tenha um único elemento
            head = Nothing
            tail = Nothing
        Else
            head = head.NextNode
            head.PrevNode = Nothing
        End If

        Return value
    End Function

    ' Método para verificar se a lista está vazia
    Public Function IsEmpty() As Boolean
        Return head Is Nothing
    End Function

    ' Método para obter o tamanho da lista
    Public Function Size() As Integer
        Dim current As Node = head
        Dim count As Integer = 0

        While current IsNot Nothing
            count += 1
            current = current.NextNode
        End While

        Return count
    End Function
End Class