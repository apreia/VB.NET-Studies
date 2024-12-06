Imports System

Module Program
    Sub Main(args As String())
        ' Solicitar ao usu�rio para inserir um n�mero
        Console.WriteLine("Digite um n�mero entre 0 e 999,999,999,999:")
        Dim input As String = Console.ReadLine()

        ' Tentar converter o input para um n�mero Long
        Dim number As Long
        If Long.TryParse(input, number) Then
            Try
                ' Chamar a fun��o que converte o n�mero para o ingl�s
                Dim result As String = Say.InEnglish(number)
                ' Exibir o resultado no console
                Console.WriteLine($"O n�mero {number} em ingl�s �: {result}")
            Catch ex As ArgumentOutOfRangeException
                Console.WriteLine($"Erro: {ex.Message}")
            End Try
        Else
            Console.WriteLine("Entrada inv�lida. Por favor, insira um n�mero v�lido.")
        End If

        ' Manter a janela do console aberta
        Console.ReadLine()
    End Sub
End Module