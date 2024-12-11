<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal2
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
        Lbl_Principal2 = New Label()
        Txt_URL = New TextBox()
        Lbl_URL = New Label()
        Lbl_Argumento = New Label()
        Txt_Argumento = New TextBox()
        Btn_Processa = New Button()
        Lbl_Propriedade = New Label()
        Txt_Propriedade = New TextBox()
        SuspendLayout()
        ' 
        ' Lbl_Principal2
        ' 
        Lbl_Principal2.AutoSize = True
        Lbl_Principal2.Location = New Point(12, 9)
        Lbl_Principal2.Name = "Lbl_Principal2"
        Lbl_Principal2.Size = New Size(41, 15)
        Lbl_Principal2.TabIndex = 0
        Lbl_Principal2.Text = "Label1"
        ' 
        ' Txt_URL
        ' 
        Txt_URL.Location = New Point(12, 56)
        Txt_URL.Multiline = True
        Txt_URL.Name = "Txt_URL"
        Txt_URL.ScrollBars = ScrollBars.Vertical
        Txt_URL.Size = New Size(588, 145)
        Txt_URL.TabIndex = 6
        ' 
        ' Lbl_URL
        ' 
        Lbl_URL.AutoSize = True
        Lbl_URL.Location = New Point(12, 38)
        Lbl_URL.Name = "Lbl_URL"
        Lbl_URL.Size = New Size(41, 15)
        Lbl_URL.TabIndex = 5
        Lbl_URL.Text = "Label1"
        ' 
        ' Lbl_Argumento
        ' 
        Lbl_Argumento.AutoSize = True
        Lbl_Argumento.Location = New Point(12, 217)
        Lbl_Argumento.Name = "Lbl_Argumento"
        Lbl_Argumento.Size = New Size(41, 15)
        Lbl_Argumento.TabIndex = 7
        Lbl_Argumento.Text = "Label1"
        ' 
        ' Txt_Argumento
        ' 
        Txt_Argumento.Location = New Point(12, 235)
        Txt_Argumento.Multiline = True
        Txt_Argumento.Name = "Txt_Argumento"
        Txt_Argumento.ScrollBars = ScrollBars.Vertical
        Txt_Argumento.Size = New Size(588, 89)
        Txt_Argumento.TabIndex = 8
        ' 
        ' Btn_Processa
        ' 
        Btn_Processa.Location = New Point(470, 206)
        Btn_Processa.Name = "Btn_Processa"
        Btn_Processa.Size = New Size(130, 23)
        Btn_Processa.TabIndex = 9
        Btn_Processa.Text = "Button1"
        Btn_Processa.UseVisualStyleBackColor = True
        ' 
        ' Lbl_Propriedade
        ' 
        Lbl_Propriedade.AutoSize = True
        Lbl_Propriedade.Location = New Point(12, 359)
        Lbl_Propriedade.Name = "Lbl_Propriedade"
        Lbl_Propriedade.Size = New Size(41, 15)
        Lbl_Propriedade.TabIndex = 10
        Lbl_Propriedade.Text = "Label1"
        ' 
        ' Txt_Propriedade
        ' 
        Txt_Propriedade.Location = New Point(12, 377)
        Txt_Propriedade.Name = "Txt_Propriedade"
        Txt_Propriedade.Size = New Size(453, 23)
        Txt_Propriedade.TabIndex = 11
        ' 
        ' Frm_Principal2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(613, 446)
        Controls.Add(Txt_Propriedade)
        Controls.Add(Lbl_Propriedade)
        Controls.Add(Btn_Processa)
        Controls.Add(Txt_Argumento)
        Controls.Add(Lbl_Argumento)
        Controls.Add(Txt_URL)
        Controls.Add(Lbl_URL)
        Controls.Add(Lbl_Principal2)
        Name = "Frm_Principal2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Frm_Principal2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal2 As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Lbl_Argumento As Label
    Friend WithEvents Txt_Argumento As TextBox
    Friend WithEvents Btn_Processa As Button
    Friend WithEvents Lbl_Propriedade As Label
    Friend WithEvents Txt_Propriedade As TextBox
End Class
