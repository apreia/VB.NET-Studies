Imports System

Module Program
    Sub Main()
        ' Solicita ao usuário o número de garrafas de início e o número de estrofes a recitar
        Console.WriteLine("Digite o número de garrafas de cerveja no começo:")
        Dim startBottles As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Quantas estrofes você deseja recitar?")
        Dim takeDown As Integer = Convert.ToInt32(Console.ReadLine())

        ' Chama a função Recite para obter a sequência de estrofes
        Dim song As String = BeerSong.Recite(startBottles, takeDown)

        ' Exibe as estrofes no console
        Console.WriteLine(vbLf & song)
    End Sub
End Module