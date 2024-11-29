Imports System

Module Program
    Sub Main()
        ' Testando a função GetMatrix para diferentes tamanhos
        Dim size As Integer = 4
        Dim result = SpiralMatrix.GetMatrix(size)

        ' Exibindo a matriz resultante
        For i = 0 To size - 1
            For j = 0 To size - 1
                Console.Write(result(i, j).ToString("D2") & " ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
