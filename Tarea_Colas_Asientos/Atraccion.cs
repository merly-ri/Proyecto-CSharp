using System;
using System.Collections.Generic;

namespace Tarea_Cola_Asientos
{
    public class Atraccion
    {
        private Queue<Persona> cola;
        private int asientoActual;
        private int maxAsientos;

        public Atraccion(int maxAsientos)
        {
            this.maxAsientos = maxAsientos;
            cola = new Queue<Persona>();
            asientoActual = 1;
        }

        public void AgregarPersona(Persona persona)
        {
            if (asientoActual <= maxAsientos)
            {
                persona.NumeroAsiento = asientoActual;
                cola.Enqueue(persona);

                Console.WriteLine($"{persona.Nombre} asignado al asiento #{persona.NumeroAsiento}");
                asientoActual++;
            }
            else
            {
                Console.WriteLine($"{persona.Nombre}: NO hay asientos disponibles");
            }
        }

        public void MostrarReporte()
        {
            Console.WriteLine("\n--- REPORTE FINAL DE LA ATRACCIÓN ---");

            foreach (Persona p in cola)
            {
                Console.WriteLine($"Asiento {p.NumeroAsiento} - {p.Nombre}");
            }
        }
    }
}
