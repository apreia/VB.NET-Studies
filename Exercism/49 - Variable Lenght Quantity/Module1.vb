Imports System
Imports System.Collections.Generic

Public Module VariableLengthQuantity
    ' Função para codificar números em formato VLQ
    Public Function Encode(ByVal numbers As UInteger()) As UInteger()
        Dim result As New List(Of UInteger)

        For Each number As UInteger In numbers
            Dim buffer As New Stack(Of UInteger)

            ' Enquanto o número for maior que 7 bits (127)
            Do
                Dim byteValue As UInteger = number And &H7F ' Pega os últimos 7 bits
                number >>= 7 ' Remove os últimos 7 bits
                If buffer.Count > 0 Then
                    byteValue = byteValue Or &H80 ' Define o bit 8 para bytes intermediários
                End If
                buffer.Push(byteValue)
            Loop While number > 0

            ' Adicionar os bytes empilhados ao resultado
            While buffer.Count > 0
                result.Add(buffer.Pop())
            End While
        Next

        Return result.ToArray()
    End Function

    ' Função para decodificar números do formato VLQ
    Public Function Decode(ByVal bytes As UInteger()) As UInteger()
        Dim result As New List(Of UInteger)
        Dim currentValue As UInteger = 0
        Dim isContinuation As Boolean = False

        For Each byteValue As UInteger In bytes
            currentValue = (currentValue << 7) Or (byteValue And &H7F) ' Adicionar 7 bits do byte atual

            If (byteValue And &H80) = 0 Then ' Se o bit 8 não está definido, o número terminou
                result.Add(currentValue)
                currentValue = 0
                isContinuation = False
            Else
                isContinuation = True
            End If
        Next

        ' Validar se há bytes restantes não processados
        If isContinuation Then
            Throw New InvalidOperationException("Bytes incompletos no final da entrada.")
        End If

        Return result.ToArray()
    End Function
End Module