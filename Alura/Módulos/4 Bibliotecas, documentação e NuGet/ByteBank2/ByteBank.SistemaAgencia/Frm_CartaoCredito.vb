Imports ByteBank.Bibliotecas.Classes.Clientes
Imports Humanizer
Public Class Frm_CartaoCredito
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Vencimento Cartão de Crédito"
        Grp_ContaCorrente.Text = "Conta Corrente"
        Lbl_Agencia.Text = "Agência"
        Lbl_ContaCorrente.Text = "Conta Corrente"
        Lbl_ContaCorrenteCriada.Text = ""
        Btm_Criar.Text = "Criar"
        Lbl_Vencimento.Text = "Data do Vencimento"
        Lbl_Mensagem.Text = ""
        Lbl_Mensagem2.Text = ""

    End Sub

    Private Sub Btm_Criar_Click(sender As Object, e As EventArgs) Handles Btm_Criar.Click
        Dim vAgencia As Integer = Val(Txt_Agencia.Text)
        Dim vContaCorrente As Integer = Val(Txt_ContaCorrente.Text)

        Dim Conta As ContaCorrente = New ContaCorrente(vAgencia, vContaCorrente)

        Dim vDataVencimento As Date = Dtp_Vencimento.Value

        Lbl_ContaCorrenteCriada.Text = "Agência: " + vAgencia.ToString + " - Conta: " + vContaCorrente.ToString + ". Data do Vencimento é " +
                                        Mid(vDataVencimento.ToString, 1, 10)

        Dim vDataHoje As Date = Date.Now()

        Lbl_Mensagem.Text = "Data de hoje é " + Mid(vDataHoje.ToString, 1, 10)

        Dim vTempoVencimento As TimeSpan = vDataVencimento - vDataHoje

        Lbl_Mensagem2.Text = "O vencimento será em " + TimeSpanHumanizeExtensions.Humanize(vTempoVencimento)
    End Sub
End Class