Imports System.DateTime
'Crear un proyecto y un módulo llamado “AhoraEs” que imprima la fecha y hora actual con
'sus respectivas leyendas según los siguientes requerimientos:
'• Utilizar una sub para imprimir la fecha actual.
'• Utilizar una function para obtener la hora actual.
'• Llamar a los procedimientos desde el Main
Module Program
    Sub Main()
        Dim funcionhora As Int16

        HoraACtual()

        Console.WriteLine()

        Console.Write("La hora actual es : " & actual(funcionhora))



    End Sub

    Sub HoraACtual()
        Console.Write("La Fecha actual es : " & DateTime.Now.Day & DateTime.Now.Month & DateTime.Now.Year)

    End Sub

    Public Function actual(horanow As Short) As Short

        horanow = DateTime.Now.Hour


        Return horanow

    End Function

End Module
