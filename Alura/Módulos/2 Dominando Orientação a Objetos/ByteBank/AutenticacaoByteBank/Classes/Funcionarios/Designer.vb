Namespace Classes.Funcionarios
    Public Class Designer
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
            Return (Salario * 0.17)
        End Function

        Public Overrides Sub AumentarSalario()
            Salario *= 1.11
        End Sub
#End Region
    End Class
End Namespace

