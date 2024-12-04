Imports System.Linq

Public Module FoodChain
    ' Define o número total de versos na música.
    Private Const Verses As Integer = 8

    ' Define os sujeitos (animais) envolvidos nos versos, exceto o "fly" e o "horse".
    Private ReadOnly Subjects As String() = {"spider", "bird", "cat", "dog", "goat", "cow"}

    ' Define os trechos adicionais únicos para cada animal.
    Private ReadOnly FollowUps As String() = {
        "It wriggled and jiggled and tickled inside her.",
        "How absurd to swallow a bird!",
        "Imagine that, to swallow a cat!",
        "What a hog, to swallow a dog!",
        "Just opened her throat and swallowed a goat!",
        "I don't know how she swallowed a cow!"
    }

    ' Define o histórico cumulativo para os versos, em ordem inversa.
    Private ReadOnly History As String() = {
        "I don't know how she swallowed a cow!",
        "She swallowed the cow to catch the goat.",
        "She swallowed the goat to catch the dog.",
        "She swallowed the dog to catch the cat.",
        "She swallowed the cat to catch the bird.",
        "She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.",
        "She swallowed the spider to catch the fly.",
        "I don't know why she swallowed the fly. Perhaps she'll die."
    }

    ' Gera um verso específico da música.
    Public Function Recite(ByVal verseNumber As Integer) As String
        ' Chama a função de recitação para um único verso.
        Return Recite(verseNumber, verseNumber)
    End Function

    ' Gera uma sequência de versos da música.
    Public Function Recite(ByVal startVerse As Integer, ByVal endVerse As Integer) As String
        ' Itera pelos versos desejados e os concatena com uma quebra de linha dupla.
        Return String.Join(vbLf & vbLf, Enumerable.Range(startVerse, endVerse - startVerse + 1).Select(Function(i) $"{VerseBegin(i)}
{VerseEnd(i)}"))
    End Function

    ' Constrói o início de um verso com base no número.
    Private Function VerseBegin(ByVal number As Integer) As String
        ' O primeiro verso sempre menciona a "fly".
        If number = 1 Then
            Return "I know an old lady who swallowed a fly."
        End If

        ' O último verso menciona a "horse".
        If number = 8 Then
            Return "I know an old lady who swallowed a horse."
        End If

        ' Para outros versos, busca o sujeito e o trecho adicional.
        Dim subject = Subjects(number - 2)
        Dim followUp = FollowUps(number - 2)
        Return $"I know an old lady who swallowed a {subject}.
{followUp}"
    End Function

    ' Constrói o final de um verso com base no número.
    Private Function VerseEnd(ByVal number As Integer) As String
        ' O último verso termina com "She's dead, of course!".
        If number = 8 Then
            Return "She's dead, of course!"
        End If

        ' Gera a parte cumulativa do verso.
        Return String.Join(vbLf, History.Skip(History.Length - number).Take(number))
    End Function
End Module