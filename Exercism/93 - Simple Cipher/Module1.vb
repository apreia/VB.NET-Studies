Imports System
Imports System.Linq
Imports System.Text

Public Class SimpleCipher
    ' Define o alfabeto utilizado na cifra
    Private Const Alphabet As String = "abcdefghijklmnopqrstuvwxyz"

    ' Gerador de números aleatórios para criar chaves automáticas
    Private Shared ReadOnly Rand As New Random()

    ' Propriedade somente leitura que contém a chave de criptografia
    Public ReadOnly Property Key As String

    ' Construtor padrão que gera uma chave aleatória de 100 caracteres
    Public Sub New()
        Key = New String(Enumerable.Range(0, 100).[Select](Function(x) Alphabet(Rand.Next(Alphabet.Length))).ToArray())
    End Sub

    ' Construtor sobrecarregado que permite definir uma chave personalizada
    Public Sub New(ByVal key As String)
        Me.Key = key
    End Sub

    ' Método para codificar o texto em texto cifrado
    Public Function Encode(ByVal plaintext As String) As String
        Dim ciphertext = New StringBuilder(plaintext.Length)

        ' Itera sobre cada caractere do texto e aplica a codificação
        For i = 0 To plaintext.Length - 1
            ciphertext.Append(EncodeCharacter(plaintext, i))
        Next

        Return ciphertext.ToString()
    End Function

    ' Codifica um único caractere com base no índice do texto e da chave
    Private Function EncodeCharacter(ByVal plaintext As String, ByVal idx As Integer) As Char
        Dim alphabetIdx = Alphabet.IndexOf(plaintext(idx)) + Alphabet.IndexOf(Key(idx Mod Key.Length))
        ' Ajusta o índice se ultrapassar o tamanho do alfabeto
        If alphabetIdx >= Alphabet.Length Then alphabetIdx -= Alphabet.Length
        Return Alphabet(alphabetIdx)
    End Function

    ' Método para decodificar um texto cifrado em texto original
    Public Function Decode(ByVal ciphertext As String) As String
        Dim plaintext = New StringBuilder(ciphertext.Length)

        ' Itera sobre cada caractere do texto cifrado e aplica a decodificação
        For i = 0 To ciphertext.Length - 1
            plaintext.Append(DecodeCharacter(ciphertext, i))
        Next

        Return plaintext.ToString()
    End Function

    ' Decodifica um único caractere com base no índice do texto cifrado e da chave
    Private Function DecodeCharacter(ByVal ciphertext As String, ByVal idx As Integer) As Char
        Dim alphabetIdx = Alphabet.IndexOf(ciphertext(idx)) - Alphabet.IndexOf(Key(idx Mod Key.Length))
        ' Ajusta o índice se ficar abaixo de zero
        If alphabetIdx < 0 Then alphabetIdx += Alphabet.Length
        Return Alphabet(alphabetIdx)
    End Function
End Class