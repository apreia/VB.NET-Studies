Imports System
Imports System.Collections
Imports System.Collections.Generic

' Define uma lista encadeada genérica
Public Class SimpleLinkedList(Of T)
    Implements IEnumerable(Of T)

    ' Campo para armazenar o tamanho da lista
    Private _CountProp As Integer = 0

    ' Classe interna representando um nó na lista
    Private Class Node
        Public Property Value As T ' Valor armazenado no nó
        Public Property [Next] As Node ' Referência para o próximo nó
    End Class

    ' Cabeça da lista (primeiro nó)
    Private head As Node

    ' Construtor padrão
    Public Sub New()
    End Sub

    ' Construtor que permite inicializar a lista com valores
    Public Sub New(ParamArray values As T())
        For Each value In values
            Push(value) ' Adiciona cada valor à lista
        Next
    End Sub

    ' Propriedade somente leitura que retorna o número de elementos na lista
    Public Property Count As Integer
        Get
            Return _CountProp
        End Get
        Private Set(value As Integer)
            _CountProp = value
        End Set
    End Property

    ' Método para adicionar um elemento ao início da lista
    Public Sub Push(ByVal value As T)
        Dim node = New Node With {
            .Value = value,
            .[Next] = head
        }
        head = node ' Atualiza o nó da cabeça
        Count += 1 ' Incrementa o contador
    End Sub

    ' Método para remover e retornar o elemento no início da lista
    Public Function Pop() As T
        If head Is Nothing Then
            Throw New InvalidOperationException("List is empty!") ' Exceção se a lista estiver vazia
        End If
        Dim value = head.Value ' Armazena o valor do nó atual
        head = head.Next ' Move a cabeça para o próximo nó
        Count -= 1 ' Decrementa o contador
        Return value
    End Function

    ' Implementação do enumerador genérico para iterar pelos elementos da lista
    Public Iterator Function GetEnumerator() As IEnumerator(Of T) Implements IEnumerable(Of T).GetEnumerator
        Dim current = head
        While current IsNot Nothing
            Yield current.Value
            current = current.Next
        End While
    End Function

    ' Implementação do enumerador não genérico
    Private Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function
End Class