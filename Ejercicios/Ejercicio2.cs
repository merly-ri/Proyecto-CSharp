using System;
using System.Collections.Generic;

public class Ejercicio2
{
    // Ejercicio 2: Yo estudio...
    public static void Ejecutar()
    {
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        Console.WriteLine("\nEjercicio 2:");
        foreach (var a in asignaturas)
        {
            Console.WriteLine($"Yo estudio {a}");
        }
    }
}
