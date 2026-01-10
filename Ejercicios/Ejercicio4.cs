using System;
using System.Collections.Generic;

public class Ejercicio4
{
    // Ejercicio 4: Números del 1 al 10 inverso
    public static void Ejecutar()
    {
        List<int> numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
            numeros.Add(i);

        numeros.Reverse();

        Console.WriteLine("\nEjercicio 4:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}
