Module Module1

    Sub Main()
        Dim a, temp, rev As Integer
        rev = 0
        Console.WriteLine("Enter a number")
        a = Console.ReadLine()
        temp = a
        Do
            rev = (rev * 10) + (a Mod 10)
            a = a \ 10
        Loop While a <> 0
        If rev = temp Then
            Console.WriteLine(rev & " is a palindrome number")
        Else
            Console.WriteLine(rev & " is not a palindrome number")
        End If
        Console.ReadLine()
    End Sub

End Module
