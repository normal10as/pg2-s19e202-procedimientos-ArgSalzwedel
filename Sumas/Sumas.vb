Imports System
'Crear un proyecto y un módulo llamado “Sumas” que implementa una función sobrecargada
'capaz de sumar dos, tres y cuatro valores de acuerdo al número de argumentos que recibe.
'Invocarla desde el módulo main probando las diferentes alternativas y mostrando los
'resultados por consola. Ej.: sumar(5, 8).Minimizar la repetición de código.
Module Program
    Sub Main()
        Dim valor1, valor2, valor3, valor4 As Int16

        Console.WriteLine("Ingrese 4 valores: ")
        valor1 = Console.ReadLine
        valor2 = Console.ReadLine
        valor3 = Console.ReadLine
        valor4 = Console.ReadLine



        Console.Write("el valor de la suma de 2 numeros es:" & sumasteishon(valor1, valor2))
        Console.WriteLine()
        Console.Write("el valor de la suma de 3 numeros es:" & sumasteishon(valor1, valor2, valor3))
        Console.WriteLine()
        Console.Write("el valor de la suma de 4 numeros es:" & sumasteishon(valor1, valor2, valor3, valor4))


    End Sub


    Private Function sumasteishon(val1 As Int16, val2 As Int16) As Integer

        Return (val1 + val2)
    End Function
    Private Function sumasteishon(val1 As Int16, val2 As Int16, val3 As Int16) As Integer

        Return (val1 + val2 + val3)
    End Function
    Private Function sumasteishon(val1 As Int16, val2 As Int16, val3 As Int16, val4 As Int16) As Integer

        Return (val1 + val2 + val3 + val4)
    End Function

End Module
