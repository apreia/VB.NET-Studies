Public Module Hamming
    Public Function Distance(ByVal firstStrand As String, ByVal secondStrand As String) As Integer
        ' Verifica se as sequências têm o mesmo comprimento
        If firstStrand.Length <> secondStrand.Length Then
            Throw New ArgumentException("As sequências devem ter o mesmo comprimento.")
        End If

        ' Inicializa o contador de diferenças
        Dim differences As Integer = 0

        ' Compara as duas sequências caractere por caractere
        For i As Integer = 0 To firstStrand.Length - 1
            If firstStrand(i) <> secondStrand(i) Then
                differences += 1
            End If
        Next

        ' Retorna o número de diferenças
        Return differences
    End Function
End Module