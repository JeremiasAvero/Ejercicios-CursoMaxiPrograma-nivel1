using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
            // que reciba un número por valor y una variable por referencia. 
            // Que analice el número y escriba variable recibida por referencia con:

            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
            int n, variable = 0;

            Console.WriteLine("Ingrese 1 número: ");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n, ref variable);
           
            Console.WriteLine("El rsultado: " + variable);
        }
        
        static void positivoNegativoCero(int n, ref int variable)
        {   
            if (n > 0)
            {
                variable = 1;
            } 
            else if ( n < 0)
            {
                variable = -1;
            } 
            else if (n == 0)
            {
                variable = 0;
            }

        }
    }
}
