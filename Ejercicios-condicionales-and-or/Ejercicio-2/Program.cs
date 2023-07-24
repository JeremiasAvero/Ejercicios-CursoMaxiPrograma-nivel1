using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad 
            // de litros vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            // Hacer un programa que solicite el ingreso del importe total de la venta y 
            // la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

            // solución maxi

            //  if (litros > 500)
            //      importeTotal *= 0.75F;
            //  if (litros > 300)
            //      importeTotal *= 0.85F;
            //  if (litros > 100)
            //      importeTotal *= 0.90F;
            //  
            //  Console.WriteLine(importeTotal);


            float importeTotal;
            int cantidadVendida;

            Console.WriteLine("Ingrese el importe total de la venta: ");
            importeTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            if (cantidadVendida>=100)
                if (cantidadVendida > 101 && cantidadVendida <= 300){
                    importeTotal = importeTotal * 0.90F;
                } else if( cantidadVendida >300 && cantidadVendida <=500){
                    importeTotal = importeTotal * 0.85F;
                } else {
                    importeTotal = importeTotal * 0.75F;
                }



            Console.WriteLine(importeTotal);
        }

    }
}
