Imports System

Module Program
    Sub Main(args As String())
        Dim dice As Integer() = {3, 3, 3, 3, 3}
        Dim category As YachtCategory = YachtCategory.Yacht
        Console.WriteLine(YachtGame.Score(dice, category)) ' Deve retornar 50
    End Sub
End Module