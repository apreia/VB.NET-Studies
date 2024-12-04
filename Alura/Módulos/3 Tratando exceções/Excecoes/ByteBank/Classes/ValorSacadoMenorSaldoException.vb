Namespace Classes
    Public Class ValorSacadoMenorSaldoException
        Inherits Exception
#Region "PROPRIEDADES"
        Public ReadOnly Property ValorSacado As Double
        Public ReadOnly Property Saldo As Double
#End Region

#Region "CONSTRUTORES"
        Sub New()

        End Sub

        Sub New(_ValorSacado As Double, _Saldo As Double, Message As String)
            Me.New(Message)
            ValorSacado = _ValorSacado
            Saldo = _Saldo
        End Sub

        Sub New(message As String)
            MyBase.New(message)

            ' Algum tipo de implementação
        End Sub
    End Class
#End Region
End Namespace