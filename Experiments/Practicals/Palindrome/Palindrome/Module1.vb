Module Module1

    Sub Main()
        Dim num, temp, rev As Integer
        rev = 0
        Console.WriteLine("Enter a number:")
        num = Console.ReadLine()
        temp = num
        While (num <> 0)
            rev = (rev * 10) + (num Mod 10)
            num = num / 10
        End While
        If (rev = temp) Then
            Console.WriteLine("The number is palindrome.")
        Else
            Console.WriteLine("The number is not palindrome.")
        End If
        Console.ReadLine()
    End Sub

End Module
