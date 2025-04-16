Imports System

Module Program
    Sub Main(args As String())
        ' Criando as rainhas nas posi��es fornecidas
        Dim whiteQueen As Queen = QueenAttack.Create(3, 2) ' c5
        Dim blackQueen As Queen = QueenAttack.Create(6, 5) ' f2

        ' Verificando se as rainhas podem se atacar
        If QueenAttack.CanAttack(whiteQueen, blackQueen) Then
            Console.WriteLine("Sim, as rainhas podem se atacar.")
        Else
            Console.WriteLine("N�o, as rainhas n�o podem se atacar.")
        End If
    End Sub
End Module