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
        Btm_Autentica = New Button()
        Btm_Autentica2 = New Button()
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
        ' Btm_Autentica
        ' 
        Btm_Autentica.Location = New Point(12, 66)
        Btm_Autentica.Name = "Btm_Autentica"
        Btm_Autentica.Size = New Size(171, 55)
        Btm_Autentica.TabIndex = 1
        Btm_Autentica.Text = "Button1"
        Btm_Autentica.UseVisualStyleBackColor = True
        ' 
        ' Btm_Autentica2
        ' 
        Btm_Autentica2.Location = New Point(189, 66)
        Btm_Autentica2.Name = "Btm_Autentica2"
        Btm_Autentica2.Size = New Size(171, 55)
        Btm_Autentica2.TabIndex = 2
        Btm_Autentica2.Text = "Button1"
        Btm_Autentica2.UseVisualStyleBackColor = True
        ' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 367)
        Controls.Add(Btm_Autentica2)
        Controls.Add(Btm_Autentica)
        Controls.Add(Lbl_Principal)
        Name = "Frm_Principal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Autentica As Button
    Friend WithEvents Btm_Autentica2 As Button

End Class
