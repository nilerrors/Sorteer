Public Class Form1
    Dim getallen As Integer() = {10, 6, -3, 11, 5, 30, 7}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laatGetallenZien()
    End Sub

    Private Sub btnSorteer_Click(sender As Object, e As EventArgs) Handles btnSorteer.Click
		MergeSortIterative(getallen)
		laatGetallenZien()
	End Sub

    Sub laatGetallenZien()
        lstGetallen.Items.Clear()

        For Each getal In getallen
            lstGetallen.Items.Add(getal.ToString())
        Next
    End Sub

	Public Shared Sub MergeSortIterative(ByRef data As Integer())
		Dim currentSize As Integer
		Dim leftStart As Integer

		currentSize = 1
		While currentSize <= data.Length - 1
			leftStart = 0
			While leftStart < data.Length - 1
				Dim mid As Integer = leftStart + currentSize - 1
				Dim rightEnd As Integer = Math.Min(leftStart + 2 * currentSize - 1, data.Length - 1)

				Merge(data, leftStart, mid, rightEnd)
				leftStart += 2 * currentSize
			End While
			currentSize = 2 * currentSize
		End While
	End Sub

	Private Shared Sub Merge(ByRef data As Integer(), left As Integer, mid As Integer, right As Integer)
		Dim i As Integer, j As Integer, k As Integer
		Dim n1 As Integer = mid - left + 1
		Dim n2 As Integer = right - mid
		Dim L As Integer() = New Integer(n1 - 1) {}
		Dim R As Integer() = New Integer(n2 - 1) {}

		For i = 0 To n1 - 1
			L(i) = data(left + i)
		Next

		For j = 0 To n2 - 1
			R(j) = data(mid + 1 + j)
		Next

		i = 0
		j = 0
		k = left

		While i < n1 AndAlso j < n2
			If L(i) <= R(j) Then
				data(k) = L(i)
				i += 1
			Else
				data(k) = R(j)
				j += 1
			End If

			k += 1
		End While

		While i < n1
			data(k) = L(i)
			i += 1
			k += 1
		End While

		While j < n2
			data(k) = R(j)
			j += 1
			k += 1
		End While
	End Sub
End Class
