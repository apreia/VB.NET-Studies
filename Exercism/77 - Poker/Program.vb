Imports System

Module Program
    Sub Main(args As String())
        ' Testando as mãos de pôquer
        Dim hands As IEnumerable(Of String) = New List(Of String) From {
            "2H 3H 4H 5H 6H", ' Straight Flush
            "KH KC KS KD 10H", ' Full House
            "2S 2D 2H 3H 3D", ' Two Pair
            "AH KH QH JH TH", ' Royal Flush
            "5C 5D 5H 5S 2D"  ' Four of a Kind
        }

        Dim bestHandss = BestHands(hands)
        Console.WriteLine("Melhores Mãos:")
        For Each hand In bestHandss
            Console.WriteLine(hand)
        Next
    End Sub
End Module