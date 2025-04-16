Imports System.Runtime.CompilerServices

Module RomanNumeralExtension
    <Extension()>
    Function ToRoman(ByVal value As Integer) As String
        ' Lista de valores romanos com a correspondência
        Dim romanNumerals As (Integer, String)() = {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        }

        ' String para armazenar o número romano
        Dim result As String = String.Empty

        ' Itera sobre a lista de numerais romanos, subtraindo o valor
        For Each numeral In romanNumerals
            Dim arabic As Integer = numeral.Item1
            Dim roman As String = numeral.Item2

            ' Enquanto o número for maior ou igual ao valor árabe, subtrai e adiciona o símbolo romano
            While value >= arabic
                result &= roman
                value -= arabic
            End While
        Next

        ' Retorna o número romano
        Return result
    End Function
End Module