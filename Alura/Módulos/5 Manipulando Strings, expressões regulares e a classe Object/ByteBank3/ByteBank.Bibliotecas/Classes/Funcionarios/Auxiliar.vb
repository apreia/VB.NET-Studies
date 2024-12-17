Namespace Classes.Funcionarios
    Public Class Auxiliar
        Inherits Funcionario

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"
        Public Sub New(_cpf As String)
            MyBase.New(_cpf, 2000)
        End Sub
#End Region

#Region "MÉTODOS"
        'Overrides = Substitui

        Public Overrides Function GetBonificacao() As Double
            Return (salario * 0.2)
        End Function

        Public Overrides Sub AumentarSalario()
            salario = salario * 1.1
        End Sub

        Public Overrides Function ToString() As String
            Dim X As String = "Esta é uma classe do tipo Auxiliar"
            Return X
        End Function
#End Region
    End Class
End Namespace