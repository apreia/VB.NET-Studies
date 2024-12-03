Imports System

Public Module ResistorColorDuo
    Public Function Value(ByVal colors As String()) As Integer
        ' Dicionário atualizado para cores em inglês
        Dim colorCode As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From {
            {"black", 0},
            {"brown", 1},
            {"red", 2},
            {"orange", 3},
            {"yellow", 4},
            {"green", 5},
            {"blue", 6},
            {"violet", 7},
            {"grey", 8},
            {"white", 9}
        }

        ' Validar se existem pelo menos duas cores
        If colors.Length < 2 Then
            Throw New ArgumentException("At least two colors must be provided.")
        End If

        ' Obter os valores das duas primeiras cores
        Dim firstValue As Integer = colorCode(colors(0).ToLower())
        Dim secondValue As Integer = colorCode(colors(1).ToLower())

        ' Retornar o número combinado
        Return firstValue * 10 + secondValue
    End Function
End Module