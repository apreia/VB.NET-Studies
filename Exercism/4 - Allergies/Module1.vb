Public Class Allergies
    Private ReadOnly _score As Integer
    Private ReadOnly _allergens As Dictionary(Of String, Integer)

    Public Sub New(score As Integer)
        _score = score
        _allergens = New Dictionary(Of String, Integer) From {
            {"eggs", 1},
            {"peanuts", 2},
            {"shellfish", 4},
            {"strawberries", 8},
            {"tomatoes", 16},
            {"chocolate", 32},
            {"pollen", 64},
            {"cats", 128}
        }
    End Sub

    Public Function AllergicTo(allergy As String) As Boolean
        If _allergens.ContainsKey(allergy.ToLower()) Then
            Dim allergenScore As Integer = _allergens(allergy.ToLower())
            Return (_score And allergenScore) = allergenScore
        End If
        Return False
    End Function

    Public Function List() As IList(Of String)
        Dim allergies As New List(Of String)
        For Each allergen In _allergens
            If (_score And allergen.Value) = allergen.Value Then
                allergies.Add(allergen.Key)
            End If
        Next
        Return allergies
    End Function
End Class