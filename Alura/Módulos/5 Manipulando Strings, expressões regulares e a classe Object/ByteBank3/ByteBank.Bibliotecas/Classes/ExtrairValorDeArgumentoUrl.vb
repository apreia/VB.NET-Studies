Namespace Classes
    Public Class ExtrairValorDeArgumentoUrl
#Region "PROPRIEDADES"
        Public ReadOnly Property Url As String
        Public ReadOnly Property Argumento As String
        Private ReadOnly Property Dominio As String
#End Region

#Region "CONSTRUTORES"
        Public Sub New(urlString As String)
            If String.IsNullOrEmpty(urlString) Then
                Throw New ArgumentException("URL possue valor vazio ou nulo", NameOf(urlString))
            End If

            Url = urlString

            Dim posicaoInterrogacao As Integer
            posicaoInterrogacao = urlString.IndexOf("?")
            Argumento = urlString.Substring(posicaoInterrogacao + 1)
            Dominio = "https://www.bytebank.com.br"
        End Sub
#End Region

#Region "MÉTODOS"
        Public Function GetValor(propriedade As String) As String
            Dim vPropriedade As String = propriedade + "="

            Dim vIndex As Integer = Argumento.ToUpper.IndexOf(vPropriedade.ToUpper)

            Dim vValor As String

            If vIndex = -1 Then
                vValor = ""
            Else
                vIndex += vPropriedade.Length

                Dim vArgumentoParcial As String = Argumento.Substring(vIndex)

                Dim vIndex2 As Integer = vArgumentoParcial.IndexOf("&")

                If vIndex2 = -1 Then
                    vValor = vArgumentoParcial
                Else
                    vValor = vArgumentoParcial.Remove(vIndex2)
                End If
            End If

            Return vValor
        End Function

        Public Function IsByteBank() As Boolean
            Return Url.ToLower.StartsWith(Dominio)
        End Function
#End Region
    End Class
End Namespace