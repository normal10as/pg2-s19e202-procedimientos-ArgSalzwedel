Imports System

Module Program
    Sub Main()

        Dim ladobase As Int16
        Dim ladobase2 As Int16
        Dim ladoaltura As Int16

        Console.Write("ingrese base:")
        ladobase = Console.ReadLine
        Console.Write("ingrese base 2:")
        ladobase2 = Console.ReadLine
        Console.Write("ingrese lado/altura: ")
        ladoaltura = Console.ReadLine()

        Console.WriteLine("Area Cuadrado: " & areasuperficie(ladobase))
        Console.WriteLine()
        Console.WriteLine("Area Cuadrado: " & areasuperficie(ladobase, ladobase2))
        Console.WriteLine()
        Console.WriteLine("Area Cuadrado: " & areasuperficie(ladobase, ladobase2, ladoaltura))


    End Sub

    Private Function areasuperficie(base As Int16) As Integer

        Return base * base
    End Function

    Private Function areasuperficie(base As Int16, altura As Int16) As Integer

        Return base * altura
    End Function
    Private Function areasuperficie(base As Int16, base2 As Int16, altura As Int16) As Integer

        Return (base + base * altura) / 2
    End Function


End Module
