// Clase Nodo: representa cada elemento de la lista enlazada
namespace Tarea_Listas_Enlazadas
{
    public class Nodo
    {
        public int Dato;          // Valor almacenado en el nodo
        public Nodo Siguiente;    // Referencia al siguiente nodo

        // Constructor del nodo
        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
