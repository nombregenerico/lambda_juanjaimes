using System;

namespace ejercicios
{
    public sealed class DelegadoExpresionLambda
    {
        private static void Main()
        {
            // declaración de delegado genérico:
            Func<int, int, int> suma;

            // asignación de una expresión lambda:
            suma = (int a, int b) => a + b;

            Console.WriteLine("La suma de a más b es igual a {0}", suma(7, 4).ToString());
        
        }
    }
}

