Imports System

Module Program
    Sub Main()
        ' Solicita ao usu�rio o n�mero de garrafas de in�cio e o n�mero de estrofes a recitar
        Console.WriteLine("Digite o n�mero de garrafas de cerveja no come�o:")
        Dim startBottles As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Quantas estrofes voc� deseja recitar?")
        Dim takeDown As Integer = Convert.ToInt32(Console.ReadLine())

        ' Chama a fun��o Recite para obter a sequ�ncia de estrofes
        Dim song As String = BeerSong.Recite(startBottles, takeDown)

        ' Exibe as estrofes no console
        Console.WriteLine(vbLf & song)
    End Sub
End Module