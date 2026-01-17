using System;

namespace Tarea_Listas_Enlazadas
{
    public class ListaEnlazada
    {
        private Nodo? cabeza; // Primer nodo de la lista (puede estar vacío)

        // Constructor de la lista
        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Método para agregar un elemento al final de la lista
        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // Método que cuenta el número de elementos de la lista
        public int ContarElementos()
        {
            int contador = 0;
            Nodo? actual = cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // Método que invierte el orden de los nodos de la lista
        public void InvertirLista()
        {
            Nodo? anterior = null;
            Nodo? actual = cabeza;
            Nodo? siguiente;

            while (actual != null)
            {
                siguiente = actual.Siguiente; // guarda el siguiente nodo
                actual.Siguiente = anterior;  // invierte el enlace
                anterior = actual;            // avanza el nodo anterior
                actual = siguiente;           // avanza al siguiente nodo
            }

            cabeza = anterior; // nueva cabeza de la lista
        }

        // Método para mostrar los elementos de la lista
        public void Mostrar()
        {
            Nodo? actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }
}

