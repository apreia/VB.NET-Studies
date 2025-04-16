Imports System

Public Module CollatzConjecture
    Public Function Steps(ByVal number As Integer) As Integer
        ' Lançando ArgumentOutOfRangeException quando o número não for válido
        If number <= 0 Then
            Throw New ArgumentOutOfRangeException("O número deve ser maior que zero")
        End If

        Dim stepCount As Integer = 0

        ' Continua o processo enquanto o número não for 1
        While number <> 1
            ' Se o número for par, divide por 2
            If number Mod 2 = 0 Then
                number /= 2
                ' Se o número for ímpar, multiplica por 3 e adiciona 1
            Else
                number = 3 * number + 1
            End If
            stepCount += 1 ' Incrementa o contador de passos
        End While

        Return stepCount
    End Function
End Module