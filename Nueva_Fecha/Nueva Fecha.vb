Imports System
'2. Crear un proyecto y un m�dulo llamado �Nueva_fecha� con una funci�n que reciba un valor
'fecha y un valor entero que representa una cantidad de d�as y retorne a la fecha sumada la
'cantidad de d�as. En el m�dulo principal ingresar una fecha y la cantidad de d�as, invocar a la
'funci�n creada y mostrar el valor obtenido.
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
