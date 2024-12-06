Namespace Classes.Bibliotecas
    Public Class ClasseTeste
        Sub Teste()
            'Dim X As New ModificadoresTeste
            'X.MetodoPublico()
            'X.MetodoPrivado()
            'X.MetodoProtedigo()
            'X.MetodoInterno()
        End Sub
    End Class

    Public Class ClasseDerivada
        Inherits ModificadoresTeste
        Sub Teste2()
            MetodoProtedigo()
        End Sub
    End Class

    Public Class ModificadoresTeste
        Sub Teste()
            Dim X As New ModificadoresTeste
            X.MetodoPublico()
            X.MetodoPrivado()
            X.MetodoProtedigo()
            X.MetodoInterno()
        End Sub

        Public Sub MetodoPublico()
            ' Método acessado pela própria classe, pela classe do mesmo projeto e por classes de outros projetos.
        End Sub

        Private Sub MetodoPrivado()
            ' Método acessado pela própria classe, não é acessado pela classe do mesmo projeto e não é acessado por classes de outros projetos.
        End Sub

        Protected Sub MetodoProtedigo()
            ' Método acessado pela própria classe, não é acessado pela classe do mesmo projeto e não é acessado por classes de outros projetos.
            ' Mas pode ser acessado pelas classes derivadas.
        End Sub

        Friend Sub MetodoInterno()
            ' Método acessado pela própria classe, acessado pela classe do mesmo projeto e não é acessado por classes de outros projetos.
        End Sub
    End Class
End Namespace