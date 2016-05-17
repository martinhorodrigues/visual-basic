Module Module1

    Function romanos(ByVal numDec As Integer) As String
        Select Case numDec
            Case 1 : romanos = "I"
            Case 2 : romanos = "II"
            Case 3 : romanos = "III"
            Case 4 : romanos = "IV"
            Case 5 : romanos = "V"
            Case 6 : romanos = "VI"
            Case 7 : romanos = "VII"
            Case 8 : romanos = "VIII"
            Case 9 : romanos = "lX"
            Case 10 : romanos = "X"
            Case 11 : romanos = "XI"
            Case 12 : romanos = "XII"
            Case 13 : romanos = "XIII"
            Case 14 : romanos = "XIV"
            Case 15 : romanos = "XV"
            Case Is < 20 : romanos = "X" & romanos(numDec - 10)
            Case 20 : romanos = "XX"
            Case Is < 30 : romanos = "XX" & romanos(numDec - 20)
            Case 30 : romanos = "XXX"
            Case 40 : romanos = "XI"
            Case 50 : romanos = "L"
            Case 60 : romanos = "LX"
            Case 70 : romanos = "LXX"
            Case 80 : romanos = "LXXX"
            Case 90 : romanos = "XC"
            Case Is < 100 : romanos = romanos(Int(numDec \ 10) * 10) & romanos(numDec Mod 10)
            Case 100 : romanos = "C"
            Case Is < 200 : romanos = "C" & romanos(numDec - 100)
            Case 200, 300, 400, 600, 800 : romanos = romanos(Int(numDec \ 100)) & "C"
            Case 500 : romanos = "D"
            Case 700 : romanos = "DCC"
            Case 900 : romanos = "CM"
            Case Is < 1000 : romanos = romanos(Int(numDec \ 100) * 100) & romanos(numDec Mod 100)
            Case 1000 : romanos = "M"
            Case Is < 2000 : romanos = "M" & romanos(numDec Mod 1000)
            Case Is < 1000000 : romanos = romanos(Int(numDec \ 1000)) & "M"
                If numDec Mod 1000 Then romanos = romanos & romanos(numDec Mod 1000)
        End Select
    End Function

    Sub Main()
        Dim numDecimal As Integer
        Dim numRom As String = ""

        Console.Write("Ingrese un numero decimal: ")
        numDecimal = Console.ReadLine

        Console.WriteLine("El numero {0} en romano es: {1}", numDecimal, romanos(numDecimal))
        Console.ReadLine()
    End Sub

End Module
