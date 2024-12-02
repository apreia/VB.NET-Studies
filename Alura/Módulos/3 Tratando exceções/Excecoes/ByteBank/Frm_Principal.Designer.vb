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
        Txt_Denominador = New TextBox()
        Lbl_Denominador = New Label()
        Aula02ToolStripMenuItem = New ToolStripMenuItem()
        Vídeo04ToolStripMenuItem = New ToolStripMenuItem()
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
        MenuStrip1.Items.AddRange(New ToolStripItem() {Aula01ToolStripMenuItem, Aula02ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(497, 24)
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
        ' Txt_Denominador
        ' 
        Txt_Denominador.Location = New Point(12, 124)
        Txt_Denominador.Name = "Txt_Denominador"
        Txt_Denominador.Size = New Size(100, 23)
        Txt_Denominador.TabIndex = 2
        ' 
        ' Lbl_Denominador
        ' 
        Lbl_Denominador.AutoSize = True
        Lbl_Denominador.Location = New Point(12, 106)
        Lbl_Denominador.Name = "Lbl_Denominador"
        Lbl_Denominador.Size = New Size(41, 15)
        Lbl_Denominador.TabIndex = 3
        Lbl_Denominador.Text = "Label1"
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
        Vídeo04ToolStripMenuItem.Size = New Size(180, 22)
        Vídeo04ToolStripMenuItem.Text = "Vídeo 04"
        ' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 359)
        Controls.Add(Lbl_Denominador)
        Controls.Add(Txt_Denominador)
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
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Lbl_Denominador As Label
    Friend WithEvents Vídeo03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Aula02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo04ToolStripMenuItem As ToolStripMenuItem

End Class
