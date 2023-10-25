Module ex3
    'brooks keller
    '10/25/23
    'a3
    Sub Main()
        Dim input As String
        Dim total As Double
        Dim av As Double
        Dim temp As Double

        For i As Integer = 1 To 5
            Console.Write("enter temp {0} >> ", i)
            input = Console.ReadLine
            Double.TryParse(input, temp)
            total = total + temp
        Next
        av = total / 5
        Console.WriteLine("average: " & av)
    End Sub
End Module
