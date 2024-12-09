Imports System

Public Module ArmstrongNumbers
    ''' <summary>
    ''' Determines if a given number is an Armstrong number.
    ''' </summary>
    ''' <param name="number">The number to check.</param>
    ''' <returns>True if the number is an Armstrong number; otherwise, False.</returns>
    Public Function IsArmstrongNumber(ByVal number As Integer) As Boolean
        Dim digits As String = number.ToString()
        Dim numDigits As Integer = digits.Length

        Dim sum As Integer = 0

        For Each digit As Char In digits
            Dim digitValue As Integer = Integer.Parse(digit.ToString())
            sum += CInt(Math.Pow(digitValue, numDigits))
        Next

        Return sum = number
    End Function
End Module