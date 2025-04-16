Imports System

Module Program
    Sub Main()
        ' Perguntas para testar em portugu�s
        Dim questions As String() = {
            "Quanto � 5 mais 13?",
            "Quanto � 7 menos 4?",
            "Quanto � 5 vezes 6?",
            "Quanto � 20 dividido por 4?",
            "Quanto � 5 mais 13 mais 7 menos 4?"
        }

        ' Executando o m�todo Answer para cada pergunta
        For Each question In questions
            Try
                Dim result As Integer = Wordy.Answer(question)
                Console.WriteLine($"Pergunta: {question}")
                Console.WriteLine($"Resposta: {result}")
                Console.WriteLine()
            Catch ex As ArgumentException
                Console.WriteLine($"Pergunta: {question}")
                Console.WriteLine("Resposta: Formato de pergunta inv�lido.")
                Console.WriteLine()
            End Try
        Next

        ' Esperar o usu�rio pressionar uma tecla antes de sair
        Console.ReadKey()
    End Sub
End Module
