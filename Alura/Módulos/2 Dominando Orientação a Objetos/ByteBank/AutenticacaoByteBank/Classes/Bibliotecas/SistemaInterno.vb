Imports AutenticacaoByteBank.Classes.Externos
Imports AutenticacaoByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas
    Public Class SistemaInterno
        Public Function Logar(Entidade As IAutentica, senhaTentativa As String)
            Dim vRetorno As Boolean
            vRetorno = Entidade.Autenticar(senhaTentativa)
            Return vRetorno
        End Function
    End Class
End Namespace