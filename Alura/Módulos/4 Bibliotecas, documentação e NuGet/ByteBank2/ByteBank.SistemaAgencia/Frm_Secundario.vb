Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_Secundario
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Formulário Secundário"
        Grp_ContaCorrente.Text = "Conta Corrente"
        Lbl_Agencia.Text = "Agência"
        Lbl_ContaCorrente.Text = "Conta Corrente"
        Lbl_ContaCorrenteCriada.Text = ""
        Btm_Criar.Text = "Criar"
    End Sub

    Private Sub Btm_Criar_Click(sender As Object, e As EventArgs) Handles Btm_Criar.Click
        Dim vAgencia As Integer = Val(Txt_Agencia.Text)
        Dim vContaCorrente As Integer = Val(Txt_ContaCorrente.Text)

        Dim Conta As ContaCorrente = New ContaCorrente(vAgencia, vContaCorrente)

        Dim Conta2 As ContaCorrente = New ContaCorrente(222, 2222222)

        Lbl_ContaCorrenteCriada.Text = "Agência: " + vAgencia.ToString + " - Conta: " + vContaCorrente.ToString
    End Sub
End Class