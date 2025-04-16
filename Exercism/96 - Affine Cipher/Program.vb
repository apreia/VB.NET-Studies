Imports System

Module Program
    Sub Main()
        Console.WriteLine("=== Affine Cipher ===")

        While True
            Console.WriteLine("Escolha uma opção:")
            Console.WriteLine("1. Codificar (Encode)")
            Console.WriteLine("2. Decodificar (Decode)")
            Console.WriteLine("3. Sair")

            Dim choice As String = Console.ReadLine()

            Select Case choice
                Case "1"
                    Console.Write("Digite o texto para codificar: ")
                    Dim plainText As String = Console.ReadLine()

                    Console.Write("Digite o valor de 'a': ")
                    Dim a As Integer = Integer.Parse(Console.ReadLine())

                    Console.Write("Digite o valor de 'b': ")
                    Dim b As Integer = Integer.Parse(Console.ReadLine())

                    Try
                        Dim encodedText As String = AffineCipher.Encode(plainText, a, b)
                        Console.WriteLine($"Texto codificado: {encodedText}")
                    Catch ex As ArgumentException
                        Console.WriteLine($"Erro: {ex.Message}")
                    End Try

                Case "2"
                    Console.Write("Digite o texto para decodificar: ")
                    Dim cipheredText As String = Console.ReadLine()

                    Console.Write("Digite o valor de 'a': ")
                    Dim a As Integer = Integer.Parse(Console.ReadLine())

                    Console.Write("Digite o valor de 'b': ")
                    Dim b As Integer = Integer.Parse(Console.ReadLine())

                    Try
                        Dim decodedText As String = AffineCipher.Decode(cipheredText, a, b)
                        Console.WriteLine($"Texto decodificado: {decodedText}")
                    Catch ex As ArgumentException
                        Console.WriteLine($"Erro: {ex.Message}")
                    End Try

                Case "3"
                    Console.WriteLine("Saindo...")
                    Exit Sub

                Case Else
                    Console.WriteLine("Opção inválida. Tente novamente.")
            End Select

            Console.WriteLine() ' Linha em branco para separar as execuções
        End While
    End Sub
End Module