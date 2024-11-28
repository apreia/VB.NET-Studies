Public Class Casa
    Implements IAbrirPorta
    Public Function AbrirPorta() As String Implements IAbrirPorta.AbrirPorta
        Return "Porta abriu da casa"
    End Function
End Class