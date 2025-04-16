Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq

Public Class LedgerEntry
    Public Sub New(ByVal [date] As Date, ByVal desc As String, ByVal chg As Decimal)
        Me.DateProp = [date] ' Corrigido para usar DateProp
        Me.Desc = desc
        Me.Chg = chg
    End Sub

    Public ReadOnly Property DateProp As Date ' Corrigido para DateProp
    Public ReadOnly Property Desc As String
    Public ReadOnly Property Chg As Decimal
End Class

Public Module Ledger
    Public Function CreateEntry(ByVal [date] As String, ByVal desc As String, ByVal chng As Integer) As LedgerEntry
        Return New LedgerEntry(Date.Parse([date], CultureInfo.InvariantCulture), desc, chng / 100D)
    End Function

    Private Function CreateCulture(ByVal cur As String, ByVal loc As String) As CultureInfo
        ' Validar moeda e local
        If Not {"USD", "EUR"}.Contains(cur) Then
            Throw New ArgumentException("Invalid currency")
        End If

        If Not {"nl-NL", "en-US"}.Contains(loc) Then
            Throw New ArgumentException("Invalid locale")
        End If

        ' Definir símbolos e formatos com base na moeda e local
        Dim culture = New CultureInfo(loc)
        Select Case cur
            Case "USD"
                culture.NumberFormat.CurrencySymbol = "$"
                culture.DateTimeFormat.ShortDatePattern = If(loc = "en-US", "MM/dd/yyyy", "dd/MM/yyyy")
                culture.NumberFormat.CurrencyNegativePattern = If(loc = "nl-NL", 12, 0)

            Case "EUR"
                culture.NumberFormat.CurrencySymbol = "€"
                culture.DateTimeFormat.ShortDatePattern = If(loc = "en-US", "MM/dd/yyyy", "dd/MM/yyyy")
                culture.NumberFormat.CurrencyNegativePattern = If(loc = "nl-NL", 12, 0)
        End Select

        Return culture
    End Function

    Private Function PrintHead(ByVal loc As String) As String
        If loc = "en-US" Then
            Return "Date       | Description               | Change       "
        ElseIf loc = "nl-NL" Then
            Return "Datum      | Omschrijving              | Verandering  "
        Else
            Throw New ArgumentException("Invalid locale")
        End If
    End Function

    Private Function FormatDate(ByVal culture As IFormatProvider, ByVal [date] As Date) As String
        Return [date].ToString("d", culture)
    End Function

    Private Function FormatDescription(ByVal desc As String) As String
        Return If(desc.Length > 25, desc.Substring(0, 22) & "...", desc)
    End Function

    Private Function FormatChange(ByVal culture As IFormatProvider, ByVal chg As Decimal) As String
        Return chg.ToString("C", culture) & If(chg < 0, "", " ")
    End Function

    Private Function PrintEntry(ByVal culture As IFormatProvider, ByVal entry As LedgerEntry) As String
        Dim formattedDate = FormatDate(culture, entry.DateProp) ' Corrigido para DateProp
        Dim formattedDesc = FormatDescription(entry.Desc)
        Dim formattedChange = FormatChange(culture, entry.Chg)

        Return $"{formattedDate} | {String.Format("{0,-25}", formattedDesc)} | {String.Format("{0,13}", formattedChange)}"
    End Function

    Private Function SortEntries(ByVal entries As LedgerEntry()) As IEnumerable(Of LedgerEntry)
        Return entries.OrderBy(Function(e) e.DateProp).ThenBy(Function(e) e.Desc).ThenBy(Function(e) e.Chg)
    End Function

    Public Function Format(ByVal currency As String, ByVal locale As String, ByVal entries As LedgerEntry()) As String
        Dim formatted = PrintHead(locale)
        Dim culture = CreateCulture(currency, locale)

        If entries.Any() Then
            Dim sortedEntries = SortEntries(entries)

            For Each entry In sortedEntries
                formatted &= vbLf & PrintEntry(culture, entry)
            Next
        End If

        Return formatted
    End Function
End Module