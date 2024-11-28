Public Class Frm_Principal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "1 - Primeira Classe"
        Lbl_Principal.Text = "1 - Primeira Classe"

        Btm_Acao.Text = "Conta Gabriela"
        Lbl_Saldo.Text = "Saldo"
        Lbl_Incremento.Text = "Incremento"

        Btm_Acao2.Text = "Conta Bruno"
    End Sub

    Private Sub Btm_Acao_Click(sender As Object, e As EventArgs) Handles Btm_Acao.Click
        'Dim Titular As String = "Gabriela"
        'Dim Agencia As Integer = 863
        'Dim Conta As Integer = 863141
        'Dim Saldo As Double = 100

        'Dim Titular2 As String = "Bruno"
        'Dim Agencia2 As Integer = 863
        'Dim Conta2 As Integer = 863142
        'Dim Saldo2 As Double = 50

        Dim ContaDaGrabiela As New ContaCorrente

        ContaDaGrabiela.Titular = "Gabriela"
        ContaDaGrabiela.Agencia = 863
        ContaDaGrabiela.Conta = 863141
        ContaDaGrabiela.Saldo = Val(Txt_Saldo.Text)

        MsgBox("O saldo da " + ContaDaGrabiela.Titular + " na C/C " + ContaDaGrabiela.Agencia.ToString + " _ " + ContaDaGrabiela.Conta.ToString +
               " é " + ContaDaGrabiela.Saldo.ToString)

        Dim vIncremento As Double = Val(Txt_Incremento.Text)
        ContaDaGrabiela.Saldo += vIncremento

        MsgBox("O saldo da " + ContaDaGrabiela.Titular + " na C/C " + ContaDaGrabiela.Agencia.ToString + " _ " + ContaDaGrabiela.Conta.ToString +
               " é " + ContaDaGrabiela.Saldo.ToString)
    End Sub

    Private Sub Btm_Acao2_Click(sender As Object, e As EventArgs) Handles Btm_Acao2.Click
        Dim ContaDoBruno As New ContaCorrente

        MsgBox(ContaDoBruno.Titular)
        MsgBox(ContaDoBruno.Agencia)
        MsgBox(ContaDoBruno.Conta)
        MsgBox(ContaDoBruno.Saldo)

        ContaDoBruno.Saldo += 100
        MsgBox(ContaDoBruno.Saldo)
    End Sub

    Private Sub Btm_ValRef_Click(sender As Object, e As EventArgs) Handles Btm_ValRef.Click
        'TIPO VALOR

        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade
        MsgBox("O valor da idade " + idade.ToString + " idade2 " + idade2.ToString)

        idade = 30
        MsgBox("O valor da idade " + idade.ToString + " idade2 " + idade2.ToString)

        Dim ContadaGabriela As New ContaCorrente()
        Dim ContadaGabrielaCosta As New ContaCorrente()

        ContadaGabriela.Titular = "Gabriela"
        ContadaGabriela.Agencia = 863
        ContadaGabriela.Conta = 863141

        ContadaGabrielaCosta = ContadaGabriela
        MsgBox("O valor da ContadaGabriela " + ContadaGabriela.Saldo.ToString + " ContadaGabrielaCosta " + ContadaGabrielaCosta.Saldo.ToString)

        ContadaGabriela.Saldo = 300
        MsgBox("O valor da ContadaGabriela " + ContadaGabriela.Saldo.ToString + " ContadaGabrielaCosta " + ContadaGabrielaCosta.Saldo.ToString)
    End Sub
End Class