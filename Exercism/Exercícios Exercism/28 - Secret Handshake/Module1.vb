Imports System

Public Module SecretHandshake
    Public Function Commands(ByVal commandValue As Integer) As String()
        ' Definir as ações correspondentes aos 5 bits
        Dim actions As String() = {"wink", "double blink", "close your eyes", "jump", "reverse"}

        ' Converter o número para binário
        Dim binary As String = Convert.ToString(commandValue, 2).PadLeft(5, "0"c)

        ' Criar uma lista de ações para armazenar as ações correspondentes aos bits
        Dim result As New List(Of String)

        ' Analisar os 5 bits mais à direita
        For i As Integer = 0 To 4
            If binary(4 - i) = "1"c Then
                If actions(i) = "reverse" Then
                    ' Apenas marque a ação de "reverse", não adicione à lista ainda
                    result.Add(actions(i))
                Else
                    result.Add(actions(i))
                End If
            End If
        Next

        ' Verificar se a ação "reverse" foi marcada, invertendo a ordem
        If result.Contains("reverse") Then
            result.Remove("reverse")
            result.Reverse()
        End If

        ' Retornar o array de ações
        Return result.ToArray()
    End Function
End Module