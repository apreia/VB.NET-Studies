Public Class Predio
    Implements IAbrirPorta
    Public Function AbrirPorta() As String Implements IAbrirPorta.AbrirPorta
        Return "Porta abriu do prédio"
    End Function
End Class