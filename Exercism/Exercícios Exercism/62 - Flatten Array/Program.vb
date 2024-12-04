Imports System

Module Program
    Sub Main()
        ' Exemplo de entrada: Lista aninhada com valores nulos
        Dim input As Object = New Object() {1, New Object() {2, 3, Nothing, 4}, New Object() {Nothing}, 5}

        ' Chama a função Flatten e converte o resultado para uma lista
        Dim flattenedResult = FlattenArray.Flatten(input).Cast(Of Object)().ToList()

        ' Exibe os resultados achatados
        Console.WriteLine("Resultado:")
        Console.WriteLine(String.Join(", ", flattenedResult))
    End Sub
End Module