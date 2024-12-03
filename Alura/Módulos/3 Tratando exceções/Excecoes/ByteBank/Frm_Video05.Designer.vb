<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Video05
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
        Lbl_Video05 = New Label()
        Btm_Fechar = New Button()
        Grp_Movimentacao = New GroupBox()
        Btm_Saque = New Button()
        Txt_Valor = New TextBox()
        Lbl_Movimentacao = New Label()
        Lbl_ContaCorrente = New Label()
        Lbl_Saldo = New Label()
        Grp_Movimentacao.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lbl_Video05
        ' 
        Lbl_Video05.AutoSize = True
        Lbl_Video05.Location = New Point(12, 9)
        Lbl_Video05.Name = "Lbl_Video05"
        Lbl_Video05.Size = New Size(41, 15)
        Lbl_Video05.TabIndex = 0
        Lbl_Video05.Text = "Label1"
        ' 
        ' Btm_Fechar
        ' 
        Btm_Fechar.Location = New Point(443, 12)
        Btm_Fechar.Name = "Btm_Fechar"
        Btm_Fechar.Size = New Size(75, 23)
        Btm_Fechar.TabIndex = 1
        Btm_Fechar.Text = "Button1"
        Btm_Fechar.UseVisualStyleBackColor = True
        ' 
        ' Grp_Movimentacao
        ' 
        Grp_Movimentacao.Controls.Add(Lbl_Saldo)
        Grp_Movimentacao.Controls.Add(Btm_Saque)
        Grp_Movimentacao.Controls.Add(Txt_Valor)
        Grp_Movimentacao.Controls.Add(Lbl_Movimentacao)
        Grp_Movimentacao.Location = New Point(12, 66)
        Grp_Movimentacao.Name = "Grp_Movimentacao"
        Grp_Movimentacao.Size = New Size(411, 102)
        Grp_Movimentacao.TabIndex = 2
        Grp_Movimentacao.TabStop = False
        Grp_Movimentacao.Text = "GroupBox1"
        ' 
        ' Btm_Saque
        ' 
        Btm_Saque.Location = New Point(112, 37)
        Btm_Saque.Name = "Btm_Saque"
        Btm_Saque.Size = New Size(75, 23)
        Btm_Saque.TabIndex = 2
        Btm_Saque.Text = "Button1"
        Btm_Saque.UseVisualStyleBackColor = True
        ' 
        ' Txt_Valor
        ' 
        Txt_Valor.Location = New Point(6, 37)
        Txt_Valor.Name = "Txt_Valor"
        Txt_Valor.Size = New Size(100, 23)
        Txt_Valor.TabIndex = 1
        ' 
        ' Lbl_Movimentacao
        ' 
        Lbl_Movimentacao.AutoSize = True
        Lbl_Movimentacao.Location = New Point(6, 19)
        Lbl_Movimentacao.Name = "Lbl_Movimentacao"
        Lbl_Movimentacao.Size = New Size(41, 15)
        Lbl_Movimentacao.TabIndex = 0
        Lbl_Movimentacao.Text = "Label1"
        ' 
        ' Lbl_ContaCorrente
        ' 
        Lbl_ContaCorrente.AutoSize = True
        Lbl_ContaCorrente.Location = New Point(12, 48)
        Lbl_ContaCorrente.Name = "Lbl_ContaCorrente"
        Lbl_ContaCorrente.Size = New Size(41, 15)
        Lbl_ContaCorrente.TabIndex = 3
        Lbl_ContaCorrente.Text = "Label1"
        ' 
        ' Lbl_Saldo
        ' 
        Lbl_Saldo.AutoSize = True
        Lbl_Saldo.Location = New Point(6, 73)
        Lbl_Saldo.Name = "Lbl_Saldo"
        Lbl_Saldo.Size = New Size(41, 15)
        Lbl_Saldo.TabIndex = 3
        Lbl_Saldo.Text = "Label1"
        ' 
        ' Frm_Video05
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(530, 338)
        Controls.Add(Lbl_ContaCorrente)
        Controls.Add(Grp_Movimentacao)
        Controls.Add(Btm_Fechar)
        Controls.Add(Lbl_Video05)
        Name = "Frm_Video05"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Frm_Video05"
        Grp_Movimentacao.ResumeLayout(False)
        Grp_Movimentacao.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Video05 As Label
    Friend WithEvents Btm_Fechar As Button
    Friend WithEvents Grp_Movimentacao As GroupBox
    Friend WithEvents Lbl_Movimentacao As Label
    Friend WithEvents Txt_Valor As TextBox
    Friend WithEvents Btm_Saque As Button
    Friend WithEvents Lbl_ContaCorrente As Label
    Friend WithEvents Lbl_Saldo As Label
End Class
