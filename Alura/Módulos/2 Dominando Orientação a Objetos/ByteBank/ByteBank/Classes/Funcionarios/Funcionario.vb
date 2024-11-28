Namespace Classes.Funcionarios
    Public MustInherit Class Funcionario
#Region "PROPRIEDADES"
        Public Property Nome As String
        Private m_CPF As String
        Public ReadOnly Property Cpf As String
            Get
                Return m_CPF
            End Get
        End Property

        Private m_salario As String
        Public Property salario As String
            Get
                Return m_salario
            End Get
            Protected Set(value As String)
                m_salario = value
            End Set
        End Property

        Private Shared m_TotalDeFuncionarios As Integer
        Public Shared ReadOnly Property TotalDeFuncionarios() As Integer
            Get
                Return m_TotalDeFuncionarios
            End Get
        End Property
#End Region

#Region "CONSTRUTORES"
        Public Sub New(_cpf As String, _Salario As Double)
            m_CPF = _cpf
            m_salario = salario
            m_TotalDeFuncionarios += 1
            Console.WriteLine("CONSTRUTOR DA CLASSE FUNCIONÁRIO")
        End Sub
#End Region

#Region "MÉTODOS"
        'Overridable = substituível
        Public MustOverride Function GetBonificacao() As Double

        Public MustOverride Sub AumentarSalario()
#End Region
    End Class
End Namespace