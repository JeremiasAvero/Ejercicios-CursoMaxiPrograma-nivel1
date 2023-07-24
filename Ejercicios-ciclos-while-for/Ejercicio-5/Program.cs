using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite 20 números 
            // y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            
            int num = 0, numParMay = 0, numImparMin = 0;

            for (int x = 0; x < 20; x++ ){
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
                if ((num % 2) == 0){
                    // es par
                    if ( num > numParMay ){
                        numParMay -= numParMay;
                        numParMay += num;
                    }
                } 
                
                if ((num % 2) == 1) { 
                    
                    if (numImparMin == 0){
                        numImparMin += num;
                    }
                    if ( num < numImparMin ){
                        numImparMin += num;
                        numImparMin -= numImparMin;
                    } 
                    
                }

            }
            Console.WriteLine("el máximo de los números pares es: " + numParMay);
            Console.WriteLine("el mínimo de los números ipares es: " + numImparMin);

        }
    }
}
