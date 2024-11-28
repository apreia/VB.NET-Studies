<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_03
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
        Txt_Numero_Char = New TextBox()
        Btm_Char = New Button()
        Lbl_Curso = New Label()
        Txt_Curso = New TextBox()
        Btm_Adicionar = New Button()
        Txt_Lista = New TextBox()
        Btm_MostraLista = New Button()
        Btm_GuardarVariaveis = New Button()
        SuspendLayout()
        ' 
        ' Btm_Principal
        ' 
        Btm_Principal.Location = New Point(12, 39)
        Btm_Principal.Name = "Btm_Principal"
        Btm_Principal.Size = New Size(191, 78)
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
        ' Txt_Numero_Char
        ' 
        Txt_Numero_Char.Location = New Point(263, 65)
        Txt_Numero_Char.Name = "Txt_Numero_Char"
        Txt_Numero_Char.Size = New Size(157, 23)
        Txt_Numero_Char.TabIndex = 2
        ' 
        ' Btm_Char
        ' 
        Btm_Char.Location = New Point(263, 94)
        Btm_Char.Name = "Btm_Char"
        Btm_Char.Size = New Size(157, 23)
        Btm_Char.TabIndex = 3
        Btm_Char.Text = "Button1"
        Btm_Char.UseVisualStyleBackColor = True
        ' 
        ' Lbl_Curso
        ' 
        Lbl_Curso.AutoSize = True
        Lbl_Curso.Location = New Point(12, 179)
        Lbl_Curso.Name = "Lbl_Curso"
        Lbl_Curso.Size = New Size(41, 15)
        Lbl_Curso.TabIndex = 4
        Lbl_Curso.Text = "Label1"
        ' 
        ' Txt_Curso
        ' 
        Txt_Curso.Location = New Point(12, 197)
        Txt_Curso.Name = "Txt_Curso"
        Txt_Curso.Size = New Size(217, 23)
        Txt_Curso.TabIndex = 5
        ' 
        ' Btm_Adicionar
        ' 
        Btm_Adicionar.Location = New Point(235, 197)
        Btm_Adicionar.Name = "Btm_Adicionar"
        Btm_Adicionar.Size = New Size(217, 23)
        Btm_Adicionar.TabIndex = 6
        Btm_Adicionar.Text = "Button1"
        Btm_Adicionar.UseVisualStyleBackColor = True
        ' 
        ' Txt_Lista
        ' 
        Txt_Lista.Location = New Point(12, 226)
        Txt_Lista.Multiline = True
        Txt_Lista.Name = "Txt_Lista"
        Txt_Lista.ScrollBars = ScrollBars.Vertical
        Txt_Lista.Size = New Size(191, 178)
        Txt_Lista.TabIndex = 7
        ' 
        ' Btm_MostraLista
        ' 
        Btm_MostraLista.Location = New Point(235, 226)
        Btm_MostraLista.Name = "Btm_MostraLista"
        Btm_MostraLista.Size = New Size(217, 23)
        Btm_MostraLista.TabIndex = 8
        Btm_MostraLista.Text = "Button1"
        Btm_MostraLista.UseVisualStyleBackColor = True
        ' 
        ' Btm_GuardarVariaveis
        ' 
        Btm_GuardarVariaveis.Location = New Point(235, 255)
        Btm_GuardarVariaveis.Name = "Btm_GuardarVariaveis"
        Btm_GuardarVariaveis.Size = New Size(217, 23)
        Btm_GuardarVariaveis.TabIndex = 9
        Btm_GuardarVariaveis.Text = "Button1"
        Btm_GuardarVariaveis.UseVisualStyleBackColor = True
        ' 
        ' Frm_TelaPrincipal_03
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 416)
        Controls.Add(Btm_GuardarVariaveis)
        Controls.Add(Btm_MostraLista)
        Controls.Add(Txt_Lista)
        Controls.Add(Btm_Adicionar)
        Controls.Add(Txt_Curso)
        Controls.Add(Lbl_Curso)
        Controls.Add(Btm_Char)
        Controls.Add(Txt_Numero_Char)
        Controls.Add(Lbl_NomeProjeto)
        Controls.Add(Btm_Principal)
        Name = "Frm_TelaPrincipal_03"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplicação Olá Mundo!"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Txt_Numero_Char As TextBox
    Friend WithEvents Btm_Char As Button
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btm_Adicionar As Button
    Friend WithEvents Txt_Lista As TextBox
    Friend WithEvents Btm_MostraLista As Button
    Friend WithEvents Btm_GuardarVariaveis As Button

End Class