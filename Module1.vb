Imports System
Imports System.IO
Imports Microsoft.VisualBasic


Module Module1


    Sub Main()
        Dim priority As String = ""
        Console.WriteLine("----------------------------")
        Console.WriteLine("  LINKIUM KERNEL            ")
        Console.WriteLine("  PRIORITIES CHECK V.0.10.0 ")
        Console.WriteLine("----------------------------")
        Console.WriteLine("HELLO WORLD")
        Console.WriteLine("WHAT'S THE PRIORITY TODAY")
        priority = Console.ReadLine().ToUpper()

        Dim todaySign = DateTime.Now.ToString("ddMMyyyy")
        Console.WriteLine("OK: " & priority)
        'TODO: Dump it to txt file in ddMMyyyy format
        Dim outPath As String = "OUT_" & todaySign & ".TXT"
        Using writer As New StreamWriter(outPath, append:=False)
            writer.WriteLine(todaySign & " " & "PRIORITY IS: " & priority)

            Dim anotherTask As String = "n"
            While True

                Console.WriteLine("ANOTHER TASK TODAY OR NOW (YES/NO):")
                anotherTask = Console.ReadLine().ToUpper()

                If anotherTask = "Y" Or anotherTask = "YES" Then
                    Dim which = ""
                    Console.WriteLine("WHICH:")
                    which = Console.ReadLine().ToUpper()
                    writer.WriteLine("ANOTHER TASK IS: " & which)
                ElseIf anotherTask = "N" Or anotherTask = "NO" Then
                    Exit While
                Else
                    Console.WriteLine("I DO NOT UNDERSTAND THAT")
                End If
            End While
        End Using
        Console.WriteLine("PRESS ANY KEY TO FINALIZE PROGRAM...")
        Console.ReadKey()
    End Sub

End Module
