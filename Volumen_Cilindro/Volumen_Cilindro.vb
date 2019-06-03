Imports System
'4. Crear un proyecto y un módulo llamado “VolumenCilindro” que implemente una función
'que lea el radio de la base y la altura de un cilindro y que calcule y devuelva el volumen. El
'volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el
'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v =
'πr²h. Ingresar los valores por teclado y mostrar el resultado en consola. 
Module Program
    Sub Main()

        Dim base, altura As Int16
        Dim volumen As Single
        Const pi As Single = 3.14159265
        Console.Write("Ingrese Base:")
        base = Console.ReadLine()
        Console.Write("Ingrese Altura: ")
        altura = Console.ReadLine()
        volumen = cilindro(pi, base, altura)
        Console.Write("El volumen del cilindro es:" & volumen)
    End Sub

    Private Function cilindro(valorpi As Single, valorbase As Single, valoraltura As Single) As Single



        Return (valorpi * valorbase ^ 2 * valoraltura)
    End Function



End Module
