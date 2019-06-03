Imports System
'2. Crear un proyecto y un módulo llamado “Nueva_fecha” con una función que reciba un valor
'fecha y un valor entero que representa una cantidad de días y retorne a la fecha sumada la
'cantidad de días. En el módulo principal ingresar una fecha y la cantidad de días, invocar a la
'función creada y mostrar el valor obtenido.
Module Program
    Sub Main()
        Dim dias As Int16
        Dim nuevafecha As Date

        Console.WriteLine("Ingrese la fecha: #MM/DD/AAAA#")
        nuevafecha = Console.ReadLine()


        Console.WriteLine("Ingrese cantida de dias a sumar: ")
        dias = Console.ReadLine

        Console.Write("la nueva fecha es: " & funnuevafecha(nuevafecha, dias))



    End Sub

    Private Function funnuevafecha(cantidaddias As Date, agregardias As Int16) As Date




        Return cantidaddias.AddDays(agregardias)
    End Function


End Module
