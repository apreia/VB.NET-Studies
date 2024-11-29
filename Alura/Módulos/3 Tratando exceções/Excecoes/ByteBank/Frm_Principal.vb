Imports ByteBank.Classes

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Projeto ByteBank"
        Lbl_Principal.Text = "Projeto ByteBank"

    End Sub

    Private Sub Vídeo01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo01ToolStripMenuItem.Click
        Dim conta As New ContaCorrente(237, 117333)
        MsgBox("O número de contas correntes criadas são de " + ContaCorrente.TotalDeContasCriadas.ToString)
        MsgBox("O valor das taxas de operações está em " + ContaCorrente.TaxaOperacao.ToString)
    End Sub

    Private Sub Vídeo02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo02ToolStripMenuItem.Click
        TestarDivisao(2)
    End Sub

    Sub TestarDivisao(valor As Integer)
        Dim Resultado As Integer = efetuardivisao(10, valor)
        MsgBox("O valor da divisão entre 10 e" + valor.ToString = " é de " + Resultado.ToString)
    End Sub

    Function efetuardivisao(Numerador As Integer, Denominador As Integer) As Integer
        Return Numerador / Denominador
    End Function
End Class