Imports System

Module Program
    Public Sub Main()
        ' Teste do HandleErrorByThrowingExceptionMethod
        Try
            ErrorHandling.HandleErrorByThrowingException()
        Catch ex As Exception
            Console.WriteLine("Exceção capturada (HandleErrorByThrowingExceptionMethod): " & ex.Message)
        End Try

        ' Teste do HandleErrorByReturningNullableType
        Dim result As Integer? = ErrorHandling.HandleErrorByReturningNullableType("42")
        If result.HasValue Then
            Console.WriteLine("Valor retornado (HandleErrorByReturningNullableType): " & result.Value)
        Else
            Console.WriteLine("Valor inválido retornado.")
        End If

        ' Teste do HandleErrorWithOutParam
        Dim outResult As Integer
        If ErrorHandling.HandleErrorWithOutParam("100", outResult) Then
            Console.WriteLine("Valor com 'out' (HandleErrorWithOutParam): " & outResult)
        Else
            Console.WriteLine("Falha ao processar o valor com 'out'.")
        End If

        ' Teste do DisposableResourcesAreDisposedWhenExceptionIsThrownMethod
        Try
            ' Usando um objeto IDisposable embutido no próprio código
            Using disposableObject As New System.IO.MemoryStream()
                ErrorHandling.DisposableResourcesAreDisposedWhenExceptionIsThrown(disposableObject)
            End Using
        Catch ex As Exception
            Console.WriteLine("Exceção capturada (DisposableResourcesAreDisposedWhenExceptionIsThrownMethod): " & ex.Message)
        End Try
    End Sub
End Module