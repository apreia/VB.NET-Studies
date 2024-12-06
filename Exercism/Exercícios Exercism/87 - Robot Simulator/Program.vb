Imports System

Module Program
    Sub Main()
        ' Cria um novo rob� no ponto (7, 3), voltado para o Norte
        Dim robot As New RobotSimulator(DirectionType.North, 7, 3)

        ' Exibe a posi��o e dire��o inicial
        Console.WriteLine($"Posi��o inicial: ({robot.X}, {robot.Y}), Dire��o: {robot.Direction}")

        ' Executa os movimentos
        robot.Move("RAALAL")

        ' Exibe a posi��o final e dire��o
        Console.WriteLine($"Posi��o final: ({robot.X}, {robot.Y}), Dire��o: {robot.Direction}")

        ' Espera a entrada do usu�rio antes de sair
        Console.ReadLine()
    End Sub
End Module