Imports System

Module Program
    Sub Main()
        ' Construção inicial da árvore
        Dim tree = New BinTree(1, New BinTree(2, Nothing, Nothing), New BinTree(3, Nothing, Nothing))

        ' Criação do Zipper
        Dim zipper2 = Zipper.FromTree(tree)
        Console.WriteLine($"Raiz: {zipper2.Value()}") ' Deve exibir 1

        ' Movendo para a esquerda
        Dim leftZipper = zipper2.Left()
        Console.WriteLine($"Esquerda: {leftZipper.Value()}") ' Deve exibir 2

        ' Movendo para a direita
        Dim rightZipper = zipper2.Right()
        Console.WriteLine($"Direita: {rightZipper.Value()}") ' Deve exibir 3

        ' Alterando o valor do nó
        Dim updatedZipper = zipper2.SetValue(10)
        Console.WriteLine($"Nova raiz: {updatedZipper.Value()}") ' Deve exibir 10

        ' Reconstruindo a árvore
        Dim newTree = updatedZipper.ToTree()
        Console.WriteLine($"Nova árvore raiz: {newTree.Value}") ' Deve exibir 10
    End Sub
End Module