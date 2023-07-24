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

            int indice = 0, n, cant = 0, artMasVen = 0, cantMayor = 0, art10 = 0;
            int[] numArticulo = new int[15];
            int[] cantVendida = new int[15];
            int[] artSinVent = new int[15];

            while (indice < 15)
            {
                Console.WriteLine("Ingrese el número de articulo vendido: ");
                n = int.Parse(Console.ReadLine());
                numArticulo[indice] = n;

                Console.WriteLine("Ingrese la cantidad de este artículo vendidos: ");
                cant = int.Parse(Console.ReadLine());
                cantVendida[indice] = cant;
                
                if (cant > cantMayor && artMasVen != n)
                {
                    cantMayor = cant;
                    artMasVen = n;
                } else if (cant > cantMayor && artMasVen == n)
                {
                    cantMayor += cant;
                }
                if (cant == 0)
                {
                    artSinVent[indice] = n;
                }

                if (n == 10)
                {
                    art10 += cant;
                }
                indice++;


            }
            numArticulo[indice] = 0;
            indice = 0;

            Console.WriteLine("El artículo más vendido es el número: " + artMasVen + " con una cantidad de: " + cant);
            Console.WriteLine("El artículo diez vendió: " + art10);
            
            while (indice < 15) 
            {
                Console.WriteLine("Los artículos que no registraron ventas: " + artSinVent[indice]);
            }






        }
    }
}
