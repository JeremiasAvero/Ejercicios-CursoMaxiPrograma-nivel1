using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar 4 números.
            // Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
            
            int n1,n2,n3,n4;

            Console.WriteLine("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número: ");
            n4 = int.Parse(Console.ReadLine());
            
            if (n1 > n2 && n2 > n3 && n3 > n4){
                Console.WriteLine("Los números estan ordenados de forma decreciente: ");
            } else {
                Console.WriteLine("Los números no estan ordenados de forma decreciente: ");
            }
            
        }
    }
}
