Imports System

Module Program
    Sub Main()
        Console.WriteLine(MatchingBrackets.IsPaired("{what is (42)}?")) ' True
        Console.WriteLine(MatchingBrackets.IsPaired("[text}"))         ' False
        Console.WriteLine(MatchingBrackets.IsPaired("({[]})"))        ' True
        Console.WriteLine(MatchingBrackets.IsPaired("{[}]"))          ' False
    End Sub
End Module
