Imports System

Module Program
    Sub Main()
        ' Gera um novo personagem
        Dim character As DndCharacter = DndCharacter.Generate()

        ' Exibe as informa��es do personagem gerado no console
        Console.WriteLine("Personagem Gerado:")
        Console.WriteLine("For�a: " & character.Strength)
        Console.WriteLine("Destreza: " & character.Dexterity)
        Console.WriteLine("Constitui��o: " & character.Constitution)
        Console.WriteLine("Intelig�ncia: " & character.Intelligence)
        Console.WriteLine("Sabedoria: " & character.Wisdom)
        Console.WriteLine("Carisma: " & character.Charisma)
        Console.WriteLine("Pontos de Vida: " & character.Hitpoints)

        ' Espera o usu�rio pressionar uma tecla para encerrar
        Console.ReadLine()
    End Sub
End Module