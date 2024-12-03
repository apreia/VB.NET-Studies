Imports System
Imports System.Text

Public Module RnaTranscription
    Public Function ToRna(ByVal dna As String) As String
        ' Dicionário para mapear os nucleotídeos de DNA para RNA
        Dim dnaToRna As Dictionary(Of Char, Char) = New Dictionary(Of Char, Char) From {
            {"G"c, "C"c},
            {"C"c, "G"c},
            {"T"c, "A"c},
            {"A"c, "U"c}
        }

        ' StringBuilder para construir o RNA de forma eficiente
        Dim rna As New StringBuilder()

        ' Transcrição de cada nucleotídeo
        For Each nucleotide As Char In dna
            If dnaToRna.ContainsKey(nucleotide) Then
                rna.Append(dnaToRna(nucleotide))
            Else
                Throw New ArgumentException($"Nucleotídeo inválido encontrado: {nucleotide}")
            End If
        Next

        ' Retorna a sequência de RNA
        Return rna.ToString()
    End Function
End Module