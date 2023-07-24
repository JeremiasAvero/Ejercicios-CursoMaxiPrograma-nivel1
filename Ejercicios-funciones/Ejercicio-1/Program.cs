using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            int resultado = 0, n1 = 0, n2 = 0;

            Console.WriteLine("Ingresa un nùmero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un nùmero: ");
            n2 = int.Parse(Console.ReadLine());
        
            resultado = producto(n1,n2);

            Console.WriteLine("El resultado es: " + resultado);
        }

        static int producto(int n1, int n2)
        {
            int result = n1 * n2;

            return result;

        }
    }
}
