Namespace Classes.Clientes
    Public Class Cliente

#Region "PROPRIEDADES"
        Public Property nome As String
        Public Property cpf As String
        Public Property profissao As String
#End Region

#Region "CONSTRUTORES"

#End Region

#Region "MÉTODOS"
        Public Overrides Function Equals(obj As Object) As Boolean
            Dim outroCliente As New Cliente()
            outroCliente = TryCast(obj, Cliente)

            If outroCliente Is Nothing Then
                Return False
            End If

            Return (nome = outroCliente.nome) And (cpf = outroCliente.cpf) And (profissao = outroCliente.profissao)
        End Function
#End Region

#Region "FUNÇÕES ESPECIAIS"

#End Region
    End Class
End Namespace