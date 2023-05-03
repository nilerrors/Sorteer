Public Class RippleSort
    Dim wiskundigen() As String = {
        "Archimedes",
        "Abel",
        "Benoulli",
        "Gauss",
        "Fourier",
        "Euler",
        "Pascal",
        "Venn",
        "Stevin",
        "Poisson",
        "Kepler",
        "Fibonacci"
    }

    Private Sub RippleSort_Load(sender As Object, e As EventArgs)
        laatWiskundigenZien()
    End Sub

    Private Sub RippleSort_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        laatWiskundigenZien()
    End Sub

    Private Sub RippleSort(ByRef arr() As String)
        Dim isSorted As Boolean
        Dim tmp As String
        For i = 0 To arr.Length - 2
            For j = 0 To arr.Length - 2 - i
                If arr(j) > arr(j + 1) Then
                    tmp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = tmp
                    isSorted = False
                End If
            Next
        Next
    End Sub

    Private Sub btnSorteer_Click(sender As Object, e As EventArgs) Handles btnSorteer.Click
        RippleSort(wiskundigen)
        laatWiskundigenZien()
    End Sub

    Sub laatWiskundigenZien()
        lstNamen.Items.Clear()
        For Each wiskundige In wiskundigen
            lstNamen.Items.Add(wiskundige)
        Next
    End Sub
End Class
