Imports ByteBank.Classes

Public Class Frm_Video05
    Dim Conta As New ContaCorrente(237, 144422)
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Formulário de Vídeo 05"
        Lbl_Video05.Text = "Formulário de Vídeo 05"
        Btm_Fechar.Text = "Fechar"
        Grp_Movimentacao.Text = "Movimentação da conta"
        Lbl_Movimentacao.Text = "Digite o valor"
        Btm_Saque.Text = "Sacar"
        Lbl_ContaCorrente.Text = "Conta: " + Conta.Agencia.ToString + " - " + Conta.Numero.ToString
        Lbl_Saldo.Text = "Saldo da conta = " + Conta.Saldo.ToString

    End Sub

    Private Sub Btm_Fechar_Click(sender As Object, e As EventArgs) Handles Btm_Fechar.Click
        Close()
    End Sub

    Private Sub Btm_Saque_Click(sender As Object, e As EventArgs) Handles Btm_Saque.Click
        Try
            Dim ValorSacar As Double = Val(Txt_Valor.Text)
            Conta.Sacar(ValorSacar)
            Lbl_Saldo.Text = "Saldo da conta = " + Conta.Saldo.ToString
        Catch ex As Exception
            MsgBox("Ocorreu um erro Exception: " + ex.Message)
        End Try
    End Sub
End Class