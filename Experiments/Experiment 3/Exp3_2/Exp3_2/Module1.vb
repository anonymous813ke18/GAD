Module Module1

    Sub Main()
        Dim num1, num2, sum, diff, mul, div, modulas As Integer
        Console.WriteLine("Enter 2 numbers:")
        num1 = Console.ReadLine()
        num2 = Console.ReadLine()
        Console.WriteLine("Sum = " & (num1 + num2))
        Console.WriteLine("Diff = " & (num1 - num2))
        Console.WriteLine("Mul = " & (num1 * num2))
        Console.WriteLine("Div = " & (num1 / num2))
        Console.WriteLine("Mod = " & (num1 Mod num2))
        Console.ReadLine()
    End Sub

End Module
