Imports ByteBank.Bibliotecas.Classes

Public Class Frm_PaginaWeb
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Página Web"
        Lbl_URL.Text = "URL"
        Btm_URL.Text = "GO"
        Grp_URL.Text = ""
        Grp_WebBrowser.Text = ""
        Btm_Propriedade.Text = "Prop"
    End Sub

    Private Sub Frm_PaginaWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Wb_Pagina.Source = New Uri("about:blank") ' Página em branco inicial
    End Sub

    Private Sub Btm_URL_Click(sender As Object, e As EventArgs) Handles Btm_URL.Click
        Dim URL As String = Txt_URL.Text

        If URL = "" Then
            MsgBox("Favor digitar uma URL.", MsgBoxStyle.Critical, "URL")
        Else
            ' Verifica se o WebView2 está inicializado
            If Wb_Pagina.CoreWebView2 IsNot Nothing Then
                ' Adiciona o protocolo "https://" caso o usuário não tenha fornecido
                If Not URL.StartsWith("http://") AndAlso Not URL.StartsWith("https://") Then
                    URL = "https://" & URL
                End If

                ' Navega até a URL
                Wb_Pagina.CoreWebView2.Navigate(URL)
            Else
                MsgBox("O WebView2 ainda não foi inicializado.", MsgBoxStyle.Exclamation, "Erro")
            End If
        End If
    End Sub

    Private Sub Btm_Propriedade_Click(sender As Object, e As EventArgs) Handles Btm_Propriedade.Click
        Dim URL As String = Txt_URL.Text

        If URL = "" Then
            MsgBox("Favor digitar uma URL.", MsgBoxStyle.Critical, "URL")
        Else
            URL = Wb_Pagina.Source.ToString()
            Txt_URL.Text = URL

            Dim paginaURL As New ExtrairValorDeArgumentoUrl(URL)
            Dim propriedadesURL As String = paginaURL.GetTodosArgumentos
            MsgBox(propriedadesURL, MsgBoxStyle.Information, "URL")
        End If
    End Sub
End Class