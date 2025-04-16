Imports System

Module Program
    Sub Main()
        ' JSON inicial simulando a base de dados
        Dim jsonData As String = "[{""Name"":""Alice"",""Owes"":{},""OwedBy"":{}},{""Name"":""Bob"",""Owes"":{},""OwedBy"":{}}]"

        ' Inicializa a API
        Dim api As New RestApi(jsonData)

        ' Adiciona um novo usu�rio
        Console.WriteLine("Adicionando usu�rio 'Charlie':")
        Dim addPayload As String = "{""user"":""Charlie""}"
        Console.WriteLine(api.Post("/add", addPayload))

        ' Cria uma transa��o de empr�stimo
        Console.WriteLine(vbCrLf & "Registrando IOU (Bob empresta 20 para Alice):")
        Dim iouPayload As String = "{""lender"":""Bob"",""borrower"":""Alice"",""amount"":20}"
        Console.WriteLine(api.Post("/iou", iouPayload))

        ' Lista todos os usu�rios
        Console.WriteLine(vbCrLf & "Listando todos os usu�rios:")
        Console.WriteLine(api.Get("/users"))

        ' Consultando usu�rios espec�ficos
        Console.WriteLine(vbCrLf & "Consultando usu�rios Alice e Bob:")
        Dim getPayload As String = "{""users"":[""Alice"",""Bob""]}"
        Console.WriteLine(api.Get("/users", getPayload))

        Console.WriteLine(vbCrLf & "Pressione qualquer tecla para sair...")
        Console.ReadKey()
    End Sub
End Module