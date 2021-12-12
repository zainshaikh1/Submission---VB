Module Module1

    Sub Main()

        Dim Str1, FN, LN As String



        Str1 = ""
        FN = ""
        LN = ""



        Console.Write("Enter String: ")
        Str1 = Console.ReadLine


        If Len(Str1) <= 2 Then
            Console.WriteLine("New string is: " & Str1)
        ElseIf Len(Str1) > 2 Then
            FN = Left(Str1, 2)
            LN = Right(Str1, 2)
            Console.WriteLine("New string is: " & FN & LN)
        End If
        Console.ReadKey()

    End Sub

End Module
