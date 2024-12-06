Imports System

Module Program
    Sub Main()
        ' Criando robôs
        Dim robot1 As New Robot()
        Console.WriteLine("Robot 1 Name: " & robot1.Name)  ' Exibe o nome aleatório gerado

        Dim robot2 As New Robot()
        Console.WriteLine("Robot 2 Name: " & robot2.Name)  ' Exibe o nome aleatório gerado

        ' Resetando o robô
        robot1.Reset()
        Console.WriteLine("Robot 1 New Name after Reset: " & robot1.Name)  ' Exibe o novo nome após o reset
    End Sub
End Module