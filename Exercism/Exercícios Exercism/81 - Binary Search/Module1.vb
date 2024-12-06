Imports System

Public Module BinarySearch
    Public Function Find(ByVal input As Integer(), ByVal value As Integer) As Integer
        Dim low As Integer = 0
        Dim high As Integer = input.Length - 1

        While low <= high
            ' Encontra o índice do elemento do meio
            Dim mid As Integer = (low + high) \ 2

            ' Compara o valor do meio com o valor procurado
            If input(mid) = value Then
                Return mid ' Encontrou o valor, retorna o índice
            ElseIf input(mid) < value Then
                low = mid + 1 ' Elimina a metade esquerda da lista
            Else
                high = mid - 1 ' Elimina a metade direita da lista
            End If
        End While

        ' Se o loop terminar sem encontrar o valor, retorna -1 (não encontrado)
        Return -1
    End Function
End Module