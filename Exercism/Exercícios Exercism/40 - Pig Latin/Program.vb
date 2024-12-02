Imports System

Module Program
    Sub Main()
        ' Testando a tradução de palavras para Pig Latin
        Console.WriteLine(PigLatin.Translate("apple"))     ' appleay
        Console.WriteLine(PigLatin.Translate("xray"))      ' xrayay
        Console.WriteLine(PigLatin.Translate("yttria"))    ' yttriaay
        Console.WriteLine(PigLatin.Translate("pig"))       ' igpay
        Console.WriteLine(PigLatin.Translate("chair"))     ' airchay
        Console.WriteLine(PigLatin.Translate("thrush"))    ' ushthray
        Console.WriteLine(PigLatin.Translate("quick"))     ' ickquay
        Console.WriteLine(PigLatin.Translate("square"))    ' aresquay
        Console.WriteLine(PigLatin.Translate("my"))        ' ymay
        Console.WriteLine(PigLatin.Translate("rhythm"))    ' ythmrhay

        ' Testando frase completa
        Console.WriteLine(PigLatin.Translate("the quick brown fox")) ' ethay ickquay ownbray oxfay
    End Sub
End Module