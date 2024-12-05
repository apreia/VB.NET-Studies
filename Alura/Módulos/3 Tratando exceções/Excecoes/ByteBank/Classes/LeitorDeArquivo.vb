Imports System.IO

Namespace Classes
    Public Class LeitorDeArquivo
        Implements IDisposable
#Region "PROPRIEDADES"
        Public Property Status As String
        Public ReadOnly Property NomeArquivo As String
        Public Property ConteudoArquivo As String
#End Region

#Region "CONTRUTOR"
        Public Sub New(_Arquivo As String)
            NomeArquivo = _Arquivo

            Throw New FileNotFoundException()
            Console.WriteLine("ABRIINDO ARQUIVO")

            Status = "ABERTO"
            ConteudoArquivo = ""
        End Sub
#End Region

#Region "MÉTODOS"
        Public Sub LeituraLinha()
            'Throw New IOException

            Console.WriteLine("LENDO LINHA...")
            ConteudoArquivo += "Leitura de Linha..." + vbCrLf
            Status = "ABERTO"
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            FecharArquivo()
        End Sub

        Sub FecharArquivo()
            Console.WriteLine("FECHANDO ARQUIVO")
            Status = "FECHADO"
        End Sub
#End Region
    End Class
End Namespace
