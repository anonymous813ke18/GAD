Module Module1

    Sub Main()
        Dim a, b, c As Integer
        a = InputBox("a:")
        b = InputBox("b:")
        c = InputBox("c:")
        If a > b Then
            If a > c Then
                Console.WriteLine("a is the greatest number")
            Else
                Console.WriteLine("c is the greatest")
            End If
        Else
            If b > c Then
                Console.WriteLine("b is the greatest number")
            Else
                Console.WriteLine("c is the greatest number")
            End If
        End If
        Console.ReadLine()
    End Sub

End Module
