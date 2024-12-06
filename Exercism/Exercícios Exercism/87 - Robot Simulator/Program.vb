Imports System

Module Program
    Sub Main()
        ' Cria um novo robô no ponto (7, 3), voltado para o Norte
        Dim robot As New RobotSimulator(DirectionType.North, 7, 3)

        ' Exibe a posição e direção inicial
        Console.WriteLine($"Posição inicial: ({robot.X}, {robot.Y}), Direção: {robot.Direction}")

        ' Executa os movimentos
        robot.Move("RAALAL")

        ' Exibe a posição final e direção
        Console.WriteLine($"Posição final: ({robot.X}, {robot.Y}), Direção: {robot.Direction}")

        ' Espera a entrada do usuário antes de sair
        Console.ReadLine()
    End Sub
End Module