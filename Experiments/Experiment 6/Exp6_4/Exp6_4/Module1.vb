Module Module1

    Sub Main()
        Dim a, temp, sum As Integer
        sum = 0
        Console.WriteLine("Enter a number")
        a = Console.ReadLine()
        temp = a
        Do
            sum = sum + (a Mod 10)
            a = a \ 10
        Loop While a <> 0
        Console.WriteLine("The sum of the digits is = " & sum)
        Console.ReadLine()

    End Sub

End Module
