Imports System

Module Program
    Sub Main()
        Console.WriteLine("Digite o número de trilhos:")
        Dim rails As Integer
        If Not Integer.TryParse(Console.ReadLine(), rails) OrElse rails < 2 Then
            Console.WriteLine("Número de trilhos inválido. Deve ser pelo menos 2.")
            Return
        End If

        ' Cria a instância da cifra Rail Fence
        Dim cipher As New RailFenceCipher(rails)

        ' Solicita o texto a ser codificado
        Console.WriteLine("Digite o texto a ser codificado:")
        Dim input As String = Console.ReadLine()

        ' Codifica o texto
        Dim encoded As String = cipher.Encode(input)
        Console.WriteLine($"Texto codificado: {encoded}")

        ' Decodifica o texto
        Dim decoded As String = cipher.Decode(encoded)
        Console.WriteLine($"Texto decodificado: {decoded}")

        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module