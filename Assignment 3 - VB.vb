Module Module1

    Sub Main()

        Dim Str1 As String
        Dim SelectedChar, X As Char
        Dim CountSelect, CountOthers, CountDigits, CountSpecial, i As Integer


        Str1 = ""
        X = ""
        SelectedChar = ""
        CountSelect = 0
        CountOthers = 0
        CountDigits = 0
        CountSpecial = 0
        i = 0


        Console.Write("Enter Your String: ")
        Str1 = Console.ReadLine
        Console.Write("Enter the character to count: ")
        SelectedChar = Console.ReadLine
        LCase(Str1)
        LCase(SelectedChar)

        For i = 1 To Len(Str1)
            X = Mid(Str1, i, 1)
            If X = SelectedChar Then
                CountSelect = CountSelect + 1
            ElseIf Asc(X) > 96 And Asc(X) < 123 And Asc(X) <> Asc(SelectedChar) Then
                CountOthers = CountOthers + 1
            ElseIf Asc(X) > 47 And Asc(X) < 58 And Asc(X) <> Asc(SelectedChar) Then
                CountDigits = CountDigits + 1
            Else
                CountSpecial = CountSpecial + 1
            End If
        Next i


        Console.WriteLine("The count for the selected character is: " & CountSelect)
        Console.WriteLine("The count for the other alphabets is: " & CountOthers)
        Console.WriteLine("The count of digits is: " & CountDigits)
        Console.WriteLine("The count of special characters is: " & CountSpecial)

        Console.ReadKey()

    End Sub

End Module
