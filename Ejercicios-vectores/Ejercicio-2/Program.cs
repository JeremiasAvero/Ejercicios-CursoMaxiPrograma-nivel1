using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            int  numerosValTotal = 0, prom = 0;
            int[] numeros = new int[10];
            int[] numerosMay = new int[10];
            

            for (int x = 0; x < 10 ; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                numeros[x] = int.Parse(Console.ReadLine());
                numerosValTotal += numeros[x];


            }

            prom = numerosValTotal / 10;
            Console.WriteLine("El promedio es: " + prom);
            for(int x = 0; x < 10; x++)
            {
                if( numeros[x] > prom)
                {
                    numerosMay[x] = numeros[x];
                }
                if (numerosMay[x] != 0)
                    Console.WriteLine("Los números mayores a el promedio son: " + numerosMay[x]);
                
            }            
            
        }
    }
}
