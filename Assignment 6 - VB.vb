Module Module1

    Sub Main()

        Dim Int1 As Integer


        Int1 = 0


        Console.Write("Enter number of donuts to process: ")
        Int1 = Console.ReadLine



        If Int1 < 0 Then
            Console.Write("Invalid number of donuts.")
        ElseIf Int1 <= 9 Then
            Console.Write("Number of donuts: " & Int1)
        ElseIf Int1 > 10 Then
            Console.Write("Number of donuts is many.")
        End If
        Console.ReadKey()

    End Sub

End Module
