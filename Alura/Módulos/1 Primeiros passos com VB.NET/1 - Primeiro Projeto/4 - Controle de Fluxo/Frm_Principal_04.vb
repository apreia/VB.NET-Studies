Public Class Frm_Principal_04
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Lbl_NomeProjeto.Text = "4 - Controle de Fluxo"
        Btm_Principal.Text = "Checagem da permissão de entrada"
        Text = "Aplicação Controle de Fluxo!"

        'Inicialização dos componentes da aplicação
        Lbl_Idade.Text = "Idade"
        Lbl_Resultado.Text = "Resultado"
        Grp_Pais.Text = "Acompanhado do pais?"
        Rdb_Sim.Text = "SIM"
        Rdb_Nao.Text = "NÃO"
    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Txt_Resultado.Text = ""

        Dim idade As SByte
        idade = Txt_Idade.Text

        Dim AcompanhadoPais As String
        If Rdb_Sim.Checked Then
            AcompanhadoPais = "S"
        Else
            AcompanhadoPais = "N"
        End If

        Dim PodeEntrar As Boolean = (idade >= 18) Or (AcompanhadoPais = "S" And idade >= 16)
        Dim NaoPodeEntrar As Boolean = (AcompanhadoPais = "N" And idade >= 16) Or (idade < 16)

        Dim MensagemAdicional As String
        If AcompanhadoPais = "S" Then
            MensagemAdicional = "ESTÁ ACOMPANHADO."
        Else
            MensagemAdicional = "NÃO ESTÁ ACOMPANHADO."
        End If

        If PodeEntrar Then
            Txt_Resultado.ForeColor = Color.Green
            Txt_Resultado.Text = "PODE ENTRAR. " + MensagemAdicional
        Else

            If NaoPodeEntrar Then
                Txt_Resultado.ForeColor = Color.Red
                Txt_Resultado.Text = "NÃO PODE ENTRAR. " + MensagemAdicional
            End If
        End If
    End Sub
End Class