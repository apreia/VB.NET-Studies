Public Class ExemploInterface
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Exemplo Interface"
        Lbl_Principal.Text = "Exemplo Interface"
        Btm_ExemploInterface.Text = "Clique Aqui"
    End Sub

    Private Sub Btm_ExemploInterface_Click(sender As Object, e As EventArgs) Handles Btm_ExemploInterface.Click
        Dim vX As New Imovel

        MsgBox(vX.AbrirPorta(New Casa))
        MsgBox(vX.AbrirPorta(New Predio))
        MsgBox(vX.AbrirPorta(New Sobrado))
    End Sub
End Class