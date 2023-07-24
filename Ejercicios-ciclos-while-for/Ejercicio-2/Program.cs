using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite el ingreso de 10 
            // números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int num, may = 0;

            for (int x = 0; x < 10; x++){
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if (x == 0)
                    may = num;
                else {
                    if (num > may)
                        may = num;
                }
                

            }

            Console.WriteLine("El número mayor es" + may);
        }
    }
}
