using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar cuatro números y 
            // luego mostrar por pantalla cuáles son mayores a 100.
            
            int n1,n2,n3,n4, cont = 0;
            
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > 100){
                Console.WriteLine("El primer valor: " + n1 + " es mayor a 100. ");
                cont++;
            }
            if (n2 > 100){
                Console.WriteLine("El segundo valor: " + n2 + " es mayor a 100. ");
                cont++;
            }
            if (n3 > 100){
                Console.WriteLine("El tercer valor: " + n3 + " es mayor a 100. ");
                cont++;
            }
            if (n4 > 100){
                Console.WriteLine("El cuarto valor: " + n4 + " es mayor a 100. ");
                cont++;
            }

            if (cont == 0 )
                Console.WriteLine("Ningun nùmero es mayor a 100.");

        }
    }
}
