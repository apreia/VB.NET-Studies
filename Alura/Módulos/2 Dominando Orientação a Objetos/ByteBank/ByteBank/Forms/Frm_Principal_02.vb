Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal_02
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Cálculo Bonificação"
        Lbl_Principal.Text = "Cálculo Bonificação"
        Btm_Bonificacao.Text = "Cálculo da bonificação"
    End Sub

    Private Sub Btm_Bonificacao_Click(sender As Object, e As EventArgs) Handles Btm_Bonificacao.Click
        Dim TotalBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Diretor("123.123.123-05", 5000)
        Dim Pedro As New Designer("123.123.444-05", 3000)
        Dim Joao As New Gerente("123.999.123-05", 4000)
        Dim Carla As New Auxiliar("999.123.123-05", 2000)
        Dim Julia As New Desenvolvedor("999.333.123-05", 2000)

        TotalBonificacao.Registrar(Carlos)
        TotalBonificacao.Registrar(Pedro)
        TotalBonificacao.Registrar(Joao)
        TotalBonificacao.Registrar(Carla)
        TotalBonificacao.Registrar(Julia)

        MsgBox("O valor total da bonificação será de " + TotalBonificacao.GetBonificacao().ToString)
    End Sub
End Class