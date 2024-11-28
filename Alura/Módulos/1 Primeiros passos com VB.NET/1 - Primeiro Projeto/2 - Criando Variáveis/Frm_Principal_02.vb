Public Class Frm_Principal_02
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btm_NumerosInteiros_Click(sender As Object, e As EventArgs) Handles Btm_NumerosInteiros.Click
        Dim idade As Integer
        idade = 12
        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Information)

        idade = 12 * 5
        MsgBox("O valor da idade multiplicado por 5 é " + idade.ToString, MsgBoxStyle.Information)

        idade = (12 * 5) + 10
        MsgBox("O valor da idade multiplicado por 5 e somado de 10 é " + idade.ToString, MsgBoxStyle.Information)
    End Sub

    Private Sub Btm_PontoFlutuante_Click(sender As Object, e As EventArgs) Handles Btm_PontoFlutuante.Click
        Dim valor As Double
        valor = 9.5
        MsgBox("A variavel valor é igual a " + valor.ToString, MsgBoxStyle.Information)

        valor = 5 / 2
        MsgBox("O valor de 5 / 2 é igual a " + valor.ToString, MsgBoxStyle.Information)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador
        MsgBox("O valor de 5 / 2 é igual a " + valor.ToString, MsgBoxStyle.Information)
    End Sub

    Private Sub Btm_ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles Btm_ConversaoNumeros.Click
        Dim salario As Double
        salario = 1300.45

        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O valor do salário é " + salario.ToString + " e do salário inteiro é " + salarioInteiro.ToString, MsgBoxStyle.Information)

        Dim salarioGrande As Long
        salarioGrande = 1300000000000000000
        MsgBox("O valor do salário longo é " + salarioGrande.ToString, salarioInteiro.ToString, MsgBoxStyle.Information)

        Dim salarioPequeno As Short
        salarioPequeno = 100
        MsgBox("O valor do salário pequeno é " + salarioPequeno.ToString, salarioInteiro.ToString, MsgBoxStyle.Information)

        Dim salarioMinusculo As SByte
        salarioMinusculo = 10
        MsgBox("O valor do salário minusculo é " + salarioMinusculo.ToString, salarioInteiro.ToString, MsgBoxStyle.Information)

        Dim valorDouble As Double
        valorDouble = 9.238748234798
        MsgBox("O valor da variável double é " + valorDouble.ToString, salarioInteiro.ToString, MsgBoxStyle.Information)

        Dim valorDecimal As Double
        valorDecimal = 9.238748234798
        MsgBox("O valor da variável decimal é " + valorDecimal.ToString, salarioInteiro.ToString, MsgBoxStyle.Information)

        '----------------------------------------------------------------'
        ''--Anotação--''
        ' Long = -9.223.372.036.854.775.808 até 9.223.372.036.854.775.807
        'Integer = -2.147.483.648 até 2.147.483.647
        'Short = -32.768 ate 32.767
        'Sbyte = -128 até 127

        'Double = Não tem uma precisão exata (64 Bits)
        'Decimal = Excelente precisão (128 Bits)
        '----------------------------------------------------------------'
    End Sub

    Private Sub Btm_Resultado_Click(sender As Object, e As EventArgs) Handles Btm_Resultado.Click
        Dim numerador As Double
        Dim denominador As Double

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text

        Dim resultadoDecimal As Decimal
        resultadoDecimal = numerador / denominador
        MsgBox("O resultado da divisão (Decimal) entre " + numerador.ToString + " por " _
              + denominador.ToString + " é = " + resultadoDecimal.ToString, MsgBoxStyle.Information)

        Dim resultadoDouble As Double
        resultadoDouble = numerador / denominador
        MsgBox("O resultado da divisão (Double) entre " + numerador.ToString + " por " _
              + denominador.ToString + " é = " + resultadoDouble.ToString, MsgBoxStyle.Information)

        Txt_ResultadoDecimal.Text = resultadoDecimal.ToString
        Txt_ResultadoDouble.Text = resultadoDouble.ToString
    End Sub
End Class