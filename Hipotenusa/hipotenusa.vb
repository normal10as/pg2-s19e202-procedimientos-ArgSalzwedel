Imports System
'.Crear un proyecto y un m�dulo llamado �Hipotenusa� que implemente una funci�n que
'reciba el tama�o de los lados A y B, calcule y devuelva C (hipotenusa). Dados los lados A y
'B de un tri�ngulo rect�ngulo, seg�n el teorema de Pit�goras, el cuadrado de la hipotenusa
'(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la siguiente
'f�rmula: c� = a� + b�. Ingresar los valores por teclado y mostrar el resultado en consola. 
Module Program
    Sub Main()

        Dim ladoa, ladob As Int16
        Dim ladoc As Int16

        Console.Write("ingrese lado A")
        ladoa = Console.ReadLine
        Console.Write("ingrese lado B")
        ladob = Console.ReadLine
        ladoc = hipotenusaa(ladoa, ladob)


        Console.Write("la hipotenusa es:" & ladoc ^ 2)



    End Sub
    Private Function hipotenusaa(valora As Int16, valorb As Int16) As Integer



        Return (valora ^ 2 + valorb ^ 2)
    End Function
End Module
