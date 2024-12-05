Public Class CircularBuffer(Of T)
    Private ReadOnly _capacity As Integer ' Capacidade máxima do buffer
    Private _size As Integer ' Número atual de elementos no buffer
    Private _start As Node ' Nó inicial (ponto de referência circular)

    ' Inicializa o buffer com a capacidade especificada
    Public Sub New(ByVal capacity As Integer)
        _capacity = capacity
    End Sub

    ' Escreve um novo valor no buffer
    Public Sub Write(ByVal value As T)
        ' Verifica se o buffer já está cheio
        If _size = _capacity Then
            Throw New InvalidOperationException("Capacity exceeded")
        End If

        ' Se o buffer estiver vazio, cria o primeiro nó
        If _start Is Nothing Then
            _start = New Node(value)
        Else
            ' Insere um novo nó circularmente à direita do início
            Dim inserted = New Node(value) With {.Left = _start, .Right = _start.Right}
            _start.Right.Left = inserted ' Ajusta o nó à direita
            _start.Right = inserted ' Atualiza a referência do nó inicial
        End If

        _size += 1 ' Incrementa o tamanho do buffer
    End Sub

    ' Lê e remove o elemento mais antigo do buffer
    Public Function Read() As T
        ' Verifica se o buffer está vazio
        If _size = 0 Then
            Throw New InvalidOperationException("Buffer is empty")
        End If

        Dim value = _start.Value ' Obtém o valor do nó atual

        ' Remove o nó atual
        If _start.Equals(_start.Left) Then
            _start = Nothing ' Se for o único nó, limpa o buffer
        Else
            _start.Right.Left = _start.Left ' Ajusta o nó à direita
            _start.Left.Right = _start.Right ' Ajusta o nó à esquerda
            _start = _start.Left ' Move o início para o próximo nó
        End If

        _size -= 1 ' Decrementa o tamanho do buffer
        Return value
    End Function

    ' Sobrescreve o valor mais antigo no buffer caso esteja cheio
    Public Sub Overwrite(ByVal value As T)
        If _size = _capacity Then
            Read() ' Remove o valor mais antigo
        End If
        Write(value) ' Escreve o novo valor
    End Sub

    ' Limpa o buffer completamente
    Public Sub Clear()
        _start = Nothing
        _size = 0
    End Sub

    ' Classe interna para representar os nós do buffer
    Private Class Node
        ReadOnly Property Value As T ' Valor armazenado no nó
        Property Left As Node = Me ' Nó à esquerda (circular)
        Property Right As Node = Me ' Nó à direita (circular)

        ' Construtor para inicializar o nó com um valor
        Public Sub New(value As T)
            Me.Value = value
        End Sub
    End Class
End Class