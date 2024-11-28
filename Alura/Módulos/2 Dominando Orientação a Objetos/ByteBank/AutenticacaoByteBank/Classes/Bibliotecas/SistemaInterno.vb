Imports AutenticacaoByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas
    Public Class SistemaInterno
        Public Function Logar(Funcionario As FuncionarioAutenticavel, senhaTentativa As String)
            Dim vRetorno As Boolean
            vRetorno = Funcionario.Autenticar(senhaTentativa)
            Return vRetorno
        End Function
    End Class
End Namespace