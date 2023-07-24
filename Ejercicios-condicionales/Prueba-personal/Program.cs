using System;

namespace Prueba_personal
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad > 20){
                Console.WriteLine("Edad correcta.");

            } else {
                Console.WriteLine("Eres menor de edad.");
            }
        }
    }
}
