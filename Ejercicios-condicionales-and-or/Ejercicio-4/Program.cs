using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa para ingresar tres números 
            // y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int n1, n2, n3;

            Console.WriteLine("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 + n2 > n2 * n3){
                Console.WriteLine("La suma de los dos primeros números es mayor a el producto del segundo con el tercero. ");
            } else {
                Console.WriteLine("La suma de los dos primeros números es menor a el producto del segundo con el tercero. ");

            }
        }

    }
}
