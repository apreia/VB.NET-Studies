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
        Public Sub New(_Agencia As Integer, _numero As Integer)
            Agencia = _Agencia
            Numero = _numero

            m_TaxaOperacao = 30 / m_TotalDeContasCriadas

            m_TotalDeContasCriadas += 1
        End Sub
#End Region

#Region "MÉTODOS"
        Public Function Sacar(valorSacado As Double) As Boolean
            Dim vRetorno As Boolean

            If m_saldo < valorSacado Then
                vRetorno = False
            Else
                vRetorno = True
                m_saldo -= valorSacado
            End If

            Return vRetorno
        End Function

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