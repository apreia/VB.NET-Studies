<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal3
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
        Lbl_Principal3 = New Label()
        Btm_Principal3 = New Button()
        Btm_Principal03a = New Button()
        Btm_Principal03b = New Button()
        SuspendLayout()
        ' 
        ' Lbl_Principal3
        ' 
        Lbl_Principal3.AutoSize = True
        Lbl_Principal3.Location = New Point(12, 9)
        Lbl_Principal3.Name = "Lbl_Principal3"
        Lbl_Principal3.Size = New Size(41, 15)
        Lbl_Principal3.TabIndex = 0
        Lbl_Principal3.Text = "Label1"
        ' 
        ' Btm_Principal3
        ' 
        Btm_Principal3.Location = New Point(12, 40)
        Btm_Principal3.Name = "Btm_Principal3"
        Btm_Principal3.Size = New Size(82, 23)
        Btm_Principal3.TabIndex = 1
        Btm_Principal3.Text = "Button1"
        Btm_Principal3.UseVisualStyleBackColor = True
        ' 
        ' Btm_Principal03a
        ' 
        Btm_Principal03a.Location = New Point(12, 81)
        Btm_Principal03a.Name = "Btm_Principal03a"
        Btm_Principal03a.Size = New Size(82, 23)
        Btm_Principal03a.TabIndex = 2
        Btm_Principal03a.Text = "Button1"
        Btm_Principal03a.UseVisualStyleBackColor = True
        ' 
        ' Btm_Principal03b
        ' 
        Btm_Principal03b.Location = New Point(12, 125)
        Btm_Principal03b.Name = "Btm_Principal03b"
        Btm_Principal03b.Size = New Size(82, 23)
        Btm_Principal03b.TabIndex = 3
        Btm_Principal03b.Text = "Button1"
        Btm_Principal03b.UseVisualStyleBackColor = True
        ' 
        ' Frm_Principal3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 294)
        Controls.Add(Btm_Principal03b)
        Controls.Add(Btm_Principal03a)
        Controls.Add(Btm_Principal3)
        Controls.Add(Lbl_Principal3)
        Name = "Frm_Principal3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Frm_Principal3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal3 As Label
    Friend WithEvents Btm_Principal3 As Button
    Friend WithEvents Btm_Principal03a As Button
    Friend WithEvents Btm_Principal03b As Button
End Class
