<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExemploInterface
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
        Btm_ExemploInterface = New Button()
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
        ' Btm_ExemploInterface
        ' 
        Btm_ExemploInterface.Location = New Point(12, 46)
        Btm_ExemploInterface.Name = "Btm_ExemploInterface"
        Btm_ExemploInterface.Size = New Size(139, 67)
        Btm_ExemploInterface.TabIndex = 1
        Btm_ExemploInterface.Text = "Button1"
        Btm_ExemploInterface.UseVisualStyleBackColor = True
        ' 
        ' ExemploInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(457, 304)
        Controls.Add(Btm_ExemploInterface)
        Controls.Add(Lbl_Principal)
        Name = "ExemploInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_ExemploInterface As Button

End Class
