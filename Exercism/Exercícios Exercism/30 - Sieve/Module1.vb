Imports System

Public Module Sieve
    ' Função que retorna os números primos até o limite usando o Crivo de Eratóstenes
    Public Function Primes(ByVal limit As Integer) As Integer()
        ' Verifica se o limite é negativo e lança uma exceção
        If limit < 0 Then
            Throw New ArgumentOutOfRangeException(NameOf(limit), "O limite não pode ser um número negativo.")
        End If

        If limit < 2 Then
            Return Array.Empty(Of Integer)() ' Retorna vazio se o limite for menor que 2
        End If

        ' Criação de uma lista booleana para marcar números (True = primo, False = não primo)
        Dim isPrime As Boolean() = Enumerable.Repeat(True, limit + 1).ToArray()
        isPrime(0) = False ' 0 não é primo
        isPrime(1) = False ' 1 não é primo

        Dim sqrtLimit As Integer = Math.Sqrt(limit)

        ' Implementação do Crivo de Eratóstenes
        For i As Integer = 2 To sqrtLimit
            If isPrime(i) Then
                ' Marcar múltiplos como não primos
                For j As Integer = i * i To limit Step i
                    isPrime(j) = False
                Next
            End If
        Next

        ' Selecionar os índices marcados como True (primos)
        Dim primeList As List(Of Integer) = New List(Of Integer)()
        For i As Integer = 2 To limit
            If isPrime(i) Then
                primeList.Add(i)
            End If
        Next

        Return primeList.ToArray()
    End Function
End Module