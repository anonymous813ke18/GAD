Module Module1

    Sub Main()
        Dim year As Integer
        year = InputBox("Enter the year")
        If year Mod 4 = 0 Then
            Console.WriteLine("It's a leap year")
        Else
            Console.WriteLine("It's not a leap year")
        End If
        Console.ReadLine()
    End Sub

End Module
