Module Module1

    Sub Main()

        Dim Str1, Str2, a, b, TwoChar1, TwoChar2, FinalStr As String
        Dim X, Y As Integer


        Str1 = ""
        Str2 = ""
        a = ""
        b = ""
        TwoChar1 = ""
        TwoChar2 = ""
        FinalStr = ""
        X = 0
        Y = 0


        Console.Write("Enter first string: ")
        Str1 = Console.ReadLine
        Console.WriteLine("Enter second string: ")
        Str2 = Console.ReadLine

        X = Len(Str1) - 2
        Y = Len(Str2) - 2
        TwoChar1 = Left(Str1, 2)
        TwoChar2 = Left(Str2, 2)
        a = TwoChar1 & Mid(Str2, 3, Y)
        b = TwoChar2 & Mid(Str1, 3, X)
        FinalStr = a & " " & b
        Console.Write("The final string is: " & FinalStr)

        Console.ReadLine()

    End Sub

End Module
