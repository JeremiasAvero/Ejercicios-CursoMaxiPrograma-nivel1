using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            int edad = 0, edadSum = 0, edadProm  = 0, may18 = 0;

            for (int x = 0; x < 20; x++){
                Console.WriteLine("Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());
                if (edad > 18){
                    edadSum += edad;
                    may18++;
                }

            }
            edadProm = edadSum / may18;
            Console.WriteLine("El promedio de edad de los mayores a 18 es: " + edadProm);
        }
    }
}
