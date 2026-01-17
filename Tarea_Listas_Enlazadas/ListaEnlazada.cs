using System;

namespace Tarea_Listas_Enlazadas
{
    public class ListaEnlazada
    {
        private Nodo cabeza;

        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (cabeza == null)
                cabeza = nuevo;
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        // EJERCICIO 1
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

        // EJERCICIO 2
        public void InvertirLista()
        {
            Nodo anterior = null;
            Nodo actual = cabeza;
            Nodo siguiente;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }
            cabeza = anterior;
        }

        public void Mostrar()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
    }
}
