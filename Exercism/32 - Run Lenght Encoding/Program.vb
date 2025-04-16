Imports System

Module Program
    Sub Main(args As String())
        ' Solicita ao usu�rio para inserir uma string para codificar
        Console.WriteLine("Digite uma string para codificar:")
        Dim input As String = Console.ReadLine()

        ' Codifica a string
        Dim encoded As String = RunLengthEncoding.Encode(input)
        Console.WriteLine($"String codificada: {encoded}")

        ' Decodifica a string
        Dim decoded As String = RunLengthEncoding.Decode(encoded)
        Console.WriteLine($"String decodificada: {decoded}")

        ' Aguarda o usu�rio pressionar uma tecla para encerrar
        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module