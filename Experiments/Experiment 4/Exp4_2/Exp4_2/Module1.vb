Module Module1

    Sub Main()
        Dim a As Integer
        a = 1
        While a <= 50
            If a Mod 2 = 0 Then
                Console.WriteLine(a & " is an even number")
            Else
                Console.WriteLine(a & " is an odd number")
            End If
            a = a + 1
        End While
        Console.ReadLine()
    End Sub

End Module
