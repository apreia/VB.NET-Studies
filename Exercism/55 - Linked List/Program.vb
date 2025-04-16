Imports System

Module Program
    Sub Main(args As String())
        Dim deque As New Deque(Of Integer)()

        ' Adiciona elementos ao final
        deque.Push(10)
        deque.Push(20)
        deque.Push(30)

        ' Remove do final
        Console.WriteLine(deque.Pop()) ' Saída: 30

        ' Adiciona elementos no início
        deque.Unshift(5)
        deque.Unshift(0)

        ' Remove do início
        Console.WriteLine(deque.Shift()) ' Saída: 0
        Console.WriteLine(deque.Shift()) ' Saída: 5

        ' Verifica o tamanho
        Console.WriteLine("Size: " & deque.Size()) ' Saída: 2

        ' Verifica se está vazio
        Console.WriteLine("IsEmpty: " & deque.IsEmpty()) ' Saída: False
    End Sub
End Module