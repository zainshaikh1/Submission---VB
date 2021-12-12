Module Module1

    Sub Main()


        Dim Str1 As String
        Dim Char1 As Char
        Dim i, ACounter, ECounter, ICounter, OCounter, UCounter As Integer
        

        Str1 = ""
        Char1 = ""
        i = 0
        ACounter = 0
        ECounter = 0
        ICounter = 0
        OCounter = 0
        UCounter = 0


        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine


        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Char1 = UCase(Char1)
            If Char1 = "A" Then
                ACounter = ACounter + 1
            End If


            If Char1 = "E" Then
                ECounter = ECounter + 1
            End If


            If Char1 = "I" Then
                ICounter = ICounter + 1
            End If

            If Char1 = "O" Then
                OCounter = OCounter + 1
            End If

            If Char1 = "U" Then
                UCounter = UCounter + 1
            End If

        Next i


        Console.WriteLine("A occurs " & ACounter & " time(s).")
        Console.WriteLine("E occurs " & ECounter & " time(s).")
        Console.WriteLine("I occurs " & ICounter & " time(s).")
        Console.WriteLine("O occurs " & OCounter & " time(s).")
        Console.WriteLine("U occurs " & UCounter & " time(s).")
        Console.ReadKey()

    End Sub

End Module
