Imports ByteBank.Classes

Public Class Frm_Video05
    Dim Conta As New ContaCorrente(237, 144422)
    Dim Conta2 As New ContaCorrente(237, 166433)
    Dim vStack As String = ""
    Dim vControle As Boolean = False

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
        Lbl_ContaCorrente2.Text = "Conta: " + Conta2.Agencia.ToString + " - " + Conta2.Numero.ToString
        Lbl_Saldo.Text = "Saldo da conta = " + Conta.Saldo.ToString
        Lbl_Saldo2.Text = "Saldo da conta = " + Conta2.Saldo.ToString
        Btm_Transferir.Text = "Trasnferir"
        Btm_Stack.Text = "Ver StackTrace"
        Txt_Stack.Visible = False

    End Sub

    Private Sub Btm_Fechar_Click(sender As Object, e As EventArgs) Handles Btm_Fechar.Click
        Close()
    End Sub

    Private Sub Btm_Saque_Click(sender As Object, e As EventArgs) Handles Btm_Saque.Click
        Try
            vStack = ""
            Dim ValorSacar As Double = Val(Txt_Valor.Text)
            Conta.Sacar(ValorSacar, "sacado")
            Lbl_Saldo.Text = "Saldo da conta = " + Conta.Saldo.ToString

        Catch ex As ValorSacadoMenorSaldoException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro ValorSacadoMenorSaldoException: " + ex.Message + ". Valor Saque de " + ex.ValorSacado.ToString + ". Saldo de " + ex.Saldo.ToString)

        Catch ex As ArgumentException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro ArgumentException: " + ex.Message)

        Catch ex As Exception
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub Btm_Transferir_Click(sender As Object, e As EventArgs) Handles Btm_Transferir.Click
        Try
            vStack = ""
            Dim ValorTransferencia As Double = Val(Txt_Valor.Text)
            Conta.Transferir(ValorTransferencia, Conta2)
            Lbl_Saldo.Text = "Saldo da conta = " + Conta.Saldo.ToString
            Lbl_Saldo2.Text = "Saldo da conta2 = " + Conta2.Saldo.ToString

        Catch ex As ValorSacadoMenorSaldoException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro ValorSacadoMenorSaldoException: " + ex.Message + ". Valor da Transferencia " + ex.ValorSacado.ToString + ". Saldo de " + ex.Saldo.ToString)

        Catch ex As ArgumentException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro ArgumentException: " + ex.Message)

        Catch ex As Exception
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub Btm_Stack_Click(sender As Object, e As EventArgs) Handles Btm_Stack.Click
        If vControle = False Then
            vControle = True
            Txt_Stack.Visible = True
        Else
            vControle = False
            Txt_Stack.Visible = False
        End If
        Txt_Stack.Text = vStack
    End Sub
End Class