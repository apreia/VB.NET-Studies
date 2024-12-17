Namespace Classes.Clientes
    Public Class ContaCorrente

#Region "PROPRIEDADES"
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

        Public Property titular As Cliente

        Public ReadOnly Property numero As Integer

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

        Public ReadOnly Property agencia As Integer

        Private m_saldo As Double = 100
        Public Property saldo As Double
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

                Dim Erro As New ArgumentException("Código da agência menor que zero !!!!", vParametro)
                Throw Erro

            ElseIf (NumeroConta <= 0) Then

                Dim vParametro As String
                vParametro = NameOf(NumeroConta)

                Dim Erro As New ArgumentException("Número da conta menor que zero !!!!", vParametro)
                Throw Erro

            End If

            agencia = CodigoAgencia
            numero = NumeroConta
            m_TotalDeContasCriadas += 1

            m_TaxaOperacao = 30 / m_TotalDeContasCriadas
        End Sub
#End Region

#Region "MÉTODOS"
        Public Sub Sacar(ValorSacado As Double, ValorLabel As String)

            If ValorSacado < 0 Then
                m_NumeroSaquesErrados += 1
                Throw New ArgumentException("Valor " + ValorLabel + " é negativo. " + ValorSacado.ToString, NameOf(ValorSacado))
            End If

            If m_saldo < ValorSacado Then
                Dim vMensagem As String
                vMensagem = "Valor " + ValorLabel + " é maior que o saldo"
                m_NumeroSaquesErrados += 1
                Throw New ValorSacadoMenorSaldoException(ValorSacado, m_saldo, vMensagem)
            Else
                m_saldo -= ValorSacado
            End If
        End Sub

        Public Sub Depositar(ValorDepositado As Double)
            m_saldo += ValorDepositado
        End Sub

        Public Sub Transferir(ValorTransferencia As Double, ContaDestino As ContaCorrente)
            Try
                Sacar(ValorTransferencia, "da transferencia")
            Catch ex As ValorSacadoMenorSaldoException
                m_NumeroTransferenciasErradas += 1
                Throw New OperacaoFinanceiraException("Operação não realizada", ex)

            Catch ex As ArgumentException
                m_NumeroTransferenciasErradas += 1
                Throw

            End Try
            ContaDestino.Depositar(ValorTransferencia)
        End Sub

        Public Overrides Function ToString() As String
            'Dim X As String = "Agencia: " + agencia.ToString + " e Conta: " + numero.ToString + " e o saldo atual é: " + saldo.ToString

            Dim X As String = $"Agencia: {agencia} e Conta {numero} e o saldo atual é {saldo}"
            Return X
        End Function
#End Region
    End Class
End Namespace