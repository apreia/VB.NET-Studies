Namespace Classes.Funcionarios
    Public Class Gerente
        Inherits Funcionario
#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"
        Public Sub New(_cpf As String, _Salario As Double)
            MyBase.New(_cpf, _Salario)
        End Sub
#End Region

#Region "MÉTODOS"
        'Overrides = substitui
        Public Overrides Function GetBonificacao() As Double
            Return salario * 0.25
        End Function

        Public Overrides Sub AumentarSalario()
            salario *= 1.03
        End Sub
#End Region
    End Class
End Namespace
