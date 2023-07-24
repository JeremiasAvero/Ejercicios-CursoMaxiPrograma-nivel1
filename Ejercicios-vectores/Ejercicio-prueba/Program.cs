using System;

namespace Ejercicio_prueba
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n;
            int[] numeros = new int[10];

            for (int x = 0; x < 10 ; x++)
            {
                Console.WriteLine("Ingrese una nota... ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            int acu = 0;

            for (int x = 0; x < 10 ; x++)
           {
                acu += numeros[x];
            }

            int prom = acu / 10;
            
        }
    }
}
