Public Class Frm_Principal_02

    Dim ContaDaGabriela As New ContaCorrente
    Dim ContaDoBruno As New ContaCorrente
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        'Inicialização dos textos para Gabriela
        Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Principal_02.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Valor_Gabriela.Text = "Valor a ser Depositado/Sacado"
        Btm_Sacar_Gabriela.Text = "Efetuar Saque"
        Btm_Depositar_Gabriela.Text = "Efetuar Depósito"
        Btm_Transferir_Gabriela.Text = "Efetuar Transferência"
        Lbl_Saldo_Gabriela.Text = "Novo Saldo"
        Lbl_Resultado_Gabriela.Text = "Resultado do saque"
        Lbl_SaldoAtual_Gabriela.Text = "Saldo Atual"
        Grp_Gabriela.Text = "Gabriela"

        Txt_SaldoAtual_Gabriela.ReadOnly = True
        Txt_Saldo_Gabriela.ReadOnly = True
        Txt_Resultado_Gabriela.ReadOnly = True
        Txt_Extrato_Gabriela.ReadOnly = True

        'Inicialização dos textos para Bruno
        Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Principal_02.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Valor_Bruno.Text = "Valor a ser Depositado/Sacado"
        Btm_Sacar_Bruno.Text = "Efetuar Saque"
        Btm_Depositar_Bruno.Text = "Efetuar Depósito"
        Btm_Transferir_Bruno.Text = "Efetuar Transferência"
        Lbl_Saldo_Bruno.Text = "Novo Saldo"
        Lbl_Resultado_Bruno.Text = "Resultado do saque"
        Lbl_SaldoAtual_Bruno.Text = "Saldo Atual"
        Grp_Bruno.Text = "Bruno"

        Txt_SaldoAtual_Bruno.ReadOnly = True
        Txt_Saldo_Bruno.ReadOnly = True
        Txt_Resultado_Bruno.ReadOnly = True
        Txt_Extrato_Bruno.ReadOnly = True

        'Inicialização dos dados da classe da Gabriela
        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        Lbl_BemVindo_Gabriela.Text = " Bem vindo: " + ContaDaGabriela.Titular + vbCrLf + " Agência: " + ContaDaGabriela.Agencia.ToString + vbCrLf + " Conta Corrente: " + ContaDaGabriela.Conta.ToString

        Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString

        'Inicialização dos dados da classe da Bruno
        ContaDoBruno.Titular = "Bruno"
        ContaDoBruno.Agencia = 863
        ContaDoBruno.Conta = 863224

        Lbl_BemVindo_Bruno.Text = " Bem vindo: " + ContaDoBruno.Titular + vbCrLf + " Agência: " + ContaDoBruno.Agencia.ToString + vbCrLf + " Conta Corrente: " + ContaDoBruno.Conta.ToString

        Txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString

    End Sub

    Private Sub Btm_Sacar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Sacar_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorSacar = Val(Txt_Valor_Gabriela.Text)
        Dim RetornoSaque = ContaDaGabriela.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Gabriela.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Resultado_Gabriela.Text = "Saque efetuado com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text

            ContaDaGabriela.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " Saldo " + ContaDaGabriela.Saldo.ToString + ". " + vbCrLf
            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
        End If
    End Sub

    Private Sub Btm_Depositar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Depositar_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorDepositar = Val(Txt_Valor_Gabriela.Text)
        ContaDaGabriela.Depositar(ValorDepositar)

        Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
        Txt_Resultado_Gabriela.Text = "Depósito efetuado com sucesso"
        Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text

        ContaDaGabriela.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString + " Saldo " + ContaDaGabriela.Saldo.ToString + ". " + vbCrLf
        Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
    End Sub

    Private Sub Btm_Depositar_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Depositar_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorDepositar = Val(Txt_Valor_Bruno.Text)
        ContaDoBruno.Depositar(ValorDepositar)

        Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString
        Txt_Resultado_Bruno.Text = "Depósito efetuado com sucesso"
        Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

        ContaDoBruno.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString + " Saldo " + ContaDoBruno.Saldo.ToString + ". " + vbCrLf
        Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
    End Sub

    Private Sub Btm_Sacar_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Sacar_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorSacar = Val(Txt_Valor_Bruno.Text)
        Dim RetornoSaque = ContaDoBruno.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Bruno.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString
            Txt_Resultado_Bruno.Text = "Saque efetuado com sucesso"
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDoBruno.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " Saldo " + ContaDoBruno.Saldo.ToString + ". " + vbCrLf
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        End If
    End Sub

    Private Sub Btm_Transferir_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Transferir_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorTransferir = Val(Txt_Valor_Gabriela.Text)

        Dim RetornoTransferencia = ContaDaGabriela.Transferir(ValorTransferir, ContaDoBruno)

        If RetornoTransferencia = False Then
            Txt_Resultado_Gabriela.Text = "Tranferência não é possível ser feita"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString

            Txt_Resultado_Gabriela.Text = "Transferência efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDaGabriela.Extrato += Now.ToString + " Transferência de " + ValorTransferir.ToString + " Saldo de " + ContaDaGabriela.Saldo.ToString + ". " + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferência de " + ValorTransferir.ToString + " Saldo de " + ContaDoBruno.Saldo.ToString + ". " + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        End If
    End Sub

    Private Sub Btm_Transferir_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Transferir_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorTransferir = Val(Txt_Valor_Bruno.Text)

        Dim RetornoTransferencia = ContaDoBruno.Transferir(ValorTransferir, ContaDaGabriela)

        If RetornoTransferencia = False Then
            Txt_Resultado_Bruno.Text = "Tranferência não é possível ser feita"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString

            Txt_Resultado_Bruno.Text = "Transferência efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDaGabriela.Extrato += Now.ToString + " Transferência de " + ValorTransferir.ToString + " Saldo de " + ContaDaGabriela.Saldo.ToString + ". " + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferência de " + ValorTransferir.ToString + " Saldo de " + ContaDoBruno.Saldo.ToString + ". " + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        End If
    End Sub
End Class