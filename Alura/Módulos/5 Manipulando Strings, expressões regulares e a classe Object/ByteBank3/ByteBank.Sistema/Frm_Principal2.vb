Imports ByteBank.Bibliotecas.Classes
Public Class Frm_Principal2
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Formulário Principal 2"
        Lbl_Principal2.Text = "Formulário Principal 2"
        Lbl_URL.Text = "URL"
        Lbl_Argumento.Text = "Argumento"
        Txt_Argumento.ReadOnly = True
        Btn_Processa.Text = "Processa"
        Lbl_Propriedade.Text = "Propriedade"

        ' Inicializando os textbox
        Txt_URL.Text = "https://www.bytebank.com.br/cambio?moedaOrigem=dolar&moedaDestino=real&valor=1500"
        Txt_Propriedade.Text = "moedaDestino"

    End Sub

    Private Sub Btn_Processa_Click(sender As Object, e As EventArgs) Handles Btn_Processa.Click
        Dim vUrl As New ExtrairValorDeArgumentoUrl(Txt_URL.Text)

        If Not vUrl.IsByteBank Then
            MsgBox("URL não é do domínio do banco ByteBank")
        Else
            Txt_Argumento.Text = vUrl.Argumento

            Dim vPropriedade As String = Txt_Propriedade.Text

            MsgBox(vUrl.GetValor(vPropriedade))
        End If
    End Sub
End Class