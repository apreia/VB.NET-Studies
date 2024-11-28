Namespace Classes.Funcionarios
    Public Class Diretor
        Inherits Funcionario
#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"
        Public Sub New(_cpf As String, _Salario As Double)
            MyBase.New(_cpf, _Salario)
        End Sub
#End Region

#Region "MÉTODOS"
        Public Overrides Function GetBonificacao() As Double
            Return (salario * 0.5)
        End Function

        Public Overrides Sub AumentarSalario()
            salario *= 1.15
        End Sub
#End Region
    End Class
End Namespace