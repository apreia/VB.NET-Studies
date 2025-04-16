Imports System.Linq

Public Module BeerSong
    ' Função que retorna uma estrofe da canção com base no número de garrafas
    Public Function Verse(ByVal number As Integer) As String
        ' Usando um bloco Select Case para decidir o que retornar baseado no número de garrafas
        Select Case number
            ' Caso tenha 0 garrafas
            Case 0
                ' Retorna a estrofe correspondente ao caso 0, onde não há mais garrafas
                Return "No more bottles of beer on the wall, no more bottles of beer." & vbLf &
                       "Go to the store and buy some more, 99 bottles of beer on the wall."
            ' Caso tenha 1 garrafa
            Case 1
                ' Retorna a estrofe correspondente ao caso 1, com 1 garrafa
                Return "1 bottle of beer on the wall, 1 bottle of beer." & vbLf &
                       "Take it down and pass it around, no more bottles of beer on the wall."
            ' Caso tenha 2 garrafas
            Case 2
                ' Retorna a estrofe correspondente ao caso 2, com 2 garrafas
                Return "2 bottles of beer on the wall, 2 bottles of beer." & vbLf &
                       "Take one down and pass it around, 1 bottle of beer on the wall."
                ' Caso o número de garrafas seja maior que 2
            Case Else
                ' Retorna uma estrofe padrão para números maiores que 2, usando o formato da string
                ' O número de garrafas diminui em 1 após cada ação
                Return String.Format("{0} bottles of beer on the wall, {0} bottles of beer." & vbLf &
                                     "Take one down and pass it around, {1} bottles of beer on the wall.", number, number - 1)
        End Select
    End Function

    ' Função que recita várias estrofes da canção começando com 'startBottles' garrafas e recitando 'takeDown' estrofes
    Public Function Recite(ByVal startBottles As Integer, ByVal takeDown As Integer) As String
        Return String.Join(vbLf & vbLf, Enumerable.Range(startBottles - takeDown + 1, takeDown).Reverse().[Select](New Func(Of Integer, String)(AddressOf Verse)))
    End Function
End Module