Imports System

Module Program
    Sub Main(args As String())
        Dim deque As New Deque(Of Integer)()

        ' Adiciona elementos ao final
        deque.Push(10)
        deque.Push(20)
        deque.Push(30)

        ' Remove do final
        Console.WriteLine(deque.Pop()) ' Sa�da: 30

        ' Adiciona elementos no in�cio
        deque.Unshift(5)
        deque.Unshift(0)

        ' Remove do in�cio
        Console.WriteLine(deque.Shift()) ' Sa�da: 0
        Console.WriteLine(deque.Shift()) ' Sa�da: 5

        ' Verifica o tamanho
        Console.WriteLine("Size: " & deque.Size()) ' Sa�da: 2

        ' Verifica se est� vazio
        Console.WriteLine("IsEmpty: " & deque.IsEmpty()) ' Sa�da: False
    End Sub
End Module