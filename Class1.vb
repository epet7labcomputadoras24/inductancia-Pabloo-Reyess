Imports System

Module Program
    Sub Main()
        Dim xl As Double
        Dim l As Double
        Dim f As Double
        Console.WriteLine("Ingrese el valor de la inductancia:")
        l = Console.ReadLine()
        Console.WriteLine("Ingrese el valor de la frecuencia:")
        f = Console.ReadLine()
        xl = (l * (2 * 3.1415) * f)
        Console.WriteLine("Tu Xl es de:" & xl)
    End Sub
End Module
