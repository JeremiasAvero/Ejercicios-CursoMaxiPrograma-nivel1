using System;

namespace Ejecicio-1
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso 0: declarar variable con tipo de dato
            //tipo de dato: int: números enteros, float: números con coma, char: letra, bool: true o false
            
            int n1, n2, resultado;

            //asignar valor a variables
            //n1 = 7;
            //n2 = 9;

            //paso 1: pedir valores
            
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro un número: ");
            n2 = int.Parse(Console.ReadLine());
            
            //paso 2: realizar cálculo

            resultado = n1 + n2;

            //paso 3: emitir resultado
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
