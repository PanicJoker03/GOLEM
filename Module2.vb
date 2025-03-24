Module Module2

    Sub Main()
        'Count to ten
        Console.WriteLine("COUNT TO TEN: ")
        For counter = 1 To 10
            Threading.Thread.Sleep(1000)
            Console.WriteLine(++counter)
        Next
        Console.ReadKey()
        Console.WriteLine("PRESS ANY KEY TO EXIT PROGRAM...")
    End Sub

End Module
