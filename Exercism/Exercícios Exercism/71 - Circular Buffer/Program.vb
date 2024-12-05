Imports System

Module Program
    Sub Main()
        ' Cria um buffer circular de capacidade 3
        Dim buffer As New CircularBuffer(Of Integer)(3)

        ' Escrevendo valores no buffer
        Console.WriteLine("Escrevendo valores: 1, 2, 3")
        buffer.Write(1)
        buffer.Write(2)
        buffer.Write(3)

        ' Tentando escrever em um buffer cheio
        Try
            Console.WriteLine("Tentando escrever 4 (deve falhar)...")
            buffer.Write(4)
        Catch ex As Exception
            Console.WriteLine($"Erro: {ex.Message}")
        End Try

        ' Lendo valores do buffer
        Console.WriteLine($"Lendo valor: {buffer.Read()}") ' Output: 1
        Console.WriteLine($"Lendo valor: {buffer.Read()}") ' Output: 2

        ' Sobrescrevendo valores
        Console.WriteLine("Sobrescrevendo com 4 e 5")
        buffer.Overwrite(4)
        buffer.Overwrite(5)

        ' Lendo os valores restantes
        Console.WriteLine($"Lendo valor: {buffer.Read()}") ' Output: 3
        Console.WriteLine($"Lendo valor: {buffer.Read()}") ' Output: 4
        Console.WriteLine($"Lendo valor: {buffer.Read()}") ' Output: 5

        ' Tentando ler de um buffer vazio
        Try
            Console.WriteLine("Tentando ler de um buffer vazio...")
            Console.WriteLine($"Lendo valor: {buffer.Read()}")
        Catch ex As Exception
            Console.WriteLine($"Erro: {ex.Message}")
        End Try

        ' Limpando o buffer
        Console.WriteLine("Limpando o buffer...")
        buffer.Clear()

        ' Verificando após limpar
        Try
            Console.WriteLine("Tentando ler após limpar o buffer...")
            Console.WriteLine($"Lendo valor: {buffer.Read()}")
        Catch ex As Exception
            Console.WriteLine($"Erro: {ex.Message}")
        End Try
    End Sub
End Module