Module Module1

    Sub Main()
        Dim a, temp, sum, c As Integer
        sum = 0
        Console.WriteLine("Enter a number")
        a = Console.ReadLine()
        temp = a
        Do
            c = (a Mod 10) * (a Mod 10) * (a Mod 10)
            sum = sum + c
            a = a \ 10
        Loop While a <> 0
        If sum = temp Then
            Console.WriteLine("The sum of the cube of the digits is = " & sum)
            Console.WriteLine(sum & " is an armstrong number")
        Else
            Console.WriteLine("The sum of the cube of the digits is = " & sum)
            Console.WriteLine(temp & " is not an armstrong number")
        End If
        Console.ReadLine()
    End Sub

End Module
