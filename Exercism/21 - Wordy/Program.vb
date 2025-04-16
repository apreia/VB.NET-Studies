Imports System

Module Program
    Sub Main()
        ' Perguntas para testar em português
        Dim questions As String() = {
            "Quanto é 5 mais 13?",
            "Quanto é 7 menos 4?",
            "Quanto é 5 vezes 6?",
            "Quanto é 20 dividido por 4?",
            "Quanto é 5 mais 13 mais 7 menos 4?"
        }

        ' Executando o método Answer para cada pergunta
        For Each question In questions
            Try
                Dim result As Integer = Wordy.Answer(question)
                Console.WriteLine($"Pergunta: {question}")
                Console.WriteLine($"Resposta: {result}")
                Console.WriteLine()
            Catch ex As ArgumentException
                Console.WriteLine($"Pergunta: {question}")
                Console.WriteLine("Resposta: Formato de pergunta inválido.")
                Console.WriteLine()
            End Try
        Next

        ' Esperar o usuário pressionar uma tecla antes de sair
        Console.ReadKey()
    End Sub
End Module
