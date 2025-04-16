Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.Json

' Classe que representa um usuário no sistema
Public Class User
    ' Nome do usuário (somente leitura)
    Public ReadOnly Property Name As String

    ' Dívidas que o usuário deve a outros usuários
    Public Property Owes As IDictionary(Of String, Double)

    ' Dívidas que outros usuários devem ao usuário
    Public Property OwedBy As IDictionary(Of String, Double)

    ' Saldo total, calculado como a soma do que é devido menos o que deve
    Public ReadOnly Property Balance As Double
        Get
            Return OwedBy.Sum(Function(x) x.Value) - Owes.Sum(Function(x) x.Value)
        End Get
    End Property

    ' Construtor para inicializar o nome do usuário e as coleções de dívidas
    Public Sub New(name As String)
        Me.Name = name
        Owes = New Dictionary(Of String, Double)()
        OwedBy = New Dictionary(Of String, Double)()
    End Sub

    ' Método para emprestar dinheiro a outro usuário
    Public Sub Lend(borrower As User, amount As Double)
        Dim remaining = amount
        ' Caso o usuário já tenha uma dívida com o emprestador
        If Owes.ContainsKey(borrower.Name) Then
            remaining = Owes(borrower.Name) - amount
            If remaining > 0 Then
                Owes(borrower.Name) = remaining
                Return
            End If

            Owes.Remove(borrower.Name)
            remaining *= -1
        End If

        ' Caso haja valor restante, ele é registrado em OwedBy
        If remaining > 0 Then
            If OwedBy.ContainsKey(borrower.Name) Then
                OwedBy(borrower.Name) += remaining
            Else
                OwedBy.Add(borrower.Name, remaining)
                OwedBy = OwedBy.OrderBy(Function(x) x.Key).ToDictionary(Function(x) x.Key, Function(x) x.Value)
            End If
        End If
    End Sub

    ' Método para pegar dinheiro emprestado de outro usuário
    Public Sub Borrow(lender As User, amount As Double)
        Dim remaining = amount
        ' Caso o usuário já tenha créditos com o emprestador
        If OwedBy.ContainsKey(lender.Name) Then
            remaining = OwedBy(lender.Name) - amount
            If remaining > 0 Then
                OwedBy(lender.Name) = remaining
                Return
            End If

            OwedBy.Remove(lender.Name)
            remaining *= -1
        End If

        ' Caso haja valor restante, ele é registrado em Owes
        If remaining > 0 Then
            If Owes.ContainsKey(lender.Name) Then
                Owes(lender.Name) += remaining
            Else
                Owes.Add(lender.Name, remaining)
                Owes = Owes.OrderBy(Function(x) x.Key).ToDictionary(Function(x) x.Key, Function(x) x.Value)
            End If
        End If
    End Sub
End Class

' Classe que simula uma API REST para gerenciar usuários e transações
Public Class RestApi
    Private ReadOnly users As IList(Of User)

    ' Inicializa a API com uma base de dados em formato JSON
    Public Sub New(database As String)
        users = JsonSerializer.Deserialize(Of List(Of User))(database)
    End Sub

    ' Lida com requisições GET
    Public Function [Get](url As String, Optional payload As String = Nothing) As String
        If Not Equals(payload, Nothing) Then
            Dim values = JsonSerializer.Deserialize(Of Dictionary(Of String, IEnumerable(Of String)))(payload)
            Dim requestedUsers = values("users")
            Return JsonSerializer.Serialize(users.Where(Function(x) requestedUsers.Contains(x.Name)))
        End If

        Return If(url = "/users", JsonSerializer.Serialize(users), "[]")
    End Function

    ' Lida com requisições POST
    Public Function Post(url As String, payload As String) As String
        If Equals(url, "/add") Then
            Dim values = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(payload)
            Dim newUser = New User(values("user"))
            users.Add(newUser)
            Return JsonSerializer.Serialize(newUser)
        ElseIf Equals(url, "/iou") Then
            Dim values = JsonSerializer.Deserialize(Of Dictionary(Of String, Object))(payload)
            Dim lender = users.First(Function(x) x.Name.Equals(values("lender").ToString()))
            Dim borrower = users.First(Function(x) x.Name.Equals(values("borrower").ToString()))
            Dim amount = Double.Parse(values("amount").ToString())
            lender.Lend(borrower, amount)
            borrower.Borrow(lender, amount)

            Return JsonSerializer.Serialize({lender, borrower}.OrderBy(Function(x) x.Name))
        End If

        Return String.Empty
    End Function
End Class