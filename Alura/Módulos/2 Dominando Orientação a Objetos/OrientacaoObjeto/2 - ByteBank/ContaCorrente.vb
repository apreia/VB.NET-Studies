Imports _2___ByteBank.ByteBannk

Public Class ContaCorrente
#Region "CONSTRUTORES"
    Public Sub New(m_Saldo As Double)
        Saldo = m_Saldo
    End Sub
#End Region

#Region "PROPRIEDADES"
    Public m_Titular As Cliente
    Public Property Titular As Cliente
        Get
            Return m_Titular
        End Get
        Set(value As Cliente)
            m_Titular = value
        End Set
    End Property

    Private m_Agencia As Integer
    Public Property Agencia As Integer
        Get
            Return m_Agencia
        End Get
        Set(value As Integer)
            m_Agencia = value
        End Set
    End Property

    Private m_Conta As Integer
    Public Property Conta As Integer
        Get
            Return m_Conta
        End Get
        Set(value As Integer)
            m_Conta = value
        End Set
    End Property

    Private m_Extrato As String
    Public Property Extrato As String
        Get
            Return m_Extrato
        End Get
        Set(value As String)
            m_Extrato = value
        End Set
    End Property

    Private m_Saldo As Double = 100
    Public Property Saldo As Double
        Get
            Return m_Saldo
        End Get
        Set(value As Double)
            If value < 0 Then
                m_Saldo = 0
            Else
                m_Saldo = value
            End If
        End Set
    End Property
#End Region

#Region "MÉTODOS"
    Public Function Sacar(ValorSacar As Double) As Boolean
        Dim Retorno As Boolean

        If m_Saldo < ValorSacar Then
            Retorno = False
        Else
            m_Saldo -= ValorSacar
            Retorno = True
        End If
        Return Retorno
    End Function

    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean
        Dim Retorno As Boolean

        If m_Saldo < ValorTransferencia Then
            Retorno = False
        Else
            m_Saldo -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If

        Return Retorno
    End Function

    Public Sub Depositar(ValoDepositar As Double)
        m_Saldo += ValoDepositar
    End Sub
#End Region

#Region "FUNÇÕES ESPECIAIS"

#End Region
End Class