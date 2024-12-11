Imports ByteBank.Bibliotecas.Classes

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Formulário Principal"
        Lbl_Principal.Text = "Formulário Principal"
        Btm_Principal.Text = "Clique Aqui (InStr)"
        Lbl_URL.Text = "URL"
        Lbl_Separador.Text = "Separador"
        Btm_Principal2.Text = "Clique Aqui (IndexOf)"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Try
            ExecutaTesteURL()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ExecutaTesteURL()
        Dim url As String = Txt_URL.Text
        url = Nothing
        Dim X As New ExtrairValorDeArgumentoUrl(url)

        Dim Resposta As Boolean = String.IsNullOrEmpty(url)
        MsgBox(Resposta)

        Dim separador As String = Txt_Sepador.Text

        If separador = "" Then
            Throw New Exception("Separador vazio")
        End If

        Dim posicaoInterrogacao As Integer
        posicaoInterrogacao = InStr(X.Url, separador)

        If posicaoInterrogacao = 0 Then
            Throw New Exception("Posição vazia")
        End If

        url = url.Substring(posicaoInterrogacao)
        MsgBox(url)
    End Sub

    Private Sub Btm_Principal2_Click(sender As Object, e As EventArgs) Handles Btm_Principal2.Click
        Try
            ExecutaTesteURL2()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ExecutaTesteURL2()
        Dim url As String = Txt_URL.Text

        If url = "" Then
            Throw New Exception("URL vazia")
        End If

        Dim separador As String = Txt_Sepador.Text

        If separador = "" Then
            Throw New Exception("Separador vazio")
        End If

        Dim posicaoInterrogacao As Integer
        posicaoInterrogacao = url.IndexOf(separador)

        If posicaoInterrogacao = -1 Then
            Throw New Exception("Posição vazia")
        End If

        url = url.Substring(posicaoInterrogacao + 1)
        MsgBox(url)
    End Sub
End Class