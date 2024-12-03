Imports System

Module Program
    Sub Main()
        Dim meetup1 As New Meetup(8, 1953) ' Agosto de 1953
        Dim teenthSaturday As Date = meetup1.Day(DayOfWeek.Saturday, Schedule.Teenth)
        Console.WriteLine($"Décimo sábado de agosto de 1953: {teenthSaturday:dd/MM/yyyy}")

        Dim firstMonday As Date = meetup1.Day(DayOfWeek.Monday, Schedule.First)
        Console.WriteLine($"Primeira segunda-feira de agosto de 1953: {firstMonday:dd/MM/yyyy}")

        Dim lastThursday As Date = meetup1.Day(DayOfWeek.Thursday, Schedule.Last)
        Console.WriteLine($"Última quinta-feira de agosto de 1953: {lastThursday:dd/MM/yyyy}")

        Dim secondTuesday As Date = meetup1.Day(DayOfWeek.Tuesday, Schedule.Second)
        Console.WriteLine($"Segunda terça-feira de agosto de 1953: {secondTuesday:dd/MM/yyyy}")

        ' Teste adicional
        Dim meetup2 As New Meetup(11, 2023) ' Novembro de 2023
        Dim thirdWednesday As Date = meetup2.Day(DayOfWeek.Wednesday, Schedule.Third)
        Console.WriteLine($"Terceira quarta-feira de novembro de 2023: {thirdWednesday:dd/MM/yyyy}")
    End Sub
End Module