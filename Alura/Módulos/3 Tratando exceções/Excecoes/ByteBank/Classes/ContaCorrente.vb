Namespace Classes
    Public Class ContaCorrente
#Region "PROPRIEDADES"
        Public Property Titular As Cliente

        Public ReadOnly Property Numero As Integer

        Private Shared m_TaxaOperacao As Integer
        Public Shared ReadOnly Property TaxaOperacao As Integer
            Get
                Return m_TaxaOperacao
            End Get
        End Property

        Private Shared m_TotalDeContasCriadas As Integer
        Public Shared ReadOnly Property TotalDeContasCriadas As Integer
            Get
                Return m_TotalDeContasCriadas
            End Get
        End Property

        Public ReadOnly Property Agencia As Integer

        Private m_saldo As Double = 100
        Public Property Saldo As Double
            Get
                Return m_saldo
            End Get
            Set(value As Double)
                If value <= 0 Then
                    m_saldo = 0
                Else
                    m_saldo = value
                End If
            End Set
        End Property
#End Region

#Region "CONSTRUTORES"
        Public Sub New(CodigoAgencia As Integer, NumeroConta As Integer)
            If (CodigoAgencia <= 0) Then
                Dim vParametro As String
                vParametro = NameOf(CodigoAgencia)

                Dim Erro As New ArgumentException("Código da agencia menor que zero", vParametro)
                Throw Erro

            ElseIf (NumeroConta <= 0) Then
                Dim vParametro As String
                vParametro = NameOf(NumeroConta)

                Dim Erro As New ArgumentException("Código da conta menor que zero", vParametro)
                Throw Erro
            End If

            Agencia = CodigoAgencia
            Numero = NumeroConta

            m_TotalDeContasCriadas += 1
            m_TaxaOperacao = 30 / m_TotalDeContasCriadas
        End Sub
#End Region

#Region "MÉTODOS"
        Public Sub Sacar(valorSacado As Double)
            If m_saldo < valorSacado Then
                Dim x As Integer = 1
                Dim y As Integer = 0
                Dim z As Integer = x / y

                Throw New Exception("Valor a ser sacado é maior que o saldo")
            Else
                m_saldo -= valorSacado
            End If
        End Sub

        Public Sub Depositar(valorDepositado As Double)
            m_saldo += valorDepositado
        End Sub

        Public Function Transferir(valorTransferencia As Double, ContaDestino As ContaCorrente) As Boolean
            Dim vRetorno As Boolean

            If m_saldo < valorTransferencia Then
                vRetorno = False
            Else
                vRetorno -= valorTransferencia
                ContaDestino.Depositar(valorTransferencia)
                vRetorno = True
            End If

            Return True
        End Function
#End Region
    End Class
End Namespace