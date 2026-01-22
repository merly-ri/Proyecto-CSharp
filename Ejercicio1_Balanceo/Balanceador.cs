using System;
using System.Collections.Generic;

namespace Ejercicio1_Balanceo
{
    // Clase que verifica si una expresión tiene paréntesis balanceados
    public class Balanceador
    {
        // Método que se ejecuta desde el menú principal
        public static void Ejecutar()
        {
            Console.Write("Ingrese una expresión: ");
            string expresion = Console.ReadLine();

            if (EstaBalanceada(expresion))
                Console.WriteLine("Fórmula balanceada.");
            else
                Console.WriteLine("Fórmula NO balanceada.");
        }

        // Método que valida el balanceo usando una pila
        static bool EstaBalanceada(string exp)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in exp)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0)
                        return false;

                    char tope = pila.Pop();

                    if (!EsPar(tope, c))
                        return false;
                }
            }

            return pila.Count == 0;
        }

        static bool EsPar(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }
    }
}
