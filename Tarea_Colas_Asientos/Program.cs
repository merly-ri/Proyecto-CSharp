using System;

namespace Tarea_Cola_Asientos
{
    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion(30);

            Console.WriteLine("=== ATRACCIÓN DEL PARQUE ===");
            Console.WriteLine("Asignación de asientos por orden de llegada\n");

            for (int i = 1; i <= 35; i++)
            {
                Persona persona = new Persona("Persona " + i);
                atraccion.AgregarPersona(persona);
            }

            atraccion.MostrarReporte();
            Console.ReadKey();
        }
    }
}
