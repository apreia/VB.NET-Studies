Imports System

Module Program
    Sub Main()
        ' Criando uma inst�ncia da escola
        Dim school As New GradeSchool()

        ' Adicionando alunos
        Console.WriteLine(school.Add("Anna", 1)) ' Deve retornar True (adicionado com sucesso)
        Console.WriteLine(school.Add("Barb", 1)) ' Deve retornar True (adicionado com sucesso)
        Console.WriteLine(school.Add("Charlie", 1)) ' Deve retornar True (adicionado com sucesso)
        Console.WriteLine(school.Add("Alex", 2)) ' Deve retornar True (adicionado com sucesso)
        Console.WriteLine(school.Add("Peter", 2)) ' Deve retornar True (adicionado com sucesso)
        Console.WriteLine(school.Add("Zoe", 2)) ' Deve retornar True (adicionado com sucesso)
        Console.WriteLine(school.Add("Jim", 5)) ' Deve retornar True (adicionado com sucesso)
        Console.WriteLine(school.Add("Anna", 1)) ' Deve retornar False (j� existe na s�rie)

        ' Mostrando todos os alunos
        Console.WriteLine("Alunos matriculados:")
        For Each student In school.Roster()
            Console.WriteLine(student)
        Next

        ' Mostrar alunos da 1� s�rie
        Console.WriteLine(vbCrLf & "Alunos da 1� s�rie:")
        For Each student In school.Grade(1)
            Console.WriteLine(student)
        Next

        ' Mostrar alunos da 2� s�rie
        Console.WriteLine(vbCrLf & "Alunos da 2� s�rie:")
        For Each student In school.Grade(2)
            Console.WriteLine(student)
        Next

        ' Mostrar alunos da 5� s�rie
        Console.WriteLine(vbCrLf & "Alunos da 5� s�rie:")
        For Each student In school.Grade(5)
            Console.WriteLine(student)
        Next

        ' Mostrar alunos de uma s�rie n�o existente
        Console.WriteLine(vbCrLf & "Alunos da 3� s�rie:")
        For Each student In school.Grade(3)
            Console.WriteLine(student)
        Next
    End Sub
End Module