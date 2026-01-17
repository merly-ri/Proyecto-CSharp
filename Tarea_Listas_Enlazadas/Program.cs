using System;

namespace Tarea_Listas_Enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada miLista = new ListaEnlazada();

            // Agregar elementos
            miLista.Agregar(10);
            miLista.Agregar(20);
            miLista.Agregar(30);
            miLista.Agregar(40);

            Console.WriteLine("Lista original:");
            miLista.Mostrar();

            // Contar elementos
            Console.WriteLine("Número de elementos: " + miLista.ContarElementos());

            // Invertir lista
            miLista.InvertirLista();
            Console.WriteLine("Lista invertida:");
            miLista.Mostrar();
        }
    }
}
