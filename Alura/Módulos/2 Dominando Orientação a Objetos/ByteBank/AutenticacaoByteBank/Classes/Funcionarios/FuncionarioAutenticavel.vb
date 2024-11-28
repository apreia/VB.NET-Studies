Namespace Classes.Funcionarios
    Public MustInherit Class FuncionarioAutenticavel
        Inherits Funcionario
#Region "PROPRIEDADES"
        Public Property Senha As String
#End Region

#Region "CONSTRUTORES"
        Public Sub New(_cpf As String, _Salario As Double)
            MyBase.New(_cpf, _Salario)
        End Sub
#End Region

#Region "MÉTODOS"
        Public Function Autenticar(senhaTentativa) As Boolean
            If Senha = senhaTentativa Then
                Return True
            End If

            Return False
        End Function
#End Region
    End Class
End Namespace