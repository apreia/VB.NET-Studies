Namespace Classes
    Public Class Cliente
#Region "PROPRIEDADES"
        Private m_cpf As String
        Public Property Cpf As String
            Get
                Return m_cpf
            End Get
            Set(value As String)
                m_cpf = value
            End Set
        End Property
        Public Property Nome As String
        Public Property Profissao As String
#End Region
    End Class
End Namespace