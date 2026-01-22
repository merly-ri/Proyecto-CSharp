using System;

namespace Tarea_Listas_Enlazadas
{
    class Program
    {
        static void Main()
        {
            ListaEnlazada lista = new ListaEnlazada();

            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            Console.WriteLine("Cantidad de elementos: " + lista.ContarElementos());

            lista.InvertirLista();
            Console.WriteLine("Lista invertida:");
            lista.Mostrar();
        }
    }
}
