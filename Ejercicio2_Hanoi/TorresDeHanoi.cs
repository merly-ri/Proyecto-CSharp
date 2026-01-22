using System;
using System.Collections.Generic;

// Clase que implementa el algoritmo de las Torres de Hanoi usando pilas
public class TorresDeHanoi
{
    // Método que se ejecuta desde el menú principal
    public static void Ejecutar()
    {
        Console.Write("Número de discos: ");
        int n = int.Parse(Console.ReadLine());

        // Declaración de las tres torres como pilas
        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Se apilan los discos en la torre de origen
        for (int i = n; i >= 1; i--)
            origen.Push(i);

        // Llamada al método recursivo para resolver el problema
        Resolver(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }

    // Método recursivo que resuelve el problema de Hanoi
    static void Resolver(int n, Stack<int> o, Stack<int> d, Stack<int> a,
                         string so, string sd, string sa)
    {
        // Caso base: mover un solo disco
        if (n == 1)
        {
            d.Push(o.Pop());
            Console.WriteLine($"Mover disco de {so} a {sd}");
            return;
        }

        // Mover n-1 discos al auxiliar
        Resolver(n - 1, o, a, d, so, sa, sd);

        // Mover el disco mayor al destino
        d.Push(o.Pop());
        Console.WriteLine($"Mover disco de {so} a {sd}");

        // Mover los n-1 discos desde el auxiliar al destino
        Resolver(n - 1, a, d, o, sa, sd, so);
    }
}
