Imports System.Math
Module Module1

    Sub Ejercicio15(ByRef montoVenta As Double, ByRef totalBonif As Double)
        Console.Write("Ingrese el monto de la venta: ")
        montoVenta = Console.ReadLine

        Select Case montoVenta
            Case 0 To 999
                totalBonif = (0 * montoVenta) / 100

            Case 1000 To 4999
                totalBonif = (3 * montoVenta) / 100

            Case 5000 To 19999
                totalBonif = (5 * montoVenta) / 100

            Case 20000
                totalBonif = (8 * montoVenta) / 100
        End Select

        Console.Write("Total de bonificacion: {0}", totalBonif)
        Console.ReadLine()
    End Sub

    Sub Ejercicio17(ByRef NumEntero As Integer, ByRef NumDecenas As Integer, ByRef NumUnidades As Integer)
        Console.Write("Ingerese el numero entero: ")
        NumEntero = Console.ReadLine

        Dim cociente, residuo As Integer

        cociente = NumEntero / 10
        residuo = NumEntero - (10 * cociente)
        NumDecenas = cociente
        NumUnidades = residuo

        Console.Write("Numero de Decenas: {0}", NumDecenas)
        Console.WriteLine(vbCrLf & "Numero de Unidades: {0}", NumUnidades)
        Console.ReadLine()

    End Sub

    Sub Ejercicio18(ByRef NumEntero As Integer, ByRef Mensaje As String)
        Console.Write("Ingrese un numero entero: ")
        NumEntero = Console.ReadLine

        Dim cociente, residuo As Integer

        cociente = NumEntero / 2
        residuo = NumEntero - (cociente * 2)

        If residuo = 0 Then
            Mensaje = "El numero es par"
        Else
            Mensaje = "Es numero es impar"
        End If

        Console.WriteLine("{0}", Mensaje)
        Console.ReadLine()
    End Sub

    Sub Ejercicio19()
        Dim num As Integer = 2

        Console.WriteLine("{0}", num)

        For cont As Integer = 1 To 4
            num = num + 2
            Console.WriteLine("{0}", num)
        Next
        Console.ReadLine()
    End Sub

    Sub Ejercicio20(ByRef Salario As Double, ByRef numEmpleados As Integer, ByRef salarioTotal As Double)
        Console.Write("Numero de empleados: ")
        numEmpleados = Console.ReadLine

        Dim sumaSueldo As Double = 0

        For cont As Integer = 1 To numEmpleados
            Console.WriteLine("Ingrese su salario: ")
            Salario = Console.ReadLine

            sumaSueldo = sumaSueldo + Salario
        Next

        salarioTotal = sumaSueldo / Salario
        Console.WriteLine("El salario total es : {0}", salarioTotal)
        Console.ReadLine()
    End Sub

    Sub Ejercicio22(ByRef num1 As Integer, ByRef num2 As Integer, ByRef total As Integer)
        Console.WriteLine("Ingrese el primer numero: ")
        num1 = Console.ReadLine

        Console.WriteLine("Ingrese el segundo numero: ")
        num2 = Console.ReadLine

        total = 0

        For cont As Integer = 1 To num2
            total = total + num1
        Next
        Console.WriteLine("Producto: {0}", total)
        Console.ReadLine()
    End Sub

    Sub Ejercicio24()
        Dim S As Integer = 1

        While S < 1000
            Console.Write("{0} ", S)
            S = (Pow(S, 2)) + 1
        End While
        Console.ReadLine()
    End Sub

    Sub Ejercicio25(ByRef Letra As Char, ByRef SEMAF As Char)
        SEMAF = "V"
        While SEMAF = "V"
            Console.Write("Ingrese una letra: ")
            Letra = Console.ReadLine
            Select Case Letra
                Case "a"
                    SEMAF = "R"
                Case "e"
                    SEMAF = "R"
                Case "i"
                    SEMAF = "R"
                Case "o"
                    SEMAF = "R"
                Case "u"
                    SEMAF = "R"
                Case Else
                    SEMAF = "V"
            End Select
        End While
        Console.ReadLine()
    End Sub

    Sub Ejercicio26()
        Dim A As Integer = 0
        Dim B As Integer = 1
        Dim C As Integer = A + B

        Console.Write("{0}", A)
        Console.Write(" {0}", B)

        While C < 100000
            Console.Write(" {0}", C)
            A = B
            B = C
            C = A + B
        End While
        Console.ReadLine()
    End Sub

    Sub Ejercicio27(ByRef Num1 As Double, ByRef Num2 As Double, ByRef OP As Char, ByRef Res As Double)
        Console.Write("Ingrese el primer valor: ")
        Num1 = Console.ReadLine

        Console.Write("Ingrese el segundo valor: ")
        Num2 = Console.ReadLine

        Console.Write("Ingrese el operador: ")
        OP = Console.ReadLine

        Select Case OP
            Case "+"
                Res = Num1 + Num2

            Case "-"
                Res = Num1 - Num2

            Case "*"
                Res = Num1 * Num2

            Case "^"
                Res = Num1 ^ Num2
        End Select
        Console.Write("El Resultado es: {0}", Res)
        Console.ReadLine()
    End Sub

    Sub Ejercicio31(ByRef Num1 As Integer, ByRef Num2 As Integer, ByRef Num3 As Integer)
        Dim MSG As String = ""
        Console.Write("Ingrese el primer valor: ")
        Num1 = Console.ReadLine

        Console.Write("Ingrese el segundo valor: ")
        Num2 = Console.ReadLine

        Console.Write("Ingrese el tercer valor: ")
        Num3 = Console.ReadLine

        If Num1 ^ 2 = Num2 ^ 2 + Num3 ^ 2 Then
            MSG = "Es tema Pitagorica"
        ElseIf Num2 ^ 2 = Num3 ^ 2 + Num1 ^ 2 Then
            MSG = "Es tema Pitagorica"
        ElseIf Num3 ^ 2 = Num1 ^ 2 + Num2 ^ 2 Then
            MSG = "Es tema Pitagorica"
        Else
            MSG = "No es tema Pitagorica"
        End If
        Console.Write("{0}", MSG)
        Console.ReadLine()
    End Sub

    Sub Ejercicio32(ByRef Num As Integer, ByRef MES As String)
        Console.Write("Ingrese un numero: ")
        Num = Console.ReadLine

        Select Case Num
            Case 1 : MES = "Enero"
            Case 2 : MES = "Febrero"
            Case 3 : MES = "Marzo"
            Case 4 : MES = "Abril"
            Case 5 : MES = "Mayo"
            Case 6 : MES = "Junio"
            Case 7 : MES = "Julio"
            Case 8 : MES = "Agosto"
            Case 9 : MES = "Septiembre"
            Case 10 : MES = "Octubre"
            Case 11 : MES = "Noviembre"
            Case 12 : MES = "Diciembre"
            Case Else : MES = "No existe ese MES"
        End Select
        Console.Write("{0}", MES)
        Console.ReadLine()
    End Sub

    Sub Ejercicio33(ByRef Num As Integer)
        Dim N, K, Q, P, R As Integer
        Console.Write("Ingrese el numero: ")
        N = Console.ReadLine

        For K = 1 To N
            Q = N / K
            P = Q * K
            R = N - P

            If R = 0 Then
                Console.WriteLine(K)
            End If
        Next
        Console.ReadLine()
    End Sub

    Sub Main()
        Dim opc As Integer
        Dim ciclo As Boolean = True

        Do
            Console.Clear()
            Console.WriteLine("Seleccione ejercicio a realizar" & vbCrLf)
            Console.WriteLine("15) Ejercicio 15 - Venta" & vbCrLf & "17) Ejercicio 17 - Numero decenas")
            Console.WriteLine("18) Ejercicio 18 - Par / Impar" & vbCrLf & "19) Ejercicio 19 - Contador")
            Console.WriteLine("20) Ejercicio 20 - Salario" & vbCrLf & "22) Ejercicio 22 - Producto")
            Console.WriteLine("24) Ejercicio 24 - Serie" & vbCrLf & "25) Ejercicio 25 - Letras")
            Console.WriteLine("26) Ejercicio 26 - Fibonacci" & vbCrLf & "27) Ejercicio 27 - Operadores")
            Console.WriteLine("31) Ejercicio 31 - Pitagorica" & vbCrLf & "32) Ejercicio 32 - Meses")
            Console.WriteLine("33) Ejercicio 33 - Divisor" & vbCrLf)


            Console.WriteLine("0) Salir" & vbCrLf)

            Console.Write("Opcion: ")
            opc = Console.ReadLine
            Console.WriteLine(vbCrLf)

            Select Case opc
                Case 15
                    Dim MV, TB As Double
                    Ejercicio15(MV, TB)

                Case 17
                    Dim NE, ND, NU As Integer
                    Ejercicio17(NE, ND, NU)

                Case 18
                    Dim NE As Integer
                    Dim MSG As String = ""
                    Ejercicio18(NE, MSG)

                Case 19
                    Ejercicio19()

                Case 20
                    Dim S, ST As Double
                    Dim E As Integer
                    Ejercicio20(S, E, ST)

                Case 22
                    Dim N1, N2, T As Integer
                    Ejercicio22(N1, N2, T)

                Case 24
                    Ejercicio24()

                Case 25
                    Dim L, S As Char
                    Ejercicio25(L, S)

                Case 26
                    Ejercicio26()

                Case 27
                    Dim N1, N2, RES As Double
                    Dim OP As Char
                    Ejercicio27(N1, N2, OP, RES)

                Case 31
                    Dim N1, N2, N3 As Integer
                    Ejercicio31(N1, N2, N3)

                Case 32
                    Dim N As Integer
                    Dim MES As String = ""
                    Ejercicio32(N, MES)

                Case 33
                    Dim N As Integer
                    Ejercicio33(N)

                Case Else
                    Console.WriteLine("Adios :)")
                    Console.ReadLine()
            End Select

            If opc = 0 Then
                ciclo = False
            End If
        Loop While ciclo = True
    End Sub
End Module
