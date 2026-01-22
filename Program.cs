// ===============================
// Tarea: Pilas (Stacks) en C#
// Archivo: Program.cs
// Función: Menú principal del programa
// Autora: Michelle Rivera
// ===============================

using System;
using Ejercicio1_Balanceo;
using Ejercicio2_Hanoi;

namespace Tarea_Pilas_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("   TAREA: PILAS (STACKS) EN C#");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Ejercicio 1: Balanceo de paréntesis");
                Console.WriteLine("2. Ejercicio 2: Torres de Hanoi");
                Console.WriteLine("0. Salir");
                Console.WriteLine("=================================");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Balanceador.Ejecutar();
                        break;

                    case 2:
                        Console.Clear();
                        TorresDeHanoi.Ejecutar();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 0);
        }
    }
}
