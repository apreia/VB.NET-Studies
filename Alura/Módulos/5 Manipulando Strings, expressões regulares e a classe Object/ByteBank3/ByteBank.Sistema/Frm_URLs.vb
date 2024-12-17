Public Class Frm_URLs
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Gerenciador de Páginas WEB"
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim F As New Frm_PaginaWeb
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascataToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class