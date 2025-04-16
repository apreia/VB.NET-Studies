Imports System

Module Program
    Sub Main()
        ' Cria uma lista encadeada com valores iniciais
        Dim list As New SimpleLinkedList(Of Integer)(10, 20, 30)

        ' Exibe os elementos na lista
        Console.WriteLine("Elementos iniciais na lista:")
        For Each value In list
            Console.WriteLine(value)
        Next

        ' Adiciona novos elementos
        list.Push(40)
        list.Push(50)
        Console.WriteLine(vbCrLf & "Ap�s adicionar 40 e 50:")
        For Each value In list
            Console.WriteLine(value)
        Next

        ' Remove elementos
        Dim removed = list.Pop()
        Console.WriteLine(vbCrLf & $"Elemento removido: {removed}")
        Console.WriteLine("Ap�s a remo��o:")
        For Each value In list
            Console.WriteLine(value)
        Next

        ' Exibe o n�mero total de elementos
        Console.WriteLine(vbCrLf & $"N�mero total de elementos na lista: {list.Count}")

        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module