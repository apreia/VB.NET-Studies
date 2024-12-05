Imports System

Module Program
    Sub Main()
        ' Gera um novo personagem
        Dim character As DndCharacter = DndCharacter.Generate()

        ' Exibe as informações do personagem gerado no console
        Console.WriteLine("Personagem Gerado:")
        Console.WriteLine("Força: " & character.Strength)
        Console.WriteLine("Destreza: " & character.Dexterity)
        Console.WriteLine("Constituição: " & character.Constitution)
        Console.WriteLine("Inteligência: " & character.Intelligence)
        Console.WriteLine("Sabedoria: " & character.Wisdom)
        Console.WriteLine("Carisma: " & character.Charisma)
        Console.WriteLine("Pontos de Vida: " & character.Hitpoints)

        ' Espera o usuário pressionar uma tecla para encerrar
        Console.ReadLine()
    End Sub
End Module