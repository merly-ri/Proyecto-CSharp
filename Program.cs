using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== TAREA PILAS (STACKS) ===");
        Console.WriteLine("1. Verificar paréntesis balanceados");
        Console.WriteLine("2. Torres de Hanoi");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Balanceador.Ejecutar();
                break;
            case 2:
                TorresDeHanoi.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}

