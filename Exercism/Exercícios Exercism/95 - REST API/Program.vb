Imports System

Module Program
    Sub Main()
        ' JSON inicial simulando a base de dados
        Dim jsonData As String = "[{""Name"":""Alice"",""Owes"":{},""OwedBy"":{}},{""Name"":""Bob"",""Owes"":{},""OwedBy"":{}}]"

        ' Inicializa a API
        Dim api As New RestApi(jsonData)

        ' Adiciona um novo usuário
        Console.WriteLine("Adicionando usuário 'Charlie':")
        Dim addPayload As String = "{""user"":""Charlie""}"
        Console.WriteLine(api.Post("/add", addPayload))

        ' Cria uma transação de empréstimo
        Console.WriteLine(vbCrLf & "Registrando IOU (Bob empresta 20 para Alice):")
        Dim iouPayload As String = "{""lender"":""Bob"",""borrower"":""Alice"",""amount"":20}"
        Console.WriteLine(api.Post("/iou", iouPayload))

        ' Lista todos os usuários
        Console.WriteLine(vbCrLf & "Listando todos os usuários:")
        Console.WriteLine(api.Get("/users"))

        ' Consultando usuários específicos
        Console.WriteLine(vbCrLf & "Consultando usuários Alice e Bob:")
        Dim getPayload As String = "{""users"":[""Alice"",""Bob""]}"
        Console.WriteLine(api.Get("/users", getPayload))

        Console.WriteLine(vbCrLf & "Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module