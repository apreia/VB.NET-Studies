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
        Lbl_SaquesErrados = New Label()
        Lbl_Saldo2 = New Label()
        Btm_Transferir = New Button()
        Lbl_Saldo = New Label()
        Btm_Saque = New Button()
        Txt_Valor = New TextBox()
        Lbl_Movimentacao = New Label()
        Lbl_ContaCorrente = New Label()
        Lbl_ContaCorrente2 = New Label()
        Btm_Stack = New Button()
        Txt_Stack = New TextBox()
        Lbl_TransferErrados = New Label()
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
        Grp_Movimentacao.Controls.Add(Lbl_TransferErrados)
        Grp_Movimentacao.Controls.Add(Lbl_SaquesErrados)
        Grp_Movimentacao.Controls.Add(Lbl_Saldo2)
        Grp_Movimentacao.Controls.Add(Btm_Transferir)
        Grp_Movimentacao.Controls.Add(Lbl_Saldo)
        Grp_Movimentacao.Controls.Add(Btm_Saque)
        Grp_Movimentacao.Controls.Add(Txt_Valor)
        Grp_Movimentacao.Controls.Add(Lbl_Movimentacao)
        Grp_Movimentacao.Location = New Point(12, 66)
        Grp_Movimentacao.Name = "Grp_Movimentacao"
        Grp_Movimentacao.Size = New Size(411, 131)
        Grp_Movimentacao.TabIndex = 2
        Grp_Movimentacao.TabStop = False
        Grp_Movimentacao.Text = "GroupBox1"
        ' 
        ' Lbl_SaquesErrados
        ' 
        Lbl_SaquesErrados.AutoSize = True
        Lbl_SaquesErrados.Location = New Point(6, 104)
        Lbl_SaquesErrados.Name = "Lbl_SaquesErrados"
        Lbl_SaquesErrados.Size = New Size(41, 15)
        Lbl_SaquesErrados.TabIndex = 6
        Lbl_SaquesErrados.Text = "Label1"
        ' 
        ' Lbl_Saldo2
        ' 
        Lbl_Saldo2.AutoSize = True
        Lbl_Saldo2.Location = New Point(146, 73)
        Lbl_Saldo2.Name = "Lbl_Saldo2"
        Lbl_Saldo2.Size = New Size(41, 15)
        Lbl_Saldo2.TabIndex = 5
        Lbl_Saldo2.Text = "Label1"
        ' 
        ' Btm_Transferir
        ' 
        Btm_Transferir.Location = New Point(193, 37)
        Btm_Transferir.Name = "Btm_Transferir"
        Btm_Transferir.Size = New Size(75, 23)
        Btm_Transferir.TabIndex = 4
        Btm_Transferir.Text = "Button1"
        Btm_Transferir.UseVisualStyleBackColor = True
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
        ' Lbl_ContaCorrente2
        ' 
        Lbl_ContaCorrente2.AutoSize = True
        Lbl_ContaCorrente2.Location = New Point(353, 48)
        Lbl_ContaCorrente2.Name = "Lbl_ContaCorrente2"
        Lbl_ContaCorrente2.Size = New Size(41, 15)
        Lbl_ContaCorrente2.TabIndex = 4
        Lbl_ContaCorrente2.Text = "Label1"
        ' 
        ' Btm_Stack
        ' 
        Btm_Stack.Location = New Point(12, 203)
        Btm_Stack.Name = "Btm_Stack"
        Btm_Stack.Size = New Size(130, 23)
        Btm_Stack.TabIndex = 5
        Btm_Stack.Text = "Button1"
        Btm_Stack.UseVisualStyleBackColor = True
        ' 
        ' Txt_Stack
        ' 
        Txt_Stack.Location = New Point(12, 232)
        Txt_Stack.Multiline = True
        Txt_Stack.Name = "Txt_Stack"
        Txt_Stack.ScrollBars = ScrollBars.Vertical
        Txt_Stack.Size = New Size(411, 123)
        Txt_Stack.TabIndex = 6
        ' 
        ' Lbl_TransferErrados
        ' 
        Lbl_TransferErrados.AutoSize = True
        Lbl_TransferErrados.Location = New Point(146, 104)
        Lbl_TransferErrados.Name = "Lbl_TransferErrados"
        Lbl_TransferErrados.Size = New Size(41, 15)
        Lbl_TransferErrados.TabIndex = 7
        Lbl_TransferErrados.Text = "Label1"
        ' 
        ' Frm_Video05
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(530, 367)
        Controls.Add(Txt_Stack)
        Controls.Add(Btm_Stack)
        Controls.Add(Lbl_ContaCorrente2)
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
    Friend WithEvents Btm_Transferir As Button
    Friend WithEvents Lbl_ContaCorrente2 As Label
    Friend WithEvents Lbl_Saldo2 As Label
    Friend WithEvents Btm_Stack As Button
    Friend WithEvents Txt_Stack As TextBox
    Friend WithEvents Lbl_SaquesErrados As Label
    Friend WithEvents Lbl_TransferErrados As Label
End Class
