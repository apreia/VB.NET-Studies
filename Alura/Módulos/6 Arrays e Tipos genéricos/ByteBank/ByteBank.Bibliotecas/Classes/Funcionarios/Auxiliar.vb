﻿Namespace Classes.Funcionarios
    Public Class Auxiliar
        Inherits Funcionario

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"
        Public Sub New(_cpf As String)
            MyBase.New(_cpf, 2000)
        End Sub
#End Region

#Region "MÉTODOS"
        'Overrides = Substitui

        Protected Friend Overrides Function GetBonificacao() As Double
            Return (salario * 0.2)
        End Function

        Public Overrides Sub AumentarSalario()
            salario = salario * 1.1
        End Sub
#End Region
    End Class
End Namespace