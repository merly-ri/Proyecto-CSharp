using System;
using System.Collections.Generic;

public class Ejercicio3
{
    // Ejercicio 3: Notas por asignatura
    public static void Ejecutar()
    {
        var notas = new Dictionary<string, double>
        {
            {"Matemáticas", 8.5},
            {"Física", 9},
            {"Química", 7.8}
        };

        Console.WriteLine("\nEjercicio 3:");
        foreach (var n in notas)
        {
            Console.WriteLine($"{n.Key}: {n.Value}");
        }
    }
}
