using System;

namespace ejercicio2
{
    class Program
        {
            static void Main(string[] args)
            {
                //Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

                int num;
                Console.WriteLine("Ingresa un número");
                num = int.Parse(Console.ReadLine());

                num = num * num * num;
                Console.WriteLine("El número elevado al cubo es: " + num);
            }       
        }
}