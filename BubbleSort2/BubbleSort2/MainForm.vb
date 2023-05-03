Imports System.Windows.Forms.VisualStyles

Public Class MainForm
    Dim getallen(19) As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rnd = New Random()
        For i = 0 To getallen.Length - 1
            getallen(i) = rnd.Next(0, 19)
        Next
        LaatGetallenZien()
    End Sub

    Private Sub btnSorteer_Click(sender As Object, e As EventArgs) Handles btnSorteer.Click
        BubbleSort2(getallen)
    End Sub

    Private Sub BubbleSort2(ByRef arr As Integer())
        Dim aantalDoorgangen As Integer = 0
        Dim aantalSwaps As Integer = 0
        Dim begin As Integer = 0
        Dim einde As Integer = arr.Length - 1

        Dim swapped As Boolean = True

        While swapped
            swapped = False
            lstGetallen.Items.Add("Left -> Right: " & begin.ToString() & " To " & (einde - 1).ToString())
            For i = begin To einde - 1
                If arr(i) > arr(i + 1) Then
                    SwapWithNext(arr, i)
                    swapped = True
                    aantalSwaps += 1
                End If
                aantalDoorgangen += 1
                LaatGetallenZien()
            Next
            If Not swapped Then
                Exit While
            End If

            swapped = False
            einde -= 1

            lstGetallen.Items.Add("Left <- Right: " & einde.ToString() & " To " & (begin).ToString())
            For i = einde - 1 To begin Step -1
                If arr(i) > arr(i + 1) Then
                    SwapWithNext(arr, i)
                    swapped = True
                    aantalSwaps += 1
                End If
                aantalDoorgangen += 1
                LaatGetallenZien()
            Next
            begin += 1
        End While

        lstGetallen.Items.Add("")
        lstGetallen.Items.Add("")
        lstGetallen.Items.Add("Gesorteerde Array:")
        LaatGetallenZien()
        lstGetallen.Items.Add("")
        lstGetallen.Items.Add("Aantal Doorgangen: " & aantalDoorgangen.ToString())
        lstGetallen.Items.Add("Aantal Swaps: " & aantalSwaps.ToString())
    End Sub

    Sub SwapWithNext(ByRef arr As Integer(), ByVal i As Integer)
        Dim temp As Integer = arr(i)
        arr(i) = arr(i + 1)
        arr(i + 1) = temp
    End Sub

    Private Sub LaatGetallenZien()
        Dim getallenString = ""
        For Each getal In getallen
            getallenString &= "      " & getal.ToString()
        Next
        lstGetallen.Items.Add(getallenString)
        TekenBerg()
    End Sub

    Private Sub TekenBerg()
        Dim berg = ""

        For i = 0 To getallen.Length - 1
            For Each getal In getallen
                If getallen.Length - getal <= i Then
                    berg &= "   |"
                Else
                    berg &= "    "
                End If
            Next
            berg &= vbNewLine & vbNewLine
        Next

        txtBerg.Text = berg
    End Sub
End Class
