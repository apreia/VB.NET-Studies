Imports System
Imports System.Linq

Public Class Robot
    ' Armazenar os nomes já gerados para garantir exclusividade
    Private Shared _usedNames As New HashSet(Of String)()
    Private _name As String

    ' Propriedade para obter o nome do robô
    Public ReadOnly Property Name As String
        Get
            ' Se o nome não foi gerado, cria um novo nome aleatório
            If _name Is Nothing Then
                GenerateName()
            End If
            Return _name
        End Get
    End Property

    ' Método para redefinir o robô, apagando seu nome e gerando um novo
    Public Sub Reset()
        _name = Nothing ' Apaga o nome atual
        GenerateName()  ' Gera um novo nome aleatório
    End Sub

    ' Método privado para gerar um nome aleatório único
    Private Sub GenerateName()
        ' Garante que o nome gerado seja único
        Dim random As New Random()
        Dim newName As String

        Do
            ' Gera um nome aleatório no formato XX### (XX: letras maiúsculas, ###: números)
            newName = Chr(random.Next(65, 91)) & Chr(random.Next(65, 91)) & random.Next(100, 1000).ToString()
        Loop While _usedNames.Contains(newName) ' Garante que o nome não foi utilizado antes

        ' Armazena o nome gerado
        _usedNames.Add(newName)
        _name = newName
    End Sub
End Class