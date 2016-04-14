Imports System.Math

Module Module1
    Sub Ingresar(ByRef X As Double)
        Console.Write("Numero: ")
        X = Console.ReadLine
    End Sub

    Sub Ingresar2(ByRef X As Double, ByRef Y As Double)
        Console.Write("Numero X: ")
        X = Console.ReadLine

        Console.Write("Numero Y: ")
        Y = Console.ReadLine
    End Sub

    Sub Ret(ByRef Ret As Double)
        Console.Write("Resultado: {0}", Ret)
        Console.ReadLine()
    End Sub

    Function abs(ByVal Numero As Double) As Double
        Return Math.Abs(Numero)
    End Function

    Function acos(ByVal Numero As Double) As Double
        Return Math.Acos(Numero)
    End Function

    Function asin(ByVal Numero As Double) As Double
        Return Math.Asin(Numero)
    End Function

    Function atan(ByVal Numero As Double) As Double
        Return Math.Atan(Numero)
    End Function

    Function atan2(ByVal Numero1 As Double, ByVal Numero2 As Double) As Double
        Return Math.Atan2(Numero1, Numero2)
    End Function

    Function bigmul(ByVal Numero1 As Double, ByVal Numero2 As Double) As Double
        Return Math.BigMul(Numero1, Numero2)
    End Function

    Function ceiling(ByVal Numero1 As Double) As Double
        Return Math.Ceiling(Numero1)
    End Function

    Function cos(ByVal Numero1 As Double)
        Return Math.Cos(Numero1)
    End Function

    Function cosh(ByVal Numero1 As Double)
        Return Math.Cosh(Numero1)
    End Function

    Function divrem(ByVal Numero1 As Integer, ByVal Numero2 As Integer, ByRef Res As Integer) As Double
        Return Math.DivRem(Numero1, Numero2, Res)
    End Function

    Function exp(ByVal Numero1 As Double) As Double
        Return Math.Exp(Numero1)
    End Function

    Function floor(ByVal Numero1 As Double) As Double
        Return Math.Floor(Numero1)
    End Function

    Function ieee(ByVal Numero1 As Double, ByVal Numero2 As Double) As Double
        Return Math.IEEERemainder(Numero1, Numero2)
    End Function

    Function log(ByVal Numero1 As Double) As Double
        Return Math.Log(Numero1)
    End Function

    Function log10(ByVal Numero1 As Double) As Double
        Return Math.Log10(Numero1)
    End Function

    Function max(ByVal Numero1 As Double, ByVal Numero2 As Double) As Double
        Return Math.Max(Numero1, Numero2)
    End Function

    Function min(ByVal Numero1 As Double, ByVal Numero2 As Double) As Double
        Return Math.Min(Numero1, Numero2)
    End Function

    Function pow(ByVal Numero1 As Double, ByVal Numero2 As Double) As Double
        Return Math.Pow(Numero1, Numero2)
    End Function

    Function round(ByVal Numero1 As Double) As Double
        Return Math.Round(Numero1)
    End Function

    Function sign(ByVal Numero1 As Double) As Double
        Return Math.Sign(Numero1)
    End Function

    Function sin(ByVal Numero1 As Double) As Double
        Return Math.Sin(Numero1)
    End Function

    Function sinh(ByVal Numero1 As Double) As Double
        Return Math.Sinh(Numero1)
    End Function

    Function sqrt(ByVal Numero1 As Double) As Double
        Return Math.Sqrt(Numero1)
    End Function

    Function tan(ByVal Numero1 As Double) As Double
        Return Math.Tan(Numero1)
    End Function

    Function tanh(ByVal Numero1 As Double) As Double
        Return Math.Tanh(Numero1)
    End Function

    Sub Main()

        Dim Res As Double
        Dim opc As Integer
        Dim ciclo As Boolean = True

        Do
            Console.Clear()
            Console.WriteLine("1 - Abs" & vbTab & vbTab & "11 - Exp" & vbTab & vbTab & "21 - Sin")
            Console.WriteLine("2 - Acos" & vbTab & "12 - Floor" & vbTab & vbTab & "22 - Sinh")
            Console.WriteLine("3 - Asin" & vbTab & "13 - IEEERemainder" & vbTab & "23 - Sqrt")
            Console.WriteLine("4 - Atan" & vbTab & "14 - Log" & vbTab & vbTab & "24 - Tan")
            Console.WriteLine("5 - Atan2" & vbTab & "15 - Log10" & vbTab & vbTab & "25 - Tanh")
            Console.WriteLine("6 - BigMul" & vbTab & "16 - Max")
            Console.WriteLine("7 - Ceiling" & vbTab & "17 - Min")
            Console.WriteLine("8 - Cos" & vbTab & vbTab & "18 - Pow")
            Console.WriteLine("9 - Cosh" & vbTab & "19 - Round")
            Console.WriteLine("10 - DivRem" & vbTab & "20 - Sign" & vbTab & vbTab & "0) Salir" & vbCrLf)

            Console.Write("Opcion: ")
            opc = Console.ReadLine
            Console.WriteLine(vbCrLf)

            Select Case opc
                Case 1
                    Dim X As Double
                    Ingresar(X)
                    Ret(abs(X))

                Case 2
                    Dim X As Double
                    Ingresar(X)
                    Ret(acos(X))

                Case 3
                    Dim X As Double
                    Ingresar(X)
                    Ret(asin(X))

                Case 4
                    Dim X As Double
                    Ingresar(X)
                    Ret(atan(X))

                Case 5
                    Dim X, Y As Double
                    Ingresar2(X, Y)
                    Ret(atan2(X, Y))

                Case 6
                    Dim X, Y As Double
                    Ingresar2(X, Y)
                    Ret(bigmul(X, Y))

                Case 7
                    Dim X As Double
                    Ingresar(X)
                    Ret(ceiling(X))

                Case 8
                    Dim X As Double
                    Ingresar(X)
                    Ret(cos(X))

                Case 9
                    Dim X As Double
                    Ingresar(X)
                    Ret(cosh(X))

                Case 10
                    Dim X, Y As Double
                    Ingresar2(X, Y)
                    Ret(divrem(X, Y, Res))

                Case 11
                    Dim X As Double
                    Ingresar(X)
                    Ret(exp(X))

                Case 12
                    Dim X As Double
                    Ingresar(X)
                    Ret(floor(X))

                Case 13
                    Dim X, Y As Double
                    Ingresar2(X, Y)
                    Ret(ieee(X, Y))

                Case 14
                    Dim X As Double
                    Ingresar(X)
                    Ret(log(X))

                Case 15
                    Dim X As Double
                    Ingresar(X)
                    Ret(log10(X))

                Case 16
                    Dim X, Y As Double
                    Ingresar2(X, Y)
                    Ret(max(X, Y))

                Case 17
                    Dim X, Y As Double
                    Ingresar2(X, Y)
                    Ret(min(X, Y))

                Case 18
                    Dim X, Y As Double
                    Ingresar2(X, Y)
                    Ret(pow(X, Y))

                Case 19
                    Dim X, Y As Double
                    Ingresar(X)
                    Ret(round(X))

                Case 20
                    Dim X As Double
                    Ingresar(X)
                    Ret(sign(X))

                Case 21
                    Dim X As Double
                    Ingresar(X)
                    Ret(sin(X))

                Case 22
                    Dim X As Double
                    Ingresar(X)
                    Ret(sinh(X))

                Case 23
                    Dim X As Double
                    Ingresar(X)
                    Ret(sqrt(X))

                Case 24
                    Dim X As Double
                    Ingresar(X)
                    Ret(tan(X))

                Case 25
                    Dim X As Double
                    Ingresar(X)
                    Ret(tanh(X))
            End Select

            If opc = 0 Then
                ciclo = False
            End If
        Loop While ciclo = True
    End Sub

End Module
