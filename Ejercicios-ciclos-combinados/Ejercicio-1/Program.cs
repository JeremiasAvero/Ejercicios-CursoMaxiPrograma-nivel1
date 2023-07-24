using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar 10 números. 
            // El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            int n, cantprim = 0, con = 0;


            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese un número: ");
                n = int.Parse(Console.ReadLine()); 
                
                for (int y = 1; y <= n; y++)
                {
                    if ( n % y == 0)
                        con += 1;
                }
                if (con == 2)
                    cantprim += 1;
                    con = 0;

            }
            Console.WriteLine("La cantidad de números primos es: " + cantprim);

        }
    }
}
