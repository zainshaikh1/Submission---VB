Module Module1

    Sub Main()

        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim i As Integer


        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        i = 0


        Console.WriteLine("Enter string to process: ")
        Str1 = Console.ReadLine
        Console.WriteLine("Enter character to replace: ")
        Char2 = Console.ReadLine
        Console.WriteLine("Enter character to replace with: ")
        Char3 = Console.ReadLine
        LCase(Str1)

        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            If Char1 <> Char2 Then
                Str2 = Str2 + Char1
            Else
                Str2 = Str2 + Char3
            End If
        Next i

        Console.WriteLine("String after replacement is: " & Str2)
        Console.ReadKey()


    End Sub

End Module
