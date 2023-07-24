using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro 
            //   con los siguientes datos:
            //  - Número de Artículo (1 a 15)
            //  - Cantidad Vendida 
            //  
            //  Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //  Se pide determinar e informar:
            //  a) El número de artículo que más se vendió en total.
            //  b) Los números de artículos que no registraron ventas.
            //  c) Cuantas unidades se vendieron del número de artículo 10.

            int nroArt, cant = 0;

            int[] totalCantVendida = new int[15];
            
            for (int x = 0; x < length ; x--)
            {
                totalCantVendida[x] = 0
            }

            Console.WriteLine("Ingrese el número de articulo vendido: ");
            nroArt = int.Parse(Console.ReadLine());
            numArticulo[indice] = n;
            Console.WriteLine("Ingrese la cantidad de este artículo vendidos: ");
            cant = int.Parse(Console.ReadLine());
            cantVendida[indice] = cant;
            while (indice < 15)
            {
                totalCantVendida[nroArt - 1] += cantidad;

                Console.WriteLine("Ingrese el número de articulo vendido: ");
                n = int.Parse(Console.ReadLine());
                numArticulo[indice] = n;
                Console.WriteLine("Ingrese la cantidad de este artículo vendidos: ");
                cant = int.Parse(Console.ReadLine());
                cantVendida[indice] = cant;

            }

            int maxCantidad = totalCantVendida[0];
            int nroMaximo = 1;

            //punto b
            for(int x = 0; x < length; x++)
            {
                if(totalCantVendida[x] > maxCantidad){
                    maxCantidad = totalCantVendida[x];
                    nroArt = x + 1;
                }
            }
            Console.WriteLine("El producto más vendido es: " + nroArt + " con la cantidad de: " maxCantidad );

            //punto b
            for (int x = 0; x < length; x++)
            {
                if(totalCantVendida[x] == 0){
                    Console.WriteLine("El producto " + (x - 1) + " no tuvo ventas");
                }   
            }

            //punto b
            Console.WriteLine("La cantidad vendida del artículo 10 es: " totalCantVendida[9]);

        }
    }
}
