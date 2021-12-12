Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim i, j, Counter, Mostrepeated As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        i = 0
        j = 0
        Counter = 0
        Mostrepeated = 0


        Console.WriteLine("Input your string: ")
        Str1 = Console.ReadLine

        For i = 1 To Len(Str1)
            Char3 = Mid(Str1, i, 1)
            Counter = 0
            For j = 1 To Len(Str1)
                Char2 = Mid(Str1, j, 1)
                If Char2 = Char3 Then
                    Counter = Counter + 1

                End If

            Next j

            If Mostrepeated < Counter Then
                Mostrepeated = Counter
                Char1 = Char3
            End If


        Next i

        Console.WriteLine("Most repeated character is: " & Char1)
        Console.ReadKey()
    End Sub

End Module
