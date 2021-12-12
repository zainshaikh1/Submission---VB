Module Module1

    Sub Main()

        Dim Str1, Last3 As String


        Str1 = ""
        Last3 = ""

        Console.Write("Input a string: ")
        Str1 = Console.ReadLine

        If Len(Str1) < 3 Then
            Str1 = Str1
        Else
            Last3 = Right(Str1, 3)
            If Last3 = "ing" Then
                Str1 = Str1 & "ly"
            Else
                Str1 = Str1 & "ing"
            End If
        End If
        Console.Write("The updated string is: " & Str1)
        Console.ReadLine()

    End Sub

End Module
