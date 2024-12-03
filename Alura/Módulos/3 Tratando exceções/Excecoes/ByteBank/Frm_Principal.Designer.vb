<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
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
        MenuStrip1 = New MenuStrip()
        Aula01ToolStripMenuItem = New ToolStripMenuItem()
        Vídeo01ToolStripMenuItem = New ToolStripMenuItem()
        Vídeo02ToolStripMenuItem = New ToolStripMenuItem()
        Vídeo03ToolStripMenuItem = New ToolStripMenuItem()
        Aula02ToolStripMenuItem = New ToolStripMenuItem()
        Vídeo04ToolStripMenuItem = New ToolStripMenuItem()
        Aula03ToolStripMenuItem = New ToolStripMenuItem()
        Txt_Denominador = New TextBox()
        Lbl_Denominador = New Label()
        Lbl_Agencia = New Label()
        Grp_DivisaoZero = New GroupBox()
        Grp_AgenciaConta = New GroupBox()
        Txt_Conta = New TextBox()
        Txt_Agencia = New TextBox()
        Lbl_Conta = New Label()
        Vídeo05ToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        Grp_DivisaoZero.SuspendLayout()
        Grp_AgenciaConta.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lbl_Principal
        ' 
        Lbl_Principal.AutoSize = True
        Lbl_Principal.Location = New Point(12, 54)
        Lbl_Principal.Name = "Lbl_Principal"
        Lbl_Principal.Size = New Size(41, 15)
        Lbl_Principal.TabIndex = 0
        Lbl_Principal.Text = "Label1"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {Aula01ToolStripMenuItem, Aula02ToolStripMenuItem, Aula03ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(414, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Aula01ToolStripMenuItem
        ' 
        Aula01ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Vídeo01ToolStripMenuItem, Vídeo02ToolStripMenuItem, Vídeo03ToolStripMenuItem})
        Aula01ToolStripMenuItem.Name = "Aula01ToolStripMenuItem"
        Aula01ToolStripMenuItem.Size = New Size(58, 20)
        Aula01ToolStripMenuItem.Text = "Aula 01"
        ' 
        ' Vídeo01ToolStripMenuItem
        ' 
        Vídeo01ToolStripMenuItem.Name = "Vídeo01ToolStripMenuItem"
        Vídeo01ToolStripMenuItem.Size = New Size(119, 22)
        Vídeo01ToolStripMenuItem.Text = "Vídeo 01"
        ' 
        ' Vídeo02ToolStripMenuItem
        ' 
        Vídeo02ToolStripMenuItem.Name = "Vídeo02ToolStripMenuItem"
        Vídeo02ToolStripMenuItem.Size = New Size(119, 22)
        Vídeo02ToolStripMenuItem.Text = "Vídeo 02"
        ' 
        ' Vídeo03ToolStripMenuItem
        ' 
        Vídeo03ToolStripMenuItem.Name = "Vídeo03ToolStripMenuItem"
        Vídeo03ToolStripMenuItem.Size = New Size(119, 22)
        Vídeo03ToolStripMenuItem.Text = "Vídeo 03"
        ' 
        ' Aula02ToolStripMenuItem
        ' 
        Aula02ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Vídeo04ToolStripMenuItem})
        Aula02ToolStripMenuItem.Name = "Aula02ToolStripMenuItem"
        Aula02ToolStripMenuItem.Size = New Size(58, 20)
        Aula02ToolStripMenuItem.Text = "Aula 02"
        ' 
        ' Vídeo04ToolStripMenuItem
        ' 
        Vídeo04ToolStripMenuItem.Name = "Vídeo04ToolStripMenuItem"
        Vídeo04ToolStripMenuItem.Size = New Size(119, 22)
        Vídeo04ToolStripMenuItem.Text = "Vídeo 04"
        ' 
        ' Aula03ToolStripMenuItem
        ' 
        Aula03ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Vídeo05ToolStripMenuItem})
        Aula03ToolStripMenuItem.Name = "Aula03ToolStripMenuItem"
        Aula03ToolStripMenuItem.Size = New Size(58, 20)
        Aula03ToolStripMenuItem.Text = "Aula 03"
        ' 
        ' Txt_Denominador
        ' 
        Txt_Denominador.Location = New Point(6, 37)
        Txt_Denominador.Name = "Txt_Denominador"
        Txt_Denominador.Size = New Size(100, 23)
        Txt_Denominador.TabIndex = 2
        ' 
        ' Lbl_Denominador
        ' 
        Lbl_Denominador.AutoSize = True
        Lbl_Denominador.Location = New Point(6, 19)
        Lbl_Denominador.Name = "Lbl_Denominador"
        Lbl_Denominador.Size = New Size(41, 15)
        Lbl_Denominador.TabIndex = 3
        Lbl_Denominador.Text = "Label1"
        ' 
        ' Lbl_Agencia
        ' 
        Lbl_Agencia.AutoSize = True
        Lbl_Agencia.Location = New Point(6, 19)
        Lbl_Agencia.Name = "Lbl_Agencia"
        Lbl_Agencia.Size = New Size(41, 15)
        Lbl_Agencia.TabIndex = 4
        Lbl_Agencia.Text = "Label1"
        ' 
        ' Grp_DivisaoZero
        ' 
        Grp_DivisaoZero.Controls.Add(Lbl_Denominador)
        Grp_DivisaoZero.Controls.Add(Txt_Denominador)
        Grp_DivisaoZero.Location = New Point(12, 86)
        Grp_DivisaoZero.Name = "Grp_DivisaoZero"
        Grp_DivisaoZero.Size = New Size(139, 74)
        Grp_DivisaoZero.TabIndex = 5
        Grp_DivisaoZero.TabStop = False
        ' 
        ' Grp_AgenciaConta
        ' 
        Grp_AgenciaConta.Controls.Add(Txt_Conta)
        Grp_AgenciaConta.Controls.Add(Txt_Agencia)
        Grp_AgenciaConta.Controls.Add(Lbl_Conta)
        Grp_AgenciaConta.Controls.Add(Lbl_Agencia)
        Grp_AgenciaConta.Location = New Point(166, 86)
        Grp_AgenciaConta.Name = "Grp_AgenciaConta"
        Grp_AgenciaConta.Size = New Size(200, 152)
        Grp_AgenciaConta.TabIndex = 6
        Grp_AgenciaConta.TabStop = False
        ' 
        ' Txt_Conta
        ' 
        Txt_Conta.Location = New Point(6, 98)
        Txt_Conta.Name = "Txt_Conta"
        Txt_Conta.Size = New Size(100, 23)
        Txt_Conta.TabIndex = 7
        ' 
        ' Txt_Agencia
        ' 
        Txt_Agencia.Location = New Point(6, 37)
        Txt_Agencia.Name = "Txt_Agencia"
        Txt_Agencia.Size = New Size(100, 23)
        Txt_Agencia.TabIndex = 6
        ' 
        ' Lbl_Conta
        ' 
        Lbl_Conta.AutoSize = True
        Lbl_Conta.Location = New Point(6, 80)
        Lbl_Conta.Name = "Lbl_Conta"
        Lbl_Conta.Size = New Size(41, 15)
        Lbl_Conta.TabIndex = 5
        Lbl_Conta.Text = "Label1"
        ' 
        ' Vídeo05ToolStripMenuItem
        ' 
        Vídeo05ToolStripMenuItem.Name = "Vídeo05ToolStripMenuItem"
        Vídeo05ToolStripMenuItem.Size = New Size(180, 22)
        Vídeo05ToolStripMenuItem.Text = "Vídeo 05"
        ' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(414, 294)
        Controls.Add(Grp_AgenciaConta)
        Controls.Add(Grp_DivisaoZero)
        Controls.Add(Lbl_Principal)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Frm_Principal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Grp_DivisaoZero.ResumeLayout(False)
        Grp_DivisaoZero.PerformLayout()
        Grp_AgenciaConta.ResumeLayout(False)
        Grp_AgenciaConta.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Aula01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Lbl_Denominador As Label
    Friend WithEvents Vídeo03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Aula02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo04ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lbl_Agencia As Label
    Friend WithEvents Grp_DivisaoZero As GroupBox
    Friend WithEvents Grp_AgenciaConta As GroupBox
    Friend WithEvents Lbl_Conta As Label
    Friend WithEvents Txt_Conta As TextBox
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Aula03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo05ToolStripMenuItem As ToolStripMenuItem

End Class
