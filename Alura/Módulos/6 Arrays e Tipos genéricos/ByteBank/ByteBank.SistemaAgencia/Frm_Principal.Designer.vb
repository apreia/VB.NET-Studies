<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Btm_Principal2 = New System.Windows.Forms.Button()
        Me.Btm_Principal3 = New System.Windows.Forms.Button()
        Me.Btm_Principal4 = New System.Windows.Forms.Button()
        Me.Btm_Principal5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(15, 45)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(124, 46)
        Me.Btm_Principal.TabIndex = 1
        Me.Btm_Principal.Text = "Button1"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'Btm_Principal2
        '
        Me.Btm_Principal2.Location = New System.Drawing.Point(15, 113)
        Me.Btm_Principal2.Name = "Btm_Principal2"
        Me.Btm_Principal2.Size = New System.Drawing.Size(124, 46)
        Me.Btm_Principal2.TabIndex = 2
        Me.Btm_Principal2.Text = "Button1"
        Me.Btm_Principal2.UseVisualStyleBackColor = True
        '
        'Btm_Principal3
        '
        Me.Btm_Principal3.Location = New System.Drawing.Point(15, 191)
        Me.Btm_Principal3.Name = "Btm_Principal3"
        Me.Btm_Principal3.Size = New System.Drawing.Size(124, 46)
        Me.Btm_Principal3.TabIndex = 3
        Me.Btm_Principal3.Text = "Button1"
        Me.Btm_Principal3.UseVisualStyleBackColor = True
        '
        'Btm_Principal4
        '
        Me.Btm_Principal4.Location = New System.Drawing.Point(184, 45)
        Me.Btm_Principal4.Name = "Btm_Principal4"
        Me.Btm_Principal4.Size = New System.Drawing.Size(124, 46)
        Me.Btm_Principal4.TabIndex = 4
        Me.Btm_Principal4.Text = "Button1"
        Me.Btm_Principal4.UseVisualStyleBackColor = True
        '
        'Btm_Principal5
        '
        Me.Btm_Principal5.Location = New System.Drawing.Point(184, 113)
        Me.Btm_Principal5.Name = "Btm_Principal5"
        Me.Btm_Principal5.Size = New System.Drawing.Size(124, 46)
        Me.Btm_Principal5.TabIndex = 5
        Me.Btm_Principal5.Text = "Button1"
        Me.Btm_Principal5.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 275)
        Me.Controls.Add(Me.Btm_Principal5)
        Me.Controls.Add(Me.Btm_Principal4)
        Me.Controls.Add(Me.Btm_Principal3)
        Me.Controls.Add(Me.Btm_Principal2)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Btm_Principal2 As Button
    Friend WithEvents Btm_Principal3 As Button
    Friend WithEvents Btm_Principal4 As Button
    Friend WithEvents Btm_Principal5 As Button
End Class
