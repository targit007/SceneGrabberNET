Imports System.Environment

Module Module1

    Declare Function AttachConsole Lib "kernel32" (ByVal dwProcessId As Int32) As Boolean
    Declare Function FreeConsole Lib "kernel32.dll" () As Boolean

    Sub Main()
        Dim args As String() = GetCommandLineArgs()
        If args.Length = 1 Then
            'No arguments so show windows form
            Dim frmMain As New frmMain
            Application.Run(frmMain)
        Else
            AttachConsole(-1)
            Console.WriteLine("Arguments supplied")
            FreeConsole()
        End If
    End Sub

End Module