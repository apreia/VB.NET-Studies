Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Principal"
        Lbl_Principal.Text = "Principal"
        Btm_Click.Text = "Clique aqui"
        Btm_TesteHerenca.Text = "Clique aqui para testar herança"
        Btm_ClasseBase.Text = "Executa exemplo classe Base"
        Btm_Aumento.Text = "Aumento Salarial"
    End Sub

    Private Sub Btm_Click_Click(sender As Object, e As EventArgs) Handles Btm_Click.Click
        Dim gerenciadorBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Gerente("543.445.434-00", 10000)
        Carlos.Nome = "Carlos Antônio"

        gerenciadorBonificacao.Registrar(Carlos)

        Dim Bia As New Diretor("522.476.980-12", 20000)
        Bia.Nome = "Beatriz Regina"

        gerenciadorBonificacao.Registrar(Bia)

        MsgBox("O salário do " + Carlos.Nome + " é " + Carlos.Salario.ToString)
        MsgBox("A bonificação do " + Carlos.Nome + " será de " + Carlos.GetBonificacao.ToString)

        MsgBox("O salário da " + Bia.Nome + " é " + Bia.Salario.ToString)
        MsgBox("A bonificação da " + Bia.Nome + " será de " + Bia.GetBonificacao.ToString)

        Dim totalBonificacao As Double
        totalBonificacao += Carlos.GetBonificacao
        totalBonificacao += Bia.GetBonificacao
        MsgBox("O valor total de bonificação a ser pago será de " + totalBonificacao.ToString + " o valor calculado pela biblioteca foi de " _
              + gerenciadorBonificacao.GetBonificacao.ToString)
    End Sub

    Private Sub Btm_TesteHerenca_Click(sender As Object, e As EventArgs) Handles Btm_TesteHerenca.Click
        'Dim vFuncionario As New Funcionario("111.111.111-04", 10000)

        'Dim vDiretorFuncionario As New Funcionario("111.112.111-04", 10000)

        'MsgBox("O número de funcionários atualmente instanciados são de " + Funcionario.TotalDeFuncionarios().ToString)

        'Dim vDiretor As New Diretor("111.116.111-04", 10000)

        'MsgBox("O número de funcionários e diretores atualmente instanciados são de " + Funcionario.TotalDeFuncionarios().ToString)

        'Dim vGerente As New Gerente("111.116.118-04", 10000)

        'MsgBox("O número de funcionários, diretores e gerentes atualmente instanciados são de " + Funcionario.TotalDeFuncionarios().ToString)

        'Dim vTexto As String
        'vTexto = "O CPF dos funcionários são " + vFuncionario.Cpf + " E " + vDiretorFuncionario.Cpf + vbCrLf
        'vTexto = "O CPF do diretor é " + vDiretor.Cpf + " E " + vbCrLf
        'vTexto = "O CPF do gerente é " + vGerente.Cpf + " E " + vbCrLf

        'MsgBox(vTexto)

        'vDiretorFuncionario = vDiretor

        'Dim vSaida As String = ""
        'vSaida = "A bonificação de VDiretor é " + vDiretor.GetBonificacao().ToString + vbCrLf
        'vSaida = "A bonificação de VFuncionario é " + vFuncionario.GetBonificacao().ToString + vbCrLf
        'vSaida = "A bonificação de VDiretorFuncionario é " + vDiretorFuncionario.GetBonificacao().ToString + vbCrLf

        'MsgBox(vSaida)
    End Sub

    Private Sub Btm_ClasseBase_Click(sender As Object, e As EventArgs) Handles Btm_ClasseBase.Click
        Dim vDiretor As New Diretor("123.456.444-04", 10000)

        MsgBox("A bonificação do diretor é: " + vDiretor.GetBonificacao().ToString)
    End Sub

    Private Sub Btm_Aumento_Click(sender As Object, e As EventArgs) Handles Btm_Aumento.Click
        'Dim vFuncionario As New Funcionario("123.123.123-56", 1000)
        'Dim vDiretor As New Diretor("123.123.444-56", 3000)
        'Dim vGerente As New Gerente("123.444.123-56", 2000)

        'Dim vTexto As String = ""
        'vTexto = "O salário do funcionário é: " + vFuncionario.Salario.ToString() + vbCrLf
        'vTexto = "O salário do gerente é: " + vGerente.Salario.ToString() + vbCrLf
        'vTexto = "O salário do diretor é: " + vDiretor.Salario.ToString() + vbCrLf

        'MsgBox(vTexto)

        'vFuncionario.AumentarSalario()
        'vGerente.AumentarSalario()
        'vDiretor.AumentarSalario()

        'vTexto = "O salário do funcionário é: " + vFuncionario.Salario.ToString() + vbCrLf
        'vTexto = "O salário do gerente é: " + vGerente.Salario.ToString() + vbCrLf
        'vTexto = "O salário do diretor é: " + vDiretor.Salario.ToString() + vbCrLf
        'MsgBox(vTexto)
    End Sub
End Class