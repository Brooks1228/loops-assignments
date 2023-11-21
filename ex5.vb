Module ex5
    'broooks keller
    '10/27/23
    'ex5
    Sub main()
        Dim input As String
        Dim parts As Integer
        Dim totparts As Integer
        Dim rejparts As Integer
        Dim totrejparts As Integer
        Dim percent As Double
        For i As Integer = 1 To 5
            Console.WriteLine("enter the number of parts for item " & i & " >> ")
            Integer.TryParse(Console.ReadLine, parts)
            Console.WriteLine()
        Next
    End Sub
End Module
