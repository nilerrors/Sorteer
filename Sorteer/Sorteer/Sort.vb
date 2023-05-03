Public Class Sort
    'Public Class Report
    '    Public ReadOnly Property time
    '    Public ReadOnly Property space
    'End Class

    Public Shared Sub Selection(ByRef arr As Integer())
        Dim indexKlein As Integer
        Dim bovengrens As Integer = arr.Length - 1
        Dim tmp As Integer

        For i = 0 To bovengrens - 1
            indexKlein = i
            For j = i + 1 To bovengrens
                If arr(j) < arr(indexKlein) Then
                    indexKlein = j
                End If
            Next
            tmp = arr(i)
            arr(i) = arr(indexKlein)
            arr(indexKlein) = tmp
        Next
    End Sub

    Public Shared Sub Bubble(ByRef arr As Integer())
        Dim bovengrens As Integer = arr.Length - 1
        Dim tmp As Integer

        For i = 0 To bovengrens - 1
            For j = 0 To bovengrens - 1 - i
                If arr(j) > arr(j + 1) Then
                    tmp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = tmp
                End If
            Next
        Next
    End Sub

    Public Shared Sub Ripple(ByRef arr As Integer())
        Dim bovengrens As Integer = arr.Length - 1
        Dim isGesorteerd As Boolean = True
        Dim tmp As Integer

        For i = 0 To bovengrens - 1
            isGesorteerd = True
            For j = 0 To bovengrens - 1 - i
                If arr(j) > arr(j + 1) Then
                    isGesorteerd = False
                    tmp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = tmp
                End If
            Next
            If isGesorteerd Then
                Exit For
            End If
        Next
    End Sub

    Public Shared Sub Insertion(ByRef arr As Integer())
        Dim bovengrens As Integer = arr.Length - 1
        Dim tmp As Integer
        Dim j As Integer

        For i = 1 To bovengrens
            tmp = arr(i)
            j = i - 1

            While j >= 0 AndAlso arr(j) > tmp
                arr(j + 1) = arr(j)
                j -= 1
            End While
            arr(j + 1) = tmp
        Next
    End Sub

    Public Shared Sub Merge(ByRef arr As Integer())
        If arr.Length <= 1 Then
            Return
        End If

        Dim middleIndex As Integer = arr.Length \ 2

        ' Halveer de array
        Dim leftArr(middleIndex - 1) As Integer
        Dim rightArr(arr.Length - middleIndex - 1) As Integer
        Array.Copy(arr, 0, leftArr, 0, middleIndex)
        Array.Copy(arr, middleIndex, rightArr, 0, arr.Length - middleIndex)

        ' Roep dezelfde functie voor beide gehalveerde kanten van de array, recursief
        Merge(leftArr)
        Merge(rightArr)

        ' Voeg beide helften samen
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0
        While i < leftArr.Length AndAlso j < rightArr.Length
            If leftArr(i) <= rightArr(j) Then
                arr(k) = leftArr(i)
                i += 1
            Else
                arr(k) = rightArr(j)
                j += 1
            End If
            k += 1
        End While

        ' Voeg enige overgebleven elementen van links en rechts toe
        While i < leftArr.Length
            arr(k) = leftArr(i)
            i += 1
            k += 1
        End While

        While j < rightArr.Length
            arr(k) = rightArr(j)
            j += 1
            k += 1
        End While
    End Sub
End Class
