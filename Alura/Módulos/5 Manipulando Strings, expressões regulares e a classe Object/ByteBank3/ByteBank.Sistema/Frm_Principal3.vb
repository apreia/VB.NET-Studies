Imports System.Text.RegularExpressions
Imports ByteBank.Bibliotecas.Classes
Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.Bibliotecas.Classes.Funcionarios

Public Class Frm_Principal3
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Formulário Principal 3"
        Lbl_Principal3.Text = "Formulário Principal 3"
        Btm_Principal3.Text = "Clique Aqui"
        Btm_Principal03a.Text = "Clique Aqui"
        Btm_Principal03b.Text = "Clique Aqui"

    End Sub

    Private Sub Btm_Principal3_Click(sender As Object, e As EventArgs) Handles Btm_Principal3.Click
        Dim vFrase As String = "O telefone é 23344332"
        'Dim vExpressaoRegular As String = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
        'Dim vExpressaoRegular As String = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"
        'Dim vExpressaoRegular As String = "[0-9]{5}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-]?[0-9]{4}"
        Dim vExpressaoRegular As String = "[0-9]{4,5}-?[0-9]{4}"

        Dim X As Boolean = Regex.IsMatch(vFrase, vExpressaoRegular)
        MsgBox(X)

        Dim Y As Match = Regex.Match(vFrase, vExpressaoRegular)
        MsgBox(Y.Value)
    End Sub

    Private Sub Btm_Principal03a_Click(sender As Object, e As EventArgs) Handles Btm_Principal03a.Click
        'Dim X As String = "aaaaaa"
        'Dim Y As Integer = 23
        'Dim Z As Boolean = True

        'Dim W As Object

        'MsgBox(X.ToString)
        'MsgBox(Y.ToString)
        'MsgBox(Z.ToString)

        'Dim Conta As New ContaCorrente(2222, 23232323)
        'MsgBox(Conta.ToString)

        Dim Cliente_1 As New Cliente
        Dim Cliente_2 As New Cliente

        Cliente_1.nome = "Carlos"
        Cliente_1.cpf = "123.123.123-23"
        Cliente_1.profissao = "Analista de Sistemas"

        Cliente_2.nome = "Carlos"
        Cliente_2.cpf = "123.123.123-23"
        Cliente_2.profissao = "Analista de Sistemas"

        Dim Ger As New Gerente("123.123.123-23")
        Dim KK = "aaaaaaaaaaaaaaaaaaaa"

        If Cliente_1.Equals(Cliente_2) Then
            MsgBox("SÃO IGUAIS !!!!")
        Else
            MsgBox("NÃO SÃO IGUAIS !!!!")
        End If
    End Sub

    Sub Teste(F As Funcionario)

    End Sub

    Private Sub Btm_Principal03b_Click(sender As Object, e As EventArgs) Handles Btm_Principal03b.Click
        Dim url As String = "https://www.bytebank.com.br/cambio"
        Dim X As New ExtrairValorDeArgumentoUrl(url)
        Dim Y As String = X.GetTodosArgumentos

        MsgBox(Y)
    End Sub
End Class