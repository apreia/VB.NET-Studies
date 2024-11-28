<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal_04
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
        Lbl_Idade = New Label()
        Txt_Idade = New TextBox()
        Txt_Resultado = New TextBox()
        Lbl_Resultado = New Label()
        Grp_Pais = New GroupBox()
        Rdb_Nao = New RadioButton()
        Rdb_Sim = New RadioButton()
        Grp_Pais.SuspendLayout()
        SuspendLayout()
        ' 
        ' Btm_Principal
        ' 
        Btm_Principal.Location = New Point(13, 115)
        Btm_Principal.Name = "Btm_Principal"
        Btm_Principal.Size = New Size(316, 35)
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
        ' Lbl_Idade
        ' 
        Lbl_Idade.AutoSize = True
        Lbl_Idade.Location = New Point(13, 68)
        Lbl_Idade.Name = "Lbl_Idade"
        Lbl_Idade.Size = New Size(41, 15)
        Lbl_Idade.TabIndex = 2
        Lbl_Idade.Text = "Label1"
        ' 
        ' Txt_Idade
        ' 
        Txt_Idade.Location = New Point(13, 86)
        Txt_Idade.Name = "Txt_Idade"
        Txt_Idade.Size = New Size(100, 23)
        Txt_Idade.TabIndex = 3
        ' 
        ' Txt_Resultado
        ' 
        Txt_Resultado.Location = New Point(13, 179)
        Txt_Resultado.Name = "Txt_Resultado"
        Txt_Resultado.Size = New Size(316, 23)
        Txt_Resultado.TabIndex = 4
        ' 
        ' Lbl_Resultado
        ' 
        Lbl_Resultado.AutoSize = True
        Lbl_Resultado.Location = New Point(13, 161)
        Lbl_Resultado.Name = "Lbl_Resultado"
        Lbl_Resultado.Size = New Size(41, 15)
        Lbl_Resultado.TabIndex = 5
        Lbl_Resultado.Text = "Label1"
        ' 
        ' Grp_Pais
        ' 
        Grp_Pais.Controls.Add(Rdb_Nao)
        Grp_Pais.Controls.Add(Rdb_Sim)
        Grp_Pais.Location = New Point(119, 27)
        Grp_Pais.Name = "Grp_Pais"
        Grp_Pais.Size = New Size(210, 82)
        Grp_Pais.TabIndex = 6
        Grp_Pais.TabStop = False
        Grp_Pais.Text = "GroupBox1"
        ' 
        ' Rdb_Nao
        ' 
        Rdb_Nao.AutoSize = True
        Rdb_Nao.Location = New Point(109, 37)
        Rdb_Nao.Name = "Rdb_Nao"
        Rdb_Nao.Size = New Size(97, 19)
        Rdb_Nao.TabIndex = 8
        Rdb_Nao.TabStop = True
        Rdb_Nao.Text = "RadioButton1"
        Rdb_Nao.UseVisualStyleBackColor = True
        ' 
        ' Rdb_Sim
        ' 
        Rdb_Sim.AutoSize = True
        Rdb_Sim.Location = New Point(6, 37)
        Rdb_Sim.Name = "Rdb_Sim"
        Rdb_Sim.Size = New Size(97, 19)
        Rdb_Sim.TabIndex = 7
        Rdb_Sim.TabStop = True
        Rdb_Sim.Text = "RadioButton1"
        Rdb_Sim.UseVisualStyleBackColor = True
        ' 
        ' Frm_Principal_04
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(617, 416)
        Controls.Add(Grp_Pais)
        Controls.Add(Lbl_Resultado)
        Controls.Add(Txt_Resultado)
        Controls.Add(Txt_Idade)
        Controls.Add(Lbl_Idade)
        Controls.Add(Lbl_NomeProjeto)
        Controls.Add(Btm_Principal)
        Name = "Frm_Principal_04"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplicação Olá Mundo!"
        Grp_Pais.ResumeLayout(False)
        Grp_Pais.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Lbl_Idade As Label
    Friend WithEvents Txt_Idade As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Grp_Pais As GroupBox
    Friend WithEvents Rdb_Sim As RadioButton
    Friend WithEvents Rdb_Nao As RadioButton

End Class
