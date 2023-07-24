using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 
            // si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int n = 0, indice = 0;
            int[] numeros = new int[20];
            int[] numerosPares = new int[20];

            Console.WriteLine("primer funciòn: ingresa 1 numero: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(par(n));

            Console.WriteLine("segunda funciòn: ingresa 20 nùmeros");
            numeros[indice] = int.Parse(Console.ReadLine());
            if (par(numeros[indice]) == 1)
            {
               numerosPares[indice] = numeros[indice];
            }

            while (indice < 20)
            {
                

                numeros[indice] = int.Parse(Console.ReadLine());
                if (par(numeros[indice]) == 1)
                {
                    numerosPares[indice] = numeros[indice];
                }
                indice++;
            }
            
            indice = 0;

            while (indice < 20)
            {
                if (numerosPares[indice] != 0)
                    Console.WriteLine("Los números pares son: " + numerosPares[indice]);
                    
                indice++;
            }
             

            
            
        }

        static int par(int n)
        {
            if (n % 2 == 0)
            {
                return 1;
            } else
            {
                return 0;
            }
        }
    }   
}
