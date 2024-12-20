Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Text = "Principal"
        Lbl_Principal.Text = "Principal"
        Btm_Principal.Text = "Clique Aqui"
        Btm_Principal2.Text = "Clique Aqui"
        Btm_Principal3.Text = "Clique Aqui"
        Btm_Principal4.Text = "Clique Aqui"
        Btm_Principal5.Text = "Clique Aqui"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click
        Dim Idade(3) As Integer
        Idade(0) = 30
        Idade(1) = 30
        Idade(2) = 20
        Idade(3) = 25

        Dim vPosicoes As Integer = Idade.Length

        Dim media As Double

        For i As Integer = 0 To vPosicoes - 1
            media += Idade(i)
        Next

        media = media / vPosicoes

        Dim Idade2(3) As Integer
        Idade2(0) = 30
        Idade2(1) = 30
        Idade2(2) = 20
        Idade2(3) = 25

        Dim vPosicoes2 As Integer = Idade.Length

        Dim vSomaArray As Integer = Idade2.Sum
        Dim media2 As Double = vSomaArray / vPosicoes2

        Dim Idade3(3) As Integer
        Idade3(0) = 30
        Idade3(1) = 30
        Idade3(2) = 20
        Idade3(3) = 25

        Dim media3 As Double = Idade3.Average

        Dim vFirst As Double = Idade3.First
        Dim vLast As Double = Idade3.Last
        Dim vMax As Double = Idade3.Max
        Dim vMin As Double = Idade3.Min

        MsgBox(media)
        MsgBox(media2)
        MsgBox(media3)
    End Sub

    Private Sub Btm_Principal2_Click(sender As Object, e As EventArgs) Handles Btm_Principal2.Click
        Dim Contas() As ContaCorrente
        Contas = {New ContaCorrente(111, 11111), New ContaCorrente(222, 22222), New ContaCorrente(333, 33333),
                  New ContaCorrente(444, 44444)}

        For i As Integer = 0 To Contas.Length - 1
            Dim ContaAtual As ContaCorrente = Contas(i)
            Dim vNumero As Integer = ContaAtual.Numero
            MsgBox(vNumero)
        Next

        Contas = {New ContaCorrente(111, 11111), New ContaCorrente(222, 22222), New ContaCorrente(333, 33333),
                  New ContaCorrente(444, 44444), New ContaCorrente(555, 55555)}

        For i As Integer = 0 To Contas.Length - 1
            Dim ContaAtual As ContaCorrente = Contas(i)
            Dim vNumero As Integer = ContaAtual.Numero
            MsgBox(vNumero)
        Next
    End Sub

    Private Sub Btm_Principal3_Click(sender As Object, e As EventArgs) Handles Btm_Principal3.Click
        Dim Lista As New ListaDeContasCorrentes(10)

        Lista.MeuMetodo(10)

        Lista.Adicionar(New ContaCorrente(111, 11111))
        Lista.Adicionar(New ContaCorrente(222, 22222))
        Lista.Adicionar(New ContaCorrente(333, 33333))
        Lista.Adicionar(New ContaCorrente(444, 44444))
        Lista.Adicionar(New ContaCorrente(555, 55555))
        Lista.Adicionar(New ContaCorrente(666, 66666))

        Dim vPosicao As Integer = Lista.PosicaoElemento(New ContaCorrente(777, 77777))
        MsgBox(vPosicao)
    End Sub

    Private Sub Btm_Principal4_Click(sender As Object, e As EventArgs) Handles Btm_Principal4.Click
        Dim Lista As New ListaDeObjects()

        Lista.Adicionar(12)
        Lista.Adicionar(13)
        Lista.Adicionar(15)
        Lista.AdicionarVariosUmAUm(12, 15, 14, 13, 18, 20)

        Dim soma As Integer

        For i As Integer = 0 To Lista.tamanho - 1
            soma += Lista(i)
        Next

        MsgBox(soma)

        Dim Lista2 As New ListaDeObjects()

        Lista2.Adicionar("a1")
        Lista2.Adicionar("a2")
        Lista2.Adicionar("a3")
        Lista2.AdicionarVariosUmAUm("a4", "a5", "a6", "a7")

        Dim somaStr As String = ""

        For i As Integer = 0 To Lista2.tamanho - 1
            somaStr += Lista2(i)
        Next

        MsgBox(somaStr)

        Dim Lista3 As New ListaDeObjects()

        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.AdicionarVariosUmAUm(New ContaCorrente(1, 1), New ContaCorrente(1, 1), New ContaCorrente(1, 1), New ContaCorrente(1, 1))

        Dim somaStr2 As String = ""

        For i As Integer = 0 To Lista3.tamanho - 1
            Dim ContaAtual As ContaCorrente = TryCast(Lista3(i), ContaCorrente)
            somaStr2 += ContaAtual.Agencia.ToString + " - " + ContaAtual.Numero.ToString + " ; "
        Next

        MsgBox(somaStr2)
    End Sub

    Private Sub Btm_Principal5_Click(sender As Object, e As EventArgs) Handles Btm_Principal5.Click
        Dim Lista As New Lista(Of Integer)

        Lista.Adicionar(12)
        Lista.Adicionar(13)
        Lista.Adicionar(15)
        Lista.AdicionarVariosUmAUm(12, 15, 14, 13, 18, 20)

        Dim soma As Integer

        For i As Integer = 0 To Lista.tamanho - 1
            soma += Lista(i)
        Next

        MsgBox(soma)

        Dim Lista2 As New Lista(Of String)

        Lista2.Adicionar("a1")
        Lista2.Adicionar("a2")
        Lista2.Adicionar("a3")
        Lista2.AdicionarVariosUmAUm("a4", "a5", "a6", "a7")

        Dim somaStr As String = ""

        For i As Integer = 0 To Lista2.tamanho - 1
            somaStr += Lista2(i)
        Next

        MsgBox(somaStr)

        Dim Lista3 As New Lista(Of ContaCorrente)

        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.AdicionarVariosUmAUm(New ContaCorrente(1, 1), New ContaCorrente(1, 1), New ContaCorrente(1, 1), New ContaCorrente(1, 1))

        Dim somaStr2 As String = ""

        For i As Integer = 0 To Lista3.tamanho - 1
            Dim ContaAtual As ContaCorrente = TryCast(Lista3(i), ContaCorrente)
            somaStr2 += ContaAtual.Agencia.ToString + " - " + ContaAtual.Numero.ToString + " ; "
        Next

        MsgBox(somaStr2)
    End Sub
End Class