using System;
using System.Collections.Generic;

public class Ejercicio1
{
    // Ejercicio 1: Mostrar asignaturas
    public static void Ejecutar()
    {
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        Console.WriteLine("\nEjercicio 1:");
        foreach (var a in asignaturas)
        {
            Console.WriteLine(a);
        }
    }
}
