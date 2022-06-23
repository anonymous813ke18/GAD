Module Module1

    Sub Main()
        Dim i, min, max, len As Integer
        Console.WriteLine("Enter the number of elements in the array:")
        len = Console.ReadLine()
        Dim iarr(len) As Integer
        For i = 0 To len - 1
            Console.WriteLine("Enter the number at iarr(" & i & "):")
            iarr(i) = Console.ReadLine()
        Next
        min = iarr(0)
        max = iarr(0)
        For i = 0 To len - 1
            If (iarr(i) > max) Then
                max = iarr(i)
            ElseIf (iarr(i) < min) Then
                min = iarr(i)
            End If
        Next
        Console.WriteLine("Minimum value = " & min & vbCrLf & "Maximum value = " & max)
        Console.ReadLine()
    End Sub

End Module
