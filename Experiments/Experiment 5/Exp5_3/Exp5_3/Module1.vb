Module Module1
    Sub main()
        Dim a, b, c, choice As Integer
        Console.WriteLine("Name - Hammad Khan")
        Do
            Console.WriteLine("Enter a choice ")
            Console.WriteLine("1 - Addition")
            Console.WriteLine("2 - Subtraction")
            Console.WriteLine("3 - Multiplication")
            Console.WriteLine("4 - Division")
            Console.WriteLine("5 - Mod")
            Console.WriteLine("6 - Exit")
            choice = Console.ReadLine()
            Select Case choice
                Case 1
                    Console.WriteLine("Enter value for a and b")
                    a = Console.ReadLine()
                    b = Console.ReadLine()
                    c = a + b
                    Console.WriteLine("The sum is =" & c)
                    Console.WriteLine("Press any key to continue...")
                    Console.ReadLine()
                    Console.Clear()
                Case 2
                    Console.WriteLine("Enter value for a and b")
                    a = Console.ReadLine()
                    b = Console.ReadLine()
                    c = a - b
                    Console.WriteLine("The diff is =" & c)
                    Console.WriteLine("Press any key to continue...")
                    Console.ReadLine()
                    Console.Clear()
                Case 3
                    Console.WriteLine("Enter value for a and b")
                    a = Console.ReadLine()
                    b = Console.ReadLine()
                    c = a * b
                    Console.WriteLine("The product is =" & c)
                    Console.WriteLine("Press any key to continue...")
                    Console.ReadLine()
                    Console.Clear()
                Case 4
                    Console.WriteLine("Enter value for a and b")
                    a = Console.ReadLine()
                    b = Console.ReadLine()
                    c = a / b
                    Console.WriteLine("The division of a and b is =" & c)
                    Console.WriteLine("Press any key to continue...")
                    Console.ReadLine()
                    Console.Clear()
                Case 5
                    Console.WriteLine("Enter value for a and b")
                    a = Console.ReadLine()
                    b = Console.ReadLine()
                    c = a Mod b
                    Console.WriteLine("The Mod is =" & c)
                    Console.WriteLine("Press any key to continue...")
                    Console.ReadLine()
                    Console.Clear()
                Case 6
                    Exit Select
            End Select
        Loop While choice <> 6
    End Sub
End Module