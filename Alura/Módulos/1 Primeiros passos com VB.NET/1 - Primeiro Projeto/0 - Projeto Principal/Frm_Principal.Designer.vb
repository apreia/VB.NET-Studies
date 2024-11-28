<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Btm_01 = New Button()
        Btm_02 = New Button()
        Btm_03 = New Button()
        Btm_04 = New Button()
        Btm_05 = New Button()
        SuspendLayout()
        ' 
        ' Btm_01
        ' 
        Btm_01.Location = New Point(12, 12)
        Btm_01.Name = "Btm_01"
        Btm_01.Size = New Size(270, 36)
        Btm_01.TabIndex = 0
        Btm_01.Text = "Button1"
        Btm_01.UseVisualStyleBackColor = True
        ' 
        ' Btm_02
        ' 
        Btm_02.Location = New Point(12, 54)
        Btm_02.Name = "Btm_02"
        Btm_02.Size = New Size(270, 36)
        Btm_02.TabIndex = 1
        Btm_02.Text = "Button2"
        Btm_02.UseVisualStyleBackColor = True
        ' 
        ' Btm_03
        ' 
        Btm_03.Location = New Point(12, 96)
        Btm_03.Name = "Btm_03"
        Btm_03.Size = New Size(270, 36)
        Btm_03.TabIndex = 2
        Btm_03.Text = "Button3"
        Btm_03.UseVisualStyleBackColor = True
        ' 
        ' Btm_04
        ' 
        Btm_04.Location = New Point(12, 138)
        Btm_04.Name = "Btm_04"
        Btm_04.Size = New Size(270, 36)
        Btm_04.TabIndex = 3
        Btm_04.Text = "Button4"
        Btm_04.UseVisualStyleBackColor = True
        ' 
        ' Btm_05
        ' 
        Btm_05.Location = New Point(12, 180)
        Btm_05.Name = "Btm_05"
        Btm_05.Size = New Size(270, 36)
        Btm_05.TabIndex = 4
        Btm_05.Text = "Button5"
        Btm_05.UseVisualStyleBackColor = True
        ' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(298, 232)
        Controls.Add(Btm_05)
        Controls.Add(Btm_04)
        Controls.Add(Btm_03)
        Controls.Add(Btm_02)
        Controls.Add(Btm_01)
        Name = "Frm_Principal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btm_01 As Button
    Friend WithEvents Btm_02 As Button
    Friend WithEvents Btm_03 As Button
    Friend WithEvents Btm_04 As Button
    Friend WithEvents Btm_05 As Button

End Class
