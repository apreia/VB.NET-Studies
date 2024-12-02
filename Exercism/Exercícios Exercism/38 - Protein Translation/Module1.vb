Imports System
Imports System.Collections.Generic

Public Module ProteinTranslation
    Public Function Proteins(ByVal strand As String) As String()
        ' Dicionário para mapear códons a proteínas
        Dim codonToProtein As New Dictionary(Of String, String) From {
            {"AUG", "Methionine"},
            {"UUU", "Phenylalanine"},
            {"UUC", "Phenylalanine"},
            {"UUA", "Leucine"},
            {"UUG", "Leucine"},
            {"UCU", "Serine"},
            {"UCC", "Serine"},
            {"UCA", "Serine"},
            {"UCG", "Serine"},
            {"UAU", "Tyrosine"},
            {"UAC", "Tyrosine"},
            {"UGU", "Cysteine"},
            {"UGC", "Cysteine"},
            {"UGG", "Tryptophan"},
            {"UAA", "STOP"},
            {"UAG", "STOP"},
            {"UGA", "STOP"}
        }

        ' Lista para armazenar os resultados da tradução
        Dim proteinsList As New List(Of String)()

        ' Dividir a cadeia de RNA em códons de 3 bases
        For i As Integer = 0 To strand.Length - 1 Step 3
            Dim codon As String = strand.Substring(i, 3)

            ' Se for um códon de parada, termina a tradução
            If codonToProtein(codon) = "STOP" Then
                Exit For
            End If

            ' Adiciona o aminoácido correspondente
            proteinsList.Add(codonToProtein(codon))
        Next

        ' Retorna o resultado como um array de strings
        Return proteinsList.ToArray()
    End Function
End Module