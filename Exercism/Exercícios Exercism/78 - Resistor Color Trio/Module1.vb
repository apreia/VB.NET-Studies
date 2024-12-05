Public Module ResistorColorTrio
    ' Definindo a constante para 1.000 (Kiloohms)
    Private Const KiloOhms As Integer = 1_000

    ' Definindo as cores válidas para o resistor e seus respectivos valores
    Private ReadOnly AllColors As String() = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"}

    ' Função principal que retorna o valor do resistor com a unidade
    Public Function Label(ByVal colors As String()) As String
        ' Obtendo o valor do resistor
        Dim value = GetValue(colors)

        ' Obtendo a unidade (kiloohms ou ohms)
        Dim unit = GetUnit(value)

        ' Se a unidade for "kiloohms", divide o valor por 1000
        If unit = "kilo" Then value \= KiloOhms

        ' Retorna o valor formatado com a unidade
        Return String.Format("{0} {1}", value, unit & "ohms")
    End Function

    ' Função para calcular o valor do resistor com base nas cores
    Private Function GetValue(ByVal colors As String()) As Integer
        ' ResistorValue retorna o valor numérico de cada cor
        Return (ResistorValue(colors(0)) * 10 + ResistorValue(colors(1))) * CInt(Math.Pow(10, ResistorValue(colors(2))))
    End Function

    ' Função para obter a unidade (kiloohms ou ohms) dependendo do valor
    Private Function GetUnit(ByVal value As Integer) As String
        ' Se o valor for maior ou igual a 1000, a unidade é kiloohms, caso contrário é ohms
        Return If(value >= KiloOhms, "kilo", "")
    End Function

    ' Função que retorna o valor associado a cada cor
    Private Function ResistorValue(ByVal color As String) As Integer
        ' Retorna o índice da cor no array AllColors, que representa seu valor
        Return Array.IndexOf(AllColors, color)
    End Function
End Module