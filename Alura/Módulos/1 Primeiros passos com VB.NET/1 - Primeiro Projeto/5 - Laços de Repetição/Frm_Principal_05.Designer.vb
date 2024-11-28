<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal_05
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
        Btm_While = New Button()
        Lbl_NomeProjeto = New Label()
        Lbl_Principal = New Label()
        Lbl_Rendimento = New Label()
        Txt_Principal = New TextBox()
        Txt_Rendimento = New TextBox()
        Lbl_Periodos = New Label()
        Txt_Periodos = New TextBox()
        Txt_Extrato_While = New TextBox()
        Btm_For = New Button()
        Txt_Extrato_For = New TextBox()
        Grp_Grupo1 = New GroupBox()
        Grp_Grupo2 = New GroupBox()
        Txt_Limite = New TextBox()
        Lbl_Limite = New Label()
        Txt_Resultado = New TextBox()
        Btm_Calcula = New Button()
        Txt_Anos = New TextBox()
        Txt_AcrescimoRendimento = New TextBox()
        Txt_Rendimento2 = New TextBox()
        Txt_Principal2 = New TextBox()
        Lbl_Anos = New Label()
        Lbl_Rendimento2 = New Label()
        Lbl_AcrescimoRendimento = New Label()
        Lbl_Principal2 = New Label()
        Grp_Grupo1.SuspendLayout()
        Grp_Grupo2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Btm_While
        ' 
        Btm_While.Location = New Point(6, 86)
        Btm_While.Name = "Btm_While"
        Btm_While.Size = New Size(239, 37)
        Btm_While.TabIndex = 0
        Btm_While.Text = "CLIQUE AQUI"
        Btm_While.UseVisualStyleBackColor = True
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
        ' Lbl_Principal
        ' 
        Lbl_Principal.AutoSize = True
        Lbl_Principal.Location = New Point(6, 28)
        Lbl_Principal.Name = "Lbl_Principal"
        Lbl_Principal.Size = New Size(41, 15)
        Lbl_Principal.TabIndex = 2
        Lbl_Principal.Text = "Label1"
        ' 
        ' Lbl_Rendimento
        ' 
        Lbl_Rendimento.AutoSize = True
        Lbl_Rendimento.Location = New Point(129, 28)
        Lbl_Rendimento.Name = "Lbl_Rendimento"
        Lbl_Rendimento.Size = New Size(41, 15)
        Lbl_Rendimento.TabIndex = 3
        Lbl_Rendimento.Text = "Label1"
        ' 
        ' Txt_Principal
        ' 
        Txt_Principal.Location = New Point(6, 46)
        Txt_Principal.Name = "Txt_Principal"
        Txt_Principal.Size = New Size(100, 23)
        Txt_Principal.TabIndex = 4
        ' 
        ' Txt_Rendimento
        ' 
        Txt_Rendimento.Location = New Point(129, 46)
        Txt_Rendimento.Name = "Txt_Rendimento"
        Txt_Rendimento.Size = New Size(100, 23)
        Txt_Rendimento.TabIndex = 5
        ' 
        ' Lbl_Periodos
        ' 
        Lbl_Periodos.AutoSize = True
        Lbl_Periodos.Location = New Point(248, 28)
        Lbl_Periodos.Name = "Lbl_Periodos"
        Lbl_Periodos.Size = New Size(41, 15)
        Lbl_Periodos.TabIndex = 6
        Lbl_Periodos.Text = "Label1"
        ' 
        ' Txt_Periodos
        ' 
        Txt_Periodos.Location = New Point(248, 46)
        Txt_Periodos.Name = "Txt_Periodos"
        Txt_Periodos.Size = New Size(100, 23)
        Txt_Periodos.TabIndex = 7
        ' 
        ' Txt_Extrato_While
        ' 
        Txt_Extrato_While.Location = New Point(6, 129)
        Txt_Extrato_While.Multiline = True
        Txt_Extrato_While.Name = "Txt_Extrato_While"
        Txt_Extrato_While.ScrollBars = ScrollBars.Vertical
        Txt_Extrato_While.Size = New Size(239, 256)
        Txt_Extrato_While.TabIndex = 8
        ' 
        ' Btm_For
        ' 
        Btm_For.Location = New Point(270, 86)
        Btm_For.Name = "Btm_For"
        Btm_For.Size = New Size(239, 37)
        Btm_For.TabIndex = 9
        Btm_For.Text = "CLIQUE AQUI"
        Btm_For.UseVisualStyleBackColor = True
        ' 
        ' Txt_Extrato_For
        ' 
        Txt_Extrato_For.Location = New Point(270, 129)
        Txt_Extrato_For.Multiline = True
        Txt_Extrato_For.Name = "Txt_Extrato_For"
        Txt_Extrato_For.ScrollBars = ScrollBars.Vertical
        Txt_Extrato_For.Size = New Size(239, 256)
        Txt_Extrato_For.TabIndex = 10
        ' 
        ' Grp_Grupo1
        ' 
        Grp_Grupo1.Controls.Add(Txt_Principal)
        Grp_Grupo1.Controls.Add(Txt_Extrato_For)
        Grp_Grupo1.Controls.Add(Btm_While)
        Grp_Grupo1.Controls.Add(Btm_For)
        Grp_Grupo1.Controls.Add(Lbl_Principal)
        Grp_Grupo1.Controls.Add(Txt_Extrato_While)
        Grp_Grupo1.Controls.Add(Lbl_Rendimento)
        Grp_Grupo1.Controls.Add(Txt_Periodos)
        Grp_Grupo1.Controls.Add(Txt_Rendimento)
        Grp_Grupo1.Controls.Add(Lbl_Periodos)
        Grp_Grupo1.Location = New Point(12, 27)
        Grp_Grupo1.Name = "Grp_Grupo1"
        Grp_Grupo1.Size = New Size(530, 395)
        Grp_Grupo1.TabIndex = 11
        Grp_Grupo1.TabStop = False
        Grp_Grupo1.Text = "GroupBox1"
        ' 
        ' Grp_Grupo2
        ' 
        Grp_Grupo2.Controls.Add(Txt_Limite)
        Grp_Grupo2.Controls.Add(Lbl_Limite)
        Grp_Grupo2.Controls.Add(Txt_Resultado)
        Grp_Grupo2.Controls.Add(Btm_Calcula)
        Grp_Grupo2.Controls.Add(Txt_Anos)
        Grp_Grupo2.Controls.Add(Txt_AcrescimoRendimento)
        Grp_Grupo2.Controls.Add(Txt_Rendimento2)
        Grp_Grupo2.Controls.Add(Txt_Principal2)
        Grp_Grupo2.Controls.Add(Lbl_Anos)
        Grp_Grupo2.Controls.Add(Lbl_Rendimento2)
        Grp_Grupo2.Controls.Add(Lbl_AcrescimoRendimento)
        Grp_Grupo2.Controls.Add(Lbl_Principal2)
        Grp_Grupo2.Location = New Point(548, 27)
        Grp_Grupo2.Name = "Grp_Grupo2"
        Grp_Grupo2.Size = New Size(530, 395)
        Grp_Grupo2.TabIndex = 12
        Grp_Grupo2.TabStop = False
        Grp_Grupo2.Text = "GroupBox1"
        ' 
        ' Txt_Limite
        ' 
        Txt_Limite.Location = New Point(318, 92)
        Txt_Limite.Name = "Txt_Limite"
        Txt_Limite.Size = New Size(100, 23)
        Txt_Limite.TabIndex = 11
        ' 
        ' Lbl_Limite
        ' 
        Lbl_Limite.AutoSize = True
        Lbl_Limite.Location = New Point(318, 74)
        Lbl_Limite.Name = "Lbl_Limite"
        Lbl_Limite.Size = New Size(41, 15)
        Lbl_Limite.TabIndex = 10
        Lbl_Limite.Text = "Label3"
        ' 
        ' Txt_Resultado
        ' 
        Txt_Resultado.Location = New Point(6, 167)
        Txt_Resultado.Multiline = True
        Txt_Resultado.Name = "Txt_Resultado"
        Txt_Resultado.ScrollBars = ScrollBars.Vertical
        Txt_Resultado.Size = New Size(518, 218)
        Txt_Resultado.TabIndex = 9
        ' 
        ' Btm_Calcula
        ' 
        Btm_Calcula.Location = New Point(6, 128)
        Btm_Calcula.Name = "Btm_Calcula"
        Btm_Calcula.Size = New Size(268, 33)
        Btm_Calcula.TabIndex = 8
        Btm_Calcula.Text = "Button1"
        Btm_Calcula.UseVisualStyleBackColor = True
        ' 
        ' Txt_Anos
        ' 
        Txt_Anos.Location = New Point(6, 92)
        Txt_Anos.Name = "Txt_Anos"
        Txt_Anos.Size = New Size(100, 23)
        Txt_Anos.TabIndex = 7
        ' 
        ' Txt_AcrescimoRendimento
        ' 
        Txt_AcrescimoRendimento.Location = New Point(174, 92)
        Txt_AcrescimoRendimento.Name = "Txt_AcrescimoRendimento"
        Txt_AcrescimoRendimento.Size = New Size(100, 23)
        Txt_AcrescimoRendimento.TabIndex = 6
        ' 
        ' Txt_Rendimento2
        ' 
        Txt_Rendimento2.Location = New Point(174, 46)
        Txt_Rendimento2.Name = "Txt_Rendimento2"
        Txt_Rendimento2.Size = New Size(100, 23)
        Txt_Rendimento2.TabIndex = 5
        ' 
        ' Txt_Principal2
        ' 
        Txt_Principal2.Location = New Point(6, 46)
        Txt_Principal2.Name = "Txt_Principal2"
        Txt_Principal2.Size = New Size(100, 23)
        Txt_Principal2.TabIndex = 4
        ' 
        ' Lbl_Anos
        ' 
        Lbl_Anos.AutoSize = True
        Lbl_Anos.Location = New Point(6, 74)
        Lbl_Anos.Name = "Lbl_Anos"
        Lbl_Anos.Size = New Size(41, 15)
        Lbl_Anos.TabIndex = 3
        Lbl_Anos.Text = "Label4"
        ' 
        ' Lbl_Rendimento2
        ' 
        Lbl_Rendimento2.AutoSize = True
        Lbl_Rendimento2.Location = New Point(174, 28)
        Lbl_Rendimento2.Name = "Lbl_Rendimento2"
        Lbl_Rendimento2.Size = New Size(41, 15)
        Lbl_Rendimento2.TabIndex = 2
        Lbl_Rendimento2.Text = "Label3"
        ' 
        ' Lbl_AcrescimoRendimento
        ' 
        Lbl_AcrescimoRendimento.AutoSize = True
        Lbl_AcrescimoRendimento.Location = New Point(174, 74)
        Lbl_AcrescimoRendimento.Name = "Lbl_AcrescimoRendimento"
        Lbl_AcrescimoRendimento.Size = New Size(41, 15)
        Lbl_AcrescimoRendimento.TabIndex = 1
        Lbl_AcrescimoRendimento.Text = "Label2"
        ' 
        ' Lbl_Principal2
        ' 
        Lbl_Principal2.AutoSize = True
        Lbl_Principal2.Location = New Point(6, 28)
        Lbl_Principal2.Name = "Lbl_Principal2"
        Lbl_Principal2.Size = New Size(41, 15)
        Lbl_Principal2.TabIndex = 0
        Lbl_Principal2.Text = "Label1"
        ' 
        ' Frm_Principal_05
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1090, 430)
        Controls.Add(Grp_Grupo2)
        Controls.Add(Grp_Grupo1)
        Controls.Add(Lbl_NomeProjeto)
        Name = "Frm_Principal_05"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplicação Olá Mundo!"
        Grp_Grupo1.ResumeLayout(False)
        Grp_Grupo1.PerformLayout()
        Grp_Grupo2.ResumeLayout(False)
        Grp_Grupo2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btm_While As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Lbl_Rendimento As Label
    Friend WithEvents Txt_Principal As TextBox
    Friend WithEvents Txt_Rendimento As TextBox
    Friend WithEvents Lbl_Periodos As Label
    Friend WithEvents Txt_Periodos As TextBox
    Friend WithEvents Txt_Extrato_While As TextBox
    Friend WithEvents Btm_For As Button
    Friend WithEvents Txt_Extrato_For As TextBox
    Friend WithEvents Grp_Grupo1 As GroupBox
    Friend WithEvents Grp_Grupo2 As GroupBox
    Friend WithEvents Lbl_Anos As Label
    Friend WithEvents Lbl_Rendimento2 As Label
    Friend WithEvents Lbl_AcrescimoRendimento As Label
    Friend WithEvents Lbl_Principal2 As Label
    Friend WithEvents Txt_Anos As TextBox
    Friend WithEvents Txt_AcrescimoRendimento As TextBox
    Friend WithEvents Txt_Rendimento2 As TextBox
    Friend WithEvents Txt_Principal2 As TextBox
    Friend WithEvents Btm_Calcula As Button
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Limite As Label
    Friend WithEvents Txt_Limite As TextBox

End Class
