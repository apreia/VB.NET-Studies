Imports System

Module Program
    Sub Main()
        ' Exemplo de entrada de texto
        Dim input As String = "ABC" & vbLf & "DE" & vbLf & "FGH"

        Console.WriteLine("Texto Original:")
        Console.WriteLine(input)
        Console.WriteLine()

        ' Chamando o método Transpose.Text
        Dim transposed As String = Transpose.Text(input)

        Console.WriteLine("Texto Transposto:")
        Console.WriteLine(transposed)
        Console.WriteLine()

        ' Exemplo para entrada personalizada do usuário
        Console.WriteLine("Digite um texto para transpor (pressione Enter para finalizar):")
        Dim userInput As String = String.Empty
        Dim line As String

        ' Leitura do texto do usuário até uma linha vazia
        Do
            line = Console.ReadLine()
            If String.IsNullOrEmpty(line) Then Exit Do
            userInput &= line & vbLf
        Loop

        ' Remover o último nova linha para evitar problemas
        If userInput.EndsWith(vbLf) Then
            userInput = userInput.TrimEnd(vbLf.ToCharArray())
        End If

        If Not String.IsNullOrEmpty(userInput) Then
            Console.WriteLine()
            Console.WriteLine("Texto Transposto do Usuário:")
            Dim userTransposed As String = Transpose.Text(userInput)
            Console.WriteLine(userTransposed)
        Else
            Console.WriteLine("Nenhum texto foi inserido.")
        End If

        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module