Imports System
'5. Crear un proyecto y un módulo llamado “Potencias” que implemente una función que
'retornará la primera vez que es invocada el valor al cuadrado, la siguiente vez el valor al
'cubo y así sucesivamente. Ingresar por teclado un valor numérico y mostrar ese valor
'elevado a la 2°, 3° y 5° potencias. Por ejemplo, ingresando 3 mostrar: 9, 27 y 243. 




Module Program
    Sub Main()

        Dim numero As Int16

        Console.Write("Ingrese un valor a elevar: ")
        numero = Console.ReadLine


        Console.Write("el numero elevado al 2,3,4,5: " & potenciacion(numero))



    End Sub


    Private Function potenciacion(incremento As Int16) As String

        Dim potencia1, potencia2, potencia3, potencia4 As Int16

        potencia1 = incremento ^ 2
        potencia2 = incremento ^ 3
        potencia3 = incremento ^ 4
        potencia4 = incremento ^ 5

        Return (potencia1 & " " & potencia2 & " " & potencia3 & " " & potencia4)
    End Function
End Module
