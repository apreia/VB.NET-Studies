<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Secundario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Secundario))
        Pic_Logo = New PictureBox()
        Grp_ContaCorrente = New GroupBox()
        Btm_Criar = New Button()
        Txt_ContaCorrente = New TextBox()
        Txt_Agencia = New TextBox()
        Lbl_ContaCorrente = New Label()
        Lbl_Agencia = New Label()
        Lbl_ContaCorrenteCriada = New Label()
        CType(Pic_Logo, ComponentModel.ISupportInitialize).BeginInit()
        Grp_ContaCorrente.SuspendLayout()
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
        ' Grp_ContaCorrente
        ' 
        Grp_ContaCorrente.Controls.Add(Btm_Criar)
        Grp_ContaCorrente.Controls.Add(Txt_ContaCorrente)
        Grp_ContaCorrente.Controls.Add(Txt_Agencia)
        Grp_ContaCorrente.Controls.Add(Lbl_ContaCorrente)
        Grp_ContaCorrente.Controls.Add(Lbl_Agencia)
        Grp_ContaCorrente.Location = New Point(85, 12)
        Grp_ContaCorrente.Name = "Grp_ContaCorrente"
        Grp_ContaCorrente.Size = New Size(219, 151)
        Grp_ContaCorrente.TabIndex = 1
        Grp_ContaCorrente.TabStop = False
        Grp_ContaCorrente.Text = "GroupBox1"
        ' 
        ' Btm_Criar
        ' 
        Btm_Criar.Location = New Point(138, 123)
        Btm_Criar.Name = "Btm_Criar"
        Btm_Criar.Size = New Size(75, 23)
        Btm_Criar.TabIndex = 4
        Btm_Criar.Text = "Button1"
        Btm_Criar.UseVisualStyleBackColor = True
        ' 
        ' Txt_ContaCorrente
        ' 
        Txt_ContaCorrente.Location = New Point(6, 100)
        Txt_ContaCorrente.Name = "Txt_ContaCorrente"
        Txt_ContaCorrente.Size = New Size(100, 23)
        Txt_ContaCorrente.TabIndex = 3
        ' 
        ' Txt_Agencia
        ' 
        Txt_Agencia.Location = New Point(6, 44)
        Txt_Agencia.Name = "Txt_Agencia"
        Txt_Agencia.Size = New Size(100, 23)
        Txt_Agencia.TabIndex = 2
        ' 
        ' Lbl_ContaCorrente
        ' 
        Lbl_ContaCorrente.AutoSize = True
        Lbl_ContaCorrente.Location = New Point(6, 82)
        Lbl_ContaCorrente.Name = "Lbl_ContaCorrente"
        Lbl_ContaCorrente.Size = New Size(41, 15)
        Lbl_ContaCorrente.TabIndex = 1
        Lbl_ContaCorrente.Text = "Label2"
        ' 
        ' Lbl_Agencia
        ' 
        Lbl_Agencia.AutoSize = True
        Lbl_Agencia.Location = New Point(6, 26)
        Lbl_Agencia.Name = "Lbl_Agencia"
        Lbl_Agencia.Size = New Size(41, 15)
        Lbl_Agencia.TabIndex = 0
        Lbl_Agencia.Text = "Label1"
        ' 
        ' Lbl_ContaCorrenteCriada
        ' 
        Lbl_ContaCorrenteCriada.AutoSize = True
        Lbl_ContaCorrenteCriada.Location = New Point(85, 175)
        Lbl_ContaCorrenteCriada.Name = "Lbl_ContaCorrenteCriada"
        Lbl_ContaCorrenteCriada.Size = New Size(41, 15)
        Lbl_ContaCorrenteCriada.TabIndex = 2
        Lbl_ContaCorrenteCriada.Text = "Label1"
        ' 
        ' Frm_Secundario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(406, 291)
        Controls.Add(Lbl_ContaCorrenteCriada)
        Controls.Add(Grp_ContaCorrente)
        Controls.Add(Pic_Logo)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Frm_Secundario"
        Text = "Frm_Secundario"
        CType(Pic_Logo, ComponentModel.ISupportInitialize).EndInit()
        Grp_ContaCorrente.ResumeLayout(False)
        Grp_ContaCorrente.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Pic_Logo As PictureBox
    Friend WithEvents Grp_ContaCorrente As GroupBox
    Friend WithEvents Lbl_ContaCorrente As Label
    Friend WithEvents Lbl_Agencia As Label
    Friend WithEvents Txt_ContaCorrente As TextBox
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Btm_Criar As Button
    Friend WithEvents Lbl_ContaCorrenteCriada As Label
End Class
