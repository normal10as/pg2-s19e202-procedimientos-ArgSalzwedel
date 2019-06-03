Imports System
'6. Crear un proyecto y un módulo llamado “Acumuladora” que implemente una subrutina que
'recibe un valor Decimal y lo va acumulando. Invocar por lo menos tres veces la subrutina
'desde el main y mostrar luego de cada llamada mostrar el valor acumulado.
Module Program
    Sub Main()

        Dim numdecimal As Single

        Console.Write("Ingrese un valor decimal:")
        numdecimal = Console.ReadLine()
        Console.WriteLine()
        acumuleitor(numdecimal)
        numdecimal += numdecimal
        Console.WriteLine()
        acumuleitor(numdecimal)
        numdecimal += numdecimal
        Console.WriteLine()
        acumuleitor(numdecimal)
    End Sub

    Private Sub acumuleitor(numero As Single)


        Console.Write("acumuleitor" & numero)




    End Sub
End Module
