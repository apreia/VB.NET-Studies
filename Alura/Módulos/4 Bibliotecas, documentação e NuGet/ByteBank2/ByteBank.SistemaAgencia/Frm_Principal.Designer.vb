<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        Aula01ToolStripMenuItem = New ToolStripMenuItem()
        Vídeo01ToolStripMenuItem = New ToolStripMenuItem()
        Aula02ToolStripMenuItem = New ToolStripMenuItem()
        Vídeo02ToolStripMenuItem = New ToolStripMenuItem()
        JanelasToolStripMenuItem = New ToolStripMenuItem()
        JanelasHorizontaisToolStripMenuItem = New ToolStripMenuItem()
        JanelasVerticaisToolStripMenuItem = New ToolStripMenuItem()
        JanelasCascatasToolStripMenuItem = New ToolStripMenuItem()
        Aula03ToolStripMenuItem = New ToolStripMenuItem()
        Vídeo03ToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {Aula01ToolStripMenuItem, Aula02ToolStripMenuItem, Aula03ToolStripMenuItem, JanelasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(490, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Aula01ToolStripMenuItem
        ' 
        Aula01ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Vídeo01ToolStripMenuItem})
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
        ' Aula02ToolStripMenuItem
        ' 
        Aula02ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Vídeo02ToolStripMenuItem})
        Aula02ToolStripMenuItem.Name = "Aula02ToolStripMenuItem"
        Aula02ToolStripMenuItem.Size = New Size(58, 20)
        Aula02ToolStripMenuItem.Text = "Aula 02"
        ' 
        ' Vídeo02ToolStripMenuItem
        ' 
        Vídeo02ToolStripMenuItem.Name = "Vídeo02ToolStripMenuItem"
        Vídeo02ToolStripMenuItem.Size = New Size(119, 22)
        Vídeo02ToolStripMenuItem.Text = "Vídeo 02"
        ' 
        ' JanelasToolStripMenuItem
        ' 
        JanelasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {JanelasHorizontaisToolStripMenuItem, JanelasVerticaisToolStripMenuItem, JanelasCascatasToolStripMenuItem})
        JanelasToolStripMenuItem.Name = "JanelasToolStripMenuItem"
        JanelasToolStripMenuItem.Size = New Size(56, 20)
        JanelasToolStripMenuItem.Text = "Janelas"
        ' 
        ' JanelasHorizontaisToolStripMenuItem
        ' 
        JanelasHorizontaisToolStripMenuItem.Name = "JanelasHorizontaisToolStripMenuItem"
        JanelasHorizontaisToolStripMenuItem.Size = New Size(174, 22)
        JanelasHorizontaisToolStripMenuItem.Text = "Janelas Horizontais"
        ' 
        ' JanelasVerticaisToolStripMenuItem
        ' 
        JanelasVerticaisToolStripMenuItem.Name = "JanelasVerticaisToolStripMenuItem"
        JanelasVerticaisToolStripMenuItem.Size = New Size(174, 22)
        JanelasVerticaisToolStripMenuItem.Text = "Janelas Verticais"
        ' 
        ' JanelasCascatasToolStripMenuItem
        ' 
        JanelasCascatasToolStripMenuItem.Name = "JanelasCascatasToolStripMenuItem"
        JanelasCascatasToolStripMenuItem.Size = New Size(174, 22)
        JanelasCascatasToolStripMenuItem.Text = "Janelas Cascatas"
        ' 
        ' Aula03ToolStripMenuItem
        ' 
        Aula03ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Vídeo03ToolStripMenuItem})
        Aula03ToolStripMenuItem.Name = "Aula03ToolStripMenuItem"
        Aula03ToolStripMenuItem.Size = New Size(58, 20)
        Aula03ToolStripMenuItem.Text = "Aula 03"
        ' 
        ' Vídeo03ToolStripMenuItem
        ' 
        Vídeo03ToolStripMenuItem.Name = "Vídeo03ToolStripMenuItem"
        Vídeo03ToolStripMenuItem.Size = New Size(180, 22)
        Vídeo03ToolStripMenuItem.Text = "Vídeo 03"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(490, 347)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Aula01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelasHorizontaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelasVerticaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelasCascatasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Aula02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Aula03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo03ToolStripMenuItem As ToolStripMenuItem

End Class
