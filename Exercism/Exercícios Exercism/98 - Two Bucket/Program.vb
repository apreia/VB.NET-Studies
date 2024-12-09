Imports System

Module Program
    Sub Main(args As String())
        Try
            ' Exemplo: Balde 1 com 3 litros, balde 2 com 5 litros, começando pelo balde 1
            Dim bucketOneCapacity = 3
            Dim bucketTwoCapacity = 5
            Dim goal = 4
            Dim startBucket = Bucket.One

            Dim twoBucket = New TwoBucket(bucketOneCapacity, bucketTwoCapacity, startBucket)
            Dim result = twoBucket.Measure(goal)

            Console.WriteLine($"Movimentos necessários: {result.Moves}")
            Console.WriteLine($"Balde que alcançou o objetivo: {result.GoalBucket}")
            Console.WriteLine($"Quantidade restante no outro balde: {result.OtherBucket}")
        Catch ex As Exception
            Console.WriteLine($"Erro: {ex.Message}")
        End Try
    End Sub
End Module