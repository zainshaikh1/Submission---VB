Module Module1

    Sub Main()

        Dim Str1, alphabets As String
        Dim HasAllAlphabets As Boolean
        Dim i As Integer
        Dim Char1 As Char


        Str1 = ""
        alphabets = ""
        HasAllAlphabets = True
        i = 0
        Char1 = ""


        alphabets = "abcdefghijklmnopqrstuvwxyz"
        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine
        Str1 = LCase(Str1)


        For i = 1 To Len(alphabets)
            Char1 = Mid(alphabets, i, 1)
            If InStr(Str1, Char1) = 0 Then HasAllAlphabets = False
            If HasAllAlphabets = False Then Exit For
        Next i


        If HasAllAlphabets = True Then
            Console.WriteLine("Entered string does contain all alphabets.")
        Else
            Console.WriteLine("Entered string does NOT contain all alphabets.")
        End If

        Console.ReadKey()
    End Sub

End Module

