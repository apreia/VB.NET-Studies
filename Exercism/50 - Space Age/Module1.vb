Imports System

Public Class SpaceAge
    Private ReadOnly _seconds As Double
    Private Const EarthYearInSeconds As Double = 31557600 ' Segundos em um ano terrestre

    ' Tabela de períodos orbitais em relação ao ano terrestre
    Private Shared ReadOnly OrbitalPeriods As Dictionary(Of String, Double) = New Dictionary(Of String, Double) From {
        {"Mercury", 0.2408467},
        {"Venus", 0.61519726},
        {"Earth", 1.0},
        {"Mars", 1.8808158},
        {"Jupiter", 11.862615},
        {"Saturn", 29.447498},
        {"Uranus", 84.016846},
        {"Neptune", 164.79132}
    }

    ' Construtor que valida os segundos
    Public Sub New(ByVal seconds As Integer)
        If seconds < 0 Then
            Throw New ArgumentException("O número de segundos não pode ser negativo.")
        End If
        _seconds = seconds
    End Sub

    ' Método genérico para calcular a idade em um planeta
    Private Function AgeOnPlanet(ByVal planet As String) As Double
        Dim orbitalPeriod As Double
        If Not OrbitalPeriods.TryGetValue(planet, orbitalPeriod) Then
            Throw New ArgumentException($"Planeta inválido: {planet}")
        End If
        Return Math.Round(_seconds / (EarthYearInSeconds * orbitalPeriod), 2) ' Arredonda para 2 casas decimais
    End Function

    ' Métodos públicos para cada planeta
    Public Function OnEarth() As Double
        Return AgeOnPlanet("Earth")
    End Function

    Public Function OnMercury() As Double
        Return AgeOnPlanet("Mercury")
    End Function

    Public Function OnVenus() As Double
        Return AgeOnPlanet("Venus")
    End Function

    Public Function OnMars() As Double
        Return AgeOnPlanet("Mars")
    End Function

    Public Function OnJupiter() As Double
        Return AgeOnPlanet("Jupiter")
    End Function

    Public Function OnSaturn() As Double
        Return AgeOnPlanet("Saturn")
    End Function

    Public Function OnUranus() As Double
        Return AgeOnPlanet("Uranus")
    End Function

    Public Function OnNeptune() As Double
        Return AgeOnPlanet("Neptune")
    End Function
End Class