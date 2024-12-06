Imports System

Module Program
    Sub Main()
        ' Exemplo de registros para construir a árvore
        Dim records As New List(Of TreeBuildingRecord) From {
            New TreeBuildingRecord With {.RecordId = 0, .ParentId = 0},  ' Raiz
            New TreeBuildingRecord With {.RecordId = 1, .ParentId = 0},  ' Child1
            New TreeBuildingRecord With {.RecordId = 2, .ParentId = 1},  ' Grandchild1
            New TreeBuildingRecord With {.RecordId = 3, .ParentId = 0},  ' Child2
            New TreeBuildingRecord With {.RecordId = 4, .ParentId = 1},  ' Grandchild2
            New TreeBuildingRecord With {.RecordId = 5, .ParentId = 0}   ' Child3
        }

        ' Construir a árvore
        Dim tree = TreeBuilder.BuildTree(records)

        ' Imprimir a árvore
        TreeBuilder.PrintTree(tree, "")
    End Sub
End Module