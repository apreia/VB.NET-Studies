Imports System

Module Program
    Sub Main(args As String())
        ' Testando a fun��o IsIsogram
        Console.WriteLine(Isogram.IsIsogram("lenhadores")) ' True
        Console.WriteLine(Isogram.IsIsogram("fundo")) ' True
        Console.WriteLine(Isogram.IsIsogram("rio abaixo")) ' True
        Console.WriteLine(Isogram.IsIsogram("seis anos de idade")) ' True
        Console.WriteLine(Isogram.IsIsogram("isogramas")) ' False (repeti��o do "s")
    End Sub
End Module