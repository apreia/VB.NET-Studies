<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_URLs
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ArquivoToolStripMenuItem = New ToolStripMenuItem()
        NovoToolStripMenuItem = New ToolStripMenuItem()
        JanelasToolStripMenuItem = New ToolStripMenuItem()
        HorizontalToolStripMenuItem = New ToolStripMenuItem()
        VerticalToolStripMenuItem = New ToolStripMenuItem()
        CascataToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArquivoToolStripMenuItem, JanelasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(571, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArquivoToolStripMenuItem
        ' 
        ArquivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NovoToolStripMenuItem})
        ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        ArquivoToolStripMenuItem.Size = New Size(61, 20)
        ArquivoToolStripMenuItem.Text = "Arquivo"
        ' 
        ' NovoToolStripMenuItem
        ' 
        NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        NovoToolStripMenuItem.Size = New Size(103, 22)
        NovoToolStripMenuItem.Text = "Novo"
        ' 
        ' JanelasToolStripMenuItem
        ' 
        JanelasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HorizontalToolStripMenuItem, VerticalToolStripMenuItem, CascataToolStripMenuItem})
        JanelasToolStripMenuItem.Name = "JanelasToolStripMenuItem"
        JanelasToolStripMenuItem.Size = New Size(56, 20)
        JanelasToolStripMenuItem.Text = "Janelas"
        ' 
        ' HorizontalToolStripMenuItem
        ' 
        HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        HorizontalToolStripMenuItem.Size = New Size(180, 22)
        HorizontalToolStripMenuItem.Text = "Horizontal"
        ' 
        ' VerticalToolStripMenuItem
        ' 
        VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        VerticalToolStripMenuItem.Size = New Size(180, 22)
        VerticalToolStripMenuItem.Text = "Vertical"
        ' 
        ' CascataToolStripMenuItem
        ' 
        CascataToolStripMenuItem.Name = "CascataToolStripMenuItem"
        CascataToolStripMenuItem.Size = New Size(180, 22)
        CascataToolStripMenuItem.Text = "Cascata"
        ' 
        ' Frm_URLs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(571, 386)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Frm_URLs"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Frm_URLs"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascataToolStripMenuItem As ToolStripMenuItem
End Class
