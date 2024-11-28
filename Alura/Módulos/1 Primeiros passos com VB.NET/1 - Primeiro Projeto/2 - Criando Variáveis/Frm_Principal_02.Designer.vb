<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal_02
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
        Btm_NumerosInteiros = New Button()
        Lbl_NomeProjeto = New Label()
        Btm_PontoFlutuante = New Button()
        Btm_ConversaoNumeros = New Button()
        Txt_Numerador = New TextBox()
        Txt_Denominador = New TextBox()
        Btm_Resultado = New Button()
        Txt_ResultadoDecimal = New TextBox()
        Txt_ResultadoDouble = New TextBox()
        SuspendLayout()
        ' 
        ' Btm_NumerosInteiros
        ' 
        Btm_NumerosInteiros.Location = New Point(12, 36)
        Btm_NumerosInteiros.Name = "Btm_NumerosInteiros"
        Btm_NumerosInteiros.Size = New Size(173, 94)
        Btm_NumerosInteiros.TabIndex = 0
        Btm_NumerosInteiros.Text = "EXEMPLO NÚMEROS INTEIROS"
        Btm_NumerosInteiros.UseVisualStyleBackColor = True
        ' 
        ' Lbl_NomeProjeto
        ' 
        Lbl_NomeProjeto.AutoSize = True
        Lbl_NomeProjeto.Location = New Point(12, 9)
        Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Lbl_NomeProjeto.Size = New Size(114, 15)
        Lbl_NomeProjeto.TabIndex = 2
        Lbl_NomeProjeto.Text = "2 - Criando Variáveis"
        ' 
        ' Btm_PontoFlutuante
        ' 
        Btm_PontoFlutuante.Location = New Point(12, 136)
        Btm_PontoFlutuante.Name = "Btm_PontoFlutuante"
        Btm_PontoFlutuante.Size = New Size(173, 94)
        Btm_PontoFlutuante.TabIndex = 3
        Btm_PontoFlutuante.Text = "EXEMPLOS NÚMEROS PONTO FLUTUANTE"
        Btm_PontoFlutuante.UseVisualStyleBackColor = True
        ' 
        ' Btm_ConversaoNumeros
        ' 
        Btm_ConversaoNumeros.Location = New Point(12, 236)
        Btm_ConversaoNumeros.Name = "Btm_ConversaoNumeros"
        Btm_ConversaoNumeros.Size = New Size(173, 94)
        Btm_ConversaoNumeros.TabIndex = 4
        Btm_ConversaoNumeros.Text = "EXEMPLOS DE CONVERSÃO DE NÚMEROS"
        Btm_ConversaoNumeros.UseVisualStyleBackColor = True
        ' 
        ' Txt_Numerador
        ' 
        Txt_Numerador.Location = New Point(266, 36)
        Txt_Numerador.Name = "Txt_Numerador"
        Txt_Numerador.Size = New Size(209, 23)
        Txt_Numerador.TabIndex = 5
        ' 
        ' Txt_Denominador
        ' 
        Txt_Denominador.Location = New Point(266, 65)
        Txt_Denominador.Name = "Txt_Denominador"
        Txt_Denominador.Size = New Size(209, 23)
        Txt_Denominador.TabIndex = 6
        ' 
        ' Btm_Resultado
        ' 
        Btm_Resultado.Location = New Point(266, 94)
        Btm_Resultado.Name = "Btm_Resultado"
        Btm_Resultado.Size = New Size(209, 23)
        Btm_Resultado.TabIndex = 7
        Btm_Resultado.Text = "RESULTADO"
        Btm_Resultado.UseVisualStyleBackColor = True
        ' 
        ' Txt_ResultadoDecimal
        ' 
        Txt_ResultadoDecimal.Location = New Point(266, 136)
        Txt_ResultadoDecimal.Name = "Txt_ResultadoDecimal"
        Txt_ResultadoDecimal.Size = New Size(291, 23)
        Txt_ResultadoDecimal.TabIndex = 8
        ' 
        ' Txt_ResultadoDouble
        ' 
        Txt_ResultadoDouble.Location = New Point(266, 165)
        Txt_ResultadoDouble.Name = "Txt_ResultadoDouble"
        Txt_ResultadoDouble.Size = New Size(291, 23)
        Txt_ResultadoDouble.TabIndex = 9
        ' 
        ' Frm_Principal_02
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(683, 376)
        Controls.Add(Txt_ResultadoDouble)
        Controls.Add(Txt_ResultadoDecimal)
        Controls.Add(Btm_Resultado)
        Controls.Add(Txt_Denominador)
        Controls.Add(Txt_Numerador)
        Controls.Add(Btm_ConversaoNumeros)
        Controls.Add(Btm_PontoFlutuante)
        Controls.Add(Lbl_NomeProjeto)
        Controls.Add(Btm_NumerosInteiros)
        Name = "Frm_Principal_02"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplicação Criando Variáveis!"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btm_NumerosInteiros As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_PontoFlutuante As Button
    Friend WithEvents Btm_ConversaoNumeros As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Btm_Resultado As Button
    Friend WithEvents Txt_ResultadoDecimal As TextBox
    Friend WithEvents Txt_ResultadoDouble As TextBox

End Class