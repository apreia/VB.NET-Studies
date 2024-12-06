Imports ByteBank.Bibliotecas.Classes.Bibliotecas

Namespace Classes.Externos

    Public Class Representante
        Implements IAutenticavel

#Region "PROPRIEDADES"
        Public Property Senha As String

        Private autenticacao As New AutenticacaoHelper()

#End Region

#Region "MÉTODOS"
        Public Function Autenticar(senhaTentativa As String) As Boolean Implements IAutenticavel.Autenticar
            Return autenticacao.Autenticar(senhaTentativa, Senha)
        End Function
#End Region
    End Class
End Namespace