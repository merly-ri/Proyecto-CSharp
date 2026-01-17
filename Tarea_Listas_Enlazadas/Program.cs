using System;

// Programa principal de la tarea de listas enlazadas
namespace Tarea_Listas_Enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Insertar elementos en la lista
            lista.Insertar(10);
            lista.Insertar(20);
            lista.Insertar(30);
            lista.Insertar(40);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            // Mostrar número de elementos (Ejercicio 1)
            Console.WriteLine("\nNúmero de elementos:");
            Console.WriteLine(lista.ContarElementos());

            // Invertir la lista (Ejercicio 2)
            Console.WriteLine("\nLista invertida:");
            lista.InvertirLista();
            lista.Mostrar();

            Console.ReadKey();
        }
    }
}

