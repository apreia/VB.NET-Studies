Imports System

Public Module Series
    Public Function Slices(ByVal numbers As String, ByVal sliceLength As Integer) As String()
        ' Verificar se a sequência está vazia
        If String.IsNullOrEmpty(numbers) Then
            Throw New ArgumentException("Input string cannot be empty.")
        End If

        ' Verificar se o sliceLength é menor ou igual a zero
        If sliceLength <= 0 Then
            Throw New ArgumentException("Slice length must be greater than zero.")
        End If

        ' Verificar se o sliceLength é maior que o comprimento da sequência
        If sliceLength > numbers.Length Then
            Throw New ArgumentException("Slice length cannot be greater than the length of the input string.")
        End If

        ' Lista para armazenar as subsequências
        Dim result As New List(Of String)()

        ' Percorrer a string e extrair as subsequências
        For i As Integer = 0 To numbers.Length - sliceLength
            result.Add(numbers.Substring(i, sliceLength))
        Next

        ' Converter a lista para um array e retornar
        Return result.ToArray()
    End Function
End Module