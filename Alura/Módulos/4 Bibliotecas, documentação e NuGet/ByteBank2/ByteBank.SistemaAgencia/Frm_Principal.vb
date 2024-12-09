Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Text = "Sistema de Agências ByteBank"

    End Sub

    Private Sub Vídeo01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo01ToolStripMenuItem.Click
        Dim F As New Frm_Secundario
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub JanelasHorizontaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelasHorizontaisToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub JanelasVerticaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelasVerticaisToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub JanelasCascatasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelasCascatasToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub Vídeo02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo02ToolStripMenuItem.Click
        Dim F As New Frm_Login
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub Vídeo03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo03ToolStripMenuItem.Click
        Dim F As New Frm_CartaoCredito
        F.MdiParent = Me
        F.Show()
    End Sub
End Class