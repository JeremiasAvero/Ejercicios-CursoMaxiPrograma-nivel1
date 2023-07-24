using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si 
            // el número es primo o cero si no lo es. Hacer un programa para ingresar números. 
            // El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            int n, ConPrimos = 0, acuPrimos = 0, promedio = 0;
            Console.WriteLine("Ingresa un número: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0 )
            {
                if (primo(n))
                {
                    ConPrimos++;
                    acuPrimos += n; 
                }
                Console.WriteLine("Ingresa un número: ");
                n = int.Parse(Console.ReadLine());
            }
            promedio = acuPrimos / ConPrimos;
            Console.WriteLine("El promedio de primos es: " + promedio);

        }

        static int primo(int n)
        {
            int cont = 0;
            for (int x = 2; x <= n; x++)
            {   
                if ( n % x == 0){
                    con++;
                } 
            }
            if (con ==2)
                return true;;
            else
                return false;
        }
    }
}
