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
        Btm_Click = New Button()
        Btm_TesteHerenca = New Button()
        Btm_ClasseBase = New Button()
        Btm_Aumento = New Button()
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
        ' Btm_Click
        ' 
        Btm_Click.Location = New Point(12, 44)
        Btm_Click.Name = "Btm_Click"
        Btm_Click.Size = New Size(156, 51)
        Btm_Click.TabIndex = 1
        Btm_Click.Text = "Button1"
        Btm_Click.UseVisualStyleBackColor = True
        ' 
        ' Btm_TesteHerenca
        ' 
        Btm_TesteHerenca.Location = New Point(174, 44)
        Btm_TesteHerenca.Name = "Btm_TesteHerenca"
        Btm_TesteHerenca.Size = New Size(156, 51)
        Btm_TesteHerenca.TabIndex = 2
        Btm_TesteHerenca.Text = "Button1"
        Btm_TesteHerenca.UseVisualStyleBackColor = True
        ' 
        ' Btm_ClasseBase
        ' 
        Btm_ClasseBase.Location = New Point(12, 101)
        Btm_ClasseBase.Name = "Btm_ClasseBase"
        Btm_ClasseBase.Size = New Size(156, 51)
        Btm_ClasseBase.TabIndex = 3
        Btm_ClasseBase.Text = "Button1"
        Btm_ClasseBase.UseVisualStyleBackColor = True
        ' 
        ' Btm_Aumento
        ' 
        Btm_Aumento.Location = New Point(174, 101)
        Btm_Aumento.Name = "Btm_Aumento"
        Btm_Aumento.Size = New Size(156, 51)
        Btm_Aumento.TabIndex = 4
        Btm_Aumento.Text = "Button1"
        Btm_Aumento.UseVisualStyleBackColor = True
        ' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btm_Aumento)
        Controls.Add(Btm_ClasseBase)
        Controls.Add(Btm_TesteHerenca)
        Controls.Add(Btm_Click)
        Controls.Add(Lbl_Principal)
        Name = "Frm_Principal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Click As Button
    Friend WithEvents Btm_TesteHerenca As Button
    Friend WithEvents Btm_ClasseBase As Button
    Friend WithEvents Btm_Aumento As Button

End Class
