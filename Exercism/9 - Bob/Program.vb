Imports System

Module Program
    Sub Main()
        Dim bob As New Bob()

        Console.WriteLine(bob.Hey("HELLO?"))            ' Teste de pergunta gritando
        Console.WriteLine(bob.Hey("HELLO"))             ' Teste de grito
        Console.WriteLine(bob.Hey("Hello?"))            ' Teste de pergunta normal
        Console.WriteLine(bob.Hey("   "))               ' Teste de silêncio
        Console.WriteLine(bob.Hey("Just a statement"))  ' Teste de afirmação comum
        Console.WriteLine(bob.Hey("YELLING AND A ?"))   ' Teste de grito com pergunta
    End Sub
End Module