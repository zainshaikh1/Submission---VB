Module Module1

    Sub Main()

        Dim s As String
        Dim ThisChar, FirstChar As Char
        Dim X, i As Integer


        s = ""
        ThisChar = ""
        FirstChar = ""
        X = 0
        i = 0


        Console.WriteLine("Enter any string: ")
        s = Console.ReadLine
        FirstChar = Left(s, 1)
        For i = 2 To Len(s)
            X = Len(s) - i
            ThisChar = Mid(s, i, 1)
            If ThisChar = FirstChar Then
                s = Left(s, i - 1) & "*" & Mid(s, i + 1, X)
            End If
        Next i
        Console.Write("The updated string is: " & s)


        Console.ReadLine()


    End Sub

End Module
