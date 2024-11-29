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
        MenuStrip1.SuspendLayout()
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
        MenuStrip1.Items.AddRange(New ToolStripItem() {Aula01ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(497, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Aula01ToolStripMenuItem
        ' 
        Aula01ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Vídeo01ToolStripMenuItem, Vídeo02ToolStripMenuItem})
        Aula01ToolStripMenuItem.Name = "Aula01ToolStripMenuItem"
        Aula01ToolStripMenuItem.Size = New Size(58, 20)
        Aula01ToolStripMenuItem.Text = "Aula 01"
        ' 
        ' Vídeo01ToolStripMenuItem
        ' 
        Vídeo01ToolStripMenuItem.Name = "Vídeo01ToolStripMenuItem"
        Vídeo01ToolStripMenuItem.Size = New Size(180, 22)
        Vídeo01ToolStripMenuItem.Text = "Vídeo 01"
        ' 
        ' Vídeo02ToolStripMenuItem
        ' 
        Vídeo02ToolStripMenuItem.Name = "Vídeo02ToolStripMenuItem"
        Vídeo02ToolStripMenuItem.Size = New Size(180, 22)
        Vídeo02ToolStripMenuItem.Text = "Vídeo 02"
        ' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 359)
        Controls.Add(Lbl_Principal)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Frm_Principal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Aula01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo02ToolStripMenuItem As ToolStripMenuItem

End Class
