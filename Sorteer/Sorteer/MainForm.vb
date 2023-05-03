Public Class MainForm
    ' Auteur: Sabawoon Enayat
    ' Sorteer Algorithmes staan in de Sort.vb file

    ' Beschrijving:
    ' Bij opstart worden er unieke 10000 getallen in een array gestoken worden
    ' Zodra je op de `Sorteer` knop drukt,
    ' worden er 5 functies geroepen die de bijhorende sorteer-algorithme
    ' toepassen en de getallen laten zien in een listbox
    ' Er wordt ook onder elke listbox laten zien, hoeveel tijd elke
    ' algorithme nodig had om de array te sorteren

    ' Pakt een beetje tijd om de applicatie op te starten
    ' omdat er 10000 getallen in een array worden toegevoegd

    Dim getallen(9999) As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim rnd As Random = New Random()
        ' Genereer random getallen en voeg die toe aan de array `getallen`
        For i = 0 To getallen.Length - 1
            Dim randomGetal As Integer
            ' Zorg ervoor dat de array, het nieuw gegenereerde getal niet bevat
            Do
                randomGetal = rnd.Next(1, getallen.Length + 1)
            Loop While getallen.Contains(randomGetal)
            getallen(i) = randomGetal

            ' Laat de getallen in de listboxes zien
            lstSelection.Items.Add(randomGetal.ToString())
            lstBubble.Items.Add(randomGetal.ToString())
            lstRipple.Items.Add(randomGetal.ToString())
            lstInsertion.Items.Add(randomGetal.ToString())
            lstMerge.Items.Add(randomGetal.ToString())
        Next
    End Sub

    Private Sub btnSorteer_Click(sender As Object, e As EventArgs) Handles btnSorteer.Click
        ShowSelection()
        ShowBubble()
        ShowRipple()
        ShowInsertion()
        ShowMerge()
    End Sub

    Private Sub ShowSelection()
        ' Maak een nieuwe array zodat `getallen` niet verandert
        Dim getallenSelection As Integer() = getallen.ToArray()
        Dim beginTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
        Sort.Selection(getallenSelection)
        Dim endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()

        lstSelection.Items.Clear()
        For Each getal In getallenSelection
            lstSelection.Items.Add(getal.ToString())
        Next
        lblTijdSelection.Text = (endTime - beginTime).ToString() & "ms"
    End Sub

    Private Sub ShowBubble()
        ' Maak een nieuwe array zodat `getallen` niet verandert
        Dim getallenBubble As Integer() = getallen.ToArray()
        Dim beginTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
        Sort.Bubble(getallenBubble)
        Dim endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()

        lstBubble.Items.Clear()
        For Each getal In getallenBubble
            lstBubble.Items.Add(getal.ToString())
        Next
        lblTijdBubble.Text = (endTime - beginTime).ToString() & "ms"
    End Sub

    Private Sub ShowRipple()
        ' Maak een nieuwe array zodat `getallen` niet verandert
        Dim getallenRipple As Integer() = getallen.ToArray()
        Dim beginTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
        Sort.Ripple(getallenRipple)
        Dim endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()

        lstRipple.Items.Clear()
        For Each getal In getallenRipple
            lstRipple.Items.Add(getal.ToString())
        Next
        lblTijdRipple.Text = (endTime - beginTime).ToString() & "ms"
    End Sub

    Private Sub ShowInsertion()
        ' Maak een nieuwe array zodat `getallen` niet verandert
        Dim getallenInsertion As Integer() = getallen.ToArray()
        Dim beginTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
        Sort.Ripple(getallenInsertion)
        Dim endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()

        lstInsertion.Items.Clear()
        For Each getal In getallenInsertion
            lstInsertion.Items.Add(getal.ToString())
        Next
        lblTijdInsertion.Text = (endTime - beginTime).ToString() & "ms"
    End Sub

    Private Sub ShowMerge()
        ' Maak een nieuwe array zodat `getallen` niet verandert
        Dim getallenMerge As Integer() = getallen.ToArray()
        Dim beginTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
        Sort.Ripple(getallenMerge)
        Dim endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()

        lstMerge.Items.Clear()
        For Each getal In getallenMerge
            lstMerge.Items.Add(getal.ToString())
        Next
        lblTijdMerge.Text = (endTime - beginTime).ToString() & "ms"
    End Sub
End Class
