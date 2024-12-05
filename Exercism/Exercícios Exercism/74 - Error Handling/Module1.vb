Imports System
Imports System.Runtime.InteropServices

Public Module ErrorHandling
    ' Lança uma exceção genérica conforme esperado pelos testes
    Public Sub HandleErrorByThrowingException()
        Throw New Exception("An error occurred while processing the request.")
    End Sub

    ' Retorna um valor nulo em caso de erro ao converter string para número
    Public Function HandleErrorByReturningNullableType(ByVal input As String) As Integer?
        Try
            Return Convert.ToInt32(input)
        Catch ex As FormatException
            Return Nothing
        End Try
    End Function

    ' Usa um parâmetro de saída para lidar com o erro
    Public Function HandleErrorWithOutParam(ByVal input As String, <Out> ByRef result As Integer) As Boolean
        Try
            result = Convert.ToInt32(input)
            Return True
        Catch ex As FormatException
            result = 0
            Return False
        End Try
    End Function

    ' Garante que o objeto descartável seja liberado e lança a exceção esperada
    Public Sub DisposableResourcesAreDisposedWhenExceptionIsThrown(ByVal disposableObject As IDisposable)
        Try
            ' Simula uma operação que pode lançar uma exceção
            Throw New Exception("An error occurred during operation.")
        Finally
            ' Garante que o objeto descartável seja liberado
            disposableObject.Dispose()
        End Try
    End Sub
End Module