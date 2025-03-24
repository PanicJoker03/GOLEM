Module Module3

    Sub Main()
        Dim reality As Integer = New Random().Next(0, 2)

        Console.WriteLine("REALITY CHECK")
        Console.WriteLine(reality)
        Console.WriteLine("PRESS ANY KEY TO FINALIZE PROGRAM...")
        Console.ReadKey()
    End Sub

End Module