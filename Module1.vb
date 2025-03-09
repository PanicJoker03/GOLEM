Imports System.IO


Module Module1


    Sub Main()
        Dim priority As String = ""
        Console.WriteLine("---------------------------")
        Console.WriteLine("GOLEM PRIORITY CHECK V.0.8.1")
        Console.WriteLine("---------------------------")
        Console.WriteLine("Hello World!")
        Console.WriteLine("What's the priority today?")
        priority = Console.ReadLine()

	Dim todaySign = DateTime.Now.ToString("ddMMyyyy")
        Console.WriteLine("Ok, you told me the priority is: " & priority)
        'TODO: Dump it to txt file in ddMMyyyy format
        Dim outPath As String = "out_" & todaySign & ".txt"
        Using writer As new StreamWriter(outPath, append:=False)
            writer.WriteLine(todaySign & " " & "priority is: " & priority)
        End Using
	Console.WriteLine("Dumped priority succesfully")
        Console.ReadKey()
    End Sub

End Module
