<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_01
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Btm_Principal = New Button()
        Lbl_NomeProjeto = New Label()
        SuspendLayout()
        ' 
        ' Btm_Principal
        ' 
        Btm_Principal.Location = New Point(199, 153)
        Btm_Principal.Name = "Btm_Principal"
        Btm_Principal.Size = New Size(173, 94)
        Btm_Principal.TabIndex = 0
        Btm_Principal.Text = "CLIQUE AQUI"
        Btm_Principal.UseVisualStyleBackColor = True
        ' 
        ' Lbl_NomeProjeto
        ' 
        Lbl_NomeProjeto.AutoSize = True
        Lbl_NomeProjeto.Location = New Point(12, 9)
        Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Lbl_NomeProjeto.Size = New Size(110, 15)
        Lbl_NomeProjeto.TabIndex = 1
        Lbl_NomeProjeto.Text = "1 - Primeiro Projeto"
        ' 
        ' Frm_TelaPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 416)
        Controls.Add(Lbl_NomeProjeto)
        Controls.Add(Btm_Principal)
        Name = "Frm_TelaPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplicação Olá Mundo!"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label

End Class