Imports System.Diagnostics.Eventing.Reader
Imports ByteBank.Classes

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Projeto ByteBank"
        Lbl_Principal.Text = "Projeto ByteBank"
        Lbl_Denominador.Text = "Digite o Denominador"
        Lbl_Agencia.Text = "Agencia"
        Lbl_Conta.Text = "Conta"

    End Sub

    Private Sub Vídeo01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo01ToolStripMenuItem.Click
        Dim conta As New ContaCorrente(237, 117333)
        MsgBox("O número de contas correntes criadas são de " + ContaCorrente.TotalDeContasCriadas.ToString)
        MsgBox("O valor das taxas de operações está em " + ContaCorrente.TaxaOperacao.ToString)
    End Sub

    Private Sub Vídeo02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo02ToolStripMenuItem.Click
        Dim denominador As Integer = Val(Txt_Denominador.Text)
        Dim resposta As Integer = TestarDivisao(denominador)

        If resposta = -1 Then
            MsgBox("Não é possível fazer a divisão porque o denominador é igual a zero")
        ElseIf resposta = -2 Then
            MsgBox("Não é possível fazer a divisão porque o denominador é maior que o numerador")
        Else
            MsgBox("O valor da divisão entre 10 e" + denominador.ToString = " é de " + resposta.ToString)
        End If
    End Sub

    Function TestarDivisao(valor As Integer) As Integer
        Dim Resultado As Integer = Efetuardivisao(10, valor)

        If Resultado = -1 Then
            Return -1

        ElseIf Resultado = -2 Then
            Return -2
        Else
        End If

        Return Resultado
    End Function

    Function Efetuardivisao(Numerador As Integer, Denominador As Integer) As Integer
        If Denominador = 0 Then
            Return -1
        End If

        If Denominador > Numerador Then
            Return -2
        End If

        Return Numerador / Denominador
    End Function

    Private Sub Vídeo03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo03ToolStripMenuItem.Click
        Dim denominador As Integer = Val(Txt_Denominador.Text)

        Try
            TestarDivisao2(denominador)
        Catch ex As InvalidCastException
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houve um erro de conversçao de um Double para um string em algum MsgBox.")
        Catch ex As OverflowException
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houve um erro de divisão por zero.")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houve um erro genérico. Observe a mensagem de retorno da exceção.")
        End Try
    End Sub

    Sub TestarDivisao2(valor As Integer)
        Dim Resultado As Integer = Efetuardivisao2(10, valor)

        MsgBox("Erro de divisão ocorreu mas estou continuou o programa")

        If valor = 5 Then
            Dim Conta As New ContaCorrente(277, 344445)
            MsgBox(Conta.Titular.Nome)
        End If

        MsgBox("O valor da divisão entre 10 e " + valor.ToString = " é de " + Resultado)
    End Sub

    Function Efetuardivisao2(Numerador As Integer, Denominador As Integer) As Integer
        Try
            Return Numerador / Denominador
        Catch ex As OverflowException
            MsgBox("Tentamos dividir o número " + Numerador.ToString = " por " + Denominador.ToString)
            Throw
        End Try
    End Function

    Private Sub Vídeo04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo04ToolStripMenuItem.Click
        Try
            Dim vAgencia As Integer = Val(Txt_Agencia.Text)
            Dim vConta As Integer = Val(Txt_Conta.Text)

            Dim Conta As New ContaCorrente(vAgencia, vConta)

            MsgBox("O código da agencia e conta são " + Conta.Agencia.ToString = " - " + Conta.Numero.ToString)
        Catch ex As ArgumentException
            MsgBox(ex.Message)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Vídeo05ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo05ToolStripMenuItem.Click
        Dim f As New Frm_Video05
        f.ShowDialog()
    End Sub
End Class