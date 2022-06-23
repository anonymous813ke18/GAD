Module Module1

    Sub Main()
        Dim i, cn As Integer
        Dim ch As Char
        cn = 0
        For i = 65 To 91
            ch = Chr(i)
            Select Case ch
                Case "A"
                    cn = cn + 1
                Case "E"
                    cn = cn + 1
                Case "I"
                    cn = cn + 1
                Case "O"
                    cn = cn + 1
                Case "U"
                    cn = cn + 1
            End Select
        Next
        Console.WriteLine("Number of vowels between A-Z is = " & cn)
        Console.ReadLine()
    End Sub

End Module
