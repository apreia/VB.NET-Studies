Public Class Frm_Principal_05
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Lbl_NomeProjeto.Text = "5 - Laços de Repetição"
        Text = "Aplicação Laços de Repetição"
        Lbl_Principal.Text = "Valor investido"
        Lbl_Rendimento.Text = "Juros (%)"
        Btm_While.Text = "Calcular valor usando WHILE"
        Btm_For.Text = "Calcular valor usando FOR"
        Lbl_Periodos.Text = "Períodos"
        Grp_Grupo1.Text = "Cálculo de investimento por WHILE e por FOR"
        Grp_Grupo2.Text = "Cálculo do investimento anual"

        Lbl_Principal2.Text = "Valor investido"
        Lbl_Rendimento2.Text = "Juros mensais(%)"
        Lbl_Anos.Text = "Anos aplicados"
        Lbl_AcrescimoRendimento.Text = "Acréscimo Juros (%)"
        Btm_Calcula.Text = "Efetua cálculo"
        Lbl_Limite.Text = "Limite"
    End Sub

    Private Sub Btm_While_Click(sender As Object, e As EventArgs) Handles Btm_While.Click
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim contador As Integer = 1
        Dim extrato As String = ""

        While contador <= periodos
            investimento += (investimento * (rendimento / 100))
            extrato += "O saldo do investimento no mês " + contador.ToString + " é " + investimento.ToString + vbCrLf
            contador += 1
        End While

        Txt_Extrato_While.Text = extrato

        ''----------Exercício a parte----------''

        'Dim Contador As Integer = 1
        'Dim Saida As String = ""

        'While Contador <= 10
        '    Saida += " - " + Contador.ToString
        '    Contador += 1
        'End While
        'MsgBox(Saida)

        ''-------------------------------------''
    End Sub

    Private Sub Btm_For_Click(sender As Object, e As EventArgs) Handles Btm_For.Click
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim extrato As String = ""

        For i As Integer = 1 To periodos
            investimento += (investimento * (rendimento / 100))
            extrato += "O saldo do investimento no mês " + i.ToString + " é " + investimento.ToString + vbCrLf
        Next

        Txt_Extrato_For.Text = extrato

        ''----------Exercício a parte----------''

        'Dim Saida As String = ""

        'For i As Integer = 1 To 10
        '    Saida += " - " + i.ToString
        'Next
        'MsgBox(Saida)

        ''-------------------------------------''
    End Sub

    Private Sub Btm_Calcula_Click(sender As Object, e As EventArgs) Handles Btm_Calcula.Click
        Dim investimento As Double = Val(Txt_Principal2.Text)
        Dim rendimento As Double = Val(Txt_Rendimento2.Text)
        Dim anos As Integer = Val(Txt_Anos.Text)
        Dim acrescimoJuros As Double = Val(Txt_AcrescimoRendimento.Text)
        Dim limite As Double = Val(Txt_Limite.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1
        Dim ExecutouExitFor As Boolean = False

        For i As Integer = 1 To anos
            For j As Integer = 1 To 12
                investimento += (investimento * (rendimento / 100))
                extrato += "O saldo do investimento no mês " + contador.ToString + " é " + investimento.ToString + " usando a taxa " + rendimento.ToString + " % mês " + vbCrLf

                If investimento >= limite Then
                    ExecutouExitFor = True
                    extrato += "O investimento atingiu o limite" + vbCrLf
                    Exit For
                End If

                contador += 1
            Next
            If ExecutouExitFor Then
                Exit For
            End If

            rendimento += (rendimento * acrescimoJuros / 100)
        Next
        Txt_Resultado.Text = extrato

        ''----------Exercício a parte----------''

        'Dim resultado As String = ""

        'For i As Integer = 1 To 3
        '    For j As Integer = 1 To 10
        '        resultado += "O número " + i.ToString + " X " + j.ToString + " é " + (i * j).ToString + vbCrLf
        '    Next
        'Next
        'MsgBox(resultado)

        ''-------------------------------------''
    End Sub
End Class