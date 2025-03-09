Imports System.IO


Module Module1


    Sub Main()
        Dim priority As String = ""
        Console.WriteLine("---------------------------")
        Console.WriteLine("  PRIORITY CHECK V.0.9.0   ")
        Console.WriteLine("---------------------------")
        Console.WriteLine("HELLO WORLD")
        Console.WriteLine("WHAT'S THE PRIORITY TODAY")
        priority = Console.ReadLine().ToUpper()

        Dim todaySign = DateTime.Now.ToString("ddMMyyyy")
        Console.WriteLine("OK: " & priority)
        'TODO: Dump it to txt file in ddMMyyyy format
        Dim outPath As String = "OUT_" & todaySign & ".TXT"
        Using writer As new StreamWriter(outPath, append:=False)
            writer.WriteLine(todaySign & " " & "PRIORITY IS: " & priority)
        End Using
        Console.WriteLine("")
        Console.ReadKey()
    End Sub

End Module
