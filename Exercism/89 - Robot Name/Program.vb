Imports System

Module Program
    Sub Main()
        ' Criando rob�s
        Dim robot1 As New Robot()
        Console.WriteLine("Robot 1 Name: " & robot1.Name)  ' Exibe o nome aleat�rio gerado

        Dim robot2 As New Robot()
        Console.WriteLine("Robot 2 Name: " & robot2.Name)  ' Exibe o nome aleat�rio gerado

        ' Resetando o rob�
        robot1.Reset()
        Console.WriteLine("Robot 1 New Name after Reset: " & robot1.Name)  ' Exibe o novo nome ap�s o reset
    End Sub
End Module