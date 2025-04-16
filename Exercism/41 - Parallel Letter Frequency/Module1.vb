Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

Public Module ParallelLetterFrequency
    Public Function Calculate(ByVal texts As IEnumerable(Of String)) As Dictionary(Of Char, Integer)
        ' Dicionário para armazenar a contagem de letras
        Dim frequency As New Dictionary(Of Char, Integer)()

        ' Usando o Parallel.ForEach para processar os textos em paralelo
        Parallel.ForEach(texts, Sub(text)
                                    ' Processa cada caractere no texto
                                    For Each c As Char In text
                                        ' Verifica se o caractere é uma letra
                                        If Char.IsLetter(c) Then
                                            ' Converte o caractere para minúsculo para contagem insensível a maiúsculas/minúsculas
                                            Dim lowerChar As Char = Char.ToLower(c)

                                            ' Adiciona a contagem ou incrementa a contagem existente
                                            SyncLock frequency
                                                If frequency.ContainsKey(lowerChar) Then
                                                    frequency(lowerChar) += 1
                                                Else
                                                    frequency(lowerChar) = 1
                                                End If
                                            End SyncLock
                                        End If
                                    Next
                                End Sub)

        ' Retorna o dicionário com a contagem de letras
        Return frequency
    End Function
End Module