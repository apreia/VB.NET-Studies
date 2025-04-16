Imports System

Module Program
    Sub Main(args As String())
        ' Exemplo de uso da função Recite
        Dim subjects As String() = {"nail", "shoe", "horse", "rider", "message", "battle", "kingdom"}
        Dim proverb As String() = Recite(subjects)

        ' Imprime cada linha do provérbio no console
        For Each line As String In proverb
            Console.WriteLine(line)
        Next
    End Sub
End Module