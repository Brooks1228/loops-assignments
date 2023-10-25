Module ex4
    'brooks keller
    '10/25/23
    'a4
    Sub main()
        Console.WriteLine("brooks keller" & vbNewLine)

        Dim input As String
        Dim total As Double
        Dim price As Double
        Dim tax As Double
        Console.WriteLine("enter 5 prices and i will calculate the subtotal, tax (6%), and total.")
        For i As Integer = 1 To 5
            Console.Write("enter price {0} >> ", i)
            input = Console.ReadLine
            Double.TryParse(input, price)
            total = total + price
        Next
    End Sub
End Module
