using System;
using System.Collections.Generic;

namespace Ejercicio2_Hanoi
{
    // Clase que implementa el algoritmo de las Torres de Hanoi usando pilas
    public class TorresDeHanoi
    {
        public static void Ejecutar()
        {
            Console.Write("Número de discos: ");
            int n = int.Parse(Console.ReadLine());

            Stack<int> origen = new Stack<int>();
            Stack<int> auxiliar = new Stack<int>();
            Stack<int> destino = new Stack<int>();

            for (int i = n; i >= 1; i--)
                origen.Push(i);

            Resolver(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
        }

        static void Resolver(int n, Stack<int> o, Stack<int> d, Stack<int> a,
                             string so, string sd, string sa)
        {
            if (n == 1)
            {
                d.Push(o.Pop());
                Console.WriteLine($"Mover disco de {so} a {sd}");
                return;
            }

            Resolver(n - 1, o, a, d, so, sa, sd);

            d.Push(o.Pop());
            Console.WriteLine($"Mover disco de {so} a {sd}");

            Resolver(n - 1, a, d, o, sa, sd, so);
        }
    }
}

