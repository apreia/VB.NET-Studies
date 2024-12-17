<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PaginaWeb
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
        Lbl_URL = New Label()
        Txt_URL = New TextBox()
        Btm_URL = New Button()
        Wb_Pagina = New Microsoft.Web.WebView2.WinForms.WebView2()
        Grp_URL = New GroupBox()
        Btm_Propriedade = New Button()
        Grp_WebBrowser = New GroupBox()
        CType(Wb_Pagina, ComponentModel.ISupportInitialize).BeginInit()
        Grp_URL.SuspendLayout()
        Grp_WebBrowser.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lbl_URL
        ' 
        Lbl_URL.AutoSize = True
        Lbl_URL.Location = New Point(6, 19)
        Lbl_URL.Name = "Lbl_URL"
        Lbl_URL.Size = New Size(41, 15)
        Lbl_URL.TabIndex = 0
        Lbl_URL.Text = "Label1"
        ' 
        ' Txt_URL
        ' 
        Txt_URL.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Txt_URL.Location = New Point(6, 40)
        Txt_URL.Multiline = True
        Txt_URL.Name = "Txt_URL"
        Txt_URL.ScrollBars = ScrollBars.Vertical
        Txt_URL.Size = New Size(817, 66)
        Txt_URL.TabIndex = 1
        ' 
        ' Btm_URL
        ' 
        Btm_URL.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btm_URL.Location = New Point(667, 15)
        Btm_URL.Name = "Btm_URL"
        Btm_URL.Size = New Size(75, 23)
        Btm_URL.TabIndex = 2
        Btm_URL.Text = "Button1"
        Btm_URL.UseVisualStyleBackColor = True
        ' 
        ' Wb_Pagina
        ' 
        Wb_Pagina.AllowExternalDrop = True
        Wb_Pagina.CreationProperties = Nothing
        Wb_Pagina.DefaultBackgroundColor = Color.White
        Wb_Pagina.Dock = DockStyle.Fill
        Wb_Pagina.Location = New Point(3, 19)
        Wb_Pagina.Name = "Wb_Pagina"
        Wb_Pagina.Size = New Size(823, 317)
        Wb_Pagina.TabIndex = 3
        Wb_Pagina.ZoomFactor = 1R
        ' 
        ' Grp_URL
        ' 
        Grp_URL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Grp_URL.Controls.Add(Btm_Propriedade)
        Grp_URL.Controls.Add(Txt_URL)
        Grp_URL.Controls.Add(Lbl_URL)
        Grp_URL.Controls.Add(Btm_URL)
        Grp_URL.Location = New Point(12, 12)
        Grp_URL.Name = "Grp_URL"
        Grp_URL.Size = New Size(829, 112)
        Grp_URL.TabIndex = 4
        Grp_URL.TabStop = False
        Grp_URL.Text = "GroupBox1"
        ' 
        ' Btm_Propriedade
        ' 
        Btm_Propriedade.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btm_Propriedade.Location = New Point(748, 15)
        Btm_Propriedade.Name = "Btm_Propriedade"
        Btm_Propriedade.Size = New Size(75, 23)
        Btm_Propriedade.TabIndex = 3
        Btm_Propriedade.Text = "Button1"
        Btm_Propriedade.UseVisualStyleBackColor = True
        ' 
        ' Grp_WebBrowser
        ' 
        Grp_WebBrowser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Grp_WebBrowser.Controls.Add(Wb_Pagina)
        Grp_WebBrowser.Location = New Point(12, 130)
        Grp_WebBrowser.Name = "Grp_WebBrowser"
        Grp_WebBrowser.Size = New Size(829, 339)
        Grp_WebBrowser.TabIndex = 5
        Grp_WebBrowser.TabStop = False
        Grp_WebBrowser.Text = "GroupBox1"
        ' 
        ' Frm_PaginaWeb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 481)
        Controls.Add(Grp_WebBrowser)
        Controls.Add(Grp_URL)
        Name = "Frm_PaginaWeb"
        Text = "Frm_PaginaWeb"
        CType(Wb_Pagina, ComponentModel.ISupportInitialize).EndInit()
        Grp_URL.ResumeLayout(False)
        Grp_URL.PerformLayout()
        Grp_WebBrowser.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Btm_URL As Button
    Friend WithEvents Wb_Pagina As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Grp_URL As GroupBox
    Friend WithEvents Grp_WebBrowser As GroupBox
    Friend WithEvents Btm_Propriedade As Button
End Class
