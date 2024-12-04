Imports System

Public Class BankAccount
    ' Objeto para sincronização, garantindo acesso exclusivo entre threads.
    Private ReadOnly _lock As Object = New Object()

    ' Campo privado que armazena o saldo da conta.
    Private balanceField As Decimal

    ' Indica se a conta está aberta ou fechada.
    Private isOpen As Boolean

    ' Método para abrir a conta.
    Public Sub Open()
        SyncLock _lock
            ' Define que a conta foi aberta.
            isOpen = True
        End SyncLock
    End Sub

    ' Método para fechar a conta.
    Public Sub Close()
        SyncLock _lock
            ' Define que a conta foi fechada.
            isOpen = False
        End SyncLock
    End Sub

    ' Propriedade somente leitura que retorna o saldo da conta.
    Public ReadOnly Property Balance As Decimal
        Get
            SyncLock _lock
                ' Se a conta não estiver aberta, lança uma exceção.
                If Not isOpen Then
                    Throw New InvalidOperationException("Não é possível obter o saldo de uma conta fechada")
                End If

                ' Retorna o saldo atual da conta.
                Return balanceField
            End SyncLock
        End Get
    End Property

    ' Método para atualizar o saldo da conta (depósito ou saque).
    Public Sub UpdateBalance(ByVal change As Decimal)
        SyncLock _lock
            ' Se a conta não estiver aberta, lança uma exceção.
            If Not isOpen Then
                Throw New InvalidOperationException("Não é possível atualizar o saldo de uma conta fechada")
            End If

            ' Atualiza o saldo com o valor de mudança (positivo ou negativo).
            balanceField += change
        End SyncLock
    End Sub
End Class