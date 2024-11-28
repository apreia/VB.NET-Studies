<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_02
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
        Lbl_Principal = New Label()
        Btm_Bonificacao = New Button()
        SuspendLayout()
        ' 
        ' Lbl_Principal
        ' 
        Lbl_Principal.AutoSize = True
        Lbl_Principal.Location = New Point(12, 9)
        Lbl_Principal.Name = "Lbl_Principal"
        Lbl_Principal.Size = New Size(41, 15)
        Lbl_Principal.TabIndex = 0
        Lbl_Principal.Text = "Label1"
        ' 
        ' Btm_Bonificacao
        ' 
        Btm_Bonificacao.Location = New Point(12, 51)
        Btm_Bonificacao.Name = "Btm_Bonificacao"
        Btm_Bonificacao.Size = New Size(172, 61)
        Btm_Bonificacao.TabIndex = 1
        Btm_Bonificacao.Text = "Button1"
        Btm_Bonificacao.UseVisualStyleBackColor = True
        ' 
        ' Frm_Principal_02
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btm_Bonificacao)
        Controls.Add(Lbl_Principal)
        Name = "Frm_Principal_02"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Frm_Principal_02"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Bonificacao As Button
End Class
