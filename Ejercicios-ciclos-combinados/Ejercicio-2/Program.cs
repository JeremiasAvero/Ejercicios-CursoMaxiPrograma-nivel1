using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            // Se pide determinar e informar:

            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el 
            // grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int n, numTot = 0, impares = 0, grupoMax = 0, min= 0,conOrdenados = 0; 
           double porc = 0, porcMax = 0; 
           bool banderaOrdenados;

            for (int x = 0; x < 5; x++)
            {   
                banderaOrdenados = true;
                Console.WriteLine("ingrese un número: ");
                n = int.Parse(Console.ReadLine()); 
                min = n;
                while (n != 0)
                {   
                    numTot ++; 
                    if (n % 2 != 0 )
                       impares ++;

                    if (n <= min)
                        min = n;
                    else
                        banderaOrdenados = false;
                    Console.WriteLine("ingrese otro número: ");
                    n = int.Parse(Console.ReadLine()); 
                } 
                

                porc = impares * 100 / numTot ;
                if (porc > porcMax)
                    porcMax = porc;
                    grupoMax = x +1 ;

                if(banderaOrdenados)
                    conOrdenados++;
            }
            grupoMax +=1;

            
            Console.WriteLine("El grupo con el mayor porcentaje de numeros impares es:  " + grupoMax + porcMax);
            Console.WriteLine("los grupos ordenados son: " + ordenados) 
            

        }
    }
}
