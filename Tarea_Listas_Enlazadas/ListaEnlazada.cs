using System;

// Clase que implementa una lista enlazada simple
namespace Tarea_Listas_Enlazadas
{
    public class ListaEnlazada
    {
        private Nodo cabeza; // Primer nodo de la lista

        // Constructor de la lista
        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Método para insertar un elemento al final de la lista
        public void Insertar(int dato)
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

        // EJERCICIO 1:
        // Método que cuenta el número de elementos de la lista enlazada
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // EJERCICIO 2:
        // Método que invierte el orden de los nodos de la lista enlazada
        public void InvertirLista()
        {
            Nodo anterior = null;
            Nodo actual = cabeza;
            Nodo siguiente;

            while (actual != null)
            {
                siguiente = actual.Siguiente; // Guarda el siguiente nodo
                actual.Siguiente = anterior;  // Invierte el enlace
                anterior = actual;             // Avanza el nodo anterior
                actual = siguiente;            // Avanza al siguiente nodo
            }

            cabeza = anterior; // Nueva cabeza de la lista
        }

        // Método para mostrar los elementos de la lista
        public void Mostrar()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }
}
