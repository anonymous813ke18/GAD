Module Module1

    Sub Main()
        Dim f, n, n2 As Integer
        Console.WriteLine("Enter the number to calculate the factorial of: ")
        n = 1
        n2 = 1
        f = Console.ReadLine()
        While n <= f
            n2 = n2 * n
            n = n + 1

        End While
        Console.WriteLine("The factorial is " & n2)
        Console.ReadLine()

    End Sub

End Module
