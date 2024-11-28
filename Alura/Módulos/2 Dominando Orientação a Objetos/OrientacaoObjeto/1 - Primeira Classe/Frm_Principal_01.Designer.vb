<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal_01
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
        Lbl_Principal = New Label()
        Btm_Acao = New Button()
        Lbl_Saldo = New Label()
        Lbl_Incremento = New Label()
        Txt_Saldo = New TextBox()
        Txt_Incremento = New TextBox()
        Btm_Acao2 = New Button()
        Btm_ValRef = New Button()
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
        ' Btm_Acao
        ' 
        Btm_Acao.Location = New Point(12, 50)
        Btm_Acao.Name = "Btm_Acao"
        Btm_Acao.Size = New Size(150, 66)
        Btm_Acao.TabIndex = 1
        Btm_Acao.Text = "Button1"
        Btm_Acao.UseVisualStyleBackColor = True
        ' 
        ' Lbl_Saldo
        ' 
        Lbl_Saldo.AutoSize = True
        Lbl_Saldo.Location = New Point(12, 130)
        Lbl_Saldo.Name = "Lbl_Saldo"
        Lbl_Saldo.Size = New Size(41, 15)
        Lbl_Saldo.TabIndex = 2
        Lbl_Saldo.Text = "Label1"
        ' 
        ' Lbl_Incremento
        ' 
        Lbl_Incremento.AutoSize = True
        Lbl_Incremento.Location = New Point(121, 130)
        Lbl_Incremento.Name = "Lbl_Incremento"
        Lbl_Incremento.Size = New Size(41, 15)
        Lbl_Incremento.TabIndex = 3
        Lbl_Incremento.Text = "Label2"
        ' 
        ' Txt_Saldo
        ' 
        Txt_Saldo.Location = New Point(12, 148)
        Txt_Saldo.Name = "Txt_Saldo"
        Txt_Saldo.Size = New Size(75, 23)
        Txt_Saldo.TabIndex = 4
        ' 
        ' Txt_Incremento
        ' 
        Txt_Incremento.Location = New Point(121, 148)
        Txt_Incremento.Name = "Txt_Incremento"
        Txt_Incremento.Size = New Size(75, 23)
        Txt_Incremento.TabIndex = 5
        ' 
        ' Btm_Acao2
        ' 
        Btm_Acao2.Location = New Point(273, 50)
        Btm_Acao2.Name = "Btm_Acao2"
        Btm_Acao2.Size = New Size(150, 66)
        Btm_Acao2.TabIndex = 6
        Btm_Acao2.Text = "Button1"
        Btm_Acao2.UseVisualStyleBackColor = True
        ' 
        ' Btm_ValRef
        ' 
        Btm_ValRef.Location = New Point(215, 125)
        Btm_ValRef.Name = "Btm_ValRef"
        Btm_ValRef.Size = New Size(150, 66)
        Btm_ValRef.TabIndex = 7
        Btm_ValRef.Text = "Button1"
        Btm_ValRef.UseVisualStyleBackColor = True
        ' 
        ' Frm_Principal_01
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(458, 337)
        Controls.Add(Btm_ValRef)
        Controls.Add(Btm_Acao2)
        Controls.Add(Txt_Incremento)
        Controls.Add(Txt_Saldo)
        Controls.Add(Lbl_Incremento)
        Controls.Add(Lbl_Saldo)
        Controls.Add(Btm_Acao)
        Controls.Add(Lbl_Principal)
        Name = "Frm_Principal_01"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Acao As Button
    Friend WithEvents Lbl_Saldo As Label
    Friend WithEvents Lbl_Incremento As Label
    Friend WithEvents Txt_Saldo As TextBox
    Friend WithEvents Txt_Incremento As TextBox
    Friend WithEvents Btm_Acao2 As Button
    Friend WithEvents Btm_ValRef As Button

End Class
