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
        Btm_Principal = New Button()
        Lbl_URL = New Label()
        Lbl_Separador = New Label()
        Txt_URL = New TextBox()
        Txt_Sepador = New TextBox()
        Btm_Principal2 = New Button()
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
        ' Btm_Principal
        ' 
        Btm_Principal.Location = New Point(12, 143)
        Btm_Principal.Name = "Btm_Principal"
        Btm_Principal.Size = New Size(117, 47)
        Btm_Principal.TabIndex = 1
        Btm_Principal.Text = "Button1"
        Btm_Principal.UseVisualStyleBackColor = True
        ' 
        ' Lbl_URL
        ' 
        Lbl_URL.AutoSize = True
        Lbl_URL.Location = New Point(12, 48)
        Lbl_URL.Name = "Lbl_URL"
        Lbl_URL.Size = New Size(41, 15)
        Lbl_URL.TabIndex = 2
        Lbl_URL.Text = "Label1"
        ' 
        ' Lbl_Separador
        ' 
        Lbl_Separador.AutoSize = True
        Lbl_Separador.Location = New Point(12, 89)
        Lbl_Separador.Name = "Lbl_Separador"
        Lbl_Separador.Size = New Size(41, 15)
        Lbl_Separador.TabIndex = 3
        Lbl_Separador.Text = "Label1"
        ' 
        ' Txt_URL
        ' 
        Txt_URL.Location = New Point(78, 45)
        Txt_URL.Name = "Txt_URL"
        Txt_URL.Size = New Size(349, 23)
        Txt_URL.TabIndex = 4
        ' 
        ' Txt_Sepador
        ' 
        Txt_Sepador.Location = New Point(78, 86)
        Txt_Sepador.Name = "Txt_Sepador"
        Txt_Sepador.Size = New Size(70, 23)
        Txt_Sepador.TabIndex = 5
        ' 
        ' Btm_Principal2
        ' 
        Btm_Principal2.Location = New Point(135, 143)
        Btm_Principal2.Name = "Btm_Principal2"
        Btm_Principal2.Size = New Size(117, 47)
        Btm_Principal2.TabIndex = 6
        Btm_Principal2.Text = "Button1"
        Btm_Principal2.UseVisualStyleBackColor = True
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 258)
        Controls.Add(Btm_Principal2)
        Controls.Add(Txt_Sepador)
        Controls.Add(Txt_URL)
        Controls.Add(Lbl_Separador)
        Controls.Add(Lbl_URL)
        Controls.Add(Btm_Principal)
        Controls.Add(Lbl_Principal)
        Name = "FrmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Lbl_Separador As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Txt_Sepador As TextBox
    Friend WithEvents Btm_Principal2 As Button

End Class
