Module Module1

    Sub Main()
        Dim choice, a, b, flag, c As Integer
        Console.WriteLine("Name - Hammad Khan")
        Do
            Console.Clear()
            Console.WriteLine("Enter your choice:-")
            Console.WriteLine("1 - Print even and odd number from 1 - 50")
            Console.WriteLine("2 - Print prime number between 1 - 100")
            Console.WriteLine("3 - Exit")
            choice = Console.ReadLine()
            Select Case choice
                Case 1
                    flag = 0
                    a = 3
                    While a < 100
                        b = 2
                        flag = 0
                        While b < a
                            c = a Mod b
                            If c = 0 Then
                                flag = 1
                            End If
                            b = b + 1
                        End While
                        If flag = 0 Then
                            Console.WriteLine(a & " is a prime number")
                        ElseIf flag = 1 Then
                            Console.WriteLine(a & " is not a prime number")
                        End If
                        a = a + 1
                    End While
                    Console.WriteLine("Press any key to continue....")
                    Console.ReadLine()
                Case 2
                    a = 1
                    While a <= 50
                        If a Mod 2 = 0 Then
                            Console.WriteLine(a & " is an even number")
                        Else
                            Console.WriteLine(a & " is an odd number")
                        End If
                        a = a + 1
                    End While
                    Console.WriteLine("Press any key to continue....")
                    Console.ReadLine()
                Case 3
                    Console.WriteLine("Exiting program....")
                    Console.WriteLine("Press any key to continue....")
                    Console.ReadLine()
                    Exit Select
                Case Else
                    Console.WriteLine("Wrong Input" & vbCrLf & "Try again" & vbCrLf & "Press any key to continue....")
                    Console.ReadLine()
            End Select
        Loop While choice <> 3

    End Sub

End Module
