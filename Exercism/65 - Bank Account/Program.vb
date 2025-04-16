Imports System

Module Program
    Sub Main()
        ' Criando uma inst�ncia da conta banc�ria.
        Dim conta As New BankAccount()

        ' Abrindo a conta.
        conta.Open()
        Console.WriteLine("Conta aberta.")

        ' Realizando um dep�sito de 100 unidades.
        conta.UpdateBalance(100)
        Console.WriteLine("Saldo ap�s dep�sito de 100: " & conta.Balance)

        ' Realizando um saque de 50 unidades.
        conta.UpdateBalance(-50)
        Console.WriteLine("Saldo ap�s saque de 50: " & conta.Balance)

        ' Tentando acessar o saldo de uma conta fechada.
        conta.Close()
        Console.WriteLine("Conta fechada.")

        Try
            ' Tentando acessar o saldo de uma conta fechada (isso vai gerar uma exce��o).
            Console.WriteLine("Tentando acessar o saldo de uma conta fechada: " & conta.Balance)
        Catch ex As InvalidOperationException
            ' Captura da exce��o se a conta estiver fechada.
            Console.WriteLine("Erro: " & ex.Message)
        End Try
    End Sub
End Module