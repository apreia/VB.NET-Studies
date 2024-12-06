<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Pic_Logo = New PictureBox()
        Grp_Login = New GroupBox()
        Btm_Logar = New Button()
        Rb_Representante = New RadioButton()
        Rb_Gerente = New RadioButton()
        Txt_Senha = New TextBox()
        Txt_Login = New TextBox()
        Lbl_Senha = New Label()
        Lbl_Login = New Label()
        CType(Pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        Grp_Login.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pic_Logo
        ' 
        Pic_Logo.Image = CType(resources.GetObject("Pic_Logo.Image"), Image)
        Pic_Logo.Location = New Point(12, 12)
        Pic_Logo.Name = "Pic_Logo"
        Pic_Logo.Size = New Size(67, 67)
        Pic_Logo.TabIndex = 0
        Pic_Logo.TabStop = False
        ' 
        ' Grp_Login
        ' 
        Grp_Login.Controls.Add(Btm_Logar)
        Grp_Login.Controls.Add(Rb_Representante)
        Grp_Login.Controls.Add(Rb_Gerente)
        Grp_Login.Controls.Add(Txt_Senha)
        Grp_Login.Controls.Add(Txt_Login)
        Grp_Login.Controls.Add(Lbl_Senha)
        Grp_Login.Controls.Add(Lbl_Login)
        Grp_Login.Location = New Point(85, 12)
        Grp_Login.Name = "Grp_Login"
        Grp_Login.Size = New Size(266, 200)
        Grp_Login.TabIndex = 1
        Grp_Login.TabStop = False
        Grp_Login.Text = "GroupBox1"
        ' 
        ' Btm_Logar
        ' 
        Btm_Logar.Location = New Point(112, 109)
        Btm_Logar.Name = "Btm_Logar"
        Btm_Logar.Size = New Size(94, 23)
        Btm_Logar.TabIndex = 6
        Btm_Logar.Text = "Button1"
        Btm_Logar.UseVisualStyleBackColor = True
        ' 
        ' Rb_Representante
        ' 
        Rb_Representante.AutoSize = True
        Rb_Representante.Location = New Point(109, 150)
        Rb_Representante.Name = "Rb_Representante"
        Rb_Representante.Size = New Size(97, 19)
        Rb_Representante.TabIndex = 5
        Rb_Representante.TabStop = True
        Rb_Representante.Text = "RadioButton1"
        Rb_Representante.UseVisualStyleBackColor = True
        ' 
        ' Rb_Gerente
        ' 
        Rb_Gerente.AutoSize = True
        Rb_Gerente.Location = New Point(6, 150)
        Rb_Gerente.Name = "Rb_Gerente"
        Rb_Gerente.Size = New Size(97, 19)
        Rb_Gerente.TabIndex = 4
        Rb_Gerente.TabStop = True
        Rb_Gerente.Text = "RadioButton1"
        Rb_Gerente.UseVisualStyleBackColor = True
        ' 
        ' Txt_Senha
        ' 
        Txt_Senha.Location = New Point(6, 109)
        Txt_Senha.Name = "Txt_Senha"
        Txt_Senha.PasswordChar = "*"c
        Txt_Senha.Size = New Size(100, 23)
        Txt_Senha.TabIndex = 3
        ' 
        ' Txt_Login
        ' 
        Txt_Login.Location = New Point(6, 51)
        Txt_Login.Name = "Txt_Login"
        Txt_Login.Size = New Size(100, 23)
        Txt_Login.TabIndex = 2
        ' 
        ' Lbl_Senha
        ' 
        Lbl_Senha.AutoSize = True
        Lbl_Senha.Location = New Point(6, 91)
        Lbl_Senha.Name = "Lbl_Senha"
        Lbl_Senha.Size = New Size(41, 15)
        Lbl_Senha.TabIndex = 1
        Lbl_Senha.Text = "Label2"
        ' 
        ' Lbl_Login
        ' 
        Lbl_Login.AutoSize = True
        Lbl_Login.Location = New Point(6, 33)
        Lbl_Login.Name = "Lbl_Login"
        Lbl_Login.Size = New Size(41, 15)
        Lbl_Login.TabIndex = 0
        Lbl_Login.Text = "Label1"
        ' 
        ' Frm_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(372, 237)
        Controls.Add(Grp_Login)
        Controls.Add(Pic_Logo)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Frm_Login"
        Text = "Frm_Login"
        CType(Pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        Grp_Login.ResumeLayout(False)
        Grp_Login.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Pic_Logo As PictureBox
    Friend WithEvents Grp_Login As GroupBox
    Friend WithEvents Lbl_Senha As Label
    Friend WithEvents Lbl_Login As Label
    Friend WithEvents Txt_Senha As TextBox
    Friend WithEvents Txt_Login As TextBox
    Friend WithEvents Rb_Gerente As RadioButton
    Friend WithEvents Rb_Representante As RadioButton
    Friend WithEvents Btm_Logar As Button
End Class
