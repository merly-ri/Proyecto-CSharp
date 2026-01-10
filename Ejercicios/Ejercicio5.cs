using System;
using System.Collections.Generic;
using System.Linq;

public class Ejercicio5
{
    // Ejercicio 5: Mayor y menor
    public static void Ejecutar()
    {
        List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

        Console.WriteLine("\nEjercicio 5:");
        Console.WriteLine("Menor: " + precios.Min());
        Console.WriteLine("Mayor: " + precios.Max());
    }
}
