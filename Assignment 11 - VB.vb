Module Module1

    Sub Main()


        Dim Str1, FinalStr As String
        Dim A, B, C As Integer


        Str1 = " "
        FinalStr = " "
        A = 0
        B = 0
        C = 0



        Console.Write("Enter any sentence/string: ")
        Str1 = Console.ReadLine
        A = InStr(Str1, "not")
        B = InStr(Str1, "bad")
        C = Len(Str1) - B - 2
        If C > 0 Then
            FinalStr = Left(Str1, A - 1) & "good" & Right(Str1, C)
        Else
            FinalStr = Left(Str1, A - 1) & "good"
        End If
        Console.WriteLine("The updated string is: " & FinalStr)
        Console.ReadKey()

    End Sub

End Module
