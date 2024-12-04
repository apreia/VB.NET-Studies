Imports System

Module Program
    Sub Main()
        ' Exibe o menu para interação com o usuário.
        Console.WriteLine("Escolha uma das opções:")
        Console.WriteLine("1. Recitar um verso específico.")
        Console.WriteLine("2. Recitar múltiplos versos.")
        Console.WriteLine("3. Recitar a música inteira.")
        Console.Write("Digite sua opção: ")

        Dim choice As Integer = Convert.ToInt32(Console.ReadLine())

        Select Case choice
            Case 1
                ' Recitar um único verso.
                Console.Write("Digite o número do verso (1-8): ")
                Dim verseNumber As Integer = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine(FoodChain.Recite(verseNumber))
            Case 2
                ' Recitar múltiplos versos.
                Console.Write("Digite o número inicial do verso (1-8): ")
                Dim startVerse As Integer = Convert.ToInt32(Console.ReadLine())
                Console.Write("Digite o número final do verso (1-8): ")
                Dim endVerse As Integer = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine(FoodChain.Recite(startVerse, endVerse))
            Case 3
                ' Recitar a música inteira.
                Console.WriteLine(FoodChain.Recite(1, 8))
            Case Else
                Console.WriteLine("Opção inválida!")
        End Select

        ' Finaliza o programa.
        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module
