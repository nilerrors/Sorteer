Public Class Form1
    Dim getallen() As Short = {-3, 5, 11, 210, 2, 6}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each getal In getallen
            lstGetallen.Items.Add(getal.ToString())
        Next
    End Sub

    Private Sub btnSorteren_Click(sender As Object, e As EventArgs) Handles btnSorteren.Click
        Array.Sort(getallen)

        lstGetallen.Items.Clear()
        For Each getal In getallen
            lstGetallen.Items.Add(getal.ToString())
        Next
    End Sub
End Class
