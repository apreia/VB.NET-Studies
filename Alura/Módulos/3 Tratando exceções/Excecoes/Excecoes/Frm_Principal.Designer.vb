<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Lbl_Principal = New Label()
        Mnu_Principal = New MenuStrip()
        ArquivoToolStripMenuItem = New ToolStripMenuItem()
        NovoToolStripMenuItem = New ToolStripMenuItem()
        AbrirToolStripMenuItem = New ToolStripMenuItem()
        ArquivoTextoToolStripMenuItem = New ToolStripMenuItem()
        PlanilhaToolStripMenuItem = New ToolStripMenuItem()
        SalvarToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem1 = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        BuscarToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        RecortarToolStripMenuItem = New ToolStripMenuItem()
        ColarToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        OnLineToolStripMenuItem = New ToolStripMenuItem()
        SobreToolStripMenuItem = New ToolStripMenuItem()
        Mnu_Principal.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lbl_Principal
        ' 
        Lbl_Principal.AutoSize = True
        Lbl_Principal.Location = New Point(12, 39)
        Lbl_Principal.Name = "Lbl_Principal"
        Lbl_Principal.Size = New Size(41, 15)
        Lbl_Principal.TabIndex = 0
        Lbl_Principal.Text = "Label1"
        ' 
        ' Mnu_Principal
        ' 
        Mnu_Principal.Items.AddRange(New ToolStripItem() {ArquivoToolStripMenuItem, EditarToolStripMenuItem, SairToolStripMenuItem})
        Mnu_Principal.Location = New Point(0, 0)
        Mnu_Principal.Name = "Mnu_Principal"
        Mnu_Principal.Size = New Size(532, 24)
        Mnu_Principal.TabIndex = 1
        Mnu_Principal.Text = "MenuStrip1"
        ' 
        ' ArquivoToolStripMenuItem
        ' 
        ArquivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NovoToolStripMenuItem, AbrirToolStripMenuItem, SalvarToolStripMenuItem, SairToolStripMenuItem1})
        ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        ArquivoToolStripMenuItem.Size = New Size(61, 20)
        ArquivoToolStripMenuItem.Text = "Arquivo"
        ' 
        ' NovoToolStripMenuItem
        ' 
        NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        NovoToolStripMenuItem.Size = New Size(180, 22)
        NovoToolStripMenuItem.Text = "Novo"
        ' 
        ' AbrirToolStripMenuItem
        ' 
        AbrirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ArquivoTextoToolStripMenuItem, PlanilhaToolStripMenuItem})
        AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        AbrirToolStripMenuItem.Size = New Size(180, 22)
        AbrirToolStripMenuItem.Text = "Abrir"
        ' 
        ' ArquivoTextoToolStripMenuItem
        ' 
        ArquivoTextoToolStripMenuItem.Name = "ArquivoTextoToolStripMenuItem"
        ArquivoTextoToolStripMenuItem.Size = New Size(180, 22)
        ArquivoTextoToolStripMenuItem.Text = "Arquivo Texto"
        ' 
        ' PlanilhaToolStripMenuItem
        ' 
        PlanilhaToolStripMenuItem.Name = "PlanilhaToolStripMenuItem"
        PlanilhaToolStripMenuItem.Size = New Size(180, 22)
        PlanilhaToolStripMenuItem.Text = "Planilha"
        ' 
        ' SalvarToolStripMenuItem
        ' 
        SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        SalvarToolStripMenuItem.Size = New Size(180, 22)
        SalvarToolStripMenuItem.Text = "Salvar"
        ' 
        ' SairToolStripMenuItem1
        ' 
        SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        SairToolStripMenuItem1.Size = New Size(180, 22)
        SairToolStripMenuItem1.Text = "Sair"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BuscarToolStripMenuItem, CopiarToolStripMenuItem, RecortarToolStripMenuItem, ColarToolStripMenuItem})
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(49, 20)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' BuscarToolStripMenuItem
        ' 
        BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        BuscarToolStripMenuItem.Size = New Size(180, 22)
        BuscarToolStripMenuItem.Text = "Buscar"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), Image)
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopiarToolStripMenuItem.Size = New Size(180, 22)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' RecortarToolStripMenuItem
        ' 
        RecortarToolStripMenuItem.Name = "RecortarToolStripMenuItem"
        RecortarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        RecortarToolStripMenuItem.Size = New Size(180, 22)
        RecortarToolStripMenuItem.Text = "Recortar"
        ' 
        ' ColarToolStripMenuItem
        ' 
        ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        ColarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        ColarToolStripMenuItem.Size = New Size(180, 22)
        ColarToolStripMenuItem.Text = "Colar"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OnLineToolStripMenuItem, SobreToolStripMenuItem})
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(50, 20)
        SairToolStripMenuItem.Text = "Ajuda"
        ' 
        ' OnLineToolStripMenuItem
        ' 
        OnLineToolStripMenuItem.Name = "OnLineToolStripMenuItem"
        OnLineToolStripMenuItem.Size = New Size(112, 22)
        OnLineToolStripMenuItem.Text = "OnLine"
        ' 
        ' SobreToolStripMenuItem
        ' 
        SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        SobreToolStripMenuItem.Size = New Size(112, 22)
        SobreToolStripMenuItem.Text = "Sobre"
        ' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(532, 392)
        Controls.Add(Lbl_Principal)
        Controls.Add(Mnu_Principal)
        MainMenuStrip = Mnu_Principal
        Name = "Frm_Principal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Mnu_Principal.ResumeLayout(False)
        Mnu_Principal.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Mnu_Principal As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArquivoTextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanilhaToolStripMenuItem As ToolStripMenuItem

End Class
