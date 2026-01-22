using System;
using System.Collections.Generic;

// Clase que verifica si una expresión tiene paréntesis balanceados
public class Balanceador
{
    // Método que se ejecuta desde el menú principal
    public static void Ejecutar()
    {
        Console.Write("Ingrese una expresión: ");
        string expresion = Console.ReadLine();

        // Verifica si la expresión está balanceada
        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }

    // Método que valida el balanceo usando una pila
    static bool EstaBalanceada(string exp)
    {
        // Pila para almacenar los símbolos de apertura
        Stack<char> pila = new Stack<char>();

        // Recorrer cada carácter de la expresión
        foreach (char c in exp)
        {
            // Si es un símbolo de apertura, se apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es un símbolo de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, no está balanceada
                if (pila.Count == 0)
                    return false;

                // Se desapila el último símbolo
                char tope = pila.Pop();

                // Se verifica si corresponde al tipo correcto
                if (!EsPar(tope, c))
                    return false;
            }
        }

        // Si la pila está vacía al final, está balanceada
        return pila.Count == 0;
    }

    // Método que valida si los símbolos coinciden
    static bool EsPar(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}
