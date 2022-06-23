Module Module1

    Sub Main()
        Dim n, i, j As Integer
        Console.WriteLine("Enter the number of lines:")
        n = Console.ReadLine()
        For i = 1 To n
            For j = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
