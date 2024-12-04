Imports System

Module Program
    Sub Main()
        ' Exibe o menu para intera��o com o usu�rio.
        Console.WriteLine("Escolha uma das op��es:")
        Console.WriteLine("1. Recitar um verso espec�fico.")
        Console.WriteLine("2. Recitar m�ltiplos versos.")
        Console.WriteLine("3. Recitar a m�sica inteira.")
        Console.Write("Digite sua op��o: ")

        Dim choice As Integer = Convert.ToInt32(Console.ReadLine())

        Select Case choice
            Case 1
                ' Recitar um �nico verso.
                Console.Write("Digite o n�mero do verso (1-8): ")
                Dim verseNumber As Integer = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine(FoodChain.Recite(verseNumber))
            Case 2
                ' Recitar m�ltiplos versos.
                Console.Write("Digite o n�mero inicial do verso (1-8): ")
                Dim startVerse As Integer = Convert.ToInt32(Console.ReadLine())
                Console.Write("Digite o n�mero final do verso (1-8): ")
                Dim endVerse As Integer = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine(FoodChain.Recite(startVerse, endVerse))
            Case 3
                ' Recitar a m�sica inteira.
                Console.WriteLine(FoodChain.Recite(1, 8))
            Case Else
                Console.WriteLine("Op��o inv�lida!")
        End Select

        ' Finaliza o programa.
        Console.WriteLine("Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module
