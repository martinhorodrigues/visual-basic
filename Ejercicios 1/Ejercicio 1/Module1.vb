Imports System.Math

Module Module1

    Sub Ejercicio1(ByRef Velocidad As Decimal, ByRef Tiempo As Decimal, ByRef Distancia As Decimal)
        Console.Write("Velocidad Constante: ")
        Velocidad = Console.ReadLine

        Console.Write("Tiempo: ")
        Tiempo = Console.ReadLine

        Distancia = Velocidad * Tiempo

        Console.Write("La distancia recorrida es= {0}", Distancia)
        Console.ReadLine()
    End Sub

    Sub Ejercicio2(ByRef Nota1 As Decimal, ByRef Nota2 As Decimal, ByRef Nota3 As Decimal, ByRef Promedio As Decimal)
        Console.Write("Calificacion 1er Parcial: ")
        Nota1 = Console.ReadLine

        Console.Write("Calificacion 2do Parcial: ")
        Nota2 = Console.ReadLine

        Console.Write("Calificacion 3er Parcial: ")
        Nota3 = Console.ReadLine

        Promedio = (Nota1 + Nota2 + Nota3) / 3

        Console.Write("El promedio total es: {0}", Promedio)
        Console.ReadLine()
    End Sub

    Sub Ejercicio3(ByRef RespCorrectas As Short, ByRef RespIncorrectas As Short, ByRef RespBlanco As Short,
                   ByRef PuntajeFinal As Short)
        Console.Write("Ingrese Respuestas Correctas: ")
        RespCorrectas = Console.ReadLine

        Console.Write("Ingrese Respuestas Incorrectas: ")
        RespIncorrectas = Console.ReadLine

        Console.Write("Ingrese Respuestas en Blanco: ")
        RespBlanco = Console.ReadLine

        Dim PunResCorrecta, PunResIncorrecta As Short
        PunResCorrecta = RespCorrectas * 4
        PunResIncorrecta = RespIncorrectas * -1

        PuntajeFinal = PunResCorrecta + PunResIncorrecta

        Console.Write("El resultado final es: {0}", PuntajeFinal)
        Console.ReadLine()
    End Sub

    Sub Ejercicio4(ByRef PartidosGanados As Short, ByRef PartidosPerdidos As Short, ByRef PartidosEmpatados As Short,
                   ByRef PuntTotal As Short)
        Console.Write("Partidos Ganados: ")
        PartidosGanados = Console.ReadLine

        Console.Write("Partidos Perdidos: ")
        PartidosPerdidos = Console.ReadLine

        Console.Write("Partidos Empatados: ")
        PartidosEmpatados = Console.ReadLine

        Dim PuntPartGanados, PuntPartEmpatados As Short

        PuntPartGanados = PartidosGanados * 3
        PuntPartEmpatados = PartidosEmpatados * 1

        PuntTotal = PuntPartGanados + PuntPartEmpatados

        Console.Write("El puntaje final del equipo es: {0}", PuntTotal)
        Console.ReadLine()
    End Sub

    Sub Ejercicio5(ByRef HorasLaboradas As Short, ByRef TarifaHora As Decimal, ByRef Planilla As Decimal)
        Console.Write("Ingrese el numero de horas trabajadas: ")
        HorasLaboradas = Console.ReadLine

        Console.Write("Tarifa por hora: ")
        TarifaHora = Console.ReadLine

        Planilla = HorasLaboradas * TarifaHora

        Console.Write("El salario es: {0}", Planilla)
        Console.ReadLine()
    End Sub

    Sub Ejercicio6(ByRef LadoA As Decimal, ByRef LadoB As Decimal, ByRef LadoC As Decimal, ByRef SemPerimetro As Decimal,
                   ByRef areaTriang As Decimal)

        Console.Write("Ingrese la longitud del lado 'A': ")
        LadoA = Console.ReadLine

        Console.Write("Ingrese la longitud del lado 'B': ")
        LadoB = Console.ReadLine

        Console.Write("Ingrese la longitud del lado 'C': ")
        LadoC = Console.ReadLine

        SemPerimetro = (LadoA + LadoB + LadoC) / 2

        areaTriang = Math.Sqrt(SemPerimetro * (SemPerimetro - LadoA) * (SemPerimetro - LadoB) * (SemPerimetro - LadoC))

        Console.Write("El area del triangulo es: {0}", areaTriang)
        Console.ReadLine()
    End Sub

    Sub Ejercicio7(ByRef Gigabyte As Integer, ByRef Megabyte As Integer, ByRef Microdisco As Decimal)
        Console.Write("Ingrese el tamaño del disco duro: ")
        Gigabyte = Console.ReadLine

        Megabyte = Gigabyte * 1024
        Microdisco = Megabyte / 1.44

        Console.Write("El numero de micro discos necesarios son: {0}", Microdisco)
        Console.ReadLine()
    End Sub

    Sub Ejercicio8(ByRef AbsA As Integer, ByRef AbsB As Integer, ByRef OrdA As Integer, ByRef OrdB As Integer,
                   ByRef Distancia As Integer)
        Console.Write("Ingrese la Abcisa de A: ")
        AbsA = Console.ReadLine

        Console.Write("Ingrese la Abcisa de B: ")
        AbsB = Console.ReadLine

        Console.Write("Ingrese la Ordenada de A: ")
        OrdA = Console.ReadLine

        Console.Write("Ingrese la Ordenada de B: ")
        OrdB = Console.ReadLine

        Distancia = Math.Sqrt(Math.Pow((AbsB - AbsA), 2) + Math.Pow((OrdB - OrdA), 2))
        Console.Write("La distancia entre los puntos es: {0}", Distancia)


        Console.ReadLine()
    End Sub

    Sub Ejercicio9(ByRef ANacimiento As Integer, ByRef AActual As Integer, ByRef Edad As Integer)
        Console.Write("Año de nacimiento: ")
        ANacimiento = Console.ReadLine()

        Console.Write("Año Actual: ")
        AActual = Console.ReadLine()

        Edad = AActual - ANacimiento

        If Edad > 17 Then
            Console.Write("Usted debe inscribirse al SMO")
        Else
            Console.Write("Te salvas, no haces SMO")
        End If
        Console.ReadLine()
    End Sub

    Sub Ejercicio10(ByRef Hermano1 As Integer, ByRef Hermano2 As Integer, ByRef Diferencia As Integer)
        Console.Write("Ingrese la edad del primer hermano: ")
        Hermano1 = Console.ReadLine

        Console.Write("Ingrese la edad del segundo hermano: ")
        Hermano2 = Console.ReadLine

        If Hermano1 > Hermano2 Then
            Diferencia = Hermano1 - Hermano2
            Console.Write("El primer hermano es mayor por {0} ", Diferencia, "años")
        Else
            Diferencia = Hermano2 - Hermano1
            Console.Write("El segundo hermano es mayor por {0} ", Diferencia, "años")
        End If
        Console.ReadLine()
    End Sub

    Sub Ejercicio11(ByRef Lunes As Integer, ByRef Martes As Integer, ByRef Miercoles As Integer, ByRef Jueves As Integer,
                    ByRef Viernes As Integer, ByRef Sabado As Integer, ByRef ProdProm As Integer, ByRef MSG As String)
        Console.Write("Produccion del dia Lunes: ")
        Lunes = Console.ReadLine

        Console.Write("Produccion del dia Martes: ")
        Martes = Console.ReadLine

        Console.Write("Produccion del dia Miercoles: ")
        Miercoles = Console.ReadLine

        Console.Write("Produccion del dia Jueves: ")
        Jueves = Console.ReadLine

        Console.Write("Produccion del dia Viernes: ")
        Viernes = Console.ReadLine

        Console.Write("Produccion del dia Sabado: ")
        Sabado = Console.ReadLine

        Dim ProdTotal As Integer
        ProdTotal = (Lunes + Martes + Miercoles + Jueves + Viernes + Sabado)
        ProdProm = ProdTotal / 6

        If ProdProm >= 100 Then
            MSG = "Recivira Incentivos"
        Else
            MSG = "No Recibira Incentivos"
        End If
        Console.Write("{0}", MSG)
        Console.ReadLine()
    End Sub

    Sub Ejercicio12(ByRef Num1 As Integer, ByRef Num2 As Integer, ByRef Num3 As Integer, ByRef NumMayor As Integer)
        Console.Write("Ingrese el numero 1: ")
        Num1 = Console.ReadLine

        Console.Write("Ingrese el numero 2: ")
        Num2 = Console.ReadLine

        Console.Write("Ingrese el numero 3: ")
        Num3 = Console.ReadLine

        If Num1 > Num2 And Num1 > Num3 Then
            NumMayor = Num1
        Else
            If Num2 > Num3 Then
                NumMayor = Num2
            Else
                NumMayor = Num3
            End If
        End If
        Console.Write("El numero mayor es: {0}", NumMayor)
        Console.ReadLine()
    End Sub

    Sub Ejercicio13(ByRef Lado1 As Decimal, ByRef Lado2 As Decimal, ByRef Lado3 As Decimal, ByRef TipoTriang As String)
        Console.Write("Ingrese el lado numero 1: ")
        Lado1 = Console.ReadLine

        Console.Write("Ingrese el lado numero 2: ")
        Lado2 = Console.ReadLine

        Console.Write("Ingrese el lado numero 3: ")
        Lado3 = Console.ReadLine

        If Lado1 <> Lado2 And Lado2 <> Lado3 And Lado3 <> Lado1 Then
            TipoTriang = "Escaleno"
        Else
            If Lado1 = Lado2 And Lado2 = Lado3 Then
                TipoTriang = "Equilatero"
            Else
                TipoTriang = "Isoseles"
            End If
        End If
        Console.Write("El triangulo es de tipo, {0}", TipoTriang)
        Console.ReadLine()
    End Sub

    Sub Main()
        Dim opc As Integer
        Dim ciclo As Boolean = True

        Do
            Console.Clear()
            Console.WriteLine("Seleccione el ejercicio a realizar:" & vbCrLf)
            Console.WriteLine("1) Ejercicio 1 - Distancia Recorrida" & vbCrLf & "2) Ejercicio 2 - Promedio")
            Console.WriteLine("3) Ejercicio 3 - Respuestas Correctas" & vbCrLf & "4) Ejercicio 4 - Puntaje Partido")
            Console.WriteLine("5) Ejercicio 5 - Planilla" & vbCrLf & "6) Ejercicio 6 - Triangulo")
            Console.WriteLine("7) Ejercicio 7 - Micro discos" & vbCrLf & "8) Ejercicio 8 - Distancia de puntos")
            Console.WriteLine("9) Ejercicio 9 - Militar" & vbCrLf & "10) Ejercicio 10 - Hermanos")
            Console.WriteLine("11) Ejercicio 11 - Incentivos" & vbCrLf & "12) Ejercicio 12 - Numero Mayor")
            Console.WriteLine("13) Ejercicio 13 - Tipo de Triangulo" & vbCrLf)


            Console.WriteLine("0) Salir" & vbCrLf)

            Console.Write("Opcion: ")
            opc = Console.ReadLine
            Console.WriteLine(vbCrLf)

            Select Case opc
                Case 1
                    Dim V, T, D As Decimal
                    Ejercicio1(V, T, D)

                Case 2
                    Dim N1, N2, N3, P As Decimal
                    Ejercicio2(N1, N2, N3, P)

                Case 3
                    Dim RC, RI, RB, PF As Short
                    Ejercicio3(RC, RI, RB, PF)

                Case 4
                    Dim PG, PE, PP, PT As Short
                    Ejercicio4(PG, PE, PP, PT)

                Case 5
                    Dim HL As Short
                    Dim TH, P As Decimal
                    Ejercicio5(HL, TH, P)

                Case 6
                    Dim S, A, B, C, AT As Decimal
                    Ejercicio6(A, B, C, S, AT)

                Case 7
                    Dim GB, MB As Integer
                    Dim MD As Decimal
                    Ejercicio7(GB, MB, MD)

                Case 8
                    Dim AA, AB, OA, OB, D As Integer
                    Ejercicio8(AA, AB, OA, OB, D)

                Case 9
                    Dim AN, AA, E As Integer
                    Ejercicio9(AN, AA, E)

                Case 10
                    Dim H1, H2, D As Integer
                    Ejercicio10(H1, H2, D)

                Case 11
                    Dim L, M, MI, J, V, S, P As Integer
                    Dim MS As String = ""
                    Ejercicio11(L, M, MI, J, V, S, P, MS)

                Case 12
                    Dim N1, N2, N3, NM As Integer
                    Ejercicio12(N1, N2, N3, NM)

                Case 13
                    Dim L1, L2, L3 As Decimal
                    Dim TT As String = ""
                    Ejercicio13(L1, L2, L3, TT)

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
