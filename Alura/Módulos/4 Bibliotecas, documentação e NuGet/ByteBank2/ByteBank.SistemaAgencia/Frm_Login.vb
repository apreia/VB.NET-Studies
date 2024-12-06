Imports ByteBank.Bibliotecas
Imports ByteBank.Bibliotecas.Classes.Bibliotecas
Imports ByteBank.Bibliotecas.Classes.Externos
Imports ByteBank.Bibliotecas.Classes.Funcionarios

Public Class Frm_Login
    Dim vNomeRepresentante As String = "Representante X"
    Dim vNomeGerente As String = "Gerente Y"

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "login Sistema Interno"
        Grp_Login.Text = "Login"
        Lbl_Login.Text = "Login"
        Lbl_Senha.Text = "Senha"
        Rb_Gerente.Text = "Gerente"
        Rb_Representante.Text = "Representante"
        Btm_Logar.Text = "Logar"

        Rb_Gerente.Checked = True
        Rb_Representante.Checked = False

        Txt_Login.ReadOnly = True

    End Sub

    Private Sub Rb_Gerente_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Gerente.CheckedChanged
        If Rb_Gerente.Checked Then
            Txt_Login.Text = vNomeGerente
        End If
    End Sub

    Private Sub Rb_Representante_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Representante.CheckedChanged
        If Rb_Representante.Checked Then
            Txt_Login.Text = vNomeRepresentante
        End If
    End Sub

    Private Sub Btm_Logar_Click(sender As Object, e As EventArgs) Handles Btm_Logar.Click
        Dim Representante As New Representante
        Representante.Senha = "rrr"

        Dim Gerente As New Gerente(11111111)
        Gerente.Senha = "ggg"

        'Dim X As New ModificadoresTeste
        'X.MetodoPublico()
        'X.MetodoPrivado()
        'X.MetodoProtedigo()
        'X.MetodoInterno()

        Dim vRetorno As Boolean = False
        If Rb_Gerente.Checked Then
            vRetorno = Gerente.Autenticar(Txt_Senha.Text)
        Else
            vRetorno = Representante.Autenticar(Txt_Senha.Text)
        End If

        If vRetorno = True Then
            MsgBox("Usuário efetuou o login no sistema interno", MsgBoxStyle.Information)
        Else
            MsgBox("Usuário não tem autorização a entrar no sistema interno", MsgBoxStyle.Critical)
        End If
    End Sub
End Class