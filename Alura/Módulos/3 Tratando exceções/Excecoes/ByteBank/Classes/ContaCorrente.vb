Imports System.Globalization

Namespace Classes
    Public Class ContaCorrente
#Region "PROPRIEDADES"
        Public Property Titular As Cliente

        Public ReadOnly Property Numero As Integer

        Private m_NumeroSaquesErrados As Integer
        Public Property NumeroSaquesErrados As Integer
            Get
                Return m_NumeroSaquesErrados
            End Get
            Private Set(value As Integer)
                m_NumeroSaquesErrados = value
            End Set
        End Property

        Private m_NumeroTransferenciasErradas As Integer
        Public Property NumeroTransferenciasErradas As Integer
            Get
                Return m_NumeroTransferenciasErradas
            End Get
            Private Set(value As Integer)
                m_NumeroTransferenciasErradas = value
            End Set
        End Property

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
        Public Sub Sacar(valorSacado As Double, ValorLabel As String)
            If valorSacado < 0 Then
                m_NumeroSaquesErrados += 1
                Throw New ArgumentException("Valor " + ValorLabel + " é negativo. " + valorSacado.ToString, NameOf(valorSacado))
            End If

            If m_saldo < valorSacado Then
                Dim vMensagem As String
                vMensagem = "Valor " + ValorLabel + " é maior que o saldo"

                m_NumeroSaquesErrados += 1
                Throw New ValorSacadoMenorSaldoException(valorSacado, m_saldo, vMensagem)
            Else
                m_saldo -= valorSacado
            End If
        End Sub

        Public Sub Depositar(valorDepositado As Double)
            m_saldo += valorDepositado
        End Sub

        Public Sub Transferir(valorTransferencia As Double, ContaDestino As ContaCorrente)
            Try
                Sacar(valorTransferencia, "da transferencia")
            Catch ex As ValorSacadoMenorSaldoException
                m_NumeroTransferenciasErradas += 1
                Throw New OperacaoFinanceiraException("Operação Inválida", ex)

            Catch ex As ArgumentException
                m_NumeroTransferenciasErradas += 1
                Throw

            End Try

            ContaDestino.Depositar(valorTransferencia)
        End Sub
#End Region
    End Class
End Namespace