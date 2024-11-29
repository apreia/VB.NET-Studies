Namespace Classes.Externos
    Public Class Representante
        Implements IAutentica
#Region "PROPRIEDADES"
        Public Property Senha As String
#End Region

#Region "MÉTODOS"
        Public Function Autenticar(senhaTentativa) As Boolean Implements IAutentica.Autenticar
            If Senha = senhaTentativa Then
                Return True
            End If

            Return False
        End Function
#End Region

    End Class
End Namespace
