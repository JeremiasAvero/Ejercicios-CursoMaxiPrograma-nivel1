using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa para ingresar cuatro números distintos y 
            // luego mostrar por pantalla el menor de ellos.

            int n1,n2,n3,n4, menor;
            
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 < n2)
                menor = n1;
            else 
                menor = n2;
            
            if (n3 < menor)
                menor = n3; 
            
            if (n4 < menor)
                menor = n4;
                

                      
            Console.WriteLine(menor);
            
        }
    }

}
